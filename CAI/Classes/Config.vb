Public Class Config

    Property path As String
    Property port = 3306
    Property user As String = "root"
    Property password As String = "root"
    Property database As String = "db_cai"
    Property server As String = "localhost"
    Property network_path As String = "Z"
    Property network_password As String = ""
    Property network_user As String = "\\PC-Name\AMD"
    Property network_address As String = "\\PC-Name\SharedCAIPath"

    Private Shared instance As Config = Nothing

    Public Function getPath() As String
        Return My.Computer.FileSystem.SpecialDirectories.CurrentUserApplicationData & "\config.ini"
    End Function

    Sub New()
        Try
            Me.path = getPath()
            If Not IO.File.Exists(Me.path) Then
                Dim str_config = New List(Of String)
                ' This method will automatically assign default values
                For Each props In Me.GetType.GetProperties()
                    str_config.Add(String.Format("{0}:{1}", props.Name, props.GetValue(Me, Nothing).ToString()))
                Next
                IO.File.WriteAllLines(path, str_config.ToArray())
            End If
            Console.WriteLine(Me.path)
            Dim configs = IO.File.ReadAllLines(Me.path)
            For Each cnfg As String In configs
                Dim tmp = cnfg.Split(":")
                For Each props In Me.GetType.GetProperties()
                    If props.Name = tmp(0) Then
                        props.SetValue(Me, tmp(1), Nothing)
                    End If
                Next
            Next
        Catch ex As Exception
            Console.WriteLine("Unable to load the configuration : " & ex.Message)
        End Try
    End Sub

    Public Shared Function GetInstance() As Config
        If instance Is Nothing Then _
            instance = New Config()
        Return instance
    End Function

End Class
