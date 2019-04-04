Public Class Enumeration

    Public Property Question As String = ""
    Public Property ItemNumber As Integer = 1
    Public Property MaxAnswers As Integer = 1
    Public Property CorrectAnswers As List(Of String)

    Private answers As List(Of TextBox)

    Private Sub instantiate()

        For x As Integer = 0 To MaxAnswers
            Dim obj = initAnswer(String.Format("answer-{0}", x + 1))
            answers.Add(obj)
            AsnwerContainer.Controls.Add(obj)
        Next x

        lbl_main_question.Text = Question
        lbl_number.Text = String.Format("{0}.)", ItemNumber)

    End Sub

    Private Function initAnswer(ByRef name As String, Optional ByRef location As Point = Nothing) As TextBox

        If location = Nothing Then _
            location = New Point(0, 0)

        Dim obj = New TextBox
        obj.Visible = True
        obj.Font = New Font(Me.Font.FontFamily, 12)
        obj.Location = location

        Return obj
    End Function

    Private Sub Enumeration_Paint(sender As Object, e As PaintEventArgs) Handles Me.Paint
        instantiate()
    End Sub
End Class
