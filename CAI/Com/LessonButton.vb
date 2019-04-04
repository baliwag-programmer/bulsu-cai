Public Class LessonButton
    Public Property lesson_number As Integer = 1
    Public Property lesson_title As String = ""
    Public Property attachment As String = ""
    Public Property is_locked As Boolean = False

    Public Sub init()
        Me.Button1.Text = String.Format("LESSON {0}" & vbNewLine & vbNewLine & "{1}", lesson_number, lesson_title)
        If Not is_locked Then _
            Me.Button1.Image = My.Resources.icons8_ok_96
        Me.Button1.Enabled = Not is_locked
    End Sub

    Private CustomEvents As New System.ComponentModel.EventHandlerList
    Public Custom Event OnSelect As EventHandler
        AddHandler(ByVal value As EventHandler)
            CustomEvents.AddHandler("OnSelect", value)
        End AddHandler
        RemoveHandler(ByVal value As EventHandler)
            CustomEvents.RemoveHandler("OnSelect", value)
        End RemoveHandler
        RaiseEvent(ByVal sender As Object, ByVal e As EventArgs)
            CType(CustomEvents("OnSelect"), EventHandler).Invoke(sender, e)
        End RaiseEvent
    End Event

    Private Sub Button1_Click(sender As Object, e As System.EventArgs) Handles Button1.Click
        RaiseEvent OnSelect(Me, New System.EventArgs)
    End Sub
End Class
