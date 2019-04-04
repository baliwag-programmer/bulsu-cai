Imports System.Net

Public Class AdminMain

    WithEvents Auth As Auth
    WithEvents timer As New Timer

    Sub loadDateTime()
        lbl_date.Text = Format(Now(), "MMMM dd, yyyy")
        Dim strHostName As String
        strHostName = System.Net.Dns.GetHostName()
        lbl_host_ip.Text = strHostName
    End Sub

    Sub loadStatistics()
        lbl_total_instructor.Text = String.Format("{0:000}", countUser)
        lbl_total_student.Text = String.Format("{0:000}", countUser("student"))
        lbl_total_administrator.Text = String.Format("{0:000}", countUser("administrator"))
    End Sub

    Sub loadUserDetails() Handles Auth.UserUpdated
        lbl_role.Text = Auth.GetInstance.role.display_name
        If Not Auth.GetInstance.dp = "" Then _
            dp_user_profile.Image = Image.FromFile(Auth.GetInstance.dp)
        If Auth.GetInstance.dp = "" Then _
            dp_user_profile.Image = My.Resources.icons8_user_96
        lbl_name.Text = String.Format("{0}, {1}, {2}", Auth.GetInstance.last_name, Auth.GetInstance.first_name, Auth.GetInstance.middle_name)
    End Sub

    Function countUser(Optional ByRef role As String = "instructor") As Integer
        countUser = 0
        Try
            Dim command = New MySql.Data.MySqlClient.MySqlCommand("SELECT COUNT(*) as TOTAL FROM users WHERE EXISTS ( SELECT * FROM role_user WHERE users.id = role_user.user_id AND EXISTS ( SELECT * FROM roles WHERE name = @name AND role_user.role_id = roles.id ) )", Database.GetInstance.GetConnection)
            command.Parameters.AddWithValue("@name", role)
            countUser = command.ExecuteScalar()
        Catch ex As Exception
            Console.WriteLine(ex.Message)
        End Try
        Return countUser
    End Function

    Private Sub AdminMain_FormClosing(sender As Object, e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        Dim confirm = MsgBox("Are you sure to logout?", MsgBoxStyle.YesNo + MsgBoxStyle.Question, "Are you sure?")
        If Not confirm = MsgBoxResult.Yes Then _
            e.Cancel = True
    End Sub

    Private Sub AdminMain_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Auth = CAI.Auth.GetInstance
        loadDateTime()

        With timer
            .Interval = 1000
            .Start()
        End With

        loadStatistics()
        loadUserDetails()
        AddHandler Auth.UserUpdated, _
            AddressOf loadUserDetails
    End Sub

    Private Sub timer_Tick(sender As Object, e As System.EventArgs) Handles timer.Tick
        lbl_time.Text = Format(Now(), "hh:mm:ss tt")
    End Sub

    Private Sub BTNInstructor_Click(sender As System.Object, e As System.EventArgs) Handles BTNInstructor.Click
        Dim form = New UserList(role:=UserList.Role.Instructor)
        Me.Hide()
        form.ShowDialog()
        Me.Show()
    End Sub

    Private Sub BTNAdmin_Click(sender As System.Object, e As System.EventArgs) Handles BTNAdmin.Click
        Dim form = New UserList
        Me.Hide()
        form.ShowDialog()
        Me.Show()
    End Sub

    Private Sub BTNLogs_Click(sender As System.Object, e As System.EventArgs) Handles BTNLogs.Click
        Dim form = New ActivityLogs
        Me.Hide()
        form.ShowDialog()
        Me.Show()
    End Sub

    Private Sub BTNSettings_Click(sender As System.Object, e As System.EventArgs) Handles BTNSettings.Click
        Dim form = New UserViewer(Auth.GetInstance.id)
        Me.Hide()
        form.ShowDialog()
        Me.Show()
    End Sub

    Private Sub BTNExit_Click(sender As System.Object, e As System.EventArgs) Handles BTNExit.Click
        Me.Close()
    End Sub

    Private Sub BTNSecurity_Click(sender As System.Object, e As System.EventArgs) Handles BTNSecurity.Click
        Dim form = New UpdatePassword(Auth.GetInstance.id)
        Me.Hide()
        form.ShowDialog()
        Me.Show()
    End Sub

End Class