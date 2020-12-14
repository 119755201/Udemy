Public Class frmEmployeeConfirmation

    Private Sub frmCustomerInformation_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        ' When the form loads, the listbox will list the information below, followed by the data entered by the end user in the previous form '

        ' Displays the string: "User Name: " and the value attached to the string variable FullName, inside the listbox '
        lstUserInfoOutput.Items.Add("User Name: " & FullName)

        ' Displays the string: "User Email: " and the value attached to the string variable EmployeeEmail, inside the listbox '
        lstUserInfoOutput.Items.Add("User Email: " & EmployeeEmail)

    End Sub

    Private Sub rdoCorrectYes_CheckedChanged(sender As Object, e As EventArgs) Handles rdoCorrectYes.CheckedChanged

        ' If the 'Yes' radio button is selected, the 'Continue' label & button become visible, while the 'Update Details' button and label become/remain invisible '

        If rdoCorrectYes.Checked = True Then

            ' Hides the 'Update Details' label '
            lblUpdateDetails.Hide()

            ' Hides the 'Update Details' button '
            btnUpdateDetails.Visible = False

            ' Shows the 'Continue' label  '
            lblContinue.Show()

            ' Changes the 'Next' button, from Invisible, to visible '
            btnNext.Visible = True

        End If

    End Sub

    Private Sub rdoCorrectNo_CheckedChanged(sender As Object, e As EventArgs) Handles rdoCorrectNo.CheckedChanged

        ' If the 'No' radio button is selected, the 'Continue' label & button become invisible, while the 'Update Details' button and label become/remain visible '

        If rdoCorrectNo.Checked = True Then

            ' Hides the 'Continue' label '
            lblContinue.Hide()

            ' Hides the 'Next' button '
            btnNext.Visible = False

            ' Shows the 'Update Details' label '
            lblUpdateDetails.Show()

            ' Shows the 'Update Details' button '
            btnUpdateDetails.Visible = True

        End If

    End Sub

    Private Sub btnUpdateDetails_Click(sender As Object, e As EventArgs) Handles btnUpdateDetails.Click

        frmRegisterDetails.Show()
        EmployeeEmail = ""
        FullName = ""
        lstUserInfoOutput.ClearSelected()

    End Sub

    Private Sub btnNext_Click(sender As Object, e As EventArgs) Handles btnNext.Click

        frmCustomerDetails.Show()

    End Sub

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click

        Me.Hide()
        frmRegisterDetails.Show()

    End Sub
End Class