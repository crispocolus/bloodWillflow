Imports MySql.Data.MySqlClient
Imports System.Security.Cryptography
Imports System.Text

Public Class LoginForm
    Public bnavn As String

    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        Dim connect As New SQL

        Dim logginntest As New Login
        logginntest.brukernavn = txtLoginBrukernavn.Text.Replace("'", "\'")
        Dim unhashed As String = txtLoginPwd.Text
        Dim salt As String = 0

        logginntest.innloggetbrukernavn = txtLoginPwd.Text

        bnavn = txtLoginBrukernavn.Text
        'Try
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
        'hashed = cryptdeux(unhashed, salt)

        'MsgBox(salt & ", " & hashed & ", " & unhashed)
        'logginntest.passord = hashed

        logginntest.passord = unhashed
        logginntest.innlogging()
    End Sub

    Private Sub llblLoginReg_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles llblLoginReg.LinkClicked
        RegistrerForm.Show()
        Me.Hide()
    End Sub

    Function cryptdeux(passord As String, salt As String) As String
        Dim HashObjekt = New Security.Cryptography.SHA256Managed()
        Dim bytes = System.Text.Encoding.ASCII.GetBytes(passord & salt)
        bytes = HashObjekt.ComputeHash(bytes)

        Dim hexStreng As String = ""
        For Each enByte In bytes
            hexStreng &= enByte.ToString("x2")
        Next
        MsgBox(hexStreng)
        Return hexStreng
    End Function

    Private Sub txtLoginPwd_TextChanged(sender As Object, e As EventArgs) Handles txtLoginPwd.TextChanged

    End Sub
End Class
