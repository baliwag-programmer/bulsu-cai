<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class QuestionManagement
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
        Me.question_list = New System.Windows.Forms.ListView()
        Me.questions_id = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.questions_question = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.questions_type = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.question_correct = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Label3 = New System.Windows.Forms.Label()
        Me.LineShape2 = New Microsoft.VisualBasic.PowerPacks.LineShape()
        Me.LineShape1 = New Microsoft.VisualBasic.PowerPacks.LineShape()
        Me.ShapeContainer1 = New Microsoft.VisualBasic.PowerPacks.ShapeContainer()
        Me.BTNEdit = New System.Windows.Forms.Button()
        Me.BTNCreate = New System.Windows.Forms.Button()
        Me.txt_filter = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.ListContainer.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'ListContainer
        '
        Me.ListContainer.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ListContainer.Controls.Add(Me.Panel2)
        Me.ListContainer.Controls.Add(Me.question_list)
        Me.ListContainer.Location = New System.Drawing.Point(-1, 156)
        Me.ListContainer.Name = "ListContainer"
        Me.ListContainer.Size = New System.Drawing.Size(547, 340)
        Me.ListContainer.TabIndex = 27
        '
        'Panel2
        '
        Me.Panel2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel2.BackColor = System.Drawing.Color.Gray
        Me.Panel2.Controls.Add(Me.lesson_prev)
        Me.Panel2.Controls.Add(Me.lesson_next)
        Me.Panel2.Controls.Add(Me.lesson_page)
        Me.Panel2.Location = New System.Drawing.Point(0, 308)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(547, 32)
        Me.Panel2.TabIndex = 3
        '
        'lesson_prev
        '
        Me.lesson_prev.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lesson_prev.FlatAppearance.BorderSize = 0
        Me.lesson_prev.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.lesson_prev.Image = Global.CAI.My.Resources.Resources.icons8_prev_48
        Me.lesson_prev.Location = New System.Drawing.Point(472, 0)
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
        Me.lesson_next.Location = New System.Drawing.Point(509, 0)
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
        'question_list
        '
        Me.question_list.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.question_list.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.questions_id, Me.questions_question, Me.questions_type, Me.question_correct})
        Me.question_list.FullRowSelect = True
        Me.question_list.GridLines = True
        Me.question_list.Location = New System.Drawing.Point(0, 0)
        Me.question_list.Name = "question_list"
        Me.question_list.Size = New System.Drawing.Size(547, 310)
        Me.question_list.TabIndex = 2
        Me.question_list.UseCompatibleStateImageBehavior = False
        Me.question_list.View = System.Windows.Forms.View.Details
        '
        'questions_id
        '
        Me.questions_id.Text = "id"
        Me.questions_id.Width = 0
        '
        'questions_question
        '
        Me.questions_question.Text = "QUESTION"
        Me.questions_question.Width = 300
        '
        'questions_type
        '
        Me.questions_type.Text = "TYPE"
        Me.questions_type.Width = 150
        '
        'question_correct
        '
        Me.question_correct.Text = "CORRECT ANSWER"
        Me.question_correct.Width = 144
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Tahoma", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(12, 9)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(179, 33)
        Me.Label3.TabIndex = 28
        Me.Label3.Text = "QUESTIONS"
        '
        'LineShape2
        '
        Me.LineShape2.BorderColor = System.Drawing.Color.White
        Me.LineShape2.Name = "LineShape2"
        Me.LineShape2.X1 = -186
        Me.LineShape2.X2 = 265
        Me.LineShape2.Y1 = 61
        Me.LineShape2.Y2 = 61
        '
        'LineShape1
        '
        Me.LineShape1.BorderColor = System.Drawing.Color.White
        Me.LineShape1.Name = "LineShape1"
        Me.LineShape1.X1 = -104
        Me.LineShape1.X2 = 331
        Me.LineShape1.Y1 = 50
        Me.LineShape1.Y2 = 50
        '
        'ShapeContainer1
        '
        Me.ShapeContainer1.Location = New System.Drawing.Point(0, 0)
        Me.ShapeContainer1.Margin = New System.Windows.Forms.Padding(0)
        Me.ShapeContainer1.Name = "ShapeContainer1"
        Me.ShapeContainer1.Shapes.AddRange(New Microsoft.VisualBasic.PowerPacks.Shape() {Me.LineShape1, Me.LineShape2})
        Me.ShapeContainer1.Size = New System.Drawing.Size(546, 496)
        Me.ShapeContainer1.TabIndex = 29
        Me.ShapeContainer1.TabStop = False
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
        Me.BTNEdit.Location = New System.Drawing.Point(461, 79)
        Me.BTNEdit.Name = "BTNEdit"
        Me.BTNEdit.Size = New System.Drawing.Size(73, 71)
        Me.BTNEdit.TabIndex = 31
        Me.BTNEdit.Text = "EDIT"
        Me.BTNEdit.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.BTNEdit.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.BTNEdit.UseVisualStyleBackColor = False
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
        Me.BTNCreate.Location = New System.Drawing.Point(374, 79)
        Me.BTNCreate.Name = "BTNCreate"
        Me.BTNCreate.Size = New System.Drawing.Size(73, 71)
        Me.BTNCreate.TabIndex = 30
        Me.BTNCreate.Text = "CREATE"
        Me.BTNCreate.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.BTNCreate.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.BTNCreate.UseVisualStyleBackColor = False
        '
        'txt_filter
        '
        Me.txt_filter.Location = New System.Drawing.Point(71, 106)
        Me.txt_filter.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txt_filter.Name = "txt_filter"
        Me.txt_filter.Size = New System.Drawing.Size(195, 21)
        Me.txt_filter.TabIndex = 33
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(9, 110)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(56, 13)
        Me.Label1.TabIndex = 32
        Me.Label1.Text = "Search :"
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
        Me.Button1.Location = New System.Drawing.Point(295, 79)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(73, 74)
        Me.Button1.TabIndex = 34
        Me.Button1.Text = "BACK"
        Me.Button1.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.Button1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.Button1.UseVisualStyleBackColor = False
        '
        'QuestionManagement
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Green
        Me.ClientSize = New System.Drawing.Size(546, 496)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.txt_filter)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.BTNEdit)
        Me.Controls.Add(Me.BTNCreate)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.ListContainer)
        Me.Controls.Add(Me.ShapeContainer1)
        Me.Font = New System.Drawing.Font("Verdana", 8.25!)
        Me.ForeColor = System.Drawing.Color.White
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "QuestionManagement"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "QUESTION MANAGEMENT"
        Me.ListContainer.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ListContainer As System.Windows.Forms.Panel
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents lesson_prev As System.Windows.Forms.Button
    Friend WithEvents lesson_next As System.Windows.Forms.Button
    Friend WithEvents lesson_page As System.Windows.Forms.Label
    Friend WithEvents question_list As System.Windows.Forms.ListView
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents LineShape2 As Microsoft.VisualBasic.PowerPacks.LineShape
    Friend WithEvents LineShape1 As Microsoft.VisualBasic.PowerPacks.LineShape
    Friend WithEvents ShapeContainer1 As Microsoft.VisualBasic.PowerPacks.ShapeContainer
    Friend WithEvents questions_id As System.Windows.Forms.ColumnHeader
    Friend WithEvents questions_question As System.Windows.Forms.ColumnHeader
    Friend WithEvents questions_type As System.Windows.Forms.ColumnHeader
    Friend WithEvents BTNEdit As System.Windows.Forms.Button
    Friend WithEvents BTNCreate As System.Windows.Forms.Button
    Friend WithEvents txt_filter As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents question_correct As System.Windows.Forms.ColumnHeader
    Friend WithEvents Button1 As System.Windows.Forms.Button

End Class
