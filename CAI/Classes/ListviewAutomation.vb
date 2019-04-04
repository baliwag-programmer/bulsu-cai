Public Class CommandParameter
    Property param As String
    Property value As Object
End Class

Public Class Criteria
    Property column As String
    Property key As String = "keyword"
    Property criteria As String = "="
    Property appender As String = "AND"
End Class

Public Class OrCriteria
    Property column As String
    Property key As String = "keyword"
    Property criteria As String = "="
    Property appender As String = "OR"
End Class

Public Class ExistsCriteria
    Property column As String
    Property key As String = "keyword"
    Property appender As String = "AND"
End Class

Public Class OrderBy
    Property columns As List(Of String)
    Property type As String = "ASC"

    Sub New()
        columns = New List(Of String)
    End Sub
End Class

Public Class GroupBy
    Property columns As List(Of String)
    Sub New()
        columns = New List(Of String)
    End Sub
End Class

Public Class LeftOuterJoin
    Property table As String
    Property Jointer As List(Of Criteria)
    Sub New()
        Jointer = New List(Of Criteria)
    End Sub
End Class

Public Class ListviewAutomation

    Public grammar As String

    Public WithEvents list As ListView
    Public WithEvents pagination As Label
    Public WithEvents btn_next As Button
    Public WithEvents btn_prev As Button

    Property table As String
    Property page As Integer = 1
    Property custom_Sql As String = ""
    Property pagination_custom_Sql As String = ""
    Property columns As List(Of String)
    Property max_per_page As Integer = 15
    Property where As List(Of Criteria)
    Property orWhere As List(Of OrCriteria)
    Property whereExists As List(Of ExistsCriteria)
    Property parameters As List(Of CommandParameter)
    Property OrderBy As OrderBy
    Property GroupBy As GroupBy
    Property LeftOuterJoiner As List(Of LeftOuterJoin)

    Public Sub fetch()

        Try
            Dim reader = queryBuilder().ExecuteReader
            With list
                .Items.Clear()

                While reader.Read
                    Dim li = New ListViewItem
                    li.Text = reader.GetValue(0) ' For id or primary keys
                    For Each col As String In columns
                        li.SubItems.Add(getValue(reader, col))
                    Next

                    .Items.Add(li)
                End While
            End With
            reader.Close()

            setupPagination()
        Catch ex As Exception
            Console.WriteLine(String.Format("Sorry unable to fetch {0} : {1}", table, ex.Message))
            Console.WriteLine(ex)
        End Try

    End Sub

    Function queryBuilder() As MySql.Data.MySqlClient.MySqlCommand
        Dim Sql = String.Format("SELECT * FROM {0}", table)
        If Not custom_Sql = "" Then _
            Sql = custom_Sql

        Dim criterias = New List(Of String)

        ' orWhere - TODO
        If Not orWhere Is Nothing Then
            If orWhere.Count > 0 Then
                Dim wheres = New List(Of String)
                For Each criteria As OrCriteria In orWhere
                    wheres.Add(String.Format("{0} {1} @{2}", criteria.column, criteria.criteria, criteria.key))
                Next
                criterias.Add(String.Join(" OR ", wheres.ToArray()))
            End If
        End If

        ' Where
        If Not where Is Nothing Then
            If where.Count > 0 Then
                Dim wheres = New List(Of String)
                For Each criteria As Criteria In where
                    wheres.Add(String.Format("{0} {1} @{2}", criteria.column, criteria.criteria, criteria.key))
                Next
                If criterias.Count > 0 Then _
                    criterias.Add(" AND ")
                criterias.Add(String.Join(" AND ", wheres.ToArray()))
            End If
        End If

        Dim SqlCriteria As String = ""
        If criterias.Count > 0 Then
            SqlCriteria = String.Format("WHERE {0} ", String.Join(" ", criterias.ToArray()))
        End If

        Dim order_statement = ""
        If Not OrderBy Is Nothing Then
            If Not OrderBy.columns Is Nothing Then
                If Not OrderBy.columns.Count = 0 Then
                    order_statement = String.Format("ORDER BY {0} {1}", String.Join(", ", OrderBy.columns.ToArray()), OrderBy.type)
                End If
            End If
        End If

        Dim group_statement = ""
        If Not GroupBy Is Nothing Then
            If Not GroupBy.columns Is Nothing Then
                If Not GroupBy.columns.Count = 0 Then
                    group_statement = String.Format("GROUP BY {0}", String.Join(", ", GroupBy.columns.ToArray()))
                End If
            End If
        End If

        ' Left outer join {table} ON ...{}
        Dim joiner_statement = ""
        If Not LeftOuterJoiner Is Nothing Then
            If LeftOuterJoiner.Count > 0 Then
                Dim joiners = New List(Of String)
                For Each joiner As LeftOuterJoin In LeftOuterJoiner
                    Dim join_grammar = String.Format("{0}", joiner.table)
                    Dim jointers = New List(Of String)
                    For Each joiner_criteria As Criteria In joiner.Jointer
                        jointers.Add(String.Format("{0} {1} {2}", joiner_criteria.column, joiner_criteria.criteria, joiner_criteria.key))
                    Next
                    If jointers.Count > 0 Then _
                        join_grammar &= String.Format(" ON {0}", String.Join(" AND ", jointers))
                    joiners.Add(join_grammar)
                Next
                joiner_statement = String.Format("LEFT OUTER JOIN {0}", String.Join("LEFT OUTER JOIN", joiners))
            End If
        End If


        Dim pagination = IIf(max_per_page = 0, "", String.Format("LIMIT {0}, {1}", (page - 1) * max_per_page, max_per_page))
        grammar = String.Format("{0} {1} {2} {3} {4} {5}", Sql, joiner_statement, SqlCriteria, order_statement, group_statement, pagination)
        Dim command = New MySql.Data.MySqlClient.MySqlCommand(grammar, Database.GetInstance.GetConnection)

        If Not parameters Is Nothing Then
            If parameters.Count > 0 Then
                With command
                    For Each param In parameters
                        .Parameters.AddWithValue(String.Format("@{0}", param.param), param.value)
                    Next
                End With
            End If
        End If

        Return command
    End Function

    Function getValue(ByRef reader As MySql.Data.MySqlClient.MySqlDataReader, ByRef column As String) As Object
        Return IIf(IsDBNull(reader.GetValue(reader.GetOrdinal(column))), "", reader.GetValue(reader.GetOrdinal(column)))
    End Function

    Function getGrammar() As String
        Return grammar
    End Function

    Sub setupPagination()
        Try
            Dim original_page = page
            Dim original_grammar = grammar
            Dim original_custom_sql = custom_Sql
            Dim original_max_per_page = max_per_page

            max_per_page = max_per_page + 1
            custom_Sql = String.Format("SELECT COUNT(*) AS TOTAL FROM {0}", table)
            Dim total = queryBuilder().ExecuteScalar()

            page = 1
            max_per_page = 0
            custom_Sql = String.Format("SELECT COUNT(*) AS TOTAL FROM {0}", table)

            If Not pagination_custom_Sql = "" Then _
                custom_Sql = pagination_custom_Sql

            Dim total_pages = queryBuilder().ExecuteScalar() / original_max_per_page

            page = original_page
            pagination.Text = String.Format("Page {0:00} of {1:00}", original_page, IIf(Integer.Parse(Math.Round(total_pages)) < 1, 1, Integer.Parse(Math.Round(total_pages))))
            btn_next.Enabled = total_pages > original_page
            btn_prev.Enabled = page > 1

            grammar = original_grammar
            custom_Sql = original_custom_sql
            max_per_page = original_max_per_page
        Catch ex As Exception

        End Try
    End Sub

    Private Sub btn_next_Click(sender As Object, e As System.EventArgs) Handles btn_next.Click
        page += 1
        fetch()
    End Sub

    Private Sub btn_prev_Click(sender As Object, e As System.EventArgs) Handles btn_prev.Click
        page -= 1
        fetch()
    End Sub
End Class
