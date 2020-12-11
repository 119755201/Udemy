Public Class frmRegisterDetails

    Public Property strUserEmail As String

    Dim strPassword, strRetypedPassword, strUserPassword As String

    Private Sub btnNext_Click(sender As Object, e As EventArgs) Handles btnNext.Click

        If txtPassword.Text <> txtRetypedPassword.Text Then

            txtPassword.Clear()
            txtRetypedPassword.Clear()

            MessageBox.Show("Password fields do not match. Please correct your input")

        Else

            txtPassword.Text = txtRetypedPassword.Text
            Me.Close()
            txtRetypedPassword.Text = strUserPassword

            Dim OBJ As New frmEmployeeConfirmation
            OBJ.strUserInfo = txtEmployeeName.Text
            OBJ.strUserEmail = txtEmployeeEmail.Text
            OBJ.Show()
            Me.Hide()

        End If

    End Sub

    Private Sub frmRegisterDetails_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        txtEmployeeEmail.Text = strUserEmail

    End Sub
End Class