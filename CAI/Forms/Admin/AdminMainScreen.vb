Imports System.ComponentModel

Public Class AdminMainScreen

    Private Sub OnActionClick(sender As Object, e As MouseEventArgs) Handles LabelViewLogReport.MouseClick, LabelMonitoring.MouseClick, LabelAccountManagement.MouseClick, BTNViewLogReport.MouseClick, BTNMonitoring.MouseClick, BTNAccountManagement.MouseClick, PictureBox1.MouseClick, Label2.MouseClick

        If sender Is BTNAccountManagement Or sender Is LabelAccountManagement Then
            Dim AMForm = New UserListRev2
            Me.Hide()
            AMForm.ShowDialog()
            Me.Show()
        End If

        If sender Is BTNMonitoring Or sender Is LabelMonitoring Then
            Dim form = New UserList(role:=UserList.Role.Instructor)
            Me.Hide()
            form.ShowDialog()
            Me.Show()
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

    Private Sub IntializeRoleBasedControl(auth As Auth)
        InstructorControlPanel.Visible = auth.role.name = "instructor"
        AdministratorControlPanel.Visible = auth.role.name = "administrator"
    End Sub

    Private Sub FillAuthDetails()
        Dim Auth = My.Application.GetAuth()
        If Not Auth Is Nothing Then
            Avatar.Image = ImageModule.Base64ToImage(Auth.dp)
            LabelFullName.Text = String.Format("{0}, {1}, {2}", Auth.last_name, Auth.first_name, Auth.middle_name).ToUpper()
            LabelAccountType.Text = Auth.role.display_name.ToUpper()
            IntializeRoleBasedControl(Auth)
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

    Private Sub OnLogout(sender As Object, e As EventArgs) Handles PictureBox1.Click, Label2.Click
        Me.Close()
    End Sub

    Private Sub AdminMainScreen_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        e.Cancel = Not MsgBox("Are you sure to logout?", MsgBoxStyle.YesNo + MsgBoxStyle.Question, "Are you sure?") = MsgBoxResult.Yes
    End Sub

    Private Sub OnEnable(sender As Object, e As EventArgs)
        Dim control As PictureBox = sender
        If control.Enabled Then
        End If
    End Sub

    Private Sub OnInstructorAction(sender As Object, e As EventArgs) Handles LabelActionTestManagement.Click, LabelActionStudentManagement.Click, LabelActionLessonManagement.Click, LabelActionApprovalManagement.Click, ActionTestManagement.Click, ActionStudentManagement.Click, ActionLessonManagement.Click, ActionApprovalManagement.Click

    End Sub

    Private Sub OnInstructorButtonChangedState(sender As Object, state As Boolean) Handles ActionTestManagement.OnStateChanged, ActionStudentManagement.OnStateChanged, ActionLessonManagement.OnStateChanged, ActionApprovalManagement.OnStateChanged
        Dim control As ImageShower = sender
        If state Then
            control.Cursor = Cursors.Hand
        Else
            control.Cursor = Cursors.No
        End If
    End Sub
End Class