Public Class Attribute
    Private col_name As String = ""
    Private col_display As String = ""

    Property name() As String
        Get
            Return col_name
        End Get
        Set(ByVal Value As String)
            col_name = Value
        End Set
    End Property

    Property display() As String
        Get
            Return col_display
        End Get
        Set(ByVal Value As String)
            col_display = Value
        End Set
    End Property

End Class
