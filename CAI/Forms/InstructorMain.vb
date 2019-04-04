Imports System.Windows.Forms

Public Class InstructorMain

    WithEvents Auth As CAI.Auth
    WithEvents timer As New Timer

    Sub loadDateTime()
        lbl_date.Text = Format(Now(), "MMMM dd, yyyy")
    End Sub

    Sub loadStatistics()
        lbl_total_lessons.Text = String.Format("{0:00}", countLessons())
        lbl_total_student.Text = String.Format("{0:00}", countUser("student"))
        lbl_total_test.Text = String.Format("{0:00}", countTests())
    End Sub

    Function countUser(Optional ByRef role As String = "instructor") As Integer
        countUser = 0
        Try
            Dim command = New MySql.Data.MySqlClient.MySqlCommand("SELECT COUNT(*) as TOTAL FROM users WHERE instructor_id = @id AND EXISTS ( SELECT * FROM role_user WHERE users.id = role_user.user_id AND EXISTS ( SELECT * FROM roles WHERE name = @name AND role_user.role_id = roles.id ) )", Database.GetInstance.GetConnection)
            command.Parameters.AddWithValue("@name", role)
            command.Parameters.AddWithValue("@id", Auth.GetInstance.id)
            countUser = command.ExecuteScalar()
        Catch ex As Exception
            Console.WriteLine(ex.Message)
        End Try
        Return countUser
    End Function

    Function countLessons() As Integer
        countLessons = 0
        Try
            Dim command = New MySql.Data.MySqlClient.MySqlCommand("SELECT COUNT(*) AS TOTAL FROM lessons WHERE instructor_id = @id", Database.GetInstance.GetConnection)
            command.Parameters.AddWithValue("@id", Auth.GetInstance.id)
            countLessons = command.ExecuteScalar()
        Catch ex As Exception
            Console.WriteLine(ex.Message)
        End Try
        Return countLessons
    End Function

    Function countTests() As Integer
        countTests = 0
        Try
            Dim command = New MySql.Data.MySqlClient.MySqlCommand("SELECT COUNT(*) AS TOTAL FROM tests WHERE instructor_id = @id", Database.GetInstance.GetConnection)
            command.Parameters.AddWithValue("@id", Auth.GetInstance.id)
            countTests = command.ExecuteScalar()
        Catch ex As Exception
            Console.WriteLine(ex.Message)
        End Try
        Return countTests
    End Function

    Sub loadUserDetails()
        lbl_role.Text = Auth.GetInstance.role.name
        lbl_name.Text = String.Format("{0}, {1}, {2}", Auth.GetInstance.last_name, Auth.GetInstance.first_name, Auth.GetInstance.middle_name)

        If Not Auth.GetInstance.dp = "" Then _
            dp_user_profile.Image = Image.FromFile(Auth.GetInstance.dp)
        If Auth.GetInstance.dp = "" Then _
            dp_user_profile.Image = My.Resources.icons8_user_96
    End Sub

    Private Sub BTNLesson_Click(sender As System.Object, e As System.EventArgs) Handles BTNLesson.Click
        Dim form = New LessonList
        Me.Hide()
        form.ShowDialog()
        Me.Show()
    End Sub

    Private Sub BTNStudent_Click(sender As System.Object, e As System.EventArgs) Handles BTNStudent.Click
        Dim form = New UserList(UserList.Role.Student)
        Me.Hide()
        form.ShowDialog()
        Me.Show()
    End Sub

    Private Sub InstructorMain_FormClosing(sender As Object, e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        If Not Auth.GetInstance.isPreview Then
            Dim confirm = MsgBox("Are you sure to logout?", MsgBoxStyle.YesNo + MsgBoxStyle.Question, "Are you sure?")
            If Not confirm = MsgBoxResult.Yes Then _
                e.Cancel = True
        End If
    End Sub

    Private Function hasForApproval() As Boolean
        hasForApproval = False

        Try
            Dim query_rule = String.Format("SELECT COUNT(*) FROM users WHERE approved = 0 AND EXISTS (SELECT * FROM role_user WHERE EXISTS (SELECT * FROM roles WHERE name = '{0}' AND role_user.role_id = roles.id) AND users.id = role_user.user_id AND users.instructor_id = {1})", "student", Auth.GetInstance.id)
            Dim command = New MySql.Data.MySqlClient.MySqlCommand(query_rule, Database.GetInstance.GetConnection)
            Dim total = command.ExecuteScalar()

            hasForApproval = total > 0
        Catch ex As Exception
            Console.WriteLine("Unable to fetch has forApproval")
            Console.WriteLine(ex)
        End Try

        Return hasForApproval
    End Function

    Private Sub InstructorMain_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Auth = CAI.Auth.GetInstance
        If Auth.GetInstance.isPreview Then
            BTNExit.Text = "Exit Preview".ToUpper() & vbNewLine & vbNewLine
            GroupBox1.Text = String.Format("Viewing {0} Account", Auth.GetInstance.role.display_name)
        End If

        With timer
            .Interval = 1000
            .Start()
        End With

        loadDateTime()
        loadStatistics()
        loadUserDetails()

        AddHandler Auth.UserUpdated, _
            AddressOf loadUserDetails

        BTNApproval.Enabled = hasForApproval()
    End Sub

    Private Sub timer_Tick(sender As Object, e As System.EventArgs) Handles timer.Tick
        lbl_time.Text = Format(Now(), "hh:mm:ss tt")
    End Sub

    Private Sub BTNTest_Click(sender As System.Object, e As System.EventArgs) Handles BTNTest.Click
        Dim form = New TestList
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

    Private Sub BTNApproval_Click(sender As System.Object, e As System.EventArgs) Handles BTNApproval.Click
        Dim form = New UserList(CAI.UserList.Role.Student, True)
        Me.Hide()
        form.ShowDialog()
        Me.Show()

        BTNApproval.Enabled = hasForApproval()
    End Sub
End Class
