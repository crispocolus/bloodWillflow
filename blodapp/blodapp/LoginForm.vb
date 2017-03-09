Imports MySql.Data.MySqlClient
Public Class LoginForm
    Private Sub LoginForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        Dim logginntest As Login
        logginntest = New Login
        logginntest.brukernavn = txtLoginBrukernavn.Text
        logginntest.passord = txtLoginPwd.Text


    End Sub
End Class
