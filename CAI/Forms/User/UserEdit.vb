﻿Imports System.Windows.Forms

Public Class UserEdit
    WithEvents Auth As Auth
    Private user_id As String
    Private dp_profile As String
    Sub New(ByRef user_id As String, Optional ByRef role As UserList.Role = UserList.Role.Administrator)

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.

        form_title.Text = "EDITING ADMINISTRATOR"
        If role = UserList.Role.Instructor Then _
            form_title.Text = "EDITING INSTRUCTOR"
        If role = UserList.Role.Student Then
            Label1.Text = "Student Number :"
            form_title.Text = "EDITING STUDENT"
        End If

        Me.user_id = user_id
        fetchDetails()
        Auth = CAI.Auth.GetInstance

        If Me.user_id = Auth.id Then _
            form_title.Text = "EDITTING PROFILE"
    End Sub

    Sub fetchDetails()
        Try
            Dim command = New MySql.Data.MySqlClient.MySqlCommand("SELECT id, username, lastname, firstname, middlename, dp FROM users WHERE id = @id", Database.GetInstance.GetConnection)
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
            reader.Close()

            txt_username.Text = username
            txt_last_name.Text = last_name
            txt_first_name.Text = first_name
            txt_middle.Text = middle_name
            If Not dp = "" Then _
                PictureBox1.Image = Image.FromFile(dp)
            If dp = "" Then _
                PictureBox1.Image = My.Resources.icons8_user_96

        Catch ex As Exception
            Console.WriteLine("Unable to fetch user details")
            Console.WriteLine(ex)
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
            Dim command = New MySql.Data.MySqlClient.MySqlCommand("UPDATE users SET username = @username, lastname = @lastname, firstname = @firstname, middlename = @middlename, dp = @dp WHERE id = @id", Database.GetInstance.GetConnection)
            command.Parameters.AddWithValue("@id", user_id)
            command.Parameters.AddWithValue("@dp", dp_profile)
            command.Parameters.AddWithValue("@username", txt_username.Text)
            command.Parameters.AddWithValue("@lastname", txt_last_name.Text)
            command.Parameters.AddWithValue("@firstname", txt_first_name.Text)
            command.Parameters.AddWithValue("@middlename", txt_middle.Text)
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
        Catch ex As Exception
        End Try
        Me.DialogResult = System.Windows.Forms.DialogResult.OK
        Me.Close()
    End Sub

    Private Sub BTNCancel_Click(sender As System.Object, e As System.EventArgs) Handles BTNCancel.Click
        Me.DialogResult = Windows.Forms.DialogResult.Cancel
        Me.Close()
    End Sub

    Private Sub PictureBox1_Click(sender As System.Object, e As System.EventArgs) Handles PictureBox1.Click
        Dim file = New OpenFileDialog
        file.ShowDialog()
        If Not file.FileName = "" Then
            dp_profile = file.FileName
            PictureBox1.Image = Image.FromFile(dp_profile)
            dp_profile = Auth.saveAvatar(dp_profile)
        End If
    End Sub

    Private Sub UserEdit_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load

    End Sub
End Class
