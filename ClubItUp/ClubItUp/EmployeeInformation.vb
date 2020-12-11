Public Class frmEmployeeConfirmation

    Public Property strUserEmail As String
    Public Property strUserInfo As String



    Private Sub frmCustomerInformation_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        lstUserInfoOutput.Items.Add("Customer Email: " & strUserEmail)

    End Sub

    Private Sub lbxUserInfoOutput_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lstUserInfoOutput.SelectedIndexChanged

    End Sub
End Class