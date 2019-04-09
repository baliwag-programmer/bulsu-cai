Public Class UserListRev2

    Private auto_list As ListviewAutomation
    Private UserDetailWrapperWidth As Integer

    Private Sub OnFormLoad(sender As Object, e As EventArgs) Handles Me.Load
        Me.UserDetailWrapperWidth = Me.UserDetailWrapper.Width

        UserDetailWrapper.Width = 0
        Me.ComboBox1.SelectedIndex = 0
    End Sub

    Private Sub OnActionClick(sender As Object, e As EventArgs) Handles Button1.Click, BTNEdit.Click, BTNCreate.Click
        If sender Is BTNCreate Then
            Dim AccountForm As New UserForm(UserForm.Mode.Create)
            Me.Hide()
            AccountForm.ShowDialog()
            Me.Show()
        End If
    End Sub
End Class