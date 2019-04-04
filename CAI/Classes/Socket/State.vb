Imports System.Text

Public Class State
    ' Client socket.  
    Public Property workSocket As Socket = Nothing
    ' Size of receive buffer.  
    Public Const BufferSize As Integer = 256
    ' Receive buffer.  
    Public buffer(256) As Byte
    ' Received data string.  
    Public sb As New StringBuilder()
End Class
