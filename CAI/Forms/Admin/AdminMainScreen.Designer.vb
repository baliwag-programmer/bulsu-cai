<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AdminMainScreen
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(AdminMainScreen))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.ButtonProfile = New System.Windows.Forms.Button()
        Me.LabelAccountType = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.LabelFullName = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Avatar = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.ButtonSecurity = New System.Windows.Forms.Button()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.LabelViewLogReport = New System.Windows.Forms.Label()
        Me.LabelMonitoring = New System.Windows.Forms.Label()
        Me.LabelAccountManagement = New System.Windows.Forms.Label()
        Me.BTNMonitoring = New System.Windows.Forms.PictureBox()
        Me.BTNViewLogReport = New System.Windows.Forms.PictureBox()
        Me.BTNAccountManagement = New System.Windows.Forms.PictureBox()
        Me.LabelDate = New System.Windows.Forms.Label()
        Me.LabelTime = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        CType(Me.Avatar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        CType(Me.BTNMonitoring, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BTNViewLogReport, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BTNAccountManagement, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Green
        Me.Panel1.Controls.Add(Me.ButtonProfile)
        Me.Panel1.Controls.Add(Me.LabelAccountType)
        Me.Panel1.Controls.Add(Me.Label8)
        Me.Panel1.Controls.Add(Me.LabelFullName)
        Me.Panel1.Controls.Add(Me.Label6)
        Me.Panel1.Controls.Add(Me.Avatar)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.PictureBox2)
        Me.Panel1.Controls.Add(Me.ButtonSecurity)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(319, 600)
        Me.Panel1.TabIndex = 0
        '
        'ButtonProfile
        '
        Me.ButtonProfile.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ButtonProfile.BackColor = System.Drawing.Color.Transparent
        Me.ButtonProfile.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ButtonProfile.FlatAppearance.BorderSize = 0
        Me.ButtonProfile.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonProfile.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonProfile.ForeColor = System.Drawing.Color.White
        Me.ButtonProfile.Image = CType(resources.GetObject("ButtonProfile.Image"), System.Drawing.Image)
        Me.ButtonProfile.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.ButtonProfile.Location = New System.Drawing.Point(235, 234)
        Me.ButtonProfile.Name = "ButtonProfile"
        Me.ButtonProfile.Size = New System.Drawing.Size(77, 59)
        Me.ButtonProfile.TabIndex = 20
        Me.ButtonProfile.Text = "PROFILE"
        Me.ButtonProfile.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.ButtonProfile.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.ButtonProfile.UseVisualStyleBackColor = False
        '
        'LabelAccountType
        '
        Me.LabelAccountType.AutoSize = True
        Me.LabelAccountType.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelAccountType.ForeColor = System.Drawing.Color.White
        Me.LabelAccountType.Location = New System.Drawing.Point(11, 470)
        Me.LabelAccountType.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.LabelAccountType.Name = "LabelAccountType"
        Me.LabelAccountType.Size = New System.Drawing.Size(118, 16)
        Me.LabelAccountType.TabIndex = 19
        Me.LabelAccountType.Text = "ADMINISTRATOR"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.White
        Me.Label8.Location = New System.Drawing.Point(11, 443)
        Me.Label8.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(126, 16)
        Me.Label8.TabIndex = 18
        Me.Label8.Text = "ACCOUNT TYPE :"
        '
        'LabelFullName
        '
        Me.LabelFullName.AutoSize = True
        Me.LabelFullName.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelFullName.ForeColor = System.Drawing.Color.White
        Me.LabelFullName.Location = New System.Drawing.Point(11, 411)
        Me.LabelFullName.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.LabelFullName.Name = "LabelFullName"
        Me.LabelFullName.Size = New System.Drawing.Size(234, 16)
        Me.LabelFullName.TabIndex = 17
        Me.LabelFullName.Text = "LAST NAME, FIRST NAME, MIDDLE"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.White
        Me.Label6.Location = New System.Drawing.Point(11, 386)
        Me.Label6.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(58, 16)
        Me.Label6.TabIndex = 16
        Me.Label6.Text = "NAME :"
        '
        'Avatar
        '
        Me.Avatar.BackColor = System.Drawing.Color.White
        Me.Avatar.Image = CType(resources.GetObject("Avatar.Image"), System.Drawing.Image)
        Me.Avatar.Location = New System.Drawing.Point(78, 234)
        Me.Avatar.Margin = New System.Windows.Forms.Padding(2)
        Me.Avatar.Name = "Avatar"
        Me.Avatar.Size = New System.Drawing.Size(158, 132)
        Me.Avatar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Avatar.TabIndex = 15
        Me.Avatar.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(11, 192)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(301, 18)
        Me.Label1.TabIndex = 14
        Me.Label1.Text = "SAINT JEAN BAPTISTE ACADEMY"
        '
        'PictureBox2
        '
        Me.PictureBox2.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(91, 20)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(133, 149)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 13
        Me.PictureBox2.TabStop = False
        '
        'ButtonSecurity
        '
        Me.ButtonSecurity.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ButtonSecurity.BackColor = System.Drawing.Color.Transparent
        Me.ButtonSecurity.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ButtonSecurity.FlatAppearance.BorderSize = 0
        Me.ButtonSecurity.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonSecurity.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonSecurity.ForeColor = System.Drawing.Color.White
        Me.ButtonSecurity.Image = Global.CAI.My.Resources.Resources.icons8_key_32x32
        Me.ButtonSecurity.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.ButtonSecurity.Location = New System.Drawing.Point(235, 307)
        Me.ButtonSecurity.Name = "ButtonSecurity"
        Me.ButtonSecurity.Size = New System.Drawing.Size(77, 59)
        Me.ButtonSecurity.TabIndex = 21
        Me.ButtonSecurity.Text = "SECURITY"
        Me.ButtonSecurity.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.ButtonSecurity.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.ButtonSecurity.UseVisualStyleBackColor = False
        '
        'Panel2
        '
        Me.Panel2.BackgroundImage = Global.CAI.My.Resources.Resources.homescreenbg
        Me.Panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Panel2.Controls.Add(Me.LabelViewLogReport)
        Me.Panel2.Controls.Add(Me.LabelMonitoring)
        Me.Panel2.Controls.Add(Me.LabelAccountManagement)
        Me.Panel2.Controls.Add(Me.BTNMonitoring)
        Me.Panel2.Controls.Add(Me.BTNViewLogReport)
        Me.Panel2.Controls.Add(Me.BTNAccountManagement)
        Me.Panel2.Controls.Add(Me.LabelDate)
        Me.Panel2.Controls.Add(Me.LabelTime)
        Me.Panel2.Location = New System.Drawing.Point(366, 18)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(586, 565)
        Me.Panel2.TabIndex = 1
        '
        'LabelViewLogReport
        '
        Me.LabelViewLogReport.AutoSize = True
        Me.LabelViewLogReport.Cursor = System.Windows.Forms.Cursors.Hand
        Me.LabelViewLogReport.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelViewLogReport.ForeColor = System.Drawing.Color.Black
        Me.LabelViewLogReport.Location = New System.Drawing.Point(373, 438)
        Me.LabelViewLogReport.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.LabelViewLogReport.Name = "LabelViewLogReport"
        Me.LabelViewLogReport.Size = New System.Drawing.Size(124, 14)
        Me.LabelViewLogReport.TabIndex = 15
        Me.LabelViewLogReport.Text = "VIEW LOG REPORT"
        '
        'LabelMonitoring
        '
        Me.LabelMonitoring.AutoSize = True
        Me.LabelMonitoring.Cursor = System.Windows.Forms.Cursors.Hand
        Me.LabelMonitoring.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelMonitoring.ForeColor = System.Drawing.Color.Black
        Me.LabelMonitoring.Location = New System.Drawing.Point(252, 438)
        Me.LabelMonitoring.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.LabelMonitoring.Name = "LabelMonitoring"
        Me.LabelMonitoring.Size = New System.Drawing.Size(89, 14)
        Me.LabelMonitoring.TabIndex = 14
        Me.LabelMonitoring.Text = "MONITORING"
        '
        'LabelAccountManagement
        '
        Me.LabelAccountManagement.AutoSize = True
        Me.LabelAccountManagement.Cursor = System.Windows.Forms.Cursors.Hand
        Me.LabelAccountManagement.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelAccountManagement.ForeColor = System.Drawing.Color.Black
        Me.LabelAccountManagement.Location = New System.Drawing.Point(75, 438)
        Me.LabelAccountManagement.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.LabelAccountManagement.Name = "LabelAccountManagement"
        Me.LabelAccountManagement.Size = New System.Drawing.Size(158, 14)
        Me.LabelAccountManagement.TabIndex = 13
        Me.LabelAccountManagement.Text = "ACCOUNT MANAGEMENT"
        '
        'BTNMonitoring
        '
        Me.BTNMonitoring.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BTNMonitoring.Image = CType(resources.GetObject("BTNMonitoring.Image"), System.Drawing.Image)
        Me.BTNMonitoring.Location = New System.Drawing.Point(242, 339)
        Me.BTNMonitoring.Margin = New System.Windows.Forms.Padding(2)
        Me.BTNMonitoring.Name = "BTNMonitoring"
        Me.BTNMonitoring.Size = New System.Drawing.Size(108, 86)
        Me.BTNMonitoring.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.BTNMonitoring.TabIndex = 10
        Me.BTNMonitoring.TabStop = False
        '
        'BTNViewLogReport
        '
        Me.BTNViewLogReport.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BTNViewLogReport.Image = CType(resources.GetObject("BTNViewLogReport.Image"), System.Drawing.Image)
        Me.BTNViewLogReport.Location = New System.Drawing.Point(381, 338)
        Me.BTNViewLogReport.Margin = New System.Windows.Forms.Padding(2)
        Me.BTNViewLogReport.Name = "BTNViewLogReport"
        Me.BTNViewLogReport.Size = New System.Drawing.Size(108, 86)
        Me.BTNViewLogReport.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.BTNViewLogReport.TabIndex = 9
        Me.BTNViewLogReport.TabStop = False
        '
        'BTNAccountManagement
        '
        Me.BTNAccountManagement.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BTNAccountManagement.Image = CType(resources.GetObject("BTNAccountManagement.Image"), System.Drawing.Image)
        Me.BTNAccountManagement.Location = New System.Drawing.Point(100, 335)
        Me.BTNAccountManagement.Margin = New System.Windows.Forms.Padding(2)
        Me.BTNAccountManagement.Name = "BTNAccountManagement"
        Me.BTNAccountManagement.Size = New System.Drawing.Size(108, 90)
        Me.BTNAccountManagement.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.BTNAccountManagement.TabIndex = 8
        Me.BTNAccountManagement.TabStop = False
        '
        'LabelDate
        '
        Me.LabelDate.AutoSize = True
        Me.LabelDate.BackColor = System.Drawing.Color.Transparent
        Me.LabelDate.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelDate.ForeColor = System.Drawing.Color.White
        Me.LabelDate.Location = New System.Drawing.Point(187, 174)
        Me.LabelDate.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.LabelDate.Name = "LabelDate"
        Me.LabelDate.Size = New System.Drawing.Size(232, 18)
        Me.LabelDate.TabIndex = 7
        Me.LabelDate.Text = "Thursday March 23, 2019"
        '
        'LabelTime
        '
        Me.LabelTime.AutoSize = True
        Me.LabelTime.BackColor = System.Drawing.Color.Transparent
        Me.LabelTime.Font = New System.Drawing.Font("Verdana", 18.0!, System.Drawing.FontStyle.Bold)
        Me.LabelTime.ForeColor = System.Drawing.Color.White
        Me.LabelTime.Location = New System.Drawing.Point(211, 122)
        Me.LabelTime.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.LabelTime.Name = "LabelTime"
        Me.LabelTime.Size = New System.Drawing.Size(185, 29)
        Me.LabelTime.TabIndex = 6
        Me.LabelTime.Text = "00:00:00 AM"
        '
        'AdminMainScreen
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1000, 600)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Font = New System.Drawing.Font("Verdana", 8.25!)
        Me.ForeColor = System.Drawing.Color.Black
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.MinimumSize = New System.Drawing.Size(1000, 600)
        Me.Name = "AdminMainScreen"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Admininstrator"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.Avatar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.BTNMonitoring, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BTNViewLogReport, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BTNAccountManagement, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents LabelDate As Label
    Friend WithEvents LabelTime As Label
    Friend WithEvents BTNMonitoring As PictureBox
    Friend WithEvents BTNViewLogReport As PictureBox
    Friend WithEvents BTNAccountManagement As PictureBox
    Friend WithEvents LabelViewLogReport As Label
    Friend WithEvents LabelMonitoring As Label
    Friend WithEvents LabelAccountManagement As Label
    Friend WithEvents LabelFullName As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Avatar As PictureBox
    Friend WithEvents LabelAccountType As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents ButtonProfile As Button
    Friend WithEvents ButtonSecurity As Button
End Class
