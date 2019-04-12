Public Class StudentLessonAttachmentViewer

    Private attachment As String

    Sub New()
        InitializeComponent()

        attachment = "C:\Users\Public\Videos\Sample Videos\Wildlife.wmv"
    End Sub

    Sub New(Optional ByRef file As String = "", Optional ByRef title As String = "")

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        attachment = file
        Heading1.Title = title.ToUpper
    End Sub

    Private Sub StudentLessonAttachmentViewer_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Me.AttachmentViewer1.setAttachment(attachment)
    End Sub

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        Me.Close()
    End Sub
End Class