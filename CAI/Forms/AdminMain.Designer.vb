<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AdminMain
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(AdminMain))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.dp_user_profile = New System.Windows.Forms.PictureBox()
        Me.lbl_host_ip = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.lbl_name = New System.Windows.Forms.Label()
        Me.lbl_role = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.BTNSecurity = New System.Windows.Forms.Button()
        Me.BTNExit = New System.Windows.Forms.Button()
        Me.BTNSettings = New System.Windows.Forms.Button()
        Me.BTNAdmin = New System.Windows.Forms.Button()
        Me.BTNLogs = New System.Windows.Forms.Button()
        Me.BTNInstructor = New System.Windows.Forms.Button()
        Me.lbl_time = New System.Windows.Forms.Label()
        Me.lbl_date = New System.Windows.Forms.Label()
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.ToolStripStatusLabel1 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.lbl_total_instructor = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ToolStripStatusLabel3 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ToolStripStatusLabel4 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.lbl_total_student = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ToolStripStatusLabel6 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ToolStripStatusLabel7 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.lbl_total_administrator = New System.Windows.Forms.ToolStripStatusLabel()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.GroupBox1.SuspendLayout()
        CType(Me.dp_user_profile, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        Me.StatusStrip1.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox1.Controls.Add(Me.dp_user_profile)
        Me.GroupBox1.Controls.Add(Me.lbl_host_ip)
        Me.GroupBox1.Controls.Add(Me.Label12)
        Me.GroupBox1.Controls.Add(Me.lbl_name)
        Me.GroupBox1.Controls.Add(Me.lbl_role)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.ForeColor = System.Drawing.Color.White
        Me.GroupBox1.Location = New System.Drawing.Point(423, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(411, 121)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "CURRENT USER"
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
        'lbl_host_ip
        '
        Me.lbl_host_ip.AutoSize = True
        Me.lbl_host_ip.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_host_ip.Location = New System.Drawing.Point(207, 32)
        Me.lbl_host_ip.Name = "lbl_host_ip"
        Me.lbl_host_ip.Size = New System.Drawing.Size(61, 13)
        Me.lbl_host_ip.TabIndex = 5
        Me.lbl_host_ip.Text = "127.0.0.1"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(95, 32)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(109, 13)
        Me.Label12.TabIndex = 4
        Me.Label12.Text = "Machine Name :"
        '
        'lbl_name
        '
        Me.lbl_name.AutoSize = True
        Me.lbl_name.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_name.Location = New System.Drawing.Point(210, 87)
        Me.lbl_name.Name = "lbl_name"
        Me.lbl_name.Size = New System.Drawing.Size(155, 13)
        Me.lbl_name.TabIndex = 3
        Me.lbl_name.Text = "Last Name, First Name, E."
        '
        'lbl_role
        '
        Me.lbl_role.AutoSize = True
        Me.lbl_role.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_role.Location = New System.Drawing.Point(210, 60)
        Me.lbl_role.Name = "lbl_role"
        Me.lbl_role.Size = New System.Drawing.Size(84, 13)
        Me.lbl_role.TabIndex = 2
        Me.lbl_role.Text = "Administrator"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(118, 87)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(86, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "User Name :"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(101, 60)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(103, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Account Type :"
        '
        'GroupBox2
        '
        Me.GroupBox2.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox2.Controls.Add(Me.BTNSecurity)
        Me.GroupBox2.Controls.Add(Me.BTNExit)
        Me.GroupBox2.Controls.Add(Me.BTNSettings)
        Me.GroupBox2.Controls.Add(Me.BTNAdmin)
        Me.GroupBox2.Controls.Add(Me.BTNLogs)
        Me.GroupBox2.Controls.Add(Me.BTNInstructor)
        Me.GroupBox2.ForeColor = System.Drawing.Color.Black
        Me.GroupBox2.Location = New System.Drawing.Point(12, 157)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(822, 304)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        '
        'BTNSecurity
        '
        Me.BTNSecurity.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.BTNSecurity.BackColor = System.Drawing.Color.White
        Me.BTNSecurity.FlatAppearance.BorderColor = System.Drawing.Color.Green
        Me.BTNSecurity.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BTNSecurity.Image = Global.CAI.My.Resources.Resources.icons8_key_96
        Me.BTNSecurity.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.BTNSecurity.Location = New System.Drawing.Point(131, 157)
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
        Me.BTNExit.BackColor = System.Drawing.Color.White
        Me.BTNExit.FlatAppearance.BorderColor = System.Drawing.Color.Green
        Me.BTNExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BTNExit.Image = Global.CAI.My.Resources.Resources.icons8_exit_96
        Me.BTNExit.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.BTNExit.Location = New System.Drawing.Point(510, 157)
        Me.BTNExit.Name = "BTNExit"
        Me.BTNExit.Size = New System.Drawing.Size(183, 129)
        Me.BTNExit.TabIndex = 4
        Me.BTNExit.Text = "LOGOUT" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        Me.BTNExit.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.BTNExit.UseVisualStyleBackColor = False
        '
        'BTNSettings
        '
        Me.BTNSettings.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.BTNSettings.BackColor = System.Drawing.Color.White
        Me.BTNSettings.FlatAppearance.BorderColor = System.Drawing.Color.Green
        Me.BTNSettings.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BTNSettings.Image = Global.CAI.My.Resources.Resources.icons8_gears_filled_100__1_
        Me.BTNSettings.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.BTNSettings.Location = New System.Drawing.Point(320, 157)
        Me.BTNSettings.Name = "BTNSettings"
        Me.BTNSettings.Size = New System.Drawing.Size(183, 129)
        Me.BTNSettings.TabIndex = 3
        Me.BTNSettings.Text = "PROFILE" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        Me.BTNSettings.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.BTNSettings.UseVisualStyleBackColor = False
        '
        'BTNAdmin
        '
        Me.BTNAdmin.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.BTNAdmin.BackColor = System.Drawing.Color.White
        Me.BTNAdmin.FlatAppearance.BorderColor = System.Drawing.Color.Green
        Me.BTNAdmin.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BTNAdmin.Image = Global.CAI.My.Resources.Resources.icons8_user_96
        Me.BTNAdmin.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.BTNAdmin.Location = New System.Drawing.Point(320, 22)
        Me.BTNAdmin.Name = "BTNAdmin"
        Me.BTNAdmin.Size = New System.Drawing.Size(183, 129)
        Me.BTNAdmin.TabIndex = 2
        Me.BTNAdmin.Text = "ADMIN MANAGEMENT" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        Me.BTNAdmin.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.BTNAdmin.UseVisualStyleBackColor = False
        '
        'BTNLogs
        '
        Me.BTNLogs.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.BTNLogs.BackColor = System.Drawing.Color.White
        Me.BTNLogs.FlatAppearance.BorderColor = System.Drawing.Color.Green
        Me.BTNLogs.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BTNLogs.Image = Global.CAI.My.Resources.Resources.icons8_bulleted_list_96
        Me.BTNLogs.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.BTNLogs.Location = New System.Drawing.Point(509, 22)
        Me.BTNLogs.Name = "BTNLogs"
        Me.BTNLogs.Size = New System.Drawing.Size(183, 129)
        Me.BTNLogs.TabIndex = 1
        Me.BTNLogs.Text = "VIEW LOG REPORTS" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        Me.BTNLogs.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.BTNLogs.UseVisualStyleBackColor = False
        '
        'BTNInstructor
        '
        Me.BTNInstructor.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.BTNInstructor.BackColor = System.Drawing.Color.White
        Me.BTNInstructor.FlatAppearance.BorderColor = System.Drawing.Color.Green
        Me.BTNInstructor.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BTNInstructor.Image = Global.CAI.My.Resources.Resources.icons8_conference_96
        Me.BTNInstructor.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.BTNInstructor.Location = New System.Drawing.Point(131, 22)
        Me.BTNInstructor.Name = "BTNInstructor"
        Me.BTNInstructor.Size = New System.Drawing.Size(183, 129)
        Me.BTNInstructor.TabIndex = 0
        Me.BTNInstructor.Text = "INSTRUCTOR MANAGEMENT" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        Me.BTNInstructor.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.BTNInstructor.UseVisualStyleBackColor = False
        '
        'lbl_time
        '
        Me.lbl_time.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.lbl_time.AutoSize = True
        Me.lbl_time.Font = New System.Drawing.Font("Verdana", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_time.Location = New System.Drawing.Point(12, 464)
        Me.lbl_time.Name = "lbl_time"
        Me.lbl_time.Size = New System.Drawing.Size(207, 32)
        Me.lbl_time.TabIndex = 2
        Me.lbl_time.Text = "00:00:00 AM"
        '
        'lbl_date
        '
        Me.lbl_date.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.lbl_date.AutoSize = True
        Me.lbl_date.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_date.Location = New System.Drawing.Point(15, 498)
        Me.lbl_date.Name = "lbl_date"
        Me.lbl_date.Size = New System.Drawing.Size(222, 16)
        Me.lbl_date.TabIndex = 3
        Me.lbl_date.Text = "Wednesday January 01, 2018"
        '
        'StatusStrip1
        '
        Me.StatusStrip1.BackColor = System.Drawing.Color.DarkGreen
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripStatusLabel1, Me.lbl_total_instructor, Me.ToolStripStatusLabel3, Me.ToolStripStatusLabel4, Me.lbl_total_student, Me.ToolStripStatusLabel6, Me.ToolStripStatusLabel7, Me.lbl_total_administrator})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 535)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(846, 22)
        Me.StatusStrip1.TabIndex = 4
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'ToolStripStatusLabel1
        '
        Me.ToolStripStatusLabel1.Name = "ToolStripStatusLabel1"
        Me.ToolStripStatusLabel1.Size = New System.Drawing.Size(153, 17)
        Me.ToolStripStatusLabel1.Text = "Total number of instructor :"
        '
        'lbl_total_instructor
        '
        Me.lbl_total_instructor.Name = "lbl_total_instructor"
        Me.lbl_total_instructor.Size = New System.Drawing.Size(19, 17)
        Me.lbl_total_instructor.Text = "00"
        '
        'ToolStripStatusLabel3
        '
        Me.ToolStripStatusLabel3.Name = "ToolStripStatusLabel3"
        Me.ToolStripStatusLabel3.Size = New System.Drawing.Size(10, 17)
        Me.ToolStripStatusLabel3.Text = "|"
        '
        'ToolStripStatusLabel4
        '
        Me.ToolStripStatusLabel4.Name = "ToolStripStatusLabel4"
        Me.ToolStripStatusLabel4.Size = New System.Drawing.Size(142, 17)
        Me.ToolStripStatusLabel4.Text = "Total number of student :"
        '
        'lbl_total_student
        '
        Me.lbl_total_student.Name = "lbl_total_student"
        Me.lbl_total_student.Size = New System.Drawing.Size(19, 17)
        Me.lbl_total_student.Text = "00"
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
        Me.ToolStripStatusLabel7.Size = New System.Drawing.Size(173, 17)
        Me.ToolStripStatusLabel7.Text = "Total number of administrator :"
        '
        'lbl_total_administrator
        '
        Me.lbl_total_administrator.Name = "lbl_total_administrator"
        Me.lbl_total_administrator.Size = New System.Drawing.Size(19, 17)
        Me.lbl_total_administrator.Text = "00"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Verdana", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(171, 12)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(171, 32)
        Me.Label7.TabIndex = 5
        Me.Label7.Text = "Saint Jean"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(205, 44)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(132, 16)
        Me.Label8.TabIndex = 6
        Me.Label8.Text = "Baptiste, Academy"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(240, 60)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(115, 16)
        Me.Label9.TabIndex = 7
        Me.Label9.Text = "Baliuag, Bulacan"
        '
        'Label10
        '
        Me.Label10.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(641, 480)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(93, 13)
        Me.Label10.TabIndex = 4
        Me.Label10.Text = "Total Online :"
        Me.Label10.Visible = False
        '
        'Label11
        '
        Me.Label11.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(743, 480)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(21, 13)
        Me.Label11.TabIndex = 4
        Me.Label11.Text = "00"
        Me.Label11.Visible = False
        '
        'PictureBox2
        '
        Me.PictureBox2.BackColor = System.Drawing.Color.White
        Me.PictureBox2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(12, 12)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(140, 139)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 12
        Me.PictureBox2.TabStop = False
        '
        'AdminMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Green
        Me.ClientSize = New System.Drawing.Size(846, 557)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.lbl_date)
        Me.Controls.Add(Me.lbl_time)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.PictureBox2)
        Me.Font = New System.Drawing.Font("Verdana", 8.25!)
        Me.ForeColor = System.Drawing.Color.White
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "AdminMain"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "AdminMain"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.dp_user_profile, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents BTNAdmin As System.Windows.Forms.Button
    Friend WithEvents BTNLogs As System.Windows.Forms.Button
    Friend WithEvents BTNInstructor As System.Windows.Forms.Button
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents lbl_time As System.Windows.Forms.Label
    Friend WithEvents lbl_date As System.Windows.Forms.Label
    Friend WithEvents lbl_name As System.Windows.Forms.Label
    Friend WithEvents lbl_role As System.Windows.Forms.Label
    Friend WithEvents StatusStrip1 As System.Windows.Forms.StatusStrip
    Friend WithEvents ToolStripStatusLabel1 As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents lbl_total_instructor As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents ToolStripStatusLabel3 As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents ToolStripStatusLabel4 As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents lbl_total_student As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents ToolStripStatusLabel6 As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents ToolStripStatusLabel7 As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents lbl_total_administrator As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents lbl_host_ip As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents dp_user_profile As System.Windows.Forms.PictureBox
    Friend WithEvents BTNExit As System.Windows.Forms.Button
    Friend WithEvents BTNSettings As System.Windows.Forms.Button
    Friend WithEvents BTNSecurity As System.Windows.Forms.Button
    Friend WithEvents PictureBox2 As PictureBox
End Class
