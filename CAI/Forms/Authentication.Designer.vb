<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
<Global.System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1726")> _
Partial Class Authentication
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
    Friend WithEvents UsernameLabel As System.Windows.Forms.Label
    Friend WithEvents PasswordLabel As System.Windows.Forms.Label
    Friend WithEvents UsernameTextBox As System.Windows.Forms.TextBox
    Friend WithEvents PasswordTextBox As System.Windows.Forms.TextBox

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Authentication))
        Me.UsernameLabel = New System.Windows.Forms.Label()
        Me.PasswordLabel = New System.Windows.Forms.Label()
        Me.UsernameTextBox = New System.Windows.Forms.TextBox()
        Me.PasswordTextBox = New System.Windows.Forms.TextBox()
        Me.BTNLogin = New System.Windows.Forms.Button()
        Me.BTNCancel = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.ip_address = New System.Windows.Forms.Label()
        Me.lbl_display_ip = New System.Windows.Forms.Label()
        Me.link_register_student = New System.Windows.Forms.LinkLabel()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.LinkLoginAsStudent = New System.Windows.Forms.LinkLabel()
        Me.LinkLabel2 = New System.Windows.Forms.LinkLabel()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'UsernameLabel
        '
        Me.UsernameLabel.AutoSize = True
        Me.UsernameLabel.Font = New System.Drawing.Font("Verdana", 14.0!, System.Drawing.FontStyle.Bold)
        Me.UsernameLabel.Location = New System.Drawing.Point(113, 217)
        Me.UsernameLabel.Name = "UsernameLabel"
        Me.UsernameLabel.Size = New System.Drawing.Size(137, 23)
        Me.UsernameLabel.TabIndex = 0
        Me.UsernameLabel.Text = "&USERNAME:"
        Me.UsernameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'PasswordLabel
        '
        Me.PasswordLabel.AutoSize = True
        Me.PasswordLabel.Font = New System.Drawing.Font("Verdana", 14.0!, System.Drawing.FontStyle.Bold)
        Me.PasswordLabel.Location = New System.Drawing.Point(113, 300)
        Me.PasswordLabel.Name = "PasswordLabel"
        Me.PasswordLabel.Size = New System.Drawing.Size(143, 23)
        Me.PasswordLabel.TabIndex = 2
        Me.PasswordLabel.Text = "&PASSWORD:"
        Me.PasswordLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'UsernameTextBox
        '
        Me.UsernameTextBox.Font = New System.Drawing.Font("Verdana", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UsernameTextBox.ForeColor = System.Drawing.Color.Black
        Me.UsernameTextBox.HideSelection = False
        Me.UsernameTextBox.Location = New System.Drawing.Point(116, 244)
        Me.UsernameTextBox.Name = "UsernameTextBox"
        Me.UsernameTextBox.Size = New System.Drawing.Size(318, 33)
        Me.UsernameTextBox.TabIndex = 1
        Me.UsernameTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'PasswordTextBox
        '
        Me.PasswordTextBox.Font = New System.Drawing.Font("Verdana", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PasswordTextBox.ForeColor = System.Drawing.Color.Black
        Me.PasswordTextBox.HideSelection = False
        Me.PasswordTextBox.Location = New System.Drawing.Point(116, 326)
        Me.PasswordTextBox.Name = "PasswordTextBox"
        Me.PasswordTextBox.PasswordChar = Global.Microsoft.VisualBasic.ChrW(8226)
        Me.PasswordTextBox.Size = New System.Drawing.Size(318, 33)
        Me.PasswordTextBox.TabIndex = 3
        Me.PasswordTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'BTNLogin
        '
        Me.BTNLogin.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BTNLogin.BackColor = System.Drawing.Color.Transparent
        Me.BTNLogin.DialogResult = System.Windows.Forms.DialogResult.OK
        Me.BTNLogin.FlatAppearance.BorderSize = 0
        Me.BTNLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BTNLogin.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTNLogin.ForeColor = System.Drawing.Color.White
        Me.BTNLogin.Image = Global.CAI.My.Resources.Resources.icons8_password_48
        Me.BTNLogin.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.BTNLogin.Location = New System.Drawing.Point(116, 374)
        Me.BTNLogin.Name = "BTNLogin"
        Me.BTNLogin.Size = New System.Drawing.Size(86, 81)
        Me.BTNLogin.TabIndex = 12
        Me.BTNLogin.Text = "" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "LOGIN"
        Me.BTNLogin.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.BTNLogin.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.BTNLogin.UseVisualStyleBackColor = False
        '
        'BTNCancel
        '
        Me.BTNCancel.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BTNCancel.BackColor = System.Drawing.Color.Transparent
        Me.BTNCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.BTNCancel.FlatAppearance.BorderSize = 0
        Me.BTNCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BTNCancel.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold)
        Me.BTNCancel.ForeColor = System.Drawing.Color.White
        Me.BTNCancel.Image = Global.CAI.My.Resources.Resources.icons8_cancel_40
        Me.BTNCancel.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.BTNCancel.Location = New System.Drawing.Point(348, 374)
        Me.BTNCancel.Name = "BTNCancel"
        Me.BTNCancel.Size = New System.Drawing.Size(86, 81)
        Me.BTNCancel.TabIndex = 13
        Me.BTNCancel.Text = "" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "EXIT"
        Me.BTNCancel.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.BTNCancel.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.BTNCancel.UseVisualStyleBackColor = False
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(5, 4)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(132, 152)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 14
        Me.PictureBox1.TabStop = False
        '
        'ip_address
        '
        Me.ip_address.AutoSize = True
        Me.ip_address.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ip_address.Location = New System.Drawing.Point(12, 171)
        Me.ip_address.Name = "ip_address"
        Me.ip_address.Size = New System.Drawing.Size(93, 16)
        Me.ip_address.TabIndex = 18
        Me.ip_address.Text = "UNIT NAME :"
        Me.ip_address.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lbl_display_ip
        '
        Me.lbl_display_ip.AutoSize = True
        Me.lbl_display_ip.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_display_ip.Location = New System.Drawing.Point(111, 171)
        Me.lbl_display_ip.Name = "lbl_display_ip"
        Me.lbl_display_ip.Size = New System.Drawing.Size(23, 16)
        Me.lbl_display_ip.TabIndex = 19
        Me.lbl_display_ip.Text = "..."
        Me.lbl_display_ip.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'link_register_student
        '
        Me.link_register_student.AutoSize = True
        Me.link_register_student.LinkColor = System.Drawing.Color.White
        Me.link_register_student.Location = New System.Drawing.Point(314, 474)
        Me.link_register_student.Name = "link_register_student"
        Me.link_register_student.Size = New System.Drawing.Size(120, 13)
        Me.link_register_student.TabIndex = 20
        Me.link_register_student.TabStop = True
        Me.link_register_student.Text = "Register As Student"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.White
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.PictureBox1)
        Me.Panel1.Controls.Add(Me.Label7)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(547, 158)
        Me.Panel1.TabIndex = 21
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Verdana", 22.0!, System.Drawing.FontStyle.Bold)
        Me.Label1.ForeColor = System.Drawing.Color.Green
        Me.Label1.Location = New System.Drawing.Point(244, 94)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(139, 36)
        Me.Label1.TabIndex = 16
        Me.Label1.Text = "LOG-IN"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Verdana", 13.0!, System.Drawing.FontStyle.Bold)
        Me.Label7.ForeColor = System.Drawing.Color.Green
        Me.Label7.Location = New System.Drawing.Point(143, 31)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(341, 44)
        Me.Label7.TabIndex = 15
        Me.Label7.Text = "SAINT JEAN BAPTISTE ACADEMY" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "BALIUAG, BULACAN"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'LinkLoginAsStudent
        '
        Me.LinkLoginAsStudent.LinkColor = System.Drawing.Color.White
        Me.LinkLoginAsStudent.Location = New System.Drawing.Point(116, 474)
        Me.LinkLoginAsStudent.Name = "LinkLoginAsStudent"
        Me.LinkLoginAsStudent.Size = New System.Drawing.Size(190, 13)
        Me.LinkLoginAsStudent.TabIndex = 22
        Me.LinkLoginAsStudent.TabStop = True
        Me.LinkLoginAsStudent.Text = "Login As Student"
        Me.LinkLoginAsStudent.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'LinkLabel2
        '
        Me.LinkLabel2.AutoSize = True
        Me.LinkLabel2.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline
        Me.LinkLabel2.LinkColor = System.Drawing.Color.White
        Me.LinkLabel2.Location = New System.Drawing.Point(305, 474)
        Me.LinkLabel2.Name = "LinkLabel2"
        Me.LinkLabel2.Size = New System.Drawing.Size(12, 13)
        Me.LinkLabel2.TabIndex = 23
        Me.LinkLabel2.TabStop = True
        Me.LinkLabel2.Text = "|"
        '
        'Authentication
        '
        Me.AcceptButton = Me.BTNLogin
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Green
        Me.CancelButton = Me.BTNCancel
        Me.ClientSize = New System.Drawing.Size(547, 511)
        Me.Controls.Add(Me.LinkLabel2)
        Me.Controls.Add(Me.LinkLoginAsStudent)
        Me.Controls.Add(Me.link_register_student)
        Me.Controls.Add(Me.lbl_display_ip)
        Me.Controls.Add(Me.ip_address)
        Me.Controls.Add(Me.BTNCancel)
        Me.Controls.Add(Me.BTNLogin)
        Me.Controls.Add(Me.PasswordTextBox)
        Me.Controls.Add(Me.UsernameTextBox)
        Me.Controls.Add(Me.PasswordLabel)
        Me.Controls.Add(Me.UsernameLabel)
        Me.Controls.Add(Me.Panel1)
        Me.Font = New System.Drawing.Font("Verdana", 8.25!)
        Me.ForeColor = System.Drawing.Color.White
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Authentication"
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Authentication"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents BTNCancel As System.Windows.Forms.Button
    Friend WithEvents BTNLogin As System.Windows.Forms.Button
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents ip_address As System.Windows.Forms.Label
    Friend WithEvents lbl_display_ip As System.Windows.Forms.Label
    Friend WithEvents link_register_student As System.Windows.Forms.LinkLabel
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label7 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents LinkLoginAsStudent As LinkLabel
    Friend WithEvents LinkLabel2 As LinkLabel
End Class
