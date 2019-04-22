<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class StudentBatchInformation
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
        Me.Heading1 = New CAI.Heading()
        Me.BTNCancel = New System.Windows.Forms.Button()
        Me.BTNSave = New System.Windows.Forms.Button()
        Me.TXTYearFrom = New System.Windows.Forms.TextBox()
        Me.TXTYearTo = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TXTYear = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TXTSection = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Heading1
        '
        Me.Heading1.BackColor = System.Drawing.Color.White
        Me.Heading1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Heading1.Font = New System.Drawing.Font("Verdana", 8.25!)
        Me.Heading1.Location = New System.Drawing.Point(0, 0)
        Me.Heading1.Name = "Heading1"
        Me.Heading1.Size = New System.Drawing.Size(739, 127)
        Me.Heading1.TabIndex = 6
        Me.Heading1.Title = "BATCH INFORMATION"
        '
        'BTNCancel
        '
        Me.BTNCancel.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.BTNCancel.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.BTNCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.BTNCancel.FlatAppearance.BorderColor = System.Drawing.Color.Green
        Me.BTNCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BTNCancel.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.BTNCancel.Location = New System.Drawing.Point(615, 271)
        Me.BTNCancel.Name = "BTNCancel"
        Me.BTNCancel.Size = New System.Drawing.Size(113, 34)
        Me.BTNCancel.TabIndex = 5
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
        Me.BTNSave.Location = New System.Drawing.Point(496, 271)
        Me.BTNSave.Name = "BTNSave"
        Me.BTNSave.Size = New System.Drawing.Size(113, 34)
        Me.BTNSave.TabIndex = 4
        Me.BTNSave.Text = "CONFIRM"
        Me.BTNSave.UseVisualStyleBackColor = False
        '
        'TXTYearFrom
        '
        Me.TXTYearFrom.Font = New System.Drawing.Font("Verdana", 9.75!)
        Me.TXTYearFrom.Location = New System.Drawing.Point(15, 160)
        Me.TXTYearFrom.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.TXTYearFrom.MaxLength = 4
        Me.TXTYearFrom.Name = "TXTYearFrom"
        Me.TXTYearFrom.Size = New System.Drawing.Size(184, 23)
        Me.TXTYearFrom.TabIndex = 0
        '
        'TXTYearTo
        '
        Me.TXTYearTo.Font = New System.Drawing.Font("Verdana", 9.75!)
        Me.TXTYearTo.Location = New System.Drawing.Point(232, 160)
        Me.TXTYearTo.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.TXTYearTo.MaxLength = 4
        Me.TXTYearTo.Name = "TXTYearTo"
        Me.TXTYearTo.Size = New System.Drawing.Size(184, 23)
        Me.TXTYearTo.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Verdana", 9.75!)
        Me.Label1.Location = New System.Drawing.Point(208, 163)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(15, 16)
        Me.Label1.TabIndex = 51
        Me.Label1.Text = "-"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Verdana", 9.75!)
        Me.Label2.Location = New System.Drawing.Point(12, 206)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(53, 16)
        Me.Label2.TabIndex = 52
        Me.Label2.Text = "YEAR :"
        '
        'TXTYear
        '
        Me.TXTYear.Font = New System.Drawing.Font("Verdana", 9.75!)
        Me.TXTYear.Location = New System.Drawing.Point(15, 226)
        Me.TXTYear.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.TXTYear.MaxLength = 2
        Me.TXTYear.Name = "TXTYear"
        Me.TXTYear.Size = New System.Drawing.Size(184, 23)
        Me.TXTYear.TabIndex = 2
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Verdana", 9.75!)
        Me.Label3.Location = New System.Drawing.Point(229, 206)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(78, 16)
        Me.Label3.TabIndex = 52
        Me.Label3.Text = "SECTION :"
        '
        'TXTSection
        '
        Me.TXTSection.Font = New System.Drawing.Font("Verdana", 9.75!)
        Me.TXTSection.Location = New System.Drawing.Point(232, 226)
        Me.TXTSection.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.TXTSection.MaxLength = 2
        Me.TXTSection.Name = "TXTSection"
        Me.TXTSection.Size = New System.Drawing.Size(184, 23)
        Me.TXTSection.TabIndex = 3
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Verdana", 9.75!)
        Me.Label4.Location = New System.Drawing.Point(12, 141)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(154, 16)
        Me.Label4.TabIndex = 54
        Me.Label4.Text = "SCHOOL YEAR FROM :"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Verdana", 9.75!)
        Me.Label5.Location = New System.Drawing.Point(229, 141)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(136, 16)
        Me.Label5.TabIndex = 54
        Me.Label5.Text = "SCHOOL YEAR TO :"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.ForeColor = System.Drawing.Color.White
        Me.GroupBox1.Location = New System.Drawing.Point(433, 142)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(292, 110)
        Me.GroupBox1.TabIndex = 55
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "NOTICE"
        '
        'Label8
        '
        Me.Label8.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label8.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(3, 19)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(286, 88)
        Me.Label8.TabIndex = 58
        Me.Label8.Text = "This information is important for the purpose of safe keeping of your data/record" &
    "s related to this application."
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Verdana", 9.75!)
        Me.Label7.Location = New System.Drawing.Point(208, 229)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(15, 16)
        Me.Label7.TabIndex = 57
        Me.Label7.Text = "-"
        '
        'StudentBatchInformation
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Green
        Me.ClientSize = New System.Drawing.Size(739, 317)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.TXTSection)
        Me.Controls.Add(Me.TXTYear)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TXTYearTo)
        Me.Controls.Add(Me.TXTYearFrom)
        Me.Controls.Add(Me.BTNCancel)
        Me.Controls.Add(Me.BTNSave)
        Me.Controls.Add(Me.Heading1)
        Me.Font = New System.Drawing.Font("Verdana", 9.75!)
        Me.ForeColor = System.Drawing.Color.White
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "StudentBatchInformation"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "STUDENT BATCH INFORMATION"
        Me.GroupBox1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Heading1 As Heading
    Friend WithEvents BTNCancel As Button
    Friend WithEvents BTNSave As Button
    Friend WithEvents TXTYearFrom As TextBox
    Friend WithEvents TXTYearTo As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents TXTYear As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents TXTSection As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
End Class
