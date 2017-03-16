Imports System.Text.RegularExpressions

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

        Dim fornavn As String = fornavnTxt.Text
        Dim etternavn As String = etternavnTxt.Text


        Dim godkjentEpost As Boolean = False
        Dim godkjentTelefon As Boolean = False

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

        If godkjentEpost = True And godkjentTelefon = True Then
            MsgBox("Registrering fullført." & vbCrLf & "Brukernavnet ditt er: " & epostTxt.Text & vbCrLf & vbCrLf & "Du kan nå gi samtykke ved resepsjonen")
        End If
    End Sub


End Class