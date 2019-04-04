<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MultipleChoice
    Inherits System.Windows.Forms.UserControl

    'UserControl overrides dispose to clean up the component list.
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
        Me.lbl_question = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.rad_d = New System.Windows.Forms.RadioButton()
        Me.rad_c = New System.Windows.Forms.RadioButton()
        Me.rad_b = New System.Windows.Forms.RadioButton()
        Me.rad_a = New System.Windows.Forms.RadioButton()
        Me.GroupBox1.SuspendLayout()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'lbl_question
        '
        Me.lbl_question.Dock = System.Windows.Forms.DockStyle.Top
        Me.lbl_question.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_question.Location = New System.Drawing.Point(0, 0)
        Me.lbl_question.Name = "lbl_question"
        Me.lbl_question.Padding = New System.Windows.Forms.Padding(15, 15, 0, 0)
        Me.lbl_question.Size = New System.Drawing.Size(699, 62)
        Me.lbl_question.TabIndex = 0
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox1.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.GroupBox1.Controls.Add(Me.TableLayoutPanel1)
        Me.GroupBox1.Location = New System.Drawing.Point(0, 48)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(699, 256)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 2
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.rad_d, 1, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.rad_c, 0, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.rad_b, 1, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.rad_a, 0, 0)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(3, 17)
        Me.TableLayoutPanel1.MaximumSize = New System.Drawing.Size(0, 236)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 2
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(693, 236)
        Me.TableLayoutPanel1.TabIndex = 0
        '
        'rad_d
        '
        Me.rad_d.AutoSize = True
        Me.rad_d.Dock = System.Windows.Forms.DockStyle.Fill
        Me.rad_d.Location = New System.Drawing.Point(349, 121)
        Me.rad_d.Name = "rad_d"
        Me.rad_d.Padding = New System.Windows.Forms.Padding(15, 0, 0, 0)
        Me.rad_d.Size = New System.Drawing.Size(341, 112)
        Me.rad_d.TabIndex = 3
        Me.rad_d.TabStop = True
        Me.rad_d.UseVisualStyleBackColor = True
        '
        'rad_c
        '
        Me.rad_c.AutoSize = True
        Me.rad_c.Dock = System.Windows.Forms.DockStyle.Fill
        Me.rad_c.Location = New System.Drawing.Point(3, 121)
        Me.rad_c.Name = "rad_c"
        Me.rad_c.Padding = New System.Windows.Forms.Padding(15, 0, 0, 0)
        Me.rad_c.Size = New System.Drawing.Size(340, 112)
        Me.rad_c.TabIndex = 2
        Me.rad_c.TabStop = True
        Me.rad_c.UseVisualStyleBackColor = True
        '
        'rad_b
        '
        Me.rad_b.AutoSize = True
        Me.rad_b.Dock = System.Windows.Forms.DockStyle.Fill
        Me.rad_b.Location = New System.Drawing.Point(349, 3)
        Me.rad_b.Name = "rad_b"
        Me.rad_b.Padding = New System.Windows.Forms.Padding(15, 0, 0, 0)
        Me.rad_b.Size = New System.Drawing.Size(341, 112)
        Me.rad_b.TabIndex = 1
        Me.rad_b.TabStop = True
        Me.rad_b.UseVisualStyleBackColor = True
        '
        'rad_a
        '
        Me.rad_a.AutoSize = True
        Me.rad_a.Dock = System.Windows.Forms.DockStyle.Fill
        Me.rad_a.Location = New System.Drawing.Point(3, 3)
        Me.rad_a.Name = "rad_a"
        Me.rad_a.Padding = New System.Windows.Forms.Padding(15, 0, 0, 0)
        Me.rad_a.Size = New System.Drawing.Size(340, 112)
        Me.rad_a.TabIndex = 0
        Me.rad_a.TabStop = True
        Me.rad_a.UseVisualStyleBackColor = True
        '
        'MultipleChoice
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.lbl_question)
        Me.Controls.Add(Me.GroupBox1)
        Me.Font = New System.Drawing.Font("Tahoma", 8.25!)
        Me.Name = "MultipleChoice"
        Me.Size = New System.Drawing.Size(699, 304)
        Me.GroupBox1.ResumeLayout(False)
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents lbl_question As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents TableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents rad_d As System.Windows.Forms.RadioButton
    Friend WithEvents rad_c As System.Windows.Forms.RadioButton
    Friend WithEvents rad_b As System.Windows.Forms.RadioButton
    Friend WithEvents rad_a As System.Windows.Forms.RadioButton

End Class
