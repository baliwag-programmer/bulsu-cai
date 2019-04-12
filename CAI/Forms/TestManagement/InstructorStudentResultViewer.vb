Public Class InstructorStudentResultViewer

    Private current_test = 0
    Sub New(Optional ByRef id As Integer = 0)

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        current_test = id
    End Sub

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        Me.Close()
    End Sub

    Sub loadUserDetails()
        lbl_username.Text = Auth.GetInstance.username
        lbl_name.Text = String.Format("{0}, {1}, {2}", Auth.GetInstance.last_name, Auth.GetInstance.first_name, Auth.GetInstance.middle_name)

        If Not Auth.GetInstance.dp = "" Then _
            dp_user_profile.Image = Image.FromFile(Auth.GetInstance.dp)
        If Auth.GetInstance.dp = "" Then _
            dp_user_profile.Image = My.Resources.icons8_user_96
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
                LBLDuration.Text = String.Format("{0:00}:{1:00}", Database.GetInstance.readerValue(reader, "duration_hour"), _
                                                 Database.GetInstance.readerValue(reader, "duration_minute"))
            End If
            reader.Close()
        Catch ex As Exception
            Console.WriteLine("Sorry unable to fetch details")
            Console.WriteLine(ex)
        End Try
    End Sub

    Sub fetchStudents()
        Try
            Dim total_student = 0
            Dim total_passed = 0
            Dim total_failed = 0

            Dim command = New MySql.Data.MySqlClient.MySqlCommand("SELECT * FROM users_tests LEFT JOIN users ON users.id = users_tests.user_id WHERE test_id = @id", Database.GetInstance.GetConnection)
            With command.Parameters
                .AddWithValue("@id", current_test)
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
                li.SubItems.Add(Database.GetInstance.readerValue(reader, "created_at"))
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
            Console.WriteLine("Sorry unable to fetch students")
            Console.WriteLine(ex)
        End Try
    End Sub

    Private Sub InstructorStudentResultViewer_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        loadUserDetails()
        fetchTestDetails()
        fetchStudents()
    End Sub

End Class