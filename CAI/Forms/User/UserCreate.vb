Imports System.Windows.Forms

Public Class UserCreate

    Private for_register As Boolean
    Private profile_path As String
    Private instructor_dictionary As New List(Of String)
    Private global_role As UserList.Role

    Sub New(Optional ByRef role As UserList.Role = UserList.Role.Administrator, Optional ByRef is_registration As Boolean = False)

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        form_title.Text = "ADD ADMINISTRATOR"
        global_role = role
        If global_role = UserList.Role.Instructor Then _
            form_title.Text = "ADD INSTRUCTOR"
        If global_role = UserList.Role.Student Then
            Label1.Text = "Student Number :"
            form_title.Text = "ADD STUDENT"
            for_register = is_registration
            If for_register Then
                form_title.Text = "REGISTER AS STUDENT"
                fetchInstructors()

                Label8.Visible = True
                CMBInstructor.Visible = True
            End If
        End If
    End Sub

    Private Sub fetchInstructors()
        Try
            CMBInstructor.Items.Clear()
            Dim query_rule = String.Format("SELECT * FROM users WHERE EXISTS (SELECT * FROM role_user WHERE EXISTS (SELECT * FROM roles WHERE name = '{0}' AND role_user.role_id = roles.id) AND users.id = role_user.user_id)", "instructor")
            Dim command = New MySql.Data.MySqlClient.MySqlCommand(query_rule, Database.GetInstance.GetConnection)
            Dim reader = command.ExecuteReader
            While reader.Read
                Dim display = String.Format("{1}, {2}, {3}", Database.GetInstance.readerValue(reader, "username"),
                                             Database.GetInstance.readerValue(reader, "lastname"),
                                              Database.GetInstance.readerValue(reader, "firstname"),
                                               Database.GetInstance.readerValue(reader, "middlename"))
                instructor_dictionary.Add(Database.GetInstance.readerValue(reader, "id"))
                CMBInstructor.Items.Add(display)
            End While
            reader.Close()
        Catch ex As Exception
            Console.WriteLine("Unable to fetch instructors.")
            Console.WriteLine(ex)
        End Try
    End Sub

    Function validation() As Boolean
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

        If for_register Then
            If CMBInstructor.Text = "" Then
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

    Function fetchInstructorId(ByRef username As String)
        Dim id = 0
        Try
            Dim command = New MySql.Data.MySqlClient.MySqlCommand("SELECT * FROM users WHERE username = @username", Database.GetInstance.GetConnection)
            command.Parameters.AddWithValue("@username", username)
            Dim reader = command.ExecuteReader
            If reader.Read Then _
                id = reader.GetValue(0)
            reader.Close()
        Catch ex As Exception
            Console.WriteLine("Sorry unable to fetch user id")
            Console.WriteLine(ex)
        End Try
        Return id
    End Function

    Private Sub OK_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BTNSave.Click
        Try
            If Not validation() Then _
                Exit Sub

            Dim instructor_id = 0
            If for_register Then
                ' identify who is the prof
                'Dim selected = CMBInstructor.Text.Split("-")(0)
                instructor_id = instructor_dictionary.ToArray()(CMBInstructor.SelectedIndex)
            End If

            Dim SQL = "INSERT INTO users ( username, lastname, firstname, middlename, password, dp ) VALUES ( @username, @lastname, @firstname, @middlename, @password, @dp ); SELECT LAST_INSERT_ID();"
            If (Not for_register) Then _
                SQL = "INSERT INTO users ( username, lastname, firstname, middlename, password, dp, approved ) VALUES ( @username, @lastname, @firstname, @middlename, @password, @dp, 1 ); SELECT LAST_INSERT_ID();"

            Dim command = New MySql.Data.MySqlClient.MySqlCommand(SQL, Database.GetInstance.GetConnection)
            command.Parameters.AddWithValue("@username", txt_username.Text)
            command.Parameters.AddWithValue("@lastname", txt_last_name.Text)
            command.Parameters.AddWithValue("@firstname", txt_first_name.Text)
            command.Parameters.AddWithValue("@middlename", txt_middle.Text)
            command.Parameters.AddWithValue("@password", txt_password.Text)
            command.Parameters.AddWithValue("@dp", ImageModule.ImageToBase64(ImageModule.ReadImageFromPath(profile_path)))
            Dim user_id = command.ExecuteScalar()
            ' Bind the role
            Dim role_id As Integer
            Dim role_name = IIf(global_role = UserList.Role.Administrator, "administrator", IIf(global_role = UserList.Role.Instructor, "instructor", "student"))
            command = New MySql.Data.MySqlClient.MySqlCommand("SELECT * FROM roles WHERE name = @role", Database.GetInstance.GetConnection)
            command.Parameters.AddWithValue("@role", role_name)
            Dim reader = command.ExecuteReader
            If reader.Read Then _
                role_id = reader.GetValue(0)
            reader.Close()

            command = New MySql.Data.MySqlClient.MySqlCommand("INSERT INTO role_user ( role_id, user_id, user_type ) VALUES ( @role, @user, @user_type )", Database.GetInstance.GetConnection)
            command.Parameters.AddWithValue("@role", role_id)
            command.Parameters.AddWithValue("@user", user_id)
            command.Parameters.AddWithValue("@user_type", role_name)
            command.ExecuteNonQuery()

            If global_role = UserList.Role.Student Then
                command = New MySql.Data.MySqlClient.MySqlCommand("UPDATE users SET instructor_id = @user WHERE id = @student", Database.GetInstance.GetConnection)
                If Not for_register Then _
                    command.Parameters.AddWithValue("@user", Auth.GetInstance.id)
                If for_register Then _
                    command.Parameters.AddWithValue("@user", instructor_id)
                command.Parameters.AddWithValue("@student", user_id)
                command.ExecuteNonQuery()
            End If

            If Not for_register Then
                Dim logs = New LogsModel
                logs.attributes.type = "USER_CREATED"
                logs.attributes.user_id = Auth.GetInstance.id
                logs.attributes.activity = String.Format("New user is created `({0}) {1}`", IIf(global_role = UserList.Role.Administrator, "administrator", IIf(global_role = UserList.Role.Instructor, "instructor", "student")), txt_username)
                logs.create()
            End If

            If Not for_register Then _
                MsgBox(String.Format("Successfully created new {0} account.", IIf(global_role = UserList.Role.Administrator, "administrator", IIf(global_role = UserList.Role.Instructor, "instructor", "student"))))
            If for_register Then _
                MsgBox("Successfully submitted your request for an account.", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "Submitted Request For An Account.")
        Catch ex As Exception
            Console.WriteLine(ex)
        End Try

        Me.DialogResult = System.Windows.Forms.DialogResult.OK
        Me.Close()
    End Sub

    Private Sub Cancel_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BTNCancel.Click
        Me.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Close()
    End Sub

    Private Sub pict_user_pict_Click(sender As System.Object, e As System.EventArgs) Handles pict_user_pict.Click
        Dim file = New OpenFileDialog
        file.ShowDialog()
        If Not file.FileName = "" Then
            profile_path = file.FileName
            pict_user_pict.Image = Image.FromFile(profile_path)
        End If
    End Sub

    Private Sub UserCreate_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load

    End Sub
End Class
