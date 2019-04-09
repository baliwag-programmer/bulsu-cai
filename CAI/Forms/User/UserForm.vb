﻿Imports System.Windows.Forms

Public Class UserForm

#Region "Enumerators"
    Public Enum Mode
        Create
        Edit
        Preview
    End Enum

    Public Enum Role
        Instructor
        Administrator
        Student
    End Enum
#End Region

#Region "Private Variables"
    Private CurrentMode As Mode
    Private ProfilePath As String
    Private PreferredRole As Role
    Private HasPreferredRole As Boolean = False
    Private StudentAccountRequest As Boolean = False
#End Region

    Sub New()
        InitializeComponent()
    End Sub

    Sub New(Optional ByRef mode As Mode = Mode.Create)
        InitializeComponent()
        Me.CurrentMode = mode
    End Sub

    Sub New(ByRef mode As Mode, ByRef role As Role)
        InitializeComponent()

        PreferredRole = role
        Me.CurrentMode = mode
        HasPreferredRole = True
    End Sub

    Sub New(ByRef mode As Mode, ByRef role As Role, ByRef request As Boolean)
        InitializeComponent()
        PreferredRole = role
        Me.CurrentMode = mode
        HasPreferredRole = True
        StudentAccountRequest = request
    End Sub

    Private Sub UserForm_Load(sender As Object, e As EventArgs) Handles Me.Load
        If Not CurrentMode = Mode.Create Then
            Heading1.Title = "EDIT ACCOUNT"
            If CurrentMode = Mode.Preview Then _
                Heading1.Title = "PREVIEW ACCOUNT"
        End If

        If HasPreferredRole Then
            If PreferredRole = Role.Student Then
                LabelAccountType.Text = "INSTRUCTOR NAME :"
                LabelUsername.Text = "STUDENT NUMBER :"
                Me.Heading1.Title = "REGISTER AS STUDENT"

                fetchInstructors()
            Else
                Me.ComboAccountType.Enabled = False
                Me.ComboAccountType.SelectedIndex = PreferredRole
            End If
        End If

    End Sub

    Private Sub OnSelectDP(sender As Object, e As EventArgs) Handles LabelActionChangeImage.Click, pict_user_pict.Click
        Dim file = New OpenFileDialog
        file.ShowDialog()
        If Not file.FileName = "" Then
            ProfilePath = file.FileName
            pict_user_pict.Image = ImageModule.ReadImageFromPath(ProfilePath)
        End If
    End Sub

    Private Sub BTNCancel_Click(sender As Object, e As EventArgs) Handles BTNCancel.Click
        Me.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Close()
    End Sub

    Function validation() As Boolean

        If txt_first_name.TextLength < 1 Then
            txt_first_name.Focus()
            MsgBox("Sorry first name is required.", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "Validation Error.")
            Return False
        End If

        If txt_last_name.TextLength < 1 Then
            txt_last_name.Focus()
            MsgBox("Sorry last name is required.", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "Validation Error.")
            Return False
        End If

        If txt_username.TextLength < 1 Then
            txt_username.Focus()
            MsgBox("Sorry username is required.", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "Validation Error.")
            Return False
        End If

        If txt_password.Text <> txt_password_confirmation.Text Then
            txt_password.Focus()
            MsgBox("Sorry password does not matched.", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "Validation Error.")
            Return False
        End If

        If txt_password.TextLength < 5 Then
            MsgBox("Sorry password length must be atleast 5 characters.", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "Validation Error.")
            txt_password.Focus()
            Return False
        End If

        If StudentAccountRequest Then
            If ComboAccountType.Text = "" Then
                MsgBox("Sorry you have to select your instructor.", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "Select Prof.")
                Return False
            End If
        End If

        Try
            Dim command = New MySql.Data.MySqlClient.MySqlCommand("SELECT * FROM users WHERE username = @username", Database.GetInstance.GetConnection)
            command.Parameters.AddWithValue("@username", txt_username.Text)
            Dim reader = command.ExecuteReader
            If reader.Read Then
                MsgBox(String.Format("Sorry username `{0}` already exist.", txt_username.Text), MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "Validation Error")
                reader.Close()
                txt_username.Focus()
                Return False
            End If
            reader.Close()
        Catch ex As Exception

        End Try
        Return True
    End Function

    Private Sub fetchInstructors()
        Try
            ComboAccountType.Items.Clear()
            Dim query_rule = String.Format("SELECT * FROM users WHERE EXISTS (SELECT * FROM role_user WHERE EXISTS (SELECT * FROM roles WHERE name = '{0}' AND role_user.role_id = roles.id) AND users.id = role_user.user_id)", "instructor")
            Dim command = New MySql.Data.MySqlClient.MySqlCommand(query_rule, Database.GetInstance.GetConnection)
            Dim reader = command.ExecuteReader
            While reader.Read
                Dim display = String.Format("{0}-{1}, {2}, {3}", Database.GetInstance.readerValue(reader, "username"),
                                             Database.GetInstance.readerValue(reader, "lastname"),
                                              Database.GetInstance.readerValue(reader, "firstname"),
                                               Database.GetInstance.readerValue(reader, "middlename"))
                ComboAccountType.Items.Add(display)
            End While
            reader.Close()

            MsgBox(ComboAccountType.Items.Count)
            If ComboAccountType.Items.Count = 0 Then
                MsgBox("Sorry their is no available instructor data.", MsgBoxStyle.Information + MsgBoxStyle.OkCancel, "Currently not available.")
                Me.Close()
            End If
        Catch ex As Exception
            LoggerModule.createLog(Me.ToString, LogType.Err)
            LoggerModule.createLog(ex.ToString(), LogType.Err)
        End Try
    End Sub

    Function FetchInstructorID(ByRef username As String)
        Dim id = 0
        Try
            Dim command = New MySql.Data.MySqlClient.MySqlCommand("SELECT * FROM users WHERE username = @username", Database.GetInstance.GetConnection)
            command.Parameters.AddWithValue("@username", username)
            Dim reader = command.ExecuteReader
            If reader.Read Then _
                id = reader.GetValue(0)
            reader.Close()
        Catch ex As Exception
            LoggerModule.createLog(Me.ToString, LogType.Err)
            LoggerModule.createLog(ex.ToString(), LogType.Err)
        End Try
        Return id
    End Function

    Private Sub OnSave(sender As Object, e As EventArgs) Handles BTNSave.Click
        If Not validation() Then Exit Sub

        Try

            Dim instructor_id = 0
            Dim role As Role = ComboAccountType.SelectedIndex
            If StudentAccountRequest Then
                role = Role.Student
                ' identify who is the prof
                Dim selected = ComboAccountType.Text.Split("-")(0)
                instructor_id = FetchInstructorID(selected)
            End If

            Dim command = New MySql.Data.MySqlClient.MySqlCommand("INSERT INTO users ( username, lastname, firstname, middlename, password, dp ) VALUES ( @username, @lastname, @firstname, @middlename, @password, @dp ); SELECT LAST_INSERT_ID();", Database.GetInstance.GetConnection)
            command.Parameters.AddWithValue("@username", txt_username.Text)
            command.Parameters.AddWithValue("@lastname", txt_last_name.Text)
            command.Parameters.AddWithValue("@firstname", txt_first_name.Text)
            command.Parameters.AddWithValue("@middlename", txt_middle.Text)
            command.Parameters.AddWithValue("@password", txt_password.Text)
            command.Parameters.AddWithValue("@dp", ImageModule.ImageToBase64(pict_user_pict.Image))
            Dim user_id = command.ExecuteScalar()

            ' Bind the role
            Dim role_id As Integer
            command = New MySql.Data.MySqlClient.MySqlCommand("SELECT * FROM roles WHERE name = @role", Database.GetInstance.GetConnection)
            command.Parameters.AddWithValue("@role", IIf(role = UserList.Role.Administrator, "administrator", IIf(role = UserList.Role.Instructor, "instructor", "student")))
            Dim reader = command.ExecuteReader
            If reader.Read Then _
                role_id = reader.GetValue(0)
            reader.Close()

            command = New MySql.Data.MySqlClient.MySqlCommand("INSERT INTO role_user ( role_id, user_id, user_type ) VALUES ( @role, @user, @type )", Database.GetInstance.GetConnection)
            command.Parameters.AddWithValue("@role", role_id)
            command.Parameters.AddWithValue("@user", user_id)
            command.Parameters.AddWithValue("@type", IIf(role = UserList.Role.Administrator, "administrator", IIf(role = UserList.Role.Instructor, "instructor", "student")))
            command.ExecuteNonQuery()

            ' Student
            If role = UserList.Role.Student Then
                command = New MySql.Data.MySqlClient.MySqlCommand("UPDATE users SET instructor_id = @user WHERE id = @student", Database.GetInstance.GetConnection)
                If Not StudentAccountRequest Then _
                    command.Parameters.AddWithValue("@user", Auth.GetInstance.id)
                If StudentAccountRequest Then _
                    command.Parameters.AddWithValue("@user", instructor_id)
                command.Parameters.AddWithValue("@student", user_id)
                command.ExecuteNonQuery()
            End If

            If Not Me.StudentAccountRequest Then
                Dim logs = New LogsModel
                logs.attributes.type = "USER_CREATED"
                logs.attributes.user_id = Auth.GetInstance.id
                logs.attributes.activity = String.Format("New account is created `({0}) {1}`", IIf(ComboAccountType.SelectedIndex = UserList.Role.Administrator, "administrator", IIf(ComboAccountType.SelectedIndex = UserList.Role.Instructor, "instructor", "student")), txt_username)
                logs.create()
            End If

            Dim message = String.Format("Successfully created new {0} account.", IIf(ComboAccountType.SelectedIndex = UserList.Role.Administrator, "administrator", IIf(ComboAccountType.SelectedIndex = UserList.Role.Instructor, "instructor", "student")))

            ' Student message
            If Me.StudentAccountRequest Then _
                MsgBox("Successfully submitted your request for an account.", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "Submitted Request For An Account.")
            MsgBox(message, MsgBoxStyle.Information + MsgBoxStyle.OkOnly)

        Catch ex As Exception
            LoggerModule.createLog(Me.ToString, LogType.Err)
            LoggerModule.createLog(ex.ToString(), LogType.Err)
        End Try
        Me.DialogResult = DialogResult.OK
        Me.Close()
    End Sub

End Class