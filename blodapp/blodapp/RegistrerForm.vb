
Public Class RegistrerForm
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click, Me.KeyPress
        SjekkInfo(postnrTxt.Text, adresseTxt.Text, pnummerTxt.Text, fornavnTxt.Text, etternavnTxt.Text, epostTxt.Text, tlfTxt.Text, finnFdato(pnummerTxt.Text), passordcTxt.Text, passordTxt.Text)
    End Sub


    Public Sub SjekkInfo(post_nr As String, adresse As String, pnummer As String, fornavn As String, etternavn As String, epost As String, tlf As String, fdato As String, passordc As String, passord As String)
        Dim Registrering As New RegBruker
        Dim info As New info
        Dim pHash As New passordHash
        Dim pros As New prosedyrer

        Dim data As DataTable
        data = info.query("epost", "bruker", "epost = '" & epost & "';")

        'MsgBox(data.Rows.Count)

        Dim godkjentEpost As Boolean = False
        Dim godkjentTelefon As Boolean = False
        Dim godkjentPassord As Boolean = False

        If pros.validateEmail(epost) = True Then
            If data.Rows.Count > 0 Then
                MsgBox("E-posten finnes fra før. Har du glemt passord?")
            Else
                godkjentEpost = True
                'MsgBox(godkjentEpost)
            End If
        Else
            MsgBox("Epost ikke godkjent. Sjekk om du har husket @")
        End If

        If IsNumeric(tlf) And tlf.Length = 8 Then
            godkjentTelefon = True
        Else
            MsgBox("Telefonnummeret må være 8 siffer")
        End If

        If passordc = passord Then
            godkjentPassord = True
        Else
            MsgBox("Passordene du anga stemmer ikke overens")
        End If

        'Når info er sjekket og godkjent så utføres funksjonen *sendInfo* som finnes i regbruker.vb
        If godkjentEpost = True And godkjentTelefon = True And godkjentPassord = True Then
            Dim salt As String
            Dim passordHash As String = ""
            salt = pHash.lagSalt
            passordHash = pHash.lagSaltetHash(passordTxt.Text, salt)

            Registrering.sendInfo(post_nr,
                                  adresse,
                                  pnummer,
                                  "0",
                                  fornavn,
                                  etternavn,
                                  epost,
                                  tlf,
                                  fdato,
                                  adresse,
                                  passordHash,
                                  salt)
            MsgBox("Registrering fullført." & vbCrLf & "Brukernavnet ditt er: " & epost & vbCrLf & vbCrLf & "Du kan nå gi samtykke ved resepsjonen")
            Me.Close()
            LoginForm.Show()
        End If
    End Sub

    Function finnFdato(person_nr As String)
        Dim fdato As String
        Dim i As Integer

        For i = 1 To 6
            fdato += (Mid(person_nr, i, 1))
        Next i

        MsgBox(fdato)
        Return fdato
    End Function

    Private Sub tilbakeBtn_Click(sender As Object, e As EventArgs) Handles tilbakeBtn.Click
        Me.Close()
        LoginForm.Show()
    End Sub

End Class