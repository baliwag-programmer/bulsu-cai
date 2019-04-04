Imports System.Windows.Forms
Public Class ConfigurationManager

    Sub loadConfig()
        txt_host.Text = Config.GetInstance.database
        txt_username.Text = Config.GetInstance.user
        txt_port.Text = Config.GetInstance.port

        ' First load the database
        Try
            Dim command = New MySql.Data.MySqlClient.MySqlCommand("SHOW DATABASES", Database.GetInstance.initConnection)
            Dim reader = command.ExecuteReader
            If reader.Read Then

            End If
            reader.Close()
        Catch ex As Exception

        End Try

        combo_database.Text = Config.GetInstance.database
    End Sub

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        Me.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Close()
    End Sub

End Class
