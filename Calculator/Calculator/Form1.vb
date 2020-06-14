Public Class frmCalculator

    ' Declare variables for later use '


    Dim firstNumber, secondNumber, resultOuput As Double

    Private Sub btnSubtract_Click(sender As Object, e As EventArgs) Handles btnSubtract.Click

        ' If the first & second textboxes contain data, that data will be converted to a double integer '

        If txtFirstNumber.Text <> "" And txtSecondNumber.Text <> "" Then
            firstNumber = CDbl(txtFirstNumber.Text)
            secondNumber = CDbl(txtSecondNumber.Text)
            resultOuput = firstNumber - secondNumber

            ' Result is equal to the total of firstNumber - secondNumber '


            txtresultOuput.Text = "The result of " & firstNumber & " - " & secondNumber & " = " & resultOuput

            ' In the event that incorrect data is entered e.g non numeric string, a message box will appear '

        Else MessageBox.Show("Please enter both numbers")

        End If

    End Sub

    Private Sub btnMultiply_Click(sender As Object, e As EventArgs) Handles btnMultiply.Click

        ' If the first & second textboxes contain data, that data will be converted to a double integer '


        If txtFirstNumber.Text <> "" And txtSecondNumber.Text <> "" Then
            firstNumber = CDbl(txtFirstNumber.Text)
            secondNumber = CDbl(txtSecondNumber.Text)
            resultOuput = firstNumber * secondNumber
            txtresultOuput.Text = "The result of " & firstNumber & " X " & secondNumber & " = " & resultOuput

        Else MessageBox.Show("Please enter both numbers")

        End If

    End Sub

    Private Sub txtFirstNumber_TextChanged(sender As Object, e As EventArgs) Handles txtFirstNumber.TextChanged

        txtresultOuput.Clear()

    End Sub

    Private Sub txtSecondNumber_TextChanged(sender As Object, e As EventArgs) Handles txtSecondNumber.TextChanged

        txtresultOuput.Clear()

    End Sub

    Private Sub frmCalculator_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btnAddition_Click(sender As Object, e As EventArgs) Handles btnAddition.Click

        If txtFirstNumber.Text <> "" And txtSecondNumber.Text <> "" Then
            firstNumber = CDbl(txtFirstNumber.Text)
            secondNumber = CDbl(txtSecondNumber.Text)
            resultOuput = firstNumber + secondNumber
            txtresultOuput.Text = "The result of " & firstNumber & " + " & secondNumber & " = " & resultOuput

        Else MessageBox.Show("Please enter both numbers")

        End If

    End Sub
End Class
