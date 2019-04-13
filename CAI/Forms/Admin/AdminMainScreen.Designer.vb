<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class AdminMainScreen
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
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
        Me.AdminPanel = New System.Windows.Forms.Panel()
        Me.LabelDate = New System.Windows.Forms.Label()
        Me.LabelTime = New System.Windows.Forms.Label()
        Me.StudentControlPanel = New System.Windows.Forms.Panel()
        Me.LabelActionViewTests = New System.Windows.Forms.Label()
        Me.LabelActionViewTestResults = New System.Windows.Forms.Label()
        Me.LabelActionViewLessons = New System.Windows.Forms.Label()
        Me.ActionViewTestResults = New CAI.ImageShower()
        Me.ActionViewLessons = New CAI.ImageShower()
        Me.ActionViewTests = New CAI.ImageShower()
        Me.InstructorControlPanel = New System.Windows.Forms.Panel()
        Me.LabelActionTestManagement = New System.Windows.Forms.Label()
        Me.LabelActionApprovalManagement = New System.Windows.Forms.Label()
        Me.LabelActionLessonManagement = New System.Windows.Forms.Label()
        Me.LabelActionStudentManagement = New System.Windows.Forms.Label()
        Me.ActionLessonManagement = New CAI.ImageShower()
        Me.ActionStudentManagement = New CAI.ImageShower()
        Me.ActionTestManagement = New CAI.ImageShower()
        Me.ActionApprovalManagement = New CAI.ImageShower()
        Me.AdministratorControlPanel = New System.Windows.Forms.Panel()
        Me.LabelViewLogReport = New System.Windows.Forms.Label()
        Me.LabelMonitoring = New System.Windows.Forms.Label()
        Me.LabelAccountManagement = New System.Windows.Forms.Label()
        Me.BTNMonitoring = New System.Windows.Forms.PictureBox()
        Me.BTNViewLogReport = New System.Windows.Forms.PictureBox()
        Me.BTNAccountManagement = New System.Windows.Forms.PictureBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Panel1.SuspendLayout()
        CType(Me.Avatar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.AdminPanel.SuspendLayout()
        Me.StudentControlPanel.SuspendLayout()
        Me.InstructorControlPanel.SuspendLayout()
        Me.AdministratorControlPanel.SuspendLayout()
        CType(Me.BTNMonitoring, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BTNViewLogReport, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BTNAccountManagement, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.ButtonProfile.Location = New System.Drawing.Point(78, 385)
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
        Me.LabelAccountType.Location = New System.Drawing.Point(11, 558)
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
        Me.Label8.Location = New System.Drawing.Point(11, 531)
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
        Me.LabelFullName.Location = New System.Drawing.Point(11, 499)
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
        Me.Label6.Location = New System.Drawing.Point(11, 474)
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
        Me.ButtonSecurity.Location = New System.Drawing.Point(159, 385)
        Me.ButtonSecurity.Name = "ButtonSecurity"
        Me.ButtonSecurity.Size = New System.Drawing.Size(77, 59)
        Me.ButtonSecurity.TabIndex = 21
        Me.ButtonSecurity.Text = "SECURITY"
        Me.ButtonSecurity.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.ButtonSecurity.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.ButtonSecurity.UseVisualStyleBackColor = False
        '
        'AdminPanel
        '
        Me.AdminPanel.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.AdminPanel.BackgroundImage = Global.CAI.My.Resources.Resources.homescreenbg
        Me.AdminPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.AdminPanel.Controls.Add(Me.LabelDate)
        Me.AdminPanel.Controls.Add(Me.LabelTime)
        Me.AdminPanel.Controls.Add(Me.StudentControlPanel)
        Me.AdminPanel.Controls.Add(Me.InstructorControlPanel)
        Me.AdminPanel.Controls.Add(Me.AdministratorControlPanel)
        Me.AdminPanel.Location = New System.Drawing.Point(347, -8)
        Me.AdminPanel.Name = "AdminPanel"
        Me.AdminPanel.Size = New System.Drawing.Size(586, 596)
        Me.AdminPanel.TabIndex = 1
        '
        'LabelDate
        '
        Me.LabelDate.BackColor = System.Drawing.Color.Transparent
        Me.LabelDate.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelDate.ForeColor = System.Drawing.Color.White
        Me.LabelDate.Location = New System.Drawing.Point(152, 174)
        Me.LabelDate.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.LabelDate.Name = "LabelDate"
        Me.LabelDate.Size = New System.Drawing.Size(309, 18)
        Me.LabelDate.TabIndex = 7
        Me.LabelDate.Text = "Thursday March 23, 2019"
        Me.LabelDate.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'LabelTime
        '
        Me.LabelTime.BackColor = System.Drawing.Color.Transparent
        Me.LabelTime.Font = New System.Drawing.Font("Verdana", 18.0!, System.Drawing.FontStyle.Bold)
        Me.LabelTime.ForeColor = System.Drawing.Color.White
        Me.LabelTime.Location = New System.Drawing.Point(152, 122)
        Me.LabelTime.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.LabelTime.Name = "LabelTime"
        Me.LabelTime.Size = New System.Drawing.Size(309, 29)
        Me.LabelTime.TabIndex = 6
        Me.LabelTime.Text = "00:00:00 AM"
        Me.LabelTime.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'StudentControlPanel
        '
        Me.StudentControlPanel.BackColor = System.Drawing.Color.Transparent
        Me.StudentControlPanel.Controls.Add(Me.LabelActionViewTests)
        Me.StudentControlPanel.Controls.Add(Me.LabelActionViewTestResults)
        Me.StudentControlPanel.Controls.Add(Me.LabelActionViewLessons)
        Me.StudentControlPanel.Controls.Add(Me.ActionViewTestResults)
        Me.StudentControlPanel.Controls.Add(Me.ActionViewLessons)
        Me.StudentControlPanel.Controls.Add(Me.ActionViewTests)
        Me.StudentControlPanel.Location = New System.Drawing.Point(3, 308)
        Me.StudentControlPanel.Name = "StudentControlPanel"
        Me.StudentControlPanel.Size = New System.Drawing.Size(583, 285)
        Me.StudentControlPanel.TabIndex = 18
        Me.StudentControlPanel.Visible = False
        '
        'LabelActionViewTests
        '
        Me.LabelActionViewTests.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.LabelActionViewTests.AutoSize = True
        Me.LabelActionViewTests.Cursor = System.Windows.Forms.Cursors.Hand
        Me.LabelActionViewTests.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelActionViewTests.ForeColor = System.Drawing.Color.Black
        Me.LabelActionViewTests.Location = New System.Drawing.Point(413, 130)
        Me.LabelActionViewTests.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.LabelActionViewTests.Name = "LabelActionViewTests"
        Me.LabelActionViewTests.Size = New System.Drawing.Size(37, 14)
        Me.LabelActionViewTests.TabIndex = 19
        Me.LabelActionViewTests.Text = "TEST"
        '
        'LabelActionViewTestResults
        '
        Me.LabelActionViewTestResults.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.LabelActionViewTestResults.AutoSize = True
        Me.LabelActionViewTestResults.Cursor = System.Windows.Forms.Cursors.Hand
        Me.LabelActionViewTestResults.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelActionViewTestResults.ForeColor = System.Drawing.Color.Black
        Me.LabelActionViewTestResults.Location = New System.Drawing.Point(244, 130)
        Me.LabelActionViewTestResults.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.LabelActionViewTestResults.Name = "LabelActionViewTestResults"
        Me.LabelActionViewTestResults.Size = New System.Drawing.Size(96, 14)
        Me.LabelActionViewTestResults.TabIndex = 18
        Me.LabelActionViewTestResults.Text = "TEST RESULTS"
        '
        'LabelActionViewLessons
        '
        Me.LabelActionViewLessons.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.LabelActionViewLessons.AutoSize = True
        Me.LabelActionViewLessons.Cursor = System.Windows.Forms.Cursors.Hand
        Me.LabelActionViewLessons.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelActionViewLessons.ForeColor = System.Drawing.Color.Black
        Me.LabelActionViewLessons.Location = New System.Drawing.Point(118, 130)
        Me.LabelActionViewLessons.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.LabelActionViewLessons.Name = "LabelActionViewLessons"
        Me.LabelActionViewLessons.Size = New System.Drawing.Size(65, 14)
        Me.LabelActionViewLessons.TabIndex = 15
        Me.LabelActionViewLessons.Text = "LESSONS"
        '
        'ActionViewTestResults
        '
        Me.ActionViewTestResults.BackColor = System.Drawing.Color.Transparent
        Me.ActionViewTestResults.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ActionViewTestResults.DisabledImage = Global.CAI.My.Resources.Resources.lesson_management_disabled
        Me.ActionViewTestResults.EnabledImage = Global.CAI.My.Resources.Resources.lesson_management
        Me.ActionViewTestResults.Location = New System.Drawing.Point(238, 31)
        Me.ActionViewTestResults.Name = "ActionViewTestResults"
        Me.ActionViewTestResults.Size = New System.Drawing.Size(108, 86)
        Me.ActionViewTestResults.State = True
        Me.ActionViewTestResults.TabIndex = 20
        '
        'ActionViewLessons
        '
        Me.ActionViewLessons.BackColor = System.Drawing.Color.Transparent
        Me.ActionViewLessons.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ActionViewLessons.DisabledImage = Global.CAI.My.Resources.Resources.student_management_ico_disabled
        Me.ActionViewLessons.EnabledImage = Global.CAI.My.Resources.Resources.student_management_ico
        Me.ActionViewLessons.Location = New System.Drawing.Point(96, 27)
        Me.ActionViewLessons.Name = "ActionViewLessons"
        Me.ActionViewLessons.Size = New System.Drawing.Size(108, 90)
        Me.ActionViewLessons.State = True
        Me.ActionViewLessons.TabIndex = 20
        '
        'ActionViewTests
        '
        Me.ActionViewTests.BackColor = System.Drawing.Color.Transparent
        Me.ActionViewTests.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ActionViewTests.DisabledImage = Global.CAI.My.Resources.Resources.test_management_disabled
        Me.ActionViewTests.EnabledImage = Global.CAI.My.Resources.Resources.test_management
        Me.ActionViewTests.Location = New System.Drawing.Point(377, 30)
        Me.ActionViewTests.Name = "ActionViewTests"
        Me.ActionViewTests.Size = New System.Drawing.Size(108, 86)
        Me.ActionViewTests.State = True
        Me.ActionViewTests.TabIndex = 21
        '
        'InstructorControlPanel
        '
        Me.InstructorControlPanel.BackColor = System.Drawing.Color.Transparent
        Me.InstructorControlPanel.Controls.Add(Me.LabelActionTestManagement)
        Me.InstructorControlPanel.Controls.Add(Me.LabelActionApprovalManagement)
        Me.InstructorControlPanel.Controls.Add(Me.LabelActionLessonManagement)
        Me.InstructorControlPanel.Controls.Add(Me.LabelActionStudentManagement)
        Me.InstructorControlPanel.Controls.Add(Me.ActionLessonManagement)
        Me.InstructorControlPanel.Controls.Add(Me.ActionStudentManagement)
        Me.InstructorControlPanel.Controls.Add(Me.ActionTestManagement)
        Me.InstructorControlPanel.Controls.Add(Me.ActionApprovalManagement)
        Me.InstructorControlPanel.Location = New System.Drawing.Point(3, 308)
        Me.InstructorControlPanel.Name = "InstructorControlPanel"
        Me.InstructorControlPanel.Size = New System.Drawing.Size(583, 285)
        Me.InstructorControlPanel.TabIndex = 17
        Me.InstructorControlPanel.Visible = False
        '
        'LabelActionTestManagement
        '
        Me.LabelActionTestManagement.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.LabelActionTestManagement.AutoSize = True
        Me.LabelActionTestManagement.Cursor = System.Windows.Forms.Cursors.Hand
        Me.LabelActionTestManagement.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelActionTestManagement.ForeColor = System.Drawing.Color.Black
        Me.LabelActionTestManagement.Location = New System.Drawing.Point(369, 130)
        Me.LabelActionTestManagement.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.LabelActionTestManagement.Name = "LabelActionTestManagement"
        Me.LabelActionTestManagement.Size = New System.Drawing.Size(127, 14)
        Me.LabelActionTestManagement.TabIndex = 19
        Me.LabelActionTestManagement.Text = "TEST MANAGEMENT"
        '
        'LabelActionApprovalManagement
        '
        Me.LabelActionApprovalManagement.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.LabelActionApprovalManagement.AutoSize = True
        Me.LabelActionApprovalManagement.Cursor = System.Windows.Forms.Cursors.Hand
        Me.LabelActionApprovalManagement.Enabled = False
        Me.LabelActionApprovalManagement.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelActionApprovalManagement.ForeColor = System.Drawing.Color.Black
        Me.LabelActionApprovalManagement.Location = New System.Drawing.Point(242, 261)
        Me.LabelActionApprovalManagement.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.LabelActionApprovalManagement.Name = "LabelActionApprovalManagement"
        Me.LabelActionApprovalManagement.Size = New System.Drawing.Size(101, 14)
        Me.LabelActionApprovalManagement.TabIndex = 18
        Me.LabelActionApprovalManagement.Text = "FOR APPROVAL"
        '
        'LabelActionLessonManagement
        '
        Me.LabelActionLessonManagement.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.LabelActionLessonManagement.AutoSize = True
        Me.LabelActionLessonManagement.Cursor = System.Windows.Forms.Cursors.Hand
        Me.LabelActionLessonManagement.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelActionLessonManagement.ForeColor = System.Drawing.Color.Black
        Me.LabelActionLessonManagement.Location = New System.Drawing.Point(260, 130)
        Me.LabelActionLessonManagement.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.LabelActionLessonManagement.Name = "LabelActionLessonManagement"
        Me.LabelActionLessonManagement.Size = New System.Drawing.Size(65, 14)
        Me.LabelActionLessonManagement.TabIndex = 18
        Me.LabelActionLessonManagement.Text = "LESSONS"
        '
        'LabelActionStudentManagement
        '
        Me.LabelActionStudentManagement.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.LabelActionStudentManagement.AutoSize = True
        Me.LabelActionStudentManagement.Cursor = System.Windows.Forms.Cursors.Hand
        Me.LabelActionStudentManagement.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelActionStudentManagement.ForeColor = System.Drawing.Color.Black
        Me.LabelActionStudentManagement.Location = New System.Drawing.Point(73, 130)
        Me.LabelActionStudentManagement.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.LabelActionStudentManagement.Name = "LabelActionStudentManagement"
        Me.LabelActionStudentManagement.Size = New System.Drawing.Size(154, 14)
        Me.LabelActionStudentManagement.TabIndex = 15
        Me.LabelActionStudentManagement.Text = "STUDENT MANAGEMENT"
        '
        'ActionLessonManagement
        '
        Me.ActionLessonManagement.BackColor = System.Drawing.Color.Transparent
        Me.ActionLessonManagement.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ActionLessonManagement.DisabledImage = Global.CAI.My.Resources.Resources.lesson_management_disabled
        Me.ActionLessonManagement.EnabledImage = Global.CAI.My.Resources.Resources.lesson_management
        Me.ActionLessonManagement.Location = New System.Drawing.Point(238, 31)
        Me.ActionLessonManagement.Name = "ActionLessonManagement"
        Me.ActionLessonManagement.Size = New System.Drawing.Size(108, 86)
        Me.ActionLessonManagement.State = True
        Me.ActionLessonManagement.TabIndex = 20
        '
        'ActionStudentManagement
        '
        Me.ActionStudentManagement.BackColor = System.Drawing.Color.Transparent
        Me.ActionStudentManagement.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ActionStudentManagement.DisabledImage = Global.CAI.My.Resources.Resources.student_management_ico_disabled
        Me.ActionStudentManagement.EnabledImage = Global.CAI.My.Resources.Resources.student_management_ico
        Me.ActionStudentManagement.Location = New System.Drawing.Point(96, 27)
        Me.ActionStudentManagement.Name = "ActionStudentManagement"
        Me.ActionStudentManagement.Size = New System.Drawing.Size(108, 90)
        Me.ActionStudentManagement.State = True
        Me.ActionStudentManagement.TabIndex = 20
        '
        'ActionTestManagement
        '
        Me.ActionTestManagement.BackColor = System.Drawing.Color.Transparent
        Me.ActionTestManagement.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ActionTestManagement.DisabledImage = Global.CAI.My.Resources.Resources.test_management_disabled
        Me.ActionTestManagement.EnabledImage = Global.CAI.My.Resources.Resources.test_management
        Me.ActionTestManagement.Location = New System.Drawing.Point(377, 30)
        Me.ActionTestManagement.Name = "ActionTestManagement"
        Me.ActionTestManagement.Size = New System.Drawing.Size(108, 86)
        Me.ActionTestManagement.State = True
        Me.ActionTestManagement.TabIndex = 21
        '
        'ActionApprovalManagement
        '
        Me.ActionApprovalManagement.BackColor = System.Drawing.Color.Transparent
        Me.ActionApprovalManagement.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ActionApprovalManagement.DisabledImage = Global.CAI.My.Resources.Resources.approval_management_disabled
        Me.ActionApprovalManagement.EnabledImage = Global.CAI.My.Resources.Resources.approval_management
        Me.ActionApprovalManagement.Location = New System.Drawing.Point(238, 162)
        Me.ActionApprovalManagement.Name = "ActionApprovalManagement"
        Me.ActionApprovalManagement.Size = New System.Drawing.Size(108, 86)
        Me.ActionApprovalManagement.State = False
        Me.ActionApprovalManagement.TabIndex = 22
        '
        'AdministratorControlPanel
        '
        Me.AdministratorControlPanel.BackColor = System.Drawing.Color.Transparent
        Me.AdministratorControlPanel.Controls.Add(Me.LabelViewLogReport)
        Me.AdministratorControlPanel.Controls.Add(Me.LabelMonitoring)
        Me.AdministratorControlPanel.Controls.Add(Me.LabelAccountManagement)
        Me.AdministratorControlPanel.Controls.Add(Me.BTNMonitoring)
        Me.AdministratorControlPanel.Controls.Add(Me.BTNViewLogReport)
        Me.AdministratorControlPanel.Controls.Add(Me.BTNAccountManagement)
        Me.AdministratorControlPanel.Location = New System.Drawing.Point(3, 343)
        Me.AdministratorControlPanel.Name = "AdministratorControlPanel"
        Me.AdministratorControlPanel.Size = New System.Drawing.Size(565, 169)
        Me.AdministratorControlPanel.TabIndex = 16
        '
        'LabelViewLogReport
        '
        Me.LabelViewLogReport.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.LabelViewLogReport.AutoSize = True
        Me.LabelViewLogReport.Cursor = System.Windows.Forms.Cursors.Hand
        Me.LabelViewLogReport.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelViewLogReport.ForeColor = System.Drawing.Color.Black
        Me.LabelViewLogReport.Location = New System.Drawing.Point(369, 130)
        Me.LabelViewLogReport.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.LabelViewLogReport.Name = "LabelViewLogReport"
        Me.LabelViewLogReport.Size = New System.Drawing.Size(124, 14)
        Me.LabelViewLogReport.TabIndex = 15
        Me.LabelViewLogReport.Text = "VIEW LOG REPORT"
        '
        'LabelMonitoring
        '
        Me.LabelMonitoring.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.LabelMonitoring.AutoSize = True
        Me.LabelMonitoring.Cursor = System.Windows.Forms.Cursors.Hand
        Me.LabelMonitoring.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelMonitoring.ForeColor = System.Drawing.Color.Black
        Me.LabelMonitoring.Location = New System.Drawing.Point(248, 130)
        Me.LabelMonitoring.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.LabelMonitoring.Name = "LabelMonitoring"
        Me.LabelMonitoring.Size = New System.Drawing.Size(89, 14)
        Me.LabelMonitoring.TabIndex = 14
        Me.LabelMonitoring.Text = "MONITORING"
        '
        'LabelAccountManagement
        '
        Me.LabelAccountManagement.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.LabelAccountManagement.AutoSize = True
        Me.LabelAccountManagement.Cursor = System.Windows.Forms.Cursors.Hand
        Me.LabelAccountManagement.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelAccountManagement.ForeColor = System.Drawing.Color.Black
        Me.LabelAccountManagement.Location = New System.Drawing.Point(71, 130)
        Me.LabelAccountManagement.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.LabelAccountManagement.Name = "LabelAccountManagement"
        Me.LabelAccountManagement.Size = New System.Drawing.Size(158, 14)
        Me.LabelAccountManagement.TabIndex = 13
        Me.LabelAccountManagement.Text = "ACCOUNT MANAGEMENT"
        '
        'BTNMonitoring
        '
        Me.BTNMonitoring.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.BTNMonitoring.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BTNMonitoring.Image = CType(resources.GetObject("BTNMonitoring.Image"), System.Drawing.Image)
        Me.BTNMonitoring.Location = New System.Drawing.Point(238, 31)
        Me.BTNMonitoring.Margin = New System.Windows.Forms.Padding(2)
        Me.BTNMonitoring.Name = "BTNMonitoring"
        Me.BTNMonitoring.Size = New System.Drawing.Size(108, 86)
        Me.BTNMonitoring.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.BTNMonitoring.TabIndex = 10
        Me.BTNMonitoring.TabStop = False
        '
        'BTNViewLogReport
        '
        Me.BTNViewLogReport.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.BTNViewLogReport.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BTNViewLogReport.Image = CType(resources.GetObject("BTNViewLogReport.Image"), System.Drawing.Image)
        Me.BTNViewLogReport.Location = New System.Drawing.Point(377, 30)
        Me.BTNViewLogReport.Margin = New System.Windows.Forms.Padding(2)
        Me.BTNViewLogReport.Name = "BTNViewLogReport"
        Me.BTNViewLogReport.Size = New System.Drawing.Size(108, 86)
        Me.BTNViewLogReport.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.BTNViewLogReport.TabIndex = 9
        Me.BTNViewLogReport.TabStop = False
        '
        'BTNAccountManagement
        '
        Me.BTNAccountManagement.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.BTNAccountManagement.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BTNAccountManagement.Image = CType(resources.GetObject("BTNAccountManagement.Image"), System.Drawing.Image)
        Me.BTNAccountManagement.Location = New System.Drawing.Point(96, 27)
        Me.BTNAccountManagement.Margin = New System.Windows.Forms.Padding(2)
        Me.BTNAccountManagement.Name = "BTNAccountManagement"
        Me.BTNAccountManagement.Size = New System.Drawing.Size(108, 90)
        Me.BTNAccountManagement.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.BTNAccountManagement.TabIndex = 8
        Me.BTNAccountManagement.TabStop = False
        '
        'Label2
        '
        Me.Label2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label2.AutoSize = True
        Me.Label2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Label2.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(938, 100)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(63, 14)
        Me.Label2.TabIndex = 14
        Me.Label2.Text = "LOG OUT"
        '
        'PictureBox1
        '
        Me.PictureBox1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PictureBox1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PictureBox1.Image = Global.CAI.My.Resources.Resources.flaticon_logout
        Me.PictureBox1.Location = New System.Drawing.Point(938, 17)
        Me.PictureBox1.Margin = New System.Windows.Forms.Padding(2)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(82, 75)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 10
        Me.PictureBox1.TabStop = False
        '
        'AdminMainScreen
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1034, 600)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.AdminPanel)
        Me.Controls.Add(Me.Panel1)
        Me.Font = New System.Drawing.Font("Verdana", 8.25!)
        Me.ForeColor = System.Drawing.Color.Black
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.MinimumSize = New System.Drawing.Size(1000, 600)
        Me.Name = "AdminMainScreen"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Admininstrator"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.Avatar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.AdminPanel.ResumeLayout(False)
        Me.StudentControlPanel.ResumeLayout(False)
        Me.StudentControlPanel.PerformLayout()
        Me.InstructorControlPanel.ResumeLayout(False)
        Me.InstructorControlPanel.PerformLayout()
        Me.AdministratorControlPanel.ResumeLayout(False)
        Me.AdministratorControlPanel.PerformLayout()
        CType(Me.BTNMonitoring, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BTNViewLogReport, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BTNAccountManagement, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents AdminPanel As Panel
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
    Friend WithEvents Label2 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents AdministratorControlPanel As Panel
    Friend WithEvents InstructorControlPanel As Panel
    Friend WithEvents LabelActionTestManagement As Label
    Friend WithEvents LabelActionLessonManagement As Label
    Friend WithEvents LabelActionStudentManagement As Label
    Friend WithEvents LabelActionApprovalManagement As Label
    Friend WithEvents ActionStudentManagement As ImageShower
    Friend WithEvents ActionLessonManagement As ImageShower
    Friend WithEvents ActionTestManagement As ImageShower
    Friend WithEvents ActionApprovalManagement As ImageShower
    Friend WithEvents StudentControlPanel As Panel
    Friend WithEvents LabelActionViewTests As Label
    Friend WithEvents LabelActionViewTestResults As Label
    Friend WithEvents LabelActionViewLessons As Label
    Friend WithEvents ActionViewTestResults As ImageShower
    Friend WithEvents ActionViewLessons As ImageShower
    Friend WithEvents ActionViewTests As ImageShower
End Class
