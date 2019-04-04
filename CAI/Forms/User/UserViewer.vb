Imports System.Windows.Forms

Public Class UserViewer
    Private current_user As Integer
    Private WithEvents Auth As CAI.Auth
    Private log_list As ListviewAutomation

    Sub New(Optional ByRef id As Integer = 0)

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        current_user = id
        Auth = CAI.Auth.GetInstance
    End Sub

    Sub fetchLogs(ByRef user_id As Integer)
        Try
            log_list = New ListviewAutomation
            log_list.table = "user_logs"
            log_list.list = list_log
            log_list.max_per_page = 15
            log_list.btn_next = btn_next
            log_list.btn_prev = btn_prev
            log_list.pagination = pagination
            log_list.custom_Sql = "SELECT id,activity,DATE_FORMAT(created_at, '%a %b %d, %Y @ %h:%i %p') as activity_date FROM user_logs"

            log_list.OrderBy = New OrderBy
            log_list.where = New List(Of Criteria)
            log_list.parameters = New List(Of CommandParameter)

            log_list.OrderBy.columns.Add("created_at")
            log_list.OrderBy.type = "DESC"

            Dim where_criteria = New Criteria
            where_criteria.column = "user_id"
            where_criteria.key = "user_id"
            log_list.where.Add(where_criteria)

            Dim param = New CommandParameter
            param.param = "user_id"
            param.value = user_id
            log_list.parameters.Add(param)

            Dim cols = New List(Of String)
            cols.Add("activity")
            cols.Add("activity_date")
            log_list.columns = cols
            log_list.fetch()

            Console.WriteLine(log_list.getGrammar)

        Catch ex As Exception
            Console.WriteLine("Sorry error during the fetch logs.")
            Console.WriteLine(ex)
        End Try
    End Sub

    Private Sub UserViewer_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        fetchLogs(current_user)
        fetchDetails()

        BTNEdit.Enabled = Not Auth.GetInstance.isPreview
        BTNPassword.Enabled = Not Auth.GetInstance.isPreview
        If current_user = Auth.GetInstance.id Then _
            AddHandler Auth.UserUpdated, AddressOf Me.fetchDetails
    End Sub


    Sub fetchDetails()
        Try
            Dim command = New MySql.Data.MySqlClient.MySqlCommand("SELECT id, username, lastname, firstname, middlename,DATE_FORMAT(created_at, '%a %b %d, %Y') as registered_since, dp FROM users WHERE id = @id", Database.GetInstance.GetConnection)
            command.Parameters.AddWithValue("@id", Me.current_user)
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
            Dim registered_since = IIf(IsDBNull(reader.GetValue(5)), "", reader.GetValue(5))
            Dim dp = Database.GetInstance.readerValue(reader, "dp")
            reader.Close()

            lbl_username.Text = username
            lbl_registered_since.Text = registered_since
            If Not dp = "" Then _
                pict_user_pict.Image = Image.FromFile(dp)
            If dp = "" Then _
                pict_user_pict.Image = My.Resources.icons8_user_96
            lbl_user_name.Text = String.Format("{0}, {1}, {2}", last_name, first_name, middle_name)

            Dim logs = New LogsModel
            logs.attributes.type = "USER_VIEWED"
            logs.attributes.user_id = Auth.GetInstance.id
            logs.attributes.activity = String.Format("User `({0}) - {1}` viewed", username, lbl_user_name.Text)
            logs.create()

        Catch ex As Exception
            Console.WriteLine("Unable to fetch user details")
            Console.WriteLine(ex)
        End Try
    End Sub

    Private Sub BTNCreate_Click(sender As System.Object, e As System.EventArgs) Handles BTNPassword.Click
        Dim form = New UpdatePassword(current_user)
        Me.Hide()
        form.ShowDialog()
        Me.Show()
    End Sub

    Private Sub BTNEdit_Click(sender As System.Object, e As System.EventArgs) Handles BTNEdit.Click
        Dim form = New UserEdit(current_user)
        Me.Hide()
        form.ShowDialog()
        Me.Show()
    End Sub

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        Me.Close()
    End Sub
End Class
