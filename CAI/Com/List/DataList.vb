Public Class DataList

#Region "Private Variables"
    Private _Columns As DataListHeaderCollectionExtender
#End Region

#Region "Component Events"
    Public Custom Event OnSelectRow As EventHandler
        AddHandler(value As EventHandler)
            Me.Events.AddHandler("OnSelectRow", value)
        End AddHandler
        RemoveHandler(value As EventHandler)
            Me.Events.RemoveHandler("OnSelectRow", value)
        End RemoveHandler
        RaiseEvent(sender As ListViewItem, e As EventArgs)
            CType(Me.Events("OnSelectRow"), EventHandler).Invoke(sender, e)
        End RaiseEvent
    End Event
    Public Custom Event OnPreselectRow As EventHandler
        AddHandler(value As EventHandler)
            Me.Events.AddHandler("OnPreselectRow", value)
        End AddHandler
        RemoveHandler(value As EventHandler)
            Me.Events.RemoveHandler("OnPreselectRow", value)
        End RemoveHandler
        RaiseEvent(sender As ListViewItem, e As EventArgs)
            CType(Me.Events("OnPreselectRow"), EventHandler).Invoke(sender, e)
        End RaiseEvent
    End Event
#End Region

#Region "Property"
    Property DataListHeaders() As DataListHeaderCollectionExtender
        Get
            Return _Columns
        End Get
        Set(value As DataListHeaderCollectionExtender)
            setupView(value)
        End Set
    End Property

    Property DataListQueryFilters() As List(Of DataLisQueryFilters)
        Get
            Return Nothing
        End Get
        Set(value As List(Of DataLisQueryFilters))

        End Set
    End Property

#End Region

#Region "Internal Events"
    Private Sub OnDoubleClickData(sender As Object, e As EventArgs) Handles ListView1.DoubleClick
        If ListView1.SelectedItems.Count = 0 Then _
            Exit Sub
        Dim OnSelectRow As EventHandler =
            CType(Me.Events("OnSelectRow"), EventHandler)
        If (OnSelectRow IsNot Nothing) Then _
            OnSelectRow.Invoke(ListView1.SelectedItems(0), e)
    End Sub

    Private Sub OnPreselect(sender As Object, e As EventArgs) Handles ListView1.SelectedIndexChanged
        If ListView1.SelectedItems.Count = 0 Then _
            Exit Sub
        Dim OnSelectRow As EventHandler =
            CType(Me.Events("OnPreselectRow"), EventHandler)
        If (OnSelectRow IsNot Nothing) Then _
            OnSelectRow.Invoke(ListView1.SelectedItems(0), e)
    End Sub
#End Region

    Sub setupView(ByRef headers As DataListHeaderCollectionExtender)
        _Columns = headers
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

End Class
