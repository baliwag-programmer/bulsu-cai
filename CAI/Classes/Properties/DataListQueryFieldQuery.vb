Imports System.ComponentModel

Public Class DataListQueryFieldQuery

    Public Enum QueryOpearators
        Equal
        NotEqual
        GreaterThan
        GreaterThanOrEqualTo
        LessThan
        LessThanOrEqualTo
    End Enum

    <Category("Column")>
    <DisplayName("Query Operator")>
    <Description("The SQL operator =,!=,>,>=,<,<=")>
    Public Property QueryOperator As QueryOpearators

    <Category("Column")>
    <DisplayName("Field From Table")>
    Public Property FieldToQuery As String

    <Category("Column")>
    <DisplayName("Value")>
    Public Property Value

End Class
