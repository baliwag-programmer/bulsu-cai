Imports System.Windows.Forms

Public Class LessonCreate

    Private id As String
    Private attachment As OpenFileDialog

    Public Sub New(Optional ByRef id As String = "")

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        attachment = New OpenFileDialog
        If Not id = "" Then
            Me.id = id
            fetchDetails(Me.id)
            form_title.Text = "EDITTING LESSON"
        End If
    End Sub

    Function generateSlug(ByRef value As String) As String
        Dim data = value.Split(" ").ToList()
        Dim processed = New List(Of String)
        For Each Val As String In data
            processed.Add(UCase(Val.Substring(0, 1)) & Val.Substring(1))
        Next

        Return String.Join("", processed.ToArray())
    End Function

    Sub saveAttachment(ByRef attachment_file As String, ByRef filename As String)
        Dim path = LessonModel.attachment_path
        IO.File.Copy(attachment_file, String.Format("{0}/{1}", path, filename), True)

        Dim command = New MySql.Data.MySqlClient.MySqlCommand("UPDATE lessons SET attachment = @filename WHERE id = @id", Database.GetInstance.GetConnection)
        With command.Parameters
            .AddWithValue("@id", id)
            .AddWithValue("@filename", filename)
        End With
        command.ExecuteNonQuery()
    End Sub

    Sub save()
        Try
            Dim command = New MySql.Data.MySqlClient.MySqlCommand("INSERT INTO lessons ( title, slug, description, created_at, instructor_id ) VALUES ( @title, @slug, @description, CURRENT_TIMESTAMP, @user ); SELECT LAST_INSERT_ID();", Database.GetInstance().GetConnection())
            command.Parameters.AddWithValue("@title", Me.TxtTitle.Text)
            command.Parameters.AddWithValue("@slug", generateSlug(Me.TxtTitle.Text))
            command.Parameters.AddWithValue("@user", Auth.GetInstance.id)
            command.Parameters.AddWithValue("@description", Me.TxtDescription.Text)
            id = command.ExecuteScalar()
            If Not attachment.FileName = "" Then _
                saveAttachment(attachment.FileName, String.Format("{0}{1}", id, System.IO.Path.GetExtension(attachment.FileName)))

            Dim logs = New LogsModel
            logs.attributes.activity = String.Format("Created new lesson `{0}`", Me.TxtTitle.Text)
            logs.attributes.user_id = Auth.GetInstance.id
            logs.attributes.type = "LESSON_CREATE"
            logs.create()
        Catch ex As MySql.Data.MySqlClient.MySqlException
            Console.WriteLine(ex.Message)
        End Try
    End Sub

    Private Sub BTNSave_Click(sender As System.Object, e As System.EventArgs) Handles BTNSave.Click
        If Me.id = "" Then
            save()

            TxtTitle.Text = ""
            TxtDescription.Text = ""

            Me.DialogResult = Windows.Forms.DialogResult.OK
            Me.Close()
            Exit Sub
        End If

        updateDetails(id)
    End Sub

    Private Sub BTNCancel_Click(sender As Object, e As System.EventArgs) Handles BTNCancel.Click
        Me.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Close()
    End Sub

    Sub fetchDetails(ByRef id As String)
        Try
            Dim command = New MySql.Data.MySqlClient.MySqlCommand("SELECT title, description FROM lessons WHERE id = @id", Database.GetInstance().GetConnection())
            command.Parameters.AddWithValue("@id", id)
            Dim reader = command.ExecuteReader
            If reader.Read Then
                TxtTitle.Text = reader.GetValue(0)
                TxtDescription.Text = reader.GetValue(1)
            End If
            reader.Close()
        Catch ex As MySql.Data.MySqlClient.MySqlException
            Console.WriteLine(ex.Message)
        End Try
    End Sub

    Sub updateDetails(ByRef id As String)
        Try
            Dim command = New MySql.Data.MySqlClient.MySqlCommand("UPDATE lessons SET title = @title, description = @description WHERE id = @id;", Database.GetInstance().GetConnection())
            command.Parameters.AddWithValue("@title", TxtTitle.Text)
            command.Parameters.AddWithValue("@description", TxtDescription.Text)
            command.Parameters.AddWithValue("@id", id)
            command.ExecuteNonQuery()

            If Not attachment.FileName = "" Then _
                saveAttachment(attachment.FileName, String.Format("{0}{1}", id, System.IO.Path.GetExtension(attachment.FileName)))
            MsgBox("Successfully updated lesson details.", MsgBoxStyle.OkOnly + MsgBoxStyle.Information, "Success")

            Me.DialogResult = Windows.Forms.DialogResult.OK

            Dim logs = New LogsModel
            logs.attributes.activity = String.Format("Updated lesson `{0} - {1}`", id, Me.TxtTitle.Text)
            logs.attributes.user_id = Auth.GetInstance.id
            logs.attributes.type = "LESSON_UPDATE"
            logs.create()
        Catch ex As MySql.Data.MySqlClient.MySqlException
            Console.WriteLine(ex.Message)
        End Try
    End Sub

    Private Sub LessonCreate_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub form_title_TextChanged(sender As System.Object, e As System.EventArgs) Handles form_title.TextChanged
        Me.Text = form_title.Text
    End Sub

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        attachment.ShowDialog()
        txt_filepath.Text = attachment.FileName
    End Sub
End Class
