<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Enumeration
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
        Me.lbl_main_question = New System.Windows.Forms.Label()
        Me.lbl_number = New System.Windows.Forms.Label()
        Me.AsnwerContainer = New System.Windows.Forms.Panel()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.AsnwerContainer.SuspendLayout()
        Me.SuspendLayout()
        '
        'lbl_main_question
        '
        Me.lbl_main_question.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lbl_main_question.BackColor = System.Drawing.Color.Transparent
        Me.lbl_main_question.Location = New System.Drawing.Point(56, 0)
        Me.lbl_main_question.Name = "lbl_main_question"
        Me.lbl_main_question.Size = New System.Drawing.Size(634, 44)
        Me.lbl_main_question.TabIndex = 5
        Me.lbl_main_question.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lbl_number
        '
        Me.lbl_number.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_number.Location = New System.Drawing.Point(-3, 0)
        Me.lbl_number.Name = "lbl_number"
        Me.lbl_number.Padding = New System.Windows.Forms.Padding(15, 15, 0, 0)
        Me.lbl_number.Size = New System.Drawing.Size(53, 44)
        Me.lbl_number.TabIndex = 4
        Me.lbl_number.Text = "1. )"
        '
        'AsnwerContainer
        '
        Me.AsnwerContainer.Controls.Add(Me.TextBox1)
        Me.AsnwerContainer.Location = New System.Drawing.Point(3, 47)
        Me.AsnwerContainer.Name = "AsnwerContainer"
        Me.AsnwerContainer.Size = New System.Drawing.Size(687, 164)
        Me.AsnwerContainer.TabIndex = 6
        '
        'TextBox1
        '
        Me.TextBox1.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox1.Location = New System.Drawing.Point(3, 3)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(257, 27)
        Me.TextBox1.TabIndex = 0
        '
        'Enumeration
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.AsnwerContainer)
        Me.Controls.Add(Me.lbl_main_question)
        Me.Controls.Add(Me.lbl_number)
        Me.Font = New System.Drawing.Font("Tahoma", 8.25!)
        Me.Name = "Enumeration"
        Me.Size = New System.Drawing.Size(693, 214)
        Me.AsnwerContainer.ResumeLayout(False)
        Me.AsnwerContainer.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents lbl_main_question As System.Windows.Forms.Label
    Friend WithEvents lbl_number As System.Windows.Forms.Label
    Friend WithEvents AsnwerContainer As System.Windows.Forms.Panel
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox

End Class
