Imports GemBox.Spreadsheet
Imports Microsoft.Office.Interop

Public Class InstructorStudentResultViewer

    Private total_student = 0
    Private total_passed = 0
    Private total_failed = 0
    Private current_test = 0

    Sub New()
        InitializeComponent()
        current_test = 2
    End Sub

    Sub New(Optional ByRef id As Integer = 0)
        InitializeComponent()
        current_test = id
    End Sub

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        Me.Close()
    End Sub

    Sub loadUserDetails()
        dp_user_profile.Image = My.Resources.icons8_user_96
        lbl_username.Text = Auth.GetInstance.username
        lbl_name.Text = String.Format("{0}, {1}, {2}", Auth.GetInstance.last_name, Auth.GetInstance.first_name, Auth.GetInstance.middle_name)

        If Not Auth.GetInstance.dp = "" Then _
            dp_user_profile.Image = ImageModule.Base64ToImage(Auth.GetInstance.dp)
    End Sub
    Sub FetchHandledSections()
        Try
            Dim SQL = "SELECT distinct year, section FROM db_cai_auto.users WHERE instructor_id = @ID AND year > 0 AND section IS NOT NULL;"
            Dim command = New MySql.Data.MySqlClient.MySqlCommand(SQL, Database.GetInstance.GetConnection)
            command.Parameters.AddWithValue("@ID", Auth.GetInstance.id)
            Dim reader = command.ExecuteReader
            With ComboShowStudents
                With .Items
                    .Clear()
                    .Add("Show All")
                    While reader.Read
                        .Add(String.Format("{0:00}-{1}",
                            reader("year"),
                            reader("section")
                        ))
                    End While
                    reader.Close()
                End With
                .SelectedIndex = 0
            End With
        Catch ex As Exception
            LoggerModule.createLog(ex.ToString, LogType.Err)
        End Try
    End Sub

    Sub fetchTestDetails()
        Try
            Dim command = New MySql.Data.MySqlClient.MySqlCommand("SELECT * FROM tests WHERE id = @id", Database.GetInstance.GetConnection)
            With command.Parameters
                .AddWithValue("@id", current_test)
            End With
            Dim reader = command.ExecuteReader
            If reader.Read Then
                LBLTitlte.Text = Database.GetInstance.readerValue(reader, "title")
                LBLDescription.Text = Database.GetInstance.readerValue(reader, "description")
                LBLDuration.Text = String.Format("{0:00}:{1:00}", Database.GetInstance.readerValue(reader, "duration_hour"),
                                                 Database.GetInstance.readerValue(reader, "duration_minute"))
            End If
            reader.Close()
        Catch ex As Exception
            LoggerModule.createLog(Me.ToString, LogType.Err)
            LoggerModule.createLog(ex.ToString, LogType.Err)
        End Try
    End Sub

    Sub fetchStudents(Optional ByRef filterYearSection As String = "Show All")
        Try
            list_results.Items.Clear()
            Dim yearFilter = 0
            Dim sectionFilter = ""
            Dim SQL = "SELECT * FROM users_tests LEFT JOIN users ON users.id = users_tests.user_id WHERE test_id = @id"
            If Not String.IsNullOrEmpty(filterYearSection) Then
                If Not filterYearSection = "Show All" Then
                    Dim YearSection = filterYearSection.Split("-")
                    yearFilter = Integer.Parse(YearSection(0))
                    sectionFilter = YearSection(1)
                    SQL = String.Format("{0} AND {1}", SQL, "user_id in (SELECT id FROM users WHERE year = @year AND section = @section)")
                End If
            End If
            Dim command = New MySql.Data.MySqlClient.MySqlCommand(SQL, Database.GetInstance.GetConnection)
            With command.Parameters
                .AddWithValue("@id", current_test)
                If Not String.IsNullOrEmpty(filterYearSection) Then
                    If Not filterYearSection = "Select All" Then
                        .AddWithValue("@year", yearFilter)
                        .AddWithValue("@section", sectionFilter)
                    End If
                End If
            End With
            Dim reader = command.ExecuteReader
            While reader.Read
                Dim li = New ListViewItem
                Dim score = Database.GetInstance.readerValue(reader, "score")
                Dim items = Database.GetInstance.readerValue(reader, "items")
                Dim avg = (score / items) * 100
                li.Text = reader.GetValue(0)
                li.SubItems.Add(Database.GetInstance.readerValue(reader, "username"))
                li.SubItems.Add(String.Format("{0}, {1}, {2}", Database.GetInstance.readerValue(reader, "lastname"), Database.GetInstance.readerValue(reader, "firstname"), Database.GetInstance.readerValue(reader, "middlename")))
                Dim yearSection = New String() {
                    String.Format("{0:00}", Database.GetInstance.readerValue(reader, "year")),
                    Database.GetInstance.readerValue(reader, "section")
                }
                li.SubItems.Add(String.Join("-", yearSection.ToArray()))
                li.SubItems.Add(String.Format("{0:MMMM dd, yyyy}", Date.Parse(Database.GetInstance.readerValue(reader, "created_at"))))
                li.SubItems.Add(String.Format("{0:00}", score))
                li.SubItems.Add(String.Format("{0:00}", items - score))
                li.SubItems.Add(String.Format("{0:00}", avg))
                list_results.Items.Add(li)

                If avg < 50 Then _
                    total_failed += 1
                If avg >= 50 Then _
                    total_passed += 1
                total_student += 1
            End While
            reader.Close()
            LBLIndication.Text = String.Format("Total Student : {0:00} | Total Student Passed : {1:00} | Total Student Failed : {2:00}", total_student, total_passed, total_failed)
        Catch ex As Exception
            LoggerModule.createLog(Me.ToString, LogType.Err)
            LoggerModule.createLog(ex.ToString, LogType.Err)
        End Try

        ButtonExport.Enabled = list_results.Items.Count > 0
        ActionPrint.Enabled = ButtonExport.Enabled
    End Sub

    Private Sub InstructorStudentResultViewer_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        FetchHandledSections()
        loadUserDetails()
        fetchTestDetails()
        fetchStudents()
    End Sub

    Private Sub SetupExcelFile(Optional ByRef Ext As String = ".pdf")
        ' Set license key to use GemBox.Spreadsheet in Free mode.
        SpreadsheetInfo.SetLicense("FREE-LIMITED-KEY")
        ' Create a new empty Excel file.
        Dim TemplateTEMPDIR = Application.StartupPath & "\templates"
        Dim TemplateTEMP = TemplateTEMPDIR & "\TestTemplate.xlsx"

        If Not IO.Directory.Exists(TemplateTEMPDIR) Then
            IO.Directory.CreateDirectory(TemplateTEMPDIR)
        End If

        If Not IO.File.Exists(TemplateTEMP) Then
            Dim resources = My.Resources.TestTemplate
            System.IO.File.WriteAllBytes(TemplateTEMP, resources)
        End If

        Dim workbook = ExcelFile.Load(TemplateTEMP)
        ' Create a new worksheet and set cell A1 value to 'Hello world!'.

        Dim sheet = workbook.Worksheets("Sheet1")
        sheet.Cells("B2").Value = LBLTitlte.Text
        sheet.Cells("H2").Value = LBLDuration.Text
        sheet.Cells("B3").Value = LBLDescription.Text
        sheet.Cells("A4").Value = String.Format("Total Student: {0:00}", total_student)
        sheet.Cells("C4").Value = String.Format("Total Passed: {0:00}", total_passed)
        sheet.Cells("E4").Value = String.Format("Total Failed: {0:00}", total_failed)

        Dim initialRow = 5
        For Each li As ListViewItem In list_results.Items
            If li.Index > 0 Then
                sheet.Rows.InsertCopy(initialRow + li.Index, workbook.Worksheets("Sheet1").Rows(initialRow))
            End If
            Dim cellIndex = li.Index + 1 + initialRow
            sheet.Cells(String.Format("A{0}", cellIndex)).Value = li.SubItems(1).Text
            sheet.Cells(String.Format("B{0}", cellIndex)).Value = li.SubItems(2).Text
            sheet.Cells(String.Format("D{0}", cellIndex)).Value = li.SubItems(3).Text
            sheet.Cells(String.Format("E{0}", cellIndex)).Value = li.SubItems(4).Text
            sheet.Cells(String.Format("F{0}", cellIndex)).Value = li.SubItems(5).Text
            sheet.Cells(String.Format("G{0}", cellIndex)).Value = li.SubItems(6).Text
            sheet.Cells(String.Format("H{0}", cellIndex)).Value = li.SubItems(7).Text
        Next

        ' Save to XLSX file.
        Dim Counter = 1
        Dim BaseFileName = String.Format("{0}", LBLTitlte.Text.Replace(" ", "_"))
        Dim FileName = BaseFileName
        While IO.File.Exists(String.Format("{0}{1}", FileName, Ext))
            FileName = String.Format("{0}{1}-{2:00}", BaseFileName, Ext, Counter)
            Counter += 1
        End While

        Dim FilePath = String.Format("{0}\{1}{2}", Application.StartupPath, FileName, Ext)
        workbook.Save(FilePath)
        System.Threading.Thread.Sleep(1000)
        Process.Start(FilePath)
    End Sub

    Private Sub PrintResults(sender As Object, e As EventArgs) Handles ActionPrint.Click
        SetupExcelFile()
        'Dim dialog = New PrintDialog
        'dialog.Document = New Printing.PrintDocument()
        'dialog.ShowDialog()
    End Sub

    Private Sub OnExport(sender As Object, e As EventArgs) Handles ButtonExport.Click
        SetupExcelFile(".xlsx")
    End Sub

    Private Sub OnFilterYearSection(sender As Object, e As EventArgs) Handles ComboShowStudents.SelectedIndexChanged
        fetchStudents(ComboShowStudents.Text)
    End Sub
End Class
