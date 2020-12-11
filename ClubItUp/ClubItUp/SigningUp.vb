Public Class frmRegisterDetails

    Dim strPassword, strRetypedPassword, strUserPassword As String

    Private Sub btnNext_Click(sender As Object, e As EventArgs) Handles btnNext.Click

        If txtPassword.Text <> txtRetypedPassword.Text Then

            txtPassword.Clear()
            txtRetypedPassword.Clear()

            MessageBox.Show("Password fields do not match. Please correct your input")

        Else
            FullName = txtEmployeeName.Text
            txtPassword.Text = txtRetypedPassword.Text
            Me.Close()
            txtRetypedPassword.Text = strUserPassword
            frmEmployeeConfirmation.Show()

        End If

    End Sub

    Private Sub frmRegisterDetails_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        txtEmployeeEmail.Text = EmployeeEmail

    End Sub
End Class