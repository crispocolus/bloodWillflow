Imports System.Globalization
Imports MySql.Data.MySqlClient

Public Class brukerSide
    Private Sub brukerSide_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        info()
        sjekkMelding()
        sjekkTime()
        Me.CenterToParent()
    End Sub


    Private Sub btnLoggUt_Click(sender As Object, e As EventArgs) Handles btnLoggUt.Click
        LoginForm.bnavn = ""
        Me.Close()
        LoginForm.Show()
        MsgBox("Du er nå logget ut")
    End Sub

    Public Sub info()
        'Importerer SQL og info ved nye objekt
        Dim info As New info
        Dim sql As New SQL

        'Oppretter 
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

    Public Sub sjekkMelding()
        'Importerer SQL og info objekt
        Dim info As New info
        Dim sql As New SQL

        'Opretter en datatabell og putter resultatet fra spørringen inni. Henter innkallinger basert på brukernavn og status. 
        Dim resultatTab As New DataTable
        resultatTab = info.queryJoin("innkallinger.person_nr, innkallinger.oppmote, innkallinger.innkallings_id, fritekst_innkalling", "innkallinger", "bruker ON bruker.person_nr = innkallinger.person_nr", " bruker.epost = '" & LoginForm.bnavn & "' AND innkallinger.status = 0;")

        'Sjekker innholdet i tabellen, hvis det er resultat får brukeren melding
        If resultatTab.Rows.Count > 0 Then
            MsgBox("DU HAR FÅTT " & resultatTab.Rows.Count & " innkalling(er)")
            For Each rad As DataRow In resultatTab.Rows
                innkallingLst.Items.Add(New ansattSide.listItem With {.display = rad("fritekst_innkalling") & " " & rad("oppmote"), .value = rad("innkallings_id")})
            Next
        Else
        End If
    End Sub

    Private Sub sjekkTime()
        Dim info As New info

        Dim tabell As New DataTable
        tabell = info.queryJoin("innkallinger.person_nr, innkallinger.oppmote, innkallinger.innkallings_id, fritekst_innkalling, innkallinger.status", "innkallinger", "bruker ON bruker.person_nr = innkallinger.person_nr", " bruker.epost = '" & LoginForm.bnavn & "' AND innkallinger.status = 1;")


        timeLst.Items.Clear()
        If tabell.Rows.Count > 0 Then
            For Each rad As DataRow In tabell.Rows

                timeLst.Items.Add(New ansattSide.listItem With {.display = rad("fritekst_innkalling") & " " & rad("oppmote") & " - UBEKREFTET", .value = rad("innkallings_id")})


            Next
        Else
        End If
    End Sub

    Private Sub sjekkInn()
        Dim info As New info
        Dim sql As New SQL

        Dim resultatTab As New DataTable
        resultatTab = info.queryJoin("innkallinger.person_nr, innkallinger.oppmote, innkallinger.innkallings_id, fritekst_innkalling", "innkallinger", "bruker ON bruker.person_nr = innkallinger.person_nr", " bruker.epost = '" & LoginForm.bnavn & "' AND innkallinger.status = 0;")

        innkallingLst.Items.Clear()
        For Each rad As DataRow In resultatTab.Rows
                innkallingLst.Items.Add(New ansattSide.listItem With {.display = rad("fritekst_innkalling") & " " & rad("oppmote"), .value = rad("innkallings_id")})
            Next

    End Sub

    Private Sub MonthCalendar2_DateChanged(sender As Object, e As DateRangeEventArgs) Handles MonthCalendar2.DateChanged
        hentInnkallingDato()
    End Sub

    Private Sub hentInnkallingDato()
        Dim info As New info
        Dim dato As String
        Dim data As New DataTable
        dato = MonthCalendar2.SelectionStart.ToString("yyyy/MM/dd")
        data = info.queryDato(dato)

        For Each rad As DataRow In data.Rows
            datoInkallLst.Items.Add(rad("fritekst_innkalling") & " " & rad("oppmote"))
        Next
    End Sub

    Private Sub Label5_Click(sender As Object, e As EventArgs) Handles Label5.Click

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        egenerklaering.Show()
    End Sub

    Private Sub btnEndrePersinfo_Click(sender As Object, e As EventArgs) Handles btnEndrePersinfo.Click
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

    Private Sub endrePwBtn_Click(sender As Object, e As EventArgs) Handles endrePwBtn.Click
        Dim pros As New prosedyrer
        pros.endrePw(LoginForm.bnavn)
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
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

    Private Sub btnAvbestillTime_Click(sender As Object, e As EventArgs) Handles btnAvbestillTime.Click
        Dim info As New info
        Dim innNr As Double
        Try


            innNr = CType(timeLst.SelectedItem, ansattSide.listItem).value
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







    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim info As New info
        Dim innNr As Double
        innNr = CType(innkallingLst.SelectedItem, ansattSide.listItem).value

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

    Private Sub bestillTime()
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



            '****Tanken er å sjekke om alt er fyllt ut, ellers virker ikke koden (kræsj)*****
            'If lstKandidater.SelectedItem Or cmbTime.SelectedItem Or cmbMin.SelectedItem = "" Then
            '    MsgBox("Du må fylle ut alle feltene!")
            '    Return
            'End If

            kommentar = InputBox("Kommentar: (frivillig)")

            tabell = info.query("epost, person_nr", "bruker", "epost = '" & bruker & "'")

            For Each rad As DataRow In tabell.Rows
                epostAddr = rad("epost")
                pNr = rad("person_nr")
            Next
            MsgBox(epostAddr & " " & pNr & " " & kommentar)

            '*************Oppsummering funker ikke enda, bare småplukk!!*****
            'MsgBox("Oppsummering: " & vbCrLf & "Navn: " & lstKandidater.SelectedItem & vbCrLf & "Dato: " & tappeKalender.SelectionStart.ToString("yyyy/MM/dd") & "Klokkeslett: " & cmbTime.SelectedItem & ":" & cmbMin.SelectedItem & vbCrLf & "Kommentar: " & kommentar & vbCrLf)

            janei = MsgBox("Vil du sende bestillingen?", MsgBoxStyle.YesNo)
            If janei = DialogResult.Yes Then
                info.sendInnkalling(pNr, 1, kommentar, MonthCalendar2.SelectionStart.ToString("yyyy/MM/dd") & " " & cmbTime.SelectedItem & ":" & cmbMin.SelectedItem & ":00")
                'epost.sendEpost("Innkalling " & MonthCalendar2.SelectionStart.ToString("dd/MM/yyyy"), "Du har fått en innkalling til blodtapping den " & MonthCalendar2.SelectionStart.ToString("dd/MM/yyyy") & " klokken " & cmbTime.SelectedItem & ":" & cmbMin.SelectedItem & vbCrLf & "Har du spørsmål kan du ringe oss på 12345678" & vbCrLf & "Mvh Blodbanken", epostAddr)
            End If

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub btnSokTime_Click(sender As Object, e As EventArgs) Handles btnSokTime.Click
        bestillTime()
        sjekkTime()
        sjekkInn()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Dim Egenerk As New EgenErk
        Dim table As New DataTable

        table = Egenerk.hentEgenErk(1231231231)
        For i = 1 To table.Rows.Count
            For Each rad In table.Rows
                ListBox4.Items.Add(rad(i))
            Next
        Next
    End Sub
End Class