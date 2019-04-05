Imports System.ComponentModel

Public Class ColumnHeader

    Inherits System.Windows.Forms.ColumnHeader

#Region "Private Variables"
    Private _FieldName As String = "FieldName"
#End Region

#Region "Extended Properties"
    <Category("Database")>
    <DisplayName("Field Name")>
    <Description("The field to show from table")>
    Property FieldOnDB() As String
        Get
            Return _FieldName
        End Get
        Set(value As String)
            _FieldName = value
        End Set
    End Property
#End Region

End Class
