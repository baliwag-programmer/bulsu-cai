Public Class ImageShower

#Region "Properties"
    Public Property EnabledImage() As Image
        Set(value As Image)
            Me._EnabledImage = value
            SetImage()
        End Set
        Get
            Return Me._EnabledImage
        End Get
    End Property
    Public Property DisabledImage() As Image
        Set(value As Image)
            Me._DisabledImage = value
            SetImage()
        End Set
        Get
            Return Me._DisabledImage
        End Get
    End Property
    Public Overridable Overloads Property State() As Boolean
        Set(value As Boolean)
            PictureBox1.Enabled = value
            SetImage()
            RaiseEvent OnStateChanged(Me, value)
        End Set
        Get
            Return PictureBox1.Enabled
        End Get
    End Property
#End Region

#Region "Private Variables"
    Private _EnabledImage As Image
    Private _DisabledImage As Image

    Private _StateChangeEventHandlers As New List(Of StateChangeEventHandler)
#End Region

#Region "Event Handler"
    Delegate Sub StateChangeEventHandler(sender As Object, state As Boolean)
#End Region

#Region "Events"
    Public Custom Event OnStateChanged As StateChangeEventHandler
        AddHandler(value As StateChangeEventHandler)
            _StateChangeEventHandlers.Add(value)
        End AddHandler
        RemoveHandler(value As StateChangeEventHandler)
            _StateChangeEventHandlers.Remove(value)
        End RemoveHandler
        RaiseEvent(sender As Object, state As Boolean)
            For Each handler As StateChangeEventHandler In _StateChangeEventHandlers
                Try
                    If handler IsNot Nothing Then
                        handler.Invoke(sender, state)
                    End If
                Catch ex As Exception
                    LoggerModule.createLog(Me.ToString, LogType.Err)
                    LoggerModule.createLog(ex.ToString, LogType.Err)
                End Try
            Next
        End RaiseEvent
    End Event
#End Region

    Private Sub SetImage()
        If PictureBox1.Enabled Then
            If Not _EnabledImage Is Nothing Then _
                Me.PictureBox1.Image = _EnabledImage
        Else
            If Not _DisabledImage Is Nothing Then _
                Me.PictureBox1.Image = _DisabledImage
        End If
    End Sub

End Class
