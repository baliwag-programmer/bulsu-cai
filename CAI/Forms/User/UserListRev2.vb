Public Class UserListRev2

    Private auto_list As ListviewAutomation
    Private UserDetailWrapperWidth As Integer

    Private Sub OnFormLoad(sender As Object, e As EventArgs) Handles Me.Load
        Me.UserDetailWrapperWidth = Me.UserDetailWrapper.Width

        UserDetailWrapper.Width = 0
        Me.ComboBox1.SelectedIndex = 0
    End Sub

    Private Sub OnSelectUser(sender As Object, e As EventArgs)

    End Sub

End Class