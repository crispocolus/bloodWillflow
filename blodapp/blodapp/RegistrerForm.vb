
Public Class RegistrerForm
    Private Sub RegistrerForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'sentrerer vinduet i forhold til forrige vindu
        Me.CenterToParent()
    End Sub

    'knapp for å registrere bruker
    Private Sub btnRegistrer_Click(sender As Object, e As EventArgs) Handles btnRegistrer.Click, Me.KeyPress
        registrerBruker()
    End Sub

    'går tilbake til LoginForm
    Private Sub btnTilbake_Click(sender As Object, e As EventArgs) Handles btnTilbake.Click
        Me.Close()
        LoginForm.Show()
    End Sub

    'sørger for at bruker har lest vilkår, lar ikke bruker trykke på knapp uten
    Private Sub chkJegHarLest_CheckedChanged(sender As Object, e As EventArgs) Handles chkJegHarLest.CheckedChanged
        If chkJegHarLest.Checked = True Then
            btnRegistrer.Enabled = True
        Else
            btnRegistrer.Enabled = False
        End If
    End Sub

    'funksjon som sjekker info som skrives inn, for så å sende videre til query-funksjon i annen klasse
    Public Function SjekkSendInfo(post_nr As String, adresse As String, pnummer As String, fornavn As String, etternavn As String, epost As String, tlf As String, passordc As String, passord As String)
        Dim Registrering As New RegBruker
        Dim info As New info
        Dim pHash As New passordHash
        Dim pros As New prosedyrer
        Dim fdato As String

        Dim data As DataTable
        data = info.query("epost", "bruker", "epost = '" & epost & "';")

        Dim godkjentEpost As Boolean = False
        Dim godkjentTelefon As Boolean = False
        Dim godkjentPassord As Boolean = False
        Dim godkjentPostnr As Boolean = False
        Dim godkjentPnr As Boolean = False

        fdato = finnFdato(pnummer)

        If pros.validateEmail(epost) = True Then
            If data.Rows.Count > 0 Then
                'bruker egendefinert MsgBoxCustom-klasse
                Dim customMsgBox As New MsgBoxCustom
                With customMsgBox
                    .Label1.Text = "E-post er registrert fra før av. " & vbCrLf & "Vil du logge inn eller har du glemt passord?"
                    .Button1.Text = "Logg inn"
                    .Button2.Text = "Glemt passord"
                    .Button3.Visible = True
                    .Button3.Text = "Tilbake til registrering"
                    .ShowDialog()
                End With

                If customMsgBox.button1click = True Then
                    Me.Close()
                    LoginForm.Show()
                ElseIf customMsgBox.button2click = True Then
                    Me.Close()
                    Dim glemtPw As New prosedyrer
                    glemtPw.glemtPw()
                ElseIf customMsgBox.button3click = True Then
                    customMsgBox.Close()
                End If

            Else
                godkjentEpost = True
            End If
        Else
            MsgBox("Epost ikke godkjent. Sjekk om du har husket @")
            Return False
        End If

        If IsNumeric(tlf) And tlf.Length = 8 Then
            godkjentTelefon = True
        Else
            MsgBox("Telefonnummeret må være 8 siffer")
            Return False
        End If

        If IsNumeric(pnummer) And pnummer.Length = 11 Then
            Dim tabell As New DataTable
            tabell = info.query("*", "bruker", "person_nr ='" & pnummer & "';")

            If tabell.Rows.Count > 0 Then
                Dim customMsgBox As New MsgBoxCustom
                With customMsgBox
                    .Label1.Text = "Personnummer er registrert fra før av. " & vbCrLf & "Vil du logge inn eller har du glemt passord?"
                    .Button1.Text = "Logg inn"
                    .Button2.Text = "Glemt passord"
                    .Button3.Visible = True
                    .Button3.Text = "Tilbake til registrering"
                    .ShowDialog()
                End With

                If customMsgBox.button1click = True Then
                    Me.Close()
                    LoginForm.Show()
                ElseIf customMsgBox.button2click = True Then
                    Me.Close()
                    Dim glemtPw As New prosedyrer
                    glemtPw.glemtPw()
                ElseIf customMsgBox.button3click = True Then
                    customMsgBox.Close()
                End If
                Return False
            Else
                godkjentPnr = True
            End If

        Else
            MsgBox("Personnummer må være 11 siffer")
            Return False
        End If

        If IsNumeric(post_nr) And post_nr.Length = 4 Then
            Dim info2 As New info
            Dim tabell2 As New DataTable
            tabell2 = info.query("post_nr", "postnummer", "post_nr ='" & post_nr & "';")
            If tabell2.Rows.Count > 0 Then
                godkjentPostnr = True
            Else
                MsgBox("Ugyldig postnummer")
                Return False
            End If

        Else
            MsgBox("Postnummer må være 4 siffer")
            Return False
        End If

        If passordc = passord Then
            godkjentPassord = True
        Else
            MsgBox("Passordene du anga stemmer ikke overens")
            Return False
        End If

        'Når info er sjekket og godkjent så utføres funksjonen *sendInfo* som finnes i regbruker.vb
        If godkjentEpost = True And godkjentTelefon = True And godkjentPassord = True And godkjentPostnr = True And godkjentPnr = True Then
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
            Return True
        Else
            Return False
        End If
    End Function

    'finner fødselsdato basert på personnr
    'finner bare født FØR 2000 (dårlig implementasjon)
    Function finnFdato(person_nr As String)
        Dim fdato As String = ""
        Dim i As Integer

        fdato += "1"
        fdato += "9"

        For i = 5 To 6
            If i = 6 Then
                fdato += (Mid(person_nr, i, 1)) & "-"
            Else
                fdato += (Mid(person_nr, i, 1))
            End If
        Next i

        For i = 3 To 4
            If i = 4 Then
                fdato += (Mid(person_nr, i, 1)) & "-"
            Else
                fdato += (Mid(person_nr, i, 1))
            End If
        Next i

        For i = 1 To 2
            fdato += (Mid(person_nr, i, 1))
        Next

        Return fdato
    End Function

    'kode som utføres for å registrere bruker
    Private Sub registrerBruker()
        If SjekkSendInfo(postnrTxt.Text, adresseTxt.Text, pnummerTxt.Text, fornavnTxt.Text, etternavnTxt.Text, epostTxt.Text, tlfTxt.Text, passordcTxt.Text, passordTxt.Text) = False Then
            MsgBox("Bruker ble ikke registrert")
        Else

            'sjekker om brukeren ble registret i programmet eller utenfor (ansatt kan registrere bruker, men da trenger man ikke loggge ut av applikasjonen)
            If LoginForm.bnavn = "" Then
                MsgBox("Registrering fullført." & vbCrLf & "Brukernavnet ditt er: " & epostTxt.Text & vbCrLf & vbCrLf & "Du kan nå gi samtykke ved resepsjonen")
                Me.Close()
                LoginForm.Show()
            Else
                MsgBox("Registrering fullført.")
                Me.Close()
                LoginForm.Show()
            End If
        End If
    End Sub
End Class