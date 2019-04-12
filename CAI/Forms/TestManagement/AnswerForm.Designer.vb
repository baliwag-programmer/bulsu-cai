<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AnswerForm
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.is_correct = New System.Windows.Forms.CheckBox()
        Me.txt_answer = New System.Windows.Forms.TextBox()
        Me.BTNCancel = New System.Windows.Forms.Button()
        Me.BTNSave = New System.Windows.Forms.Button()
        Me.Heading1 = New CAI.Heading()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 155)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(58, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Answer :"
        '
        'is_correct
        '
        Me.is_correct.AutoSize = True
        Me.is_correct.Location = New System.Drawing.Point(15, 230)
        Me.is_correct.Name = "is_correct"
        Me.is_correct.Size = New System.Drawing.Size(192, 17)
        Me.is_correct.TabIndex = 31
        Me.is_correct.Text = "Mark This As Correct Answer"
        Me.is_correct.UseVisualStyleBackColor = True
        '
        'txt_answer
        '
        Me.txt_answer.Font = New System.Drawing.Font("Tahoma", 14.25!)
        Me.txt_answer.Location = New System.Drawing.Point(15, 181)
        Me.txt_answer.Name = "txt_answer"
        Me.txt_answer.Size = New System.Drawing.Size(504, 30)
        Me.txt_answer.TabIndex = 32
        '
        'BTNCancel
        '
        Me.BTNCancel.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.BTNCancel.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.BTNCancel.FlatAppearance.BorderColor = System.Drawing.Color.Green
        Me.BTNCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BTNCancel.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.BTNCancel.Location = New System.Drawing.Point(406, 275)
        Me.BTNCancel.Name = "BTNCancel"
        Me.BTNCancel.Size = New System.Drawing.Size(113, 34)
        Me.BTNCancel.TabIndex = 34
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
        Me.BTNSave.Location = New System.Drawing.Point(287, 275)
        Me.BTNSave.Name = "BTNSave"
        Me.BTNSave.Size = New System.Drawing.Size(113, 34)
        Me.BTNSave.TabIndex = 33
        Me.BTNSave.Text = "SAVE"
        Me.BTNSave.UseVisualStyleBackColor = False
        '
        'Heading1
        '
        Me.Heading1.BackColor = System.Drawing.Color.White
        Me.Heading1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Heading1.Font = New System.Drawing.Font("Verdana", 8.25!)
        Me.Heading1.Location = New System.Drawing.Point(0, 0)
        Me.Heading1.Name = "Heading1"
        Me.Heading1.Size = New System.Drawing.Size(542, 127)
        Me.Heading1.TabIndex = 35
        Me.Heading1.Title = ""
        '
        'AnswerForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Green
        Me.ClientSize = New System.Drawing.Size(542, 329)
        Me.Controls.Add(Me.BTNCancel)
        Me.Controls.Add(Me.BTNSave)
        Me.Controls.Add(Me.txt_answer)
        Me.Controls.Add(Me.is_correct)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Heading1)
        Me.Font = New System.Drawing.Font("Verdana", 8.25!)
        Me.ForeColor = System.Drawing.Color.White
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "AnswerForm"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Answer Form"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents is_correct As System.Windows.Forms.CheckBox
    Friend WithEvents txt_answer As System.Windows.Forms.TextBox
    Friend WithEvents BTNCancel As System.Windows.Forms.Button
    Friend WithEvents BTNSave As System.Windows.Forms.Button
    Friend WithEvents Heading1 As Heading
End Class
