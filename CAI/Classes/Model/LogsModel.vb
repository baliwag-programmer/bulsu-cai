Imports System.Reflection

Public Class LogsAttribute
    Public Property id As Integer
    Public Property activity As String
    Public Property user_id As Integer
    Public Property type As String
    Public Property created_at As Date
End Class

Public Class LogsModel

    Public Property table As String = "user_logs"

    Public Property fillables As List(Of String)

    Public Property attributes As LogsAttribute

    Sub New()
        attributes = New LogsAttribute
        fillables = New List(Of String)
    End Sub

    Public Function create()
        Try
            Dim grammar = String.Format("INSERT INTO {0} (activity, user_id, type) VALUES (@activity, @user_id, @type); SELECT LAST_INSERT_ID();", table)
            Dim command = New MySql.Data.MySqlClient.MySqlCommand(grammar, Database.GetInstance.GetConnection)
            command.Parameters.AddWithValue("@activity", attributes.activity)
            command.Parameters.AddWithValue("@user_id", attributes.user_id)
            command.Parameters.AddWithValue("@type", attributes.type)
            Return command.ExecuteScalar()
        Catch ex As Exception
            Console.WriteLine(String.Format("Unable to create {0} : {1}", table, ex.Message))
        End Try
        Return False
    End Function

    Public Function getProperties()
        If attributes Is Nothing Then _
            attributes = New LogsAttribute
        Return attributes.GetType.GetProperties
    End Function

End Class
