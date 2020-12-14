Public Class frmCustomisationOptions

    ' Declaring variables for later use '

    Dim StripesSubtotal, StripesPrice, ShortsPrice, HoodiePrice, JerseyPrice As Double
    Dim ShortsQuantity, JerseyQuantity, HoodieQuantity As Integer

    Private Sub btnAddJerseyTotal_Click(sender As Object, e As EventArgs) Handles btnAddJerseyTotal.Click

        ' Determining the total costs involved when purchasing a jersey '

        txtJerseySubtotal.Text = (JerseyPrice * JerseyQuantity) + CInt(txtExtraStripesJersey.Text) * StripesPrice

    End Sub

    Private Sub txtShortsQuantity_TextChanged(sender As Object, e As EventArgs) Handles txtShortsQuantity.TextChanged

        ' If the text in the Shorts quantity box changes, the Extra Stripes box will accept user input '

        txtExtraStripes.ReadOnly = False

    End Sub

    Dim StripesNum As Integer = CInt(txtExtraStripes.Text)

    Private Sub btnAddShortsTotal_Click(sender As Object, e As EventArgs) Handles btnAddShortsTotal.Click

        ' Determining the total costs involved when purchasing  shorts '

        txtShortsSubStripes.Text = (ShortsPrice * ShortsQuantity) + StripesNum * StripesPrice

    End Sub

    Private Sub txtExtraStripes_TextChanged(sender As Object, e As EventArgs) Handles txtExtraStripes.TextChanged


        If Integer.TryParse(txtExtraStripes.Text, StripesNum) Then

            If StripesNum > 2 Then
                MessageBox.Show("Please note that a maximum of 3 stripes is allowed", "OK")
                txtExtraStripes.Text = 2

            ElseIf StripesNum < 2 Then

            End If

        End If

    End Sub

    Private Sub CustomisationOptions_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        ShortsQuantity = CInt(txtShortsQuantity.Text)


        ShortsPrice = 5.5
        JerseyPrice = 30.5
        HoodiePrice = 40.99

        txtShortsPrice.Text = ShortsPrice
        txtJerseyPrice.Text = JerseyPrice
        txtHoodiePrice.Text = HoodiePrice

    End Sub
End Class