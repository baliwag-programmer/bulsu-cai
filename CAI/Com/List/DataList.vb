Public Class DataList
    Private headers As List(Of ColumnHeader)
    Property DataHeaders() As List(Of ColumnHeader)
        Get
            Return headers
        End Get
        Set(value As List(Of ColumnHeader))
            headers = value
        End Set
    End Property

    Sub setupView()
        With ListView1
            .Clear()

            If Not headers Is Nothing Then
                If headers.Count > 0 Then
                    For Each header As ColumnHeader In headers
                        .Columns.Add(header)
                    Next
                End If
            End If
        End With
    End Sub

    Private Sub DataList_Load(sender As Object, e As System.EventArgs) Handles Me.Load
        setupView()
    End Sub

End Class
