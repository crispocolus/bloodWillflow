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

        resultatTab = soking.sok(sokeord, sorter)

        ListBox1.Items.Clear()
        For Each rad As DataRow In resultatTab.Rows
            ListBox1.Items.Add(rad("Fornavn") & " " & rad("Etternavn") & " " & rad("Epost") & " " & rad("Fdato"))
        Next

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim reg As New RegistrerForm
        reg.SjekkInfo(postnrTxt.Text, adresseTxt.Text, pnummerTxt.Text, fornavnTxt.Text, etternavnTxt.Text, epostTxt.Text, tlfTxt.Text, RegistrerForm.finnFdato(pnummerTxt.Text), passordcTxt.Text, passordTxt.Text)

    End Sub

    Private Sub ListBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListBox1.SelectedIndexChanged

    End Sub
End Class


