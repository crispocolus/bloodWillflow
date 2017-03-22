Imports MySql.Data.MySqlClient
Imports System.Security.Cryptography
Imports System.Text

Public Class LoginForm

    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        Dim logginntest As New Login
        logginntest.brukernavn = txtLoginBrukernavn.Text.Replace("'", "\'")
        Dim unhashed As String = txtLoginPwd.Text.Replace("'", "\'")
        'Dim salt As String = 0

        Dim bnavn As String = txtLoginBrukernavn.Text
        'Try
        '    Dim connect As New SQL
        '    Dim oppkobling = connect.oppkobling
        '    oppkobling.Open()

        '    Dim sqlSporring = "select salt from bruker where epost=@brukernavn"
        '    Dim sql As New MySqlCommand(sqlSporring, oppkobling)

        '    sql.Parameters.AddWithValue("@brukernavn", bnavn)
        '    sql.ExecuteNonQuery()

        '    Dim leser = sql.ExecuteReader()
        '    While leser.Read()
        '        salt = (leser("salt"))
        '    End While

        '    leser.Close()
        '    oppkobling.Close()
        'Catch ex As MySqlException
        '    MessageBox.Show("Noe gikk galt: " & ex.Message)
        'End Try

        'Dim hashed As String
        'hashed = HashReverse(unhashed, salt)

        'MsgBox(salt & ", " & hashed & ", " & unhashed)

        logginntest.passord = unhashed
        logginntest.innlogging()
    End Sub

    Private Sub llblLoginReg_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles llblLoginReg.LinkClicked
        RegistrerForm.Show()
        Me.Hide()
    End Sub
    'Private Function HashPas(passord As String, salt As String)
    '    Dim test As New RegistrerForm
    '    Dim hashed As String
    '    hashed = (test.Hash512(passord, salt))
    '    Return hashed
    'End Function

    Public Function HashReverse(password As String, salt As String) As String
        Dim convertedToBytes As Byte() = Encoding.UTF8.GetBytes(password & salt)
        Dim hashType As HashAlgorithm = New SHA512Managed()
        Dim hashBytes As Byte() = hashType.ComputeHash(convertedToBytes)
        Dim hashedResult As String = Convert.ToBase64String(hashBytes)
        Return hashedResult
    End Function

    Private Sub txtLoginPwd_TextChanged(sender As Object, e As EventArgs) Handles txtLoginPwd.TextChanged

    End Sub
End Class
