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

        ListBox1.Items.Clear()
        For Each rad As DataRow In resultatTab.Rows
            ListBox1.Items.Add(New ansattSide.listItem With {.display = rad("Fornavn") & " " & rad("Etternavn") & " " & rad("Epost") & " " & rad("Fdato"), .value = rad("person_nr")})
        Next

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim reg As New RegistrerForm
        reg.SjekkInfo(postnrTxt.Text, adresseTxt.Text, pnummerTxt.Text, fornavnTxt.Text, etternavnTxt.Text, epostTxt.Text, tlfTxt.Text, RegistrerForm.finnFdato(pnummerTxt.Text), passordcTxt.Text, passordTxt.Text)

    End Sub

    Private Sub ListBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListBox1.SelectedIndexChanged
        'Try


        '    Dim info As New info
        '    Dim tabell As New DataTable
        '    Dim pNummer As Double
        '    pNummer = ListBox1.SelectedValue


        '    tabell = info.queryJoin("fornavn, etternavn, epost, telefon, gateadresse, post_nr, blodgiver.blodtype", "bruker", "blodgiver ON bruker.person_nr = blodgiver.person_nr", "bruker.person_nr = '" & pNummer & "';")

        '    For Each rad In tabell.Rows
        '        TextBox1.Text = rad("fornavn")
        '    Next

        'Catch ex As Exception
        '    MsgBox(ex.Message)
        'End Try
    End Sub

    Private Sub endrePwBtn_Click(sender As Object, e As EventArgs) Handles endrePwBtn.Click
        Dim pros As New prosedyrer
        pros.endrePw(LoginForm.bnavn)
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Try


            Dim info As New info

            Dim bruker As Double
            bruker = CType(ListBox1.SelectedItem, ansattSide.listItem).value
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
        Try



            Dim info As New info
            Dim bruker As Double
            bruker = CType(ListBox1.SelectedItem, ansattSide.listItem).value
            Dim brukerstatus As Integer
            brukerstatus = 9
            info.queryUpdate("bruker", "brukerstatus = '" & brukerstatus & "'", "person_nr = '" & bruker & "';")

            MsgBox("Bruker er blitt gjort inaktiv")

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try


    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Try


            Dim info As New info
            Dim tabell As New DataTable
            Dim pNummer As Double
            pNummer = CType(ListBox1.SelectedItem, ansattSide.listItem).value



            tabell = info.queryJoin("fornavn, etternavn, epost, telefon, gateadresse, post_nr, blodgiver.blodtype", "bruker", "blodgiver ON bruker.person_nr = blodgiver.person_nr", "bruker.person_nr = '" & pNummer & "';")

            For Each rad In tabell.Rows
                TextBox1.Text = rad("fornavn")
                TextBox2.Text = rad("etternavn")
                TextBox3.Text = rad("epost")
                TextBox4.Text = rad("telefon")
                TextBox5.Text = rad("gateadresse")
                TextBox6.Text = rad("post_nr")
                TextBox7.Text = rad("blodtype")

            Next

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub btnEndrePersoninfo_Click(sender As Object, e As EventArgs) Handles btnEndrePersoninfo.Click
        Try



            Dim info As New info
            Dim bruker As Double
            bruker = CType(ListBox1.SelectedItem, ansattSide.listItem).value
            Dim fornavn As String = TextBox1.Text
            Dim etternavn As String = TextBox2.Text
            Dim epost As String = TextBox3.Text
            Dim telefon As Double = TextBox4.Text
            Dim gateadresse As String = TextBox5.Text
            Dim post_nr As Double = TextBox6.Text
            Dim blodtype As String = TextBox7.Text
            info.queryUpdate("bruker", "fornavn = '" & fornavn & "', etternavn = '" & etternavn & "', epost = '" & epost & "', telefon = '" & telefon & "', gateadresse = '" & gateadresse & "'", "person_nr = '" & bruker & "';")

            MsgBox("Brukerinfo er blitt oppdatert")

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
End Class


