Imports System.Windows.Forms

Public Class UpdatePassword

    Private user_id As Integer

    Sub New(Optional ByRef id As Integer = 0)

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        user_id = id
    End Sub

    Private Sub BTNCancel_Click(sender As System.Object, e As System.EventArgs) Handles BTNCancel.Click
        Dim confirm = MsgBox("Are you sure to cancel updating your password?", MsgBoxStyle.YesNo + MsgBoxStyle.Question, "Are you sure?")
        If confirm = MsgBoxResult.Yes Then
            Me.DialogResult = Windows.Forms.DialogResult.Cancel
            Me.Close()
        End If
    End Sub

    Public Function validation() As Boolean
        If txt_current.Text = "" Then
            MsgBox("Sorry current password must be confirmed first.", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "Validation error.")
            txt_current.Focus()
            Return False
        End If

        If txt_password.Text = "" Then
            MsgBox("Sorry new password is required.", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "Validation error.")
            txt_password.Focus()
            Return False
        End If

        If txt_password_confirmation.Text = "" Then
            MsgBox("Sorry password confirmation is required.", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "Validation error.")
            txt_password_confirmation.Focus()
            Return False
        End If

        If Not txt_password.Text = txt_password_confirmation.Text Then
            MsgBox("Sorry new password not matched.", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "Validation error.")
            txt_password_confirmation.Focus()
            Return False
        End If

        If txt_password.TextLength < 5 Then
            MsgBox("Sorry password length must be atleast 5 characters.", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "Validation Error.")
            txt_password.Focus()
            Return False
        End If

        Try
            Dim command = New MySql.Data.MySqlClient.MySqlCommand("SELECT COUNT(*) AS TOTAL FROM users WHERE password = @password AND id = @id", Database.GetInstance.GetConnection)
            With command.Parameters
                .AddWithValue("@password", txt_current.Text)
                .AddWithValue("@id", user_id)
            End With
            Dim password_matched = command.ExecuteScalar
            If password_matched = 0 Then
                MsgBox("Sorry current password not matched.", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "Validation error.")
                txt_current.Focus()
                Return False
            End If
        Catch ex As Exception
            Console.WriteLine("UNable to update password.")
            Console.WriteLine(ex)
            Return False
        End Try

        Return True
    End Function

    Private Sub BTNSave_Click(sender As System.Object, e As System.EventArgs) Handles BTNSave.Click
        If Not validation() Then _
            Exit Sub

        Try
            Dim command = New MySql.Data.MySqlClient.MySqlCommand("UPDATE users SET password = @password WHERE id = @id", Database.GetInstance.GetConnection)
            With command.Parameters
                .AddWithValue("@id", user_id)
                .AddWithValue("@password", txt_password.Text)
            End With
            command.ExecuteNonQuery()

            Dim logs = New LogsModel
            logs.attributes.type = "PASSWORD_UPDATED"
            logs.attributes.user_id = Auth.GetInstance.id
            logs.attributes.activity = "Password changed"
            logs.create()

            MsgBox("Successfully updated password.", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "Success.")
            Me.DialogResult = Windows.Forms.DialogResult.OK
            Me.Close()
        Catch ex As Exception
            Console.WriteLine("Sorry unable to update password.")
            Console.WriteLine(ex)
        End Try
    End Sub

    Private Sub UpdatePassword_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
    End Sub

End Class
