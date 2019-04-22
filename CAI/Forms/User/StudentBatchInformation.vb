Imports System.Windows.Forms

Public Class StudentBatchInformation

    Private StrictMode As Boolean = True

    Sub New()
        InitializeComponent()
    End Sub

    Sub New(ByRef NonStrictMode As Boolean)
        InitializeComponent()
        StrictMode = NonStrictMode
    End Sub

    Private Function Validation()

        Validation = "You need to provide all required fields."
        Dim schoolYear = New Control() {TXTYearFrom, TXTYearTo}
        Dim yearAndSection = New Control() {TXTYear, TXTSection}

        ' First Validate All Required
#Region "Required Validation"
        For Each control As Control In schoolYear
            If String.IsNullOrEmpty(control.Text) Then
                control.Focus()
                Return Validation
            End If
        Next

        For Each control As Control In yearAndSection
            If String.IsNullOrEmpty(control.Text) Then
                control.Focus()
                Return Validation
            End If
        Next
#End Region
#Region "Data Validation"
        Dim currentYear = Today().ToString("yyyy")
        Dim lastYear = Today().AddYears(-1).ToString("yyyy")
        Dim nextYear = Today().AddYears(1).ToString("yyyy")

        Dim schoolYearAcceptanceCriteria = New String() {
            "School year must be atleast 4 digits.",
            "School year from must be less than the school year to.",
            String.Format("School year must be in range only of {0}-{1}, {1}-{2}.", lastYear, currentYear, nextYear)
        }

        Dim schoolYearDataMessage = "Invalid school year." & vbNewLine & vbNewLine & "Acceptance Criteria:" & vbNewLine & "* " & String.Join(vbNewLine & "* ", schoolYearAcceptanceCriteria)

        Dim schoolYearData = New Integer() {schoolYear(0).Text, schoolYear(1).Text}
        If schoolYearData(0) >= schoolYearData(1) Or
            schoolYearData(0).ToString().Length < 4 Or
            schoolYearData(1).ToString().Length < 4 Then
            schoolYear(0).Focus()
            Return schoolYearDataMessage
        Else
            If Not schoolYearData(0) <> lastYear And Not schoolYearData(0) <> currentYear Then _
                Return schoolYearDataMessage
            If Not schoolYearData(1) <> currentYear And Not schoolYearData(1) <> nextYear Then _
                Return schoolYearDataMessage
        End If
#End Region

        Return Nothing
    End Function

    Private Sub ActionSelected(sender As Object, e As EventArgs) Handles BTNSave.Click, BTNCancel.Click
        If sender Is BTNSave Then
            Dim message = Validation()
            If Not message Is Nothing Then
                MsgBox(message, MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly, "Validation Error.")
                Exit Sub
            End If
            Me.DialogResult = DialogResult.OK
        End If

        If sender Is BTNCancel Then
            Me.DialogResult = DialogResult.Cancel
        End If
        Me.Close()
    End Sub

    Private Sub StudentBatchInformation_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        If Me.DialogResult = DialogResult.Cancel Then
            Dim message = "If you cancel this required information. You data won't be save."

            If Not StrictMode Then _
                message = "Do you want to cancel changing batch information?"
            Dim confirm = MsgBox(message, MsgBoxStyle.YesNo + MsgBoxStyle.Question, "Cancel?")

            If StrictMode Then _
                e.Cancel = Not confirm = MsgBoxResult.Ok

            If Not StrictMode Then _
                e.Cancel = Not confirm = MsgBoxResult.Yes
        End If
    End Sub

    Private Sub NumberOnly(sender As Object, e As KeyPressEventArgs) Handles TXTYearFrom.KeyPress, TXTYear.KeyPress, TXTYearTo.KeyPress

        If Asc(e.KeyChar) <> 8 Then
            If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then
                e.Handled = True
            End If
        End If

    End Sub
End Class
