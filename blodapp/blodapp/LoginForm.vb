Imports MySql.Data.MySqlClient
Public Class LoginForm
    'Dim SQLConnection As Object
    Private Sub LoginForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        Dim logginntest As New Login
        ' logginntest = New Login
        logginntest.brukernavn = txtLoginBrukernavn.Text
        logginntest.passord = txtLoginPwd.Text

        logginntest.innlogging()
        'SQLConnection.innlogging(txtLoginBrukernavn.Text, txtLoginPwd.Text)
    End Sub

    Private Sub llblLoginReg_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles llblLoginReg.LinkClicked
        RegistrerForm.Open()
    End Sub
End Class
