Imports CAI.BP
Imports System.ComponentModel

Public Class DBList

    Property table As String
    Property list As ListView
    Property skip As Integer = 0
    Property limit As Integer = 15
    Property custom_sql As String
    Private connection As MySql.Data.MySqlClient.MySqlConnection

    <DesignerSerializationVisibility(DesignerSerializationVisibility.Content)>
    Public Shared DB_columns As List(Of DBColumn)

    Sub New()
        ' This call is required by the designer.
        InitializeComponent()
        ' Add any initialization after the InitializeComponent() call.
        columns = New List(Of DBColumn)
        list = ListView1
    End Sub

    <DesignerSerializationVisibility(DesignerSerializationVisibility.Content)>
    Public Shared Property columns() As List(Of DBColumn)
        Get
            Return DB_columns
        End Get
        Set(value As List(Of DBColumn))
            DB_columns = value
        End Set
    End Property

    <DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)>
    Sub updateView()
        ListView1.Clear()
        ListView1.GridLines = True
        ListView1.View = View.Details
        ListView1.MultiSelect = False
        ListView1.FullRowSelect = True

        If Not DB_columns Is Nothing And Not list Is Nothing Then
            If Not DB_columns.Count = 0 Then
                For Each column As DBColumn In DB_columns
                    If Not column Is Nothing Then _
                        ListView1.Columns.Add(column.display, column.width, HorizontalAlignment.Center)
                Next
            End If
        End If
    End Sub

    Private Sub DBList_Load(sender As Object, e As System.EventArgs) Handles Me.Load
        updateView()

        If Not Me.DesignMode Then _
            setupRuntime()
    End Sub

    Private Sub setupRuntime()
        ' Setup the data
        connection = Database.GetInstance.GetConnection()
        If connection.State = ConnectionState.Open Then _
            fetchData()
    End Sub

    Public Sub fetchData()
        If columns.Count = 0 Then _
            Exit Sub
        list.Items.Clear()
        Dim index = 0
        Dim cols As New List(Of String)
        For Each column As DBColumn In columns
            cols.Add(column.name)
        Next
        Dim grammar As String = String.Format("SELECT {0}", String.Join(", ", cols))
        grammar &= String.Format(" FROM {0} LIMIT {1}, {2}", table, skip, limit)

        If Not custom_sql Is Nothing Then _
            grammar = String.Format("{0} LIMIT {1}, {2}", custom_sql, skip, limit)
        Dim command As New MySql.Data.MySqlClient.MySqlCommand(grammar, connection)
        Dim reader = command.ExecuteReader
        While reader.Read
            Dim item = New ListViewItem
            item.Name = reader.GetValue(0)
            index = 0
            item.Text = IIf(reader.IsDBNull(index), "", reader.GetValue(index))
            index += 1
            For x As Integer = index To cols.Count - 1
                Dim value = IIf(reader.IsDBNull(x), "", reader.GetValue(x))
                If TypeOf value Is Date Then _
                    value = Format(value, "dddd, d MMM yyyy")

                item.SubItems.Add(value)
            Next
            ListView1.Items.Add(item)
        End While
        reader.Close()
    End Sub

End Class
