<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class UserListRev2
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(UserListRev2))
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.UserDetailWrapper = New System.Windows.Forms.Panel()
        Me.ActionHideUserDetailWrapper = New System.Windows.Forms.Button()
        Me.BTNApprovedBlocked = New System.Windows.Forms.Button()
        Me.BTNPreview = New System.Windows.Forms.Button()
        Me.DisplayAccountType = New System.Windows.Forms.Label()
        Me.LabelDisplayAccountType = New System.Windows.Forms.Label()
        Me.DisplayFullName = New System.Windows.Forms.Label()
        Me.LabelDisplayFullName = New System.Windows.Forms.Label()
        Me.DisplayUsername = New System.Windows.Forms.Label()
        Me.LabelDisplayUsername = New System.Windows.Forms.Label()
        Me.DisplayRegisteredSince = New System.Windows.Forms.Label()
        Me.LabelDisplayRegisteredSince = New System.Windows.Forms.Label()
        Me.pict_user_pict = New System.Windows.Forms.PictureBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.btn_prev = New System.Windows.Forms.Button()
        Me.btn_next = New System.Windows.Forms.Button()
        Me.pagination = New System.Windows.Forms.Label()
        Me.user_list = New System.Windows.Forms.ListView()
        Me.ColumnHeader5 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.list_username = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader6 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader8 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader7 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ActionClose = New System.Windows.Forms.Button()
        Me.BTNEdit = New System.Windows.Forms.Button()
        Me.BTNCreate = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.ActionFilter = New System.Windows.Forms.Button()
        Me.RoleFilter = New System.Windows.Forms.ComboBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.KeywordFilter = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.ColumnHeader1 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader2 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader3 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader4 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.BTNTrash = New System.Windows.Forms.Button()
        Me.Heading1 = New CAI.Heading()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.UserDetailWrapper.SuspendLayout()
        CType(Me.pict_user_pict, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TableLayoutPanel1.ColumnCount = 2
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.TableLayoutPanel1.Controls.Add(Me.UserDetailWrapper, 1, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.Panel1, 0, 0)
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(-2, 200)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 1
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 363.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(1204, 363)
        Me.TableLayoutPanel1.TabIndex = 3
        '
        'UserDetailWrapper
        '
        Me.UserDetailWrapper.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.UserDetailWrapper.BackColor = System.Drawing.Color.DarkGreen
        Me.UserDetailWrapper.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.UserDetailWrapper.Controls.Add(Me.pict_user_pict)
        Me.UserDetailWrapper.Controls.Add(Me.ActionHideUserDetailWrapper)
        Me.UserDetailWrapper.Controls.Add(Me.BTNApprovedBlocked)
        Me.UserDetailWrapper.Controls.Add(Me.BTNPreview)
        Me.UserDetailWrapper.Controls.Add(Me.DisplayAccountType)
        Me.UserDetailWrapper.Controls.Add(Me.LabelDisplayAccountType)
        Me.UserDetailWrapper.Controls.Add(Me.DisplayFullName)
        Me.UserDetailWrapper.Controls.Add(Me.LabelDisplayFullName)
        Me.UserDetailWrapper.Controls.Add(Me.DisplayUsername)
        Me.UserDetailWrapper.Controls.Add(Me.LabelDisplayUsername)
        Me.UserDetailWrapper.Controls.Add(Me.DisplayRegisteredSince)
        Me.UserDetailWrapper.Controls.Add(Me.LabelDisplayRegisteredSince)
        Me.UserDetailWrapper.Dock = System.Windows.Forms.DockStyle.Left
        Me.UserDetailWrapper.Location = New System.Drawing.Point(942, 0)
        Me.UserDetailWrapper.Margin = New System.Windows.Forms.Padding(0)
        Me.UserDetailWrapper.Name = "UserDetailWrapper"
        Me.UserDetailWrapper.Size = New System.Drawing.Size(262, 363)
        Me.UserDetailWrapper.TabIndex = 0
        '
        'ActionHideUserDetailWrapper
        '
        Me.ActionHideUserDetailWrapper.BackColor = System.Drawing.Color.Red
        Me.ActionHideUserDetailWrapper.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ActionHideUserDetailWrapper.FlatAppearance.BorderSize = 0
        Me.ActionHideUserDetailWrapper.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ActionHideUserDetailWrapper.Font = New System.Drawing.Font("Verdana", 10.0!)
        Me.ActionHideUserDetailWrapper.ForeColor = System.Drawing.Color.White
        Me.ActionHideUserDetailWrapper.Location = New System.Drawing.Point(230, -1)
        Me.ActionHideUserDetailWrapper.Name = "ActionHideUserDetailWrapper"
        Me.ActionHideUserDetailWrapper.Size = New System.Drawing.Size(34, 25)
        Me.ActionHideUserDetailWrapper.TabIndex = 64
        Me.ActionHideUserDetailWrapper.Text = "X"
        Me.ActionHideUserDetailWrapper.UseVisualStyleBackColor = False
        '
        'BTNApprovedBlocked
        '
        Me.BTNApprovedBlocked.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BTNApprovedBlocked.BackColor = System.Drawing.Color.Transparent
        Me.BTNApprovedBlocked.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BTNApprovedBlocked.Enabled = False
        Me.BTNApprovedBlocked.FlatAppearance.BorderSize = 0
        Me.BTNApprovedBlocked.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BTNApprovedBlocked.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTNApprovedBlocked.ForeColor = System.Drawing.Color.White
        Me.BTNApprovedBlocked.Image = Global.CAI.My.Resources.Resources.icons8_ok_48
        Me.BTNApprovedBlocked.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.BTNApprovedBlocked.Location = New System.Drawing.Point(152, 74)
        Me.BTNApprovedBlocked.Name = "BTNApprovedBlocked"
        Me.BTNApprovedBlocked.Size = New System.Drawing.Size(85, 71)
        Me.BTNApprovedBlocked.TabIndex = 63
        Me.BTNApprovedBlocked.Text = "APPROVE"
        Me.BTNApprovedBlocked.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.BTNApprovedBlocked.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.BTNApprovedBlocked.UseVisualStyleBackColor = False
        Me.BTNApprovedBlocked.Visible = False
        '
        'BTNPreview
        '
        Me.BTNPreview.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BTNPreview.BackColor = System.Drawing.Color.Transparent
        Me.BTNPreview.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BTNPreview.Enabled = False
        Me.BTNPreview.FlatAppearance.BorderSize = 0
        Me.BTNPreview.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BTNPreview.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTNPreview.ForeColor = System.Drawing.Color.White
        Me.BTNPreview.Image = Global.CAI.My.Resources.Resources.icons8_eye_48
        Me.BTNPreview.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.BTNPreview.Location = New System.Drawing.Point(152, 0)
        Me.BTNPreview.Name = "BTNPreview"
        Me.BTNPreview.Size = New System.Drawing.Size(85, 71)
        Me.BTNPreview.TabIndex = 62
        Me.BTNPreview.Text = "PREVIEW"
        Me.BTNPreview.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.BTNPreview.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.BTNPreview.UseVisualStyleBackColor = False
        Me.BTNPreview.Visible = False
        '
        'DisplayAccountType
        '
        Me.DisplayAccountType.AutoSize = True
        Me.DisplayAccountType.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DisplayAccountType.ForeColor = System.Drawing.Color.White
        Me.DisplayAccountType.Location = New System.Drawing.Point(14, 326)
        Me.DisplayAccountType.Name = "DisplayAccountType"
        Me.DisplayAccountType.Size = New System.Drawing.Size(91, 14)
        Me.DisplayAccountType.TabIndex = 58
        Me.DisplayAccountType.Text = "Administrator"
        Me.DisplayAccountType.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'LabelDisplayAccountType
        '
        Me.LabelDisplayAccountType.AutoSize = True
        Me.LabelDisplayAccountType.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelDisplayAccountType.ForeColor = System.Drawing.Color.White
        Me.LabelDisplayAccountType.Location = New System.Drawing.Point(14, 301)
        Me.LabelDisplayAccountType.Name = "LabelDisplayAccountType"
        Me.LabelDisplayAccountType.Size = New System.Drawing.Size(126, 16)
        Me.LabelDisplayAccountType.TabIndex = 58
        Me.LabelDisplayAccountType.Text = "ACCOUNT TYPE :"
        Me.LabelDisplayAccountType.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'DisplayFullName
        '
        Me.DisplayFullName.AutoSize = True
        Me.DisplayFullName.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DisplayFullName.ForeColor = System.Drawing.Color.White
        Me.DisplayFullName.Location = New System.Drawing.Point(14, 276)
        Me.DisplayFullName.Name = "DisplayFullName"
        Me.DisplayFullName.Size = New System.Drawing.Size(22, 14)
        Me.DisplayFullName.TabIndex = 57
        Me.DisplayFullName.Text = "---"
        Me.DisplayFullName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'LabelDisplayFullName
        '
        Me.LabelDisplayFullName.AutoSize = True
        Me.LabelDisplayFullName.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelDisplayFullName.ForeColor = System.Drawing.Color.White
        Me.LabelDisplayFullName.Location = New System.Drawing.Point(14, 251)
        Me.LabelDisplayFullName.Name = "LabelDisplayFullName"
        Me.LabelDisplayFullName.Size = New System.Drawing.Size(97, 16)
        Me.LabelDisplayFullName.TabIndex = 57
        Me.LabelDisplayFullName.Text = "FULL NAME :"
        Me.LabelDisplayFullName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'DisplayUsername
        '
        Me.DisplayUsername.AutoSize = True
        Me.DisplayUsername.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DisplayUsername.ForeColor = System.Drawing.Color.White
        Me.DisplayUsername.Location = New System.Drawing.Point(14, 226)
        Me.DisplayUsername.Name = "DisplayUsername"
        Me.DisplayUsername.Size = New System.Drawing.Size(22, 14)
        Me.DisplayUsername.TabIndex = 56
        Me.DisplayUsername.Text = "---"
        Me.DisplayUsername.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'LabelDisplayUsername
        '
        Me.LabelDisplayUsername.AutoSize = True
        Me.LabelDisplayUsername.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelDisplayUsername.ForeColor = System.Drawing.Color.White
        Me.LabelDisplayUsername.Location = New System.Drawing.Point(14, 201)
        Me.LabelDisplayUsername.Name = "LabelDisplayUsername"
        Me.LabelDisplayUsername.Size = New System.Drawing.Size(95, 16)
        Me.LabelDisplayUsername.TabIndex = 56
        Me.LabelDisplayUsername.Text = "USERNAME :"
        Me.LabelDisplayUsername.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'DisplayRegisteredSince
        '
        Me.DisplayRegisteredSince.AutoSize = True
        Me.DisplayRegisteredSince.Font = New System.Drawing.Font("Verdana", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DisplayRegisteredSince.ForeColor = System.Drawing.Color.White
        Me.DisplayRegisteredSince.Location = New System.Drawing.Point(14, 176)
        Me.DisplayRegisteredSince.Name = "DisplayRegisteredSince"
        Me.DisplayRegisteredSince.Size = New System.Drawing.Size(22, 14)
        Me.DisplayRegisteredSince.TabIndex = 56
        Me.DisplayRegisteredSince.Text = "---"
        Me.DisplayRegisteredSince.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'LabelDisplayRegisteredSince
        '
        Me.LabelDisplayRegisteredSince.AutoSize = True
        Me.LabelDisplayRegisteredSince.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelDisplayRegisteredSince.ForeColor = System.Drawing.Color.White
        Me.LabelDisplayRegisteredSince.Location = New System.Drawing.Point(14, 151)
        Me.LabelDisplayRegisteredSince.Name = "LabelDisplayRegisteredSince"
        Me.LabelDisplayRegisteredSince.Size = New System.Drawing.Size(153, 16)
        Me.LabelDisplayRegisteredSince.TabIndex = 56
        Me.LabelDisplayRegisteredSince.Text = "REGISTERED SINCE :"
        Me.LabelDisplayRegisteredSince.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'pict_user_pict
        '
        Me.pict_user_pict.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.pict_user_pict.BackColor = System.Drawing.Color.White
        Me.pict_user_pict.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.pict_user_pict.Image = Global.CAI.My.Resources.Resources.icons8_user_96
        Me.pict_user_pict.Location = New System.Drawing.Point(70, 25)
        Me.pict_user_pict.Name = "pict_user_pict"
        Me.pict_user_pict.Size = New System.Drawing.Size(120, 112)
        Me.pict_user_pict.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pict_user_pict.TabIndex = 55
        Me.pict_user_pict.TabStop = False
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.Panel3)
        Me.Panel1.Controls.Add(Me.user_list)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(3, 3)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(936, 357)
        Me.Panel1.TabIndex = 1
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.Gray
        Me.Panel3.Controls.Add(Me.btn_prev)
        Me.Panel3.Controls.Add(Me.btn_next)
        Me.Panel3.Controls.Add(Me.pagination)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel3.Location = New System.Drawing.Point(0, 325)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(936, 32)
        Me.Panel3.TabIndex = 66
        '
        'btn_prev
        '
        Me.btn_prev.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_prev.FlatAppearance.BorderSize = 0
        Me.btn_prev.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_prev.Image = Global.CAI.My.Resources.Resources.icons8_prev_48
        Me.btn_prev.Location = New System.Drawing.Point(861, 0)
        Me.btn_prev.Name = "btn_prev"
        Me.btn_prev.Size = New System.Drawing.Size(38, 31)
        Me.btn_prev.TabIndex = 2
        Me.btn_prev.UseVisualStyleBackColor = True
        '
        'btn_next
        '
        Me.btn_next.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_next.FlatAppearance.BorderSize = 0
        Me.btn_next.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_next.Image = Global.CAI.My.Resources.Resources.icons8_right_button_48
        Me.btn_next.Location = New System.Drawing.Point(898, 0)
        Me.btn_next.Name = "btn_next"
        Me.btn_next.Size = New System.Drawing.Size(38, 31)
        Me.btn_next.TabIndex = 1
        Me.btn_next.UseVisualStyleBackColor = True
        '
        'pagination
        '
        Me.pagination.AutoSize = True
        Me.pagination.ForeColor = System.Drawing.Color.White
        Me.pagination.Location = New System.Drawing.Point(14, 10)
        Me.pagination.Name = "pagination"
        Me.pagination.Size = New System.Drawing.Size(100, 16)
        Me.pagination.TabIndex = 0
        Me.pagination.Text = "Page 01 of 10"
        '
        'user_list
        '
        Me.user_list.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.user_list.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader5, Me.list_username, Me.ColumnHeader6, Me.ColumnHeader8, Me.ColumnHeader7})
        Me.user_list.FullRowSelect = True
        Me.user_list.GridLines = True
        Me.user_list.Location = New System.Drawing.Point(2, 1)
        Me.user_list.Name = "user_list"
        Me.user_list.Size = New System.Drawing.Size(934, 325)
        Me.user_list.TabIndex = 65
        Me.user_list.UseCompatibleStateImageBehavior = False
        Me.user_list.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader5
        '
        Me.ColumnHeader5.Text = "ID"
        Me.ColumnHeader5.Width = 0
        '
        'list_username
        '
        Me.list_username.Text = "USERNAME"
        Me.list_username.Width = 150
        '
        'ColumnHeader6
        '
        Me.ColumnHeader6.Text = "FULL NAME"
        Me.ColumnHeader6.Width = 300
        '
        'ColumnHeader8
        '
        Me.ColumnHeader8.Text = "ACCOUNT TYPE"
        Me.ColumnHeader8.Width = 140
        '
        'ColumnHeader7
        '
        Me.ColumnHeader7.Text = "REGISTERED SINCE"
        Me.ColumnHeader7.Width = 194
        '
        'ActionClose
        '
        Me.ActionClose.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ActionClose.BackColor = System.Drawing.Color.Transparent
        Me.ActionClose.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ActionClose.FlatAppearance.BorderSize = 0
        Me.ActionClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ActionClose.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ActionClose.ForeColor = System.Drawing.Color.White
        Me.ActionClose.Image = Global.CAI.My.Resources.Resources.icons8_back_48
        Me.ActionClose.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.ActionClose.Location = New System.Drawing.Point(1115, 130)
        Me.ActionClose.Name = "ActionClose"
        Me.ActionClose.Size = New System.Drawing.Size(85, 71)
        Me.ActionClose.TabIndex = 63
        Me.ActionClose.Text = "BACK"
        Me.ActionClose.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.ActionClose.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.ActionClose.UseVisualStyleBackColor = False
        '
        'BTNEdit
        '
        Me.BTNEdit.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BTNEdit.BackColor = System.Drawing.Color.Transparent
        Me.BTNEdit.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BTNEdit.Enabled = False
        Me.BTNEdit.FlatAppearance.BorderSize = 0
        Me.BTNEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BTNEdit.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTNEdit.ForeColor = System.Drawing.Color.White
        Me.BTNEdit.Image = Global.CAI.My.Resources.Resources.edit
        Me.BTNEdit.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.BTNEdit.Location = New System.Drawing.Point(941, 130)
        Me.BTNEdit.Name = "BTNEdit"
        Me.BTNEdit.Size = New System.Drawing.Size(85, 71)
        Me.BTNEdit.TabIndex = 62
        Me.BTNEdit.Text = "EDIT"
        Me.BTNEdit.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.BTNEdit.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.BTNEdit.UseVisualStyleBackColor = False
        '
        'BTNCreate
        '
        Me.BTNCreate.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BTNCreate.BackColor = System.Drawing.Color.Transparent
        Me.BTNCreate.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BTNCreate.FlatAppearance.BorderSize = 0
        Me.BTNCreate.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BTNCreate.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTNCreate.ForeColor = System.Drawing.Color.White
        Me.BTNCreate.Image = Global.CAI.My.Resources.Resources.add
        Me.BTNCreate.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.BTNCreate.Location = New System.Drawing.Point(854, 130)
        Me.BTNCreate.Name = "BTNCreate"
        Me.BTNCreate.Size = New System.Drawing.Size(85, 71)
        Me.BTNCreate.TabIndex = 61
        Me.BTNCreate.Text = "ADD"
        Me.BTNCreate.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.BTNCreate.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.BTNCreate.UseVisualStyleBackColor = False
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.ActionFilter)
        Me.GroupBox1.Controls.Add(Me.RoleFilter)
        Me.GroupBox1.Controls.Add(Me.Label10)
        Me.GroupBox1.Controls.Add(Me.KeywordFilter)
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.ForeColor = System.Drawing.Color.White
        Me.GroupBox1.Location = New System.Drawing.Point(12, 137)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(783, 49)
        Me.GroupBox1.TabIndex = 64
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "FILTERS"
        '
        'ActionFilter
        '
        Me.ActionFilter.BackColor = System.Drawing.Color.Transparent
        Me.ActionFilter.BackgroundImage = CType(resources.GetObject("ActionFilter.BackgroundImage"), System.Drawing.Image)
        Me.ActionFilter.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ActionFilter.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ActionFilter.FlatAppearance.BorderSize = 0
        Me.ActionFilter.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ActionFilter.Location = New System.Drawing.Point(744, 17)
        Me.ActionFilter.Name = "ActionFilter"
        Me.ActionFilter.Padding = New System.Windows.Forms.Padding(0, 0, 50, 10)
        Me.ActionFilter.Size = New System.Drawing.Size(26, 23)
        Me.ActionFilter.TabIndex = 61
        Me.ActionFilter.UseVisualStyleBackColor = False
        '
        'RoleFilter
        '
        Me.RoleFilter.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.RoleFilter.FormattingEnabled = True
        Me.RoleFilter.Items.AddRange(New Object() {"All", "Administrator", "Instructor", "Student"})
        Me.RoleFilter.Location = New System.Drawing.Point(553, 16)
        Me.RoleFilter.Name = "RoleFilter"
        Me.RoleFilter.Size = New System.Drawing.Size(173, 24)
        Me.RoleFilter.TabIndex = 60
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.White
        Me.Label10.Location = New System.Drawing.Point(436, 22)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(111, 13)
        Me.Label10.TabIndex = 59
        Me.Label10.Text = "ACCOUNT TYPE :"
        Me.Label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'KeywordFilter
        '
        Me.KeywordFilter.Location = New System.Drawing.Point(77, 17)
        Me.KeywordFilter.Name = "KeywordFilter"
        Me.KeywordFilter.Size = New System.Drawing.Size(272, 23)
        Me.KeywordFilter.TabIndex = 58
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.White
        Me.Label9.Location = New System.Drawing.Point(6, 22)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(65, 13)
        Me.Label9.TabIndex = 57
        Me.Label9.Text = "SEARCH :"
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'ColumnHeader4
        '
        Me.ColumnHeader4.Text = "asdfasdfasd"
        '
        'BTNTrash
        '
        Me.BTNTrash.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BTNTrash.BackColor = System.Drawing.Color.Transparent
        Me.BTNTrash.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BTNTrash.Enabled = False
        Me.BTNTrash.FlatAppearance.BorderSize = 0
        Me.BTNTrash.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BTNTrash.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTNTrash.ForeColor = System.Drawing.Color.White
        Me.BTNTrash.Image = Global.CAI.My.Resources.Resources.trash
        Me.BTNTrash.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.BTNTrash.Location = New System.Drawing.Point(1028, 130)
        Me.BTNTrash.Name = "BTNTrash"
        Me.BTNTrash.Size = New System.Drawing.Size(85, 71)
        Me.BTNTrash.TabIndex = 65
        Me.BTNTrash.Text = "DELETE"
        Me.BTNTrash.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.BTNTrash.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.BTNTrash.UseVisualStyleBackColor = False
        '
        'Heading1
        '
        Me.Heading1.BackColor = System.Drawing.Color.White
        Me.Heading1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Heading1.Font = New System.Drawing.Font("Verdana", 8.25!)
        Me.Heading1.Location = New System.Drawing.Point(0, 0)
        Me.Heading1.Name = "Heading1"
        Me.Heading1.Size = New System.Drawing.Size(1202, 127)
        Me.Heading1.TabIndex = 4
        Me.Heading1.Title = "ACCOUNT MANAGEMENT"
        '
        'UserListRev2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Green
        Me.ClientSize = New System.Drawing.Size(1202, 562)
        Me.Controls.Add(Me.BTNTrash)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.ActionClose)
        Me.Controls.Add(Me.BTNEdit)
        Me.Controls.Add(Me.BTNCreate)
        Me.Controls.Add(Me.Heading1)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.MinimumSize = New System.Drawing.Size(1000, 600)
        Me.Name = "UserListRev2"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "ACCOUNTS"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.UserDetailWrapper.ResumeLayout(False)
        Me.UserDetailWrapper.PerformLayout()
        CType(Me.pict_user_pict, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents UserDetailWrapper As Panel
    Friend WithEvents LabelDisplayRegisteredSince As Label
    Friend WithEvents pict_user_pict As PictureBox
    Friend WithEvents Heading1 As Heading
    Friend WithEvents LabelDisplayUsername As Label
    Friend WithEvents LabelDisplayFullName As Label
    Friend WithEvents LabelDisplayAccountType As Label
    Friend WithEvents DisplayAccountType As Label
    Friend WithEvents DisplayFullName As Label
    Friend WithEvents DisplayUsername As Label
    Friend WithEvents DisplayRegisteredSince As Label
    Friend WithEvents BTNPreview As Button
    Friend WithEvents BTNApprovedBlocked As Button
    Friend WithEvents ActionClose As Button
    Friend WithEvents BTNEdit As Button
    Friend WithEvents BTNCreate As Button
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label9 As Label
    Friend WithEvents RoleFilter As ComboBox
    Friend WithEvents Label10 As Label
    Friend WithEvents KeywordFilter As TextBox
    Friend WithEvents ActionFilter As Button
    Friend WithEvents ColumnHeader1 As ColumnHeader
    Friend WithEvents ColumnHeader2 As ColumnHeader
    Friend WithEvents ColumnHeader3 As ColumnHeader
    Friend WithEvents ColumnHeader4 As ColumnHeader
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel3 As Panel
    Friend WithEvents btn_prev As Button
    Friend WithEvents btn_next As Button
    Friend WithEvents pagination As Label
    Friend WithEvents user_list As ListView
    Friend WithEvents ColumnHeader5 As ColumnHeader
    Friend WithEvents list_username As ColumnHeader
    Friend WithEvents ColumnHeader6 As ColumnHeader
    Friend WithEvents ColumnHeader7 As ColumnHeader
    Friend WithEvents ColumnHeader8 As ColumnHeader
    Friend WithEvents ActionHideUserDetailWrapper As Button
    Friend WithEvents BTNTrash As Button
End Class
