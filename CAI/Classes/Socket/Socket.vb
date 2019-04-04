Imports System.Threading
Imports BaseSockets = System.Net.Sockets
Imports BaseSocket = System.Net.Sockets.Socket
Imports System.Net

Public Class Socket

    Private client As BaseSocket
    ' The port number for the remote device.  
    Private Const port As Integer = 11000

    ' ManualResetEvent instances signal completion.  
    Private connectDone As ManualResetEvent =
        New ManualResetEvent(False)
    Private sendDone As ManualResetEvent =
        New ManualResetEvent(False)
    Private receiveDone As ManualResetEvent =
        New ManualResetEvent(False)

    ' The response from the remote device.  
    Private response As String = String.Empty

    ' This method will try to connect to the selected server
    Public Sub connect()
        ' Connect to a remote device.  
        ' Establish the remote endpoint for the socket.  
        ' The name of the   
        ' Remote device is "host.contoso.com".  
        Dim ipHostInfo As IPHostEntry = Dns.GetHostEntry("AMD-PC")
        Dim ipAddress As IPAddress = ipHostInfo.AddressList(0)
        Dim remoteEP = New IPEndPoint(ipAddress, port)

        ' Create a TCP/IP socket.  
        client = New BaseSocket(ipAddress.AddressFamily, BaseSockets.SocketType.Stream, BaseSockets.ProtocolType.Tcp)
        ' Connect to the remote endpoint.  
        client.BeginConnect(remoteEP, New AsyncCallback(AddressOf ConnectCallback), client)
        connectDone.WaitOne()

        ' Send test data to the remote device.  
        Send(client, String.Format("This is a test {0} <EOF>", "test"))
        sendDone.WaitOne()

        ' Receive the response from the remote device.  
        Receive(client)
        receiveDone.WaitOne()

    End Sub

    Public Sub sendMessage(ByRef messsage As String)

    End Sub

    ' This method will handle received data from the server
    Private Sub Receive(client As Sockets.Socket)
        Throw New NotImplementedException
    End Sub

    ' This method will manage to shutdown the current server connection
    'Private Function SocketShutdown() As Object
    '    Throw New NotImplementedException
    'End Function

    ' This method will manage to send data to the current server
    Private Sub Send(client As Sockets.Socket, p2 As String)
        Throw New NotImplementedException
    End Sub

    ' This method will handle the connection to the server
    Private Sub ConnectCallback(ByVal ar As IAsyncResult)
        Try
            ' Retrieve the socket from the state object.  
            Dim client As BaseSocket = ar.AsyncState

            ' Complete the connection.  
            client.EndConnect(ar)
            Console.WriteLine("Socket connected to {0}", client.RemoteEndPoint.ToString())

            ' Signal that the connection has been made.  
            connectDone.Set()
        Catch ex As Exception
            Console.WriteLine("Unable to connect : " & ex.Message)
        End Try
    End Sub

End Class
