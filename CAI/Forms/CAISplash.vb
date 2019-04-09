Public NotInheritable Class CAISplash

    Private WithEvents ProgressTimer As New Timer

    Private CurrentStatus As String
    Private DotIndicator As New List(Of String)

    Private Sub SplashScreen_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        'Set up the dialog text at runtime according to the application's assembly information.  

        'TODO: Customize the application's assembly information in the "Application" pane of the project 
        '  properties dialog (under the "Project" menu).

        'Application title
        If My.Application.Info.Title <> "" Then
            'ApplicationTitle.Text = My.Application.Info.Title
        Else
            'If the application title is missing, use the application name, without the extension
            ApplicationTitle.Text = System.IO.Path.GetFileNameWithoutExtension(My.Application.Info.AssemblyName)
        End If

        'Format the version information using the text set into the Version control at design time as the
        '  formatting string.  This allows for effective localization if desired.
        '  Build and revision information could be included by using the following code and changing the 
        '  Version control's designtime text to "Version {0}.{1:00}.{2}.{3}" or something similar.  See
        '  String.Format() in Help for more information.
        '
        '    Version.Text = System.String.Format(Version.Text, My.Application.Info.Version.Major, My.Application.Info.Version.Minor, My.Application.Info.Version.Build, My.Application.Info.Version.Revision)

        Version.Text = System.String.Format(Version.Text, My.Application.Info.Version.Major, My.Application.Info.Version.Minor)

        'Copyright info
        Copyright.Text = My.Application.Info.Copyright

        With ProgressTimer
            .Interval = 500
            .Start()
        End With

        AddHandler My.Application.OnApplicationEvent, AddressOf OnApplicationEventChange

    End Sub

    Public Sub OnApplicationEventChange(ByRef EventMessage As String)
        CurrentStatus = EventMessage
        Console.WriteLine(EventMessage)
    End Sub

    Private Sub ProgressTimer_Tick(sender As Object, e As EventArgs) Handles ProgressTimer.Tick
        DotIndicator.Add(".")
        Me.LabelProgress.Text = My.Application.CurrentStatus & String.Join("", DotIndicator.ToArray())
        If DotIndicator.Count >= 3 Then _
            DotIndicator = New List(Of String)
    End Sub
End Class
