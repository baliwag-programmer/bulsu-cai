<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class TestTaker
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
        Me.lbl_date = New System.Windows.Forms.Label()
        Me.lbl_time = New System.Windows.Forms.Label()
        Me.BTNSave = New System.Windows.Forms.Button()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.lbl_title = New System.Windows.Forms.Label()
        Me.question_container = New System.Windows.Forms.Panel()
        Me.TXTInstruction = New System.Windows.Forms.Label()
        Me.lock_container = New System.Windows.Forms.Panel()
        Me.lbl_indicator = New System.Windows.Forms.Label()
        Me.img_lock_indication = New System.Windows.Forms.PictureBox()
        Me.Panel1.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.question_container.SuspendLayout()
        Me.lock_container.SuspendLayout()
        CType(Me.img_lock_indication, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Panel1.Controls.Add(Me.lbl_date)
        Me.Panel1.Controls.Add(Me.lbl_time)
        Me.Panel1.Controls.Add(Me.BTNSave)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel1.Location = New System.Drawing.Point(0, 431)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(766, 61)
        Me.Panel1.TabIndex = 0
        '
        'lbl_date
        '
        Me.lbl_date.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.lbl_date.AutoSize = True
        Me.lbl_date.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_date.Location = New System.Drawing.Point(15, 34)
        Me.lbl_date.Name = "lbl_date"
        Me.lbl_date.Size = New System.Drawing.Size(222, 16)
        Me.lbl_date.TabIndex = 13
        Me.lbl_date.Text = "Wednesday January 01, 2018"
        '
        'lbl_time
        '
        Me.lbl_time.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.lbl_time.AutoSize = True
        Me.lbl_time.Font = New System.Drawing.Font("Verdana", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_time.Location = New System.Drawing.Point(12, 2)
        Me.lbl_time.Name = "lbl_time"
        Me.lbl_time.Size = New System.Drawing.Size(151, 32)
        Me.lbl_time.TabIndex = 12
        Me.lbl_time.Text = "00:00:00"
        '
        'BTNSave
        '
        Me.BTNSave.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BTNSave.BackColor = System.Drawing.Color.YellowGreen
        Me.BTNSave.FlatAppearance.BorderColor = System.Drawing.Color.Green
        Me.BTNSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BTNSave.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.BTNSave.Location = New System.Drawing.Point(641, 0)
        Me.BTNSave.Name = "BTNSave"
        Me.BTNSave.Size = New System.Drawing.Size(125, 61)
        Me.BTNSave.TabIndex = 11
        Me.BTNSave.Text = "DONE"
        Me.BTNSave.UseVisualStyleBackColor = False
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.DarkGreen
        Me.Panel3.Controls.Add(Me.lbl_title)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel3.Location = New System.Drawing.Point(0, 0)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(766, 61)
        Me.Panel3.TabIndex = 2
        '
        'lbl_title
        '
        Me.lbl_title.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lbl_title.Font = New System.Drawing.Font("Verdana", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_title.Location = New System.Drawing.Point(3, 14)
        Me.lbl_title.Name = "lbl_title"
        Me.lbl_title.Size = New System.Drawing.Size(763, 32)
        Me.lbl_title.TabIndex = 13
        Me.lbl_title.Text = "TEST TITLE"
        Me.lbl_title.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'question_container
        '
        Me.question_container.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.question_container.AutoScroll = True
        Me.question_container.BackColor = System.Drawing.Color.Transparent
        Me.question_container.Controls.Add(Me.TXTInstruction)
        Me.question_container.Location = New System.Drawing.Point(-2, 60)
        Me.question_container.Name = "question_container"
        Me.question_container.Size = New System.Drawing.Size(768, 372)
        Me.question_container.TabIndex = 3
        '
        'TXTInstruction
        '
        Me.TXTInstruction.AutoSize = True
        Me.TXTInstruction.Dock = System.Windows.Forms.DockStyle.Top
        Me.TXTInstruction.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TXTInstruction.Location = New System.Drawing.Point(0, 0)
        Me.TXTInstruction.Name = "TXTInstruction"
        Me.TXTInstruction.Padding = New System.Windows.Forms.Padding(15, 15, 15, 0)
        Me.TXTInstruction.Size = New System.Drawing.Size(127, 31)
        Me.TXTInstruction.TabIndex = 0
        Me.TXTInstruction.Text = "Instruction :"
        '
        'lock_container
        '
        Me.lock_container.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lock_container.BackColor = System.Drawing.Color.Transparent
        Me.lock_container.Controls.Add(Me.lbl_indicator)
        Me.lock_container.Controls.Add(Me.img_lock_indication)
        Me.lock_container.Location = New System.Drawing.Point(1, 0)
        Me.lock_container.Name = "lock_container"
        Me.lock_container.Size = New System.Drawing.Size(765, 492)
        Me.lock_container.TabIndex = 4
        '
        'lbl_indicator
        '
        Me.lbl_indicator.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lbl_indicator.Font = New System.Drawing.Font("Verdana", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_indicator.Location = New System.Drawing.Point(-1, 6)
        Me.lbl_indicator.Name = "lbl_indicator"
        Me.lbl_indicator.Size = New System.Drawing.Size(766, 163)
        Me.lbl_indicator.TabIndex = 1
        Me.lbl_indicator.Text = "TEST CURRENTLY LOCKED"
        Me.lbl_indicator.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'img_lock_indication
        '
        Me.img_lock_indication.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.img_lock_indication.Image = Global.CAI.My.Resources.Resources.icons8_lock_96
        Me.img_lock_indication.Location = New System.Drawing.Point(321, 186)
        Me.img_lock_indication.Name = "img_lock_indication"
        Me.img_lock_indication.Size = New System.Drawing.Size(123, 121)
        Me.img_lock_indication.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.img_lock_indication.TabIndex = 0
        Me.img_lock_indication.TabStop = False
        '
        'TestTaker
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Green
        Me.ClientSize = New System.Drawing.Size(766, 492)
        Me.Controls.Add(Me.lock_container)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.question_container)
        Me.Controls.Add(Me.Panel1)
        Me.Font = New System.Drawing.Font("Verdana", 8.25!)
        Me.ForeColor = System.Drawing.Color.White
        Me.Name = "TestTaker"
        Me.RightToLeftLayout = True
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        Me.question_container.ResumeLayout(False)
        Me.question_container.PerformLayout()
        Me.lock_container.ResumeLayout(False)
        CType(Me.img_lock_indication, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents BTNSave As System.Windows.Forms.Button
    Friend WithEvents lbl_time As System.Windows.Forms.Label
    Friend WithEvents lbl_date As System.Windows.Forms.Label
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents lbl_title As System.Windows.Forms.Label
    Friend WithEvents question_container As System.Windows.Forms.Panel
    Friend WithEvents lock_container As System.Windows.Forms.Panel
    Friend WithEvents lbl_indicator As System.Windows.Forms.Label
    Friend WithEvents img_lock_indication As System.Windows.Forms.PictureBox
    Friend WithEvents TXTInstruction As System.Windows.Forms.Label
End Class
