Public Class frmSignUp

    Private Sub frmSignUp_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub


    Private Sub btnSignUp_Click(sender As Object, e As EventArgs) Handles btnSignUp.Click

        Dim OBJ As New frmRegisterDetails
        OBJ.strUserEmail = txtUserEmail.Text
        OBJ.Show()
        Me.Hide()


    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click

        ' Closes the current form which ends the application when the 'Exit' button is selected '
        Me.Close()

    End Sub
End Class
