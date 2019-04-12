Module NetworkModule1
    Public Sub MapDrive(ByVal DriveLetter As String, ByVal UNCPath As String, ByVal strUsername As String, ByVal strPassword As String)
        Dim p As New Process()
        p.StartInfo.FileName = "net.exe"
        p.StartInfo.Arguments = " use " & DriveLetter & ": " & UNCPath & " " & strPassword & " /USER:" & strUsername
        p.StartInfo.CreateNoWindow = True
        p.Start()
        p.WaitForExit()

        MsgBox("Successfully mapped network drive.", MsgBoxStyle.Information, "Map driving complete.")
    End Sub

End Module
