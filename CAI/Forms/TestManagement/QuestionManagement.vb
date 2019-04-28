Imports System.Windows.Forms

Public Class QuestionManagement

    Private test_id As Integer
    Private WithEvents filter_timer As Timer
    Private auto_list As ListviewAutomation

    Sub New(Optional test_id As Integer = 0)

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        Me.test_id = test_id
    End Sub

    Private Sub QuestionManagement_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        fetchQuestion(txt_filter.Text)
        'BTNCreate.Visible = Not Auth.GetInstance.isPreview
        BTNEdit.Visible = Not Auth.GetInstance.isPreview
    End Sub

    Sub fetchQuestion(Optional ByRef filter As String = "")
        auto_list = New ListviewAutomation
        auto_list.table = "questions"
        auto_list.list = question_list
        auto_list.max_per_page = 15
        auto_list.btn_next = lesson_next
        auto_list.btn_prev = lesson_prev
        auto_list.pagination = lesson_page
        auto_list.custom_Sql = String.Format("SELECT questions.id, questions.question, questions.type, answers.answer as correct_answer, DATE_FORMAT(questions.created_at, '%a %b %d, %Y') as created_at FROM questions LEFT OUTER JOIN answers ON question_id = questions.id AND is_correct = 1", Auth.GetInstance.id)
        auto_list.where = New List(Of Criteria)
        auto_list.orWhere = New List(Of OrCriteria)
        auto_list.parameters = New List(Of CommandParameter)

        If filter <> "" Then
            Dim criteria = New OrCriteria
            criteria.column = "title"
            criteria.criteria = "LIKE"
            criteria.key = "keyword"
            auto_list.orWhere.Add(criteria)
        End If

        Dim where_criteria = New Criteria
        where_criteria.column = "test_id"
        where_criteria.key = "test_id"
        auto_list.where.Add(where_criteria)

        Dim param = Nothing
        If filter <> "" Then
            param = New CommandParameter
            param.param = "keyword"
            param.value = "%" & filter & "%"
            auto_list.parameters.Add(param)
        End If

        param = New CommandParameter
        param.param = "test_id"
        param.value = test_id
        auto_list.parameters.Add(param)

        Dim cols = New List(Of String)
        cols.Add("question")
        cols.Add("type")
        cols.Add("correct_answer")
        cols.Add("created_at")
        auto_list.columns = cols
        auto_list.fetch()
    End Sub

    Private Sub BTNCreate_Click(sender As System.Object, e As System.EventArgs) Handles BTNCreate.Click
        Dim form = New QuestionForm(test_id)
        Me.Hide()
        Dim result = form.ShowDialog()
        If result = Windows.Forms.DialogResult.OK Then _
            fetchQuestion()
        Me.Show()
    End Sub

    Private Sub BTNEdit_Click(sender As System.Object, e As System.EventArgs) Handles BTNEdit.Click
        If question_list.SelectedItems.Count = 0 Then _
            Exit Sub
        Dim form = New QuestionForm(test_id, question_list.SelectedItems(0).Text)
        Me.Hide()
        form.ShowDialog()
        Me.Show()
        fetchQuestion()
    End Sub

    Private Sub question_list_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles question_list.SelectedIndexChanged
        BTNEdit.Enabled = question_list.SelectedItems.Count > 0 And Not Auth.GetInstance.isPreview
    End Sub

    Private Sub showEdit(sender As System.Object, e As System.EventArgs) Handles question_list.DoubleClick
        BTNEdit_Click(BTNEdit, New System.EventArgs)
    End Sub

    Private Sub txt_filter_KeyPress(sender As Object, e As System.Windows.Forms.KeyPressEventArgs) Handles txt_filter.KeyPress
        If Not filter_timer Is Nothing Then
            filter_timer.Stop()
            filter_timer.Dispose()
            filter_timer = Nothing
        End If
    End Sub

    Private Sub txt_filter_KeyUp(sender As Object, e As System.Windows.Forms.KeyEventArgs) Handles txt_filter.KeyUp
        filter_timer = New Timer
        filter_timer.Interval = 500
        filter_timer.Start()
    End Sub

    Private Sub filter_timer_Tick(sender As Object, e As System.EventArgs) Handles filter_timer.Tick
        fetchQuestion(txt_filter.Text)

        filter_timer.Stop()
        filter_timer.Dispose()
        filter_timer = Nothing
    End Sub

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        Me.Close()
    End Sub
End Class
