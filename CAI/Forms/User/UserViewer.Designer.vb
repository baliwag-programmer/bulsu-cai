<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class UserViewer
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
        Me.Label7 = New System.Windows.Forms.Label()
        Me.lbl_user_name = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.btn_prev = New System.Windows.Forms.Button()
        Me.btn_next = New System.Windows.Forms.Button()
        Me.pagination = New System.Windows.Forms.Label()
        Me.list_log = New System.Windows.Forms.ListView()
        Me.ColumnHeader1 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader2 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader3 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.lbl_registered_since = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.lbl_username = New System.Windows.Forms.Label()
        Me.pict_user_pict = New System.Windows.Forms.PictureBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.BTNEdit = New System.Windows.Forms.Button()
        Me.BTNPassword = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Panel1.SuspendLayout()
        Me.Panel3.SuspendLayout()
        CType(Me.pict_user_pict, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(10, 174)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(101, 13)
        Me.Label7.TabIndex = 60
        Me.Label7.Text = "Recent Activities"
        '
        'lbl_user_name
        '
        Me.lbl_user_name.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lbl_user_name.AutoSize = True
        Me.lbl_user_name.Location = New System.Drawing.Point(315, 98)
        Me.lbl_user_name.Name = "lbl_user_name"
        Me.lbl_user_name.Size = New System.Drawing.Size(151, 13)
        Me.lbl_user_name.TabIndex = 59
        Me.lbl_user_name.Text = "Last Name, First Name, E"
        '
        'Panel1
        '
        Me.Panel1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel1.Controls.Add(Me.Panel3)
        Me.Panel1.Controls.Add(Me.list_log)
        Me.Panel1.Location = New System.Drawing.Point(-4, 190)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(530, 317)
        Me.Panel1.TabIndex = 58
        '
        'Panel3
        '
        Me.Panel3.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel3.BackColor = System.Drawing.Color.Gray
        Me.Panel3.Controls.Add(Me.btn_prev)
        Me.Panel3.Controls.Add(Me.btn_next)
        Me.Panel3.Controls.Add(Me.pagination)
        Me.Panel3.Location = New System.Drawing.Point(0, 285)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(530, 32)
        Me.Panel3.TabIndex = 3
        '
        'btn_prev
        '
        Me.btn_prev.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_prev.FlatAppearance.BorderSize = 0
        Me.btn_prev.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_prev.Image = Global.CAI.My.Resources.Resources.icons8_prev_48
        Me.btn_prev.Location = New System.Drawing.Point(455, 0)
        Me.btn_prev.Name = "btn_prev"
        Me.btn_prev.Size = New System.Drawing.Size(38, 31)
        Me.btn_prev.TabIndex = 2
        Me.btn_prev.UseVisualStyleBackColor = True
        '
        'btn_next
        '
        Me.btn_next.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_next.FlatAppearance.BorderSize = 0
        Me.btn_next.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_next.Image = Global.CAI.My.Resources.Resources.icons8_right_button_48
        Me.btn_next.Location = New System.Drawing.Point(492, 0)
        Me.btn_next.Name = "btn_next"
        Me.btn_next.Size = New System.Drawing.Size(38, 31)
        Me.btn_next.TabIndex = 1
        Me.btn_next.UseVisualStyleBackColor = True
        '
        'pagination
        '
        Me.pagination.AutoSize = True
        Me.pagination.Location = New System.Drawing.Point(14, 10)
        Me.pagination.Name = "pagination"
        Me.pagination.Size = New System.Drawing.Size(86, 13)
        Me.pagination.TabIndex = 0
        Me.pagination.Text = "Page 01 of 10"
        '
        'list_log
        '
        Me.list_log.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.list_log.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1, Me.ColumnHeader2, Me.ColumnHeader3})
        Me.list_log.FullRowSelect = True
        Me.list_log.GridLines = True
        Me.list_log.Location = New System.Drawing.Point(0, 0)
        Me.list_log.Name = "list_log"
        Me.list_log.Size = New System.Drawing.Size(530, 287)
        Me.list_log.TabIndex = 2
        Me.list_log.UseCompatibleStateImageBehavior = False
        Me.list_log.View = System.Windows.Forms.View.Details
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
        'lbl_registered_since
        '
        Me.lbl_registered_since.AutoSize = True
        Me.lbl_registered_since.Location = New System.Drawing.Point(127, 34)
        Me.lbl_registered_since.Name = "lbl_registered_since"
        Me.lbl_registered_since.Size = New System.Drawing.Size(133, 13)
        Me.lbl_registered_since.TabIndex = 57
        Me.lbl_registered_since.Text = "Mon January 01, 2018"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(127, 12)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(112, 13)
        Me.Label3.TabIndex = 56
        Me.Label3.Text = "Registered Since :"
        '
        'lbl_username
        '
        Me.lbl_username.AutoSize = True
        Me.lbl_username.Location = New System.Drawing.Point(127, 101)
        Me.lbl_username.Name = "lbl_username"
        Me.lbl_username.Size = New System.Drawing.Size(65, 13)
        Me.lbl_username.TabIndex = 55
        Me.lbl_username.Text = "Username"
        '
        'pict_user_pict
        '
        Me.pict_user_pict.BackColor = System.Drawing.Color.White
        Me.pict_user_pict.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.pict_user_pict.Image = Global.CAI.My.Resources.Resources.icons8_user_96
        Me.pict_user_pict.Location = New System.Drawing.Point(12, 12)
        Me.pict_user_pict.Name = "pict_user_pict"
        Me.pict_user_pict.Size = New System.Drawing.Size(109, 105)
        Me.pict_user_pict.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pict_user_pict.TabIndex = 54
        Me.pict_user_pict.TabStop = False
        '
        'Label5
        '
        Me.Label5.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(315, 79)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(97, 13)
        Me.Label5.TabIndex = 52
        Me.Label5.Text = "User Fullname :"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(127, 79)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(74, 13)
        Me.Label1.TabIndex = 53
        Me.Label1.Text = "Username :"
        '
        'BTNEdit
        '
        Me.BTNEdit.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BTNEdit.BackColor = System.Drawing.Color.Transparent
        Me.BTNEdit.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BTNEdit.FlatAppearance.BorderSize = 0
        Me.BTNEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BTNEdit.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTNEdit.ForeColor = System.Drawing.Color.White
        Me.BTNEdit.Image = Global.CAI.My.Resources.Resources.edit
        Me.BTNEdit.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.BTNEdit.Location = New System.Drawing.Point(441, 116)
        Me.BTNEdit.Name = "BTNEdit"
        Me.BTNEdit.Size = New System.Drawing.Size(85, 71)
        Me.BTNEdit.TabIndex = 62
        Me.BTNEdit.Text = "PROFILE"
        Me.BTNEdit.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.BTNEdit.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.BTNEdit.UseVisualStyleBackColor = False
        '
        'BTNPassword
        '
        Me.BTNPassword.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BTNPassword.BackColor = System.Drawing.Color.Transparent
        Me.BTNPassword.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BTNPassword.FlatAppearance.BorderSize = 0
        Me.BTNPassword.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BTNPassword.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTNPassword.ForeColor = System.Drawing.Color.White
        Me.BTNPassword.Image = Global.CAI.My.Resources.Resources.icons8_key_2_48
        Me.BTNPassword.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.BTNPassword.Location = New System.Drawing.Point(350, 116)
        Me.BTNPassword.Name = "BTNPassword"
        Me.BTNPassword.Size = New System.Drawing.Size(85, 71)
        Me.BTNPassword.TabIndex = 61
        Me.BTNPassword.Text = "Security"
        Me.BTNPassword.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.BTNPassword.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.BTNPassword.UseVisualStyleBackColor = False
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
        Me.Button1.Location = New System.Drawing.Point(259, 116)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(85, 71)
        Me.Button1.TabIndex = 63
        Me.Button1.Text = "BACK"
        Me.Button1.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.Button1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.Button1.UseVisualStyleBackColor = False
        '
        'UserViewer
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Green
        Me.ClientSize = New System.Drawing.Size(525, 507)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.BTNEdit)
        Me.Controls.Add(Me.BTNPassword)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.lbl_user_name)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.lbl_registered_since)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.lbl_username)
        Me.Controls.Add(Me.pict_user_pict)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label1)
        Me.Font = New System.Drawing.Font("Verdana", 8.25!)
        Me.ForeColor = System.Drawing.Color.White
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "UserViewer"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "USER VIEWER"
        Me.Panel1.ResumeLayout(False)
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        CType(Me.pict_user_pict, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents lbl_user_name As System.Windows.Forms.Label
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents btn_prev As System.Windows.Forms.Button
    Friend WithEvents btn_next As System.Windows.Forms.Button
    Friend WithEvents pagination As System.Windows.Forms.Label
    Friend WithEvents list_log As System.Windows.Forms.ListView
    Friend WithEvents ColumnHeader1 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader2 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader3 As System.Windows.Forms.ColumnHeader
    Friend WithEvents lbl_registered_since As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents lbl_username As System.Windows.Forms.Label
    Friend WithEvents pict_user_pict As System.Windows.Forms.PictureBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents BTNEdit As System.Windows.Forms.Button
    Friend WithEvents BTNPassword As System.Windows.Forms.Button
    Friend WithEvents Button1 As System.Windows.Forms.Button

End Class
