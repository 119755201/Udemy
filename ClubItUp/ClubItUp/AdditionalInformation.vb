Public Class frmAdditionalInformation

    Private Sub rdoCorrectYes_CheckedChanged(sender As Object, e As EventArgs) Handles rdoCorrectYes.CheckedChanged

        ' If the 'Yes' radio button is selected, the 'Next' button become's visible to the end user '
        If rdoCorrectYes.Checked = True Then
            btnNext.Visible = True

        Else

            ' If the 'No' radio button is selected, the 'Next' button become's invisible to the end user '
            If rdoCorrectNo.Checked = True Then
                btnNext.Visible = False
            End If

        End If

    End Sub

    Private Sub btnNext_Click(sender As Object, e As EventArgs) Handles btnNext.Click

        ' Hides the current form from view and opens the next form in the programme, when the 'Next' button is selected '
        Me.Visible = False
        frmCustomerDetails.Show()

    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click


        ' Terminates the program when the 'Exit' button is selected '
        Me.Close()

    End Sub
End Class