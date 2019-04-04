<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Identification
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
        Me.lbl_number = New System.Windows.Forms.Label()
        Me.txt_answer = New System.Windows.Forms.TextBox()
        Me.lbl_main_question = New System.Windows.Forms.Label()
        Me.ShapeContainer1 = New Microsoft.VisualBasic.PowerPacks.ShapeContainer()
        Me.LineShape1 = New Microsoft.VisualBasic.PowerPacks.LineShape()
        Me.LineShape2 = New Microsoft.VisualBasic.PowerPacks.LineShape()
        Me.SuspendLayout()
        '
        'lbl_number
        '
        Me.lbl_number.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_number.Location = New System.Drawing.Point(0, 0)
        Me.lbl_number.Name = "lbl_number"
        Me.lbl_number.Padding = New System.Windows.Forms.Padding(15, 15, 0, 0)
        Me.lbl_number.Size = New System.Drawing.Size(284, 44)
        Me.lbl_number.TabIndex = 1
        Me.lbl_number.Text = "1. )"
        '
        'txt_answer
        '
        Me.txt_answer.Location = New System.Drawing.Point(42, 12)
        Me.txt_answer.Name = "txt_answer"
        Me.txt_answer.Size = New System.Drawing.Size(239, 21)
        Me.txt_answer.TabIndex = 2
        '
        'lbl_main_question
        '
        Me.lbl_main_question.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lbl_main_question.BackColor = System.Drawing.Color.Transparent
        Me.lbl_main_question.Location = New System.Drawing.Point(287, 15)
        Me.lbl_main_question.Name = "lbl_main_question"
        Me.lbl_main_question.Size = New System.Drawing.Size(403, 13)
        Me.lbl_main_question.TabIndex = 3
        '
        'ShapeContainer1
        '
        Me.ShapeContainer1.Location = New System.Drawing.Point(0, 0)
        Me.ShapeContainer1.Margin = New System.Windows.Forms.Padding(0)
        Me.ShapeContainer1.Name = "ShapeContainer1"
        Me.ShapeContainer1.Shapes.AddRange(New Microsoft.VisualBasic.PowerPacks.Shape() {Me.LineShape2, Me.LineShape1})
        Me.ShapeContainer1.Size = New System.Drawing.Size(693, 44)
        Me.ShapeContainer1.TabIndex = 4
        Me.ShapeContainer1.TabStop = False
        '
        'LineShape1
        '
        Me.LineShape1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LineShape1.BorderColor = System.Drawing.Color.White
        Me.LineShape1.Name = "LineShape1"
        Me.LineShape1.X1 = -2
        Me.LineShape1.X2 = 698
        Me.LineShape1.Y1 = 43
        Me.LineShape1.Y2 = 43
        '
        'LineShape2
        '
        Me.LineShape2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LineShape2.BorderColor = System.Drawing.Color.White
        Me.LineShape2.Name = "LineShape2"
        Me.LineShape2.X1 = -4
        Me.LineShape2.X2 = 696
        Me.LineShape2.Y1 = 1
        Me.LineShape2.Y2 = 1
        '
        'Identification
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.Controls.Add(Me.lbl_main_question)
        Me.Controls.Add(Me.txt_answer)
        Me.Controls.Add(Me.ShapeContainer1)
        Me.Controls.Add(Me.lbl_number)
        Me.Font = New System.Drawing.Font("Tahoma", 8.25!)
        Me.Name = "Identification"
        Me.Padding = New System.Windows.Forms.Padding(0, 0, 0, 10)
        Me.Size = New System.Drawing.Size(693, 54)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lbl_number As System.Windows.Forms.Label
    Friend WithEvents txt_answer As System.Windows.Forms.TextBox
    Friend WithEvents lbl_main_question As System.Windows.Forms.Label
    Friend WithEvents ShapeContainer1 As Microsoft.VisualBasic.PowerPacks.ShapeContainer
    Friend WithEvents LineShape1 As Microsoft.VisualBasic.PowerPacks.LineShape
    Friend WithEvents LineShape2 As Microsoft.VisualBasic.PowerPacks.LineShape

End Class
