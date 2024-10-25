' Program Name: Home Down payment
' Date: October 24, 2024
' Author: K Bola
' Purpose: This appliication computes and display the compound interest for a home down payment

Public Class frmHome
    Const _cdecRequiredAmount As Decimal = 5000
    Private Sub frmHome_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lstDisplay.Items.Clear()
        lblAmt.Text = _cdecRequiredAmount.ToString("C")
    End Sub
    Private Sub btnPayment_Click(sender As Object, e As EventArgs) Handles btnPayment.Click
        Dim strDownPayment As String
        Dim strInterestRate As String
        Dim strNumberOfYears As String
        Dim decDownPayment As Decimal
        Dim dblInterestRate As Double
        Dim decCompoundInterest As Decimal
        Dim intNumberOfYears As Integer
        Dim strInputDownPayment As String = "Enter the Down Payment: "
        Dim strInputDownPaymentHeading As String = "Home Down Payment"
        Dim strInputInterest As String = "Enter the Interest rate: "
        Dim strInputInterestHeading As String = "Interest Rate"
        Dim strInputYears As String = "Enter the years: "
        Dim strInputYearsHeading As String = "Years"
        Dim strNegativeValue As String = "Please Enter a Positive Value"
        strDownPayment = InputBox(strInputDownPayment, strInputDownPaymentHeading, "")
        strInterestRate = InputBox(strInputInterest, strInputInterestHeading, "")
        strNumberOfYears = InputBox(strInputYears, strInputYearsHeading, "")
        If (strDownPayment.Equals("") And strInterestRate.Equals("") And strNumberOfYears.Equals("")) Then
            MsgBox("It is Mandatory to Fill the Empty Spaces", MsgBoxStyle.OkOnly Or MsgBoxStyle.Exclamation, "Empty")
        End If
        If (IsNumeric(strDownPayment)) Then
            decDownPayment = Convert.ToDecimal(strDownPayment)
            If decDownPayment < 0 Then
                MsgBox(strNegativeValue, MsgBoxStyle.OkOnly Or MsgBoxStyle.Exclamation, "Negative Value")
            End If
        Else
            MsgBox("Please Enter a Valid Value For the Down Payment", MsgBoxStyle.OkOnly Or MsgBoxStyle.Exclamation, "Invalid Entry")
        End If
        If (IsNumeric(strInterestRate)) Then
            dblInterestRate = Convert.ToDouble(strInterestRate) / 100
            If dblInterestRate < 0 Then
                MsgBox(strNegativeValue, MsgBoxStyle.OkOnly Or MsgBoxStyle.Exclamation, "Negative Value")
            End If
        Else
            MsgBox("Please Enter a Valid Value For the Interest Rate", MsgBoxStyle.OkOnly Or MsgBoxStyle.Exclamation, "Invalid Entry")
        End If
        If (IsNumeric(strNumberOfYears)) Then
            intNumberOfYears = Convert.ToInt32(strNumberOfYears)
            If intNumberOfYears < 0 Then
                MsgBox(strNegativeValue, MsgBoxStyle.OkOnly Or MsgBoxStyle.Exclamation, "Negative Value")
            End If
        Else
            MsgBox("Please Enter a Valid Value for the Years", MsgBoxStyle.OkOnly Or MsgBoxStyle.Exclamation, "Invalid Entry")
        End If
        lstDisplay.Items.Clear()
        For year As Integer = 1 To intNumberOfYears
            decCompoundInterest = decDownPayment * Math.Pow(1 + dblInterestRate, year)
            lstDisplay.Items.Add("Year " & year & ": " & decCompoundInterest.ToString("C"))
        Next
        Dim decTotalAmount As Decimal = decDownPayment * Math.Pow(1 + dblInterestRate, intNumberOfYears)
        If decTotalAmount >= _cdecRequiredAmount Then
            lblCheck.Text = "You have saved enough for a house down payment."
        Else
            lblCheck.Text = "You have NOT saved enough for a house down payment"
        End If
        btnPayment.Enabled = False
    End Sub
    Private Sub mnuClear_Click(sender As Object, e As EventArgs) Handles mnuClear.Click
        lstDisplay.Items.Clear()
        lblAmt.Text = ""
        lblCheck.Text = ""
        btnPayment.Enabled = True
    End Sub
    Private Sub mnuExit_Click(sender As Object, e As EventArgs) Handles mnuExit.Click
        Close()
    End Sub
End Class
