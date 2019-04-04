Imports System.ComponentModel

Public Class AttachmentViewer

    WithEvents not_found_timer As Timer
    Private allowed_ppt As List(Of String)

    Private Property _file As OpenFileDialog
    Private Property FilePath As String = ""

    <EditorAttribute(GetType(System.Windows.Forms.Design.FileNameEditor), GetType(System.Drawing.Design.UITypeEditor)), Browsable(True), Category("Image Details"), RefreshProperties(RefreshProperties.All)> _
    Public Property SelectedFile() As String
        Get
            Return FilePath
        End Get
        Set(value As String)
            setAttachment(value)
        End Set
    End Property


    Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        not_found_timer = New Timer
        not_found_timer.Interval = 500
        not_found_timer.Start()

        allowed_ppt = New List(Of String)
        allowed_ppt.Add(".ppt")
        allowed_ppt.Add(".pptx")
        allowed_ppt.Add(".pps")
    End Sub

    Public Sub setAttachment(ByRef path As String)
        FilePath = path
        Try
            If IO.File.Exists(path) Then
                Dim info As New IO.FileInfo(FilePath)
                If allowed_ppt.IndexOf(info.Extension) = -1 Then

                    If info.Extension = ".pdf" Then
                        PictureBox2.Visible = False
                        AxWindowsMediaPlayer1.Visible = False

                    Else
                        AxWindowsMediaPlayer1.settings.autoStart = False
                        AxWindowsMediaPlayer1.URL = FilePath
                        PictureBox2.Visible = False
                        AxWindowsMediaPlayer1.Visible = True
                    End If
                Else
                    Dim objPPTViewer As New PowerPointViewer.PowerPointViewerControl
                    objPPTViewer.IsHide = True
                    PictureBox2.Visible = True
                    AxWindowsMediaPlayer1.Visible = False
                    objPPTViewer.Open(FilePath, PictureBox2.Left, PictureBox2.Top, PictureBox2.Width, PictureBox2.Height)
                    objPPTViewer.SetPPTViewerParent(Me.PictureBox2.Handle)
                End If
            End If
        Catch ex As System.IO.DirectoryNotFoundException
            FilePath = ""
        End Try
    End Sub

    Private Sub not_found_timer_Tick(sender As Object, e As System.EventArgs) Handles not_found_timer.Tick
        attachment_status.Visible = Not attachment_status.Visible And FilePath = ""
    End Sub

End Class
