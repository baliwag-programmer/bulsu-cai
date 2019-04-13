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
        Me.ShapeContainer1 = New Microsoft.VisualBasic.PowerPacks.ShapeContainer()
        Me.LineShape1 = New Microsoft.VisualBasic.PowerPacks.LineShape()
        Me.GroupBox1.SuspendLayout()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'lbl_question
        '
        Me.lbl_question.Dock = System.Windows.Forms.DockStyle.Top
        Me.lbl_question.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_question.Location = New System.Drawing.Point(0, 0)
        Me.lbl_question.Name = "lbl_question"
        Me.lbl_question.Padding = New System.Windows.Forms.Padding(19, 0, 0, 0)
        Me.lbl_question.Size = New System.Drawing.Size(927, 38)
        Me.lbl_question.TabIndex = 0
        Me.lbl_question.Text = "1.) Test question ?"
        Me.lbl_question.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox1.Controls.Add(Me.TableLayoutPanel1)
        Me.GroupBox1.Controls.Add(Me.ShapeContainer1)
        Me.GroupBox1.ForeColor = System.Drawing.Color.White
        Me.GroupBox1.Location = New System.Drawing.Point(-11, 28)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.GroupBox1.Size = New System.Drawing.Size(952, 178)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.BackColor = System.Drawing.Color.Transparent
        Me.TableLayoutPanel1.ColumnCount = 2
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.rad_d, 1, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.rad_c, 0, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.rad_b, 1, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.rad_a, 0, 0)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(3, 20)
        Me.TableLayoutPanel1.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.TableLayoutPanel1.MaximumSize = New System.Drawing.Size(0, 290)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 2
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 46.875!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 53.125!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(946, 154)
        Me.TableLayoutPanel1.TabIndex = 0
        '
        'rad_d
        '
        Me.rad_d.AutoSize = True
        Me.rad_d.Dock = System.Windows.Forms.DockStyle.Fill
        Me.rad_d.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rad_d.ForeColor = System.Drawing.Color.White
        Me.rad_d.Location = New System.Drawing.Point(476, 76)
        Me.rad_d.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.rad_d.Name = "rad_d"
        Me.rad_d.Padding = New System.Windows.Forms.Padding(19, 0, 0, 0)
        Me.rad_d.Size = New System.Drawing.Size(467, 74)
        Me.rad_d.TabIndex = 3
        Me.rad_d.TabStop = True
        Me.rad_d.UseVisualStyleBackColor = True
        '
        'rad_c
        '
        Me.rad_c.AutoSize = True
        Me.rad_c.Dock = System.Windows.Forms.DockStyle.Fill
        Me.rad_c.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rad_c.ForeColor = System.Drawing.Color.White
        Me.rad_c.Location = New System.Drawing.Point(3, 76)
        Me.rad_c.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.rad_c.Name = "rad_c"
        Me.rad_c.Padding = New System.Windows.Forms.Padding(19, 0, 0, 0)
        Me.rad_c.Size = New System.Drawing.Size(467, 74)
        Me.rad_c.TabIndex = 2
        Me.rad_c.TabStop = True
        Me.rad_c.UseVisualStyleBackColor = True
        '
        'rad_b
        '
        Me.rad_b.AutoSize = True
        Me.rad_b.Dock = System.Windows.Forms.DockStyle.Fill
        Me.rad_b.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rad_b.ForeColor = System.Drawing.Color.White
        Me.rad_b.Location = New System.Drawing.Point(476, 4)
        Me.rad_b.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.rad_b.Name = "rad_b"
        Me.rad_b.Padding = New System.Windows.Forms.Padding(19, 0, 0, 0)
        Me.rad_b.Size = New System.Drawing.Size(467, 64)
        Me.rad_b.TabIndex = 1
        Me.rad_b.TabStop = True
        Me.rad_b.UseVisualStyleBackColor = True
        '
        'rad_a
        '
        Me.rad_a.AutoSize = True
        Me.rad_a.Dock = System.Windows.Forms.DockStyle.Fill
        Me.rad_a.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rad_a.ForeColor = System.Drawing.Color.White
        Me.rad_a.Location = New System.Drawing.Point(3, 4)
        Me.rad_a.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.rad_a.Name = "rad_a"
        Me.rad_a.Padding = New System.Windows.Forms.Padding(19, 0, 0, 0)
        Me.rad_a.Size = New System.Drawing.Size(467, 64)
        Me.rad_a.TabIndex = 0
        Me.rad_a.TabStop = True
        Me.rad_a.UseVisualStyleBackColor = True
        '
        'ShapeContainer1
        '
        Me.ShapeContainer1.Location = New System.Drawing.Point(3, 20)
        Me.ShapeContainer1.Margin = New System.Windows.Forms.Padding(0)
        Me.ShapeContainer1.Name = "ShapeContainer1"
        Me.ShapeContainer1.Shapes.AddRange(New Microsoft.VisualBasic.PowerPacks.Shape() {Me.LineShape1})
        Me.ShapeContainer1.Size = New System.Drawing.Size(946, 154)
        Me.ShapeContainer1.TabIndex = 1
        Me.ShapeContainer1.TabStop = False
        '
        'LineShape1
        '
        Me.LineShape1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LineShape1.BorderColor = System.Drawing.Color.White
        Me.LineShape1.Name = "LineShape1"
        Me.LineShape1.X1 = 6
        Me.LineShape1.X2 = 940
        Me.LineShape1.Y1 = 19
        Me.LineShape1.Y2 = 19
        '
        'MultipleChoice
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.lbl_question)
        Me.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "MultipleChoice"
        Me.Size = New System.Drawing.Size(927, 197)
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
    Private WithEvents ShapeContainer1 As PowerPacks.ShapeContainer
    Private WithEvents LineShape1 As PowerPacks.LineShape
End Class
