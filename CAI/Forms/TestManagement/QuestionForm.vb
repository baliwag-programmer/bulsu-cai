Imports System.Windows.Forms

Public Class QuestionForm

    Dim question As QuestionModel
    Private current_test As Integer
    Private current_question As Integer
    Private auto_list As ListviewAutomation

    Sub New(Optional ByRef test As Integer = 0, Optional ByRef id As Integer = 0)

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        current_test = test
        current_question = id
    End Sub

    Function validation() As Boolean
        If txt_question.Text = "" Then
            MsgBox("Sorry unable to save the question due to question is required.", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "Validation Error.")
            txt_question.Focus()
            Return False
        End If

        If txt_correct.Text = "" Then
            MsgBox("Sorry but the correct answer must have a value.", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "Validation Error.")
            txt_correct.Focus()
            Return False
        End If

        If Not RADIdentification.Checked Then
            Dim has_error = False
            For Each ctrl As Control In choices_container.Controls
                Dim txt As TextBox = ctrl
                has_error = txt.Text = ""
                If has_error Then _
                    Exit For
            Next

            If has_error Then
                MsgBox("Sorry you have to put values on the choices.", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "Validation error")
                Return False
            End If

            For Each ctrl As Control In choices_container.Controls
                Dim txt As TextBox = ctrl
                has_error = txt.Text = txt_correct.Text
                If has_error Then _
                    GoTo hasError
            Next
hasError:
            If has_error Then
                MsgBox("Sorry correct answer cannot be a including to wrong choices.", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "Validation error")
                Return False
            End If

        End If

        Return True
    End Function

    Private Sub BTNCancel_Click(sender As System.Object, e As System.EventArgs) Handles BTNCancel.Click
        Me.DialogResult = Windows.Forms.DialogResult.Cancel
        Me.Close()
    End Sub

    Private Sub QuestionForm_FormClosing(sender As Object, e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        If Auth.GetInstance.isPreview Then _
            Exit Sub
        If Not Me.DialogResult = Windows.Forms.DialogResult.OK Then
            Dim confirm = MsgBox("Are you sure to quit this form?", MsgBoxStyle.YesNo + MsgBoxStyle.Question, "Are you sure?")
            If Not confirm = MsgBoxResult.Yes Then _
                e.Cancel = True
        End If
    End Sub

    Private Sub BTNSave_Click(sender As System.Object, e As System.EventArgs) Handles BTNSave.Click
        If Not validation() Then _
            Exit Sub
        Dim new_question As Boolean = question Is Nothing
        If new_question Then _
            question = New QuestionModel

        If question.attributes Is Nothing Then _
            question.attributes = New QuestionAttribute

        question.attributes.question = txt_question.Text
        question.attributes.test_id = current_test
        If new_question Then
            question.attributes.type = "MULTIPLE-CHOICE"
            If RADEnumeration.Checked Then _
                question.attributes.type = "ENUMERATION"
            If RADIdentification.Checked Then _
                question.attributes.type = "IDENTIFICATION"
        End If
        If new_question Then
            question = question.create()

            current_question = question.attributes.id
            MsgBox("Successfully created question.", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "Success")
        End If
        If Not new_question Then
            MsgBox("Successfully updated question.", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "Success")
            question.update()
        End If

        Try
            Dim command = New MySql.Data.MySqlClient.MySqlCommand("DELETE FROM answers WHERE question_id = @id", Database.GetInstance.GetConnection)
            command.Parameters.AddWithValue("@id", current_question)
            command.ExecuteNonQuery()
        Catch ex As Exception
            Console.WriteLine("Sorry unable to dettach recent answers.")
            Console.WriteLine(ex)
        End Try

        Try
            ' Correct
            Dim answer = New AnswerModel
            answer.attributes.answer = txt_correct.Text
            answer.attributes.question_id = current_question
            answer.attributes.is_correct = 1
            answer.create()

            If Not RADIdentification.Checked Then
                For Each obj In choices_container.Controls
                    Dim choice As TextBox = obj
                    answer = New AnswerModel
                    answer.attributes.answer = choice.Text
                    answer.attributes.question_id = current_question
                    answer.attributes.is_correct = 0
                    answer.create()
                Next
            End If

            Me.DialogResult = Windows.Forms.DialogResult.OK
            Me.Close()
        Catch ex As Exception
            Console.WriteLine("Sorry unable to create answers.")
            Console.WriteLine(ex)
        End Try

    End Sub

    Private Sub BTNAdd_Click(sender As System.Object, e As System.EventArgs) Handles BTNAdd.Click
        Dim total_inserted = choices_container.Controls.Count
        If RADMultipleChoice.Checked Then
            If total_inserted = 3 Then
                MsgBox("Sorry only 3 non correct choices and 1 correct choices is allowed to be added in current question type.", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "Validation Error.")
                Exit Sub
            End If
        End If
        Dim txt = initAnswer()
        Me.choices_container.Controls.Add(txt)
        Dim y = ((11 + txt.Height) * total_inserted) + 11
        txt.Location = New Point(12, y)
    End Sub

    Sub setupAnswers()

        With choices_container
            If RADMultipleChoice.Checked Then
                Dim choice = initAnswer()
                'txt.Location = New Point(12, 11)
            End If
        End With

    End Sub

    Function initAnswer() As TextBox
        Dim txt = New TextBox
        txt.Font = txt_question.Font
        txt.Size = New Point(504, 30)
        txt.Visible = True
        Return txt
    End Function

    Private Sub RADMatching_CheckedChanged(sender As System.Object, e As System.EventArgs)
        choices_container.Controls.Clear()
    End Sub

    Private Sub RADMatching_CheckedChanged_1(sender As System.Object, e As System.EventArgs) Handles RADMultipleChoice.CheckedChanged, RADIdentification.CheckedChanged, RADEnumeration.CheckedChanged
        lbl_choices.Visible = Not RADIdentification.Checked
        choices_container.Visible = Not RADIdentification.Checked
        BTNAdd.Visible = Not RADIdentification.Checked
        lbl_note.Visible = Not RADIdentification.Checked

        If RADIdentification.Checked Then _
            Me.Size = New Point(537, 333)
        If Not RADIdentification.Checked Then _
            Me.Size = New Point(537, 532)
    End Sub

    Private Sub QuestionForm_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        GroupBox1.Visible = current_question = 0
        BTNAdd.Visible = current_question = 0
        If Not current_question = 0 Then _
            fetchDetails()

        BTNSave.Visible = Not Auth.GetInstance.isPreview
        txt_correct.ReadOnly = Auth.GetInstance.isPreview
        txt_question.ReadOnly = Auth.GetInstance.isPreview

        For Each Control In choices_container.Controls
            Dim txt As TextBox = Control
            txt.ReadOnly = Auth.GetInstance.isPreview
        Next
    End Sub

    Sub fetchDetails()
        Try
            question = New QuestionModel
            Dim command = New MySql.Data.MySqlClient.MySqlCommand("SELECT * FROM questions WHERE id = @id", Database.GetInstance.GetConnection)
            command.Parameters.AddWithValue("@id", current_question)
            Dim reader = command.ExecuteReader
            If reader.Read Then
                question.attributes.question = Database.GetInstance.readerValue(reader, "question")
                question.attributes.type = Database.GetInstance.readerValue(reader, "type")
                question.attributes.id = current_question

                If question.attributes.type = "IDENTIFICATION" Then
                    Me.Size = New Point(537, 333)
                    lbl_choices.Visible = False
                End If
            End If
            txt_question.Text = question.attributes.question
            reader.Close()

            command = New MySql.Data.MySqlClient.MySqlCommand("SELECT * FROM answers WHERE question_id = @id", Database.GetInstance.GetConnection)
            command.Parameters.AddWithValue("@id", current_question)
            reader = command.ExecuteReader
            While reader.Read
                Dim is_correct = Database.GetInstance.readerValue(reader, "is_correct")
                If is_correct = 1 Then _
                    txt_correct.Text = Database.GetInstance.readerValue(reader, "answer")
                If is_correct = 0 Then
                    Dim txt = initAnswer()
                    Me.choices_container.Controls.Add(txt)
                    Dim y = ((11 + txt.Height) * (choices_container.Controls.Count - 1)) + 11
                    txt.Location = New Point(12, y)
                    txt.Text = Database.GetInstance.readerValue(reader, "answer")
                End If
            End While
            reader.Close()
        Catch ex As Exception
            Console.WriteLine("Sorry unable to fetch details.")
            Console.WriteLine(ex)
        End Try
    End Sub

End Class
