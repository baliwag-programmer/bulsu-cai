Public Class MultipleChoice

    Public Property Question As String = ""
    Public Property ItemNumber As Integer = 1
    Public Property Choices As List(Of String)
    Public Property CorrectAnswers As List(Of String)
    Private Property Randomize As Random

    Sub New(Optional ByRef rand As Random = Nothing)

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        If rand Is Nothing Then _
            rand = New Random
        Randomize = rand
    End Sub


    Private Sub instantiate()

        lbl_question.Text = String.Format("{0}.) {1}", ItemNumber, Question)

        Dim thread = New System.Threading.Thread(AddressOf AssignSelections)
        thread.Start()
    End Sub

    Private Sub MultipleChoice_Paint(sender As Object, e As PaintEventArgs) Handles Me.Paint
        If Choices Is Nothing Then _
            Choices = New List(Of String)
        If CorrectAnswers Is Nothing Then _
            CorrectAnswers = New List(Of String)

        instantiate()
    End Sub

    Private Sub AssignSelections()
        If Choices.Count = 0 Then _
            Exit Sub
        Dim rand_choices = New List(Of RadioButton)
        rand_choices.Add(rad_a)
        rand_choices.Add(rad_b)
        rand_choices.Add(rad_c)
        rand_choices.Add(rad_d)

        Dim index = Randomize.Next(0, Choices.Count)
        For Each radio As RadioButton In rand_choices
            radio.Text = Choices(index)
            index = Randomize.Next(0, Choices.Count)
        Next
    End Sub

End Class
