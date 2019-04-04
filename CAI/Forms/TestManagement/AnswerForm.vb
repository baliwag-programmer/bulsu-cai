Imports System.Windows.Forms

Public Class AnswerForm

    Private question_id As Integer
    Private answer_id As Integer
    Public mode As FormMode
    Public Enum FormMode
        Create
        Edit
    End Enum

    Sub New(Optional ByRef current_question As Integer = 0, Optional ByRef id As Integer = 0)

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        question_id = current_question
        If Not id = 0 Then
            mode = FormMode.Edit
            answer_id = id
        End If
    End Sub

    Sub save()
        Try
            Dim answer = New AnswerModel
            answer.attributes.answer = txt_answer.Text
            answer.attributes.is_correct = IIf(is_correct.Checked, 1, 0)
            answer.attributes.question_id = question_id
            answer.create()
            MsgBox("Successfully created answer.", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "Success")
            txt_answer.Text = ""
            is_correct.Checked = False
        Catch ex As Exception
            Console.WriteLine("Sorry unable to save answer : ")
            Console.WriteLine(ex)
        End Try
    End Sub

    Private Sub BTNCancel_Click(sender As System.Object, e As System.EventArgs) Handles BTNCancel.Click
        Me.DialogResult = Windows.Forms.DialogResult.Cancel
        Me.Close()
    End Sub

    Private Sub AnswerForm_FormClosing(sender As Object, e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        If Not Me.DialogResult = Windows.Forms.DialogResult.OK Then
            Dim confirm = MsgBox("Are you sure to quit this form?", MsgBoxStyle.YesNo + MsgBoxStyle.Question, "Are you sure?")
            If Not confirm = MsgBoxResult.Yes Then _
                e.Cancel = True
        End If
    End Sub

    Function validation() As Boolean
        If txt_answer.Text = "" Then
            MsgBox("Sorry answer is required.", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "No Answer Provided.")
            Return False
        End If
        Return True
    End Function

    Private Sub BTNSave_Click(sender As System.Object, e As System.EventArgs) Handles BTNSave.Click
        If Not validation() Then _
            Exit Sub

        save()
        Me.Close()
    End Sub

    Private Sub AnswerForm_Load(sender As Object, e As System.EventArgs) Handles Me.Load
        If mode = FormMode.Edit Then
            Dim answer = AnswerModel.find(answer_id)
            If answer Is Nothing Then
                MsgBox("Sorry invalid answer record.", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "Invalid Data")
                Exit Sub
            End If
            txt_answer.Text = answer.attributes.answer
            is_correct.Checked = answer.attributes.is_correct = 1
        End If
    End Sub

End Class
