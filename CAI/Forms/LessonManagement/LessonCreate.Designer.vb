<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class LessonCreate
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
        Me.TxtTitle = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TxtDescription = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txt_filepath = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.BTNCancel = New System.Windows.Forms.Button()
        Me.BTNSave = New System.Windows.Forms.Button()
        Me.Heading1 = New CAI.Heading()
        Me.SuspendLayout()
        '
        'TxtTitle
        '
        Me.TxtTitle.Font = New System.Drawing.Font("Tahoma", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtTitle.Location = New System.Drawing.Point(12, 163)
        Me.TxtTitle.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.TxtTitle.Name = "TxtTitle"
        Me.TxtTitle.Size = New System.Drawing.Size(481, 30)
        Me.TxtTitle.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 144)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(42, 16)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Title :"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 196)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(80, 16)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Description :"
        '
        'TxtDescription
        '
        Me.TxtDescription.Font = New System.Drawing.Font("Tahoma", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtDescription.Location = New System.Drawing.Point(12, 216)
        Me.TxtDescription.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.TxtDescription.Multiline = True
        Me.TxtDescription.Name = "TxtDescription"
        Me.TxtDescription.Size = New System.Drawing.Size(481, 216)
        Me.TxtDescription.TabIndex = 4
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(9, 434)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(82, 16)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "Attachment :"
        '
        'txt_filepath
        '
        Me.txt_filepath.Font = New System.Drawing.Font("Tahoma", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_filepath.Location = New System.Drawing.Point(11, 452)
        Me.txt_filepath.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txt_filepath.Name = "txt_filepath"
        Me.txt_filepath.ReadOnly = True
        Me.txt_filepath.Size = New System.Drawing.Size(396, 30)
        Me.txt_filepath.TabIndex = 8
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.Transparent
        Me.Button1.ForeColor = System.Drawing.Color.Black
        Me.Button1.Location = New System.Drawing.Point(413, 452)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 30)
        Me.Button1.TabIndex = 9
        Me.Button1.Text = "Browse"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'BTNCancel
        '
        Me.BTNCancel.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.BTNCancel.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.BTNCancel.FlatAppearance.BorderColor = System.Drawing.Color.Green
        Me.BTNCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BTNCancel.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.BTNCancel.Location = New System.Drawing.Point(375, 502)
        Me.BTNCancel.Name = "BTNCancel"
        Me.BTNCancel.Size = New System.Drawing.Size(113, 31)
        Me.BTNCancel.TabIndex = 11
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
        Me.BTNSave.Location = New System.Drawing.Point(256, 502)
        Me.BTNSave.Name = "BTNSave"
        Me.BTNSave.Size = New System.Drawing.Size(113, 31)
        Me.BTNSave.TabIndex = 10
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
        Me.Heading1.Size = New System.Drawing.Size(506, 127)
        Me.Heading1.TabIndex = 12
        Me.Heading1.Title = ""
        '
        'LessonCreate
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Green
        Me.ClientSize = New System.Drawing.Size(506, 545)
        Me.Controls.Add(Me.BTNCancel)
        Me.Controls.Add(Me.BTNSave)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.txt_filepath)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.TxtDescription)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TxtTitle)
        Me.Controls.Add(Me.Heading1)
        Me.Font = New System.Drawing.Font("Tahoma", 9.75!)
        Me.ForeColor = System.Drawing.Color.White
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "LessonCreate"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "LESSON CREATE"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TxtTitle As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Protected WithEvents TxtDescription As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txt_filepath As System.Windows.Forms.TextBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents BTNCancel As System.Windows.Forms.Button
    Friend WithEvents BTNSave As System.Windows.Forms.Button
    Friend WithEvents Heading1 As Heading
End Class
