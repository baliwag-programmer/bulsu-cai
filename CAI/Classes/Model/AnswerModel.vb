<Serializable()>
Public Class AnswerAttribute
    Public Property id As Integer
    Public Property answer As String
    Public Property is_correct As Integer
    Public Property question_id As Integer
    Public Property created_at As Date
End Class

Public Class AnswerModel

    Public Property table As String = "answers"

    Public Property fillables As List(Of String)

    Public Property attributes As AnswerAttribute

    Sub New()
        attributes = New AnswerAttribute
        fillables = New List(Of String)
    End Sub

    Public Function getProperties()
        If attributes Is Nothing Then _
            attributes = New AnswerAttribute
        Return attributes.GetType.GetProperties
    End Function

    Public Function create()
        Dim command = New MySql.Data.MySqlClient.MySqlCommand("INSERT INTO answers (answer,question_id,is_correct) VALUES (@answer,@question_id,@is_correct); SELECT LAST_INSERT_ID();", Database.GetInstance.GetConnection)
        With command.Parameters
            .AddWithValue("@answer", Me.attributes.answer)
            .AddWithValue("@question_id", Me.attributes.question_id)
            .AddWithValue("@is_correct", Me.attributes.is_correct)
        End With
        Return command.ExecuteScalar()
    End Function

    Shared Function find(p1 As Object) As AnswerModel
        Try
            Dim command = New MySql.Data.MySqlClient.MySqlCommand("SELECT * FROM answers WHERE id = @id", Database.GetInstance.GetConnection)
            Dim reader = command.ExecuteReader
            If reader.Read Then
                Dim answer = New AnswerModel
                answer.attributes.id = reader.GetValue(0)
                answer.attributes.answer = IIf(IsDBNull(reader.GetValue(reader.GetOrdinal("answer"))), "", reader.GetValue(reader.GetOrdinal("answer")))
                answer.attributes.is_correct = reader.GetValue(reader.GetOrdinal("is_correct"))
                reader.Close()
                Return answer
            End If
            reader.Close()
        Catch ex As Exception
            Console.WriteLine("Sorry unable to find `Answer`")
            Console.WriteLine(ex)
        End Try

        Return Nothing
    End Function

End Class
