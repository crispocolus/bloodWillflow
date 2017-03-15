Imports MySql.Data.MySqlClient
Public Class LoginForm

    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        Dim logginntest As New Login
        ' logginntest = New Login
        logginntest.brukernavn = txtLoginBrukernavn.Text
        logginntest.passord = txtLoginPwd.Text

        logginntest.innlogging()
        'SQLConnection.innlogging(txtLoginBrukernavn.Text, txtLoginPwd.Text)
    End Sub

    Private Sub llblLoginReg_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles llblLoginReg.LinkClicked
        RegistrerForm.Show()
        Me.Hide()
    End Sub
End Class
