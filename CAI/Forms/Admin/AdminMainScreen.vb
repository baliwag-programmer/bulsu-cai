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
            Dim form = New ActivityLogs
            Me.Hide()
            form.ShowDialog()
            Me.Show()
        End If

    End Sub

    Private Sub OnDateTimeChanged(ByRef CurrentDateTime As Date)
        Try
            Me.LabelDate.Text = Format(CurrentDateTime, "Long Date")
            Me.LabelTime.Text = Format(CurrentDateTime, "hh:mm:ss tt")
        Catch ex As Exception

        End Try
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

    Private Sub OnClickProfileAction(sender As Object, e As EventArgs) Handles ButtonSecurity.Click, ButtonProfile.Click
        If sender Is ButtonSecurity Then
            Dim form = New UpdatePassword(Auth.GetInstance.id)
            Me.Hide()
            form.ShowDialog()
            Me.Show()
        End If

        If sender Is ButtonProfile Then
            Dim form = New UserViewer(Auth.GetInstance.id)
            Me.Hide()
            form.ShowDialog()
            Me.Show()
        End If
    End Sub

End Class