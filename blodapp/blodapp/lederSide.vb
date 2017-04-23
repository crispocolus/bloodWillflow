﻿Public Class lederSide
    Dim kommentar As String

    'Kode som utføres når siden lastes
    Private Sub lederSide_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Sentrerer siden når den lastes
        Me.CenterToParent()

        lastBlodType()
        oppdaterBestillinger()
        kalenderToUker()
        blodFullOversikt()
        oppdaterInnkallinger()
        fyllEgenNavn()
        antBlodTapp()

        'Fyller info for antall personer med x blodtype på statistikk
        antallGivere("A+")
        antallGivere("A-")
        antallGivere("B+")
        antallGivere("B-")
        antallGivere("AB+")
        antallGivere("AB-")
        antallGivere("O+")
        antallGivere("O-")
    End Sub

    'logger ut den gjeldende brukeren
    Private Sub loggutBtn_Click(sender As Object, e As EventArgs) Handles loggutBtn.Click
        Dim pros As New prosedyrer
        Me.Close()
        pros.loggUt()
    End Sub

    'Knapp for å se egenerklæring. avhengig av lstEgennavn og lstEgenDato
    Private Sub btnSeEgen_Click(sender As Object, e As EventArgs) Handles btnSeEgen.Click
        seEgenerklaering()
    End Sub

    'Knapp for å endre passord. 
    Private Sub endrePwBtn_Click(sender As Object, e As EventArgs) Handles endrePwBtn.Click
        Dim pros As New prosedyrer
        pros.endrePw(LoginForm.bnavn)
    End Sub

    'kaller prosedyren blodTappetSiste() ved endret verdi
    Private Sub cmbSiste_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbSiste.SelectedIndexChanged
        blodTappetSiste()
    End Sub

    'regner ut literbehovet ved klikk
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

    'Knapp for å sende normal innkalling 
    Private Sub btnInnkalling_Click(sender As Object, e As EventArgs) Handles btnInnkalling.Click
        sendInnkalling()
    End Sub

    'Knapp for å sende bestilling i retur
    Private Sub btnRetur_Click(sender As Object, e As EventArgs) Handles btnRetur.Click
        sendBestillingRetur()
    End Sub

    Private Sub btnGodkjenn_Click(sender As Object, e As EventArgs) Handles btnGodkjenn.Click
        sendBestillingGodkjent()
    End Sub

    'lar ikke bestilling godkjennen før chkbox er huket av 
    Private Sub chkBekreft_CheckedChanged(sender As Object, e As EventArgs) Handles chkBekreft.CheckedChanged
        If chkBekreft.Checked = False Then
            btnGodkjenn.Enabled = False
        Else
            btnGodkjenn.Enabled = True
        End If
    End Sub

    'Oppdaterer blodinfo når verdien endres. 
    Private Sub CBoxProdukt_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cBoxProdukt.SelectedIndexChanged
        Dim blodtype As String
        Dim produkt As String

        blodtype = cBoxOversikt.SelectedItem
        produkt = cBoxProdukt.SelectedItem

        blodInfo()
    End Sub

    Private Sub lstBestillinger_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lstBestillinger.SelectedIndexChanged
        fyllBestilling()
    End Sub

    Private Sub btnBehandle_Click(sender As Object, e As EventArgs) Handles btnBehandle.Click
        behandleInnkalling()
    End Sub

    'Utføres når en bruker velges på egenerklæring
    Private Sub lstEgenerk_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lstEgenNavn.SelectedIndexChanged
        fyllEgenSkjema(CType(lstEgenNavn.SelectedItem, listItem).value)
    End Sub

    '*******FUNKSJONER OG PROSEDYRER************

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
            'lstKandidater.Items.Add(rad("fornavn") & " " & rad("etternavn"))
            lstKandidater.Items.Add(New listItem With {.display = rad("fornavn") & " " & rad("etternavn"), .value = rad("person_nr")})
        Next
        Dim sResult As String = ""

    End Sub

    'prosedyre som oppdaterer både behandlede og ubehandlede innkallinger.
    'hentes ut fra databasen
    Private Sub oppdaterInnkallinger()
        Dim info As New info
        Dim ubehandletTabell As New DataTable
        Dim behandletTabell As New DataTable
        lstSvarInn.Items.Clear()
        lstBehandlet.Items.Clear()

        ubehandletTabell = info.queryJoin("innkallinger.person_nr, innkallinger.oppmote, bruker.fornavn, bruker.etternavn, innkallinger.innkallings_id, fritekst_innkalling, innkallinger.status", "innkallinger", "bruker ON bruker.person_nr = innkallinger.person_nr", "innkallinger.status = 1 ORDER BY innkallinger.innkallings_id DESC;")
        behandletTabell = info.queryJoin("innkallinger.person_nr, innkallinger.oppmote, bruker.fornavn, bruker.etternavn, innkallinger.innkallings_id, fritekst_innkalling, innkallinger.status", "innkallinger", "bruker ON bruker.person_nr = innkallinger.person_nr", "(innkallinger.status = 2 OR innkallinger.status = 3) ORDER BY innkallinger.innkallings_id DESC;")

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

    'prosedyre som benyttes for å sende innkalling
    Public Sub sendInnkalling()
        Dim info As New info
        Dim pros As New prosedyrer
        Dim epost As New epost
        Dim janei As Integer
        Dim kommentar As String
        Dim epostAddr As String = ""
        Dim epostTab As DataTable

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

    'gir info over lagerbeholdning for en spesifikk blodtype
    Public Sub blodInfo()
        Dim info As New info
        Dim tabell As New DataTable

        Dim blodtype As String = cBoxOversikt.SelectedItem
        Dim produkt As String = cBoxProdukt.SelectedItem

        tabell = info.query("id", produkt, "blodtype = '" & blodtype & "';")

        lblResultat.Text = (tabell.Rows.Count * 0.45) & " liter"
    End Sub

    'fyller inn fyll oversikt over blodmengde
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

            ListBox1.Items.Add("Blodplasma: ")
            For Each rad In tabellPlasma.Rows
                ListBox1.Items.Add(rad("blodtype") & vbTab & rad("count(blodtype)"))

            Next
            ListBox1.Items.Add("Blodplater")
            For Each rad In tabellPlater.Rows

                ListBox1.Items.Add(rad("blodtype") & vbTab & rad("count(blodtype)"))

            Next
            ListBox1.Items.Add("Blodlegemer: ")
            For Each rad In tabellLegemer.Rows
                ListBox1.Items.Add(rad("blodtype") & vbTab & rad("count(blodtype)"))
            Next
        Catch feil As Exception
            MsgBox(feil.Message)
        End Try

    End Sub

    Public Sub kalenderToUker()
        'Kalender for inkalling skal kun vise dato minst to uker etter dagens dato
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

    'Regner ut behov for blodgivere basert på hvor mange liter en skal ha.
    'benytter seg kun av de blodtypene som finnes i databasen
    Public Sub regnUtBehov()
        Dim literbehov As Double
        Dim giverbehov As Integer
        Try
            If IsNumeric(TextBox1.Text) = False Then
                MsgBox("du må skrive et tall når du skriver literbehov (bruk komma, ikke punktum for desimal)")
            Else
                literbehov = TextBox1.Text
                giverbehov = Math.Ceiling(literbehov / 0.45)
                Label9.Text = "du trenger minst: " & giverbehov & " blodgivere" & vbCrLf & "for å få " & literbehov & " liter blod."
            End If
        Catch feil As Exception

            MsgBox(feil.Message)
        End Try
    End Sub

    'Sender bestilling i retur til lege/institusjon etc. 
    Public Sub sendBestillingRetur()
        'Importerer SQL-funksjon
        Dim info As New info

        Dim valgtBestilling As String
        valgtBestilling = CType(lstBestillinger.SelectedItem, listItem).value
        kommentar = InputBox("Skriv en kommentar til bestillingen")

        info.queryUpdate("bestilling", "status = 9, fritekst_svar = '" & kommentar & "'", "bestilling_id = " & valgtBestilling & "")
        oppdaterBestillinger()
    End Sub

    'sender tilbake en bestilling godkjent til lege/institusjon etc.
    Private Sub sendBestillingGodkjent()
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

    'viser egenerklæring, basert på blodgiver og aktuell egenerklæring 
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

    'fyller i lstAntallBlodgivere hvor mange aktive blodgivere som er registrert i databasen
    Private Sub antallGivere(blodtype As String)
        Dim info As New info
        Dim tabell As New DataTable


        tabell = info.queryJoin("COUNT(bruker.person_nr)", "bruker", "blodgiver ON bruker.person_nr = blodgiver.person_nr", "blodgiver.blodtype = '" & blodtype & "';")

        For Each rad In tabell.Rows
            lstAntallBlodgivere.Items.Add(blodtype & ": " & rad("COUNT(bruker.person_nr)") & " aktive blodgivere registrert")
        Next

    End Sub

    'prosedyre for å oppdatere stastistikken
    Private Sub btnRefresh_Click(sender As Object, e As EventArgs) Handles btnRefresh.Click

        lstAntallBlodgivere.Items.Clear()
        lstAntallTappinger.Items.Clear()

        antallGivere("A+")
        antallGivere("A-")
        antallGivere("B+")
        antallGivere("B-")
        antallGivere("AB+")
        antallGivere("AB-")
        antallGivere("O+")
        antallGivere("O-")

        Dim info As New info
        Dim tabell As New DataTable
        tabell = info.query("COUNT(tappe_id), MONTH(tappedato)", "tappesesjon", "YEAR(tappedato) = YEAR(CURDATE()) GROUP BY MONTH(tappedato)")

        For Each rad In tabell.Rows
            Select Case rad("MONTH(tappedato)")
                Case 1
                    lstAntallTappinger.Items.Add("Januar: " & rad("COUNT(tappe_id)"))
                Case 2
                    lstAntallTappinger.Items.Add("Februar: " & rad("COUNT(tappe_id)"))
                Case 3
                    lstAntallTappinger.Items.Add("Mars: " & rad("COUNT(tappe_id)"))
                Case 4
                    lstAntallTappinger.Items.Add("April: " & rad("COUNT(tappe_id)"))
                Case 5
                    lstAntallTappinger.Items.Add("Mai: " & rad("COUNT(tappe_id)"))
                Case 6
                    lstAntallTappinger.Items.Add("Juni: " & rad("COUNT(tappe_id)"))
                Case 7
                    lstAntallTappinger.Items.Add("Juli: " & rad("COUNT(tappe_id)"))
                Case 8
                    lstAntallTappinger.Items.Add("August: " & rad("COUNT(tappe_id)"))
                Case 9
                    lstAntallTappinger.Items.Add("September: " & rad("COUNT(tappe_id)"))
                Case 10
                    lstAntallTappinger.Items.Add("Oktober: " & rad("COUNT(tappe_id)"))
                Case 11
                    lstAntallTappinger.Items.Add("November: " & rad("COUNT(tappe_id)"))
                Case 12
                    lstAntallTappinger.Items.Add("Desember: " & rad("COUNT(tappe_id)"))
            End Select

        Next
    End Sub
    'fyller ut antall med blod tappet siste måned, kvartar eller år.
    'ikke helt 100% pga SQL-spørringen
    Private Sub blodTappetSiste()
        Dim info As New info
        Dim tabell As New DataTable
        Dim valg As String = 0

        lstBlodTappet.Items.Clear()
        Select Case cmbSiste.SelectedItem
            Case "Måned"
                valg = 1
            Case "Kvartal"
                valg = 3
            Case "År"
                valg = 12
        End Select
        tabell = info.query("COUNT(blodlegemer.id), COUNT(blodplasma.id), COUNT(blodplater.id)", "bruker
                             LEFT JOIN tappesesjon ON tappesesjon.person_nr = bruker.person_nr
                             LEFT JOIN blodlegemer ON blodlegemer.tappe_id = tappesesjon.tappe_id
                             LEFT JOIN blodplasma ON blodplasma.tappe_id = tappesesjon.tappe_id
                             LEFT JOIN blodplater ON blodplater.tappe_id = tappesesjon.tappe_id",
                            "tappesesjon.tappedato >= MONTH(CURDATE() - " & valg & ");")
        'SQL spørring funker ikke som den skal
        'skal hente ut

        For Each rad In tabell.Rows
            With lstBlodTappet.Items
                .Add((rad("COUNT(blodlegemer.id)")) * 0.45 & " liter blodlegemer")
                .Add((rad("COUNT(blodplasma.id)")) * 0.45 & " liter blodplasma")
                .Add((rad("COUNT(blodplater.id)")) * 0.45 & " liter blodplater")
            End With

        Next
    End Sub
    'Fyller info for antall blodtappinger på statistikk
    Private Sub antBlodTapp()

        Dim info As New info
        Dim tabell As New DataTable
        tabell = info.query("COUNT(tappe_id), MONTH(tappedato)", "tappesesjon", "YEAR(tappedato) = YEAR(CURDATE()) GROUP BY MONTH(tappedato)")

        For Each rad In tabell.Rows
            Select Case rad("MONTH(tappedato)")
                Case 1
                    lstAntallTappinger.Items.Add("Januar: " & rad("COUNT(tappe_id)"))
                Case 2
                    lstAntallTappinger.Items.Add("Februar: " & rad("COUNT(tappe_id)"))
                Case 3
                    lstAntallTappinger.Items.Add("Mars: " & rad("COUNT(tappe_id)"))
                Case 4
                    lstAntallTappinger.Items.Add("April: " & rad("COUNT(tappe_id)"))
                Case 5
                    lstAntallTappinger.Items.Add("Mai: " & rad("COUNT(tappe_id)"))
                Case 6
                    lstAntallTappinger.Items.Add("Juni: " & rad("COUNT(tappe_id)"))
                Case 7
                    lstAntallTappinger.Items.Add("Juli: " & rad("COUNT(tappe_id)"))
                Case 8
                    lstAntallTappinger.Items.Add("August: " & rad("COUNT(tappe_id)"))
                Case 9
                    lstAntallTappinger.Items.Add("September: " & rad("COUNT(tappe_id)"))
                Case 10
                    lstAntallTappinger.Items.Add("Oktober: " & rad("COUNT(tappe_id)"))
                Case 11
                    lstAntallTappinger.Items.Add("November: " & rad("COUNT(tappe_id)"))
                Case 12
                    lstAntallTappinger.Items.Add("Desember: " & rad("COUNT(tappe_id)"))
            End Select
        Next
    End Sub
End Class

