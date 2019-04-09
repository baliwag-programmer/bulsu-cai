<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class UserForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(UserForm))
        Me.LabelActionChangeImage = New System.Windows.Forms.Label()
        Me.txt_last_name = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txt_middle = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txt_first_name = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txt_password_confirmation = New System.Windows.Forms.TextBox()
        Me.txt_password = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txt_username = New System.Windows.Forms.TextBox()
        Me.LabelUsername = New System.Windows.Forms.Label()
        Me.LabelAccountType = New System.Windows.Forms.Label()
        Me.ComboAccountType = New System.Windows.Forms.ComboBox()
        Me.BTNCancel = New System.Windows.Forms.Button()
        Me.BTNSave = New System.Windows.Forms.Button()
        Me.pict_user_pict = New System.Windows.Forms.PictureBox()
        Me.Heading1 = New CAI.Heading()
        CType(Me.pict_user_pict, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'LabelActionChangeImage
        '
        Me.LabelActionChangeImage.AutoSize = True
        Me.LabelActionChangeImage.Cursor = System.Windows.Forms.Cursors.Hand
        Me.LabelActionChangeImage.Font = New System.Drawing.Font("Verdana", 9.75!)
        Me.LabelActionChangeImage.ImageAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.LabelActionChangeImage.Location = New System.Drawing.Point(487, 274)
        Me.LabelActionChangeImage.Name = "LabelActionChangeImage"
        Me.LabelActionChangeImage.Size = New System.Drawing.Size(175, 16)
        Me.LabelActionChangeImage.TabIndex = 15
        Me.LabelActionChangeImage.Text = "CLICK IMAGE TO CHANGE"
        '
        'txt_last_name
        '
        Me.txt_last_name.Font = New System.Drawing.Font("Verdana", 9.75!)
        Me.txt_last_name.Location = New System.Drawing.Point(465, 332)
        Me.txt_last_name.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txt_last_name.Name = "txt_last_name"
        Me.txt_last_name.Size = New System.Drawing.Size(196, 23)
        Me.txt_last_name.TabIndex = 19
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Verdana", 9.75!)
        Me.Label7.Location = New System.Drawing.Point(465, 310)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(95, 16)
        Me.Label7.TabIndex = 20
        Me.Label7.Text = "LAST NAME :"
        '
        'txt_middle
        '
        Me.txt_middle.Font = New System.Drawing.Font("Verdana", 9.75!)
        Me.txt_middle.Location = New System.Drawing.Point(272, 332)
        Me.txt_middle.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txt_middle.Name = "txt_middle"
        Me.txt_middle.Size = New System.Drawing.Size(172, 23)
        Me.txt_middle.TabIndex = 18
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Verdana", 9.75!)
        Me.Label6.Location = New System.Drawing.Point(269, 310)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(110, 16)
        Me.Label6.TabIndex = 21
        Me.Label6.Text = "MIDDLE NAME :"
        '
        'txt_first_name
        '
        Me.txt_first_name.Font = New System.Drawing.Font("Verdana", 9.75!)
        Me.txt_first_name.Location = New System.Drawing.Point(52, 332)
        Me.txt_first_name.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txt_first_name.Name = "txt_first_name"
        Me.txt_first_name.Size = New System.Drawing.Size(201, 23)
        Me.txt_first_name.TabIndex = 17
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Verdana", 9.75!)
        Me.Label5.Location = New System.Drawing.Point(49, 310)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(100, 16)
        Me.Label5.TabIndex = 22
        Me.Label5.Text = "FIRST NAME :"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Verdana", 9.75!)
        Me.Label4.Location = New System.Drawing.Point(369, 376)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(201, 16)
        Me.Label4.TabIndex = 27
        Me.Label4.Text = "PASSWORD CONFIRMATION :"
        '
        'txt_password_confirmation
        '
        Me.txt_password_confirmation.Font = New System.Drawing.Font("Verdana", 9.75!)
        Me.txt_password_confirmation.Location = New System.Drawing.Point(372, 398)
        Me.txt_password_confirmation.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txt_password_confirmation.Name = "txt_password_confirmation"
        Me.txt_password_confirmation.PasswordChar = Global.Microsoft.VisualBasic.ChrW(8226)
        Me.txt_password_confirmation.Size = New System.Drawing.Size(290, 23)
        Me.txt_password_confirmation.TabIndex = 25
        '
        'txt_password
        '
        Me.txt_password.Font = New System.Drawing.Font("Verdana", 9.75!)
        Me.txt_password.Location = New System.Drawing.Point(52, 398)
        Me.txt_password.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txt_password.Name = "txt_password"
        Me.txt_password.PasswordChar = Global.Microsoft.VisualBasic.ChrW(8226)
        Me.txt_password.Size = New System.Drawing.Size(290, 23)
        Me.txt_password.TabIndex = 23
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Verdana", 9.75!)
        Me.Label3.Location = New System.Drawing.Point(49, 376)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(94, 16)
        Me.Label3.TabIndex = 26
        Me.Label3.Text = "PASSWORD :"
        '
        'txt_username
        '
        Me.txt_username.Font = New System.Drawing.Font("Verdana", 9.75!)
        Me.txt_username.Location = New System.Drawing.Point(52, 233)
        Me.txt_username.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txt_username.Name = "txt_username"
        Me.txt_username.Size = New System.Drawing.Size(290, 23)
        Me.txt_username.TabIndex = 16
        '
        'LabelUsername
        '
        Me.LabelUsername.AutoSize = True
        Me.LabelUsername.Font = New System.Drawing.Font("Verdana", 9.75!)
        Me.LabelUsername.Location = New System.Drawing.Point(49, 211)
        Me.LabelUsername.Name = "LabelUsername"
        Me.LabelUsername.Size = New System.Drawing.Size(90, 16)
        Me.LabelUsername.TabIndex = 24
        Me.LabelUsername.Text = "USERNAME :"
        '
        'LabelAccountType
        '
        Me.LabelAccountType.AutoSize = True
        Me.LabelAccountType.Font = New System.Drawing.Font("Verdana", 9.75!)
        Me.LabelAccountType.Location = New System.Drawing.Point(49, 151)
        Me.LabelAccountType.Name = "LabelAccountType"
        Me.LabelAccountType.Size = New System.Drawing.Size(122, 16)
        Me.LabelAccountType.TabIndex = 28
        Me.LabelAccountType.Text = "ACCOUNT TYPE :"
        '
        'ComboAccountType
        '
        Me.ComboAccountType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboAccountType.Font = New System.Drawing.Font("Verdana", 9.75!)
        Me.ComboAccountType.FormattingEnabled = True
        Me.ComboAccountType.Items.AddRange(New Object() {"Instructor", "Administrator"})
        Me.ComboAccountType.Location = New System.Drawing.Point(52, 170)
        Me.ComboAccountType.Name = "ComboAccountType"
        Me.ComboAccountType.Size = New System.Drawing.Size(290, 24)
        Me.ComboAccountType.TabIndex = 43
        '
        'BTNCancel
        '
        Me.BTNCancel.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.BTNCancel.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.BTNCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.BTNCancel.FlatAppearance.BorderColor = System.Drawing.Color.Green
        Me.BTNCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BTNCancel.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.BTNCancel.Location = New System.Drawing.Point(549, 444)
        Me.BTNCancel.Name = "BTNCancel"
        Me.BTNCancel.Size = New System.Drawing.Size(113, 34)
        Me.BTNCancel.TabIndex = 45
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
        Me.BTNSave.Location = New System.Drawing.Point(430, 444)
        Me.BTNSave.Name = "BTNSave"
        Me.BTNSave.Size = New System.Drawing.Size(113, 34)
        Me.BTNSave.TabIndex = 44
        Me.BTNSave.Text = "SAVE"
        Me.BTNSave.UseVisualStyleBackColor = False
        '
        'pict_user_pict
        '
        Me.pict_user_pict.BackColor = System.Drawing.Color.White
        Me.pict_user_pict.Cursor = System.Windows.Forms.Cursors.Hand
        Me.pict_user_pict.Image = CType(resources.GetObject("pict_user_pict.Image"), System.Drawing.Image)
        Me.pict_user_pict.Location = New System.Drawing.Point(495, 139)
        Me.pict_user_pict.Margin = New System.Windows.Forms.Padding(2)
        Me.pict_user_pict.Name = "pict_user_pict"
        Me.pict_user_pict.Size = New System.Drawing.Size(158, 132)
        Me.pict_user_pict.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pict_user_pict.TabIndex = 46
        Me.pict_user_pict.TabStop = False
        '
        'Heading1
        '
        Me.Heading1.BackColor = System.Drawing.Color.White
        Me.Heading1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Heading1.Font = New System.Drawing.Font("Verdana", 8.25!)
        Me.Heading1.Location = New System.Drawing.Point(0, 0)
        Me.Heading1.Name = "Heading1"
        Me.Heading1.Size = New System.Drawing.Size(710, 127)
        Me.Heading1.TabIndex = 5
        Me.Heading1.Title = "NEW ACCOUNT"
        '
        'UserForm
        '
        Me.AcceptButton = Me.BTNSave
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Green
        Me.CancelButton = Me.BTNCancel
        Me.ClientSize = New System.Drawing.Size(710, 497)
        Me.Controls.Add(Me.pict_user_pict)
        Me.Controls.Add(Me.BTNCancel)
        Me.Controls.Add(Me.BTNSave)
        Me.Controls.Add(Me.ComboAccountType)
        Me.Controls.Add(Me.LabelAccountType)
        Me.Controls.Add(Me.txt_last_name)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.txt_middle)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.txt_first_name)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txt_password_confirmation)
        Me.Controls.Add(Me.txt_password)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txt_username)
        Me.Controls.Add(Me.LabelUsername)
        Me.Controls.Add(Me.LabelActionChangeImage)
        Me.Controls.Add(Me.Heading1)
        Me.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ForeColor = System.Drawing.Color.White
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "UserForm"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Create New Account"
        CType(Me.pict_user_pict, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Heading1 As Heading
    Friend WithEvents LabelActionChangeImage As Label
    Friend WithEvents txt_last_name As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents txt_middle As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents txt_first_name As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents txt_password_confirmation As TextBox
    Friend WithEvents txt_password As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txt_username As TextBox
    Friend WithEvents LabelUsername As Label
    Friend WithEvents LabelAccountType As Label
    Friend WithEvents ComboAccountType As ComboBox
    Friend WithEvents BTNCancel As Button
    Friend WithEvents BTNSave As Button
    Friend WithEvents pict_user_pict As PictureBox
End Class
