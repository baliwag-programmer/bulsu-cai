<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class QuestionForm
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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.RADEnumeration = New System.Windows.Forms.RadioButton()
        Me.RADIdentification = New System.Windows.Forms.RadioButton()
        Me.RADMultipleChoice = New System.Windows.Forms.RadioButton()
        Me.LineShape1 = New Microsoft.VisualBasic.PowerPacks.LineShape()
        Me.LineShape2 = New Microsoft.VisualBasic.PowerPacks.LineShape()
        Me.ShapeContainer1 = New Microsoft.VisualBasic.PowerPacks.ShapeContainer()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txt_question = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.BTNCancel = New System.Windows.Forms.Button()
        Me.BTNSave = New System.Windows.Forms.Button()
        Me.BTNAdd = New System.Windows.Forms.Button()
        Me.txt_correct = New System.Windows.Forms.TextBox()
        Me.lbl_choices = New System.Windows.Forms.Label()
        Me.choices_container = New System.Windows.Forms.Panel()
        Me.lbl_note = New System.Windows.Forms.Label()
        Me.Heading1 = New CAI.Heading()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox1.BackColor = System.Drawing.Color.White
        Me.GroupBox1.Controls.Add(Me.RADEnumeration)
        Me.GroupBox1.Controls.Add(Me.RADIdentification)
        Me.GroupBox1.Controls.Add(Me.RADMultipleChoice)
        Me.GroupBox1.ForeColor = System.Drawing.Color.Black
        Me.GroupBox1.Location = New System.Drawing.Point(549, 9)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(150, 102)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "QUESTION TYPE"
        '
        'RADEnumeration
        '
        Me.RADEnumeration.AutoSize = True
        Me.RADEnumeration.Location = New System.Drawing.Point(18, 71)
        Me.RADEnumeration.Name = "RADEnumeration"
        Me.RADEnumeration.Size = New System.Drawing.Size(97, 17)
        Me.RADEnumeration.TabIndex = 2
        Me.RADEnumeration.TabStop = True
        Me.RADEnumeration.Text = "Enumeration"
        Me.RADEnumeration.UseVisualStyleBackColor = True
        Me.RADEnumeration.Visible = False
        '
        'RADIdentification
        '
        Me.RADIdentification.AutoSize = True
        Me.RADIdentification.Location = New System.Drawing.Point(18, 48)
        Me.RADIdentification.Name = "RADIdentification"
        Me.RADIdentification.Size = New System.Drawing.Size(99, 17)
        Me.RADIdentification.TabIndex = 1
        Me.RADIdentification.TabStop = True
        Me.RADIdentification.Text = "Identification"
        Me.RADIdentification.UseVisualStyleBackColor = True
        '
        'RADMultipleChoice
        '
        Me.RADMultipleChoice.AutoSize = True
        Me.RADMultipleChoice.Checked = True
        Me.RADMultipleChoice.Location = New System.Drawing.Point(18, 25)
        Me.RADMultipleChoice.Name = "RADMultipleChoice"
        Me.RADMultipleChoice.Size = New System.Drawing.Size(111, 17)
        Me.RADMultipleChoice.TabIndex = 0
        Me.RADMultipleChoice.TabStop = True
        Me.RADMultipleChoice.Text = "Multiple Choice"
        Me.RADMultipleChoice.UseVisualStyleBackColor = True
        '
        'LineShape1
        '
        Me.LineShape1.BorderColor = System.Drawing.Color.White
        Me.LineShape1.Name = "LineShape1"
        Me.LineShape1.X1 = -151
        Me.LineShape1.X2 = 284
        Me.LineShape1.Y1 = 63
        Me.LineShape1.Y2 = 63
        '
        'LineShape2
        '
        Me.LineShape2.BorderColor = System.Drawing.Color.White
        Me.LineShape2.Name = "LineShape2"
        Me.LineShape2.X1 = -233
        Me.LineShape2.X2 = 218
        Me.LineShape2.Y1 = 74
        Me.LineShape2.Y2 = 74
        '
        'ShapeContainer1
        '
        Me.ShapeContainer1.Location = New System.Drawing.Point(0, 127)
        Me.ShapeContainer1.Margin = New System.Windows.Forms.Padding(0)
        Me.ShapeContainer1.Name = "ShapeContainer1"
        Me.ShapeContainer1.Shapes.AddRange(New Microsoft.VisualBasic.PowerPacks.Shape() {Me.LineShape2, Me.LineShape1})
        Me.ShapeContainer1.Size = New System.Drawing.Size(711, 397)
        Me.ShapeContainer1.TabIndex = 30
        Me.ShapeContainer1.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(15, 152)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(66, 13)
        Me.Label1.TabIndex = 32
        Me.Label1.Text = "Question :"
        '
        'txt_question
        '
        Me.txt_question.Font = New System.Drawing.Font("Tahoma", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_question.Location = New System.Drawing.Point(13, 174)
        Me.txt_question.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txt_question.Name = "txt_question"
        Me.txt_question.Size = New System.Drawing.Size(686, 30)
        Me.txt_question.TabIndex = 31
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 214)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(58, 13)
        Me.Label2.TabIndex = 33
        Me.Label2.Text = "Answer :"
        '
        'BTNCancel
        '
        Me.BTNCancel.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BTNCancel.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.BTNCancel.FlatAppearance.BorderColor = System.Drawing.Color.Green
        Me.BTNCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BTNCancel.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.BTNCancel.Location = New System.Drawing.Point(588, 478)
        Me.BTNCancel.Name = "BTNCancel"
        Me.BTNCancel.Size = New System.Drawing.Size(113, 34)
        Me.BTNCancel.TabIndex = 36
        Me.BTNCancel.Text = "CANCEL"
        Me.BTNCancel.UseVisualStyleBackColor = False
        '
        'BTNSave
        '
        Me.BTNSave.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BTNSave.BackColor = System.Drawing.Color.YellowGreen
        Me.BTNSave.FlatAppearance.BorderColor = System.Drawing.Color.Green
        Me.BTNSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BTNSave.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.BTNSave.Location = New System.Drawing.Point(469, 478)
        Me.BTNSave.Name = "BTNSave"
        Me.BTNSave.Size = New System.Drawing.Size(113, 34)
        Me.BTNSave.TabIndex = 35
        Me.BTNSave.Text = "SAVE"
        Me.BTNSave.UseVisualStyleBackColor = False
        '
        'BTNAdd
        '
        Me.BTNAdd.BackColor = System.Drawing.Color.Transparent
        Me.BTNAdd.FlatAppearance.BorderSize = 0
        Me.BTNAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BTNAdd.Image = Global.CAI.My.Resources.Resources.add
        Me.BTNAdd.Location = New System.Drawing.Point(648, 271)
        Me.BTNAdd.Name = "BTNAdd"
        Me.BTNAdd.Size = New System.Drawing.Size(48, 48)
        Me.BTNAdd.TabIndex = 39
        Me.BTNAdd.UseVisualStyleBackColor = False
        '
        'txt_correct
        '
        Me.txt_correct.Font = New System.Drawing.Font("Tahoma", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_correct.Location = New System.Drawing.Point(12, 236)
        Me.txt_correct.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txt_correct.Name = "txt_correct"
        Me.txt_correct.Size = New System.Drawing.Size(684, 30)
        Me.txt_correct.TabIndex = 41
        '
        'lbl_choices
        '
        Me.lbl_choices.AutoSize = True
        Me.lbl_choices.Location = New System.Drawing.Point(9, 306)
        Me.lbl_choices.Name = "lbl_choices"
        Me.lbl_choices.Size = New System.Drawing.Size(61, 13)
        Me.lbl_choices.TabIndex = 42
        Me.lbl_choices.Text = "Choices :"
        '
        'choices_container
        '
        Me.choices_container.AutoScroll = True
        Me.choices_container.BackColor = System.Drawing.Color.DimGray
        Me.choices_container.Location = New System.Drawing.Point(0, 322)
        Me.choices_container.Name = "choices_container"
        Me.choices_container.Size = New System.Drawing.Size(711, 141)
        Me.choices_container.TabIndex = 46
        '
        'lbl_note
        '
        Me.lbl_note.AutoSize = True
        Me.lbl_note.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_note.Location = New System.Drawing.Point(3, 466)
        Me.lbl_note.Name = "lbl_note"
        Me.lbl_note.Size = New System.Drawing.Size(279, 39)
        Me.lbl_note.TabIndex = 47
        Me.lbl_note.Text = "Note: You dont have to add the correct answer " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "here due to its automatically pro" &
    "cessed and " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "included within the choices."
        '
        'Heading1
        '
        Me.Heading1.BackColor = System.Drawing.Color.White
        Me.Heading1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Heading1.Font = New System.Drawing.Font("Verdana", 8.25!)
        Me.Heading1.Location = New System.Drawing.Point(0, 0)
        Me.Heading1.Name = "Heading1"
        Me.Heading1.Size = New System.Drawing.Size(711, 127)
        Me.Heading1.TabIndex = 48
        Me.Heading1.Title = ""
        '
        'QuestionForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Green
        Me.ClientSize = New System.Drawing.Size(711, 524)
        Me.Controls.Add(Me.lbl_note)
        Me.Controls.Add(Me.lbl_choices)
        Me.Controls.Add(Me.txt_correct)
        Me.Controls.Add(Me.BTNAdd)
        Me.Controls.Add(Me.BTNCancel)
        Me.Controls.Add(Me.BTNSave)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txt_question)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.choices_container)
        Me.Controls.Add(Me.ShapeContainer1)
        Me.Controls.Add(Me.Heading1)
        Me.Font = New System.Drawing.Font("Verdana", 8.25!)
        Me.ForeColor = System.Drawing.Color.White
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "QuestionForm"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "QUESTION FORM"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents RADEnumeration As System.Windows.Forms.RadioButton
    Friend WithEvents RADIdentification As System.Windows.Forms.RadioButton
    Friend WithEvents RADMultipleChoice As System.Windows.Forms.RadioButton
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txt_question As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents BTNCancel As System.Windows.Forms.Button
    Friend WithEvents BTNSave As System.Windows.Forms.Button
    Friend WithEvents BTNAdd As System.Windows.Forms.Button
    Friend WithEvents txt_correct As System.Windows.Forms.TextBox
    Friend WithEvents lbl_choices As System.Windows.Forms.Label
    Friend WithEvents choices_container As System.Windows.Forms.Panel
    Friend WithEvents lbl_note As System.Windows.Forms.Label
    Private WithEvents LineShape1 As PowerPacks.LineShape
    Private WithEvents LineShape2 As PowerPacks.LineShape
    Private WithEvents ShapeContainer1 As PowerPacks.ShapeContainer
    Friend WithEvents Heading1 As Heading
End Class
