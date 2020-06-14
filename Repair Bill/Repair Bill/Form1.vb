Public Class frmRepairBill

    Dim customerName As String

    Dim hoursWorked, partsCost, suppliesCost, subTotal, totalCost, salesTax As Double

    Private Sub txtCustomerName_TextChanged(sender As Object, e As EventArgs) Handles txtCustomerName.TextChanged


    End Sub

    Const Tax As Double = 0.05

    Private Sub btnCalculate_Click(sender As Object, e As EventArgs) Handles btnCalculate.Click

        If txtCustomerName.Text <> "" And IsNumeric(txtHoursWorked.Text) And IsNumeric(txtPartsCost.Text) And IsNumeric(txtSuppliesCost.Text) Then

            customerName = txtCustomerName.Text
            hoursWorked = txtHoursWorked.Text * 35
            partsCost = CDbl(txtPartsCost.Text)
            suppliesCost = CDbl(txtSuppliesCost.Text)

            subTotal = hoursWorked + partsCost + suppliesCost

            salesTax = subTotal * Tax

            totalCost = salesTax + subTotal

            txtSubTotal.Text = subTotal
            txtSalesTax.Text = salesTax
            txtTotalCost.Text = totalCost

            lstDisplayOutput.Items.Add("Customer: " & customerName)
            lstDisplayOutput.Items.Add("Total Labor Cost: " & FormatCurrency(hoursWorked))
            lstDisplayOutput.Items.Add("Total Parts Cost: " & FormatCurrency(partsCost + suppliesCost))
            lstDisplayOutput.Items.Add("Total Sales Tax (5%): " & FormatCurrency(salesTax))

        Else
            MessageBox.Show("Please enter all the required information")

        End If

    End Sub


End Class
