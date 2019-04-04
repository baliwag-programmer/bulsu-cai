Public Class TestList

    Private student_taken_test As List(Of String)
    Private auto_list As ListviewAutomation
    Private WithEvents filter_timer As Timer ' Search timer

    Private Sub TestList_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        ComboType.SelectedItem = ComboType.Items(0)

        If Auth.GetInstance.role.name = "student" Or Auth.GetInstance.isPreview Then
            BTNCreate.Visible = False
            BTNEdit.Visible = False
            BTNTrash.Visible = False
            BTNLocker.Visible = False
            BTNStudentResults.Visible = False

            Button1.Location = BTNTrash.Location
        End If
    End Sub

    Sub fetchStudentTakenTest()
        Try
            Dim command = New MySql.Data.MySqlClient.MySqlCommand("SELECT DISTINCT(test_id) FROM users_tests WHERE user_id = @id", Database.GetInstance.GetConnection)
            Dim reader = command.ExecuteReader
            While reader.Read
                student_taken_test.Add(reader.GetValue(0).ToString())
            End While
            reader.Close()
        Catch ex As Exception
            Console.WriteLine("Sorry unable to fetchStudent taken test")
            Console.WriteLine(ex)
        End Try
    End Sub

    Sub fetchTest(Optional ByRef filter As String = "")
        test_list.Items.Clear()

        auto_list = New ListviewAutomation
        auto_list.table = "tests"
        auto_list.list = test_list
        auto_list.max_per_page = 15
        auto_list.btn_next = lesson_next
        auto_list.btn_prev = lesson_prev
        auto_list.pagination = lesson_page
        auto_list.custom_Sql = String.Format("SELECT tests.id, tests.title, tests.description, DATE_FORMAT(tests.created_at, '%a %b %d, %Y') as created_at, tests.type, IF(is_locked = 1, 'LOCKED', 'UNLOCKED') as locked_display, CONCAT(LPAD(duration_hour, 2, '0'), ':', LPAD(duration_minute, 2, '0')) as duration, COUNT(questions.id) as total_items, is_locked FROM tests", Auth.GetInstance.id)
        auto_list.where = New List(Of Criteria)
        auto_list.orWhere = New List(Of OrCriteria)
        auto_list.parameters = New List(Of CommandParameter)

        auto_list.LeftOuterJoiner = New List(Of LeftOuterJoin)
        auto_list.GroupBy = New GroupBy
        auto_list.GroupBy.columns.Add("questions.test_id")

        Dim join_question = New LeftOuterJoin
        join_question.table = "questions"
        join_question.Jointer = New List(Of Criteria)
        Dim join_question_critera = New Criteria
        join_question_critera.column = "questions.test_id"
        join_question_critera.key = "tests.id"
        join_question.Jointer.Add(join_question_critera)
        auto_list.LeftOuterJoiner.Add(join_question)

        If filter <> "" Then
            Dim criteria = New OrCriteria
            criteria.column = "tests.title"
            criteria.criteria = "LIKE"
            criteria.key = "keyword"
            auto_list.orWhere.Add(criteria)
        End If

        Dim where_criteria = New Criteria
        where_criteria.column = "instructor_id"
        where_criteria.key = "instructor_id"
        auto_list.where.Add(where_criteria)

        If ComboType.Text.ToLower <> "all" Then
            where_criteria = New Criteria
            where_criteria.column = "tests.type"
            where_criteria.key = "type"
            auto_list.where.Add(where_criteria)
        End If

        Dim param = Nothing
        If filter <> "" Then
            param = New CommandParameter
            param.param = "keyword"
            param.value = "%" & filter & "%"
            auto_list.parameters.Add(param)
        End If

        If ComboType.Text.ToLower <> "all" Then
            param = New CommandParameter
            param.param = "type"
            param.value = ComboType.Text
            auto_list.parameters.Add(param)
        End If

        param = New CommandParameter
        param.param = "instructor_id"
        param.value = IIf(Auth.GetInstance.role.name = "instructor", Auth.GetInstance.id, Auth.GetInstance.instructor_id)
        auto_list.parameters.Add(param)

        Dim cols = New List(Of String)
        cols.Add("title")
        cols.Add("description")
        cols.Add("type")
        cols.Add("locked_display")
        cols.Add("duration")
        cols.Add("total_items")
        cols.Add("created_at")
        cols.Add("is_locked")
        auto_list.columns = cols
        auto_list.fetch()

        Console.WriteLine(auto_list.getGrammar())
    End Sub

    Sub destroy()
        Try
            Dim items = test_list.SelectedItems
            If items.Count > 0 Then
                For Each item As ListViewItem In items
                    Dim id = item.Text
                    Dim command = New MySql.Data.MySqlClient.MySqlCommand("DELETE FROM tests WHERE id = @id", Database.GetInstance.GetConnection())
                    command.Parameters.AddWithValue("@id", id)
                    command.ExecuteNonQuery()
                Next
                MsgBox("Successfully deleted test.", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "Success")

                fetchTest(txt_filter.Text)
            End If
        Catch ex As Exception
            Console.WriteLine("Sorry unable to destroy data")
            Console.WriteLine(ex)
        End Try
    End Sub

    Private Sub BTNCreate_Click(sender As System.Object, e As System.EventArgs) Handles BTNCreate.Click
        Dim form = New TestForm
        Me.Hide()
        Dim result = form.ShowDialog()

        If result = Windows.Forms.DialogResult.OK Then _
            fetchTest(txt_filter.Text)
        Me.Show()

        BTNEdit.Enabled = False
        BTNLocker.Enabled = False
    End Sub

    Private Sub txt_filter_KeyDown(sender As Object, e As System.Windows.Forms.KeyEventArgs) Handles txt_filter.KeyDown
        If e.KeyCode = Keys.Enter Then
            If Not filter_timer Is Nothing Then
                filter_timer.Stop()
                filter_timer.Dispose()
                filter_timer = Nothing
            End If

            fetchTest(txt_filter.Text)
        End If
    End Sub

    Private Sub txt_filter_KeyPress(sender As Object, e As System.Windows.Forms.KeyPressEventArgs) Handles txt_filter.KeyPress
        If Not filter_timer Is Nothing Then
            filter_timer.Stop()
            filter_timer.Dispose()
            filter_timer = Nothing
        End If
    End Sub

    Private Sub txt_filter_KeyUp(sender As Object, e As System.Windows.Forms.KeyEventArgs) Handles txt_filter.KeyUp
        filter_timer = New Timer
        filter_timer.Interval = 1000
        filter_timer.Start()
    End Sub

    Private Sub BTNTrash_Click(sender As System.Object, e As System.EventArgs) Handles BTNTrash.Click
        Dim message = "Are you sure to delete this data?"
        If test_list.SelectedItems.Count > 1 Then _
            message = String.Format("Are you sure to delete `{0}` data", test_list.SelectedItems.Count)
        Dim response = MsgBox(Message, MsgBoxStyle.YesNo + MsgBoxStyle.Question, "Are you sure?")
        If response = MsgBoxResult.Yes Then _
            destroy()

        test_list.SelectedItems.Clear()
        BTNLocker.Enabled = False
        BTNEdit.Enabled = False
        BTNTrash.Enabled = False
    End Sub

    Private Sub test_list_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles test_list.SelectedIndexChanged
        BTNLocker.Enabled = test_list.SelectedItems.Count > 0
        BTNEdit.Enabled = test_list.SelectedItems.Count > 0
        BTNTrash.Enabled = test_list.SelectedItems.Count > 0
        BTNStudentResults.Enabled = test_list.SelectedItems.Count > 0
        If test_list.SelectedItems.Count = 0 Then _
                   Exit Sub

        Dim item = test_list.SelectedItems(0)
        BTNLocker.Text = IIf(item.SubItems(item.SubItems.Count - 1).Text = "1", "UN-LOCK", "LOCK")
        BTNLocker.Image = IIf(item.SubItems(item.SubItems.Count - 1).Text = "1", My.Resources.icons8_padlock_48, My.Resources.icons8_lock_48)
    End Sub

    Private Sub BTNLocker_Click(sender As System.Object, e As System.EventArgs) Handles BTNLocker.Click
        Dim item = test_list.SelectedItems(0)
        Dim selected = item.Text
        Dim method = "lock"
        If item.SubItems(item.SubItems.Count - 1).Text = "1" Then _
            method = "unlock"

        Dim confirm = MsgBox(String.Format("Are you sure to {0} this test?", method), MsgBoxStyle.YesNo + MsgBoxStyle.Question, "Are you sure?")
        If Not confirm = MsgBoxResult.Yes Then _
            Exit Sub
        Try
            Dim command = New MySql.Data.MySqlClient.MySqlCommand("UPDATE tests SET is_locked = @method WHERE id = @id", Database.GetInstance.GetConnection)
            With command.Parameters
                .AddWithValue("@id", selected)
                .AddWithValue("@method", IIf(method = "lock", 1, 0))
            End With
            command.ExecuteNonQuery()
            MsgBox(String.Format("Successfully {0} the test.", method), MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "Success")
            fetchTest()
        Catch ex As Exception
            Console.WriteLine(String.Format("Sorry unable to {0} the test.", method))
            Console.WriteLine(ex)
        End Try

        test_list.SelectedItems.Clear()
    End Sub

    Private Sub BTNEdit_Click(sender As System.Object, e As System.EventArgs) Handles BTNEdit.Click
        If test_list.SelectedItems.Count = 0 Then _
            Exit Sub
        Dim form = New TestForm(test_list.SelectedItems(0).Text)
        Me.Hide()
        form.ShowDialog()
        Me.Show()
        test_list.SelectedItems.Clear()
        fetchTest(txt_filter.Text)
    End Sub

    Private Sub test_list_DoubleClick(sender As System.Object, e As System.EventArgs) Handles test_list.DoubleClick
        If test_list.SelectedItems.Count = 0 Then _
            Exit Sub

        If BTNEdit.Visible And Auth.GetInstance.role.name <> "student" Then _
            BTNEdit_Click(BTNEdit, New System.EventArgs)
        If Not BTNEdit.Visible And Auth.GetInstance.isPreview Then _
            BTNStudentResults_Click(BTNStudentResults, New System.EventArgs)
        If Not BTNEdit.Visible And Not Auth.GetInstance.isPreview Then
            Dim form = New TestTaker(test_list.SelectedItems(0).Text)
            Me.Hide()
            form.ShowDialog()
            Me.Show()
        End If
    End Sub

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        Me.Close()
    End Sub

    Private Sub ComboType_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles ComboType.SelectedIndexChanged
        fetchTest(txt_filter.Text)
    End Sub

    Private Sub BTNStudentResults_Click(sender As System.Object, e As System.EventArgs) Handles BTNStudentResults.Click
        If test_list.SelectedItems.Count = 0 Then _
            Exit Sub
        Dim form = New InstructorStudentResultViewer(test_list.SelectedItems(0).Text)
        Me.Hide()
        form.ShowDialog()
        Me.Show()
    End Sub
End Class