Public Class adminSide

    'utføres når siden lastes inn
    Private Sub adminSide_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.CenterToParent()
    End Sub

    Private Sub btnSokBruker_Click(sender As Object, e As EventArgs) Handles btnSokBruker.Click
        hentBruker()
    End Sub
    'utføres når bruker logger ut
    Private Sub btnLoggUt_Click(sender As Object, e As EventArgs) Handles btnLoggUt.Click
        Dim pros As New prosedyrer
        pros.loggUt()
        Me.Close()
    End Sub

    'utføres når admin registrerer ny bruker
    Private Sub btnRegistrer_Click(sender As Object, e As EventArgs) Handles btnRegistrer.Click
        Dim reg As New RegistrerForm
        reg.SjekkSendInfo(postnrTxt.Text, adresseTxt.Text, pnummerTxt.Text, fornavnTxt.Text, etternavnTxt.Text, epostTxt.Text, tlfTxt.Text, passordcTxt.Text, passordTxt.Text)
    End Sub

    Private Sub lstBrukere_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lstBrukere.SelectedIndexChanged
        fyllBrukerinfoFelt()
    End Sub

    Private Sub endrePwBtn_Click(sender As Object, e As EventArgs) Handles endrePwBtn.Click
        Dim pros As New prosedyrer
        pros.endrePw(LoginForm.bnavn)
    End Sub

    Private Sub btnEndreStatus_Click(sender As Object, e As EventArgs) Handles btnEndreStatus.Click
        endreBrukerstatus()
    End Sub

    Private Sub btnFjernBruker_Click(sender As Object, e As EventArgs) Handles btnFjernBruker.Click
        fjernBruker()
    End Sub

    Private Sub btnEndrePersoninfo_Click(sender As Object, e As EventArgs) Handles btnEndrePersoninfo.Click
        endreBrukerInfo()
    End Sub

    'brukes for å hente bruker ved søk
    Public Sub hentBruker()
        'Importerer søkefunksjon fra SQLConnection.vb form
        Dim soking As New soking

        Dim sokeord As String = cmbsokTxt.Text
        Dim resultatTab As New DataTable
        Dim sorter As String = ""

        Select Case cmbsokSpes.Text
            Case "fornavn"
                sorter = "fornavn"
            Case "etternavn"
                sorter = "etternavn"
            Case "e-post"
                sorter = "epost"
        End Select

        resultatTab = soking.sokBruker(sokeord, sorter)

        lstBrukere.Items.Clear()
        For Each rad As DataRow In resultatTab.Rows
            lstBrukere.Items.Add(New listItem With {.display = rad("Fornavn") & " " & rad("Etternavn") & " " & rad("Epost") & " " & rad("Fdato"), .value = rad("person_nr")})
        Next

    End Sub
    'fyller ut felt med brukerdata basert på hva som er valgt i lstBrukere
    Private Sub fyllBrukerinfoFelt()
        Try
            Dim info As New info
            Dim tabell As New DataTable
            Dim pNummer As Double
            pNummer = CType(lstBrukere.SelectedItem, listItem).value

            tabell = info.queryJoin("fornavn, etternavn, epost, telefon, gateadresse, post_nr", "bruker", "blodgiver ON bruker.person_nr = blodgiver.person_nr", "bruker.person_nr = '" & pNummer & "';")

            For Each rad In tabell.Rows
                txtFornavn.Text = rad("fornavn")
                txtEtternavn.Text = rad("etternavn")
                txtEpost.Text = rad("epost")
                txtTelefon.Text = rad("telefon")
                txtAdresse.Text = rad("gateadresse")
                txtPostnr.Text = rad("post_nr")
            Next

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    'brukes for å endre status på en bruker
    Private Sub endreBrukerstatus()
        Try
            Dim info As New info

            Dim bruker As Double
            bruker = CType(lstBrukere.SelectedItem, listItem).value
            Dim brukerstatus As Integer
            brukerstatus = 0

            'setter brukerstatus avhengig av hva som er valgt i cmbBrukerStatus
            Select Case cmbBrukerStatus.Text
                Case "blodgiver"
                    brukerstatus = 0
                Case "ansatt"
                    brukerstatus = 1
                Case "leder"
                    brukerstatus = 2
                Case "admin"
                    brukerstatus = 3

            End Select

            'oppdaterer brukerstatus
            info.queryUpdate("bruker", "brukerstatus = '" & brukerstatus & "'", "person_nr = '" & bruker & "';")

            MsgBox("Bruker har fått brukerstatus endret til " & cmbBrukerStatus.Text)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    'setter bruker inaktiv i database for sletting 
    'bruker ligger fortsatt i database for andre formål
    Private Sub fjernBruker()
        'Validerer at du virkelig vil fjerne bruker
        Dim janei As Integer
        janei = MsgBox("Vil du sende innkallingen?", MsgBoxStyle.YesNo)
        If janei = DialogResult.Yes Then

            'endrer brukerstatus til "9" for å fjerne de fra funksjonaliteten i systemet, men fortsatt ha de i databasen
            Try
                Dim info As New info
                Dim bruker As Double
                bruker = CType(lstBrukere.SelectedItem, listItem).value
                Dim brukerstatus As Integer
                brukerstatus = 9
                info.queryUpdate("bruker", "brukerstatus = '" & brukerstatus & "'", "person_nr = '" & bruker & "';")

                MsgBox("Bruker er blitt gjort inaktiv")

            Catch ex As Exception
                MsgBox(ex.Message)
            End Try

        End If
    End Sub
    'brukes for å endre info på bruker
    Private Sub endreBrukerInfo()
        Try
            'importerer info-klasse fra SQLConnection.vb
            Dim info As New info
            Dim bruker As Double
            bruker = CType(lstBrukere.SelectedItem, listItem).value
            Dim fornavn As String = txtFornavn.Text
            Dim etternavn As String = txtEtternavn.Text
            Dim epost As String = txtEpost.Text
            Dim telefon As Double = txtTelefon.Text
            Dim gateadresse As String = txtAdresse.Text
            Dim post_nr As Double = txtPostnr.Text

            info.queryUpdate("bruker", "fornavn = '" & fornavn & "', etternavn = '" & etternavn & "', epost = '" & epost & "', telefon = '" & telefon & "', gateadresse = '" & gateadresse & "'", "person_nr = '" & bruker & "';")

            MsgBox("Brukerinfo er blitt oppdatert")

        Catch ex As Exception
            MsgBox("Ingen bruker valgt")
        End Try
    End Sub
End Class


