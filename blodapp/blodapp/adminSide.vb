Public Class adminSide
    Private Sub btnSokBruker_Click(sender As Object, e As EventArgs) Handles btnSokBruker.Click
        hentBruker()
    End Sub


    Public Sub hentBruker()
        'Importerer søkefunksjon fra SQLConnection.vb form
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

        lstBrukere.Items.Clear()
        For Each rad As DataRow In resultatTab.Rows
            lstBrukere.Items.Add(New listItem With {.display = rad("Fornavn") & " " & rad("Etternavn") & " " & rad("Epost") & " " & rad("Fdato"), .value = rad("person_nr")})
        Next

    End Sub

    Private Sub adminSide_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.CenterToParent()
    End Sub



    Private Sub btnRegistrer_Click(sender As Object, e As EventArgs) Handles btnRegistrer.Click
        Dim reg As New RegistrerForm
        reg.SjekkInfo(postnrTxt.Text, adresseTxt.Text, pnummerTxt.Text, fornavnTxt.Text, etternavnTxt.Text, epostTxt.Text, tlfTxt.Text, passordcTxt.Text, passordTxt.Text)

    End Sub

    Private Sub lstBrukere_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lstBrukere.SelectedIndexChanged
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

    Private Sub endrePwBtn_Click(sender As Object, e As EventArgs) Handles endrePwBtn.Click
        Dim pros As New prosedyrer
        pros.endrePw(LoginForm.bnavn)
    End Sub

    Private Sub btnEndreStatus_Click(sender As Object, e As EventArgs) Handles btnEndreStatus.Click
        Try


            Dim info As New info

            Dim bruker As Double
            bruker = CType(lstBrukere.SelectedItem, listItem).value
            Dim brukerstatus As Integer
            brukerstatus = 0

            Select Case ComboBox1.Text
                Case "Blodgiver"
                    brukerstatus = 0
                Case "Ansatt"
                    brukerstatus = 1
                Case "Leder"
                    brukerstatus = 2
                Case "IT"
                    brukerstatus = 3

            End Select


            info.queryUpdate("bruker", "brukerstatus = '" & brukerstatus & "'", "person_nr = '" & bruker & "';")

            MsgBox("Bruker har fått brukerstatus endret til " & ComboBox1.Text)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub btnFjernBruker_Click(sender As Object, e As EventArgs) Handles btnFjernBruker.Click

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


    Private Sub btnEndrePersoninfo_Click(sender As Object, e As EventArgs) Handles btnEndrePersoninfo.Click
        Try



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

    Private Sub btnLoggUt_Click(sender As Object, e As EventArgs) Handles btnLoggUt.Click
        Dim pros As New prosedyrer
        Me.Close()
        pros.loggUt()
    End Sub
End Class


