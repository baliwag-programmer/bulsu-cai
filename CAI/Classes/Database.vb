Imports System
Imports System.Windows.Forms
Imports System.ComponentModel
Imports MySql.Data.MySqlClient
Imports AppConfig = CAI.Config
Public Class Database

    Class DBconfig
        Property server As String = ""
        Property port = 3306
        Property database As String = ""
        Property user As String = ""
        Property password As String = ""
    End Class
    Shared config As DBconfig
    Shared instance As Database = Nothing
    Shared connection As MySql.Data.MySqlClient.MySqlConnection

    Sub New()
        config = New DBconfig
        config.user = AppConfig.GetInstance().user
        config.port = AppConfig.GetInstance().port
        config.server = AppConfig.GetInstance().server
        config.database = AppConfig.GetInstance().database
        config.password = AppConfig.GetInstance().password

        connection = initConnection()
        Try
            Dim command = New MySql.Data.MySqlClient.MySqlCommand("SHOW TABLES; SELECT FOUND_ROWS();", connection)
            Dim rows = command.ExecuteScalar
            Dim sql = My.Resources.cai_setup
            If rows = "" Then
                Dim confirm = MsgBox("System detected that database table is not yet configured." & vbNewLine & vbNewLine & "Do want to run database setup?", MsgBoxStyle.YesNo + MsgBoxStyle.Question, "No Database.")
                If confirm = MsgBoxResult.Yes Then
                    command = New MySql.Data.MySqlClient.MySqlCommand(sql, connection)
                    command.ExecuteScalar()

                    MsgBox("Successfully configured database." & vbNewLine & vbNewLine & String.Format(" {0} will now restart.", Application.ProductName), MsgBoxStyle.Information + vbOKOnly, "Success")
                    Application.Restart()
                    Exit Sub
                End If
            End If
        Catch ex As Exception
            connection = Nothing
            Console.WriteLine(ex)
        End Try
    End Sub

    Public Function initConnection(Optional ByRef with_db As Boolean = False) As MySqlConnection
        Dim connection_string As New List(Of String)
        connection_string.Add("server=" & config.server)
        connection_string.Add("user=" & config.user)
        If with_db Then _
            connection_string.Add("database=" & config.database)
        connection_string.Add("port=" & config.port)
        connection_string.Add("password=" & config.password)
        initConnection = New MySql.Data.MySqlClient.MySqlConnection(String.Join(";", connection_string.ToArray()))
        Try
            initConnection.Open()
            If initConnection.State = ConnectionState.Open And Not with_db Then
                Dim command = New MySqlCommand("CREATE DATABASE IF NOT EXISTS " & config.database, initConnection)
                command.ExecuteNonQuery()
                initConnection.Close()

                Return initConnection(True)
            End If
        Catch ex As Exception
            Console.WriteLine(ex.Message)
            Return Nothing
        End Try

        Return initConnection
    End Function

    Public Shared Function GetInstance() As Database
        If instance Is Nothing Then _
            instance = New Database()
        Return instance
    End Function

    Public Function GetConnection() As MySql.Data.MySqlClient.MySqlConnection
        Return connection
    End Function

    Public Function readerValue(ByRef reader As MySql.Data.MySqlClient.MySqlDataReader, ByRef col As String) As Object
        Return IIf(IsDBNull(reader.GetValue(reader.GetOrdinal(col))), "", reader.GetValue(reader.GetOrdinal(col)))
    End Function

End Class
