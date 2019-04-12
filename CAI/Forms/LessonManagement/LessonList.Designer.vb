<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class LessonList
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txt_filter = New System.Windows.Forms.TextBox()
        Me.BTNEdit = New System.Windows.Forms.Button()
        Me.BTNTrash = New System.Windows.Forms.Button()
        Me.BTNCreate = New System.Windows.Forms.Button()
        Me.id = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.title = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.description = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader1 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader2 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader3 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader4 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader5 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader6 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader7 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader8 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader9 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ListContainer = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.lesson_prev = New System.Windows.Forms.Button()
        Me.lesson_next = New System.Windows.Forms.Button()
        Me.lesson_page = New System.Windows.Forms.Label()
        Me.lesson_list = New System.Windows.Forms.ListView()
        Me.lessons_id = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.lessons_title = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.lessons_description = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.lessons_created_at = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.AttachmentViewer1 = New CAI.AttachmentViewer()
        Me.txt_lesson_description = New System.Windows.Forms.RichTextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.lbl_lesson_title = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.BTNLocker = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Heading1 = New CAI.Heading()
        Me.ListContainer.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(4, 184)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(57, 16)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Search :"
        '
        'txt_filter
        '
        Me.txt_filter.Location = New System.Drawing.Point(66, 181)
        Me.txt_filter.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txt_filter.Name = "txt_filter"
        Me.txt_filter.Size = New System.Drawing.Size(193, 23)
        Me.txt_filter.TabIndex = 3
        '
        'BTNEdit
        '
        Me.BTNEdit.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BTNEdit.BackColor = System.Drawing.Color.Transparent
        Me.BTNEdit.Enabled = False
        Me.BTNEdit.FlatAppearance.BorderSize = 0
        Me.BTNEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BTNEdit.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTNEdit.ForeColor = System.Drawing.Color.White
        Me.BTNEdit.Image = Global.CAI.My.Resources.Resources.edit
        Me.BTNEdit.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.BTNEdit.Location = New System.Drawing.Point(443, 153)
        Me.BTNEdit.Name = "BTNEdit"
        Me.BTNEdit.Size = New System.Drawing.Size(73, 71)
        Me.BTNEdit.TabIndex = 8
        Me.BTNEdit.Text = "EDIT"
        Me.BTNEdit.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.BTNEdit.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.BTNEdit.UseVisualStyleBackColor = False
        '
        'BTNTrash
        '
        Me.BTNTrash.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BTNTrash.BackColor = System.Drawing.Color.Transparent
        Me.BTNTrash.Enabled = False
        Me.BTNTrash.FlatAppearance.BorderSize = 0
        Me.BTNTrash.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BTNTrash.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTNTrash.ForeColor = System.Drawing.Color.White
        Me.BTNTrash.Image = Global.CAI.My.Resources.Resources.trash
        Me.BTNTrash.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.BTNTrash.Location = New System.Drawing.Point(523, 153)
        Me.BTNTrash.Name = "BTNTrash"
        Me.BTNTrash.Size = New System.Drawing.Size(73, 71)
        Me.BTNTrash.TabIndex = 7
        Me.BTNTrash.Text = "DELETE"
        Me.BTNTrash.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.BTNTrash.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.BTNTrash.UseVisualStyleBackColor = False
        '
        'BTNCreate
        '
        Me.BTNCreate.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BTNCreate.BackColor = System.Drawing.Color.Transparent
        Me.BTNCreate.FlatAppearance.BorderSize = 0
        Me.BTNCreate.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BTNCreate.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTNCreate.ForeColor = System.Drawing.Color.White
        Me.BTNCreate.Image = Global.CAI.My.Resources.Resources.add
        Me.BTNCreate.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.BTNCreate.Location = New System.Drawing.Point(363, 153)
        Me.BTNCreate.Name = "BTNCreate"
        Me.BTNCreate.Size = New System.Drawing.Size(73, 71)
        Me.BTNCreate.TabIndex = 6
        Me.BTNCreate.Text = "CREATE"
        Me.BTNCreate.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.BTNCreate.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.BTNCreate.UseVisualStyleBackColor = False
        '
        'id
        '
        Me.id.Text = "ID"
        Me.id.Width = 0
        '
        'title
        '
        Me.title.Text = "TITLE"
        Me.title.Width = 150
        '
        'description
        '
        Me.description.Text = "DESCRIPTION"
        Me.description.Width = 300
        '
        'ListContainer
        '
        Me.ListContainer.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ListContainer.Controls.Add(Me.Panel2)
        Me.ListContainer.Controls.Add(Me.lesson_list)
        Me.ListContainer.Location = New System.Drawing.Point(0, 231)
        Me.ListContainer.Name = "ListContainer"
        Me.ListContainer.Size = New System.Drawing.Size(680, 341)
        Me.ListContainer.TabIndex = 17
        '
        'Panel2
        '
        Me.Panel2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel2.BackColor = System.Drawing.Color.Gray
        Me.Panel2.Controls.Add(Me.lesson_prev)
        Me.Panel2.Controls.Add(Me.lesson_next)
        Me.Panel2.Controls.Add(Me.lesson_page)
        Me.Panel2.Location = New System.Drawing.Point(0, 309)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(680, 32)
        Me.Panel2.TabIndex = 3
        '
        'lesson_prev
        '
        Me.lesson_prev.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lesson_prev.FlatAppearance.BorderSize = 0
        Me.lesson_prev.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.lesson_prev.Image = Global.CAI.My.Resources.Resources.icons8_prev_48
        Me.lesson_prev.Location = New System.Drawing.Point(605, 0)
        Me.lesson_prev.Name = "lesson_prev"
        Me.lesson_prev.Size = New System.Drawing.Size(38, 31)
        Me.lesson_prev.TabIndex = 2
        Me.lesson_prev.UseVisualStyleBackColor = True
        '
        'lesson_next
        '
        Me.lesson_next.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lesson_next.FlatAppearance.BorderSize = 0
        Me.lesson_next.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.lesson_next.Image = Global.CAI.My.Resources.Resources.icons8_right_button_48
        Me.lesson_next.Location = New System.Drawing.Point(642, 0)
        Me.lesson_next.Name = "lesson_next"
        Me.lesson_next.Size = New System.Drawing.Size(38, 31)
        Me.lesson_next.TabIndex = 1
        Me.lesson_next.UseVisualStyleBackColor = True
        '
        'lesson_page
        '
        Me.lesson_page.AutoSize = True
        Me.lesson_page.Location = New System.Drawing.Point(14, 10)
        Me.lesson_page.Name = "lesson_page"
        Me.lesson_page.Size = New System.Drawing.Size(87, 16)
        Me.lesson_page.TabIndex = 0
        Me.lesson_page.Text = "Page 01 of 10"
        '
        'lesson_list
        '
        Me.lesson_list.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lesson_list.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.lessons_id, Me.lessons_title, Me.lessons_description, Me.lessons_created_at})
        Me.lesson_list.FullRowSelect = True
        Me.lesson_list.GridLines = True
        Me.lesson_list.Location = New System.Drawing.Point(0, 0)
        Me.lesson_list.Name = "lesson_list"
        Me.lesson_list.Size = New System.Drawing.Size(680, 311)
        Me.lesson_list.TabIndex = 2
        Me.lesson_list.UseCompatibleStateImageBehavior = False
        Me.lesson_list.View = System.Windows.Forms.View.Details
        '
        'lessons_id
        '
        Me.lessons_id.Text = "ID"
        Me.lessons_id.Width = 0
        '
        'lessons_title
        '
        Me.lessons_title.Text = "TITLE"
        Me.lessons_title.Width = 150
        '
        'lessons_description
        '
        Me.lessons_description.Text = "DESCRIPTION"
        Me.lessons_description.Width = 300
        '
        'lessons_created_at
        '
        Me.lessons_created_at.Text = "CREATED AT"
        Me.lessons_created_at.Width = 150
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox1.Controls.Add(Me.AttachmentViewer1)
        Me.GroupBox1.Controls.Add(Me.txt_lesson_description)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.lbl_lesson_title)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.ForeColor = System.Drawing.Color.White
        Me.GroupBox1.Location = New System.Drawing.Point(686, 151)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(371, 415)
        Me.GroupBox1.TabIndex = 18
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "LESSON VIEWER"
        '
        'AttachmentViewer1
        '
        Me.AttachmentViewer1.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.AttachmentViewer1.Font = New System.Drawing.Font("Verdana", 8.25!)
        Me.AttachmentViewer1.Location = New System.Drawing.Point(9, 22)
        Me.AttachmentViewer1.Name = "AttachmentViewer1"
        Me.AttachmentViewer1.SelectedFile = ""
        Me.AttachmentViewer1.Size = New System.Drawing.Size(356, 242)
        Me.AttachmentViewer1.TabIndex = 17
        '
        'txt_lesson_description
        '
        Me.txt_lesson_description.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txt_lesson_description.Location = New System.Drawing.Point(6, 312)
        Me.txt_lesson_description.Name = "txt_lesson_description"
        Me.txt_lesson_description.ReadOnly = True
        Me.txt_lesson_description.Size = New System.Drawing.Size(359, 97)
        Me.txt_lesson_description.TabIndex = 16
        Me.txt_lesson_description.Text = ""
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(6, 293)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(108, 16)
        Me.Label6.TabIndex = 15
        Me.Label6.Text = "DESCRIPTION :"
        '
        'lbl_lesson_title
        '
        Me.lbl_lesson_title.AutoSize = True
        Me.lbl_lesson_title.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_lesson_title.Location = New System.Drawing.Point(69, 267)
        Me.lbl_lesson_title.Name = "lbl_lesson_title"
        Me.lbl_lesson_title.Size = New System.Drawing.Size(23, 16)
        Me.lbl_lesson_title.TabIndex = 14
        Me.lbl_lesson_title.Text = "..."
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(6, 267)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(57, 16)
        Me.Label3.TabIndex = 13
        Me.Label3.Text = "TITLE :"
        '
        'BTNLocker
        '
        Me.BTNLocker.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BTNLocker.BackColor = System.Drawing.Color.Transparent
        Me.BTNLocker.Enabled = False
        Me.BTNLocker.FlatAppearance.BorderSize = 0
        Me.BTNLocker.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BTNLocker.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTNLocker.ForeColor = System.Drawing.Color.White
        Me.BTNLocker.Image = Global.CAI.My.Resources.Resources.icons8_lock_48
        Me.BTNLocker.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.BTNLocker.Location = New System.Drawing.Point(283, 153)
        Me.BTNLocker.Name = "BTNLocker"
        Me.BTNLocker.Size = New System.Drawing.Size(73, 71)
        Me.BTNLocker.TabIndex = 19
        Me.BTNLocker.Text = "LOCK"
        Me.BTNLocker.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.BTNLocker.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.BTNLocker.UseVisualStyleBackColor = False
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
        Me.Button1.Location = New System.Drawing.Point(603, 151)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(73, 74)
        Me.Button1.TabIndex = 20
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
        Me.Heading1.Size = New System.Drawing.Size(1069, 127)
        Me.Heading1.TabIndex = 21
        Me.Heading1.Title = "LESSONS"
        '
        'LessonList
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Green
        Me.ClientSize = New System.Drawing.Size(1069, 572)
        Me.Controls.Add(Me.Heading1)
        Me.Controls.Add(Me.BTNLocker)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.ListContainer)
        Me.Controls.Add(Me.BTNEdit)
        Me.Controls.Add(Me.BTNCreate)
        Me.Controls.Add(Me.txt_filter)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.BTNTrash)
        Me.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ForeColor = System.Drawing.Color.White
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.MinimizeBox = False
        Me.Name = "LessonList"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "LessonList"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.ListContainer.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txt_filter As System.Windows.Forms.TextBox
    Friend WithEvents BTNCreate As System.Windows.Forms.Button
    Friend WithEvents BTNTrash As System.Windows.Forms.Button
    Friend WithEvents BTNEdit As System.Windows.Forms.Button
    Friend WithEvents id As System.Windows.Forms.ColumnHeader
    Friend WithEvents title As System.Windows.Forms.ColumnHeader
    Friend WithEvents description As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader1 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader2 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader3 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader4 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader5 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader6 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader7 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader8 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader9 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ListContainer As System.Windows.Forms.Panel
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents lesson_prev As System.Windows.Forms.Button
    Friend WithEvents lesson_next As System.Windows.Forms.Button
    Friend WithEvents lesson_page As System.Windows.Forms.Label
    Friend WithEvents lesson_list As System.Windows.Forms.ListView
    Friend WithEvents lessons_id As System.Windows.Forms.ColumnHeader
    Friend WithEvents lessons_title As System.Windows.Forms.ColumnHeader
    Friend WithEvents lessons_description As System.Windows.Forms.ColumnHeader
    Friend WithEvents lessons_created_at As System.Windows.Forms.ColumnHeader
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents lbl_lesson_title As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txt_lesson_description As System.Windows.Forms.RichTextBox
    Friend WithEvents BTNLocker As System.Windows.Forms.Button
    Friend WithEvents AttachmentViewer1 As CAI.AttachmentViewer
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Heading1 As Heading
End Class
