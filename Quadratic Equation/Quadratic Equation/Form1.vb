Public Class frmQuadraticEquation
    Private Sub btnSolutions_Click(sender As Object, e As EventArgs) Handles btnSolutions.Click
        ' Variables Declared "

        Dim a, b, c As Double

        '   Statement declares that if the data in; txtA, txtB or txtC is a Double, then pass that value to the appropriate variable: a, b, or c. "

        If Double.TryParse(txtA.Text, a) And Double.TryParse(txtB.Text, b) And Double.TryParse(txtC.Text, c) Then

            ' As per the above rules, 'a' cannot equal 0 "

            ' The message box will notify the end user if the data is invalid via a message box with the below message " 

            If a = 0 Then
                MessageBox.Show("Please enter a non-zero value", "Invalid Input for 'a'", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                txtA.Clear()
            Else

                Dim determinant As Double = b ^ 2 - 4 * a * c

                Select Case determinant
                    Case < 0
                        txtSolutions.Text = "There is no solution"

                    Case = 0
                        txtSolutions.Text = "The solution is: " & ((-b) / (2 * a)).ToString("N")

                    Case Else
                        txtSolutions.Text = "Solution 1: " & (-b + Math.Sqrt(determinant)) / (2 * a) &
                                            " Solution 2: " & (-b - Math.Sqrt(determinant)) / (2 * a)
                End Select
            End If
            ' If the data entered in either of the text boxes (txtA, txtB or txtC) is non-numeric, the following message will appear "

        Else
            MessageBox.Show("Please correct your input", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub
End Class
