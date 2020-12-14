Public Class frmCustomerDetails2

    Private Sub txtStreetAddress_TextChanged(sender As Object, e As EventArgs) Handles txtStreetAddress.TextChanged

        ' If the 'Street Address' text box doesn't contain data, other text boxes wont except input '
        If txtStreetAddress.Text = "" Then

            ' Town/City text box will remain as read only '
            txtTownCity.ReadOnly = True

            ' Else if 'Street Address' text box contains data to proceed with the function '
        ElseIf txtStreetAddress.Text <> "" Then

            ' The 'Town/City' text box will accept user input '
            txtTownCity.ReadOnly = False

        End If
    End Sub

    Private Sub btnNext_Click(sender As Object, e As EventArgs) Handles btnNext.Click

        ' When the 'Next' button is selected, the current form will close and another form will open '
        Me.Visible = False

        ' Customer Details 3/3 form will become visible '
        frmCustomerDetails3.Show()

        ' Assigns the data entered in the Street Address text box, to a public variable called 'StreetAddress' '
        txtStreetAddress.Text = StreetAddress

        ' Assigns the value entered in the Town/City text box, to a public variable called 'TownCity' '
        txtTownCity.Text = TownCity

        ' Assigns the value entered in the County text box, to a public variable called 'CustCounty' '
        txtCounty.Text = CustCounty

        ' Assigns the value entered in the Eir Code text box, to a public variable called 'CustEirCode' '
        txtEirCode.Text = CustEirCode

    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click

        ' The programme will terminate when the exit button is selected '
        Me.Close()

    End Sub

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click

        ' When the 'Back' button is selected the current form will hide, whilst the previous form will become visible '
        Me.Hide()
        frmCustomerDetails.Show()

    End Sub

    Private Sub txtTownCity_TextChanged(sender As Object, e As EventArgs) Handles txtTownCity.TextChanged

        ' County text box will remain as read only '
        txtCounty.ReadOnly = True

        ' Eir Code text box will remain as read only '
        txtEirCode.ReadOnly = True


        ' If the 'Street Address' text isnt empty e.g. contains data, proceed with the function '
        If txtStreetAddress.Text <> "" Then

            ' Town/City text box will accept user input'
            txtTownCity.ReadOnly = False

            ' If 'Town/City' contains data to proceed; '
        ElseIf txtTownCity.Text <> "" Then

            ' County text box will now accept user input '
            txtCounty.ReadOnly = False

            ' If 'County' contains data to proceed; '
        ElseIf txtCounty.Text <> "" Then

            ' Eir Code will now accept user input '
            txtEirCode.ReadOnly = False

            ' If EirCode contains data to proceed; '
        ElseIf txtEirCode.Text <> "" Then

            ' The 'Next' button becomes visible and becomes accessible to the end user '
            btnNext.Visible = True

        End If

    End Sub
End Class