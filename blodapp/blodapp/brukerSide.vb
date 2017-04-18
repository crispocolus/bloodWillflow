Imports System.Globalization
Imports MySql.Data.MySqlClient

Public Class brukerSide
    Private Sub brukerSide_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        info()
        sjekkMelding()
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
        resultatTab = info.queryJoin("innkallinger.person_nr, innkallinger.oppmote, fritekst_innkalling", "innkallinger", "bruker ON bruker.person_nr = innkallinger.person_nr", " bruker.epost = '" & LoginForm.bnavn & "' AND innkallinger.status = 0;")

        'Sjekker innholdet i tabellen, hvis det er resultat får brukeren melding
        If resultatTab.Rows.Count > 0 Then
            MsgBox("DU HAR FÅTT " & resultatTab.Rows.Count & " innkalling(er)")
            For Each rad As DataRow In resultatTab.Rows
                innkallingLst.Items.Add(rad("fritekst_innkalling") & " " & rad("oppmote"))
            Next
        Else
        End If
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
End Class