Imports System.Text.RegularExpressions

Public Class RegistrerForm
    Public Function validateEmail(emailAddress) As Boolean
        ' Dim email As New Regex("^(?<user>[^@]+)@(?<host>.+)$")
        Dim email As New Regex("([\w-+]+(?:\.[\w-+]+)*@(?:[\w-]+\.)+[a-zA-Z]{2,7})")
        If email.IsMatch(emailAddress) Then
            Return True
        Else
            Return False
        End If
    End Function

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim epost As String
        Dim fornavn As String
        Dim etternavn As String
        Dim telefon As Integer

        Dim godkjentEpost As Boolean = False

        If validateEmail(TextBox1.Text) = True Then
            godkjentEpost = True
        Else
            MsgBox("Epost ikke godkjent. Sjekk om du har husket @")

        End If


        If godkjentEpost = True Then
            MsgBox("Registrering fullført." & vbCrLf & "Brukernavnet ditt er: " & epost & vbCrLf & vbCrLf & "Du kan nå gi samtykke ved resepsjonen")
        End If
    End Sub
End Class