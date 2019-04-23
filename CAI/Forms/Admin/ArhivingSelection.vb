Imports System.Windows.Forms
Imports MySql.Data.MySqlClient

Public Class ArhivingSelection
    Private auto_list As ListviewAutomation

    Private Sub user_list_SelectedIndexChanged(sender As Object, e As EventArgs) Handles user_list.SelectedIndexChanged
        BTNArchive.Enabled = user_list.SelectedItems.Count > 0
    End Sub

    Private Sub BTNArchive_Click(sender As Object, e As EventArgs) Handles BTNArchive.Click
        Dim confirm = MsgBox("Are you sure to archive the selected batch?", MsgBoxStyle.YesNo + MsgBoxStyle.Question, "Confirm selection.")
        If confirm <> MsgBoxResult.Yes Then _
            Exit Sub

        Dim li = user_list.SelectedItems(0)
        Dim SY = li.SubItems(1).Text.Split("-")
        Dim year = li.SubItems(2).Text

        Dim DumpArgs = New List(Of String)
#Region "Dump Access"
        Dim DBConfig = Config.GetInstance()
        DumpArgs.Add(String.Format("{0}", DBConfig.user))
        DumpArgs.Add(DBConfig.database)
        DumpArgs.Add(String.Format("{0}", DBConfig.server))
        DumpArgs.Add(String.Format("{0}", DBConfig.port))
        If (Not String.IsNullOrEmpty(DBConfig.password)) Then
            DumpArgs.Add(String.Format("{0}", DBConfig.password))
        End If


        ' Query
        'DumpArgs.Add("users")
        'DumpArgs.Add(String.Format("--where='sy_from = {0} AND sy_to = {1} AND year = {2}'", SY(0), SY(1), year))
        ' Query

        'DumpArgs.Add("--no-create-info=true")
        'DumpArgs.Add("--verbose")

        Dim Repetion As Integer = 1
        Dim BasePath = Config.GetInstance().network_path & ":\Archive"
        Dim BaseFileName = String.Format("{0}-{1}_@_{2}_{3:yyyy_MMMM_dd}-archive", SY(0), SY(1), year, Now)
        Dim FileName = BaseFileName
        If (Not IO.Directory.Exists(BasePath)) Then _
            IO.Directory.CreateDirectory(BasePath)

        While (IO.File.Exists(String.Format("{0}\{1}.sql", BasePath, FileName)))
            FileName = String.Format("{0}-{1}", BaseFileName, Repetion)
            Repetion += 1
        End While

        DumpArgs.Add(String.Format("""{0}\{1}.sql""", BasePath, FileName))
#End Region

        If (String.IsNullOrEmpty(DBConfig.password)) Then
            Shell("""" & Application.StartupPath & "\archiver\exec.bat"" " & String.Join(" ", DumpArgs.ToArray()), AppWinStyle.Hide, True)
        Else
            Shell("""" & Application.StartupPath & "\archiver\exec-secure.bat"" " & String.Join(" ", DumpArgs.ToArray()), AppWinStyle.Hide, True)
        End If
        ' Deletion Process
        Try
            Dim DeletionScript = My.Resources.cai_query_for_batch_dump_deletion
            DeletionScript = DeletionScript.Replace("@PLACE_SY_FROM", SY(0))
            DeletionScript = DeletionScript.Replace("@PLACE_SY_TO", SY(1))
            DeletionScript = DeletionScript.Replace("@PLACE_YEAR", year)

            Console.WriteLine(DeletionScript)
            Dim connection = Database.GetInstance.GetConnection
            Dim command = New MySqlCommand(DeletionScript, connection)
            command.ExecuteScalar()
            FetchBatches()

            BTNArchive.Enabled = False
        Catch ex As Exception
            LoggerModule.createLog(ex.ToString, LogType.Err)
        End Try

        MsgBox("Successfully archived selected batch." & vbNewLine & vbNewLine & String.Format("Archived File: {0}\{1}.sql", BasePath, FileName), MsgBoxStyle.Information + MsgBoxStyle.OkOnly, "Success")
    End Sub

    Sub FetchBatches()
        Try

            auto_list = New ListviewAutomation
            auto_list.list = user_list

            auto_list.custom_Sql = My.Resources.cai_batch_query
            auto_list.max_per_page = 0
            auto_list.where = New List(Of Criteria)
            auto_list.orWhere = New List(Of OrCriteria)
            auto_list.parameters = New List(Of CommandParameter)

            Dim cols = New List(Of String)
            cols.Add("SY")
            cols.Add("student_year")
            cols.Add("total_sections")
            cols.Add("total_students")
            auto_list.columns = cols
            auto_list.fetch()

        Catch ex As Exception
            LoggerModule.createLog(ex.ToString, LogType.Err)
        End Try
    End Sub

    Private Sub ArhivingSelection_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        FetchBatches()
    End Sub
End Class
