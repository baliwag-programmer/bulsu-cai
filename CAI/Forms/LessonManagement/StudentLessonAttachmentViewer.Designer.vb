<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class StudentLessonAttachmentViewer
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
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.AttachmentViewer1 = New CAI.AttachmentViewer()
        Me.Heading1 = New CAI.Heading()
        Me.Panel3.SuspendLayout()
        Me.SuspendLayout()
        '
        'Button1
        '
        Me.Button1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Button1.BackColor = System.Drawing.Color.Transparent
        Me.Button1.FlatAppearance.BorderSize = 0
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.Color.White
        Me.Button1.Image = Global.CAI.My.Resources.Resources.icons8_back_48
        Me.Button1.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.Button1.Location = New System.Drawing.Point(12, 644)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(73, 74)
        Me.Button1.TabIndex = 21
        Me.Button1.Text = "BACK"
        Me.Button1.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.Button1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Panel1
        '
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(780, 85)
        Me.Panel1.TabIndex = 1
        '
        'Panel3
        '
        Me.Panel3.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Panel3.BackColor = System.Drawing.Color.Transparent
        Me.Panel3.BackgroundImage = Global.CAI.My.Resources.Resources.lessonviewer1
        Me.Panel3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Panel3.Controls.Add(Me.AttachmentViewer1)
        Me.Panel3.Location = New System.Drawing.Point(-56, 62)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(893, 742)
        Me.Panel3.TabIndex = 2
        '
        'AttachmentViewer1
        '
        Me.AttachmentViewer1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.AttachmentViewer1.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.AttachmentViewer1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.AttachmentViewer1.Font = New System.Drawing.Font("Verdana", 8.25!)
        Me.AttachmentViewer1.Location = New System.Drawing.Point(241, 213)
        Me.AttachmentViewer1.Name = "AttachmentViewer1"
        Me.AttachmentViewer1.SelectedFile = ""
        Me.AttachmentViewer1.Size = New System.Drawing.Size(405, 253)
        Me.AttachmentViewer1.TabIndex = 0
        '
        'Heading1
        '
        Me.Heading1.BackColor = System.Drawing.Color.White
        Me.Heading1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Heading1.Font = New System.Drawing.Font("Verdana", 8.25!)
        Me.Heading1.Location = New System.Drawing.Point(0, 0)
        Me.Heading1.Name = "Heading1"
        Me.Heading1.Size = New System.Drawing.Size(780, 127)
        Me.Heading1.TabIndex = 22
        Me.Heading1.Title = "LESSON VIEWER"
        '
        'StudentLessonAttachmentViewer
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Green
        Me.ClientSize = New System.Drawing.Size(780, 730)
        Me.Controls.Add(Me.Heading1)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Panel3)
        Me.Name = "StudentLessonAttachmentViewer"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "StudentLessonAttachmentViewer"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.Panel3.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents AttachmentViewer1 As CAI.AttachmentViewer
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Heading1 As Heading
End Class
