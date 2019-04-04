Public Class StudentLessonViewerV2
    WithEvents timer As Timer
    Private Sub StudentLessonViewerV2_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        lbl_time.Text = Format(Now(), "hh:mm:ss tt")
        lbl_date.Text = Format(Now(), "MMMM dd, yyyy")
        timer = New Timer
        With timer
            .Interval = 1000
            .Enabled = True
            .Start()
        End With
        With Panel1
            .Controls.Clear()
            Dim next_x = 12
            Dim next_y = 12

            Dim x_item = 1
            Dim sql = String.Format("SELECT COUNT(*) as total FROM lessons WHERE instructor_id = {0}", Auth.GetInstance.instructor_id)
            Try
                Dim command = New MySql.Data.MySqlClient.MySqlCommand(sql, Database.GetInstance.GetConnection)

                Dim record_count As Integer = command.ExecuteScalar
                Dim max_x As Integer = (Me.Width / 168) - 1
                If max_x > record_count Then _
                    max_x = record_count
                Dim margin As Integer = (Me.Width - ((168 + 5) * max_x)) / 2
                next_x = margin - 12
                next_y = (margin - 12) / 2

                sql = String.Format("SELECT id, title, description, DATE_FORMAT(created_at, '%a %b %d, %Y') as created_at,attachment,is_locked FROM lessons WHERE instructor_id = {0}", Auth.GetInstance.instructor_id)
                command = New MySql.Data.MySqlClient.MySqlCommand(sql, Database.GetInstance.GetConnection)
                Dim reader = command.ExecuteReader
                Dim x As Integer = 1
                While reader.Read
                    Dim btn = New LessonButton
                    .Controls.Add(btn)
                    btn.Size = New Point(168, 148)
                    btn.Location = New Point(next_x, next_y)
                    btn.Visible = True
                    next_x = next_x + btn.Width + 5
                    btn.lesson_number = x
                    btn.lesson_title = Database.GetInstance.readerValue(reader, "title")
                    btn.is_locked = Database.GetInstance.readerValue(reader, "is_locked") = 1
                    btn.attachment = String.Format("{0}/{1}", LessonModel.attachment_path, Database.GetInstance.readerValue(reader, "attachment"))
                    If max_x = x_item Then
                        x_item = 0
                        next_y = next_y + btn.Height + 5
                        next_x = margin - 12
                    End If
                    btn.init()
                    x_item += 1
                    x += 1
                    AddHandler btn.OnSelect, AddressOf showAttachment
                End While
                reader.Close()
            Catch ex As Exception
                Console.WriteLine("Unable to fetch lessons")
                Console.WriteLine(ex)
            End Try
        End With
    End Sub

    Private Sub timer_Tick(sender As Object, e As System.EventArgs) Handles timer.Tick
        lbl_time.Text = Format(Now(), "hh:mm:ss tt")
        lbl_date.Text = Format(Now(), "MMMM dd, yyyy")
    End Sub

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        Me.Close()
    End Sub

    Private Sub showAttachment(sender As Object, e As EventArgs)
        Dim btn As LessonButton = sender
        Me.Hide()
        Dim form = New StudentLessonAttachmentViewer(btn.attachment, btn.lesson_title)
        form.ShowDialog()
        Me.Show()
    End Sub

End Class