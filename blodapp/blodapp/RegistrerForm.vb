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
            Dim passordHash As String
            salt = CreateRandomSalt()
            passordHash = Hash512(passordTxt.Text, salt)

            Registrering.sendInfo(postnrTxt.Text,
                                  adresseTxt.Text,
                                  stdnavnTxt.Text,
                                  fylkeTxt.Text,
                                  pnummerTxt.Text,
                                  fornavnTxt.Text,
                                  etternavnTxt.Text,
                                  epostTxt.Text,
                                  tlfTxt.Text,
                                  passordHash,
                                  salt)
        End If
    End Sub

    Public Function CreateRandomSalt() As String
        'the following is the string that will hold the salt charachters
        Dim mix As String = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789!@#$%^&*()_+=][}{<>"
        Dim salt As String = ""
        Dim rnd As New Random
        Dim sb As New StringBuilder
        For i As Integer = 1 To 100 'Length of the salt
            Dim x As Integer = rnd.Next(0, mix.Length - 1)
            salt &= (mix.Substring(x, 1))
        Next
        Return salt
    End Function

    Public Function Hash512(password As String, salt As String) As String
        Dim convertedToBytes As Byte() = Encoding.UTF8.GetBytes(password & salt)
        Dim hashType As HashAlgorithm = New SHA512Managed()
        Dim hashBytes As Byte() = hashType.ComputeHash(convertedToBytes)
        Dim hashedResult As String = Convert.ToBase64String(hashBytes)
        Return hashedResult
    End Function
End Class