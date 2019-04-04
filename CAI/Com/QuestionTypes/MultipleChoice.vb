Public Class MultipleChoice

    Public Property id As Integer = 0
    Public Property Question As String = ""
    Public Property ItemNumber As Integer = 1
    Public Property Choices As New List(Of AnswerAttribute)
    Public Property CorrectAnswers As New List(Of String)
    Public Property Randomize As Random

    'Sub New(Optional ByRef rand As Random = Nothing)

    '    ' This call is required by the designer.
    '    InitializeComponent()

    'End Sub

    Sub MultipleChoice(Optional ByRef rand As Random = Nothing)
        ' Add any initialization after the InitializeComponent() call.
        If rand Is Nothing Then _
            rand = New Random
        Randomize = rand
    End Sub

    Public Sub instantiate()
        If Not lbl_question Is Nothing Then _
            lbl_question.Text = String.Format("{0}.) {1}", ItemNumber, Question)

        Dim thread = New System.Threading.Thread(AddressOf AssignSelections)
        thread.Start()
    End Sub

    Private Sub MultipleChoice_Load(sender As Object, e As System.EventArgs) Handles Me.Load
        If Choices Is Nothing Then _
            Choices = New List(Of AnswerAttribute)
        If CorrectAnswers Is Nothing Then _
            CorrectAnswers = New List(Of String)

        instantiate()
    End Sub

    Public Function isCorrect() As Boolean
        Dim selected As String = ""
        If rad_a.Checked Then _
            selected = rad_a.Text
        If rad_b.Checked Then _
            selected = rad_b.Text
        If rad_c.Checked Then _
            selected = rad_c.Text
        If rad_d.Checked Then _
            selected = rad_d.Text


        ' TODO save the answer
        Try
            For Each choice As AnswerAttribute In Me.Choices
                If selected = choice.answer Then
                    Dim command = New MySql.Data.MySqlClient.MySqlCommand("INSERT INTO users_answers (user_id, answer_id, answer, is_correct, question_id, question)VALUES(@user_id, @answer_id, @answer, @is_correct, @question_id, @question)", Database.GetInstance.GetConnection)
                    With command.Parameters
                        .AddWithValue("@user_id", Auth.GetInstance.id)
                        .AddWithValue("@answer_id", choice.id)
                        .AddWithValue("@answer", choice.answer)
                        .AddWithValue("@is_correct", choice.is_correct)
                        .AddWithValue("@question_id", choice.question_id)
                        .AddWithValue("@question", Me.Question)
                    End With
                    command.ExecuteNonQuery()
                    Exit For
                End If
            Next
        Catch ex As Exception
            Console.WriteLine("Sorry unable to save answer")
            Console.WriteLine(ex)
        End Try

        Return CorrectAnswers.IndexOf(selected) > -1
    End Function

    Private Sub AssignSelections()
        If Choices.Count = 0 Then _
            Exit Sub
        Dim tmp_choices As New List(Of AnswerAttribute)
        For Each choice In Choices
            tmp_choices.Add(choice)
        Next
        Dim rand_choices = New List(Of RadioButton)
        rand_choices.Add(rad_a)
        rand_choices.Add(rad_b)
        rand_choices.Add(rad_c)
        rand_choices.Add(rad_d)

        Dim index = Randomize.Next(0, tmp_choices.Count)
        For Each radio As RadioButton In rand_choices
            radio.Text = tmp_choices(index).answer
            tmp_choices.RemoveAt(index)
            index = Randomize.Next(0, tmp_choices.Count)
        Next
    End Sub

End Class
