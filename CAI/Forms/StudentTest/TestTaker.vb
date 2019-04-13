Public Class TestTaker

    Private current_test As Integer = 0

    Private is_locked As Integer = 1
    Private WithEvents timer As Timer
    Private WithEvents effect_timer As Timer
    Private is_time_out As Boolean = False
    Private duration_hour As Integer = 0
    Private duration_minutes As Integer = 0
    Private duration_seconds As Integer = 30

    Sub New(Optional ByRef id As Integer = 0)

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        current_test = id
    End Sub

    Private Sub OnDateTimeChanged(ByRef CurrentDateTime As Date)
        Try
            Me.lbl_date.Text = Format(CurrentDateTime, "Long Date")
        Catch ex As Exception

        End Try
    End Sub

    Sub fetchQuestions()
        Try
            Dim command = New MySql.Data.MySqlClient.MySqlCommand("SELECT * FROM questions WHERE test_id = @test", Database.GetInstance.GetConnection)
            With command.Parameters
                .AddWithValue("@test", current_test)
            End With
            Dim reader = command.ExecuteReader
            Dim questions As New List(Of QuestionModel)
            While reader.Read
                Dim question = New QuestionModel
                question.attributes.id = reader.GetValue(0)
                question.attributes.question = reader.GetValue(reader.GetOrdinal("question"))
                question.attributes.type = reader.GetValue(reader.GetOrdinal("type"))

                questions.Add(question)
            End While
            reader.Close()
            CheckForIllegalCrossThreadCalls = False

            Dim random = New Random
            Dim item_number As Integer = 1
            Dim next_y As Integer = 0
            next_y = TXTInstruction.Location.Y + TXTInstruction.Height + 5
            While questions.Count - 5 > 0
                Dim index As Integer = random.Next(0, questions.Count)
                Dim question = questions(index)

                command = New MySql.Data.MySqlClient.MySqlCommand("SELECT * FROM answers WHERE question_id = @question", Database.GetInstance.GetConnection)
                command.Parameters.AddWithValue("@question", question.attributes.id)
                reader = command.ExecuteReader
                Dim question_com = New MultipleChoice
                Select Case question.attributes.type
                    Case "MULTIPLE-CHOICE"
                        question_container.Controls.Add(question_com)
                        question_com.id = question.attributes.id
                        question_com.Visible = True
                        question_com.Location = New Point(15, IIf(next_y > 0, next_y, question_com.Height * (item_number - 1)))
                        next_y = question_com.Location.Y + question_com.Height
                        question_com.Width = question_container.Width - 40
                        question_com.Question = question.attributes.question
                        question_com.ItemNumber = String.Format("{0:00}", item_number)

                        question_com.Randomize = random
                        While reader.Read
                            Dim answer = New AnswerAttribute
                            answer.id = reader.GetValue(0)
                            answer.answer = reader.GetValue(reader.GetOrdinal("answer"))
                            answer.question_id = reader.GetValue(reader.GetOrdinal("question_id"))
                            answer.is_correct = Database.GetInstance.readerValue(reader, "is_correct")
                            If answer.is_correct = 1 Then _
                                question_com.CorrectAnswers.Add(answer.answer)
                            question_com.Choices.Add(answer)
                        End While
                        question_com.instantiate()
                        reader.Close()
                    Case "IDENTIFICATION"
                        Dim control = New Identification
                        question_container.Controls.Add(control)
                        control.Visible = True
                        control.Location = New Point(15, next_y)
                        next_y = control.Location.Y + control.Height
                        control.Width = question_container.Width - 40
                        control.Question = question.attributes.question
                        control.ItemNumber = String.Format("{0:00}", item_number)

                        If reader.Read Then
                            Dim answer = New AnswerAttribute
                            answer.id = reader.GetValue(0)
                            answer.answer = reader.GetValue(reader.GetOrdinal("answer"))
                            answer.question_id = reader.GetValue(reader.GetOrdinal("question_id"))
                            answer.is_correct = Database.GetInstance.readerValue(reader, "is_correct")
                            control.Answer = answer
                        End If
                        control.instantiate()
                        reader.Close()
                End Select

                item_number += 1

                questions.Remove(question)
            End While

        Catch ex As Exception
            Console.WriteLine("Sorry unable to fetch questions")
            Console.WriteLine(ex)
        End Try
    End Sub

    Sub fetchDetails()

        Try
            lbl_indicator.Text = "TEST CURRENTLY LOCKED"
            Dim command = New MySql.Data.MySqlClient.MySqlCommand("SELECT * FROM tests WHERE id = @id AND NOT EXISTS (SELECT * FROM users_tests WHERE ( tests.id = users_tests.test_id AND user_id = @user ))", Database.GetInstance.GetConnection)
            command.Parameters.AddWithValue("@id", current_test)
            command.Parameters.AddWithValue("@user", Auth.GetInstance.id)
            Dim reader = command.ExecuteReader
            If reader.Read Then
                lbl_title.Text = Database.GetInstance.readerValue(reader, "title")
                is_locked = Database.GetInstance.readerValue(reader, "is_locked")
                duration_hour = Database.GetInstance.readerValue(reader, "duration_hour")
                duration_minutes = Database.GetInstance.readerValue(reader, "duration_minute")
                TXTInstruction.Text = String.Format("Instruction : {0}", Database.GetInstance.readerValue(reader, "instruction"))
                duration_seconds = 0
            End If
            reader.Close()

            lock_container.Visible = is_locked = 1
            If lock_container.Visible Then
                effect_timer = New Timer
                effect_timer.Interval = 500
                effect_timer.Start()

                command = New MySql.Data.MySqlClient.MySqlCommand("SELECT * FROM users_tests WHERE test_id = @test AND user_id = @user", Database.GetInstance.GetConnection)
                command.Parameters.AddWithValue("@test", current_test)
                command.Parameters.AddWithValue("@user", Auth.GetInstance.id)
                reader = command.ExecuteReader
                If reader.Read Then _
                    lbl_indicator.Text = "TEST ALREADY BEEN TAKEN"
                reader.Close()
            End If

            If is_locked = 0 Then
                fetchQuestions()
                lbl_time.Text = String.Format("{0:00}:{1:00}:{2:00}", duration_hour, duration_minutes, duration_seconds)
                timer = New Timer
                timer.Interval = 1000
                timer.Start()

                Dim logs = New LogsModel
                logs.attributes.type = "TEST_TAKEN_START"
                logs.attributes.user_id = Auth.GetInstance.id
                logs.attributes.activity = String.Format("Start taking test `{0} - {1}` with a duration of `{2}`", current_test, lbl_title.Text, String.Format("{0:00}:{1:00}", duration_hour, duration_minutes))
                logs.create()
            End If
        Catch ex As Exception
            Console.WriteLine("Unable to fetch details.")
            Console.WriteLine(ex)
        End Try
    End Sub

    Private Sub TestTaker_FormClosing(sender As Object, e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        If Not timer Is Nothing Then
            timer.Stop()
            timer.Dispose()
            timer = Nothing
        End If
    End Sub

    Private Sub TestTaker_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        AddHandler My.Application.OnDateTimeChanged, AddressOf OnDateTimeChanged
        fetchDetails()
    End Sub

    Private Sub timer_Tick(sender As Object, e As System.EventArgs) Handles timer.Tick
        If duration_seconds = 0 Then
            If duration_minutes = 0 Then
                If duration_hour = 0 And duration_minutes = 0 And duration_seconds = 0 Then
                    timer.Stop()
                    is_time_out = True
                    MsgBox("Timeout!", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "Time Completed.")
                    BTNSave.PerformClick()
                    Return
                Else
                    duration_hour -= 1
                    duration_minutes = 59
                    duration_seconds = 59
                End If
            Else
                duration_minutes -= 1
                duration_seconds = 59
            End If
        Else
            duration_seconds -= 1
        End If

        lbl_time.Text = String.Format("{0:00}:{1:00}:{2:00}", duration_hour, duration_minutes, duration_seconds)
    End Sub

    Private Sub effect_timer_Tick(sender As Object, e As System.EventArgs) Handles effect_timer.Tick
        lbl_indicator.Visible = Not lbl_indicator.Visible
        img_lock_indication.Visible = lbl_indicator.Visible
    End Sub

    Private Sub BTNSave_Click(sender As Object, e As System.EventArgs) Handles BTNSave.Click
        If Not is_time_out Then
            Dim confirm = MsgBox("Are you sure to finish taking this test?", MsgBoxStyle.YesNo + MsgBoxStyle.Question, "Are you sure?")
            If Not confirm = MsgBoxResult.Yes Then _
                Exit Sub
        End If
        Dim num_correct As Integer = 0
        Dim items = question_container.Controls.Count - 1

        For Each ctrl As Control In question_container.Controls
            If TypeOf (ctrl) Is MultipleChoice Then
                Dim obj As MultipleChoice = ctrl
                If obj.isCorrect Then _
                    num_correct += 1
            End If
            If TypeOf (ctrl) Is Identification Then
                Dim obj As Identification = ctrl
                If obj.isCorrect Then _
                    num_correct += 1
            End If
        Next

        ' Save the test first
        Try
            Dim command = New MySql.Data.MySqlClient.MySqlCommand("INSERT INTO users_tests (test_id, user_id, items, score)VALUES(@test_id, @user_id, @items, @score)", Database.GetInstance.GetConnection)
            With command.Parameters
                .AddWithValue("@test_id", current_test)
                .AddWithValue("@user_id", Auth.GetInstance.id)
                .AddWithValue("@items", items)
                .AddWithValue("@score", num_correct)
            End With
            command.ExecuteNonQuery()

            Dim logs = New LogsModel
            logs.attributes.type = "TEST_TAKEN_END"
            logs.attributes.user_id = Auth.GetInstance.id
            logs.attributes.activity = String.Format("Done taking test `{0} - {1}` with a duration of `{2}`", current_test, lbl_title.Text, String.Format("{0:00}:{1:00}", duration_hour, duration_minutes))
            logs.create()
        Catch ex As Exception
            Console.WriteLine("Sorry unable to save the current test")
            Console.WriteLine(ex)
        End Try

        If Not timer Is Nothing Then
            timer.Stop()
            timer.Dispose()
            timer = Nothing
        End If

        MsgBox(String.Format("Successfully done your test with a score of {0:00} / {1:00}", num_correct, items), MsgBoxStyle.Information, "Success")
        Me.Close()
    End Sub
End Class