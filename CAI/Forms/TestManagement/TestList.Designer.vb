<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class TestList
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
        Dim ColumnHeader1 As System.Windows.Forms.ColumnHeader
        Me.BTNEdit = New System.Windows.Forms.Button()
        Me.BTNTrash = New System.Windows.Forms.Button()
        Me.BTNCreate = New System.Windows.Forms.Button()
        Me.txt_filter = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ListContainer = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.lesson_prev = New System.Windows.Forms.Button()
        Me.lesson_next = New System.Windows.Forms.Button()
        Me.lesson_page = New System.Windows.Forms.Label()
        Me.test_list = New System.Windows.Forms.ListView()
        Me.lessons_id = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.lessons_title = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.lessons_description = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.lessons_type = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader2 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader3 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.lessons_created_at = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.BTNLocker = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.ComboType = New System.Windows.Forms.ComboBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.BTNStudentResults = New System.Windows.Forms.Button()
        Me.Heading1 = New CAI.Heading()
        ColumnHeader1 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ListContainer.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'ColumnHeader1
        '
        ColumnHeader1.Text = "STATUS"
        ColumnHeader1.Width = 116
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
        Me.BTNEdit.Location = New System.Drawing.Point(747, 141)
        Me.BTNEdit.Name = "BTNEdit"
        Me.BTNEdit.Size = New System.Drawing.Size(73, 71)
        Me.BTNEdit.TabIndex = 19
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
        Me.BTNTrash.Location = New System.Drawing.Point(828, 141)
        Me.BTNTrash.Name = "BTNTrash"
        Me.BTNTrash.Size = New System.Drawing.Size(73, 71)
        Me.BTNTrash.TabIndex = 18
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
        Me.BTNCreate.Location = New System.Drawing.Point(666, 141)
        Me.BTNCreate.Name = "BTNCreate"
        Me.BTNCreate.Size = New System.Drawing.Size(73, 71)
        Me.BTNCreate.TabIndex = 17
        Me.BTNCreate.Text = "CREATE"
        Me.BTNCreate.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.BTNCreate.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.BTNCreate.UseVisualStyleBackColor = False
        '
        'txt_filter
        '
        Me.txt_filter.Font = New System.Drawing.Font("Tahoma", 14.25!)
        Me.txt_filter.Location = New System.Drawing.Point(69, 161)
        Me.txt_filter.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txt_filter.Name = "txt_filter"
        Me.txt_filter.Size = New System.Drawing.Size(172, 30)
        Me.txt_filter.TabIndex = 15
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(7, 170)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(56, 13)
        Me.Label1.TabIndex = 14
        Me.Label1.Text = "Search :"
        '
        'ListContainer
        '
        Me.ListContainer.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ListContainer.Controls.Add(Me.Panel2)
        Me.ListContainer.Controls.Add(Me.test_list)
        Me.ListContainer.Location = New System.Drawing.Point(0, 223)
        Me.ListContainer.Name = "ListContainer"
        Me.ListContainer.Size = New System.Drawing.Size(994, 349)
        Me.ListContainer.TabIndex = 26
        '
        'Panel2
        '
        Me.Panel2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel2.BackColor = System.Drawing.Color.Gray
        Me.Panel2.Controls.Add(Me.lesson_prev)
        Me.Panel2.Controls.Add(Me.lesson_next)
        Me.Panel2.Controls.Add(Me.lesson_page)
        Me.Panel2.Location = New System.Drawing.Point(0, 317)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(994, 32)
        Me.Panel2.TabIndex = 3
        '
        'lesson_prev
        '
        Me.lesson_prev.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lesson_prev.FlatAppearance.BorderSize = 0
        Me.lesson_prev.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.lesson_prev.Image = Global.CAI.My.Resources.Resources.icons8_prev_48
        Me.lesson_prev.Location = New System.Drawing.Point(919, 0)
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
        Me.lesson_next.Location = New System.Drawing.Point(956, 0)
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
        'test_list
        '
        Me.test_list.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.test_list.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.lessons_id, Me.lessons_title, Me.lessons_description, Me.lessons_type, ColumnHeader1, Me.ColumnHeader2, Me.ColumnHeader3, Me.lessons_created_at})
        Me.test_list.FullRowSelect = True
        Me.test_list.GridLines = True
        Me.test_list.Location = New System.Drawing.Point(0, 0)
        Me.test_list.Name = "test_list"
        Me.test_list.Size = New System.Drawing.Size(994, 319)
        Me.test_list.TabIndex = 2
        Me.test_list.UseCompatibleStateImageBehavior = False
        Me.test_list.View = System.Windows.Forms.View.Details
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
        'lessons_type
        '
        Me.lessons_type.Text = "TYPE"
        Me.lessons_type.Width = 201
        '
        'ColumnHeader2
        '
        Me.ColumnHeader2.Text = "Duration"
        Me.ColumnHeader2.Width = 72
        '
        'ColumnHeader3
        '
        Me.ColumnHeader3.Text = "ITEMS"
        Me.ColumnHeader3.Width = 96
        '
        'lessons_created_at
        '
        Me.lessons_created_at.Text = "CREATED AT"
        Me.lessons_created_at.Width = 150
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
        Me.BTNLocker.Image = Global.CAI.My.Resources.Resources.icons8_padlock_48
        Me.BTNLocker.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.BTNLocker.Location = New System.Drawing.Point(585, 141)
        Me.BTNLocker.Name = "BTNLocker"
        Me.BTNLocker.Size = New System.Drawing.Size(73, 71)
        Me.BTNLocker.TabIndex = 27
        Me.BTNLocker.Text = "UN-LOCK"
        Me.BTNLocker.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.BTNLocker.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.BTNLocker.UseVisualStyleBackColor = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(259, 170)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(44, 13)
        Me.Label3.TabIndex = 28
        Me.Label3.Text = "Type :"
        '
        'ComboType
        '
        Me.ComboType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboType.Font = New System.Drawing.Font("Tahoma", 14.25!)
        Me.ComboType.FormattingEnabled = True
        Me.ComboType.Items.AddRange(New Object() {"PRE-TEST", "POST-TEST", "QUIZ", "ACTIVITY"})
        Me.ComboType.Location = New System.Drawing.Point(309, 161)
        Me.ComboType.Name = "ComboType"
        Me.ComboType.Size = New System.Drawing.Size(172, 31)
        Me.ComboType.TabIndex = 29
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
        Me.Button1.Location = New System.Drawing.Point(909, 139)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(73, 74)
        Me.Button1.TabIndex = 30
        Me.Button1.Text = "BACK"
        Me.Button1.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.Button1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.Button1.UseVisualStyleBackColor = False
        '
        'BTNStudentResults
        '
        Me.BTNStudentResults.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BTNStudentResults.BackColor = System.Drawing.Color.Transparent
        Me.BTNStudentResults.Enabled = False
        Me.BTNStudentResults.FlatAppearance.BorderSize = 0
        Me.BTNStudentResults.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BTNStudentResults.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTNStudentResults.ForeColor = System.Drawing.Color.White
        Me.BTNStudentResults.Image = Global.CAI.My.Resources.Resources.icons8_test_passed_48
        Me.BTNStudentResults.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.BTNStudentResults.Location = New System.Drawing.Point(504, 139)
        Me.BTNStudentResults.Name = "BTNStudentResults"
        Me.BTNStudentResults.Size = New System.Drawing.Size(73, 74)
        Me.BTNStudentResults.TabIndex = 31
        Me.BTNStudentResults.Text = "RESULTS"
        Me.BTNStudentResults.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.BTNStudentResults.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.BTNStudentResults.UseVisualStyleBackColor = False
        '
        'Heading1
        '
        Me.Heading1.BackColor = System.Drawing.Color.White
        Me.Heading1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Heading1.Font = New System.Drawing.Font("Verdana", 8.25!)
        Me.Heading1.Location = New System.Drawing.Point(0, 0)
        Me.Heading1.Name = "Heading1"
        Me.Heading1.Size = New System.Drawing.Size(994, 127)
        Me.Heading1.TabIndex = 32
        Me.Heading1.Title = "TEST MANAGEMENT"
        '
        'TestList
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Green
        Me.ClientSize = New System.Drawing.Size(994, 572)
        Me.Controls.Add(Me.Heading1)
        Me.Controls.Add(Me.BTNStudentResults)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.ComboType)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.BTNLocker)
        Me.Controls.Add(Me.ListContainer)
        Me.Controls.Add(Me.BTNEdit)
        Me.Controls.Add(Me.BTNTrash)
        Me.Controls.Add(Me.BTNCreate)
        Me.Controls.Add(Me.txt_filter)
        Me.Controls.Add(Me.Label1)
        Me.Font = New System.Drawing.Font("Verdana", 8.25!)
        Me.ForeColor = System.Drawing.Color.White
        Me.Name = "TestList"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "TestList"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.ListContainer.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents BTNEdit As System.Windows.Forms.Button
    Friend WithEvents BTNTrash As System.Windows.Forms.Button
    Friend WithEvents BTNCreate As System.Windows.Forms.Button
    Friend WithEvents txt_filter As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents ListContainer As System.Windows.Forms.Panel
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents lesson_prev As System.Windows.Forms.Button
    Friend WithEvents lesson_next As System.Windows.Forms.Button
    Friend WithEvents lesson_page As System.Windows.Forms.Label
    Friend WithEvents test_list As System.Windows.Forms.ListView
    Friend WithEvents lessons_id As System.Windows.Forms.ColumnHeader
    Friend WithEvents lessons_title As System.Windows.Forms.ColumnHeader
    Friend WithEvents lessons_description As System.Windows.Forms.ColumnHeader
    Friend WithEvents lessons_created_at As System.Windows.Forms.ColumnHeader
    Friend WithEvents BTNLocker As System.Windows.Forms.Button
    Friend WithEvents lessons_type As System.Windows.Forms.ColumnHeader
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents ComboType As System.Windows.Forms.ComboBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents ColumnHeader2 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader3 As System.Windows.Forms.ColumnHeader
    Friend WithEvents BTNStudentResults As System.Windows.Forms.Button
    Friend WithEvents Heading1 As Heading
End Class
