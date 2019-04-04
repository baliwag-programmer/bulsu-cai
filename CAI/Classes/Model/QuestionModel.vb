
Public Class QuestionAttribute
    Public Property id As Integer
    Public Property type As String
    Public Property question As String
    Public Property test_id As Integer
    Public Property created_at As Date
    Public Property answers As List(Of AnswerModel)
End Class

Public Class QuestionModel

    Public Property table As String = "questions"

    Public Property fillables As List(Of String)

    Public Property attributes As QuestionAttribute

    Sub New()
        attributes = New QuestionAttribute
        fillables = New List(Of String)
    End Sub

    Public Function getProperties()
        If attributes Is Nothing Then _
            attributes = New QuestionAttribute
        Return attributes.GetType.GetProperties
    End Function

    Public Function create() As QuestionModel
        Try
            Dim command = New MySql.Data.MySqlClient.MySqlCommand("INSERT INTO questions ( question, test_id, type ) VALUES ( @question, @test_id, @type ); SELECT LAST_INSERT_ID();", Database.GetInstance.GetConnection)
            With command.Parameters
                .AddWithValue("@question", Me.attributes.question)
                .AddWithValue("@test_id", Me.attributes.test_id)
                .AddWithValue("@type", Me.attributes.type)
            End With

            Me.attributes.id = command.ExecuteScalar
            Return Me
        Catch ex As Exception
            Console.WriteLine("Sorry unable to create Question")
            Console.WriteLine(ex)
        End Try

        Return Nothing
    End Function

    Public Function update() As QuestionModel
        Try
            Dim command = New MySql.Data.MySqlClient.MySqlCommand("UPDATE questions SET question = @question, type = @type WHERE id = @id", Database.GetInstance.GetConnection)
            With command.Parameters
                .AddWithValue("@id", Me.attributes.id)
                .AddWithValue("@type", Me.attributes.type)
                .AddWithValue("@question", Me.attributes.question)
            End With

            command.ExecuteNonQuery()
            Return Me
        Catch ex As Exception
            Console.WriteLine("Sorry unable to create Question")
            Console.WriteLine(ex)
        End Try

        Return Nothing
    End Function

End Class
