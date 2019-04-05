Imports System.ComponentModel
Public Class DataLisQueryFilters

    Public Enum QueryTypes
        Where
        Where_Exists
    End Enum

    <Category("General")>
    <DisplayName("Query Type")>
    Property QueryType() As QueryTypes
        Get
            Return Nothing
        End Get
        Set(value As QueryTypes)

        End Set
    End Property

    <Category("General")>
    <DisplayName("Table Fields")>
    Property QueryColumns() As List(Of DataListQueryFieldQuery)
        Get
            Return Nothing
        End Get
        Set(value As List(Of DataListQueryFieldQuery))

        End Set
    End Property

End Class
