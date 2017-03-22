Imports System.Text.RegularExpressions
Imports System.Security.Cryptography
Imports System.Text

Public Class RegistrerForm
    Public Function validateEmail(emailAddress) As Boolean
        ' Dim email As New Regex("^(?<user>[^@]+)@(?<host>.+)$")
        Dim epostChar As New Regex("@")
        If epostChar.IsMatch(emailAddress) Then
            Return True
        Else
            Return False
        End If
    End Function

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        SjekkInfo()
    End Sub


    Public Sub SjekkInfo()
        Dim Registrering As New RegBruker
        Dim fornavn As String = fornavnTxt.Text
        Dim etternavn As String = etternavnTxt.Text
        Dim godkjentEpost As Boolean = False
        Dim godkjentTelefon As Boolean = False
        Dim godkjentPassord As Boolean = False

        If validateEmail(epostTxt.Text) = True Then
            godkjentEpost = True
        Else
            MsgBox("Epost ikke godkjent. Sjekk om du har husket @")
        End If

        If IsNumeric(tlfTxt.Text) And tlfTxt.TextLength = 8 Then
            godkjentTelefon = True
        Else
            MsgBox("Telefonnummeret må være 8 siffer")
        End If

        If passordcTxt.Text = passordTxt.Text Then
            godkjentPassord = True
        Else
            MsgBox("Passordene du anga stemmer ikke overens")
        End If

        'Når info er sjekket og godkjent så utføres funksjonen *sendInfo* som finnes i regbruker.vb
        If godkjentEpost = True And godkjentTelefon = True And godkjentPassord = True Then
            MsgBox("Registrering fullført." & vbCrLf & "Brukernavnet ditt er: " & epostTxt.Text & vbCrLf & vbCrLf & "Du kan nå gi samtykke ved resepsjonen")
            Dim salt As String
            Dim passordHash As String = ""
            salt = CreateRandomSalt()
            'passordHash = crypt(passordTxt.Text, salt)
            passordHash = passordTxt.Text


            Registrering.sendInfo(postnrTxt.Text,
                                  adresseTxt.Text,
                                  pnummerTxt.Text,
                                  fornavnTxt.Text,
                                  etternavnTxt.Text,
                                  epostTxt.Text,
                                  tlfTxt.Text,
                                  postnrTxt.Text,
                                  adresseTxt.Text,
                                  passordHash,
                                  salt)

            Me.Hide()
            LoginForm.Show()
        End If
    End Sub

    Public Function CreateRandomSalt() As String
        'the following is the string that will hold the salt charachters
        Dim mix As String = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789"
        '!@#$%^&*()_+=][}{<>"
        Dim salt As String = ""
        Dim rnd As New Random
        Dim sb As New StringBuilder

        Dim hexStreng As String = ""

        For i As Integer = 1 To 10 'Length of the salt
            Dim x As Integer = rnd.Next(0, mix.Length - 1)
            salt &= (mix.Substring(x, 1))
            For t As Integer = 1 To 10
                hexStreng &= t.ToString("x2")
            Next
        Next




        Return hexStreng
    End Function

    Public Function Hash512(password As String, salt As String) As String
        Dim convertedToBytes As Byte() = Encoding.UTF8.GetBytes(password & salt)
        Dim hashType As HashAlgorithm = New SHA512Managed()
        Dim hashBytes As Byte() = hashType.ComputeHash(convertedToBytes)
        Dim hashedResult As String = Convert.ToBase64String(hashBytes)
        Return hashedResult
    End Function

    Function crypt(passord As String, salt As String) As String
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
End Class