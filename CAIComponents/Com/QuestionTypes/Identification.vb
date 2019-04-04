Public Class Identification

    Public Property Answer As String
    Public Property Question As String = ""
    Public Property ItemNumber As Integer = 1
    Public Property CorrectAnswer As String = ""
    Public Property MaxPointPerLetter As Double = 6.11

    Sub processQuestion()
        Dim max As Integer = computeMaxCharacter()
        If Not Question.Length > 0 Then _
            Exit Sub
        lbl_main_question.Text = Question.Substring(0, IIf(max > Question.Length, Question.Length, max))
    End Sub

    Function computeMaxCharacter() As Integer
        Dim width = lbl_main_question.Width

        ' TODO get the maximuum letters for the main label
        computeMaxCharacter = width / MaxPointPerLetter

        Return computeMaxCharacter
    End Function

    Private Sub Identification_Paint(sender As Object, e As PaintEventArgs) Handles Me.Paint
        processQuestion()
        lbl_number.Text = String.Format("{0}.)", ItemNumber)
    End Sub
End Class
