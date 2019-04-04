Imports System.Windows.Forms

Public Class LessonEdit
    Private id As String
    Public Sub New(ByRef id As String)

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        Me.id = id
        fetchDetails(Me.id)
    End Sub

    Sub fetchDetails(ByRef id As String)
        Try
            Dim command = New MySql.Data.MySqlClient.MySqlCommand("SELECT title, description FROM lessons WHERE id = @id", Database.GetInstance().GetConnection())
            command.Parameters.AddWithValue("@id", id)
            Dim reader = command.ExecuteReader
            If reader.Read Then
                TxtTitle.Text = reader.GetValue(0)
                TxtDescription.Text = reader.GetValue(1)
            End If
            reader.Close()
        Catch ex As MySql.Data.MySqlClient.MySqlException
            Console.WriteLine(ex.Message)
        End Try
    End Sub

    Sub updateDetails(ByRef id As String)
        Try
            Dim command = New MySql.Data.MySqlClient.MySqlCommand("UPDATE lessons SET title = @title, description = @description WHERE id = @id", Database.GetInstance().GetConnection())
            command.Parameters.AddWithValue("@title", TxtTitle.Text)
            command.Parameters.AddWithValue("@description", TxtDescription.Text)
            command.Parameters.AddWithValue("@id", id)
            command.ExecuteNonQuery()

            MsgBox("Successfully updated lesson details.", MsgBoxStyle.OkOnly + MsgBoxStyle.Information, "Success")
        Catch ex As MySql.Data.MySqlClient.MySqlException
            Console.WriteLine(ex.Message)
        End Try
    End Sub

    Private Sub OK_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK_Button.Click
        updateDetails(Me.id)
        Me.DialogResult = System.Windows.Forms.DialogResult.OK
        Me.Close()
    End Sub

    Private Sub Cancel_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel_Button.Click
        Me.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Close()
    End Sub

    Private Sub LessonEdit_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load

    End Sub
End Class
