Public Class ansattSide
    Dim kommentar As String
    Dim blod_pnummer As String

    Public literBehov As String = 0

    'Kode som utføres når siden lastes
    Private Sub ansattSide_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim tabell As New DataTable
        Dim prosedyrer As New prosedyrer
        tabell = prosedyrer.lastinnBlodtype()
        For Each rad In tabell.Rows
            CBoxBlodtype.Items.Add(rad("blodtype"))
        Next
    End Sub

    'Knapp for å endre passord. 
    Private Sub endrePwBtn_Click(sender As Object, e As EventArgs) Handles endrePwBtn.Click
        Dim pros As New prosedyrer
        pros.endrePw(LoginForm.bnavn)
    End Sub

    'Knapp for å logge ut. 
    Private Sub btnLoggUt_Click(sender As Object, e As EventArgs) Handles btnLoggUt.Click
        LoginForm.bnavn = ""
        Me.Close()
        LoginForm.Show()
        MsgBox("Du er nå logget ut")
    End Sub

    '*****INNKALLING****
    Private Sub btnBehov_Click(sender As Object, e As EventArgs) Handles btnBehov.Click
        '    If IsNumeric(txtMengde) Then
        '        Label9.Text = "Du trenger minst: " & giverBehov & "antall blodgivere"
        '    Else
        '        MsgBox("Du må skrive et tall når du skriver literbehov")
        '    End If

        '*******Skal vi ha denne?**************
    End Sub

    'Private Sub btnBehov_Click(sender As Object, e As EventArgs) Handles btnBehov.Click
    '    literBehov = TextBox1.Text
    '    Dim giverBehov As Integer
    '    giverBehov = (literBehov / 0.45) + 1
    '    If IsNumeric(TextBox1.Text) = False Then
    '        MsgBox("Du må skrive et heltall når du skriver literbehov")
    '    Else
    '        Label9.Text = "Du trenger minst: " & giverBehov & " blodgivere" & vbCrLf & "for å få " & literBehov & " liter blod."
    '    End If


    '***********Skal vi ha denne?********
    'End Sub

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

    '********BESTILLINGER*********

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

    '*******OVERSIKT BLODBANK *************

    'Oppdaterer **(??)** når verdien endres. 
    Private Sub CBoxProdukt_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cBoxProdukt.SelectedIndexChanged
        ListBox1.Items.Clear()

        Dim blodtype As String
        Dim produkt As String

        blodtype = cBoxOversikt.SelectedItem
        produkt = cBoxProdukt.SelectedItem

        blodInfo()
    End Sub

    'Knapp for å hente ut full blod-oversikt. 
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        blodFullOversikt()
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

    Public Sub sendInnkalling()
        Dim info As New info
        Dim epost As New epost
        Dim janei As Integer
        Dim kommentar As String
        Dim epostAddr As String = ""
        Dim epostTab As DataTable

        Dim valgtPnummer As String
        valgtPnummer = CType(lstKandidater.SelectedItem, listItem).value


        '****Tanken er å sjekke om alt er fyllt ut, ellers virker ikke koden (kræsj)*****
        'If lstKandidater.SelectedItem Or cmbTime.SelectedItem Or cmbMin.SelectedItem = "" Then
        '    MsgBox("Du må fylle ut alle feltene!")
        '    Return
        'End If

        kommentar = InputBox("Kommentar: (frivillig)")

        epostTab = info.query("epost", "bruker", "person_nr = '" & valgtPnummer & "'")

        For Each rad As DataRow In epostTab.Rows
            epostAddr = rad("epost")
        Next
        MsgBox(epostAddr & " " & valgtPnummer & " " & kommentar)

        '*************Oppsummering funker ikke enda, bare småplukk!!*****
        'MsgBox("Oppsummering: " & vbCrLf & "Navn: " & lstKandidater.SelectedItem & vbCrLf & "Dato: " & tappeKalender.SelectionStart.ToString("yyyy/MM/dd") & "Klokkeslett: " & cmbTime.SelectedItem & ":" & cmbMin.SelectedItem & vbCrLf & "Kommentar: " & kommentar & vbCrLf)

        janei = MsgBox("Vil du sende innkallingen?", MsgBoxStyle.YesNo)
        If janei = DialogResult.Yes Then
            info.sendInnkalling(valgtPnummer, kommentar, tappeKalender.SelectionStart.ToString("yyyy/MM/dd") & " " & cmbTime.SelectedItem & ":" & cmbMin.SelectedItem & ":00")
            epost.sendEpost("Innkalling " & tappeKalender.SelectionStart.ToString("dd/MM/yyyy"), "Du har fått en innkalling til blodtapping den " & tappeKalender.SelectionStart.ToString("dd/MM/yyyy") & " klokken " & cmbTime.SelectedItem & ":" & cmbMin.SelectedItem & vbCrLf & "Har du spørsmål kan du ringe oss på 12345678" & vbCrLf & "Mvh Blodbanken", epostAddr)
        End If
    End Sub

    Public Class listItem
        Public display As String
        Public value As Decimal
        Public Overrides Function ToString() As String
            Return Me.display
        End Function
    End Class

    Public Sub blodInfo()

        Dim info As New info
        Dim tabell As New DataTable

        Dim blodtype As String = cBoxOversikt.SelectedItem
        Dim produkt As String = cBoxProdukt.SelectedItem


        tabell = info.query("id", produkt, "blodtype = '" & blodtype & "';")

        lblResultat.Text = (tabell.Rows.Count * 0.45) & " liter"
    End Sub

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
End Class

