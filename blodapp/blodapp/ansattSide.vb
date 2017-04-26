Public Class ansattSide
    Dim kommentar As String

    'Kode som utføres når siden lastes og lukker login form
    Private Sub ansattSide_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Sentrerer siden når den lastes
        Me.CenterToParent()

        'utfører diverse funksjoner når siden lastes
        lastBlodType()
        oppdaterBestillinger()
        kalenderToUker()
        blodFullOversikt()
        oppdaterInnkallinger()
        fyllEgenNavn()

        LoginForm.Hide()
    End Sub

    'logger ut den gjeldende brukeren og viser login form igjen
    Private Sub loggutBtn_Click(sender As Object, e As EventArgs) Handles loggutBtn.Click
        Dim pros As New prosedyrer
        Me.Close()
        pros.loggUt()
        LoginForm.Show()
    End Sub

    'Knapp for å endre passord. 
    Private Sub endrePwBtn_Click(sender As Object, e As EventArgs) Handles endrePwBtn.Click
        Dim pros As New prosedyrer
        pros.endrePw(LoginForm.bnavn)
    End Sub

    Private Sub btnbehov_click(sender As Object, e As EventArgs) Handles btnBehov.Click
        regnUtBehov()
    End Sub

    'Oppdaterer listbox når man skifter blodtype. 
    Private Sub CBoxBlodtype_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CBoxBlodtype.SelectedIndexChanged
        Dim blodtype As String

        blodtype = CBoxBlodtype.Text

        hentBlodGiverInfo(blodtype)
    End Sub

    'Knapp for hurtigbestilling. 
    Private Sub btnHurtigB_Click(sender As Object, e As EventArgs) Handles btnHurtigB.Click
        Dim hurtigbestilling As New hurtigBestilling
        hurtigbestilling.lastBGTlf(CBoxBlodtype.Text)
        hurtigbestilling.Show()
    End Sub

    'Knapp for å sende bestilling. 
    Private Sub btnInnkalling_Click(sender As Object, e As EventArgs) Handles btnInnkalling.Click
        sendInnkalling()
    End Sub

    'Knapp for å sende 
    Private Sub btnRetur_Click(sender As Object, e As EventArgs) Handles btnReturBestilling.Click
        sendBestillingRetur()
    End Sub

    Private Sub btnSend_Click(sender As Object, e As EventArgs) Handles btnGodkjennBestilling.Click
        sendGodkjentBestilling()
    End Sub

    'utfører funksjon hvis chkBekreft er huket av
    Private Sub chkBekreft_CheckedChanged(sender As Object, e As EventArgs) Handles chkBekreft.CheckedChanged
        If chkBekreft.Checked = False Then
            btnGodkjennBestilling.Enabled = False
        Else
            btnGodkjennBestilling.Enabled = True
        End If
    End Sub

    'fyller ut info basert på blodtype og blodprodukt 
    Private Sub CBoxProdukt_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cBoxProdukt.SelectedIndexChanged
        Dim blodtype As String
        Dim produkt As String

        blodtype = cBoxOversikt.SelectedItem
        produkt = cBoxProdukt.SelectedItem

        blodInfo()
    End Sub

    'Utføres når en bruker velges på egenerklæring
    Private Sub lstEgenerk_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lstEgenNavn.SelectedIndexChanged
        fyllEgenSkjema(CType(lstEgenNavn.SelectedItem, listItem).value)
    End Sub

    'Knapp for å se egenerklæring. avhengig av lstEgennavn og lstEgenDato
    Private Sub btnSeEgen_Click(sender As Object, e As EventArgs) Handles btnSeEgen.Click
        seEgenerklaering()
    End Sub

    Private Sub btnBehandle_Click(sender As Object, e As EventArgs) Handles btnBehandle.Click
        behandleInnkalling()
    End Sub

    Private Sub btnRegBruker_Click(sender As Object, e As EventArgs) Handles btnRegBruker.Click
        RegistrerForm.Show()
    End Sub

    Private Sub btnSokBruker_Click(sender As Object, e As EventArgs) Handles btnSokBruker.Click
        sokbruker()
    End Sub

    Private Sub btnLeggInnTime_Click(sender As Object, e As EventArgs) Handles btnLeggInnTime.Click
        leggInnTime()
    End Sub

    Private Sub lstBestillinger_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lstBestillinger.SelectedIndexChanged
        fyllBestilling()
    End Sub

    '******************FUNKSJONER OG PROSEDYRER***********************

    'laster inn blodtype i CBoxBlodType
    Public Sub lastBlodType()
        'Importerer info-klassen som inneholder query-funksjon
        Dim info As New info
        'Lager en ny tabell som inneholder data fra query
        Dim CountTabell As New DataTable
        'Tømmer combo-box før query
        CBoxBlodtype.Items.Clear()

        'Utfører query ved hjelp av funksjonen query under klassen info. 
        CountTabell = info.query("blodtype", "blodgiver", "1 GROUP BY blodtype")

        'For hver blodtype i blodtype-tabell legges en til i combo-box. Dvs. fyller ikke ut blodtyper som ikke finnes i systmet
        For Each rad In CountTabell.Rows
            CBoxBlodtype.Items.Add(rad("blodtype"))
        Next
    End Sub

    'henter aktuelle blodgivere sortert på blodtype
    Public Sub hentBlodGiverInfo(blodtype As String)
        'Importerer info - klassen som inneholder query-funksjon
        Dim info As New info
        'Lager en ny tabell som inneholder data fra query
        Dim Tabell As New DataTable
        'Tømmer combo - box før query
        lstKandidater.Items.Clear()

        'Utfører query ved hjelp av funksjonen query under klassen info. 
        Tabell = info.queryJoin("fornavn, etternavn, bruker.person_nr", "bruker", "blodgiver ON bruker.person_nr = blodgiver.person_nr", "blodtype = '" & blodtype & "';")

        'Legger til kandidater basert på hva som er valgt i ComboBox
        For Each rad In Tabell.Rows
            lstKandidater.Items.Add(New listItem With {.display = rad("fornavn") & " " & rad("etternavn"), .value = rad("person_nr")})
        Next
        Dim sResult As String = ""

    End Sub

    'oppdaterer innkallinger, både ubehandlede og behandlede, og fyller disse i lstBehandlet og lstUbehandlet
    Private Sub oppdaterInnkallinger()
        Dim info As New info
        Dim ubehandletTabell As New DataTable
        Dim behandletTabell As New DataTable
        lstSvarInn.Items.Clear()
        lstBehandlet.Items.Clear()

        ubehandletTabell = info.queryJoin("innkallinger.person_nr, innkallinger.oppmote, bruker.fornavn, bruker.etternavn, innkallinger.innkallings_id, fritekst_innkalling, innkallinger.status", "innkallinger", "bruker ON bruker.person_nr = innkallinger.person_nr", "innkallinger.status = 1 ORDER BY innkallinger.oppmote ASC;")
        behandletTabell = info.queryJoin("innkallinger.person_nr, innkallinger.oppmote, bruker.fornavn, bruker.etternavn, innkallinger.innkallings_id, fritekst_innkalling, innkallinger.status", "innkallinger", "bruker ON bruker.person_nr = innkallinger.person_nr", "(innkallinger.status = 2 OR innkallinger.status = 3) ORDER BY innkallinger.oppmote ASC;")

        For Each rad As DataRow In ubehandletTabell.Rows
            lstSvarInn.Items.Add(New listItem With {.display = rad("oppmote") & ", " & rad("fornavn") & ", " & rad("etternavn"), .value = rad("innkallings_id")})
        Next

        For Each rad As DataRow In behandletTabell.Rows
            If rad("status") = 3 Then
                lstBehandlet.Items.Add(rad("oppmote") & ", " & rad("fornavn") & ", " & rad("etternavn") & ": Avvist")
            ElseIf rad("status") = 2 Then
                lstBehandlet.Items.Add(rad("oppmote") & ", " & rad("fornavn") & ", " & rad("etternavn") & ": Bekreftet")
            Else
                Continue For
            End If
        Next
    End Sub

    'prosedyre som brukes for å sende inn innkalling
    Public Sub sendInnkalling()
        Dim info As New info
        Dim pros As New prosedyrer
        Dim epost As New epost
        Dim janei As Integer
        Dim kommentar As String
        Dim epostAddr As String = ""
        Dim epostTab As DataTable

        MsgBox(lstKandidater.SelectedIndex)

        If lstKandidater.SelectedIndex = -1 Or cmbTime.SelectedIndex = -1 Or cmbMin.SelectedIndex = -1 Then
            MsgBox("Du må fylle ut alle feltene!")
            Exit Sub
        End If

        Dim valgtPnummer As String
        valgtPnummer = CType(lstKandidater.SelectedItem, listItem).value

        kommentar = InputBox("Kommentar: (frivillig)")

        epostTab = info.query("epost", "bruker", "person_nr = '" & valgtPnummer & "'")

        For Each rad As DataRow In epostTab.Rows
            epostAddr = rad("epost")
        Next

        janei = MsgBox("Vil du sende innkallingen?", MsgBoxStyle.YesNo)
        If janei = DialogResult.Yes Then
            info.sendInnkalling(valgtPnummer, 0, kommentar, tappeKalender.SelectionStart.ToString("yyyy/MM/dd") & " " & cmbTime.SelectedItem & ":" & cmbMin.SelectedItem & ":00")
            epost.sendEpost("Innkalling " & tappeKalender.SelectionStart.ToString("dd/MM/yyyy"), "Du har fått en innkalling til blodtapping den " & tappeKalender.SelectionStart.ToString("dd/MM/yyyy") & " klokken " & cmbTime.SelectedItem & ":" & cmbMin.SelectedItem & vbCrLf & "Har du spørsmål kan du ringe oss på 12345678" & vbCrLf & "Mvh Blodbanken", epostAddr)
        End If
    End Sub

    'henter ut info om blod basert på blodtype og blodprodukt
    Public Sub blodInfo()
        Dim info As New info
        Dim tabell As New DataTable

        Dim blodtype As String = cBoxOversikt.SelectedItem
        Dim produkt As String = cBoxProdukt.SelectedItem

        tabell = info.query("id", produkt, "blodtype = '" & blodtype & "';")

        lblResultat.Text = (tabell.Rows.Count * 0.45) & " liter"
    End Sub

    'henter ut full oversikt over blodbanken
    Public Sub blodFullOversikt()
        Dim connect As New SQL
        Dim oppkobling = connect.oppkobling
        Dim info As New info
        Dim tabellPlasma As New DataTable
        Dim tabellLegemer As New DataTable
        Dim tabellPlater As New DataTable

        tabellPlasma = info.query("count(blodtype), blodtype", "blodplasma", "1 GROUP BY blodtype")
        tabellLegemer = info.query("count(blodtype), blodtype", "blodlegemer", "1 GROUP BY blodtype")
        tabellPlater = info.query("count(blodtype), blodtype", "blodplater", "1 GROUP BY blodtype")

        Try
            lstFullOversikt.Items.Add("Blodplasma: ")
            For Each rad In tabellPlasma.Rows
                lstFullOversikt.Items.Add(rad("blodtype") & vbTab & rad("count(blodtype)"))

            Next
            lstFullOversikt.Items.Add("Blodplater")
            For Each rad In tabellPlater.Rows

                lstFullOversikt.Items.Add(rad("blodtype") & vbTab & rad("count(blodtype)"))

            Next
            lstFullOversikt.Items.Add("Blodlegemer: ")
            For Each rad In tabellLegemer.Rows
                lstFullOversikt.Items.Add(rad("blodtype") & vbTab & rad("count(blodtype)"))
            Next
        Catch feil As Exception
            MsgBox(feil.Message)
        End Try
    End Sub

    'Kalender for inkalling skal kun vise dato minst to uker etter dagens dato
    Public Sub kalenderToUker()
        Dim toUker As New Date
        toUker = Today.AddDays(14)
        tappeKalender.MinDate = toUker
    End Sub

    'Fyller tilgjengelige blodtyper i CBoxBlodtype. Brukes ved sendInkalling()
    Public Sub fyllBlodtype()
        Dim tabell As New DataTable
        Dim prosedyrer As New prosedyrer
        tabell = prosedyrer.lastinnBlodtype()
        For Each rad In tabell.Rows
            CBoxBlodtype.Items.Add(rad("blodtype"))
        Next
    End Sub

    'Oppdaterer bestillinger for å se om det har kommet noen 
    Public Sub oppdaterBestillinger()
        'Importerer info - klassen som inneholder query-funksjon
        Dim info As New info
        'Lager en ny tabell som inneholder data fra query
        Dim Tabell As New DataTable
        'Tømmer combo - box før query
        lstBestillinger.Items.Clear()

        'Utfører query ved hjelp av funksjonen query under klassen info. 
        Tabell = info.query("bestilling_id, til_bank, dato_sendt", "bestilling", "status = 0")

        'Legger til kandidater basert på hva som er valgt i ComboBox
        For Each rad In Tabell.Rows
            lstBestillinger.Items.Add(New listItem With {.display = "Fra = " & rad("til_bank") & ", sendt:" & rad("dato_sendt"), .value = rad("bestilling_id")})
        Next
    End Sub



    'Fyller ut valgt bestilling
    Private Sub fyllBestilling()
        Dim valgtBestilling As String
        valgtBestilling = CType(lstBestillinger.SelectedItem, listItem).value

        'Importerer info - klassen som inneholder query-funksjon
        Dim info As New info
        'Lager en ny tabell som inneholder data fra query
        Dim Tabell As New DataTable

        'Utfører query ved hjelp av funksjonen query under klassen info. 
        Tabell = info.query("*", "bestilling", "bestilling_id = " & valgtBestilling & "")

        'Legger til kandidater basert på hva som er valgt i ComboBox
        For Each rad In Tabell.Rows
            txtBlodtype.Text = rad("blodtype")
            txtLegemer.Text = rad("legemer") & " poser"
            txtPlasma.Text = rad("plasma") & " poser"
            txtPlater.Text = rad("plater") & " poser"
            txtLevering.Text = rad("dato_til")
        Next
    End Sub

    'Fyller lstEgenNavn med  brukere som har levert egenerklæring. Brukes for å hente egenerklæring
    Private Sub fyllEgenNavn()
        Dim info As New info
        Dim tabell As New DataTable
        lstEgenNavn.Items.Clear()

        tabell = info.queryJoin("DISTINCT skjema.person_nr, bruker.fornavn, bruker.etternavn", "skjema", "bruker ON bruker.person_nr = skjema.person_nr", "1 = 1")

        For Each rad As DataRow In tabell.Rows
            lstEgenNavn.Items.Add(New listItem With {.display = rad("fornavn") & " " & rad("etternavn"), .value = rad("person_nr")})
        Next
    End Sub

    'Fyller lstEgenDato med egenerklæringer. Brukes for å hente egenerklæring
    Private Sub fyllEgenSkjema(pnummer As String)
        Dim info As New info
        Dim tabell As New DataTable
        lstEgenDato.Items.Clear()

        tabell = info.query("skjema_id, dato", "skjema", "person_nr = " & pnummer & "")

        For Each rad As DataRow In tabell.Rows
            lstEgenDato.Items.Add(New listItem With {.display = rad("dato"), .value = rad("skjema_id")})
        Next
    End Sub

    'prosedyre for å behandle innkalling. kan bekrefte eller kansellere
    Private Sub behandleInnkalling()
        Dim info As New info
        Dim tabell As New DataTable
        Dim innId As Double

        If Not lstSvarInn.SelectedIndex >= 0 Then
            MsgBox("Du må velge en innkalling!")
            Exit Sub
        End If

        innId = CType(lstSvarInn.SelectedItem, listItem).value
        Dim customMsgBox As New MsgBoxCustom

        customMsgBox.Label1.Text = "Skal den valgte timen bekreftes eller kanselleres?"
        customMsgBox.Button1.Text = "Bekreft"
        customMsgBox.Button2.Text = "Kanseller"

        customMsgBox.ShowDialog()

        If customMsgBox.button1click = True Then
            info.queryUpdate("innkallinger", "status = 2", "innkallings_id = '" & innId & "';")
        ElseIf customMsgBox.button2click = True Then
            info.queryUpdate("innkallinger", "status = 3", "innkallings_id = '" & innId & "';")
        End If
        oppdaterInnkallinger()
    End Sub

    'Regner ut literbehov
    Public Sub regnUtBehov()
        Dim literbehov As Double
        Dim giverbehov As Integer
        Try
            If IsNumeric(txtLiterBehov.Text) = False Then
                MsgBox("du må skrive et tall når du skriver literbehov (bruk komma, ikke punktum for desimal)")
            Else
                literbehov = txtLiterBehov.Text
                giverbehov = Math.Ceiling(literbehov / 0.45)
                Label9.Text = "du trenger minst: " & giverbehov & " blodgivere" & vbCrLf & "for å få " & literbehov & " liter blod."
            End If
        Catch feil As Exception

            MsgBox(feil.Message)
        End Try
    End Sub

    'Sender bestilling i retur
    Public Sub sendBestillingRetur()
        'Importerer SQL-funksjon
        Dim info As New info

        Dim valgtBestilling As String
        valgtBestilling = CType(lstBestillinger.SelectedItem, listItem).value
        kommentar = InputBox("Skriv en kommentar til bestillingen")

        info.queryUpdate("bestilling", "status = 9, fritekst_svar = '" & kommentar & "'", "bestilling_id = " & valgtBestilling & "")
        oppdaterBestillinger()
    End Sub

    'henter ut egenerklæring basert på bruker og hvilken egenerklæring det skal has tak i 
    Public Sub seEgenerklaering()
        Dim egenerklaering As New egenerklaering

        If Not lstEgenNavn.SelectedIndex >= 0 Then
            MsgBox("Du må velge en person!")
            Exit Sub
        End If

        If Not lstEgenDato.SelectedIndex >= 0 Then
            MsgBox("Du må velge en egenerklæring!")
            Exit Sub
        End If

        egenerklaering.Show()
        egenerklaering.fyllSkjema(CType(lstEgenNavn.SelectedItem, listItem).value, CType(lstEgenDato.SelectedItem, listItem).value)
    End Sub

    'sender tilbake bestilling til lege/institusjon etc.
    Public Sub sendGodkjentBestilling()
        'Importerer SQL-funksjon
        Dim info As New info

        Dim valgtBestilling As String
        valgtBestilling = CType(lstBestillinger.SelectedItem, listItem).value

        If chkBekreft.Checked = False Then
            MsgBox("Du må godkjenne bestillingen før du kan sende den")
        Else
            info.queryUpdate("bestilling", "status = 1", "bestilling_id = " & valgtBestilling & "")
        End If
        oppdaterBestillinger()
    End Sub

    'legger inn time manuelt, uten at bruker må godkjenne denne på forhånd
    Private Sub leggInnTime()
        Dim epost As New epost
        Dim info As New info
        Dim status As Integer
        status = 2
        Dim pNr As Double
        pNr = CType(lstKandidater.SelectedItem, listItem).value
        Dim janei As Integer
        Dim epostTab As New DataTable
        Dim epostAddr As String = ""

        kommentar = InputBox("Skriv inn en kommentar")

        epostTab = info.query("epost", "bruker", "person_nr = '" & pNr & "'")

        For Each rad As DataRow In epostTab.Rows
            epostAddr = rad("epost")
        Next

        janei = MsgBox("Vil du sende innkallingen?", MsgBoxStyle.YesNo)
        If janei = DialogResult.Yes Then
            info.sendInnkalling(pNr, status, kommentar, tappeKalender.SelectionStart.ToString("yyyy/MM/dd") & " " & cmbTime.SelectedItem & ":" & cmbMin.SelectedItem & ":00")
            epost.sendEpost("Innkalling " & tappeKalender.SelectionStart.ToString("dd/MM/yyyy"), "Du har fått en innkalling til blodtapping den " & tappeKalender.SelectionStart.ToString("dd/MM/yyyy") & " klokken " & cmbTime.SelectedItem & ":" & cmbMin.SelectedItem & vbCrLf & "Har du spørsmål kan du ringe oss på 12345678" & vbCrLf & "Mvh Blodbanken", epostAddr)
        End If
    End Sub

    'brukes for å søke i brukere i databasen
    Private Sub sokbruker()
        Dim soking As New soking

        Dim sokeord As String = sokTxt.Text
        Dim resultatTab As New DataTable
        Dim sorter As String = "fornavn"

        Select Case sokSpesCmb.Text
            Case "fornavn"
                sorter = "fornavn"
            Case "etternavn"
                sorter = "etternavn"
            Case "e-post"
                sorter = "epost"
        End Select

        resultatTab = soking.sokBruker(sokeord, sorter)

        lstKandidater.Items.Clear()
        For Each rad As DataRow In resultatTab.Rows
            lstKandidater.Items.Add(New listItem With {.display = rad("Fornavn") & " " & rad("Etternavn") & " " & rad("Epost") & " " & rad("Fdato"), .value = rad("person_nr")})
        Next
    End Sub
End Class

