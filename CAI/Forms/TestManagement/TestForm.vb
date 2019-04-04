Imports System.Windows.Forms

Public Class TestForm

    Private current_test As Integer = 0

    Sub New(Optional ByRef id As Integer = 0)

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        current_test = id
    End Sub

    Function validation()
        If TxtTitle.Text = "" Then
            MsgBox("Title is required.", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "Validation Error.")
            Return False
        End If
        If combo_hour.Text = "00" And combo_minutes.Text = "00" Then
            MsgBox("Duration is invalid.", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "Validation Error.")
            Return False
        End If

        If CMBQuestionType.Text = "" Then
            MsgBox("Sorry question types is required.", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "Validation Error.")
            Return False
        End If

        If TXTTotal.Text = "" Then
            MsgBox("Sorry total questions is required.", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "Validation Error.")
            Return False
        End If

        Dim total = TXTTotal.Text
        If Not IsNumeric(total) Then
            MsgBox(String.Format("Sorry total question `{0}` is invalid.", total), MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "Validation Error.")
            Return False
        End If

        If total < 10 And current_test = 0 Then
            MsgBox("Sorry total question minimuum is 10.", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "Validation Error.")
            Return False
        End If

        Return True
    End Function

    Sub createTest()
        Try
            Dim command = New MySql.Data.MySqlClient.MySqlCommand("INSERT INTO tests (title, description, instructor_id, duration_hour, duration_minute, is_locked, type, instruction) VALUES (@title, @description, @instructor_id, @duration_hour, @duration_minute, @is_locked, @type, @instruction); SELECT LAST_INSERT_ID();", Database.GetInstance.GetConnection)
            With command.Parameters
                .AddWithValue("@type", ComboType.Text)
                .AddWithValue("@title", TxtTitle.Text)
                .AddWithValue("@description", TxtDescription.Text)
                .AddWithValue("@instructor_id", Auth.GetInstance.id)
                .AddWithValue("@instruction", TXTInstruction.Text)
                .AddWithValue("@duration_hour", combo_hour.Text)
                .AddWithValue("@duration_minute", combo_minutes.Text)
                .AddWithValue("@is_locked", IIf(CHKLocked.Checked, 1, 0))
            End With
            current_test = command.ExecuteScalar()

            ' Create 10 question items
            For x As Integer = 0 To TXTTotal.Text + 5
                Dim question = New QuestionModel
                question.attributes.question = String.Format("Question {0}", x + 1)
                question.attributes.test_id = current_test
                question.attributes.type = CMBQuestionType.Text
                question = question.create()

                Dim answer = New AnswerModel
                answer.attributes.is_correct = 1
                answer.attributes.answer = "Correct Choice"
                answer.attributes.question_id = question.attributes.id
                answer.create()

                If CMBQuestionType.Text = "MULTIPLE-CHOICE" Then
                    For y As Integer = 0 To 2
                        answer = New AnswerModel
                        answer.attributes.is_correct = 0
                        answer.attributes.answer = String.Format("Choice {0}", y + 1)
                        answer.attributes.question_id = question.attributes.id
                        answer.create()
                    Next y
                End If
            Next x

            MsgBox("Successfully created new test.", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "Success")

            Dim logs = New LogsModel
            logs.attributes.type = "TEST_CREATE"
            logs.attributes.user_id = Auth.GetInstance.id
            logs.attributes.activity = String.Format("Create new test `{0} - {1}` with a duration of `{1:00}:{2:00}`.", current_test, TxtTitle.Text, combo_hour.Text, combo_minutes.Text)
            logs.create()

            Dim form = New QuestionManagement(current_test)
            Me.Hide()
            form.ShowDialog()

            Me.DialogResult = Windows.Forms.DialogResult.OK
            Me.Close()
        Catch ex As Exception
            Console.WriteLine("Error saving the data : " & ex.Message)
            Console.WriteLine(ex)
        End Try
    End Sub

    Sub updateTest()
        Try
            Dim command = New MySql.Data.MySqlClient.MySqlCommand("UPDATE tests SET title = @title, description = @description, instructor_id = @instructor_id, duration_hour = @duration_hour, duration_minute = @duration_minute, is_locked = @locked, type = @type, instruction = @instruction WHERE ( id = @id )", Database.GetInstance.GetConnection)
            With command.Parameters
                .AddWithValue("@type", ComboType.Text)
                .AddWithValue("@title", TxtTitle.Text)
                .AddWithValue("@description", TxtDescription.Text)
                .AddWithValue("@instructor_id", Auth.GetInstance.id)
                .AddWithValue("@instruction", TXTInstruction.Text)
                .AddWithValue("@duration_hour", combo_hour.Text)
                .AddWithValue("@duration_minute", combo_minutes.Text)
                .AddWithValue("@locked", IIf(CHKLocked.Checked, 1, 0))
                .AddWithValue("@id", current_test)
            End With
            command.ExecuteNonQuery()
            MsgBox("Successfully updated test.", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "Success")

            Dim logs = New LogsModel
            logs.attributes.type = "TEST_UPDATED"
            logs.attributes.user_id = Auth.GetInstance.id
            logs.attributes.activity = String.Format("Upated test `{0} - {1}` with a duration of `{2:00}:{3:00}`.", current_test, TxtTitle.Text, combo_hour.Text, combo_minutes.Text)
            logs.create()

            Dim form = New QuestionManagement(current_test)
            Me.Hide()
            form.ShowDialog()

            Me.DialogResult = Windows.Forms.DialogResult.OK
            Me.Close()
        Catch ex As Exception
            Console.WriteLine("Error saving the data : " & ex.Message)
            Console.WriteLine(ex)
        End Try
    End Sub

    Sub save()
        If current_test > 0 Then _
            updateTest()
        If current_test = 0 Then _
            createTest()
    End Sub

    Private Sub BTNSave_Click(sender As System.Object, e As System.EventArgs) Handles BTNSave.Click
        If validation() Then _
            save()
    End Sub

    Private Sub TestForm_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Button1.Visible = Not current_test = 0
        If Not current_test = 0 Then
            fetchDetails()
            CMBQuestionType.Enabled = False
            TXTTotal.Enabled = False
            Label12.Enabled = False
        End If

        If Auth.GetInstance.isPreview Then
            CMBQuestionType.Enabled = False
            TXTTotal.Enabled = False
            ComboType.Enabled = False
            combo_hour.Enabled = False
            combo_minutes.Enabled = False
            BTNSave.Visible = False
            Button1.Text = "VIEW QUESTIONS"
        End If
    End Sub

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        Dim form = New QuestionManagement(current_test)
        Me.Hide()
        form.ShowDialog()
        Me.Show()
    End Sub

    Sub fetchDetails()
        Try
            Dim command = New MySql.Data.MySqlClient.MySqlCommand("SELECT *, (SELECT COUNT(*) FROM questions WHERE tests.id = questions.test_id) as total, (SELECT type FROM questions WHERE tests.id = questions.test_id LIMIT 1) as question_type FROM tests WHERE id = @id", Database.GetInstance.GetConnection)
            With command.Parameters
                .AddWithValue("@id", current_test)
            End With
            Dim reader = command.ExecuteReader
            If reader.Read Then
                CMBQuestionType.Text = Database.GetInstance.readerValue(reader, "question_type")
                TXTTotal.Text = Database.GetInstance.readerValue(reader, "total") - 5
                TxtTitle.Text = Database.GetInstance.readerValue(reader, "title")
                ComboType.Text = Database.GetInstance.readerValue(reader, "type")
                combo_hour.Text = String.Format("{0:00}", Database.GetInstance.readerValue(reader, "duration_hour"))
                combo_minutes.Text = String.Format("{0:00}", Database.GetInstance.readerValue(reader, "duration_minute"))
                CHKLocked.Checked = Database.GetInstance.readerValue(reader, "is_locked") = 1
                TxtDescription.Text = Database.GetInstance.readerValue(reader, "description")
                TXTInstruction.Text = Database.GetInstance.readerValue(reader, "instruction")
            End If
            reader.Close()
        Catch ex As Exception
            Console.WriteLine("Sorry unable to fetch details.")
            Console.WriteLine(ex)
        End Try
    End Sub

    Private Sub BTNCancel_Click(sender As System.Object, e As System.EventArgs) Handles BTNCancel.Click
        Me.Close()
    End Sub
End Class
