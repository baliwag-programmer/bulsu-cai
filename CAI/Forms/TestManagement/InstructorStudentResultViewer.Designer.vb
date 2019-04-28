<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class InstructorStudentResultViewer
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
        Me.Button1 = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.lbl_name = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.dp_user_profile = New System.Windows.Forms.PictureBox()
        Me.lbl_username = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.LBLTitlte = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.LBLIndication = New System.Windows.Forms.Label()
        Me.LBLDescription = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.ComboShowStudents = New System.Windows.Forms.ComboBox()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.list_results = New System.Windows.Forms.ListView()
        Me.head_id = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader1 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader2 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader4 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader5 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader6 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader7 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.LBLDuration = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.ActionPrint = New System.Windows.Forms.Button()
        Me.Heading1 = New CAI.Heading()
        Me.ButtonExport = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        CType(Me.dp_user_profile, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
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
        Me.Button1.Location = New System.Drawing.Point(946, 133)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(73, 74)
        Me.Button1.TabIndex = 36
        Me.Button1.Text = "BACK"
        Me.Button1.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.Button1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.Button1.UseVisualStyleBackColor = False
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox1.BackColor = System.Drawing.Color.White
        Me.GroupBox1.Controls.Add(Me.lbl_name)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.dp_user_profile)
        Me.GroupBox1.Controls.Add(Me.lbl_username)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.ForeColor = System.Drawing.Color.Black
        Me.GroupBox1.Location = New System.Drawing.Point(608, 1)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(411, 121)
        Me.GroupBox1.TabIndex = 37
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "INSTRUCTOR DETAILS"
        '
        'lbl_name
        '
        Me.lbl_name.AutoSize = True
        Me.lbl_name.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_name.Location = New System.Drawing.Point(219, 74)
        Me.lbl_name.Name = "lbl_name"
        Me.lbl_name.Size = New System.Drawing.Size(12, 13)
        Me.lbl_name.TabIndex = 11
        Me.lbl_name.Text = "-"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(97, 74)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(119, 13)
        Me.Label3.TabIndex = 10
        Me.Label3.Text = "USER FULLNAME :"
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
        'lbl_username
        '
        Me.lbl_username.AutoSize = True
        Me.lbl_username.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_username.Location = New System.Drawing.Point(219, 48)
        Me.lbl_username.Name = "lbl_username"
        Me.lbl_username.Size = New System.Drawing.Size(12, 13)
        Me.lbl_username.TabIndex = 3
        Me.lbl_username.Text = "-"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(132, 48)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(84, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "USERNAME :"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(12, 139)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(58, 18)
        Me.Label1.TabIndex = 38
        Me.Label1.Text = "Title :"
        '
        'LBLTitlte
        '
        Me.LBLTitlte.Font = New System.Drawing.Font("Verdana", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBLTitlte.Location = New System.Drawing.Point(12, 163)
        Me.LBLTitlte.Name = "LBLTitlte"
        Me.LBLTitlte.Size = New System.Drawing.Size(585, 26)
        Me.LBLTitlte.TabIndex = 39
        Me.LBLTitlte.Text = "-"
        Me.LBLTitlte.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(14, 195)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(113, 18)
        Me.Label10.TabIndex = 40
        Me.Label10.Text = "Description :"
        '
        'LBLIndication
        '
        Me.LBLIndication.AutoSize = True
        Me.LBLIndication.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBLIndication.Location = New System.Drawing.Point(9, 15)
        Me.LBLIndication.Name = "LBLIndication"
        Me.LBLIndication.Size = New System.Drawing.Size(508, 16)
        Me.LBLIndication.TabIndex = 42
        Me.LBLIndication.Text = "Total Student : 00 | Total Student Passed : 00 | Total Student Failed : 00"
        '
        'LBLDescription
        '
        Me.LBLDescription.Font = New System.Drawing.Font("Verdana", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBLDescription.Location = New System.Drawing.Point(14, 219)
        Me.LBLDescription.Name = "LBLDescription"
        Me.LBLDescription.Size = New System.Drawing.Size(1002, 68)
        Me.LBLDescription.TabIndex = 41
        Me.LBLDescription.Text = "-"
        '
        'Panel1
        '
        Me.Panel1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel1.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.ComboShowStudents)
        Me.Panel1.Controls.Add(Me.LBLIndication)
        Me.Panel1.Location = New System.Drawing.Point(0, 293)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1028, 45)
        Me.Panel1.TabIndex = 43
        '
        'Label4
        '
        Me.Label4.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(620, 16)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(181, 16)
        Me.Label4.TabIndex = 44
        Me.Label4.Text = "FILTER YEAR && SECTION :"
        '
        'ComboShowStudents
        '
        Me.ComboShowStudents.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ComboShowStudents.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboShowStudents.Font = New System.Drawing.Font("Tahoma", 14.25!)
        Me.ComboShowStudents.FormattingEnabled = True
        Me.ComboShowStudents.Location = New System.Drawing.Point(807, 7)
        Me.ComboShowStudents.Name = "ComboShowStudents"
        Me.ComboShowStudents.Size = New System.Drawing.Size(209, 31)
        Me.ComboShowStudents.TabIndex = 43
        '
        'Panel2
        '
        Me.Panel2.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel2.Controls.Add(Me.list_results)
        Me.Panel2.Location = New System.Drawing.Point(-1, 336)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1029, 226)
        Me.Panel2.TabIndex = 59
        '
        'list_results
        '
        Me.list_results.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.list_results.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.head_id, Me.ColumnHeader1, Me.ColumnHeader2, Me.ColumnHeader4, Me.ColumnHeader5, Me.ColumnHeader6, Me.ColumnHeader7})
        Me.list_results.FullRowSelect = True
        Me.list_results.GridLines = True
        Me.list_results.Location = New System.Drawing.Point(0, 0)
        Me.list_results.Name = "list_results"
        Me.list_results.Size = New System.Drawing.Size(1029, 226)
        Me.list_results.TabIndex = 2
        Me.list_results.UseCompatibleStateImageBehavior = False
        Me.list_results.View = System.Windows.Forms.View.Details
        '
        'head_id
        '
        Me.head_id.Width = 0
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Text = "STUDENT NUMBER"
        Me.ColumnHeader1.Width = 126
        '
        'ColumnHeader2
        '
        Me.ColumnHeader2.Text = "STUDENT NAME"
        Me.ColumnHeader2.Width = 245
        '
        'ColumnHeader4
        '
        Me.ColumnHeader4.Text = "DATE TAKEN"
        Me.ColumnHeader4.Width = 277
        '
        'ColumnHeader5
        '
        Me.ColumnHeader5.Text = "TOTAL CORRECT"
        Me.ColumnHeader5.Width = 134
        '
        'ColumnHeader6
        '
        Me.ColumnHeader6.Text = "TOTAL WRONG"
        Me.ColumnHeader6.Width = 116
        '
        'ColumnHeader7
        '
        Me.ColumnHeader7.Text = "AVERAGE"
        Me.ColumnHeader7.Width = 100
        '
        'LBLDuration
        '
        Me.LBLDuration.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LBLDuration.Font = New System.Drawing.Font("Verdana", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBLDuration.Location = New System.Drawing.Point(602, 163)
        Me.LBLDuration.Name = "LBLDuration"
        Me.LBLDuration.Size = New System.Drawing.Size(335, 26)
        Me.LBLDuration.TabIndex = 61
        Me.LBLDuration.Text = "00 : 00"
        Me.LBLDuration.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label13
        '
        Me.Label13.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(602, 139)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(91, 18)
        Me.Label13.TabIndex = 60
        Me.Label13.Text = "Duration :"
        '
        'ActionPrint
        '
        Me.ActionPrint.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ActionPrint.BackColor = System.Drawing.Color.Transparent
        Me.ActionPrint.FlatAppearance.BorderSize = 0
        Me.ActionPrint.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ActionPrint.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ActionPrint.ForeColor = System.Drawing.Color.White
        Me.ActionPrint.Image = Global.CAI.My.Resources.Resources.icons8_send_to_printer_48
        Me.ActionPrint.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.ActionPrint.Location = New System.Drawing.Point(873, 133)
        Me.ActionPrint.Name = "ActionPrint"
        Me.ActionPrint.Size = New System.Drawing.Size(73, 74)
        Me.ActionPrint.TabIndex = 63
        Me.ActionPrint.Text = "PRINT"
        Me.ActionPrint.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.ActionPrint.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.ActionPrint.UseVisualStyleBackColor = False
        '
        'Heading1
        '
        Me.Heading1.BackColor = System.Drawing.Color.White
        Me.Heading1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Heading1.Font = New System.Drawing.Font("Verdana", 8.25!)
        Me.Heading1.Location = New System.Drawing.Point(0, 0)
        Me.Heading1.Name = "Heading1"
        Me.Heading1.Size = New System.Drawing.Size(1028, 127)
        Me.Heading1.TabIndex = 62
        Me.Heading1.Title = ""
        '
        'ButtonExport
        '
        Me.ButtonExport.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ButtonExport.BackColor = System.Drawing.Color.Transparent
        Me.ButtonExport.FlatAppearance.BorderSize = 0
        Me.ButtonExport.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonExport.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonExport.ForeColor = System.Drawing.Color.White
        Me.ButtonExport.Image = Global.CAI.My.Resources.Resources.icons8_microsoft_excel_48
        Me.ButtonExport.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.ButtonExport.Location = New System.Drawing.Point(800, 133)
        Me.ButtonExport.Name = "ButtonExport"
        Me.ButtonExport.Size = New System.Drawing.Size(73, 74)
        Me.ButtonExport.TabIndex = 64
        Me.ButtonExport.Text = "EXPORT"
        Me.ButtonExport.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.ButtonExport.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.ButtonExport.UseVisualStyleBackColor = False
        '
        'InstructorStudentResultViewer
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Green
        Me.ClientSize = New System.Drawing.Size(1028, 562)
        Me.Controls.Add(Me.ButtonExport)
        Me.Controls.Add(Me.ActionPrint)
        Me.Controls.Add(Me.LBLDuration)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.LBLDescription)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.LBLTitlte)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Heading1)
        Me.Font = New System.Drawing.Font("Verdana", 8.25!)
        Me.ForeColor = System.Drawing.Color.White
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "InstructorStudentResultViewer"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "InstructorStudentResultViewer"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.dp_user_profile, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents lbl_name As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents dp_user_profile As System.Windows.Forms.PictureBox
    Friend WithEvents lbl_username As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents LBLTitlte As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents LBLIndication As System.Windows.Forms.Label
    Friend WithEvents LBLDescription As System.Windows.Forms.Label
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents list_results As System.Windows.Forms.ListView
    Friend WithEvents head_id As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader4 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader5 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader6 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader7 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader1 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader2 As System.Windows.Forms.ColumnHeader
    Friend WithEvents LBLDuration As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Heading1 As Heading
    Friend WithEvents ActionPrint As Button
    Friend WithEvents ButtonExport As Button
    Friend WithEvents Label4 As Label
    Friend WithEvents ComboShowStudents As ComboBox
End Class
