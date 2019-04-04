Imports System.Windows.Forms

Public Class StudentMain

    Private WithEvents Auth As CAI.Auth
    Private WithEvents timer As Timer

    Sub loadDateTime()
        lbl_date.Text = Format(Now(), "MMMM dd, yyyy")
    End Sub

    Private Sub timer_Tick(sender As Object, e As System.EventArgs) Handles timer.Tick
        lbl_time.Text = Format(Now(), "hh:mm:ss tt")
    End Sub

    Function totalLessons() As Integer

        Try
            Dim command = New MySql.Data.MySqlClient.MySqlCommand("SELECT COUNT(*) AS TOTAL from lessons WHERE instructor_id = @id", Database.GetInstance.GetConnection)
            With command.Parameters
                .AddWithValue("@id", Auth.GetInstance.instructor_id)
            End With
            Return command.ExecuteScalar()
        Catch ex As Exception
            Console.WriteLine("Unable to count all lessons.")
            Console.WriteLine(ex)
        End Try

        Return 0
    End Function

    Function totalTests() As Integer
        Try
            Dim command = New MySql.Data.MySqlClient.MySqlCommand("SELECT COUNT(*) AS TOTAL from tests WHERE instructor_id = @id", Database.GetInstance.GetConnection)
            With command.Parameters
                .AddWithValue("@id", Auth.GetInstance.instructor_id)
            End With
            Return command.ExecuteScalar()
        Catch ex As Exception
            Console.WriteLine("Unable to count all lessons.")
            Console.WriteLine(ex)
        End Try

        Return 0
    End Function

    Function totalTakenTests() As Integer
        Try
            Dim command = New MySql.Data.MySqlClient.MySqlCommand("SELECT COUNT(*) AS TOTAL from users_tests WHERE user_id = @id", Database.GetInstance.GetConnection)
            With command.Parameters
                .AddWithValue("@id", Auth.GetInstance.id)
            End With
            Return command.ExecuteScalar()
        Catch ex As Exception
            Console.WriteLine("Unable to count all totalTakenTests.")
            Console.WriteLine(ex)
        End Try
        Return 0
    End Function

    Private Sub loadStatistics()
        lbl_total_lessons.Text = String.Format("{0:00}", totalLessons)
        lbl_total_untaken_test.Text = String.Format("{0:00}", totalTests)
        lbl_total_test_taken.Text = String.Format("{0:00}", totalTakenTests)

        If totalTests() = 0 Then
            ' Start Taking Pre Test
            ' First validate if has pre-test

        End If
    End Sub

    Private Sub BTNSettings_Click(sender As System.Object, e As System.EventArgs) Handles BTNSettings.Click
        Dim form = New UserViewer(Auth.GetInstance.id)
        Me.Hide()
        form.ShowDialog()
        Me.Show()
    End Sub

    Private Sub StudentMain_FormClosing(sender As Object, e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        If Not Auth.GetInstance.isPreview Then
            Dim confirm = MsgBox("Are you sure to logout?", MsgBoxStyle.YesNo + MsgBoxStyle.Question, "Are you sure?")
            If Not confirm = MsgBoxResult.Yes Then _
                e.Cancel = True
        End If
    End Sub

    Private Sub StudentMain_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Auth = CAI.Auth.GetInstance
        If Auth.GetInstance.isPreview Then
            BTNExit.Text = "Exit Preview".ToUpper() & vbNewLine & vbNewLine
            GroupBox1.Text = String.Format("Viewing {0} Account", Auth.GetInstance.role.display_name)
        End If

        timer = New Timer
        timer.Interval = 1000
        timer.Start()

        loadUserDetails()
        loadDateTime()
        loadStatistics()

        AddHandler Auth.UserUpdated, _
            AddressOf loadUserDetails
    End Sub

    Sub loadUserDetails()
        lbl_id.Text = Auth.GetInstance.username
        lbl_role.Text = Auth.GetInstance.role.display_name
        lbl_name.Text = String.Format("{0}, {1}, {2}", Auth.GetInstance.last_name, Auth.GetInstance.first_name, Auth.GetInstance.middle_name)

        If Not Auth.GetInstance.dp = "" Then _
            dp_user_profile.Image = Image.FromFile(Auth.GetInstance.dp)
        If Auth.GetInstance.dp = "" Then _
            dp_user_profile.Image = My.Resources.icons8_user_96
    End Sub

    Private Sub BTNStudent_Click(sender As System.Object, e As System.EventArgs) Handles BTNStudent.Click
        Dim form = New StudentLessonViewerV2
        Me.Hide()
        form.ShowDialog()
        Me.Show()
    End Sub

    Private Sub BTNLesson_Click(sender As System.Object, e As System.EventArgs) Handles BTNLesson.Click
        Dim form = New StudentTestResult
        Me.Hide()
        form.ShowDialog()
        Me.Show()
    End Sub

    Private Sub BTNTest_Click(sender As System.Object, e As System.EventArgs) Handles BTNTest.Click
        Dim form As New TestList
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
