﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class StudentTestResult
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
        Me.ListContainer = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.lesson_prev = New System.Windows.Forms.Button()
        Me.lesson_next = New System.Windows.Forms.Button()
        Me.lesson_page = New System.Windows.Forms.Label()
        Me.test_list = New System.Windows.Forms.ListView()
        Me.ColumnHeader1 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader5 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader6 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader2 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader3 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader4 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.ListContainer.SuspendLayout()
        Me.Panel2.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ListContainer
        '
        Me.ListContainer.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ListContainer.Controls.Add(Me.Panel2)
        Me.ListContainer.Controls.Add(Me.test_list)
        Me.ListContainer.Location = New System.Drawing.Point(-1, 101)
        Me.ListContainer.Name = "ListContainer"
        Me.ListContainer.Size = New System.Drawing.Size(990, 461)
        Me.ListContainer.TabIndex = 27
        '
        'Panel2
        '
        Me.Panel2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel2.BackColor = System.Drawing.Color.Gray
        Me.Panel2.Controls.Add(Me.lesson_prev)
        Me.Panel2.Controls.Add(Me.lesson_next)
        Me.Panel2.Controls.Add(Me.lesson_page)
        Me.Panel2.Location = New System.Drawing.Point(0, 429)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(990, 32)
        Me.Panel2.TabIndex = 3
        '
        'lesson_prev
        '
        Me.lesson_prev.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lesson_prev.FlatAppearance.BorderSize = 0
        Me.lesson_prev.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.lesson_prev.Image = Global.CAI.My.Resources.Resources.icons8_prev_48
        Me.lesson_prev.Location = New System.Drawing.Point(915, 0)
        Me.lesson_prev.Name = "lesson_prev"
        Me.lesson_prev.Size = New System.Drawing.Size(38, 31)
        Me.lesson_prev.TabIndex = 2
        Me.lesson_prev.UseVisualStyleBackColor = True
        '
        'lesson_next
        '
        Me.lesson_next.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lesson_next.FlatAppearance.BorderSize = 0
        Me.lesson_next.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.lesson_next.Image = Global.CAI.My.Resources.Resources.icons8_right_button_48
        Me.lesson_next.Location = New System.Drawing.Point(952, 0)
        Me.lesson_next.Name = "lesson_next"
        Me.lesson_next.Size = New System.Drawing.Size(38, 31)
        Me.lesson_next.TabIndex = 1
        Me.lesson_next.UseVisualStyleBackColor = True
        '
        'lesson_page
        '
        Me.lesson_page.AutoSize = True
        Me.lesson_page.Location = New System.Drawing.Point(14, 10)
        Me.lesson_page.Name = "lesson_page"
        Me.lesson_page.Size = New System.Drawing.Size(86, 13)
        Me.lesson_page.TabIndex = 0
        Me.lesson_page.Text = "Page 01 of 10"
        '
        'test_list
        '
        Me.test_list.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.test_list.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1, Me.ColumnHeader5, Me.ColumnHeader6, Me.ColumnHeader2, Me.ColumnHeader3, Me.ColumnHeader4})
        Me.test_list.FullRowSelect = True
        Me.test_list.GridLines = True
        Me.test_list.Location = New System.Drawing.Point(0, 0)
        Me.test_list.Name = "test_list"
        Me.test_list.Size = New System.Drawing.Size(990, 431)
        Me.test_list.TabIndex = 2
        Me.test_list.UseCompatibleStateImageBehavior = False
        Me.test_list.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Text = "ID"
        Me.ColumnHeader1.Width = 0
        '
        'ColumnHeader5
        '
        Me.ColumnHeader5.Text = "TITLE"
        '
        'ColumnHeader6
        '
        Me.ColumnHeader6.Text = "DESCRIPTION"
        Me.ColumnHeader6.Width = 180
        '
        'ColumnHeader2
        '
        Me.ColumnHeader2.Text = "TOTAL ITEMS"
        Me.ColumnHeader2.Width = 220
        '
        'ColumnHeader3
        '
        Me.ColumnHeader3.Text = "SCORE"
        Me.ColumnHeader3.Width = 174
        '
        'ColumnHeader4
        '
        Me.ColumnHeader4.Text = "DATE TAKEN"
        Me.ColumnHeader4.Width = 189
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.White
        Me.PictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.PictureBox1.Image = Global.CAI.My.Resources.Resources.logo
        Me.PictureBox1.Location = New System.Drawing.Point(2, 3)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(100, 92)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 30
        Me.PictureBox1.TabStop = False
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(177, 59)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(115, 16)
        Me.Label9.TabIndex = 29
        Me.Label9.Text = "Baliuag, Bulacan"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(142, 43)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(132, 16)
        Me.Label8.TabIndex = 28
        Me.Label8.Text = "Baptiste, Academy"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Verdana", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(108, 9)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(171, 32)
        Me.Label7.TabIndex = 31
        Me.Label7.Text = "Saint Jean"
        '
        'Button1
        '
        Me.Button1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button1.BackColor = System.Drawing.Color.Transparent
        Me.Button1.FlatAppearance.BorderSize = 0
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.Color.White
        Me.Button1.Image = Global.CAI.My.Resources.Resources.icons8_back_48
        Me.Button1.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.Button1.Location = New System.Drawing.Point(899, 21)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(73, 74)
        Me.Button1.TabIndex = 32
        Me.Button1.Text = "BACK"
        Me.Button1.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.Button1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.Button1.UseVisualStyleBackColor = False
        '
        'StudentTestResult
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Green
        Me.ClientSize = New System.Drawing.Size(984, 562)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.ListContainer)
        Me.Font = New System.Drawing.Font("Verdana", 8.25!)
        Me.ForeColor = System.Drawing.Color.White
        Me.Name = "StudentTestResult"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "StudentTestResult"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.ListContainer.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ListContainer As System.Windows.Forms.Panel
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents lesson_prev As System.Windows.Forms.Button
    Friend WithEvents lesson_next As System.Windows.Forms.Button
    Friend WithEvents lesson_page As System.Windows.Forms.Label
    Friend WithEvents test_list As System.Windows.Forms.ListView
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents ColumnHeader1 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader2 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader3 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader4 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader5 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader6 As System.Windows.Forms.ColumnHeader
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Button1 As System.Windows.Forms.Button
End Class
