<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class StudentLessonViewer
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
        Me.txt_lesson_description = New System.Windows.Forms.RichTextBox()
        Me.lbl_lesson_title = New System.Windows.Forms.Label()
        Me.lock_container = New System.Windows.Forms.Panel()
        Me.lbl_indicator = New System.Windows.Forms.Label()
        Me.img_lock_indication = New System.Windows.Forms.PictureBox()
        Me.AttachmentViewer1 = New CAI.AttachmentViewer()
        Me.ListContainer.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.lock_container.SuspendLayout()
        CType(Me.img_lock_indication, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ListContainer
        '
        Me.ListContainer.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ListContainer.Controls.Add(Me.Panel2)
        Me.ListContainer.Controls.Add(Me.lesson_list)
        Me.ListContainer.Location = New System.Drawing.Point(538, -1)
        Me.ListContainer.Name = "ListContainer"
        Me.ListContainer.Size = New System.Drawing.Size(310, 480)
        Me.ListContainer.TabIndex = 18
        '
        'Panel2
        '
        Me.Panel2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel2.BackColor = System.Drawing.Color.Gray
        Me.Panel2.Controls.Add(Me.lesson_prev)
        Me.Panel2.Controls.Add(Me.lesson_next)
        Me.Panel2.Controls.Add(Me.lesson_page)
        Me.Panel2.Location = New System.Drawing.Point(0, 448)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(310, 32)
        Me.Panel2.TabIndex = 3
        '
        'lesson_prev
        '
        Me.lesson_prev.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lesson_prev.FlatAppearance.BorderSize = 0
        Me.lesson_prev.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.lesson_prev.Image = Global.CAI.My.Resources.Resources.icons8_prev_48
        Me.lesson_prev.Location = New System.Drawing.Point(235, 0)
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
        Me.lesson_next.Location = New System.Drawing.Point(272, 0)
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
        Me.lesson_page.Size = New System.Drawing.Size(86, 13)
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
        Me.lesson_list.Size = New System.Drawing.Size(310, 450)
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
        'txt_lesson_description
        '
        Me.txt_lesson_description.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txt_lesson_description.BackColor = System.Drawing.Color.White
        Me.txt_lesson_description.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txt_lesson_description.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_lesson_description.ForeColor = System.Drawing.Color.Black
        Me.txt_lesson_description.Location = New System.Drawing.Point(0, 341)
        Me.txt_lesson_description.Name = "txt_lesson_description"
        Me.txt_lesson_description.ReadOnly = True
        Me.txt_lesson_description.Size = New System.Drawing.Size(539, 138)
        Me.txt_lesson_description.TabIndex = 23
        Me.txt_lesson_description.Text = ""
        '
        'lbl_lesson_title
        '
        Me.lbl_lesson_title.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lbl_lesson_title.BackColor = System.Drawing.Color.Transparent
        Me.lbl_lesson_title.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_lesson_title.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.lbl_lesson_title.Location = New System.Drawing.Point(0, 285)
        Me.lbl_lesson_title.Name = "lbl_lesson_title"
        Me.lbl_lesson_title.Size = New System.Drawing.Size(539, 54)
        Me.lbl_lesson_title.TabIndex = 20
        Me.lbl_lesson_title.Text = "LESSON TITLE"
        Me.lbl_lesson_title.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lock_container
        '
        Me.lock_container.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lock_container.BackColor = System.Drawing.Color.Transparent
        Me.lock_container.Controls.Add(Me.lbl_indicator)
        Me.lock_container.Controls.Add(Me.img_lock_indication)
        Me.lock_container.Location = New System.Drawing.Point(0, -1)
        Me.lock_container.Name = "lock_container"
        Me.lock_container.Size = New System.Drawing.Size(539, 480)
        Me.lock_container.TabIndex = 2
        '
        'lbl_indicator
        '
        Me.lbl_indicator.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lbl_indicator.Font = New System.Drawing.Font("Verdana", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_indicator.Location = New System.Drawing.Point(-1, 0)
        Me.lbl_indicator.Name = "lbl_indicator"
        Me.lbl_indicator.Size = New System.Drawing.Size(540, 163)
        Me.lbl_indicator.TabIndex = 1
        Me.lbl_indicator.Text = "LESSON CURRENTLY LOCKED"
        Me.lbl_indicator.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'img_lock_indication
        '
        Me.img_lock_indication.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.img_lock_indication.Image = Global.CAI.My.Resources.Resources.icons8_lock_96
        Me.img_lock_indication.Location = New System.Drawing.Point(208, 180)
        Me.img_lock_indication.Name = "img_lock_indication"
        Me.img_lock_indication.Size = New System.Drawing.Size(123, 121)
        Me.img_lock_indication.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.img_lock_indication.TabIndex = 0
        Me.img_lock_indication.TabStop = False
        '
        'AttachmentViewer1
        '
        Me.AttachmentViewer1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.AttachmentViewer1.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.AttachmentViewer1.Font = New System.Drawing.Font("Verdana", 8.25!)
        Me.AttachmentViewer1.Location = New System.Drawing.Point(0, 0)
        Me.AttachmentViewer1.Name = "AttachmentViewer1"
        Me.AttachmentViewer1.SelectedFile = ""
        Me.AttachmentViewer1.Size = New System.Drawing.Size(539, 286)
        Me.AttachmentViewer1.TabIndex = 24
        '
        'StudentLessonViewer
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Green
        Me.ClientSize = New System.Drawing.Size(848, 479)
        Me.Controls.Add(Me.lock_container)
        Me.Controls.Add(Me.AttachmentViewer1)
        Me.Controls.Add(Me.lbl_lesson_title)
        Me.Controls.Add(Me.ListContainer)
        Me.Controls.Add(Me.txt_lesson_description)
        Me.Font = New System.Drawing.Font("Verdana", 8.25!)
        Me.ForeColor = System.Drawing.Color.White
        Me.Name = "StudentLessonViewer"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "STUDENT LESSON VIEWER"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.ListContainer.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.lock_container.ResumeLayout(False)
        CType(Me.img_lock_indication, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
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
    Friend WithEvents txt_lesson_description As System.Windows.Forms.RichTextBox
    Friend WithEvents lbl_lesson_title As System.Windows.Forms.Label
    Friend WithEvents lock_container As System.Windows.Forms.Panel
    Friend WithEvents img_lock_indication As System.Windows.Forms.PictureBox
    Friend WithEvents lbl_indicator As System.Windows.Forms.Label
    Friend WithEvents AttachmentViewer1 As CAI.AttachmentViewer
End Class
