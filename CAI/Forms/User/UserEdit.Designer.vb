<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class UserEdit
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(UserEdit))
        Me.txt_last_name = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txt_middle = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txt_first_name = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txt_username = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.BTNCancel = New System.Windows.Forms.Button()
        Me.BTNSave = New System.Windows.Forms.Button()
        Me.Heading1 = New CAI.Heading()
        Me.pict_user_pict = New System.Windows.Forms.PictureBox()
        Me.LabelActionChangeImage = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.DisplayLastUpdatedDate = New System.Windows.Forms.Label()
        Me.DisplayLastUpdatedBy = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        CType(Me.pict_user_pict, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txt_last_name
        '
        Me.txt_last_name.Location = New System.Drawing.Point(11, 567)
        Me.txt_last_name.Margin = New System.Windows.Forms.Padding(3, 5, 3, 5)
        Me.txt_last_name.Name = "txt_last_name"
        Me.txt_last_name.Size = New System.Drawing.Size(470, 23)
        Me.txt_last_name.TabIndex = 3
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(11, 546)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(95, 16)
        Me.Label7.TabIndex = 15
        Me.Label7.Text = "LAST NAME :"
        '
        'txt_middle
        '
        Me.txt_middle.Location = New System.Drawing.Point(11, 503)
        Me.txt_middle.Margin = New System.Windows.Forms.Padding(3, 5, 3, 5)
        Me.txt_middle.Name = "txt_middle"
        Me.txt_middle.Size = New System.Drawing.Size(470, 23)
        Me.txt_middle.TabIndex = 2
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(11, 482)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(68, 16)
        Me.Label6.TabIndex = 13
        Me.Label6.Text = "MIDDLE :"
        '
        'txt_first_name
        '
        Me.txt_first_name.Location = New System.Drawing.Point(11, 438)
        Me.txt_first_name.Margin = New System.Windows.Forms.Padding(3, 5, 3, 5)
        Me.txt_first_name.Name = "txt_first_name"
        Me.txt_first_name.Size = New System.Drawing.Size(470, 23)
        Me.txt_first_name.TabIndex = 1
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(11, 417)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(100, 16)
        Me.Label5.TabIndex = 16
        Me.Label5.Text = "FIRST NAME :"
        '
        'txt_username
        '
        Me.txt_username.Location = New System.Drawing.Point(11, 375)
        Me.txt_username.Margin = New System.Windows.Forms.Padding(3, 5, 3, 5)
        Me.txt_username.Name = "txt_username"
        Me.txt_username.Size = New System.Drawing.Size(319, 23)
        Me.txt_username.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(11, 354)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(90, 16)
        Me.Label1.TabIndex = 14
        Me.Label1.Text = "USERNAME :"
        '
        'BTNCancel
        '
        Me.BTNCancel.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BTNCancel.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.BTNCancel.FlatAppearance.BorderColor = System.Drawing.Color.Green
        Me.BTNCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BTNCancel.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.BTNCancel.Location = New System.Drawing.Point(350, 616)
        Me.BTNCancel.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.BTNCancel.Name = "BTNCancel"
        Me.BTNCancel.Size = New System.Drawing.Size(129, 42)
        Me.BTNCancel.TabIndex = 38
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
        Me.BTNSave.Location = New System.Drawing.Point(214, 616)
        Me.BTNSave.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.BTNSave.Name = "BTNSave"
        Me.BTNSave.Size = New System.Drawing.Size(129, 42)
        Me.BTNSave.TabIndex = 37
        Me.BTNSave.Text = "SAVE"
        Me.BTNSave.UseVisualStyleBackColor = False
        '
        'Heading1
        '
        Me.Heading1.BackColor = System.Drawing.Color.White
        Me.Heading1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Heading1.Font = New System.Drawing.Font("Verdana", 8.25!)
        Me.Heading1.Location = New System.Drawing.Point(0, 0)
        Me.Heading1.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Heading1.Name = "Heading1"
        Me.Heading1.Size = New System.Drawing.Size(500, 134)
        Me.Heading1.TabIndex = 39
        Me.Heading1.Title = ""
        '
        'pict_user_pict
        '
        Me.pict_user_pict.BackColor = System.Drawing.Color.White
        Me.pict_user_pict.Cursor = System.Windows.Forms.Cursors.Hand
        Me.pict_user_pict.Image = CType(resources.GetObject("pict_user_pict.Image"), System.Drawing.Image)
        Me.pict_user_pict.Location = New System.Drawing.Point(37, 155)
        Me.pict_user_pict.Margin = New System.Windows.Forms.Padding(2)
        Me.pict_user_pict.Name = "pict_user_pict"
        Me.pict_user_pict.Size = New System.Drawing.Size(181, 162)
        Me.pict_user_pict.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pict_user_pict.TabIndex = 48
        Me.pict_user_pict.TabStop = False
        '
        'LabelActionChangeImage
        '
        Me.LabelActionChangeImage.AutoSize = True
        Me.LabelActionChangeImage.Cursor = System.Windows.Forms.Cursors.Hand
        Me.LabelActionChangeImage.Font = New System.Drawing.Font("Verdana", 9.75!)
        Me.LabelActionChangeImage.ImageAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.LabelActionChangeImage.Location = New System.Drawing.Point(40, 322)
        Me.LabelActionChangeImage.Name = "LabelActionChangeImage"
        Me.LabelActionChangeImage.Size = New System.Drawing.Size(175, 16)
        Me.LabelActionChangeImage.TabIndex = 47
        Me.LabelActionChangeImage.Text = "CLICK IMAGE TO CHANGE"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(257, 155)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(171, 16)
        Me.Label2.TabIndex = 49
        Me.Label2.Text = "LAST DETAILS UPDATE :"
        '
        'DisplayLastUpdatedDate
        '
        Me.DisplayLastUpdatedDate.AutoSize = True
        Me.DisplayLastUpdatedDate.Location = New System.Drawing.Point(257, 181)
        Me.DisplayLastUpdatedDate.Name = "DisplayLastUpdatedDate"
        Me.DisplayLastUpdatedDate.Size = New System.Drawing.Size(29, 16)
        Me.DisplayLastUpdatedDate.TabIndex = 50
        Me.DisplayLastUpdatedDate.Text = "---"
        '
        'DisplayLastUpdatedBy
        '
        Me.DisplayLastUpdatedBy.AutoSize = True
        Me.DisplayLastUpdatedBy.Location = New System.Drawing.Point(257, 236)
        Me.DisplayLastUpdatedBy.Name = "DisplayLastUpdatedBy"
        Me.DisplayLastUpdatedBy.Size = New System.Drawing.Size(29, 16)
        Me.DisplayLastUpdatedBy.TabIndex = 52
        Me.DisplayLastUpdatedBy.Text = "---"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(257, 210)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(102, 16)
        Me.Label8.TabIndex = 51
        Me.Label8.Text = "UPDATED BY :"
        '
        'UserEdit
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Green
        Me.ClientSize = New System.Drawing.Size(500, 672)
        Me.Controls.Add(Me.DisplayLastUpdatedBy)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.DisplayLastUpdatedDate)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Heading1)
        Me.Controls.Add(Me.BTNCancel)
        Me.Controls.Add(Me.BTNSave)
        Me.Controls.Add(Me.txt_last_name)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.txt_middle)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.txt_first_name)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.txt_username)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.pict_user_pict)
        Me.Controls.Add(Me.LabelActionChangeImage)
        Me.Font = New System.Drawing.Font("Verdana", 9.75!)
        Me.ForeColor = System.Drawing.Color.White
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "UserEdit"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Editing Profile"
        CType(Me.pict_user_pict, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txt_last_name As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents txt_middle As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txt_first_name As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txt_username As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents BTNCancel As System.Windows.Forms.Button
    Friend WithEvents BTNSave As System.Windows.Forms.Button
    Friend WithEvents Heading1 As Heading
    Friend WithEvents pict_user_pict As PictureBox
    Friend WithEvents LabelActionChangeImage As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents DisplayLastUpdatedDate As Label
    Friend WithEvents DisplayLastUpdatedBy As Label
    Friend WithEvents Label8 As Label
End Class
