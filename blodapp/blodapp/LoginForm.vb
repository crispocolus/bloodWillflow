Imports MySql.Data.MySqlClient
Imports System.Security.Cryptography
Imports System.Text

Public Class LoginForm
    'Brukes for å vite hvem som er innlogget
    Public bnavn As String

    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        'Lager et nytt SQL og et nytt Login-objekt. 
        Dim connect As New SQL
        Dim logginntest As New Login

        'Skriver brukernavn til logginntest-objektet
        logginntest.brukernavn = txtLoginBrukernavn.Text.Replace("'", "\'")

        'Skriver passordet til en variabel som brukes i hasingen
        Dim unhashed As String = txtLoginPwd.Text

        'Definerer en ny variabel for saltet
        Dim salt As String = 0

        bnavn = txtLoginBrukernavn.Text

        'Funksjon for å hente salt fra databasen. Brukes ikke enda. 

        Try
            Dim oppkobling = connect.oppkobling
            oppkobling.Open()

            Dim sqlSporring = "select salt from bruker where epost=@brukernavn"
            Dim sql As New MySqlCommand(sqlSporring, oppkobling)

            sql.Parameters.AddWithValue("@brukernavn", bnavn)
            sql.ExecuteNonQuery()

            Dim leser = sql.ExecuteReader()
            While leser.Read()
                salt = (leser("salt"))
            End While

            leser.Close()
            oppkobling.Close()
        Catch ex As MySqlException
            MessageBox.Show("Noe gikk galt: " & ex.Message)
        End Try

        Dim hashed As String
        hashed = GetSaltedHash(unhashed, salt)

        MsgBox(salt & ", " & hashed & ", " & unhashed)
        logginntest.passord = hashed

        'logginntest.passord = unhashed

        logginntest.innlogging()


    End Sub

    Private Sub llblLoginReg_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles llblLoginReg.LinkClicked
        'Viser registreringskjema når brukeren trykker på "Registrer" knappen
        RegistrerForm.Show()
        Me.Hide()
    End Sub

    'Funksjon for å hashe passord. Heter deux fordi den brukes ved innlogging. 
    'Function cryptdeux(passord As String, salt As String) As String
    '    Dim HashObjekt = New Security.Cryptography.SHA256Managed()
    '    Dim bytes = System.Text.Encoding.ASCII.GetBytes(passord & salt)
    '    bytes = HashObjekt.ComputeHash(bytes)

    '    Dim hexStreng As String = ""
    '    For Each enByte In bytes
    '        hexStreng &= enByte.ToString("x2")
    '    Next
    '    MsgBox(hexStreng)
    '    Return hexStreng
    'End Function

    Private Function GetSaltedHash(pw As String, salt As String) As String
        Dim tmp As String = pw & salt

        ' or SHA512Managed
        Using hash As HashAlgorithm = New SHA256Managed()
            ' convert pw+salt to bytes:
            Dim saltyPW = Encoding.UTF8.GetBytes(tmp)
            ' hash the pw+salt bytes:
            Dim hBytes = hash.ComputeHash(saltyPW)
            ' return a B64 string so it can be saved as text 
            Return Convert.ToBase64String(hBytes)
        End Using

    End Function

    Private Sub llblLoginFgtPwd_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles llblLoginFgtPwd.LinkClicked
        Dim epost As New epost
        epost.sendEpost("hei på deg", "kristoffer.selbekk.hille@gmail.com")
    End Sub
End Class
