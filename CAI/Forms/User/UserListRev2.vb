Imports System.ComponentModel

Public Class UserListRev2

#Region "Private Variables"
    Private auto_list As ListviewAutomation
    Private UserDetailWrapperWidth As Integer
    Private ShowUserWrapper As Boolean = False
    Private PaginationNextLastState As Boolean
    Private PaginationPrevLastState As Boolean
    Private WithEvents UserDetailsShowServiceWorker As New System.ComponentModel.BackgroundWorker
#End Region

    Private Sub OnFormLoad(sender As Object, e As EventArgs) Handles Me.Load
        Me.UserDetailWrapperWidth = Me.UserDetailWrapper.Width

        UserDetailWrapper.Width = 0
        Me.RoleFilter.SelectedIndex = 0

        With UserDetailsShowServiceWorker
            .WorkerReportsProgress = True
        End With
    End Sub

    Private Sub OnActionClick(sender As Object, e As EventArgs) Handles ActionClose.Click, BTNEdit.Click, BTNCreate.Click, BTNTrash.Click
        If sender Is BTNCreate Then
            Dim AccountForm As New UserForm(UserForm.Mode.Create)
            Me.Hide()
            AccountForm.ShowDialog()
            Me.Show()
            FetchUsers(KeywordFilter.Text)
        End If

        If sender Is ActionClose Then
            Me.Close()
        End If

        If sender Is BTNEdit Then
            Me.Hide()
            Dim role_display = user_list.SelectedItems(0).SubItems(3).Text.ToLower
            Dim role As UserList.Role = IIf(role_display = "administrator", UserList.Role.Administrator, IIf(role_display = "instructor", UserList.Role.Instructor, UserList.Role.Student))
            Dim selected = user_list.SelectedItems(0).Text
            Dim form = New UserEdit(selected, )
            Dim result = form.ShowDialog()
            If result = Windows.Forms.DialogResult.OK Then _
                FetchUsers(KeywordFilter.Text)
            Me.Show()
        End If

        If sender Is BTNTrash Then
            DestroyData()
        End If
    End Sub

    Private Sub DestroyData()
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
            LoggerModule.createLog(Me.ToString, LogType.Err)
            LoggerModule.createLog(ex.ToString, LogType.Err)
        End Try
        FetchUsers(KeywordFilter.Text)
    End Sub

    Private Sub ShowUserDetails(show As Boolean)
        If UserDetailsShowServiceWorker.IsBusy Then Exit Sub
        ShowUserWrapper = show
        UserDetailsShowServiceWorker.RunWorkerAsync()
    End Sub

    Private Sub UserDetailsShowServiceWorker_DoWork(sender As Object, e As DoWorkEventArgs) Handles UserDetailsShowServiceWorker.DoWork

        PaginationNextLastState = btn_next.Enabled
        PaginationPrevLastState = btn_prev.Enabled

        user_list.Enabled = False
        btn_next.Enabled = False
        btn_prev.Enabled = False
        While UserDetailWrapper.Width < UserDetailWrapperWidth And ShowUserWrapper
            Application.DoEvents()
            Dim percentage = (UserDetailWrapper.Width / UserDetailWrapperWidth) * 100
            UserDetailsShowServiceWorker.ReportProgress(percentage)
            UserDetailWrapper.Width += 50
            System.Threading.Thread.Sleep(10)
        End While

        While UserDetailWrapper.Width > 0 And Not ShowUserWrapper
            Application.DoEvents()
            Dim percentage = (UserDetailWrapper.Width / UserDetailWrapperWidth) * 100
            UserDetailsShowServiceWorker.ReportProgress(percentage)
            UserDetailWrapper.Width -= 50
            System.Threading.Thread.Sleep(10)
        End While

        If ShowUserWrapper Then
            UserDetailWrapper.Width = UserDetailWrapperWidth
        Else
            UserDetailWrapper.Width = 0
        End If

        UserDetailsShowServiceWorker.ReportProgress(100)
    End Sub

    Sub FetchUsers(Optional ByRef filter As String = "")
        Try

            auto_list = New ListviewAutomation
            auto_list.table = "users"
            auto_list.list = user_list
            auto_list.max_per_page = 15
            auto_list.btn_next = btn_next
            auto_list.btn_prev = btn_prev
            auto_list.pagination = pagination

            Dim tmp_cols = "id,username,concat(lastname,', ',firstname,', ',middlename) as name,DATE_FORMAT(created_at, '%a %b %d, %Y') as registered_since, dp, (SELECT display_name FROM roles WHERE roles.id = (SELECT role_id FROM role_user WHERE user_id = users.id)) as account_type"
            auto_list.custom_Sql = String.Format("SELECT {0} FROM users", tmp_cols)
            auto_list.pagination_custom_Sql = String.Format("SELECT {0} FROM users", "COUNT(*) AS TOTAL")

            Dim FilterRole = Nothing
            If Not RoleFilter.SelectedIndex = 0 Then
                FilterRole = RoleFilter.SelectedIndex - 1
            End If

            Dim query_rule = String.Format(" WHERE EXISTS (SELECT * FROM role_user WHERE EXISTS (SELECT * FROM roles WHERE role_user.role_id = roles.id {0}) AND users.id = role_user.user_id AND users.id NOT IN ({1}))",
                IIf(FilterRole Is Nothing, "", String.Format(" AND name = '{0}'", IIf(FilterRole = 0, "administrator", IIf(FilterRole = 1, "instructor", "student")))), Auth.GetInstance.id)
            auto_list.custom_Sql &= query_rule
            auto_list.pagination_custom_Sql &= query_rule

            auto_list.where = New List(Of Criteria)
            auto_list.orWhere = New List(Of OrCriteria)
            auto_list.parameters = New List(Of CommandParameter)

            If Not filter = "" Then
                query_rule = " AND id IN (SELECT id FROM users as filter_user WHERE filter_user.username LIKE @keyword OR filter_user.lastname LIKE @keyword OR filter_user.firstname LIKE @keyword OR filter_user.middlename LIKE @keyword)"
                auto_list.custom_Sql &= query_rule
                auto_list.pagination_custom_Sql &= query_rule

                Console.WriteLine(auto_list.custom_Sql)
            End If

            Dim param = Nothing
            If Not String.IsNullOrEmpty(filter) Then
                param = New CommandParameter
                param.param = "keyword"
                param.value = filter & "%"
                auto_list.parameters.Add(param)
            End If

            Dim cols = New List(Of String)
            cols.Add("username")
            cols.Add("name")
            cols.Add("account_type")
            cols.Add("registered_since")
            cols.Add("dp")
            auto_list.columns = cols
            auto_list.fetch()

        Catch ex As Exception
            LoggerModule.createLog(Me.ToString, LogType.Err)
            LoggerModule.createLog(ex.ToString, LogType.Err)
        End Try
    End Sub

    Private Sub RoleFilter_SelectedIndexChanged(sender As Object, e As EventArgs) Handles RoleFilter.SelectedIndexChanged
        FetchUsers(KeywordFilter.Text)
    End Sub

    Private Sub ActionFilter_Click(sender As Object, e As EventArgs) Handles ActionFilter.Click
        FetchUsers(KeywordFilter.Text)
    End Sub

    Private Sub KeywordFilter_KeyPress(sender As Object, e As KeyPressEventArgs) Handles KeywordFilter.KeyPress
        FetchUsers(KeywordFilter.Text)
    End Sub

    Private Sub ResetUserDetailViewer()

        pict_user_pict.Image = My.Resources.icons8_user_96
        DisplayUsername.Text = "---"
        DisplayFullName.Text = "---"
        DisplayRegisteredSince.Text = "---"
        DisplayAccountType.Text = "---"
        LabelDisplayUsername.Text = "USERNAME :"

    End Sub

    Private Sub OnViewUser(sender As Object, e As EventArgs) Handles user_list.DoubleClick
        ShowUserDetails(True)

        Dim items = user_list.SelectedItems
        BTNEdit.Enabled = items.Count > 0 And Not Auth.GetInstance.isPreview
        'BTNTrash.Enabled = items.Count > 0 And Not Auth.GetInstance.isPreview
        BTNPreview.Enabled = items.Count > 0 And Not Auth.GetInstance.isPreview
        BTNApprovedBlocked.Enabled = items.Count > 0 And Not Auth.GetInstance.isPreview

        ResetUserDetailViewer()

        If items.Count > 0 Then
            DisplayUsername.Text = items(0).SubItems(1).Text
            DisplayFullName.Text = items(0).SubItems(2).Text
            DisplayRegisteredSince.Text = items(0).SubItems(4).Text
            DisplayAccountType.Text = items(0).SubItems(3).Text

            If DisplayAccountType.Text.ToLower() = "student" Then
                LabelDisplayUsername.Text = "STUDENT NUMBER :"
            End If

            If Not items(0).SubItems(5).Text = "" Then
                Dim avatar = ImageModule.Base64ToImage(items(0).SubItems(5).Text)
                If Not avatar Is Nothing Then _
                    pict_user_pict.Image = avatar
            End If
        End If
    End Sub

    Private Sub UserDetailsShowServiceWorker_RunWorkerCompleted(sender As Object, e As RunWorkerCompletedEventArgs) Handles UserDetailsShowServiceWorker.RunWorkerCompleted
        user_list.Enabled = True
        btn_next.Enabled = PaginationNextLastState
        btn_prev.Enabled = PaginationPrevLastState

        Dim controls = New List(Of Control)
        controls.Add(user_list)
        controls.Add(RoleFilter)
        controls.Add(KeywordFilter)

        If ShowUserWrapper Then
            For Each ctrl As Control In controls
                AddHandler ctrl.KeyDown, AddressOf CloseTheUserDetailWrapper
            Next
        Else
            For Each ctrl As Control In controls
                RemoveHandler ctrl.KeyDown, AddressOf CloseTheUserDetailWrapper
            Next
        End If
    End Sub

    Private Sub CloseTheUserDetailWrapper(sender As Object, e As KeyEventArgs)
        If e.KeyCode = Keys.Escape Then
            ShowUserDetails(False)
        End If
    End Sub

    Private Sub HideUserDetailWrapper(sender As Object, e As EventArgs) Handles ActionHideUserDetailWrapper.Click
        ShowUserDetails(False)
    End Sub

    Private Sub user_list_SelectedIndexChanged(sender As Object, e As EventArgs) Handles user_list.SelectedIndexChanged
        BTNEdit.Enabled = user_list.SelectedItems.Count > 0
        BTNTrash.Enabled = BTNEdit.Enabled

        If user_list.SelectedItems.Count = 0 Then
            ResetUserDetailViewer()
        Else
            If ShowUserWrapper Then
                OnViewUser(sender, e)
            End If
        End If
    End Sub

End Class