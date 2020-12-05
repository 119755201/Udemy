Public Class frmCustomerInformation

    ' Declaring different variables to hold customer information '

    Public Property strCustomerName As String
    Public Property strAge As String
    Public Property strStAddress As String
    Public Property strTown As String
    Public Property strCounty As String
    Public Property strEirCode As String
    Public Property strContactNumber As String
    Public Property strCardNumber As String

    ' The code below within "Private Sub btnStart" will execute when the "Start" button is selected ' 

    Private Sub btnStart_Click(sender As Object, e As EventArgs) Handles btnAdd.Click

        ' If the data in the Customer Name text box contains a String, it will be attached to the variable strCustomerName '
        If txtCustomerName.Text <> "" Then
            txtCustomerName.Text = strCustomerName

            ' If the above parameters cannot be met, the below function will execute '
        ElseIf txtCustomerName.Text = "" Then

            ' Displays a message to the end user with the below text: '
            MessageBox.Show("Please correct your input in order to proceed to the next step")

        End If

    End Sub
End Class
