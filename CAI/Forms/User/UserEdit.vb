Imports System.Windows.Forms

Public Class UserEdit
    WithEvents Auth As Auth
    Private user_id As String
    Private dp_profile As String
    Private CurrentRole As UserList.Role

#Region "Batching Data"
    Private _Year As Integer
    Private _SY_To As Integer
    Private _SY_From As Integer
    Private _Section As String


    Private Property Year As Integer
        Set(value As Integer)
            _Year = value
            LabelYearSection.Text = String.Format("YEAR && SECTION: {0:00}-{1}", _Year, _Section)
        End Set
        Get
            Return IIf(CurrentRole = UserList.Role.Student, _Year, Nothing)
        End Get
    End Property
    Private Property SY_To As Integer
        Set(value As Integer)
            _SY_To = value
            LabelSY.Text = String.Format("SY: {0}-{1}", _SY_From, _SY_To)
        End Set
        Get
            Return IIf(CurrentRole = UserList.Role.Student, _SY_To, Nothing)
        End Get
    End Property
    Private Property SY_From As Integer
        Set(value As Integer)
            _SY_From = value
            LabelSY.Text = String.Format("SY: {0}-{1}", _SY_From, _SY_To)
        End Set
        Get
            Return IIf(CurrentRole = UserList.Role.Student, _SY_From, Nothing)
        End Get
    End Property
    Private Property Section As String
        Set(value As String)
            _Section = value
            LabelYearSection.Text = String.Format("YEAR && SECTION: {0:00}-{1}", _Year, _Section)
        End Set
        Get
            Return IIf(CurrentRole = UserList.Role.Student, _Section, Nothing)
        End Get
    End Property
#End Region

    Sub New(ByRef user_id As String, Optional ByRef role As UserList.Role = UserList.Role.Administrator)

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.

        CurrentRole = role
        Heading1.Title = "EDITING ADMINISTRATOR"
        If role = UserList.Role.Instructor Then _
            Heading1.Title = "EDITING INSTRUCTOR"
        If role = UserList.Role.Student Then
            Label1.Text = "Student Number :"
            Heading1.Title = "EDITING STUDENT"
            Me.Width = 701
            GroupBox1.Visible = True
        End If

        Me.user_id = user_id
        fetchDetails()
        Auth = CAI.Auth.GetInstance

        If Me.user_id = Auth.id Then
            Heading1.Title = "EDITTING PROFILE"
            If Auth.role.name = "student" Then
                Me.Width = 701
                GroupBox1.Visible = True
                CurrentRole = UserList.Role.Student
            End If
        End If
    End Sub

    Sub fetchDetails()
        Try
            Dim UpdatedBySQL = "SELECT concat(lastname,', ',firstname,', ',middlename) FROM users as updated_by_details WHERE updated_by_details.id = IF(ISNULL(users.updated_by), users.id, users.updated_by)"
            Dim command = New MySql.Data.MySqlClient.MySqlCommand(String.Format("SELECT id, username, lastname, firstname, middlename, dp, DATE_FORMAT(updated_at, '%a %b %d, %Y @ %h:%m') as updated_at, ({0}) as last_updated_by, sy_from, sy_to, year, section FROM users WHERE id = @id", UpdatedBySQL), Database.GetInstance.GetConnection)
            command.Parameters.AddWithValue("@id", Me.user_id)
            Dim reader = command.ExecuteReader
            If Not reader.Read Then
                reader.Close()
                MsgBox("Sorry invalid user record", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, "Invalid Data")
                Me.Close()
                Exit Sub
            End If
            Dim username = IIf(IsDBNull(reader.GetValue(1)), "", reader.GetValue(1))
            Dim last_name = IIf(IsDBNull(reader.GetValue(2)), "", reader.GetValue(2))
            Dim first_name = IIf(IsDBNull(reader.GetValue(3)), "", reader.GetValue(3))
            Dim middle_name = IIf(IsDBNull(reader.GetValue(4)), "", reader.GetValue(4))
            Dim dp = Database.GetInstance.readerValue(reader, "dp")
            Dim avatar = ImageModule.Base64ToImage(dp)
            Dim last_updated_date = Database.GetInstance.readerValue(reader, "updated_at")
            Dim last_updated_by = Database.GetInstance.readerValue(reader, "last_updated_by")

#Region "Batch Details"
            If Not IsDBNull(reader("year")) Then _
                Year = reader("year")
            If Not IsDBNull(reader("sy_to")) Then _
                SY_To = reader("sy_to")
            If Not IsDBNull(reader("sy_from")) Then _
                SY_From = reader("sy_from")
            If Not IsDBNull(reader("section")) Then _
                 Section = reader("section")
#End Region

            pict_user_pict.Image = My.Resources.icons8_user_96
            reader.Close()

            txt_username.Text = username
            txt_last_name.Text = last_name
            txt_first_name.Text = first_name
            txt_middle.Text = middle_name

            DisplayLastUpdatedBy.Text = last_updated_by
            DisplayLastUpdatedDate.Text = last_updated_date
            dp_profile = dp

            If Not avatar Is Nothing Then _
                pict_user_pict.Image = avatar

        Catch ex As Exception
            LoggerModule.createLog(Me.ToString, LogType.Err)
            LoggerModule.createLog(ex.ToString, LogType.Err)
        End Try
    End Sub

    Function validation() As Boolean
        Try
            Dim command = New MySql.Data.MySqlClient.MySqlCommand("SELECT * FROM users WHERE username = @username AND id <> @id", Database.GetInstance.GetConnection)
            command.Parameters.AddWithValue("@id", user_id)
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

    Private Sub BTNSave_Click(sender As System.Object, e As System.EventArgs) Handles BTNSave.Click
        Try
            If Not validation() Then _
                Exit Sub
            Dim command = New MySql.Data.MySqlClient.MySqlCommand("UPDATE users SET username = @username, lastname = @lastname, firstname = @firstname, middlename = @middlename, dp = @dp, sy_from = @sy_from, sy_to = @sy_to, year = @year, section = @section, updated_by = @updatedBy WHERE id = @id", Database.GetInstance.GetConnection)
            command.Parameters.AddWithValue("@id", user_id)
            command.Parameters.AddWithValue("@dp", dp_profile)
            command.Parameters.AddWithValue("@username", txt_username.Text)
            command.Parameters.AddWithValue("@lastname", txt_last_name.Text)
            command.Parameters.AddWithValue("@firstname", txt_first_name.Text)
            command.Parameters.AddWithValue("@middlename", txt_middle.Text)
            command.Parameters.AddWithValue("@updatedBy", Auth.GetInstance.id)

            With command.Parameters
                .AddWithValue("@year", Year)
                .AddWithValue("@sy_to", SY_To)
                .AddWithValue("@sy_from", SY_From)
                .AddWithValue("@section", Section)
            End With

            command.ExecuteNonQuery()
            Dim logs = New LogsModel
            If Not user_id = Auth.GetInstance.id Then
                logs.attributes.type = "USER_UPDATED"
                logs.attributes.user_id = Auth.GetInstance.id
                logs.attributes.activity = "User updated details of `{0}` - `{}`."
                logs.create()
            Else
                logs.attributes.type = "USER_UPDATED_PROFILE"
                logs.attributes.user_id = Auth.GetInstance.id
                logs.attributes.activity = "User updated details."
                logs.create()
                Auth.dp = dp_profile
                Auth.username = txt_username.Text
                Auth.last_name = txt_last_name.Text
                Auth.first_name = txt_first_name.Text
                Auth.middle_name = txt_middle.Text

                Auth.updatedDetails()
            End If
            MsgBox("Successfully updated user details.", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "Success")

            If Auth.GetInstance.id = Me.user_id Then
                Auth.GetInstance.dp = dp_profile
                Auth.GetInstance.middle_name = txt_middle.Text
                Auth.GetInstance.first_name = txt_username.Text
                Auth.GetInstance.last_name = txt_last_name.Text
                Auth.GetInstance.first_name = txt_first_name.Text
            End If
        Catch ex As Exception
        End Try
        Me.DialogResult = System.Windows.Forms.DialogResult.OK
        Me.Close()
    End Sub

    Private Sub BTNCancel_Click(sender As System.Object, e As System.EventArgs) Handles BTNCancel.Click
        Me.DialogResult = Windows.Forms.DialogResult.Cancel
        Me.Close()
    End Sub

    Private Sub PictureBox1_Click(sender As System.Object, e As System.EventArgs) Handles pict_user_pict.Click, LabelActionChangeImage.Click
        Dim file = New OpenFileDialog
        file.ShowDialog()
        If Not file.FileName = "" Then
            Dim avatar = ImageModule.ReadImageFromPath(file.FileName)
            pict_user_pict.Image = avatar
            dp_profile = ImageModule.ImageToBase64(avatar)
        End If
    End Sub

    Private Sub OnChangeBatchDetails(sender As Object, e As EventArgs) Handles PictureBox1.Click
        Dim BatchInforGather = New StudentBatchInformation(False)
        With BatchInforGather
            .TXTYear.Text = Year()
            .TXTYearTo.Text = SY_To
            .TXTSection.Text = Section
            .TXTYearFrom.Text = SY_From

            Me.Visible = False
            Dim result = BatchInforGather.ShowDialog()

            Year = .TXTYear.Text
            SY_To = .TXTYearTo.Text
            Section = .TXTSection.Text
            SY_From = .TXTYearFrom.Text
            Me.Visible = True
        End With
    End Sub
End Class
