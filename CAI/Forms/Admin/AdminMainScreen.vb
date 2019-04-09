Imports System.ComponentModel

Public Class AdminMainScreen

    Private Sub OnActionClick(sender As Object, e As MouseEventArgs) Handles LabelViewLogReport.MouseClick, LabelMonitoring.MouseClick, LabelAccountManagement.MouseClick, BTNViewLogReport.MouseClick, BTNMonitoring.MouseClick, BTNAccountManagement.MouseClick

        If sender Is BTNAccountManagement Or sender Is LabelAccountManagement Then
            Dim AMForm = New UserListRev2
            Me.Hide()
            AMForm.ShowDialog()
            Me.Show()
        End If

        If sender Is BTNMonitoring Or sender Is LabelMonitoring Then

        End If

        If sender Is BTNViewLogReport Or sender Is LabelViewLogReport Then

        End If

    End Sub

    Private Sub OnDateTimeChanged(ByRef CurrentDateTime As Date)
        If Not Me.IsDisposed Then
            Me.LabelDate.Text = Format(CurrentDateTime, "Long Date")
            Me.LabelTime.Text = Format(CurrentDateTime, "hh:mm:ss tt")
        End If
    End Sub

    Private Sub OnFormLoad(sender As Object, e As EventArgs) Handles MyBase.Load
        AddHandler My.Application.OnDateTimeChanged, AddressOf OnDateTimeChanged
        FillAuthDetails()
    End Sub

    Private Sub FillAuthDetails()
        Dim Auth = My.Application.GetAuth()
        If Not Auth Is Nothing Then
            Avatar.Image = ImageModule.Base64ToImage(Auth.dp)
            LabelFullName.Text = String.Format("{0}, {1}, {2}", Auth.last_name, Auth.first_name, Auth.middle_name).ToUpper()
            LabelAccountType.Text = Auth.role.display_name.ToUpper()
        End If
    End Sub

End Class