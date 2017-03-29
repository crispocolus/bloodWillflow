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
            fornavnTxt.Text = (rad("fornavn"))
            etternavnTxt.Text = (rad("etternavn"))
            telefonTxt.Text = (rad("telefon"))
            epostTxt.Text = (rad("epost"))

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
End Class