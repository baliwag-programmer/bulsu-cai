Public Class Auth
    Private _id As Integer = 6
    Private _instructor_id As Integer = 6
    Public Property id() As Integer
        Get
            Return _id
        End Get
        Set(value As Integer)
            _id = value

            Try
                Dim command = New MySql.Data.MySqlClient.MySqlCommand("SELECT id, name, display_name, description FROM roles WHERE EXISTS (SELECT * FROM role_user WHERE role_user.user_id = @id AND roles.id = role_user.role_id)", Database.GetInstance.GetConnection)
                command.Parameters.AddWithValue("@id", value)
                Dim reader = command.ExecuteReader
                If reader.Read Then
                    role.id = reader.GetValue(0)
                    role.name = IIf(IsDBNull(reader.GetValue(1)), "", reader.GetValue(1))
                    role.display_name = IIf(IsDBNull(reader.GetValue(2)), "", reader.GetValue(2))
                    role.description = IIf(IsDBNull(reader.GetValue(3)), "", reader.GetValue(3))
                End If
                reader.Close()
            Catch ex As Exception

            End Try
        End Set
    End Property
    Public Property instructor_id() As Integer
        Get
            Return _instructor_id
        End Get
        Set(value As Integer)
            _instructor_id = value

            Try

            Catch ex As Exception

            End Try
        End Set
    End Property
    Public Property dp As String
    Public Property role As RoleModel
    Public Property username As String
    Public Property last_name As String
    Public Property first_name As String
    Public Property isPreview As Boolean
    Public Property middle_name As String
    Public Property approved As Integer
    Public Property previewing_auth As Auth

#Region "Batching Information"
    Public Property sy_from As Integer
    Public Property sy_to As Integer
    Public Property year As Integer
    Public Property section As String
#End Region

    Shared instance As Auth = Nothing

    Sub New()
        role = New RoleModel
    End Sub

    Public Shared Function saveAvatar(ByRef file_path As String) As String
        saveAvatar = ""
        Dim path = String.Format("{0}:\avatars", Config.GetInstance.network_path)
        Try
            If Not IO.Directory.Exists(path) Then _
                IO.Directory.CreateDirectory(path)
        Catch ex As Exception
            Console.WriteLine("Sorry unable to create directory")
            Console.WriteLine(ex)
        End Try

        Dim mili = ((DateTime.Now - New DateTime(1970, 1, 1)).TotalMilliseconds).ToString()
        saveAvatar = String.Format("{0}\{1}.{2}", path, mili, file_path.Split(".")(file_path.Split(".").Length - 1))

        IO.File.Copy(file_path, saveAvatar)
        Return saveAvatar
    End Function

    Public Shared Function GetInstance() As Auth
        If instance Is Nothing Then _
            instance = New Auth()
        Return instance
    End Function

    Private Events As New System.ComponentModel.EventHandlerList
    Public Custom Event UserUpdated As EventHandler
        AddHandler(ByVal value As EventHandler)
            Events.AddHandler("UserUpdated", value)
        End AddHandler
        RemoveHandler(ByVal value As EventHandler)
            Events.RemoveHandler("UserUpdated", value)
        End RemoveHandler
        RaiseEvent(ByVal sender As Object, ByVal e As EventArgs)
            CType(Events("UserUpdated"), EventHandler).Invoke(sender, e)
        End RaiseEvent
    End Event

    Public Sub updatedDetails()
        RaiseEvent UserUpdated(Me, New System.EventArgs)
    End Sub
End Class
