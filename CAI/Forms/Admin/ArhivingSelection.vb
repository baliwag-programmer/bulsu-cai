Imports System.Windows.Forms

Public Class ArhivingSelection
    Private auto_list As ListviewAutomation

    Private Sub user_list_SelectedIndexChanged(sender As Object, e As EventArgs) Handles user_list.SelectedIndexChanged
        BTNArchive.Enabled = user_list.SelectedItems.Count > 0
    End Sub

    Private Sub BTNArchive_Click(sender As Object, e As EventArgs) Handles BTNArchive.Click
        Dim confirm = MsgBox("Are you sure to archive the selected batch?", MsgBoxStyle.YesNo + MsgBoxStyle.Question, "Confirm selection.")
        If confirm <> MsgBoxResult.Yes Then _
            Exit Sub

        MsgBox("Successfully archived selected batch.", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "Success")
    End Sub

    Sub FetchBatches()
        'Try

        '    auto_list = New ListviewAutomation
        '    auto_list.table = "users"
        '    auto_list.list = user_list
        '    auto_list.max_per_page = 15
        '    auto_list.btn_next = btn_next
        '    auto_list.btn_prev = btn_prev
        '    auto_list.pagination = pagination

        '    Dim tmp_cols = "id,username,concat(lastname,', ',firstname,', ',middlename) as name,DATE_FORMAT(created_at, '%a %b %d, %Y') as registered_since, dp"
        '    auto_list.custom_Sql = String.Format("SELECT {0} FROM users", tmp_cols)
        '    auto_list.pagination_custom_Sql = String.Format("SELECT {0} FROM users", "COUNT(*) AS TOTAL")

        '    Dim query_rule = String.Format(" WHERE EXISTS (SELECT * FROM role_user WHERE EXISTS (SELECT * FROM roles WHERE name = '{0}' AND role_user.role_id = roles.id) AND users.id = role_user.user_id AND users.id NOT IN ({1})) {2}", IIf(current_role = UserList.Role.Administrator, "administrator", IIf(current_role = UserList.Role.Instructor, "instructor", "student")), Auth.GetInstance.id, IIf(for_approval, "AND approved = 0", ""))
        '    auto_list.custom_Sql &= query_rule
        '    auto_list.pagination_custom_Sql &= query_rule

        '    auto_list.where = New List(Of Criteria)
        '    auto_list.orWhere = New List(Of OrCriteria)
        '    auto_list.parameters = New List(Of CommandParameter)

        '    Dim cols = New List(Of String)
        '    cols.Add("username")
        '    cols.Add("name")
        '    cols.Add("registered_since")
        '    cols.Add("dp")
        '    auto_list.columns = cols
        '    auto_list.fetch()

        'Catch ex As Exception
        '    LoggerModule.createLog(ex.ToString, LogType.Err)
        'End Try
    End Sub

End Class
