<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PrintPreviewer
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
        Me.Heading1 = New CAI.Heading()
        Me.ActionPrint = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Heading1
        '
        Me.Heading1.BackColor = System.Drawing.Color.White
        Me.Heading1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Heading1.Font = New System.Drawing.Font("Verdana", 8.25!)
        Me.Heading1.Location = New System.Drawing.Point(0, 0)
        Me.Heading1.Name = "Heading1"
        Me.Heading1.Size = New System.Drawing.Size(933, 127)
        Me.Heading1.TabIndex = 0
        Me.Heading1.Title = "PRINT PREVIEW"
        '
        'ActionPrint
        '
        Me.ActionPrint.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ActionPrint.BackColor = System.Drawing.Color.Transparent
        Me.ActionPrint.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ActionPrint.FlatAppearance.BorderSize = 0
        Me.ActionPrint.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ActionPrint.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ActionPrint.ForeColor = System.Drawing.Color.White
        Me.ActionPrint.Image = Global.CAI.My.Resources.Resources.icons8_send_to_printer_48
        Me.ActionPrint.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.ActionPrint.Location = New System.Drawing.Point(834, 133)
        Me.ActionPrint.Name = "ActionPrint"
        Me.ActionPrint.Size = New System.Drawing.Size(85, 74)
        Me.ActionPrint.TabIndex = 64
        Me.ActionPrint.Text = "PRINT"
        Me.ActionPrint.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.ActionPrint.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.ActionPrint.UseVisualStyleBackColor = False
        '
        'PrintPreviewer
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Green
        Me.ClientSize = New System.Drawing.Size(933, 506)
        Me.Controls.Add(Me.ActionPrint)
        Me.Controls.Add(Me.Heading1)
        Me.Font = New System.Drawing.Font("Verdana", 8.25!)
        Me.Name = "PrintPreviewer"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "PRINT PREVIEW"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Heading1 As Heading
    Friend WithEvents ActionPrint As Button
End Class
