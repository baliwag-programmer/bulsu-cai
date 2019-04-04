Public Class StudentLessonViewer

    Private auto_list As ListviewAutomation
    Private current_file_path As String = ""
    Private WithEvents effect_timer As Timer

    Private Sub StudentLessonViewer_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        effect_timer = New Timer
        effect_timer.Interval = 500
        effect_timer.Start()
        fetchLessons()
        fetchLessonsList()
    End Sub

    Sub fetchLessons()

        Try
            Dim command = New MySql.Data.MySqlClient.MySqlCommand("SELECT COUNT(*) as TOTAL FROM lessons WHERE instructor_id = @id", Database.GetInstance.GetConnection)
            With command.Parameters
                .AddWithValue("@id", Auth.GetInstance.instructor_id)
            End With
            If command.ExecuteScalar() = 0 Then
                lbl_indicator.Text = "No Available Lessons"
            End If

            command = New MySql.Data.MySqlClient.MySqlCommand("SELECT COUNT(*) as TOTAL FROM lessons WHERE instructor_id = @id AND is_locked = 0", Database.GetInstance.GetConnection)
            With command.Parameters
                .AddWithValue("@id", Auth.GetInstance.instructor_id)
            End With
            lock_container.Visible = command.ExecuteScalar() = 0
        Catch ex As Exception
            Console.WriteLine("Sorry unable to fetch lessons.")
            Console.WriteLine(ex)
        End Try

    End Sub

    Sub fetchLessonsList(Optional ByRef filter As String = "")
        auto_list = New ListviewAutomation
        auto_list.table = "lessons"
        auto_list.list = lesson_list
        auto_list.max_per_page = 2
        auto_list.btn_next = lesson_next
        auto_list.btn_prev = lesson_prev
        auto_list.pagination = lesson_page
        auto_list.custom_Sql = String.Format("SELECT id, title, description, DATE_FORMAT(created_at, '%a %b %d, %Y') as created_at,attachment FROM lessons", Auth.GetInstance.id)
        auto_list.where = New List(Of Criteria)
        auto_list.orWhere = New List(Of OrCriteria)
        auto_list.parameters = New List(Of CommandParameter)

        'If filter <> "" Then
        '    Dim criteria = New OrCriteria
        '    criteria.column = "title"
        '    criteria.criteria = "LIKE"
        '    criteria.key = "keyword"
        '    auto_list.orWhere.Add(criteria)
        'End If

        Dim where_criteria = New Criteria
        where_criteria.column = "instructor_id"
        where_criteria.key = "instructor_id"
        auto_list.where.Add(where_criteria)

        where_criteria = New Criteria
        where_criteria.column = "is_locked"
        where_criteria.key = "is_locked"
        auto_list.where.Add(where_criteria)

        'Dim param = Nothing
        'If filter <> "" Then
        '    param = New CommandParameter
        '    param.param = "keyword"
        '    param.value = "%" & txt_filter.Text & "%"
        '    auto_list.parameters.Add(param)
        'End If

        Dim param = New CommandParameter
        param.param = "instructor_id"
        param.value = Auth.GetInstance.instructor_id
        auto_list.parameters.Add(param)

        param = New CommandParameter
        param.param = "is_locked"
        param.value = 0
        auto_list.parameters.Add(param)

        Dim cols = New List(Of String)
        cols.Add("title")
        cols.Add("description")
        cols.Add("created_at")
        cols.Add("attachment")
        auto_list.columns = cols
        auto_list.fetch()
    End Sub

    Private Sub effect_timer_Tick(sender As Object, e As System.EventArgs) Handles effect_timer.Tick
        lbl_indicator.Visible = Not lbl_indicator.Visible
        img_lock_indication.Visible = lbl_indicator.Visible
    End Sub

    Private Sub lesson_list_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles lesson_list.SelectedIndexChanged
        If lesson_list.SelectedItems.Count > 0 Then
            Dim item = lesson_list.SelectedItems(0)
            lbl_lesson_title.Text = item.SubItems(1).Text
            txt_lesson_description.Text = item.SubItems(2).Text
            current_file_path = ""
            If item.SubItems(item.SubItems.Count - 1).Text = "" Then _
                Exit Sub
            current_file_path = String.Format("{0}/{1}", LessonModel.attachment_path, item.SubItems(item.SubItems.Count - 1).Text)
            AttachmentViewer1.SelectedFile = current_file_path

            Dim logs = New LogsModel
            logs.attributes.activity = String.Format("View lesson `{0} - {1}`.", item.Text, item.SubItems(1).Text)
            logs.attributes.user_id = Auth.GetInstance.id
            logs.attributes.type = String.Format("LESSON_VIEWED")
            logs.create()
        End If
    End Sub
End Class