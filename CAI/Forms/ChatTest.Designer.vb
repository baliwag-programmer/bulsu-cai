<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ChatTest
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txt_message = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txt_conversations = New System.Windows.Forms.RichTextBox()
        Me.btn_message = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txt_username = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(61, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Username :"
        '
        'txt_message
        '
        Me.txt_message.Location = New System.Drawing.Point(71, 301)
        Me.txt_message.Name = "txt_message"
        Me.txt_message.Size = New System.Drawing.Size(211, 20)
        Me.txt_message.TabIndex = 2
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 61)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(80, 13)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Conversations :"
        '
        'txt_conversations
        '
        Me.txt_conversations.Location = New System.Drawing.Point(12, 77)
        Me.txt_conversations.Name = "txt_conversations"
        Me.txt_conversations.ReadOnly = True
        Me.txt_conversations.Size = New System.Drawing.Size(351, 215)
        Me.txt_conversations.TabIndex = 4
        Me.txt_conversations.Text = ""
        '
        'btn_message
        '
        Me.btn_message.Location = New System.Drawing.Point(288, 299)
        Me.btn_message.Name = "btn_message"
        Me.btn_message.Size = New System.Drawing.Size(75, 23)
        Me.btn_message.TabIndex = 5
        Me.btn_message.Text = "SEND"
        Me.btn_message.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(9, 304)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(56, 13)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Message :"
        '
        'txt_username
        '
        Me.txt_username.Location = New System.Drawing.Point(12, 25)
        Me.txt_username.Name = "txt_username"
        Me.txt_username.Size = New System.Drawing.Size(351, 20)
        Me.txt_username.TabIndex = 7
        '
        'ChatTest
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(381, 338)
        Me.Controls.Add(Me.txt_username)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.btn_message)
        Me.Controls.Add(Me.txt_conversations)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txt_message)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "ChatTest"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "ChatTest"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txt_message As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txt_conversations As System.Windows.Forms.RichTextBox
    Friend WithEvents btn_message As System.Windows.Forms.Button
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txt_username As System.Windows.Forms.TextBox

End Class
