Imports System.IO
Imports System.IO.Compression

Module DataArchiver

    Private BasePath = My.Computer.FileSystem.SpecialDirectories.CurrentUserApplicationData
    Dim ArchiveFile As String = BasePath & "\archiver.zip"

    Sub Initialize()
        If Not IO.File.Exists(BasePath & "\archiver\mysqldump.exe") Then
            CopyZipFile()
            Dim FileStream = IO.File.OpenRead(ArchiveFile)
            'Dim gzip = New ZipFile(FileStream, CompressionMode.Decompress)
            'gzip.CopyTo(New FileStream(BasePath, FileMode.OpenOrCreate))
        End If
    End Sub

    Sub CopyZipFile()
        If Not IO.File.Exists(ArchiveFile) Then
            Dim archiverBytes = My.Resources.archiver
            System.IO.File.WriteAllBytes(ArchiveFile, archiverBytes)
        End If
    End Sub

End Module
