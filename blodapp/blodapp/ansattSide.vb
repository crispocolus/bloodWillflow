Public Class ansattSide
    Dim kommentar As String
    Dim blod_pnummer As String

    Public giverBehov As String = 1
    Private Sub btnRetur_Click(sender As Object, e As EventArgs) Handles btnRetur.Click

        kommentar = InputBox("Skriv en kommentar til bestillingen")
    End Sub

    Private Sub btnSend_Click(sender As Object, e As EventArgs) Handles btnSend.Click
        If chkBekreft.Checked = False Then
            MsgBox("Du må godkjenne bestillingen før du kan sende den")
        Else
        End If
    End Sub

    Private Sub chkBekreft_CheckedChanged(sender As Object, e As EventArgs) Handles chkBekreft.CheckedChanged
        If chkBekreft.Checked = False Then
            btnSend.Enabled = False
        Else
            btnSend.Enabled = True
        End If
    End Sub

    Private Sub btnInnkalling_Click(sender As Object, e As EventArgs) Handles btnInnkalling.Click
        sendInnkalling()
    End Sub

    Private Sub btnBehov_Click(sender As Object, e As EventArgs) Handles btnBehov.Click
        giverBehov = TextBox1.Text
        If IsNumeric(txtMengde) Then
            Label9.Text = "Du trenger minst: " & giverBehov & "antall blodgivere"
        Else
            MsgBox("Du må skrive et tall når du skriver literbehov")
        End If

    End Sub

    Private Sub CBoxBlodtype_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CBoxBlodtype.SelectedIndexChanged
        Dim blodtype As String

        blodtype = CBoxBlodtype.Text

        hentBlodGiver(blodtype)
    End Sub

    Private Sub ansattSide_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim tabell As New DataTable
        Dim prosedyrer As New prosedyrer
        tabell = prosedyrer.lastinnBlodtype()
        For Each rad In tabell.Rows
            CBoxBlodtype.Items.Add(rad("blodtype"))
        Next
    End Sub
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

    Public Sub hentBlodGiver(blodtype As String)

        'Importerer info-klassen som inneholder query-funksjon
        Dim info As New info
        'Lager en ny tabell som inneholder data fra query
        Dim Tabell As New DataTable
        Dim pNummerTabell As New ArrayList()
        'Tømmer combo-box før query
        lstKandidater.Items.Clear()

        'Utfører query ved hjelp av funksjonen query under klassen info. 
        Tabell = info.queryJoin("fornavn, etternavn, bruker.person_nr", "bruker", "blodgiver ON bruker.person_nr = blodgiver.person_nr", "blodtype = '" & blodtype & "';")
        'pNummerTabell = Tabell
        'Legger til kandidater basert på hva som er valgt i ComboBox
        For Each rad In Tabell.Rows
            lstKandidater.Items.Add(rad("fornavn") & " " & rad("etternavn"))
            pNummerTabell.Add(rad("person_nr").ToString)
            MsgBox(pNummerTabell.IndexOf())
        Next
        Dim sResult As String = ""

        'For Each elem As String In pNummerTabell
        '    MsgBox(elem)
        'Next
    End Sub

    Public Sub sendInnkalling()
        Dim info As New info

        info.sendInnkalling("12345678900", InputBox("Her skriver du din tekst"), InputBox("skriv inn en dato når du vil at folk skal komme"))
    End Sub


    'Public Sub fyllKandidat(blodtype As String)

    '    'Importerer info-klassen som inneholder query-funksjon
    '    Dim info As New info
    '    'Lager en ny tabell som inneholder data fra query
    '    Dim Tabell As New DataTable
    '    Dim personNrTab As New DataTable
    '    'Tømmer combo-box før query
    '    kandidatCmb.Items.Clear()

    '    'Utfører query ved hjelp av funksjonen query under klassen info. 
    '    Tabell = info.queryJoin("fornavn, etternavn, person_nr", "bruker", "blodgiver ON bruker.person_nr = blodgiver.person_nr", "1")

    '    'Legger til kandidater basert på hva som er valgt i ComboBox
    '    For Each rad In Tabell.Rows
    '        kandidatCmb.Items.Add(rad("fornavn") & vbTab & rad("etternavn") & vbTab & rad("person_nr"))
    '    Next
    'End Sub

    'Public Sub hentKandPers(blodtype As String)

    '    'Importerer info-klassen som inneholder query-funksjon
    '    Dim info As New info
    '    'Lager en ny tabell som inneholder data fra query
    '    Dim Tabell As New DataTable

    '    'Tømmer combo-box før query
    '    kandidatCmb.Items.Clear()

    '    'Utfører query ved hjelp av funksjonen query under klassen info. 
    '    Tabell = info.query("person_nr", "bruker", "fornavn+etternavn = " & kandidatCmb.Text)

    '    'Legger til kandidater basert på hva som er valgt i ComboBox
    '    For Each rad In Tabell.Rows
    '        kandidatCmb.Items.Add(rad("fornavn") & " " & rad("etternavn"))
    '    Next
    'End Sub

    Private Sub kandidatCmb_SelectedIndexChanged(sender As Object, e As EventArgs)

        'blod_pnummer = kandidatCmb.
    End Sub

    Private Sub loggutBtn_Click(sender As Object, e As EventArgs) Handles loggutBtn.Click
        LoginForm.bnavn = ""
        Me.Close()
        LoginForm.Show()
        MsgBox("Du er nå logget ut")
    End Sub
End Class

