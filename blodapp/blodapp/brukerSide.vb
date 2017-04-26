Public Class brukerSide
    Private Sub brukerSide_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Henter inn diverse info ved innlasting av side og gjemmer login form
        hentpersonInfo()
        sjekkMelding()
        sjekkTime()
        'sørger for at kalenderen alltid er 14 dager i forveien 
        mndKal1.MinDate = Today.AddDays(14)
        Me.CenterToParent()
        LoginForm.Hide()
        fyllLabSvar(LoginForm.bnavn)
    End Sub

    'utfører utloggings-prosedyre når brukeren logger ut og viser login formet igjen
    Private Sub btnLoggUt_Click(sender As Object, e As EventArgs) Handles btnLoggUt.Click
        Dim pros As New prosedyrer
        Me.Close()
        pros.loggUt()
        LoginForm.Show()
    End Sub

    Private Sub mndKal1_DateChanged(sender As Object, e As DateRangeEventArgs) Handles mndKal1.DateChanged
        hentInnkallingDato()
    End Sub

    'viser egenerklæring når knapp trykkes
    Private Sub btnEgenErk_Click(sender As Object, e As EventArgs) Handles btnEgenErk.Click
        egenerklaering.Show()
    End Sub

    Private Sub btnEndrePersinfo_Click(sender As Object, e As EventArgs) Handles btnEndrePersinfo.Click
        endrePersonInfo()
    End Sub

    '
    Private Sub btnSokTime_Click(sender As Object, e As EventArgs) Handles btnSokTime.Click
        sendOnsketTime()
        sjekkTime()
        sjekkInn()
    End Sub

    Private Sub endrePwBtn_Click(sender As Object, e As EventArgs) Handles btnEndrePw.Click
        Dim pros As New prosedyrer
        pros.endrePw(LoginForm.bnavn)
    End Sub

    Private Sub btnLagrePInfo_Click(sender As Object, e As EventArgs) Handles btnLagrePInfo.Click
        lagrePersonInfo()
    End Sub

    Private Sub bnSvarInkalling_Click(sender As Object, e As EventArgs) Handles btnSvarInkalling.Click
        svarInnkalling()
    End Sub

    Private Sub btnAvbestillTime_Click(sender As Object, e As EventArgs) Handles btnAvbestillTime.Click
        avbestillTime()
    End Sub

    'henter ut info om brukeren ved innloggin
    Public Sub hentpersonInfo()
        'Importerer SQL og info ved nye objekt
        Dim info As New info
        Dim sql As New SQL

        'lister ut info i tekstboksene
        Dim resultatTab As New DataTable
        resultatTab = info.queryJoin("*", "bruker", "postnummer ON bruker.post_nr = postnummer.post_nr", "epost = '" & LoginForm.bnavn & "';")
        For Each rad As DataRow In resultatTab.Rows
            lblFornavn.Text = (rad("fornavn"))
            lblEtternavn.Text = (rad("etternavn"))
            lblTlf.Text = (rad("telefon"))
            lblEpost.Text = (rad("epost"))
            lblAdresse.Text = (rad("gateadresse"))
            lblPostnr.Text = (rad("post_nr"))
        Next
    End Sub

    'sjekker om brukeren har fått noen innkallinger
    Public Sub sjekkMelding()
        'Importerer SQL og info objekt
        Dim info As New info
        Dim sql As New SQL

        'Opretter en datatabell og putter resultatet fra spørringen inni. Henter innkallinger basert på brukernavn og status. 
        Dim resultatTab As New DataTable
        resultatTab = info.queryJoin("innkallinger.person_nr, innkallinger.oppmote, innkallinger.innkallings_id, fritekst_innkalling", "innkallinger", "bruker ON bruker.person_nr = innkallinger.person_nr", " bruker.epost = '" & LoginForm.bnavn & "' AND innkallinger.status = 0;")

        'Sjekker innholdet i tabellen, hvis det er resultat får brukeren melding
        If resultatTab.Rows.Count > 0 Then
            MsgBox("Du har mottatt " & resultatTab.Rows.Count & " innkalling(er)")
            For Each rad As DataRow In resultatTab.Rows
                innkallingLst.Items.Add(New listItem With {.display = rad("fritekst_innkalling") & " " & rad("oppmote"), .value = rad("innkallings_id")})
            Next
        Else
        End If
    End Sub

    'Sub for å fylle liste på Min Side tab med behandlet innkallinger/bestillinger av time for blodtapping
    Private Sub sjekkTime()
        Dim info As New info

        Dim tabell As New DataTable
        tabell = info.queryJoin("innkallinger.person_nr, innkallinger.oppmote, innkallinger.innkallings_id, fritekst_innkalling, innkallinger.status", "innkallinger", "bruker ON bruker.person_nr = innkallinger.person_nr", " bruker.epost = '" & LoginForm.bnavn & "' AND (innkallinger.status = '1' OR innkallinger.status ='2');")

        timeLst.Items.Clear()
        If tabell.Rows.Count > 0 Then
            For Each rad As DataRow In tabell.Rows
                If rad("status") = 1 Then
                    timeLst.Items.Add(New listItem With {.display = rad("oppmote") & " - UBEKREFTET", .value = rad("innkallings_id")})
                ElseIf rad("status") = 2 Then
                    timeLst.Items.Add(New listItem With {.display = rad("oppmote") & " - BEKREFTET", .value = rad("innkallings_id")})
                End If
            Next
        Else
        End If
    End Sub

    'prosedyre for å hente inn innkallinger som brukeren kan ha fått
    Private Sub sjekkInn()
        Dim info As New info
        Dim sql As New SQL

        Dim resultatTab As New DataTable
        resultatTab = info.queryJoin("innkallinger.person_nr, innkallinger.oppmote, innkallinger.innkallings_id, fritekst_innkalling", "innkallinger", "bruker ON bruker.person_nr = innkallinger.person_nr", " bruker.epost = '" & LoginForm.bnavn & "' AND innkallinger.status = 0;")

        innkallingLst.Items.Clear()
        For Each rad As DataRow In resultatTab.Rows
            innkallingLst.Items.Add(New listItem With {.display = rad("fritekst_innkalling") & " " & rad("oppmote"), .value = rad("innkallings_id")})
        Next
    End Sub

    'henter aktuelle innkallinger på valgt dato
    Private Sub hentInnkallingDato()
        Dim info As New info
        Dim dato As String
        Dim data As New DataTable
        dato = mndKal1.SelectionStart.ToString("yyyy/MM/dd")
        data = info.queryDato(dato)

        For Each rad As DataRow In data.Rows
            datoInkallLst.Items.Add(rad("fritekst_innkalling") & " " & rad("oppmote"))
        Next
    End Sub

    'prosedyre for å sende inn en ønsket time
    Private Sub sendOnsketTime()
        Dim info As New info
        Dim epost As New epost
        Dim janei As Integer
        Dim kommentar As String
        Dim epostAddr As String = ""
        Dim tabell As DataTable
        Dim pNr As Double
        Try
            Dim bruker As String
            bruker = LoginForm.bnavn

            kommentar = InputBox("Kommentar: (frivillig)")

            tabell = info.query("epost, person_nr", "bruker", "epost = '" & bruker & "'")

            For Each rad As DataRow In tabell.Rows
                epostAddr = rad("epost")
                pNr = rad("person_nr")
            Next

            janei = MsgBox("Vil du sende bestillingen?", MsgBoxStyle.YesNo)
            If janei = DialogResult.Yes Then
                info.sendInnkalling(pNr, 1, kommentar, mndKal1.SelectionStart.ToString("yyyy/MM/dd") & " " & cmbTime.SelectedItem & ":" & cmbMin.SelectedItem & ":00")
            End If

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    'gjemmer labels og viser tekstbokser når man skal endre brukerinfo
    Private Sub endrePersonInfo()
        lblFornavn.Hide()
        lblEtternavn.Hide()
        lblTlf.Hide()
        lblEpost.Hide()
        lblAdresse.Hide()
        lblPostnr.Hide()

        fornavnTxt.Text = lblFornavn.Text
        fornavnTxt.Visible = True
        etternavnTxt.Text = lblEtternavn.Text
        etternavnTxt.Visible = True
        epostTxt.Text = lblEpost.Text
        epostTxt.Visible = True
        telefonTxt.Text = lblTlf.Text
        telefonTxt.Visible = True
        adresseTxt.Text = lblAdresse.Text
        adresseTxt.Visible = True
        postnrTxt.Text = lblPostnr.Text
        postnrTxt.Visible = True
    End Sub

    'prosedyre for å lagre personinfo. utfører spørring som oppdaterer databasen
    Private Sub lagrePersonInfo()
        Try
            Dim info As New info
            Dim bruker As String = LoginForm.bnavn
            Dim fornavn As String = fornavnTxt.Text
            Dim etternavn As String = etternavnTxt.Text
            Dim epost As String = epostTxt.Text
            Dim telefon As Double = telefonTxt.Text
            Dim gateadresse As String = adresseTxt.Text
            Dim post_nr As Double = postnrTxt.Text

            info.queryUpdate("bruker", "fornavn = '" & fornavn & "', etternavn = '" & etternavn & "', epost = '" & epost & "', telefon = '" & telefon & "', gateadresse = '" & gateadresse & "'", "epost = '" & bruker & "';")

            MsgBox("Brukerinfo er blitt oppdatert")

            Dim tabell As New DataTable
            tabell = info.queryJoin("*", "bruker", "postnummer ON bruker.post_nr = postnummer.post_nr", "epost = '" & epostTxt.Text & "';")

            For Each rad In tabell.Rows
                lblFornavn.Text = (rad("fornavn"))
                lblEtternavn.Text = (rad("etternavn"))
                lblTlf.Text = (rad("telefon"))
                lblEpost.Text = (rad("epost"))
                lblAdresse.Text = (rad("gateadresse"))
                lblPostnr.Text = (rad("post_nr"))
            Next

            fornavnTxt.Text = lblFornavn.Text
            fornavnTxt.Visible = False
            etternavnTxt.Text = lblEtternavn.Text
            etternavnTxt.Visible = False
            epostTxt.Text = lblEpost.Text
            epostTxt.Visible = False
            telefonTxt.Text = lblTlf.Text
            telefonTxt.Visible = False
            adresseTxt.Text = lblAdresse.Text
            adresseTxt.Visible = False
            postnrTxt.Text = lblPostnr.Text
            postnrTxt.Visible = False

            lblFornavn.Show()
            lblEtternavn.Show()
            lblEpost.Show()
            lblAdresse.Show()
            lblPostnr.Show()
            lblTlf.Show()

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    'prosedyre som sender svar på mottatt innkalling
    Private Sub svarInnkalling()
        Dim info As New info
        Dim innNr As Double
        innNr = CType(innkallingLst.SelectedItem, listItem).value

        Dim customMsgBox As New MsgBoxCustom

        customMsgBox.Label1.Text = "Vil du bekrefte eller avkrefte denne innkallingen?"
        customMsgBox.Button1.Text = "Bekrefte"
        customMsgBox.Button2.Text = "Avkrefte"

        customMsgBox.ShowDialog()

        If customMsgBox.button1click = True Then
            info.queryUpdate("innkallinger", "status = 1", "innkallings_id = '" & innNr & "';")
        ElseIf customMsgBox.button2click = True Then
            info.queryUpdate("innkallinger", "status = 3", "innkallings_id = '" & innNr & "';")
        End If

        sjekkTime()
        sjekkInn()
    End Sub

    'proesdyre for å avbestille en mottatt time
    Private Sub avbestillTime()
        Dim info As New info
        Dim innNr As Double
        Try
            innNr = CType(timeLst.SelectedItem, listItem).value
            Dim svar
            svar = MsgBox("Er du sikker på at du vil avbestille timen?", MsgBoxStyle.YesNo Or MsgBoxStyle.Critical)

            If svar = MsgBoxResult.Yes Then
                info.queryUpdate("innkallinger", "status = 3", "innkallings_id = '" & innNr & "';")

                MsgBox("Time er avbestilt")
            Else
                Exit Sub
            End If

            sjekkTime()
        Catch ex As Exception
            MsgBox("Du må velge en time")
        End Try
    End Sub

    Public Sub fyllLabSvar(brukernavn)
        Dim info As New info
        Dim pros As New prosedyrer
        Dim tabell As New DataTable
        Dim person_nr As String

        person_nr = pros.finnPersonNummer(brukernavn)


        tabell = info.query("*", "labsvar", "person_nr = " & person_nr & "")

        For Each rad In tabell.Rows
            lstLabsvar.Items.Add("Tid sendt: " & rad("tid_sendt"))
            lstLabsvar.Items.Add("Kommentar: " & rad("fritekst_resultat"))
            lstLabsvar.Items.Add("CRP: " & rad("CRP"))
            lstLabsvar.Items.Add("Hvite blodceller: " & rad("hvit"))
            lstLabsvar.Items.Add("Røde blodceller:" & rad("rod"))
            lstLabsvar.Items.Add("Blodsukker: " & rad("blodsukker"))
        Next
    End Sub
End Class