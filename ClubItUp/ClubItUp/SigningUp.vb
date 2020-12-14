Public Class frmRegisterDetails

    Dim strPassword, strRetypedPassword, strUserPassword As String

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click

        ' hides the current form from view and shows the previous form: frmSignUp '
        Me.Hide()
        frmSignUp.Show()

    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click

        Me.Close()

    End Sub

    Private Sub btnNext_Click(sender As Object, e As EventArgs) Handles btnNext.Click

        If txtPassword.Text <> txtRetypedPassword.Text And txtPassword.Text <> "" And txtRetypedPassword.Text <> "" Then
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

        ' Declares that the value declared in the string EmployeeEmail will be displayed in txtEmployeeEmail.Text '
        txtEmployeeEmail.Text = EmployeeEmail

    End Sub
End Class