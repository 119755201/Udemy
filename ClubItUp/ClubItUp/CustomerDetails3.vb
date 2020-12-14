Public Class frmCustomerDetails3

    Private Sub btnNext_Click(sender As Object, e As EventArgs) Handles btnNext.Click

        ' When the 'Next' button is selected, the current form becomes invisible '
        Me.Visible = False

        ' The next form, 'Customisation Options' will become visible '
        frmCustomisationOptions.Show()

        ' The data entered in the 'Card Holder Name' text box will assign to the 'CardHolder' public variable '
        txtCardHolderName.Text = CardHolder

    End Sub

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click

        ' When the 'Back' button is selected, the current form will hide from view and the previous form will become visible '
        Me.Hide()

        ' The previous form, 'Customer Details 2/3' will become visible '
        frmCustomerDetails2.Show()

    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click

        ' When the 'Exit' button is selected, the programme will terminate '
        Me.Close()

    End Sub

    Private Sub frmCustomerDetails3_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class