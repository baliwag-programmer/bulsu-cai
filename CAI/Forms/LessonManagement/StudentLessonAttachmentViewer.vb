Public Class StudentLessonAttachmentViewer

    Private attachment As String
    Sub New(Optional ByRef file As String = "", Optional ByRef title As String = "")

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        attachment = file
        lbl_time.Text = title
    End Sub

    Private Sub StudentLessonAttachmentViewer_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Me.AttachmentViewer1.setAttachment(attachment)
    End Sub

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        Me.Close()
    End Sub
End Class