Public Class frmCustomerDetails

    Private Sub btnNext_Click(sender As Object, e As EventArgs) Handles btnNext.Click

        ' When the 'Next' button is selected, the current form hides from view and the next form appears '
        Me.Visible = False

        ' frmCustomerDetails becomes visible '
        frmCustomerDetails2.Show()

    End Sub

    Private Sub txtContactNumber_TextChanged(sender As Object, e As EventArgs) Handles txtContactNumber.TextChanged

        ' If the contact number text box doesnt contain data/contains less than 6 characters '
        If txtContactNumPrefix.Text = "" And txtContactNumber.Text.Count < 6 Then

            ' The 'Next' button remains invisible to the end user '
            btnNext.Visible = False

        Else

            ' Otherwise if the data entered in the contact prefix can be converted to an integer '
            ' And happens to be equal to or more than 7'
            If CInt(txtContactNumPrefix.Text) And txtContactNumber.Text.Count >= 7 Then

                ' The 'Next' button will become visible '
                btnNext.Visible = True

            End If

        End If

    End Sub

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click

        ' Hides the current form from view when the 'back' button is selected
        Me.Hide()

        ' The previous form, additional information will also become visible '
        frmAdditionalInformation.Show()

    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click

        ' When selected, the 'Exit' button terminates the program. '
        Me.Close()
    End Sub
End Class