Public Class Authentication

    Sub createRole(ByRef role As RoleModel)
        Try
            Dim command = New MySql.Data.MySqlClient.MySqlCommand("SELECT * FROM roles WHERE name = @role", Database.GetInstance.GetConnection)
            command.Parameters.AddWithValue("@role", role.name)
            Dim reader = command.ExecuteReader
            If Not reader.Read Then
                reader.Close()
                ' insert
                command = New MySql.Data.MySqlClient.MySqlCommand("INSERT INTO roles ( name, display_name ) VALUES ( @name, @display_name )", Database.GetInstance.GetConnection)
                command.Parameters.AddWithValue("@name", role.name)
                command.Parameters.AddWithValue("@display_name", role.display_name)
                command.ExecuteNonQuery()
            Else
                reader.Close()
            End If
        Catch ex As Exception
            Console.WriteLine(ex.Message)
        End Try
    End Sub

    Sub setupRole()

        Dim roles As New List(Of RoleModel)

        Dim admin As New RoleModel
        admin.name = "administrator"
        admin.display_name = "Administrator"
        createRole(admin)

        Dim student As New RoleModel
        student.name = "student"
        student.display_name = "Student"
        createRole(student)

        Dim instructor As New RoleModel
        instructor.name = "instructor"
        instructor.display_name = "Instructor"
        createRole(instructor)

    End Sub

    Private Function validation() As Boolean '
        If UsernameTextBox.Text = "" And PasswordTextBox.Text = "" Then
            MsgBox("Username and password is required.", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "Validation Error")
            UsernameTextBox.Focus()
            Return False
        End If

        If UsernameTextBox.Text = "" Then
            MsgBox("Username is required.", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "Validation Error")
            UsernameTextBox.Focus()
            Return False
        End If

        If PasswordTextBox.Text = "" Then
            MsgBox("Password is required.", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "Validation Error")
            PasswordTextBox.Focus()
            Return False
        End If

        If PasswordTextBox.TextLength < 5 Then
            MsgBox("Sorry password length must be atleast 5 characters.", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "Validation Error.")
            PasswordTextBox.Focus()
            Return False
        End If

        Return True
    End Function

    Private Sub BTNCreate_Click(sender As System.Object, e As System.EventArgs) Handles BTNLogin.Click
        If Not validation() Then _
            Exit Sub

        Try
            Dim con = Database.GetInstance.GetConnection
            Dim command = New MySql.Data.MySqlClient.MySqlCommand("SELECT id, lastname, firstname, middlename, username, instructor_id, password, dp, approved FROM users WHERE username = @username", con)
            command.Parameters.AddWithValue("@username", UsernameTextBox.Text)
            Dim reader = command.ExecuteReader
            If reader.Read Then

                Dim id As Integer = reader.GetValue(0)
                Dim last_name As String = IIf(reader.IsDBNull(1), "", reader.GetValue(1))
                Dim first_name As String = IIf(reader.IsDBNull(2), "", reader.GetValue(2))
                Dim middle_name As String = IIf(reader.IsDBNull(3), "", reader.GetValue(3))
                Dim username As String = IIf(reader.IsDBNull(4), "", reader.GetValue(4))
                Dim instructor_id As String = IIf(reader.IsDBNull(5), "", reader.GetValue(5))
                Dim dp As String = Database.GetInstance.readerValue(reader, "dp")
                Dim approved As Integer = Database.GetInstance.readerValue(reader, "approved")

                If Not PasswordTextBox.Text = Database.GetInstance.readerValue(reader, "password") Then
                    reader.Close()
                    GoTo invalid
                End If

                reader.Close()
                Dim logs = New LogsModel
                logs.attributes.activity = "Logged in"
                logs.attributes.user_id = id
                logs.attributes.type = "logon"
                logs.create()

                PasswordTextBox.Text = ""
                Dim user = Auth.GetInstance()
                user.id = id
                user.dp = dp
                user.username = username
                user.last_name = last_name
                user.first_name = first_name
                user.middle_name = middle_name
                user.instructor_id = IIf(String.IsNullOrEmpty(instructor_id), 0, instructor_id)
                user.approved = approved


                If user.role.name = "student" Then
                    If user.approved = 0 Then
                        MsgBox("Sorry your account is currently pending for approval by the instructor.", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "Account Not Approved.")
                        Exit Sub
                    End If
                End If

                MsgBox(String.Format("Welcome {0}, {1}, {2}", last_name, first_name, middle_name), MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "Successfully logged in.")
                Me.Hide()

                My.Application.SetAuth(user)

                If user.role.name = "student" Then
                    Dim form = New StudentMain
                    form.ShowDialog()
                End If

                If user.role.name = "administrator" Or user.role.name = "instructor" Then
                    Dim form = New AdminMainScreen
                    form.ShowDialog()
                End If

                Me.Show()
                Exit Sub
            End If
            reader.Close()
invalid:
            MsgBox("Invalid login credentials", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "Invalid")
            PasswordTextBox.Text = ""
        Catch ex As Exception
            LoggerModule.createLog(Me.ToString, LogType.Err)
            LoggerModule.createLog(ex.ToString, LogType.Err)

            MsgBox("Sorry unable to log in. Please see the latest log file for information.", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "Unable to login.")
        End Try
    End Sub

    Private Sub BTNCancel_Click(sender As System.Object, e As System.EventArgs) Handles BTNCancel.Click
        Dim confirm = MsgBox("Are you sure to quit the application?", MsgBoxStyle.YesNo + MsgBoxStyle.Question, "Exiting")
        If confirm = MsgBoxResult.Yes Then _
            Me.Close()
    End Sub

    Private Sub Authentication_KeyDown(sender As Object, e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown, UsernameTextBox.KeyDown, PasswordTextBox.KeyDown
        If e.Alt And e.KeyCode = Keys.F2 Then
            Process.Start(Config.GetInstance.getPath()).WaitForExit()
            Application.Exit()
        End If
    End Sub

    Sub loadDateTime()
        Dim strHostName As String
        strHostName = System.Net.Dns.GetHostName()
        lbl_display_ip.Text = strHostName
    End Sub

    Private Sub Authentication_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        'If Not IO.Directory.Exists(String.Format("{0}:/", Config.GetInstance.network_path)) Then
        '    'Auto map network drive
        '    If MsgBox("System detected that your network drive is not yet mounted." & vbNewLine & vbNewLine &
        '        String.Format("Do you want to automatically mount network drive {0}:/", Config.GetInstance.network_path),
        '        MsgBoxStyle.YesNo + MsgBoxStyle.Question, "Network drive not detected.") = MsgBoxResult.Yes Then
        '        NetworkModule1.MapDrive(
        '                Config.GetInstance.network_path,
        '                Config.GetInstance.network_address,
        '                Config.GetInstance.network_user,
        '                Config.GetInstance.network_password
        '            )
        '    End If
        'End If

        loadDateTime()
        ' Add any initialization after the InitializeComponent() call.
        setupRole()
        Try
            Dim command = New MySql.Data.MySqlClient.MySqlCommand("SELECT COUNT(id) FROM users;", Database.GetInstance.GetConnection)
            Dim total_user = command.ExecuteScalar
            If total_user = 0 Then
                Dim confirm = MsgBox("System detected their is no administrator account yet." & vbNewLine & vbNewLine & "Do you want to create administrator now?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "No Data Found")
                If confirm = MsgBoxResult.Yes Then
                    Dim form = New UserForm(UserForm.Mode.Create, UserForm.Role.Administrator)
                    form.ShowDialog()
                End If
            End If

        Catch ex As Exception

        End Try
    End Sub

    Private Sub link_register_student_LinkClicked(sender As System.Object, e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles link_register_student.LinkClicked
        Dim form = New UserForm(UserForm.Mode.Create, UserForm.Role.Student, True)
        Me.Hide()
        form.ShowDialog()
        Me.Show()
    End Sub
End Class
