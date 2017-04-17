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

    End Sub

    Private Sub endrePwBtn_Click(sender As Object, e As EventArgs) Handles endrePwBtn.Click
        Dim pros As New prosedyrer
        pros.endrePw(LoginForm.bnavn)
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Try


            Dim info As New info

            Dim bruker As String
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
End Class


