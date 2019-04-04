<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class UserList
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
        Me.txt_filter = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.form_title = New System.Windows.Forms.Label()
        Me.LineShape1 = New Microsoft.VisualBasic.PowerPacks.LineShape()
        Me.LineShape2 = New Microsoft.VisualBasic.PowerPacks.LineShape()
        Me.ShapeContainer1 = New Microsoft.VisualBasic.PowerPacks.ShapeContainer()
        Me.BTNEdit = New System.Windows.Forms.Button()
        Me.BTNTrash = New System.Windows.Forms.Button()
        Me.BTNCreate = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.btn_prev = New System.Windows.Forms.Button()
        Me.btn_next = New System.Windows.Forms.Button()
        Me.pagination = New System.Windows.Forms.Label()
        Me.user_list = New System.Windows.Forms.ListView()
        Me.ColumnHeader1 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.list_username = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader3 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader4 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.lbl_user_name = New System.Windows.Forms.Label()
        Me.lbl_reigestered_since = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.lbl_username = New System.Windows.Forms.Label()
        Me.pict_user_pict = New System.Windows.Forms.PictureBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.BTNPreview = New System.Windows.Forms.Button()
        Me.BTNApprovedBlocked = New System.Windows.Forms.Button()
        Me.Panel1.SuspendLayout()
        Me.Panel3.SuspendLayout()
        CType(Me.pict_user_pict, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txt_filter
        '
        Me.txt_filter.Location = New System.Drawing.Point(80, 78)
        Me.txt_filter.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txt_filter.Name = "txt_filter"
        Me.txt_filter.Size = New System.Drawing.Size(243, 21)
        Me.txt_filter.TabIndex = 13
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(18, 81)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(56, 13)
        Me.Label1.TabIndex = 12
        Me.Label1.Text = "Search :"
        '
        'form_title
        '
        Me.form_title.AutoSize = True
        Me.form_title.Font = New System.Drawing.Font("Tahoma", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.form_title.Location = New System.Drawing.Point(14, 9)
        Me.form_title.Name = "form_title"
        Me.form_title.Size = New System.Drawing.Size(459, 33)
        Me.form_title.TabIndex = 14
        Me.form_title.Text = "ADMINISTRATOR MANAGEMENT"
        '
        'LineShape1
        '
        Me.LineShape1.BorderColor = System.Drawing.Color.White
        Me.LineShape1.Name = "LineShape1"
        Me.LineShape1.X1 = -12
        Me.LineShape1.X2 = 474
        Me.LineShape1.Y1 = 44
        Me.LineShape1.Y2 = 44
        '
        'LineShape2
        '
        Me.LineShape2.BorderColor = System.Drawing.Color.White
        Me.LineShape2.Name = "LineShape2"
        Me.LineShape2.X1 = -94
        Me.LineShape2.X2 = 408
        Me.LineShape2.Y1 = 55
        Me.LineShape2.Y2 = 55
        '
        'ShapeContainer1
        '
        Me.ShapeContainer1.Location = New System.Drawing.Point(0, 0)
        Me.ShapeContainer1.Margin = New System.Windows.Forms.Padding(0)
        Me.ShapeContainer1.Name = "ShapeContainer1"
        Me.ShapeContainer1.Shapes.AddRange(New Microsoft.VisualBasic.PowerPacks.Shape() {Me.LineShape2, Me.LineShape1})
        Me.ShapeContainer1.Size = New System.Drawing.Size(1020, 562)
        Me.ShapeContainer1.TabIndex = 15
        Me.ShapeContainer1.TabStop = False
        '
        'BTNEdit
        '
        Me.BTNEdit.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BTNEdit.BackColor = System.Drawing.Color.Transparent
        Me.BTNEdit.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BTNEdit.Enabled = False
        Me.BTNEdit.FlatAppearance.BorderSize = 0
        Me.BTNEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BTNEdit.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTNEdit.ForeColor = System.Drawing.Color.White
        Me.BTNEdit.Image = Global.CAI.My.Resources.Resources.edit
        Me.BTNEdit.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.BTNEdit.Location = New System.Drawing.Point(623, 48)
        Me.BTNEdit.Name = "BTNEdit"
        Me.BTNEdit.Size = New System.Drawing.Size(85, 71)
        Me.BTNEdit.TabIndex = 11
        Me.BTNEdit.Text = "EDIT"
        Me.BTNEdit.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.BTNEdit.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.BTNEdit.UseVisualStyleBackColor = False
        '
        'BTNTrash
        '
        Me.BTNTrash.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BTNTrash.BackColor = System.Drawing.Color.Transparent
        Me.BTNTrash.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BTNTrash.Enabled = False
        Me.BTNTrash.FlatAppearance.BorderSize = 0
        Me.BTNTrash.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BTNTrash.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTNTrash.ForeColor = System.Drawing.Color.White
        Me.BTNTrash.Image = Global.CAI.My.Resources.Resources.trash
        Me.BTNTrash.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.BTNTrash.Location = New System.Drawing.Point(725, 48)
        Me.BTNTrash.Name = "BTNTrash"
        Me.BTNTrash.Size = New System.Drawing.Size(85, 71)
        Me.BTNTrash.TabIndex = 10
        Me.BTNTrash.Text = "DELETE"
        Me.BTNTrash.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.BTNTrash.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.BTNTrash.UseVisualStyleBackColor = False
        '
        'BTNCreate
        '
        Me.BTNCreate.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BTNCreate.BackColor = System.Drawing.Color.Transparent
        Me.BTNCreate.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BTNCreate.FlatAppearance.BorderSize = 0
        Me.BTNCreate.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BTNCreate.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTNCreate.ForeColor = System.Drawing.Color.White
        Me.BTNCreate.Image = Global.CAI.My.Resources.Resources.add
        Me.BTNCreate.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.BTNCreate.Location = New System.Drawing.Point(522, 48)
        Me.BTNCreate.Name = "BTNCreate"
        Me.BTNCreate.Size = New System.Drawing.Size(85, 71)
        Me.BTNCreate.TabIndex = 9
        Me.BTNCreate.Text = "ADD"
        Me.BTNCreate.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.BTNCreate.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.BTNCreate.UseVisualStyleBackColor = False
        '
        'Panel1
        '
        Me.Panel1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel1.Controls.Add(Me.Panel3)
        Me.Panel1.Controls.Add(Me.user_list)
        Me.Panel1.Location = New System.Drawing.Point(0, 125)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(810, 437)
        Me.Panel1.TabIndex = 28
        '
        'Panel3
        '
        Me.Panel3.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel3.BackColor = System.Drawing.Color.Gray
        Me.Panel3.Controls.Add(Me.btn_prev)
        Me.Panel3.Controls.Add(Me.btn_next)
        Me.Panel3.Controls.Add(Me.pagination)
        Me.Panel3.Location = New System.Drawing.Point(0, 405)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(810, 32)
        Me.Panel3.TabIndex = 3
        '
        'btn_prev
        '
        Me.btn_prev.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_prev.FlatAppearance.BorderSize = 0
        Me.btn_prev.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_prev.Image = Global.CAI.My.Resources.Resources.icons8_prev_48
        Me.btn_prev.Location = New System.Drawing.Point(735, 0)
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
        Me.btn_next.Location = New System.Drawing.Point(772, 0)
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
        'user_list
        '
        Me.user_list.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.user_list.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1, Me.list_username, Me.ColumnHeader3, Me.ColumnHeader4})
        Me.user_list.FullRowSelect = True
        Me.user_list.GridLines = True
        Me.user_list.Location = New System.Drawing.Point(0, 0)
        Me.user_list.Name = "user_list"
        Me.user_list.Size = New System.Drawing.Size(810, 407)
        Me.user_list.TabIndex = 2
        Me.user_list.UseCompatibleStateImageBehavior = False
        Me.user_list.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Text = "ID"
        Me.ColumnHeader1.Width = 0
        '
        'list_username
        '
        Me.list_username.Text = "USERNAME"
        Me.list_username.Width = 150
        '
        'ColumnHeader3
        '
        Me.ColumnHeader3.Text = "FULL NAME"
        Me.ColumnHeader3.Width = 300
        '
        'ColumnHeader4
        '
        Me.ColumnHeader4.Text = "REGISTERED SINCE"
        Me.ColumnHeader4.Width = 150
        '
        'lbl_user_name
        '
        Me.lbl_user_name.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lbl_user_name.AutoSize = True
        Me.lbl_user_name.Location = New System.Drawing.Point(816, 462)
        Me.lbl_user_name.Name = "lbl_user_name"
        Me.lbl_user_name.Size = New System.Drawing.Size(12, 13)
        Me.lbl_user_name.TabIndex = 59
        Me.lbl_user_name.Text = "-"
        '
        'lbl_reigestered_since
        '
        Me.lbl_reigestered_since.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lbl_reigestered_since.AutoSize = True
        Me.lbl_reigestered_since.Location = New System.Drawing.Point(816, 354)
        Me.lbl_reigestered_since.Name = "lbl_reigestered_since"
        Me.lbl_reigestered_since.Size = New System.Drawing.Size(12, 13)
        Me.lbl_reigestered_since.TabIndex = 57
        Me.lbl_reigestered_since.Text = "-"
        '
        'Label3
        '
        Me.Label3.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(816, 327)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(112, 13)
        Me.Label3.TabIndex = 56
        Me.Label3.Text = "Registered Since :"
        '
        'lbl_username
        '
        Me.lbl_username.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lbl_username.AutoSize = True
        Me.lbl_username.Location = New System.Drawing.Point(816, 408)
        Me.lbl_username.Name = "lbl_username"
        Me.lbl_username.Size = New System.Drawing.Size(12, 13)
        Me.lbl_username.TabIndex = 55
        Me.lbl_username.Text = "-"
        '
        'pict_user_pict
        '
        Me.pict_user_pict.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.pict_user_pict.BackColor = System.Drawing.Color.White
        Me.pict_user_pict.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.pict_user_pict.Image = Global.CAI.My.Resources.Resources.icons8_user_96
        Me.pict_user_pict.Location = New System.Drawing.Point(819, 125)
        Me.pict_user_pict.Name = "pict_user_pict"
        Me.pict_user_pict.Size = New System.Drawing.Size(189, 181)
        Me.pict_user_pict.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pict_user_pict.TabIndex = 54
        Me.pict_user_pict.TabStop = False
        '
        'Label5
        '
        Me.Label5.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(816, 435)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(97, 13)
        Me.Label5.TabIndex = 52
        Me.Label5.Text = "User Fullname :"
        '
        'Label8
        '
        Me.Label8.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(816, 381)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(74, 13)
        Me.Label8.TabIndex = 53
        Me.Label8.Text = "Username :"
        '
        'Button1
        '
        Me.Button1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button1.BackColor = System.Drawing.Color.Transparent
        Me.Button1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button1.FlatAppearance.BorderSize = 0
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.Color.White
        Me.Button1.Image = Global.CAI.My.Resources.Resources.icons8_back_48
        Me.Button1.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.Button1.Location = New System.Drawing.Point(431, 48)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(85, 71)
        Me.Button1.TabIndex = 60
        Me.Button1.Text = "BACK"
        Me.Button1.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.Button1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.Button1.UseVisualStyleBackColor = False
        '
        'BTNPreview
        '
        Me.BTNPreview.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BTNPreview.BackColor = System.Drawing.Color.Transparent
        Me.BTNPreview.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BTNPreview.Enabled = False
        Me.BTNPreview.FlatAppearance.BorderSize = 0
        Me.BTNPreview.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BTNPreview.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTNPreview.ForeColor = System.Drawing.Color.White
        Me.BTNPreview.Image = Global.CAI.My.Resources.Resources.icons8_eye_48
        Me.BTNPreview.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.BTNPreview.Location = New System.Drawing.Point(923, 48)
        Me.BTNPreview.Name = "BTNPreview"
        Me.BTNPreview.Size = New System.Drawing.Size(85, 71)
        Me.BTNPreview.TabIndex = 61
        Me.BTNPreview.Text = "PREVIEW"
        Me.BTNPreview.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.BTNPreview.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.BTNPreview.UseVisualStyleBackColor = False
        '
        'BTNApprovedBlocked
        '
        Me.BTNApprovedBlocked.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BTNApprovedBlocked.BackColor = System.Drawing.Color.Transparent
        Me.BTNApprovedBlocked.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BTNApprovedBlocked.Enabled = False
        Me.BTNApprovedBlocked.FlatAppearance.BorderSize = 0
        Me.BTNApprovedBlocked.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BTNApprovedBlocked.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTNApprovedBlocked.ForeColor = System.Drawing.Color.White
        Me.BTNApprovedBlocked.Image = Global.CAI.My.Resources.Resources.icons8_ok_48
        Me.BTNApprovedBlocked.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.BTNApprovedBlocked.Location = New System.Drawing.Point(725, 48)
        Me.BTNApprovedBlocked.Name = "BTNApprovedBlocked"
        Me.BTNApprovedBlocked.Size = New System.Drawing.Size(85, 71)
        Me.BTNApprovedBlocked.TabIndex = 62
        Me.BTNApprovedBlocked.Text = "APPROVE"
        Me.BTNApprovedBlocked.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.BTNApprovedBlocked.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.BTNApprovedBlocked.UseVisualStyleBackColor = False
        Me.BTNApprovedBlocked.Visible = False
        '
        'UserList
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Green
        Me.ClientSize = New System.Drawing.Size(1020, 562)
        Me.Controls.Add(Me.BTNApprovedBlocked)
        Me.Controls.Add(Me.BTNPreview)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.lbl_user_name)
        Me.Controls.Add(Me.lbl_reigestered_since)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.lbl_username)
        Me.Controls.Add(Me.pict_user_pict)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.form_title)
        Me.Controls.Add(Me.txt_filter)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.BTNEdit)
        Me.Controls.Add(Me.BTNTrash)
        Me.Controls.Add(Me.BTNCreate)
        Me.Controls.Add(Me.ShapeContainer1)
        Me.Font = New System.Drawing.Font("Verdana", 8.25!)
        Me.ForeColor = System.Drawing.Color.White
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Name = "UserList"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "List"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.Panel1.ResumeLayout(False)
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        CType(Me.pict_user_pict, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents BTNEdit As System.Windows.Forms.Button
    Friend WithEvents BTNTrash As System.Windows.Forms.Button
    Friend WithEvents BTNCreate As System.Windows.Forms.Button
    Friend WithEvents txt_filter As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents form_title As System.Windows.Forms.Label
    Friend WithEvents LineShape1 As Microsoft.VisualBasic.PowerPacks.LineShape
    Friend WithEvents LineShape2 As Microsoft.VisualBasic.PowerPacks.LineShape
    Friend WithEvents ShapeContainer1 As Microsoft.VisualBasic.PowerPacks.ShapeContainer
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents btn_prev As System.Windows.Forms.Button
    Friend WithEvents btn_next As System.Windows.Forms.Button
    Friend WithEvents pagination As System.Windows.Forms.Label
    Friend WithEvents user_list As System.Windows.Forms.ListView
    Friend WithEvents ColumnHeader1 As System.Windows.Forms.ColumnHeader
    Friend WithEvents list_username As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader3 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader4 As System.Windows.Forms.ColumnHeader
    Friend WithEvents lbl_user_name As System.Windows.Forms.Label
    Friend WithEvents lbl_reigestered_since As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents lbl_username As System.Windows.Forms.Label
    Friend WithEvents pict_user_pict As System.Windows.Forms.PictureBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents BTNPreview As System.Windows.Forms.Button
    Friend WithEvents BTNApprovedBlocked As System.Windows.Forms.Button
End Class
