Imports System.Data.DataSet
Imports System.Windows.Forms
Imports MySql.Data.MySqlClient
Public Class LessonList
    Dim oDocument As Object
    WithEvents list As ListView
    WithEvents filter_timer As Timer
    WithEvents not_found_timer As Timer
    Private auto_list As ListviewAutomation
    Private current_file_path As String = ""

    Sub New()
        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        'DbList1.custom_sql = String.Format("SELECT id, title, description, created_at FROM lessons WHERE instructor_id IN ({0})", Auth.GetInstance.id)
        'list = DbList1.list
    End Sub

    Sub create()
        Dim dialog = New LessonCreate
        Me.Hide()
        Dim result = dialog.ShowDialog()
        If result = DialogResult.OK Then _
            fetchLessons()
        Me.Show()
    End Sub

    Sub destroy()
        Dim selected = lesson_list.SelectedItems(0).Text
        Try
            Dim command = New MySql.Data.MySqlClient.MySqlCommand("DELETE FROM lessons WHERE id = @id", Database.GetInstance().GetConnection())
            command.Parameters.AddWithValue("@id", selected)
            command.ExecuteNonQuery()

            Dim logs = New LogsModel
            logs.attributes.activity = String.Format("Lesson `{0} - {1}` deleted.", selected, lesson_list.SelectedItems(0).SubItems(1).Text)
            logs.attributes.user_id = Auth.GetInstance.id
            logs.attributes.type = String.Format("LESSON_DELETED")
            logs.create()

            MsgBox("Successfully deleted lesson.", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "Success")
            lesson_list.SelectedItems.Clear()
        Catch ex As MySql.Data.MySqlClient.MySqlException
            Console.WriteLine("Unable to destroy data")
            Console.WriteLine(ex)
        End Try
        fetchLessons()
    End Sub

    Sub edit()
        Dim selected = lesson_list.SelectedItems(0).Text
        Dim dialog = New LessonCreate(selected)
        Me.Hide()
        Dim result = dialog.ShowDialog
        Me.Show()
        If result = DialogResult.OK Then _
            fetchLessons(txt_filter.Text)
    End Sub

    Sub trash()
        Dim confirm = MsgBox("Deleting lesson", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "Are you sure?")
        If confirm = MsgBoxResult.Yes Then _
            destroy()
    End Sub

    Sub lockUnlock()
        Dim item = lesson_list.SelectedItems(0)
        Dim selected = item.Text
        Dim method = "lock"
        If item.SubItems(item.SubItems.Count - 2).Text = "1" Then _
            method = "unlock"

        Dim confirm = MsgBox(String.Format("Are you sure to {0} this lesson?", method), MsgBoxStyle.YesNo + MsgBoxStyle.Question, "Are you sure?")
        If Not confirm = MsgBoxResult.Yes Then _
            Exit Sub
        Try
            Dim command = New MySql.Data.MySqlClient.MySqlCommand("UPDATE lessons SET is_locked = @method WHERE id = @id", Database.GetInstance.GetConnection)
            With command.Parameters
                .AddWithValue("@id", selected)
                .AddWithValue("@method", IIf(method = "lock", 1, 0))
            End With
            command.ExecuteNonQuery()

            Dim logs = New LogsModel
            logs.attributes.activity = String.Format("Set {0} lesson `{1} - {2}`", method, id, item.SubItems(1).Text)
            logs.attributes.user_id = Auth.GetInstance.id
            logs.attributes.type = String.Format("LESSON_{0}", method.ToUpper())
            logs.create()

            MsgBox(String.Format("Successfully {0} the lesson.", method), MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "Success")
            fetchLessons()
        Catch ex As Exception
            Console.WriteLine(String.Format("Sorry unable to {0} the lesson.", method))
            Console.WriteLine(ex)
        End Try
    End Sub

    Private Sub dispatch(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BTNTrash.Click, BTNEdit.Click, BTNCreate.Click, BTNLocker.Click
        Dim dispatcher As Button = sender
        If dispatcher.Name = BTNCreate.Name Then _
            create()
        If dispatcher.Name = BTNEdit.Name Then _
            edit()
        If dispatcher.Name = BTNTrash.Name Then _
            trash()
        If dispatcher.Name = BTNLocker.Name Then _
            lockUnlock()

        lesson_list.SelectedItems.Clear()
        BTNEdit.Enabled = False
        BTNTrash.Enabled = False
        BTNLocker.Enabled = False
    End Sub

    Private Sub LessonList_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        fetchLessons()

        not_found_timer = New Timer
        not_found_timer.Interval = 500
        not_found_timer.Start()

        BTNCreate.Enabled = Not Auth.GetInstance.isPreview
    End Sub

    Sub fetchLessons(Optional ByRef filter As String = "")
        auto_list = New ListviewAutomation
        auto_list.table = "lessons"
        auto_list.list = lesson_list
        auto_list.max_per_page = 2
        auto_list.btn_next = lesson_next
        auto_list.btn_prev = lesson_prev
        auto_list.pagination = lesson_page
        auto_list.custom_Sql = String.Format("SELECT id, title, description, DATE_FORMAT(created_at, '%a %b %d, %Y') as created_at, is_locked, attachment FROM lessons", Auth.GetInstance.id)
        auto_list.where = New List(Of Criteria)
        auto_list.orWhere = New List(Of OrCriteria)
        auto_list.parameters = New List(Of CommandParameter)

        If filter <> "" Then
            Dim criteria = New OrCriteria
            criteria.column = "title"
            criteria.criteria = "LIKE"
            criteria.key = "keyword"
            auto_list.orWhere.Add(criteria)
        End If

        Dim where_criteria = New Criteria
        where_criteria.column = "instructor_id"
        where_criteria.key = "instructor_id"
        auto_list.where.Add(where_criteria)

        Dim param = Nothing
        If filter <> "" Then
            param = New CommandParameter
            param.param = "keyword"
            param.value = "%" & txt_filter.Text & "%"
            auto_list.parameters.Add(param)
        End If

        param = New CommandParameter
        param.param = "instructor_id"
        param.value = Auth.GetInstance.id
        auto_list.parameters.Add(param)

        Dim cols = New List(Of String)
        cols.Add("title")
        cols.Add("description")
        cols.Add("created_at")
        cols.Add("is_locked")
        cols.Add("attachment")

        auto_list.columns = cols
        auto_list.fetch()
    End Sub

    Sub fetchTest(Optional ByRef filter As String = "")
        auto_list = New ListviewAutomation
        auto_list.table = "tests"
        auto_list.list = lesson_list
        auto_list.max_per_page = 2
        auto_list.btn_next = lesson_next
        auto_list.btn_prev = lesson_prev
        auto_list.pagination = lesson_page
        auto_list.custom_Sql = String.Format("SELECT id, title, description, DATE_FORMAT(created_at, '%a %b %d, %Y') as created_at, is_locked FROM tests", Auth.GetInstance.id)
        auto_list.where = New List(Of Criteria)
        auto_list.orWhere = New List(Of OrCriteria)
        auto_list.parameters = New List(Of CommandParameter)

        If filter <> "" Then
            Dim criteria = New OrCriteria
            criteria.column = "title"
            criteria.criteria = "LIKE"
            criteria.key = "keyword"
            auto_list.orWhere.Add(criteria)
        End If

        Dim where_criteria = New Criteria
        where_criteria.column = "instructor_id"
        where_criteria.key = "instructor_id"
        auto_list.where.Add(where_criteria)

        Dim param = Nothing
        If filter <> "" Then
            param = New CommandParameter
            param.param = "keyword"
            param.value = "%" & txt_filter.Text & "%"
            auto_list.parameters.Add(param)
        End If

        param = New CommandParameter
        param.param = "instructor_id"
        param.value = Auth.GetInstance.id
        auto_list.parameters.Add(param)

        Dim cols = New List(Of String)
        cols.Add("title")
        cols.Add("description")
        cols.Add("created_at")
        auto_list.columns = cols
        auto_list.fetch()
    End Sub

    Private Sub lesson_list_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles lesson_list.SelectedIndexChanged
        BTNEdit.Enabled = lesson_list.SelectedItems.Count > 0 And Not Auth.GetInstance.isPreview
        BTNTrash.Enabled = lesson_list.SelectedItems.Count > 0 And Not Auth.GetInstance.isPreview
        BTNLocker.Enabled = lesson_list.SelectedItems.Count > 0 And Not Auth.GetInstance.isPreview

        current_file_path = ""

        If lesson_list.SelectedItems.Count > 0 Then
            Dim item = lesson_list.SelectedItems(0)
            lbl_lesson_title.Text = item.SubItems(1).Text
            txt_lesson_description.Text = item.SubItems(2).Text
            BTNLocker.Text = IIf(item.SubItems(item.SubItems.Count - 2).Text = "1", "Unlock", "Lock")
            BTNLocker.Image = IIf(item.SubItems(item.SubItems.Count - 2).Text = "1", My.Resources.icons8_padlock_48, My.Resources.icons8_lock_48)

            If item.SubItems(item.SubItems.Count - 1).Text = "" Then _
                Exit Sub

            current_file_path = String.Format("{0}/{1}", LessonModel.attachment_path, item.SubItems(item.SubItems.Count - 1).Text)
            AttachmentViewer1.SelectedFile = current_file_path
        End If

    End Sub

    Private Sub TextBox1_KeyDown(sender As System.Object, e As System.Windows.Forms.KeyEventArgs) Handles txt_filter.KeyDown
        If e.KeyCode = Keys.Enter Then _
            fetchLessons(txt_filter.Text)
    End Sub

    Private Sub txt_filter_KeyPress(sender As System.Object, e As System.Windows.Forms.KeyPressEventArgs) Handles txt_filter.KeyPress
        If Not filter_timer Is Nothing Then
            filter_timer.Stop()
            filter_timer.Dispose()
        End If
    End Sub

    Private Sub txt_filter_KeyUp(sender As Object, e As System.Windows.Forms.KeyEventArgs) Handles txt_filter.KeyUp
        filter_timer = New Timer
        filter_timer.Interval = 1000
        filter_timer.Start()
    End Sub

    Private Sub filter_timer_Tick(sender As Object, e As System.EventArgs) Handles filter_timer.Tick
        filter_timer.Stop()
        filter_timer.Dispose()
        fetchLessons(txt_filter.Text)
    End Sub

    Private Sub lesson_list_DoubleClick(sender As System.Object, e As System.EventArgs) Handles lesson_list.DoubleClick
        If lesson_list.SelectedItems.Count > 0 Then _
            BTNEdit.PerformClick()
    End Sub

    Private Sub not_found_timer_Tick(sender As Object, e As System.EventArgs) Handles not_found_timer.Tick
        'If current_file_path = "" Then _
        '    attachment_status.Visible = Not attachment_status.Visible
    End Sub

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        Me.Close()
    End Sub
End Class
