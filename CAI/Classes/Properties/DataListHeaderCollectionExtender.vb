Imports System.ComponentModel

Public Class DataListHeaderCollectionExtender
    Inherits ListView.ColumnHeaderCollection

    Private ReadOnly _Item As ColumnHeader
    Public Shadows Property Test As String

    Sub New(owner As ListView)
        MyBase.New(owner)
    End Sub

End Class
