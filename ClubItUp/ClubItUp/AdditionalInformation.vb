Public Class frmAdditionalInformation
    Private Sub lblDetailsCorrect_Click(sender As Object, e As EventArgs) Handles lblDetailsCorrect.Click

    End Sub

    Private Sub rdoCorrectYes_CheckedChanged(sender As Object, e As EventArgs) Handles rdoCorrectYes.CheckedChanged

        If rdoCorrectYes.Checked = True Then
            btnNext.Visible = True

        Else

            If rdoCorrectNo.Checked = True Then
                btnNext.Visible = False
            End If
        End If

    End Sub

    Private Sub btnNext_Click(sender As Object, e As EventArgs) Handles btnNext.Click

        Me.Hide()

    End Sub
End Class