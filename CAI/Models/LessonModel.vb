Public Class LessonModel
    Inherits Model

    Public table As String = "lessons"

    Shared Function attachment_path() As String
        Dim path = String.Format("{0}:\lesson-attachment", Config.GetInstance.network_path)
        Try
            If Not IO.Directory.Exists(path) Then _
                IO.Directory.CreateDirectory(path)
        Catch ex As Exception

        End Try
        Return path
    End Function

End Class
