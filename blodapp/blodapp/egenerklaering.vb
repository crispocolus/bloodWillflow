Imports System.IO
Public Class egenerklaering
    'arraylist som inneholder data fra egenerklæring
    Public svar As New ArrayList()
    'kode som utføres når egenerklæring lastes. 
    Private Sub egenerklaering_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'fyller ut combo-box med land ut ifra textfil i programmet
        cmbEgenLand.Items.AddRange(File.ReadAllLines("land.txt"))
        'sentrerer vinduet basert på forrige åpne vindu
        Me.CenterToParent()
    End Sub
    'utføres når knaoo for fram-klikkes
    Private Sub nesteSide(sender As Object, e As EventArgs) Handles btnEgenNext1.Click, btnEgenNext2.Click, btnEgenNext3.Click, btnEgenNext4.Click, btnEgenNext5.Click
        nesteSide()
    End Sub
    'utføres når knapp for tilbake-klikkes
    Private Sub forrigeSide(sender As Object, e As EventArgs) Handles btnEgenBack1.Click, btnEgenBack2.Click, btnEgenBack3.Click, btnEgenBack4.Click, btnEgenBack5.Click
        forrigeSide()
    End Sub
    'generell kode for å gå fram til neste side
    Private Sub nesteSide()
        TabControl1.SelectedIndex = TabControl1.SelectedIndex + 1
    End Sub
    'generell kode for å gå tilbake til forrige side
    Private Sub forrigeSide()
        TabControl1.SelectedIndex = TabControl1.SelectedIndex - 1
    End Sub
    'utfører kode når knapp for å sende skjema klikkes
    Private Sub btnEgenSubmit_Click(sender As Object, e As EventArgs) Handles btnEgenSubmit.Click
        submitSkjema()
        Me.Close()
    End Sub
    'utfører funksjon når chkSomFor krysses av
    'data beholdes selv om den krysses ut igjen fordi bruker kan verifisere at det stemmer uavhengig
    Private Sub ChkSomFor_CheckedChanged(sender As Object, e As EventArgs) Handles ChkSomFor.CheckedChanged
        Dim pros As New prosedyrer
        hentPersonalia(pros.finnPersonNummer(LoginForm.bnavn))
    End Sub
    'brukes for å hente ut personalia. personnummer som variabel
    Private Sub hentPersonalia(person_nr As String)
        'importerer klassen info fra SQLCOnnection.vb 
        Dim info As New info
        Dim pros As New prosedyrer
        Dim tabell As New DataTable

        tabell = info.query("*", "bruker", "person_nr = '" & person_nr & "'")

        For Each rad In tabell.Rows
            txtEgenFornavn.Text = rad("fornavn")
            txtEgenEtternavn.Text = rad("etternavn")
            txtEgenPrivatadresse.Text = rad("gateadresse")
            txtEgenPost_nr.Text = rad("post_nr")
            txtEgenTlf.Text = rad("telefon")
            txtEgenEpost.Text = rad("epost")
        Next
    End Sub
    'kode som brukes for å sende egenerklæringskjema opp til database
    Private Sub submitSkjema()
        'importerer EgenErk-klassen fra SQLConnection.vb som inneholder kode for query
        Dim egenerk As New EgenErk
        'importerer info-klassen fra SQLConnection.vb som inneholder generelle query
        Dim info As New info
        Try
            Dim dt As New DataTable
            Dim pnummer As String = ""
            Dim nr As Integer = 0
            svar.Clear()

            'sjekker gjennom alle checkboxer, og noterer ned verdi (0, 1)
            For Each tb In TabControl1.Controls.OfType(Of TabPage)()
                For Each pnl In tb.Controls.OfType(Of Panel)().OrderBy(Function(c) c.TabIndex)
                    For Each cb In pnl.Controls.OfType(Of CheckBox)()
                        If cb.Checked = True Then
                            nr += 1
                            svar.Add(1)
                        Else
                            nr += 1
                            svar.Add(0)
                        End If
                    Next
                Next
            Next

            'henter ut personnummer basert på innlogget brukernavn
            dt = info.query("person_nr", "bruker", "epost = '" & LoginForm.bnavn & "'")
            For Each rad In dt.Rows
                pnummer = rad("person_nr")
            Next

            'oppdaterer brukerinfo basert på om "som før" er huket av eller ikke
            If ChkSomFor.Checked = False Then
                egenerk.oppdaterBrukerInfo(pnummer, txtEgenFornavn.Text, txtEgenEtternavn.Text, txtEgenTlf.Text, txtEgenPrivatadresse.Text, txtEgenPost_nr.Text, txtEgenEpost.Text)
                Return
            End If

            'sender ut resultatet fra sendEgenErk i en meldingboks
            MsgBox(egenerk.sendEgenErk(pnummer, cmbEgenLand.SelectedIndex))

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    'kode for å fylle ut egenerklæringskjema med data fra database
    Public Sub fyllSkjema(pnummer As String, skjema_id As String)
        'importerer EgenErk-klassen fra SQLConnection.vb som inneholder kode for query
        Dim egenerk As New EgenErk
        'importerer info-klassen fra SQLConnection.vb som inneholder generelle query
        Dim info As New info
        Dim tabell As New DataTable

        hentPersonalia(pnummer)

        'sørger for at knapper ikke kan trykkes på (egenerklæring skal bare vises, ikke bli sendt på nytt)
        ChkSomFor.Enabled = False
        btnEgenNext1.Enabled = False
        btnEgenSubmit.Enabled = False
        cmbEgenLand.Enabled = False

        'bugfiksing; fikk ikke tid til å feilsøke (funksjonen nedenfor klarte på en eller annen måte ikke å 'skru av' alle check-boxer)
        CheckBox61.Enabled = False
        CheckBox1.Enabled = False

        'henter inn data til egenTabell, som inneholder svar fra egenerklæring
        egenerk.hentEgenTabellBruker(pnummer, skjema_id)
        egenerk.hentEgenTabell("skjema_besvar", skjema_id)
        egenerk.svarTabell.Add(0)
        egenerk.hentEgenTabell("skjema_fire_uker", skjema_id)
        egenerk.hentEgenTabell("skjema_to_aar", skjema_id)
        egenerk.hentEgenTabell("skjema_seks_mnd", skjema_id)
        egenerk.hentEgenTabell("skjema_livet", skjema_id)
        egenerk.hentEgenTabell("skjema_kvinner", skjema_id)
        egenerk.hentEgenTabell("skjema_menn", skjema_id)

        'fyller ut land_oppvokst som er en egen combo-box
        tabell = info.query("Land_oppvokst", "skjema_besvar", "skjema_id = " & skjema_id & "")
        For Each rad In tabell.Rows
            cmbEgenLand.Text = (rad("Land_oppvokst"))
        Next

        'sørger for at ingen tekst-felt kan bli endret
        For Each tb In TabControl1.Controls.OfType(Of TabPage)()
            For Each textBox In tb.Controls.OfType(Of TextBox)()
                textBox.Enabled = False
            Next
        Next

        'kode som fyller ut egenerklæringskjema basert på data i egentabell
        Dim idx = 0
        For Each tb In TabControl1.Controls.OfType(Of TabPage)()
            For Each pnl In tb.Controls.OfType(Of Panel)().OrderBy(Function(c) c.TabIndex)
                For Each cb In pnl.Controls.OfType(Of CheckBox)()
                    cb.Enabled = False
                    cb.ForeColor = Color.Maroon
                    If idx = egenerk.svarTabell.Count - 1 Then
                        cb.Enabled = False
                        cb.Checked = egenerk.svarTabell(idx)
                        Exit Sub
                    Else
                        cb.Enabled = False
                        cb.Checked = egenerk.svarTabell(idx)
                        idx += 1
                    End If
                    cb.Enabled = False
                Next
            Next
        Next
    End Sub


    ''brukes for å hente ut person-info til egenerklæring. 
    ''brukes både når bruker fyller ut og når ansatt ser på egenerklæring
    'Public Sub hentPersonaliaPersonNr()
    '    'importerer info-klassen fra SQLConnection.vb som inneholder generelle query
    '    Dim info As New info
    '    Dim midTabell As New DataTable

    '    midTabell = info.query("person_nr", "bruker", "epost = '" & LoginForm.bnavn & "'")

    '    For Each rad In midTabell.Rows
    '        hentPersonalia(rad("person_nr"))
    '    Next
    'End Sub
End Class
