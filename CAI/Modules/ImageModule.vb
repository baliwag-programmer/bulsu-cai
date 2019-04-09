Imports System.IO

Module ImageModule

    Public Function ReadImageFromPath(ByRef path As String) As Image
        If IO.File.Exists(path) Then
            Return Image.FromFile(path)
        End If

        Return Nothing
    End Function

    Public Function ImageToBase64(ByVal img As Image, Optional ByVal format As System.Drawing.Imaging.ImageFormat = Nothing) As String

        If format Is Nothing Then
            format = Imaging.ImageFormat.Jpeg
        End If

        Using ms As New MemoryStream
            ' Convert Image to byte[]
            img.Save(ms, format)
            Dim imageBytes As Byte() = ms.ToArray() ' Convert byte[] to Base64 String
            Dim base64String As String = Convert.ToBase64String(imageBytes)
            Console.WriteLine(format.ToString)
            Return base64String
        End Using
    End Function

    Public Function Base64ToImage(ByVal base64String As String) As Image
        ' Convert Base64 String to byte[]
        Dim imageBytes As Byte() = Convert.FromBase64String(base64String)
        Dim ms As New MemoryStream(imageBytes, 0, imageBytes.Length)

        ' Convert byte[] to Image
        ms.Write(imageBytes, 0, imageBytes.Length)
        Dim ConvertedBase64Image As Image = Image.FromStream(ms, True)
        Return ConvertedBase64Image
    End Function
End Module
