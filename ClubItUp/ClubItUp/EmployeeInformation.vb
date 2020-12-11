Public Class frmEmployeeConfirmation


    Private Sub frmCustomerInformation_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        lstUserInfoOutput.Items.Add("User Name: " & FullName)
        lstUserInfoOutput.Items.Add("User Email: " & EmployeeEmail)


    End Sub

    Private Sub lbxUserInfoOutput_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lstUserInfoOutput.SelectedIndexChanged

    End Sub
End Class