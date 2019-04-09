Module LoggerModule

    Public Enum LogType
        Info
        Err
    End Enum

    Public Function createLog(ByRef message As String, ByRef Optional mode As LogType = LogType.Info)

        Try
            Dim BaseFileName As String = String.Format("{0:MM-dd-yy}", Date.Today())
            Dim FileName = String.Format("{0}.log", BaseFileName)
            Dim BasePath As String = String.Format("{0}/{1}", Application.StartupPath, "logs")

            If Not IO.Directory.Exists(BasePath) Then
                IO.Directory.CreateDirectory(BasePath)
            End If

            Select Case mode
                Case LogType.Err
                    FileName = String.Format("{0}-error.log", BaseFileName)

            End Select

            FileName = String.Format("{0}/{1}", BasePath, FileName)
            If Not IO.File.Exists(FileName) Then
                IO.File.Create(FileName).Dispose()
            End If
            IO.File.AppendAllText(FileName, vbNewLine & String.Format("{0}::{1}", Date.Today(), message))
        Catch ex As Exception
            Console.WriteLine("Error LoggerModule::CreateLog()->" & ex.Message)
        End Try

        Return False
    End Function

End Module
