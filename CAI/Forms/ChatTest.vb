Imports System.Windows.Forms

Public Class ChatTest

    Private Sub btn_message_Click(sender As System.Object, e As System.EventArgs) Handles btn_message.Click

    End Sub

    Private Sub ChatTest_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Dim sock = New Socket
        sock.connect()
    End Sub
End Class
