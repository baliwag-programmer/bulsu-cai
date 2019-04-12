Public Class UserList

    WithEvents list As ListView
    Private for_approval As Boolean
    Private log_list As ListviewAutomation
    Private auto_list As ListviewAutomation
    Private WithEvents filter_timer As Timer

    Public current_role As Role
    Public Enum Role
        Instructor
        Administrator
        Student
    End Enum
    '
    '
    ' SELECT * FROM roles WHERE name = 'administrator'
    Sub New(Optional ByRef role As Role = UserList.Role.Administrator, Optional ByRef showForApproval As Boolean = False)

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        current_role = role
        for_approval = showForApproval
        Dim title = "ADMINISTRATOR MANAGEMENT"
        Select Case current_role
            Case UserList.Role.Instructor
                title = "MONITORING"
                BTNCreate.Visible = False
                BTNEdit.Visible = False
                Button1.SetBounds(BTNApprovedBlocked.Location.X, BTNApprovedBlocked.Location.Y, BTNApprovedBlocked.Width, BTNApprovedBlocked.Height)
                for_approval = False
            Case UserList.Role.Student
                title = "STUDENT MANAGEMENT"
                user_list.Columns(1).Text = "STUDENT NUMBER"
                Label8.Text = "Student Number :"
            Case Else
                BTNPreview.Visible = False
        End Select
        Me.Heading1.Title = title
        Me.Text = title

        If for_approval Then
            BTNApprovedBlocked.Location = BTNEdit.Location
        Else
            BTNTrash.Location = BTNEdit.Location
            BTNEdit.Location = BTNCreate.Location
            BTNCreate.Location = BTNApprovedBlocked.Location
        End If

        If Auth.GetInstance().role.name = "instructor" Then
            BTNApprovedBlocked.Visible = for_approval
            BTNCreate.Visible = Not for_approval
            BTNEdit.Visible = Not for_approval
            BTNTrash.Visible = Not for_approval
            BTNPreview.Visible = Not for_approval
        End If
    End Sub

    Private Sub list_ItemSelectionChanged(ByVal sender As System.Object, ByVal e As System.Windows.Forms.ListViewItemSelectionChangedEventArgs) Handles list.ItemSelectionChanged
        Dim list As ListView = sender
        BTNEdit.Enabled = list.SelectedItems.Count > 0
        BTNTrash.Enabled = list.SelectedItems.Count > 0
    End Sub

    Private Sub dispatch(sender As System.Object, e As System.EventArgs) Handles BTNCreate.Click, BTNEdit.Click, BTNTrash.Click
        Dim button As Button = sender
        If button.Name = BTNCreate.Name Then _
            create()
        If button.Name = BTNEdit.Name Then _
            edit()
        If button.Name = BTNTrash.Name Then _
            destroy()

        user_list.SelectedItems.Clear()
        BTNEdit.Enabled = False
        BTNTrash.Enabled = False

        lbl_reigestered_since.Text = "-"
        lbl_username.Text = "-"
        lbl_user_name.Text = "-"
    End Sub


    Sub create()
        Me.Hide()
        Dim form = New UserCreate(current_role)
        Dim result = form.ShowDialog()
        If result = Windows.Forms.DialogResult.OK Then _
            fetchUsers(txt_filter.Text)
        Me.Show()
    End Sub

    Sub edit()
        Me.Hide()
        Dim selected = user_list.SelectedItems(0).Text
        Dim form = New UserEdit(selected, current_role)
        Dim result = form.ShowDialog()
        If result = Windows.Forms.DialogResult.OK Then _
            fetchUsers(txt_filter.Text)
        Me.Show()
    End Sub

    Sub destroy()
        Dim confirm = MsgBox("Are you sure to delete selected account?", MsgBoxStyle.YesNo + MsgBoxStyle.Question, "Are you sure?")
        If confirm = MsgBoxResult.No Then _
            Exit Sub

        Dim selected = user_list.SelectedItems(0).Text
        Try
            Dim command = New MySql.Data.MySqlClient.MySqlCommand("DELETE FROM users WHERE id = @id", Database.GetInstance().GetConnection())
            command.Parameters.AddWithValue("@id", selected)
            command.ExecuteNonQuery()

            MsgBox("Successfully deleted user account.", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "Success")
            user_list.SelectedItems.Clear()
        Catch ex As MySql.Data.MySqlClient.MySqlException
            Console.WriteLine("Sorry unable to delete the user.")
            Console.WriteLine(ex)
        End Try
        fetchUsers(txt_filter.Text)
    End Sub

    Sub fetchUsers(Optional ByRef filter As String = "")
        Try

            auto_list = New ListviewAutomation
            auto_list.table = "users"
            auto_list.list = user_list
            auto_list.max_per_page = 15
            auto_list.btn_next = btn_next
            auto_list.btn_prev = btn_prev
            auto_list.pagination = pagination

            Dim tmp_cols = "id,username,concat(lastname,', ',firstname,', ',middlename) as name,DATE_FORMAT(created_at, '%a %b %d, %Y') as registered_since, dp"
            auto_list.custom_Sql = String.Format("SELECT {0} FROM users", tmp_cols)
            auto_list.pagination_custom_Sql = String.Format("SELECT {0} FROM users", "COUNT(*) AS TOTAL")

            Dim query_rule = String.Format(" WHERE EXISTS (SELECT * FROM role_user WHERE EXISTS (SELECT * FROM roles WHERE name = '{0}' AND role_user.role_id = roles.id) AND users.id = role_user.user_id AND users.id NOT IN ({1})) {2}", IIf(current_role = UserList.Role.Administrator, "administrator", IIf(current_role = UserList.Role.Instructor, "instructor", "student")), Auth.GetInstance.id, IIf(for_approval, "AND approved = 0", ""))
            auto_list.custom_Sql &= query_rule
            auto_list.pagination_custom_Sql &= query_rule
            If current_role = UserList.Role.Student And Auth.GetInstance.role.name <> "administrator" Then
                query_rule = String.Format(" AND instructor_id = {0}", Auth.GetInstance.id)
                auto_list.custom_Sql &= query_rule
                auto_list.pagination_custom_Sql &= query_rule
            End If

            auto_list.where = New List(Of Criteria)
            auto_list.orWhere = New List(Of OrCriteria)
            auto_list.parameters = New List(Of CommandParameter)

            If Not filter = "" Then
                query_rule = " AND EXISTS (SELECT * FROM users as filter_user WHERE filter_user.username LIKE @keyword OR filter_user.lastname LIKE @keyword OR filter_user.firstname LIKE @keyword OR filter_user.middlename LIKE @keyword AND users.id = filter_user.id)"
                auto_list.custom_Sql &= query_rule
                auto_list.pagination_custom_Sql &= query_rule
            End If

            Dim param = Nothing
            If filter <> "" Then
                param = New CommandParameter
                param.param = "keyword"
                param.value = "%" & filter & "%"
                auto_list.parameters.Add(param)
            End If

            Dim cols = New List(Of String)
            cols.Add("username")
            cols.Add("name")
            cols.Add("registered_since")
            cols.Add("dp")
            auto_list.columns = cols
            auto_list.fetch()

        Catch ex As Exception
            Console.WriteLine("Error on fetch users")
            Console.WriteLine(ex)
        End Try
    End Sub

    Private Sub UserList_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        fetchUsers()

        If Not Auth.GetInstance.isPreview Then
            Dim logs = New LogsModel
            logs.attributes.user_id = Auth.GetInstance.id
            logs.attributes.activity = "Viewed the list of users."
            logs.attributes.type = "USER_VIEWED_LIST"
            logs.create()
        Else
            Dim logs = New LogsModel
            logs.attributes.user_id = Auth.GetInstance.previewing_auth.id
            logs.attributes.activity = "Viewed the list of users."
            logs.attributes.type = "USER_VIEWED_LIST_VIA_PREVIEW"
            logs.create()
        End If
    End Sub

    Private Sub txt_filter_KeyDown(sender As Object, e As System.Windows.Forms.KeyEventArgs) Handles txt_filter.KeyDown
        If e.KeyCode = Keys.Enter Then
            If Not filter_timer Is Nothing Then
                filter_timer.Stop()
                filter_timer.Dispose()
                filter_timer = Nothing
            End If

            fetchUsers(txt_filter.Text)
        End If
    End Sub

    Private Sub txt_filter_KeyPress(sender As System.Object, e As System.Windows.Forms.KeyPressEventArgs) Handles txt_filter.KeyPress
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

    Private Sub filter_timer_Tick(sender As Object, e As System.EventArgs) Handles filter_timer.Tick
        filter_timer.Stop()
        filter_timer.Dispose()
        filter_timer = Nothing

        fetchUsers(txt_filter.Text)
    End Sub

    Private Sub user_list_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles user_list.SelectedIndexChanged
        Dim items = user_list.SelectedItems
        BTNEdit.Enabled = items.Count > 0 And Not Auth.GetInstance.isPreview
        BTNTrash.Enabled = items.Count > 0 And Not Auth.GetInstance.isPreview
        BTNPreview.Enabled = items.Count > 0 And Not Auth.GetInstance.isPreview
        BTNApprovedBlocked.Enabled = items.Count > 0 And Not Auth.GetInstance.isPreview

        pict_user_pict.Image = My.Resources.icons8_user_96

        lbl_username.Text = "-"
        lbl_user_name.Text = "-"
        lbl_reigestered_since.Text = "-"

        If items.Count > 0 Then
            lbl_username.Text = items(0).SubItems(1).Text
            lbl_user_name.Text = items(0).SubItems(2).Text
            lbl_reigestered_since.Text = items(0).SubItems(3).Text
            If Not items(0).SubItems(4).Text = "" Then
                Dim avatar = ImageModule.Base64ToImage(items(0).SubItems(4).Text)
                If Not avatar Is Nothing Then _
                    pict_user_pict.Image = avatar
            End If
        End If
    End Sub

    Private Sub user_list_DoubleClick(sender As System.Object, e As System.EventArgs) Handles user_list.DoubleClick
        Dim items = user_list.SelectedItems
        If items.Count > 0 Then _
            BTNEdit.PerformClick()
    End Sub

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        Me.Close()
    End Sub

    Private Sub Button2_Click(sender As System.Object, e As System.EventArgs) Handles BTNPreview.Click
        If user_list.SelectedItems.Count = 0 Then _
            Exit Sub
        Dim selected = user_list.SelectedItems(0).Text
        Auth.GetInstance.previewing_auth = New Auth
        Auth.GetInstance.previewing_auth.id = Auth.GetInstance.id
        Auth.GetInstance.previewing_auth.username = Auth.GetInstance.username
        Auth.GetInstance.previewing_auth.last_name = Auth.GetInstance.last_name
        Auth.GetInstance.previewing_auth.first_name = Auth.GetInstance.first_name
        Auth.GetInstance.previewing_auth.middle_name = Auth.GetInstance.middle_name
        Auth.GetInstance.previewing_auth.instructor_id = Auth.GetInstance.instructor_id

        Try
            Dim command = New MySql.Data.MySqlClient.MySqlCommand("SELECT id, lastname, firstname, middlename, username, instructor_id, dp FROM users WHERE id = @id", Database.GetInstance.GetConnection)
            command.Parameters.AddWithValue("@id", selected)
            Dim reader = command.ExecuteReader
            If reader.Read Then

                Dim id As Integer = selected
                Dim last_name As String = IIf(reader.IsDBNull(1), "", reader.GetValue(1))
                Dim first_name As String = IIf(reader.IsDBNull(2), "", reader.GetValue(2))
                Dim middle_name As String = IIf(reader.IsDBNull(3), "", reader.GetValue(3))
                Dim username As String = IIf(reader.IsDBNull(4), "", reader.GetValue(4))
                Dim dp As String = IIf(IsDBNull(reader("dp")), "", reader("dp"))
                Dim instructor_id As String = IIf(reader.IsDBNull(5), "", reader.GetValue(5))
                reader.Close()

                Auth.GetInstance.id = id
                Auth.GetInstance.dp = dp
                Auth.GetInstance.username = username
                Auth.GetInstance.last_name = last_name
                Auth.GetInstance.first_name = first_name
                Auth.GetInstance.middle_name = middle_name
                Auth.GetInstance.instructor_id = IIf(String.IsNullOrEmpty(instructor_id), 0, instructor_id)

                Me.Hide()
                Auth.GetInstance.isPreview = True
                If Auth.GetInstance.role.name = "instructor" Then
                    Dim form = New AdminMainScreen
                    form.ShowDialog()
                End If

                If Auth.GetInstance.role.name = "student" Then
                    Dim form = New StudentMain
                    form.ShowDialog()
                End If

                Auth.GetInstance.id = Auth.GetInstance.previewing_auth.id
                Auth.GetInstance.username = Auth.GetInstance.previewing_auth.username
                Auth.GetInstance.last_name = Auth.GetInstance.previewing_auth.last_name
                Auth.GetInstance.first_name = Auth.GetInstance.previewing_auth.first_name
                Auth.GetInstance.middle_name = Auth.GetInstance.previewing_auth.middle_name
                Auth.GetInstance.instructor_id = Auth.GetInstance.previewing_auth.instructor_id
                Auth.GetInstance.isPreview = False
            Else
                reader.Close()
            End If

        Catch ex As Exception
            Console.WriteLine("Sorry unable to load data.")
            Console.WriteLine(ex)
        End Try
        Me.Close()
    End Sub

    Private Sub BTNApprovedBlocked_Click(sender As System.Object, e As System.EventArgs) Handles BTNApprovedBlocked.Click
        Dim confirm = MsgBox("Are you sure to approved this student?", MsgBoxStyle.YesNo + MsgBoxStyle.Question, "Are you sure?")
        If Not confirm = MsgBoxResult.Yes Then _
            Exit Sub

        Try
            Dim command = New MySql.Data.MySqlClient.MySqlCommand("UPDATE users SET approved = 1 WHERE id = @id", Database.GetInstance.GetConnection)
            With command.Parameters
                .AddWithValue("@id", user_list.SelectedItems(0).Text)
            End With
            command.ExecuteScalar()
            MsgBox("Successfully approved student.", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "Success.")
        Catch ex As Exception
            Console.WriteLine("Unable to approved student data.")
            Console.WriteLine(ex)
        End Try
        user_list.SelectedItems.Clear()
        fetchUsers()
    End Sub
End Class