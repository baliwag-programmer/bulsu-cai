Public Class Heading

    Private _Title As String = ""

    Property Title As String
        Set(value As String)
            Me._Title = value
            Me.HeadingMainTitle.Text = Title
        End Set
        Get
            Return Me._Title
        End Get
    End Property

End Class
