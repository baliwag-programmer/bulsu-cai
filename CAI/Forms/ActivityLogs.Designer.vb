<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ActivityLogs
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
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.logs_btn_prev = New System.Windows.Forms.Button()
        Me.logs_btn_next = New System.Windows.Forms.Button()
        Me.logs_pagination = New System.Windows.Forms.Label()
        Me.list_log = New System.Windows.Forms.ListView()
        Me.logs_id = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.logs_activity = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.logs_user_name = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.logs_user_full_name = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.logs_created_at = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.pict_user_pict = New System.Windows.Forms.PictureBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lbl_username = New System.Windows.Forms.Label()
        Me.lbl_reigestered_since = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.recent_btn_prev = New System.Windows.Forms.Button()
        Me.recent_btn_next = New System.Windows.Forms.Button()
        Me.recent_pagination = New System.Windows.Forms.Label()
        Me.list_recent_logs = New System.Windows.Forms.ListView()
        Me.ColumnHeader1 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader2 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader3 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.lbl_user_name = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Heading1 = New CAI.Heading()
        Me.Panel2.SuspendLayout()
        Me.Panel4.SuspendLayout()
        CType(Me.pict_user_pict, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel2
        '
        Me.Panel2.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel2.Controls.Add(Me.Panel4)
        Me.Panel2.Controls.Add(Me.list_log)
        Me.Panel2.Location = New System.Drawing.Point(-2, 133)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(553, 429)
        Me.Panel2.TabIndex = 30
        '
        'Panel4
        '
        Me.Panel4.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel4.BackColor = System.Drawing.Color.Gray
        Me.Panel4.Controls.Add(Me.logs_btn_prev)
        Me.Panel4.Controls.Add(Me.logs_btn_next)
        Me.Panel4.Controls.Add(Me.logs_pagination)
        Me.Panel4.Location = New System.Drawing.Point(0, 397)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(553, 32)
        Me.Panel4.TabIndex = 3
        '
        'logs_btn_prev
        '
        Me.logs_btn_prev.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.logs_btn_prev.FlatAppearance.BorderSize = 0
        Me.logs_btn_prev.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.logs_btn_prev.Image = Global.CAI.My.Resources.Resources.icons8_prev_48
        Me.logs_btn_prev.Location = New System.Drawing.Point(478, 0)
        Me.logs_btn_prev.Name = "logs_btn_prev"
        Me.logs_btn_prev.Size = New System.Drawing.Size(38, 31)
        Me.logs_btn_prev.TabIndex = 2
        Me.logs_btn_prev.UseVisualStyleBackColor = True
        '
        'logs_btn_next
        '
        Me.logs_btn_next.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.logs_btn_next.FlatAppearance.BorderSize = 0
        Me.logs_btn_next.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.logs_btn_next.Image = Global.CAI.My.Resources.Resources.icons8_right_button_48
        Me.logs_btn_next.Location = New System.Drawing.Point(515, 0)
        Me.logs_btn_next.Name = "logs_btn_next"
        Me.logs_btn_next.Size = New System.Drawing.Size(38, 31)
        Me.logs_btn_next.TabIndex = 1
        Me.logs_btn_next.UseVisualStyleBackColor = True
        '
        'logs_pagination
        '
        Me.logs_pagination.AutoSize = True
        Me.logs_pagination.Location = New System.Drawing.Point(14, 10)
        Me.logs_pagination.Name = "logs_pagination"
        Me.logs_pagination.Size = New System.Drawing.Size(86, 13)
        Me.logs_pagination.TabIndex = 0
        Me.logs_pagination.Text = "Page 01 of 10"
        '
        'list_log
        '
        Me.list_log.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.list_log.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.logs_id, Me.logs_activity, Me.logs_user_name, Me.logs_user_full_name, Me.logs_created_at})
        Me.list_log.FullRowSelect = True
        Me.list_log.GridLines = True
        Me.list_log.Location = New System.Drawing.Point(0, 0)
        Me.list_log.Name = "list_log"
        Me.list_log.Size = New System.Drawing.Size(553, 399)
        Me.list_log.TabIndex = 2
        Me.list_log.UseCompatibleStateImageBehavior = False
        Me.list_log.View = System.Windows.Forms.View.Details
        '
        'logs_id
        '
        Me.logs_id.Text = "ID"
        Me.logs_id.Width = 0
        '
        'logs_activity
        '
        Me.logs_activity.Text = "ACTIVITY"
        Me.logs_activity.Width = 270
        '
        'logs_user_name
        '
        Me.logs_user_name.Text = "USERNAME"
        Me.logs_user_name.Width = 175
        '
        'logs_user_full_name
        '
        Me.logs_user_full_name.Text = "FULL NAME"
        Me.logs_user_full_name.Width = 279
        '
        'logs_created_at
        '
        Me.logs_created_at.Text = "ACITIVTY DATE"
        Me.logs_created_at.Width = 158
        '
        'pict_user_pict
        '
        Me.pict_user_pict.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.pict_user_pict.BackColor = System.Drawing.Color.White
        Me.pict_user_pict.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.pict_user_pict.Image = Global.CAI.My.Resources.Resources.icons8_user_96
        Me.pict_user_pict.Location = New System.Drawing.Point(563, 133)
        Me.pict_user_pict.Name = "pict_user_pict"
        Me.pict_user_pict.Size = New System.Drawing.Size(109, 105)
        Me.pict_user_pict.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pict_user_pict.TabIndex = 43
        Me.pict_user_pict.TabStop = False
        '
        'Label5
        '
        Me.Label5.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(560, 252)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(97, 13)
        Me.Label5.TabIndex = 35
        Me.Label5.Text = "User Fullname :"
        '
        'Label1
        '
        Me.Label1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(678, 200)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(74, 13)
        Me.Label1.TabIndex = 37
        Me.Label1.Text = "Username :"
        '
        'lbl_username
        '
        Me.lbl_username.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lbl_username.AutoSize = True
        Me.lbl_username.Location = New System.Drawing.Point(678, 222)
        Me.lbl_username.Name = "lbl_username"
        Me.lbl_username.Size = New System.Drawing.Size(65, 13)
        Me.lbl_username.TabIndex = 46
        Me.lbl_username.Text = "Username"
        '
        'lbl_reigestered_since
        '
        Me.lbl_reigestered_since.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lbl_reigestered_since.AutoSize = True
        Me.lbl_reigestered_since.Location = New System.Drawing.Point(678, 155)
        Me.lbl_reigestered_since.Name = "lbl_reigestered_since"
        Me.lbl_reigestered_since.Size = New System.Drawing.Size(133, 13)
        Me.lbl_reigestered_since.TabIndex = 48
        Me.lbl_reigestered_since.Text = "Mon January 01, 2018"
        '
        'Label3
        '
        Me.Label3.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(678, 133)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(112, 13)
        Me.Label3.TabIndex = 47
        Me.Label3.Text = "Registered Since :"
        '
        'Panel1
        '
        Me.Panel1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel1.Controls.Add(Me.Panel3)
        Me.Panel1.Controls.Add(Me.list_recent_logs)
        Me.Panel1.Location = New System.Drawing.Point(561, 334)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(337, 228)
        Me.Panel1.TabIndex = 49
        '
        'Panel3
        '
        Me.Panel3.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel3.BackColor = System.Drawing.Color.Gray
        Me.Panel3.Controls.Add(Me.recent_btn_prev)
        Me.Panel3.Controls.Add(Me.recent_btn_next)
        Me.Panel3.Controls.Add(Me.recent_pagination)
        Me.Panel3.Location = New System.Drawing.Point(0, 196)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(337, 32)
        Me.Panel3.TabIndex = 3
        '
        'recent_btn_prev
        '
        Me.recent_btn_prev.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.recent_btn_prev.FlatAppearance.BorderSize = 0
        Me.recent_btn_prev.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.recent_btn_prev.Image = Global.CAI.My.Resources.Resources.icons8_prev_48
        Me.recent_btn_prev.Location = New System.Drawing.Point(262, 0)
        Me.recent_btn_prev.Name = "recent_btn_prev"
        Me.recent_btn_prev.Size = New System.Drawing.Size(38, 31)
        Me.recent_btn_prev.TabIndex = 2
        Me.recent_btn_prev.UseVisualStyleBackColor = True
        '
        'recent_btn_next
        '
        Me.recent_btn_next.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.recent_btn_next.FlatAppearance.BorderSize = 0
        Me.recent_btn_next.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.recent_btn_next.Image = Global.CAI.My.Resources.Resources.icons8_right_button_48
        Me.recent_btn_next.Location = New System.Drawing.Point(299, 0)
        Me.recent_btn_next.Name = "recent_btn_next"
        Me.recent_btn_next.Size = New System.Drawing.Size(38, 31)
        Me.recent_btn_next.TabIndex = 1
        Me.recent_btn_next.UseVisualStyleBackColor = True
        '
        'recent_pagination
        '
        Me.recent_pagination.AutoSize = True
        Me.recent_pagination.Location = New System.Drawing.Point(14, 10)
        Me.recent_pagination.Name = "recent_pagination"
        Me.recent_pagination.Size = New System.Drawing.Size(86, 13)
        Me.recent_pagination.TabIndex = 0
        Me.recent_pagination.Text = "Page 01 of 10"
        '
        'list_recent_logs
        '
        Me.list_recent_logs.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.list_recent_logs.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1, Me.ColumnHeader2, Me.ColumnHeader3})
        Me.list_recent_logs.FullRowSelect = True
        Me.list_recent_logs.GridLines = True
        Me.list_recent_logs.Location = New System.Drawing.Point(0, 0)
        Me.list_recent_logs.Name = "list_recent_logs"
        Me.list_recent_logs.Size = New System.Drawing.Size(337, 198)
        Me.list_recent_logs.TabIndex = 2
        Me.list_recent_logs.UseCompatibleStateImageBehavior = False
        Me.list_recent_logs.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Text = "ID"
        Me.ColumnHeader1.Width = 0
        '
        'ColumnHeader2
        '
        Me.ColumnHeader2.Text = "ACTIVITY"
        Me.ColumnHeader2.Width = 257
        '
        'ColumnHeader3
        '
        Me.ColumnHeader3.Text = "ACTIVITY DATE"
        Me.ColumnHeader3.Width = 263
        '
        'lbl_user_name
        '
        Me.lbl_user_name.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lbl_user_name.AutoSize = True
        Me.lbl_user_name.Location = New System.Drawing.Point(560, 271)
        Me.lbl_user_name.Name = "lbl_user_name"
        Me.lbl_user_name.Size = New System.Drawing.Size(151, 13)
        Me.lbl_user_name.TabIndex = 50
        Me.lbl_user_name.Text = "Last Name, First Name, E"
        '
        'Label7
        '
        Me.Label7.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(561, 318)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(101, 13)
        Me.Label7.TabIndex = 51
        Me.Label7.Text = "Recent Activities"
        '
        'Button1
        '
        Me.Button1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button1.BackColor = System.Drawing.Color.Transparent
        Me.Button1.FlatAppearance.BorderSize = 0
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.Color.White
        Me.Button1.Image = Global.CAI.My.Resources.Resources.icons8_back_48
        Me.Button1.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.Button1.Location = New System.Drawing.Point(813, 252)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(73, 74)
        Me.Button1.TabIndex = 52
        Me.Button1.Text = "BACK"
        Me.Button1.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.Button1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Heading1
        '
        Me.Heading1.BackColor = System.Drawing.Color.White
        Me.Heading1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Heading1.Font = New System.Drawing.Font("Verdana", 8.25!)
        Me.Heading1.Location = New System.Drawing.Point(0, 0)
        Me.Heading1.Name = "Heading1"
        Me.Heading1.Size = New System.Drawing.Size(898, 127)
        Me.Heading1.TabIndex = 53
        Me.Heading1.Title = "LOG REPORTS"
        '
        'ActivityLogs
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Green
        Me.ClientSize = New System.Drawing.Size(898, 562)
        Me.Controls.Add(Me.Heading1)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.lbl_user_name)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.lbl_reigestered_since)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.lbl_username)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.pict_user_pict)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label1)
        Me.Font = New System.Drawing.Font("Verdana", 8.25!)
        Me.ForeColor = System.Drawing.Color.White
        Me.Name = "ActivityLogs"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "ActivityLogs"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.Panel2.ResumeLayout(False)
        Me.Panel4.ResumeLayout(False)
        Me.Panel4.PerformLayout()
        CType(Me.pict_user_pict, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents Panel4 As System.Windows.Forms.Panel
    Friend WithEvents logs_btn_prev As System.Windows.Forms.Button
    Friend WithEvents logs_btn_next As System.Windows.Forms.Button
    Friend WithEvents logs_pagination As System.Windows.Forms.Label
    Friend WithEvents list_log As System.Windows.Forms.ListView
    Friend WithEvents logs_id As System.Windows.Forms.ColumnHeader
    Friend WithEvents logs_activity As System.Windows.Forms.ColumnHeader
    Friend WithEvents logs_user_full_name As System.Windows.Forms.ColumnHeader
    Friend WithEvents pict_user_pict As System.Windows.Forms.PictureBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents lbl_username As System.Windows.Forms.Label
    Friend WithEvents lbl_reigestered_since As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents recent_btn_prev As System.Windows.Forms.Button
    Friend WithEvents recent_btn_next As System.Windows.Forms.Button
    Friend WithEvents recent_pagination As System.Windows.Forms.Label
    Friend WithEvents list_recent_logs As System.Windows.Forms.ListView
    Friend WithEvents ColumnHeader1 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader2 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader3 As System.Windows.Forms.ColumnHeader
    Friend WithEvents lbl_user_name As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents logs_user_name As System.Windows.Forms.ColumnHeader
    Friend WithEvents logs_created_at As System.Windows.Forms.ColumnHeader
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Heading1 As Heading
End Class
