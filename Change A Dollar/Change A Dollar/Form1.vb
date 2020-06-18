Public Class frmChangeADollar

    Dim amount, cents25, cents10, cents5, cents1 As Double


    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub txt25Cents_TextChanged(sender As Object, e As EventArgs) Handles txt25Cents.TextChanged

    End Sub

    Private Sub btnCalculate_Click(sender As Object, e As EventArgs) Handles btnCalculate.Click

        amount = CDbl(txtAmountInput.Text)

        cents25 = Int(amount / 0.25)
        txt25Cents.Text = cents25
        amount = amount - (0.25 * cents25)

        cents10 = Int(amount / 0.1)
        txt10Cents.Text = cents10
        amount = amount - (0.1 * cents10)

        cents5 = Int(amount / 0.05)
        txt5Cents.Text = cents5
        amount = amount - (0.05 * cents5)

        cents1 = Int(amount / 0.01)
        txt1Cent.Text = cents1
        amount = amount - (0.01 * cents1)


    End Sub
End Class
