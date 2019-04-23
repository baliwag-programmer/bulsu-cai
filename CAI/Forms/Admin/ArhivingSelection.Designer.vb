<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ArhivingSelection
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
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.user_list = New System.Windows.Forms.ListView()
        Me.ColumnHeader2 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader5 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader6 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader7 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.BTNArchive = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Heading1 = New CAI.Heading()
        Me.ColumnHeader1 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Panel1.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel1.Controls.Add(Me.user_list)
        Me.Panel1.Location = New System.Drawing.Point(0, 236)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(863, 310)
        Me.Panel1.TabIndex = 29
        '
        'user_list
        '
        Me.user_list.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.user_list.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1, Me.ColumnHeader2, Me.ColumnHeader5, Me.ColumnHeader6, Me.ColumnHeader7})
        Me.user_list.FullRowSelect = True
        Me.user_list.GridLines = True
        Me.user_list.Location = New System.Drawing.Point(0, 0)
        Me.user_list.Name = "user_list"
        Me.user_list.Size = New System.Drawing.Size(863, 310)
        Me.user_list.TabIndex = 2
        Me.user_list.UseCompatibleStateImageBehavior = False
        Me.user_list.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader2
        '
        Me.ColumnHeader2.Text = "SCHOOL YEAR"
        Me.ColumnHeader2.Width = 167
        '
        'ColumnHeader5
        '
        Me.ColumnHeader5.Text = "YEAR"
        Me.ColumnHeader5.Width = 63
        '
        'ColumnHeader6
        '
        Me.ColumnHeader6.Text = "NUMBER OF SECTIONS"
        Me.ColumnHeader6.Width = 167
        '
        'ColumnHeader7
        '
        Me.ColumnHeader7.Text = "TOTAL NUMBER OF STUDENTS"
        Me.ColumnHeader7.Width = 208
        '
        'BTNArchive
        '
        Me.BTNArchive.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BTNArchive.BackColor = System.Drawing.Color.Transparent
        Me.BTNArchive.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BTNArchive.Enabled = False
        Me.BTNArchive.FlatAppearance.BorderSize = 0
        Me.BTNArchive.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BTNArchive.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTNArchive.ForeColor = System.Drawing.Color.White
        Me.BTNArchive.Image = Global.CAI.My.Resources.Resources.icons8_ok_48
        Me.BTNArchive.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.BTNArchive.Location = New System.Drawing.Point(765, 146)
        Me.BTNArchive.Name = "BTNArchive"
        Me.BTNArchive.Size = New System.Drawing.Size(85, 71)
        Me.BTNArchive.TabIndex = 63
        Me.BTNArchive.Text = "ARCHIVE"
        Me.BTNArchive.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.BTNArchive.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.BTNArchive.UseVisualStyleBackColor = False
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.ForeColor = System.Drawing.Color.White
        Me.GroupBox1.Location = New System.Drawing.Point(12, 146)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(469, 71)
        Me.GroupBox1.TabIndex = 64
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "NOTICE"
        '
        'Label8
        '
        Me.Label8.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label8.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(3, 17)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(463, 51)
        Me.Label8.TabIndex = 58
        Me.Label8.Text = "After archiving the data will is not going to be available but it is not been del" &
    "eted instead the application will put it into a file that stores the selected ba" &
    "tch to be archived."
        '
        'Heading1
        '
        Me.Heading1.BackColor = System.Drawing.Color.White
        Me.Heading1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Heading1.Font = New System.Drawing.Font("Verdana", 8.25!)
        Me.Heading1.Location = New System.Drawing.Point(0, 0)
        Me.Heading1.Name = "Heading1"
        Me.Heading1.Size = New System.Drawing.Size(862, 127)
        Me.Heading1.TabIndex = 6
        Me.Heading1.Title = "BATCH SELECTION"
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Width = 0
        '
        'ArhivingSelection
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Green
        Me.ClientSize = New System.Drawing.Size(862, 546)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.BTNArchive)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Heading1)
        Me.Font = New System.Drawing.Font("Verdana", 8.25!)
        Me.ForeColor = System.Drawing.Color.White
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "ArhivingSelection"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "ARCHIVING SELECTION"
        Me.Panel1.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Heading1 As Heading
    Friend WithEvents Panel1 As Panel
    Friend WithEvents user_list As ListView
    Friend WithEvents ColumnHeader2 As ColumnHeader
    Friend WithEvents ColumnHeader5 As ColumnHeader
    Friend WithEvents ColumnHeader6 As ColumnHeader
    Friend WithEvents ColumnHeader7 As ColumnHeader
    Friend WithEvents BTNArchive As Button
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label8 As Label
    Friend WithEvents ColumnHeader1 As ColumnHeader
End Class
