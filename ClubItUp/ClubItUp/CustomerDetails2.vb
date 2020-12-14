Public Class frmCustomerDetails2

    Private Sub txtStreetAddress_TextChanged(sender As Object, e As EventArgs) Handles txtStreetAddress.TextChanged

        ' If the 'Street Address' text box doesn't contain data, other text boxes wont except input '
        If txtStreetAddress.Text = "" Then

            ' Town/City text box will remain as read only '
            txtTownCity.ReadOnly = True

            ' County text box will remain as read only '
            txtCounty.ReadOnly = True

            ' Eir Code text box will remain as read only '
            txtEirCode.ReadOnly = True


            ' Else if, the 'Street Address' text isnt empty e.g. contains data, proceed with the function '
        ElseIf txtStreetAddress.Text <> "" Then

            ' Town/City text box will accept user input'
            txtTownCity.ReadOnly = False

            ' Else if 'Town/City' contains data to proceed; '
        ElseIf txtTownCity.Text <> "" Then

            ' County text box will now accept user input '
            txtCounty.ReadOnly = False

            ' Else if 'County' contains data to proceed; '
        ElseIf txtCounty.Text <> "" Then

            ' Eir Code will now accept user input '
            txtEirCode.ReadOnly = False

            ' Else if EirCode contains data to proceed; '
        ElseIf txtEirCode.Text <> "" Then

            ' The 'Next' button becomes visible and becomes accessible to the end user '
            btnNext.Visible = True

        End If
    End Sub

    Private Sub btnNext_Click(sender As Object, e As EventArgs) Handles btnNext.Click

        ' When the 'Next' button is selected, the current form will close and another form will open '
        Me.Visible = False

        ' Customer Details 3/3 form will become visible '
        frmCustomerDetails3.Show()

    End Sub
End Class