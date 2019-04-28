<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class TestForm
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
        Me.TxtDescription = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TxtTitle = New System.Windows.Forms.TextBox()
        Me.LineShape1 = New Microsoft.VisualBasic.PowerPacks.LineShape()
        Me.LineShape2 = New Microsoft.VisualBasic.PowerPacks.LineShape()
        Me.ShapeContainer1 = New Microsoft.VisualBasic.PowerPacks.ShapeContainer()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.ComboType = New System.Windows.Forms.ComboBox()
        Me.BTNCancel = New System.Windows.Forms.Button()
        Me.BTNSave = New System.Windows.Forms.Button()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.combo_hour = New System.Windows.Forms.ComboBox()
        Me.combo_minutes = New System.Windows.Forms.ComboBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.CHKLocked = New System.Windows.Forms.CheckBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.CMBQuestionType = New System.Windows.Forms.ComboBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.TXTTotal = New System.Windows.Forms.TextBox()
        Me.TXTInstruction = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Heading1 = New CAI.Heading()
        Me.SuspendLayout()
        '
        'TxtDescription
        '
        Me.TxtDescription.Font = New System.Drawing.Font("Tahoma", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtDescription.Location = New System.Drawing.Point(12, 273)
        Me.TxtDescription.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.TxtDescription.Multiline = True
        Me.TxtDescription.Name = "TxtDescription"
        Me.TxtDescription.Size = New System.Drawing.Size(625, 143)
        Me.TxtDescription.TabIndex = 13
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 253)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(80, 13)
        Me.Label2.TabIndex = 12
        Me.Label2.Text = "Description :"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 201)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(40, 13)
        Me.Label1.TabIndex = 11
        Me.Label1.Text = "Title :"
        '
        'TxtTitle
        '
        Me.TxtTitle.Font = New System.Drawing.Font("Tahoma", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtTitle.Location = New System.Drawing.Point(12, 220)
        Me.TxtTitle.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.TxtTitle.Name = "TxtTitle"
        Me.TxtTitle.Size = New System.Drawing.Size(625, 30)
        Me.TxtTitle.TabIndex = 10
        '
        'LineShape1
        '
        Me.LineShape1.BorderColor = System.Drawing.Color.White
        Me.LineShape1.Name = "LineShape1"
        Me.LineShape1.X1 = -126
        Me.LineShape1.X2 = 309
        Me.LineShape1.Y1 = 44
        Me.LineShape1.Y2 = 44
        '
        'LineShape2
        '
        Me.LineShape2.BorderColor = System.Drawing.Color.White
        Me.LineShape2.Name = "LineShape2"
        Me.LineShape2.X1 = -208
        Me.LineShape2.X2 = 243
        Me.LineShape2.Y1 = 55
        Me.LineShape2.Y2 = 55
        '
        'ShapeContainer1
        '
        Me.ShapeContainer1.Location = New System.Drawing.Point(0, 0)
        Me.ShapeContainer1.Margin = New System.Windows.Forms.Padding(0)
        Me.ShapeContainer1.Name = "ShapeContainer1"
        Me.ShapeContainer1.Shapes.AddRange(New Microsoft.VisualBasic.PowerPacks.Shape() {Me.LineShape2, Me.LineShape1})
        Me.ShapeContainer1.Size = New System.Drawing.Size(649, 618)
        Me.ShapeContainer1.TabIndex = 18
        Me.ShapeContainer1.TabStop = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(9, 146)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(44, 13)
        Me.Label4.TabIndex = 19
        Me.Label4.Text = "Type :"
        '
        'ComboType
        '
        Me.ComboType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboType.Font = New System.Drawing.Font("Tahoma", 14.25!)
        Me.ComboType.FormattingEnabled = True
        Me.ComboType.Items.AddRange(New Object() {"PRE-TEST", "POST-TEST", "QUIZ", "ACTIVITY"})
        Me.ComboType.Location = New System.Drawing.Point(12, 162)
        Me.ComboType.Name = "ComboType"
        Me.ComboType.Size = New System.Drawing.Size(382, 31)
        Me.ComboType.TabIndex = 20
        '
        'BTNCancel
        '
        Me.BTNCancel.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.BTNCancel.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.BTNCancel.FlatAppearance.BorderColor = System.Drawing.Color.Green
        Me.BTNCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BTNCancel.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.BTNCancel.Location = New System.Drawing.Point(524, 574)
        Me.BTNCancel.Name = "BTNCancel"
        Me.BTNCancel.Size = New System.Drawing.Size(113, 34)
        Me.BTNCancel.TabIndex = 22
        Me.BTNCancel.Text = "CANCEL"
        Me.BTNCancel.UseVisualStyleBackColor = False
        '
        'BTNSave
        '
        Me.BTNSave.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.BTNSave.BackColor = System.Drawing.Color.YellowGreen
        Me.BTNSave.FlatAppearance.BorderColor = System.Drawing.Color.Green
        Me.BTNSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BTNSave.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.BTNSave.Location = New System.Drawing.Point(405, 574)
        Me.BTNSave.Name = "BTNSave"
        Me.BTNSave.Size = New System.Drawing.Size(113, 34)
        Me.BTNSave.TabIndex = 21
        Me.BTNSave.Text = "SAVE"
        Me.BTNSave.UseVisualStyleBackColor = False
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(493, 146)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(65, 13)
        Me.Label5.TabIndex = 23
        Me.Label5.Text = "Duration :"
        '
        'combo_hour
        '
        Me.combo_hour.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.combo_hour.Font = New System.Drawing.Font("Tahoma", 14.25!)
        Me.combo_hour.FormattingEnabled = True
        Me.combo_hour.Items.AddRange(New Object() {"00", "01", "02", "03", "04", "05", "06", "07", "08", "09", "10", "12", "13", "14", "15", "16", "17", "18", "19", "20", "21", "22", "23", "24"})
        Me.combo_hour.Location = New System.Drawing.Point(496, 162)
        Me.combo_hour.Name = "combo_hour"
        Me.combo_hour.Size = New System.Drawing.Size(62, 31)
        Me.combo_hour.TabIndex = 24
        '
        'combo_minutes
        '
        Me.combo_minutes.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.combo_minutes.Font = New System.Drawing.Font("Tahoma", 14.25!)
        Me.combo_minutes.FormattingEnabled = True
        Me.combo_minutes.Items.AddRange(New Object() {"01", "02", "03", "04", "05", "06", "07", "08", "09", "10", "11", "12", "13", "14", "15", "16", "17", "18", "19", "20", "21", "22", "23", "24", "25", "26", "27", "28", "29", "30", "31", "32", "33", "34", "35", "36", "37", "38", "39", "40", "41", "42", "43", "44", "45", "46", "47", "48", "49", "50", "51", "52", "53", "54", "55", "56", "57", "58", "59"})
        Me.combo_minutes.Location = New System.Drawing.Point(575, 162)
        Me.combo_minutes.Name = "combo_minutes"
        Me.combo_minutes.Size = New System.Drawing.Size(62, 31)
        Me.combo_minutes.TabIndex = 25
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Verdana", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(554, 159)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(26, 32)
        Me.Label6.TabIndex = 26
        Me.Label6.Text = ":"
        '
        'CHKLocked
        '
        Me.CHKLocked.AutoSize = True
        Me.CHKLocked.Checked = True
        Me.CHKLocked.CheckState = System.Windows.Forms.CheckState.Checked
        Me.CHKLocked.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CHKLocked.Location = New System.Drawing.Point(12, 548)
        Me.CHKLocked.Name = "CHKLocked"
        Me.CHKLocked.Size = New System.Drawing.Size(84, 20)
        Me.CHKLocked.TabIndex = 27
        Me.CHKLocked.Text = "LOCKED"
        Me.CHKLocked.UseVisualStyleBackColor = True
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(510, 196)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(34, 13)
        Me.Label7.TabIndex = 28
        Me.Label7.Text = "Hour"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(584, 196)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(44, 13)
        Me.Label8.TabIndex = 29
        Me.Label8.Text = "Minute"
        '
        'Button1
        '
        Me.Button1.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.Button1.BackColor = System.Drawing.Color.YellowGreen
        Me.Button1.FlatAppearance.BorderColor = System.Drawing.Color.Green
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.Button1.Location = New System.Drawing.Point(12, 574)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(161, 34)
        Me.Button1.TabIndex = 30
        Me.Button1.Text = "MANAGE QUESTIONS"
        Me.Button1.UseVisualStyleBackColor = False
        Me.Button1.Visible = False
        '
        'CMBQuestionType
        '
        Me.CMBQuestionType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CMBQuestionType.Font = New System.Drawing.Font("Tahoma", 14.25!)
        Me.CMBQuestionType.FormattingEnabled = True
        Me.CMBQuestionType.Items.AddRange(New Object() {"MULTIPLE-CHOICE", "IDENTIFICATION"})
        Me.CMBQuestionType.Location = New System.Drawing.Point(12, 457)
        Me.CMBQuestionType.Name = "CMBQuestionType"
        Me.CMBQuestionType.Size = New System.Drawing.Size(382, 31)
        Me.CMBQuestionType.TabIndex = 32
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(9, 441)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(104, 13)
        Me.Label9.TabIndex = 31
        Me.Label9.Text = "Question Types :"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(436, 441)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(132, 13)
        Me.Label10.TabIndex = 33
        Me.Label10.Text = "Number Of Question :"
        '
        'TXTTotal
        '
        Me.TXTTotal.Font = New System.Drawing.Font("Tahoma", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TXTTotal.Location = New System.Drawing.Point(439, 457)
        Me.TXTTotal.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.TXTTotal.Name = "TXTTotal"
        Me.TXTTotal.Size = New System.Drawing.Size(198, 30)
        Me.TXTTotal.TabIndex = 34
        Me.TXTTotal.Text = "10"
        '
        'TXTInstruction
        '
        Me.TXTInstruction.Font = New System.Drawing.Font("Tahoma", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TXTInstruction.Location = New System.Drawing.Point(12, 507)
        Me.TXTInstruction.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.TXTInstruction.Name = "TXTInstruction"
        Me.TXTInstruction.Size = New System.Drawing.Size(625, 30)
        Me.TXTInstruction.TabIndex = 36
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(9, 491)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(77, 13)
        Me.Label11.TabIndex = 35
        Me.Label11.Text = "Instruction :"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(9, 418)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(463, 13)
        Me.Label12.TabIndex = 37
        Me.Label12.Text = "Note : Automatically added 5 more question for the randomization of questions."
        '
        'Heading1
        '
        Me.Heading1.BackColor = System.Drawing.Color.White
        Me.Heading1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Heading1.Font = New System.Drawing.Font("Verdana", 8.25!)
        Me.Heading1.Location = New System.Drawing.Point(0, 0)
        Me.Heading1.Name = "Heading1"
        Me.Heading1.Size = New System.Drawing.Size(649, 133)
        Me.Heading1.TabIndex = 38
        Me.Heading1.Title = "TEST FORM"
        '
        'TestForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Green
        Me.ClientSize = New System.Drawing.Size(649, 618)
        Me.Controls.Add(Me.Heading1)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.TXTInstruction)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.TXTTotal)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.CMBQuestionType)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.CHKLocked)
        Me.Controls.Add(Me.combo_minutes)
        Me.Controls.Add(Me.combo_hour)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.BTNCancel)
        Me.Controls.Add(Me.BTNSave)
        Me.Controls.Add(Me.ComboType)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.TxtDescription)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TxtTitle)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.ShapeContainer1)
        Me.Font = New System.Drawing.Font("Verdana", 8.25!)
        Me.ForeColor = System.Drawing.Color.White
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "TestForm"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "TEST FORM"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Protected WithEvents TxtDescription As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents TxtTitle As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents ComboType As System.Windows.Forms.ComboBox
    Friend WithEvents BTNCancel As System.Windows.Forms.Button
    Friend WithEvents BTNSave As System.Windows.Forms.Button
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents combo_hour As System.Windows.Forms.ComboBox
    Friend WithEvents combo_minutes As System.Windows.Forms.ComboBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents CHKLocked As System.Windows.Forms.CheckBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents CMBQuestionType As System.Windows.Forms.ComboBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents TXTTotal As System.Windows.Forms.TextBox
    Friend WithEvents TXTInstruction As System.Windows.Forms.TextBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Private WithEvents LineShape1 As PowerPacks.LineShape
    Private WithEvents LineShape2 As PowerPacks.LineShape
    Private WithEvents ShapeContainer1 As PowerPacks.ShapeContainer
    Friend WithEvents Heading1 As Heading
End Class
