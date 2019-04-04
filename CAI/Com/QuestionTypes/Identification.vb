Public Class Identification

    Public Property Question As String = ""
    Public Property Answer As AnswerAttribute
    Public Property ItemNumber As Integer = 1
    Public Property CorrectAnswer As String = ""
    Public Property MaxPointPerLetter As Double = 6.11

    Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        Answer = New AnswerAttribute
    End Sub

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

    Public Sub instantiate()
        lbl_number.Text = String.Format("{0}.)", ItemNumber)
        processQuestion()
    End Sub

    Public Function isCorrect() As Boolean
        ' TODO save the answer
        Try
            Dim id As Integer = 0
            If txt_answer.Text = Answer.answer Then
                id = Answer.id
            End If
            Dim command = New MySql.Data.MySqlClient.MySqlCommand("INSERT INTO users_answers (user_id, answer_id, answer, is_correct, question_id, question)VALUES(@user_id, @answer_id, @answer, @is_correct, @question_id, @question)", Database.GetInstance.GetConnection)
            With command.Parameters
                .AddWithValue("@user_id", Auth.GetInstance.id)
                .AddWithValue("@answer_id", id)
                .AddWithValue("@answer", txt_answer.Text)
                .AddWithValue("@is_correct", IIf(id = 0, 0, 1))
                .AddWithValue("@question_id", Answer.question_id)
                .AddWithValue("@question", Me.Question)
            End With
            command.ExecuteNonQuery()
        Catch ex As Exception
            Console.WriteLine("Sorry unable to save answer")
            Console.WriteLine(ex)
        End Try

        Return txt_answer.Text = Answer.answer
    End Function

End Class
