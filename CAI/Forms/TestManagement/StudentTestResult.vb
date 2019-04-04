Public Class StudentTestResult
    Dim auto_list As ListviewAutomation
    Private Sub StudentTestResult_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        fetchTest()

        Dim logs = New LogsModel
        logs.attributes.type = "TEST_VIEW_RESULTS"
        logs.attributes.user_id = Auth.GetInstance.id
        logs.attributes.activity = "Viewed test results"
        logs.create()
    End Sub

    Sub fetchTest(Optional ByRef filter As String = "")
        auto_list = New ListviewAutomation
        auto_list.table = "users_tests"
        auto_list.list = test_list
        auto_list.max_per_page = 15
        auto_list.btn_next = lesson_next
        auto_list.btn_prev = lesson_prev
        auto_list.pagination = lesson_page
        auto_list.custom_Sql = String.Format("SELECT users_tests.id, tests.title, tests.description, users_tests.items, users_tests.score, DATE_FORMAT(users_tests.created_at, '%a %b %d, %Y') as date_taken FROM users_tests LEFT JOIN tests ON tests.id = test_id", Auth.GetInstance.id)
        auto_list.where = New List(Of Criteria)
        auto_list.orWhere = New List(Of OrCriteria)
        auto_list.parameters = New List(Of CommandParameter)

        Dim where_criteria = New Criteria
        where_criteria.column = "user_id"
        where_criteria.key = "user_id"
        auto_list.where.Add(where_criteria)

        Dim param = New CommandParameter
        param.param = "user_id"
        param.value = Auth.GetInstance.id
        auto_list.parameters.Add(param)

        Dim cols = New List(Of String)
        cols.Add("title")
        cols.Add("description")
        cols.Add("items")
        cols.Add("score")
        cols.Add("date_taken")
        auto_list.columns = cols
        auto_list.fetch()
    End Sub

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        Me.Close()
    End Sub
End Class