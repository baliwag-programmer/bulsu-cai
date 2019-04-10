Public Class ActivityLogs
    Private log_list As ListviewAutomation
    Private user_log_list As ListviewAutomation
    Private Sub ActivityLogs_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        fetchLogs()
    End Sub

    Sub fetchLogs()
        Try
            log_list = New ListviewAutomation
            log_list.table = "user_logs"
            log_list.list = list_log
            log_list.max_per_page = 15
            log_list.btn_next = logs_btn_next
            log_list.btn_prev = logs_btn_prev
            log_list.pagination = logs_pagination
            log_list.custom_Sql = "SELECT user_logs.id,user_logs.activity,users.username as username,concat(users.lastname, ', ', users.firstname, ', ', users.middlename) as name,DATE_FORMAT(user_logs.created_at, '%a %b %d, %Y @ %h:%i %p') as activity_date,DATE_FORMAT(users.created_at, '%a %b %d, %Y') as registered_date, users.id as user_id, users.dp FROM user_logs"
            log_list.custom_Sql &= " LEFT OUTER JOIN users ON users.id = user_logs.user_id"

            log_list.OrderBy = New OrderBy
            log_list.where = New List(Of Criteria)
            log_list.parameters = New List(Of CommandParameter)

            log_list.OrderBy.columns.Add("user_logs.created_at")
            log_list.OrderBy.type = "DESC"

            Dim cols = New List(Of String)
            cols.Add("activity")
            cols.Add("username")
            cols.Add("name")
            cols.Add("activity_date")
            cols.Add("registered_date")
            cols.Add("user_id")
            cols.Add("dp")
            log_list.columns = cols
            log_list.fetch()

            Console.WriteLine(log_list.getGrammar)

        Catch ex As Exception
            Console.WriteLine("Sorry error during the fetch logs.")
            Console.WriteLine(ex)
        End Try
    End Sub

    Sub fetchUserLogs(ByRef user_id As Integer)
        Try
            user_log_list = New ListviewAutomation
            user_log_list.table = "user_logs"
            user_log_list.list = list_recent_logs
            user_log_list.max_per_page = 15
            user_log_list.btn_next = recent_btn_next
            user_log_list.btn_prev = recent_btn_prev
            user_log_list.pagination = recent_pagination
            user_log_list.custom_Sql = "SELECT id,activity,DATE_FORMAT(created_at, '%a %b %d, %Y @ %h:%i %p') as activity_date FROM user_logs"

            user_log_list.OrderBy = New OrderBy
            user_log_list.where = New List(Of Criteria)
            user_log_list.parameters = New List(Of CommandParameter)

            user_log_list.OrderBy.columns.Add("created_at")
            user_log_list.OrderBy.type = "DESC"

            Dim where_criteria = New Criteria
            where_criteria.column = "user_id"
            where_criteria.key = "user_id"
            user_log_list.where.Add(where_criteria)

            Dim param = New CommandParameter
            param.param = "user_id"
            param.value = user_id
            user_log_list.parameters.Add(param)

            Dim cols = New List(Of String)
            cols.Add("activity")
            cols.Add("activity_date")
            user_log_list.columns = cols
            user_log_list.fetch()

        Catch ex As Exception
            Console.WriteLine("Sorry error during the fetch logs.")
            Console.WriteLine(ex)
        End Try
    End Sub

    Private Sub list_log_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles list_log.SelectedIndexChanged
        Try
            Dim items = list_log.SelectedItems
            If items.Count > 0 Then
                lbl_user_name.Text = items(0).SubItems(3).Text
                lbl_username.Text = items(0).SubItems(2).Text
                lbl_reigestered_since.Text = items(0).SubItems(items(0).SubItems.Count - 3).Text
                Dim dp = items(0).SubItems(items(0).SubItems.Count - 1).Text
                If Not dp = "" Then _
                    pict_user_pict.Image = ImageModule.Base64ToImage(dp)
                If dp = "" Then _
                    pict_user_pict.Image = My.Resources.icons8_user_96

                ' TODO fetch the recent activities
                list_recent_logs.Items.Clear()
                fetchUserLogs(items(0).SubItems(items(0).SubItems.Count - 2).Text)
            End If
        Catch ex As Exception
            LoggerModule.createLog(Me.ToString, LogType.Err)
            LoggerModule.createLog(ex.ToString, LogType.Err)
        End Try
    End Sub

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        Me.Close()
    End Sub
End Class