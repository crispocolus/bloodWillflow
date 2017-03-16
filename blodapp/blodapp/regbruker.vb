Public Class RegBruker
    Dim fornavn As String = RegistrerForm.fornavnTxt.Text
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
