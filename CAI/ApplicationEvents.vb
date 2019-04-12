Imports System.Collections.ObjectModel
Imports System.ComponentModel
Imports System.Threading
Imports Microsoft.VisualBasic.ApplicationServices

Namespace My
    ' The following events are available for MyApplication:
    ' Startup: Raised when the application starts, before the startup form is created.
    ' Shutdown: Raised after all application forms are closed.  This event is not raised if the application terminates abnormally.
    ' UnhandledException: Raised if the application encounters an unhandled exception.
    ' StartupNextInstance: Raised when launching a single-instance application and the application is already active. 
    ' NetworkAvailabilityChanged: Raised when the network connection is connected or disconnected.
    Partial Friend Class MyApplication
#Region "Event Handlers Definition"
        Public Delegate Sub DatabaseConnectivityErrorHandler()
        Public Delegate Sub ApplicationEventHandler(ByRef EventMessage As String)
        Public Delegate Sub AuthenticationHandler(ByRef Auth As Auth)
        Public Delegate Sub DateTimeEventHandler(ByRef CurrentDateTime As DateTime)
#End Region

#Region "Event Handlers"
        Private OnDateTimeChangedHandlers As New List(Of DateTimeEventHandler)
        Private OnAuthenticationHandlers As New List(Of AuthenticationHandler)
        Private OnApplicationEventHandlers As New List(Of ApplicationEventHandler)
        Private OnDatabaseConnectivityErrorHandlers As New List(Of DatabaseConnectivityErrorHandler)
#End Region

#Region "Private Declarations"
        Private IsLive As Boolean = False
        Private AuthenticatedUser As Auth
        Private CurrentDateTime As DateTime
        Public CurrentStatus As String = "Loading Resources"
        Private WithEvents DateTimeBackgroundWorker As New System.ComponentModel.BackgroundWorker
#End Region

#Region "Custom Events"
        Public Custom Event OnDateTimeChanged As DateTimeEventHandler
            AddHandler(value As DateTimeEventHandler)
                OnDateTimeChangedHandlers.Add(value)
            End AddHandler
            RemoveHandler(value As DateTimeEventHandler)
                OnDateTimeChangedHandlers.Remove(value)
            End RemoveHandler
            RaiseEvent(ByRef CurrentDateTime As Date)
                For Each handler As DateTimeEventHandler In OnDateTimeChangedHandlers
                    If handler IsNot Nothing Then
                        handler.BeginInvoke(Me.CurrentDateTime, Nothing, Nothing)
                    End If
                Next
            End RaiseEvent
        End Event

        Public Custom Event OnAuthentication As AuthenticationHandler
            AddHandler(value As AuthenticationHandler)
                OnAuthenticationHandlers.Add(value)
            End AddHandler
            RemoveHandler(value As AuthenticationHandler)
                OnAuthenticationHandlers.Remove(value)
            End RemoveHandler
            RaiseEvent(ByRef Auth As Auth)
                For Each handler As AuthenticationHandler In OnAuthenticationHandlers
                    If handler IsNot Nothing Then
                        handler.BeginInvoke(Auth, Nothing, Nothing)
                    End If
                Next
            End RaiseEvent
        End Event

        Public Custom Event OnDatabaseConnectivityError As DatabaseConnectivityErrorHandler
            AddHandler(value As DatabaseConnectivityErrorHandler)
                OnDatabaseConnectivityErrorHandlers.Add(value)
            End AddHandler
            RemoveHandler(value As DatabaseConnectivityErrorHandler)
                OnDatabaseConnectivityErrorHandlers.Remove(value)
            End RemoveHandler
            RaiseEvent()
                For Each handler As DatabaseConnectivityErrorHandler In OnDatabaseConnectivityErrorHandlers
                    If handler IsNot Nothing Then
                        handler.BeginInvoke(Nothing, Nothing)
                    End If
                Next
            End RaiseEvent
        End Event

        Public Custom Event OnApplicationEvent As ApplicationEventHandler
            AddHandler(value As ApplicationEventHandler)
                OnApplicationEventHandlers.Add(value)
            End AddHandler
            RemoveHandler(value As ApplicationEventHandler)
                OnApplicationEventHandlers.Remove(value)
            End RemoveHandler
            RaiseEvent(ByRef message As String)
                CurrentStatus = message
                For Each handler As ApplicationEventHandler In OnApplicationEventHandlers
                    If handler IsNot Nothing Then
                        handler.BeginInvoke(message, Nothing, Nothing)
                    End If
                Next
            End RaiseEvent
        End Event
#End Region

        Private Sub DateTimeBackgroundWorker_DoWork(sender As Object, e As DoWorkEventArgs) Handles DateTimeBackgroundWorker.DoWork
            While IsLive
                DoEvents()
                If Not CurrentDateTime.Equals(DateTime.Now) Then
                    CurrentDateTime = DateTime.Now
                    Control.CheckForIllegalCrossThreadCalls = False
                    RaiseEvent OnDateTimeChanged(Me.CurrentDateTime)
                    DateTimeBackgroundWorker.ReportProgress(1)
                End If
            End While
        End Sub

        Private Sub MyApplication_Shutdown(sender As Object, e As EventArgs) Handles Me.Shutdown
            IsLive = False
        End Sub

        Protected Overrides Function OnInitialize(commandLineArgs As ReadOnlyCollection(Of String)) As Boolean
            IsLive = True
            DateTimeBackgroundWorker.WorkerReportsProgress = True
            DateTimeBackgroundWorker.RunWorkerAsync()
            CheckDatabaseConnection()
            Return MyBase.OnInitialize(commandLineArgs)
        End Function

        Public Sub SetAuth(ByRef Auth As Auth)
            Me.AuthenticatedUser = Auth
            RaiseEvent OnAuthentication(Auth)
        End Sub

        Public Function GetAuth() As Auth
            Return Me.AuthenticatedUser
        End Function

        Public Sub CheckDatabaseConnection()
            CurrentStatus = "Checking database connectivity"
            'Dim Connection = Database.GetInstance().GetConnection()
            'If Connection Is Nothing Then _
            '    RaiseEvent OnDatabaseConnectivityError()
        End Sub

        Private Sub MyApplication_Startup(sender As Object, e As StartupEventArgs) Handles Me.Startup

        End Sub

        Public Function GetCurrentStatus() As String
            Return CurrentStatus
        End Function

    End Class
End Namespace
