﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class StudentMain
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.ToolStripStatusLabel4 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ToolStripStatusLabel3 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.lbl_total_lessons = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ToolStripStatusLabel1 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.lbl_total_test_taken = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ToolStripStatusLabel6 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ToolStripStatusLabel7 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.lbl_total_untaken_test = New System.Windows.Forms.ToolStripStatusLabel()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.BTNLesson = New System.Windows.Forms.Button()
        Me.lbl_date = New System.Windows.Forms.Label()
        Me.BTNTest = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.lbl_id = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.dp_user_profile = New System.Windows.Forms.PictureBox()
        Me.lbl_name = New System.Windows.Forms.Label()
        Me.lbl_role = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.BTNStudent = New System.Windows.Forms.Button()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.BTNSecurity = New System.Windows.Forms.Button()
        Me.BTNExit = New System.Windows.Forms.Button()
        Me.BTNSettings = New System.Windows.Forms.Button()
        Me.lbl_time = New System.Windows.Forms.Label()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.StatusStrip1.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.dp_user_profile, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.White
        Me.PictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.PictureBox1.Image = Global.CAI.My.Resources.Resources.logo
        Me.PictureBox1.Location = New System.Drawing.Point(12, 12)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(153, 139)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 22
        Me.PictureBox1.TabStop = False
        '
        'ToolStripStatusLabel4
        '
        Me.ToolStripStatusLabel4.Name = "ToolStripStatusLabel4"
        Me.ToolStripStatusLabel4.Size = New System.Drawing.Size(153, 17)
        Me.ToolStripStatusLabel4.Text = "Total number of test taken :"
        '
        'ToolStripStatusLabel3
        '
        Me.ToolStripStatusLabel3.Name = "ToolStripStatusLabel3"
        Me.ToolStripStatusLabel3.Size = New System.Drawing.Size(10, 17)
        Me.ToolStripStatusLabel3.Text = "|"
        '
        'lbl_total_lessons
        '
        Me.lbl_total_lessons.Name = "lbl_total_lessons"
        Me.lbl_total_lessons.Size = New System.Drawing.Size(19, 17)
        Me.lbl_total_lessons.Text = "00"
        '
        'ToolStripStatusLabel1
        '
        Me.ToolStripStatusLabel1.Name = "ToolStripStatusLabel1"
        Me.ToolStripStatusLabel1.Size = New System.Drawing.Size(140, 17)
        Me.ToolStripStatusLabel1.Text = "Total number of lessons :"
        '
        'StatusStrip1
        '
        Me.StatusStrip1.BackColor = System.Drawing.Color.DarkGreen
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripStatusLabel1, Me.lbl_total_lessons, Me.ToolStripStatusLabel3, Me.ToolStripStatusLabel4, Me.lbl_total_test_taken, Me.ToolStripStatusLabel6, Me.ToolStripStatusLabel7, Me.lbl_total_untaken_test})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 535)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(846, 22)
        Me.StatusStrip1.TabIndex = 28
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'lbl_total_test_taken
        '
        Me.lbl_total_test_taken.Name = "lbl_total_test_taken"
        Me.lbl_total_test_taken.Size = New System.Drawing.Size(19, 17)
        Me.lbl_total_test_taken.Text = "00"
        '
        'ToolStripStatusLabel6
        '
        Me.ToolStripStatusLabel6.Name = "ToolStripStatusLabel6"
        Me.ToolStripStatusLabel6.Size = New System.Drawing.Size(10, 17)
        Me.ToolStripStatusLabel6.Text = "|"
        '
        'ToolStripStatusLabel7
        '
        Me.ToolStripStatusLabel7.Name = "ToolStripStatusLabel7"
        Me.ToolStripStatusLabel7.Size = New System.Drawing.Size(121, 17)
        Me.ToolStripStatusLabel7.Text = "Total number of test :"
        '
        'lbl_total_untaken_test
        '
        Me.lbl_total_untaken_test.Name = "lbl_total_untaken_test"
        Me.lbl_total_untaken_test.Size = New System.Drawing.Size(19, 17)
        Me.lbl_total_untaken_test.Text = "00"
        '
        'Label11
        '
        Me.Label11.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(743, 480)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(21, 13)
        Me.Label11.TabIndex = 31
        Me.Label11.Text = "00"
        Me.Label11.Visible = False
        '
        'Label10
        '
        Me.Label10.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(641, 480)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(93, 13)
        Me.Label10.TabIndex = 32
        Me.Label10.Text = "Total Online :"
        Me.Label10.Visible = False
        '
        'BTNLesson
        '
        Me.BTNLesson.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.BTNLesson.BackColor = System.Drawing.Color.YellowGreen
        Me.BTNLesson.FlatAppearance.BorderColor = System.Drawing.Color.Green
        Me.BTNLesson.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BTNLesson.Image = Global.CAI.My.Resources.Resources.icons8_books_96
        Me.BTNLesson.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.BTNLesson.Location = New System.Drawing.Point(320, 20)
        Me.BTNLesson.Name = "BTNLesson"
        Me.BTNLesson.Size = New System.Drawing.Size(183, 129)
        Me.BTNLesson.TabIndex = 2
        Me.BTNLesson.Text = "TEST RESULTS" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        Me.BTNLesson.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.BTNLesson.UseVisualStyleBackColor = False
        '
        'lbl_date
        '
        Me.lbl_date.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.lbl_date.AutoSize = True
        Me.lbl_date.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_date.Location = New System.Drawing.Point(15, 498)
        Me.lbl_date.Name = "lbl_date"
        Me.lbl_date.Size = New System.Drawing.Size(222, 16)
        Me.lbl_date.TabIndex = 30
        Me.lbl_date.Text = "Wednesday January 01, 2018"
        '
        'BTNTest
        '
        Me.BTNTest.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.BTNTest.BackColor = System.Drawing.Color.YellowGreen
        Me.BTNTest.FlatAppearance.BorderColor = System.Drawing.Color.Green
        Me.BTNTest.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BTNTest.Image = Global.CAI.My.Resources.Resources.icons8_test_passed_80
        Me.BTNTest.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.BTNTest.Location = New System.Drawing.Point(509, 20)
        Me.BTNTest.Name = "BTNTest"
        Me.BTNTest.Size = New System.Drawing.Size(183, 129)
        Me.BTNTest.TabIndex = 1
        Me.BTNTest.Text = "TEST" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        Me.BTNTest.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.BTNTest.UseVisualStyleBackColor = False
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox1.Controls.Add(Me.lbl_id)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.dp_user_profile)
        Me.GroupBox1.Controls.Add(Me.lbl_name)
        Me.GroupBox1.Controls.Add(Me.lbl_role)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.ForeColor = System.Drawing.Color.White
        Me.GroupBox1.Location = New System.Drawing.Point(423, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(411, 121)
        Me.GroupBox1.TabIndex = 26
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "CURRENT USER"
        '
        'lbl_id
        '
        Me.lbl_id.AutoSize = True
        Me.lbl_id.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_id.Location = New System.Drawing.Point(204, 30)
        Me.lbl_id.Name = "lbl_id"
        Me.lbl_id.Size = New System.Drawing.Size(12, 13)
        Me.lbl_id.TabIndex = 11
        Me.lbl_id.Text = "-"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(114, 30)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(84, 13)
        Me.Label3.TabIndex = 10
        Me.Label3.Text = "Student ID :"
        '
        'dp_user_profile
        '
        Me.dp_user_profile.BackColor = System.Drawing.Color.White
        Me.dp_user_profile.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.dp_user_profile.Image = Global.CAI.My.Resources.Resources.icons8_user_96
        Me.dp_user_profile.Location = New System.Drawing.Point(10, 27)
        Me.dp_user_profile.Name = "dp_user_profile"
        Me.dp_user_profile.Size = New System.Drawing.Size(79, 81)
        Me.dp_user_profile.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.dp_user_profile.TabIndex = 9
        Me.dp_user_profile.TabStop = False
        '
        'lbl_name
        '
        Me.lbl_name.AutoSize = True
        Me.lbl_name.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_name.Location = New System.Drawing.Point(204, 78)
        Me.lbl_name.Name = "lbl_name"
        Me.lbl_name.Size = New System.Drawing.Size(12, 13)
        Me.lbl_name.TabIndex = 3
        Me.lbl_name.Text = "-"
        '
        'lbl_role
        '
        Me.lbl_role.AutoSize = True
        Me.lbl_role.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_role.Location = New System.Drawing.Point(204, 54)
        Me.lbl_role.Name = "lbl_role"
        Me.lbl_role.Size = New System.Drawing.Size(12, 13)
        Me.lbl_role.TabIndex = 2
        Me.lbl_role.Text = "-"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(112, 78)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(86, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "User Name :"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(95, 54)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(103, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Account Type :"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(240, 60)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(115, 16)
        Me.Label9.TabIndex = 25
        Me.Label9.Text = "Baliuag, Bulacan"
        '
        'BTNStudent
        '
        Me.BTNStudent.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.BTNStudent.BackColor = System.Drawing.Color.YellowGreen
        Me.BTNStudent.FlatAppearance.BorderColor = System.Drawing.Color.Green
        Me.BTNStudent.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BTNStudent.Image = Global.CAI.My.Resources.Resources.icons8_conference_96
        Me.BTNStudent.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.BTNStudent.Location = New System.Drawing.Point(131, 20)
        Me.BTNStudent.Name = "BTNStudent"
        Me.BTNStudent.Size = New System.Drawing.Size(183, 129)
        Me.BTNStudent.TabIndex = 0
        Me.BTNStudent.Text = "LESSONS" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        Me.BTNStudent.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.BTNStudent.UseVisualStyleBackColor = False
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(205, 44)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(132, 16)
        Me.Label8.TabIndex = 24
        Me.Label8.Text = "Baptiste, Academy"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Verdana", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(171, 12)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(171, 32)
        Me.Label7.TabIndex = 23
        Me.Label7.Text = "Saint Jean"
        '
        'GroupBox2
        '
        Me.GroupBox2.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox2.Controls.Add(Me.BTNSecurity)
        Me.GroupBox2.Controls.Add(Me.BTNExit)
        Me.GroupBox2.Controls.Add(Me.BTNSettings)
        Me.GroupBox2.Controls.Add(Me.BTNLesson)
        Me.GroupBox2.Controls.Add(Me.BTNTest)
        Me.GroupBox2.Controls.Add(Me.BTNStudent)
        Me.GroupBox2.ForeColor = System.Drawing.Color.Black
        Me.GroupBox2.Location = New System.Drawing.Point(12, 157)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(822, 304)
        Me.GroupBox2.TabIndex = 27
        Me.GroupBox2.TabStop = False
        '
        'BTNSecurity
        '
        Me.BTNSecurity.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.BTNSecurity.BackColor = System.Drawing.Color.YellowGreen
        Me.BTNSecurity.FlatAppearance.BorderColor = System.Drawing.Color.Green
        Me.BTNSecurity.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BTNSecurity.Image = Global.CAI.My.Resources.Resources.icons8_key_96
        Me.BTNSecurity.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.BTNSecurity.Location = New System.Drawing.Point(131, 155)
        Me.BTNSecurity.Name = "BTNSecurity"
        Me.BTNSecurity.Size = New System.Drawing.Size(183, 129)
        Me.BTNSecurity.TabIndex = 8
        Me.BTNSecurity.Text = "SECURITY" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        Me.BTNSecurity.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.BTNSecurity.UseVisualStyleBackColor = False
        '
        'BTNExit
        '
        Me.BTNExit.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.BTNExit.BackColor = System.Drawing.Color.YellowGreen
        Me.BTNExit.FlatAppearance.BorderColor = System.Drawing.Color.Green
        Me.BTNExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BTNExit.Image = Global.CAI.My.Resources.Resources.icons8_exit_96
        Me.BTNExit.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.BTNExit.Location = New System.Drawing.Point(510, 155)
        Me.BTNExit.Name = "BTNExit"
        Me.BTNExit.Size = New System.Drawing.Size(183, 129)
        Me.BTNExit.TabIndex = 6
        Me.BTNExit.Text = "LOGOUT" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        Me.BTNExit.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.BTNExit.UseVisualStyleBackColor = False
        '
        'BTNSettings
        '
        Me.BTNSettings.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.BTNSettings.BackColor = System.Drawing.Color.YellowGreen
        Me.BTNSettings.FlatAppearance.BorderColor = System.Drawing.Color.Green
        Me.BTNSettings.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BTNSettings.Image = Global.CAI.My.Resources.Resources.icons8_gears_filled_100__1_
        Me.BTNSettings.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.BTNSettings.Location = New System.Drawing.Point(320, 155)
        Me.BTNSettings.Name = "BTNSettings"
        Me.BTNSettings.Size = New System.Drawing.Size(183, 129)
        Me.BTNSettings.TabIndex = 5
        Me.BTNSettings.Text = "PROFILE" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        Me.BTNSettings.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.BTNSettings.UseVisualStyleBackColor = False
        '
        'lbl_time
        '
        Me.lbl_time.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.lbl_time.AutoSize = True
        Me.lbl_time.Font = New System.Drawing.Font("Verdana", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_time.Location = New System.Drawing.Point(12, 464)
        Me.lbl_time.Name = "lbl_time"
        Me.lbl_time.Size = New System.Drawing.Size(207, 32)
        Me.lbl_time.TabIndex = 29
        Me.lbl_time.Text = "00:00:00 AM"
        '
        'StudentMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Green
        Me.ClientSize = New System.Drawing.Size(846, 557)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.lbl_date)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.lbl_time)
        Me.Font = New System.Drawing.Font("Verdana", 8.25!)
        Me.ForeColor = System.Drawing.Color.White
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "StudentMain"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "WELCOME STUDENT"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.dp_user_profile, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents ToolStripStatusLabel4 As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents ToolStripStatusLabel3 As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents lbl_total_lessons As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents ToolStripStatusLabel1 As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents StatusStrip1 As System.Windows.Forms.StatusStrip
    Friend WithEvents lbl_total_test_taken As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents ToolStripStatusLabel6 As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents ToolStripStatusLabel7 As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents lbl_total_untaken_test As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents BTNLesson As System.Windows.Forms.Button
    Friend WithEvents lbl_date As System.Windows.Forms.Label
    Friend WithEvents BTNTest As System.Windows.Forms.Button
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents dp_user_profile As System.Windows.Forms.PictureBox
    Friend WithEvents lbl_name As System.Windows.Forms.Label
    Friend WithEvents lbl_role As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents BTNStudent As System.Windows.Forms.Button
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents lbl_time As System.Windows.Forms.Label
    Friend WithEvents BTNExit As System.Windows.Forms.Button
    Friend WithEvents BTNSettings As System.Windows.Forms.Button
    Friend WithEvents lbl_id As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents BTNSecurity As System.Windows.Forms.Button

End Class
