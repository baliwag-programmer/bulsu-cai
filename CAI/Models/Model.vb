Imports MySql.Data.MySqlClient

Public Class Model

    Dim DB As Database
    Dim command As MySqlCommand
    Dim reader As MySqlDataReader

    Class pagination
        Shared skip As Integer = 0
        Shared limit As Integer = 15
        Shared next_page As Integer = 0
        Shared prev_page As Integer = 0
    End Class

    Public table As String
    Public datas As List(Of Model)
    Public attributes As List(Of Attribute)

    Public Sub New()
        DB = Database.GetInstance()
    End Sub

    Public Function fetch()
        Dim selections As New List(Of String)
        selections.Add("*")
        If Not attributes Is Nothing Then
            If attributes.Count > 0 Then
                selections.Clear()
                For Each attribute As Attribute In attributes
                    selections.Add(attribute.name & " as " & attribute.display)
                Next
            End If
        End If
        Console.WriteLine("SELECT " & String.Join(", ", selections.ToArray()) & " FROM " & Me.table)
        'Dim adapter As MySqlDataAdapter = New MySqlDataAdapter("SELECT " & String.Join(", ", selections) & " FROM " & table, DB.GetConnection())
    End Function

    Public Function find()

    End Function

    Public Function create()

    End Function

    Public Function update()

    End Function

    Public Function destroy()

    End Function

    Public Function simplePaginate()

    End Function

End Class
