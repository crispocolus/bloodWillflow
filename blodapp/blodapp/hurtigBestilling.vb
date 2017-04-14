Public Class hurtigBestilling

    Public Sub lastBGTlf(blodtype As String)
        'Importerer info - klassen som inneholder query-funksjon
        Dim info As New info
        'Lager en ny tabell som inneholder data fra query
        Dim Tabell As New DataTable

        lblHurtigBType.Text = blodtype
        'Tømmer combo - box før query
        lstBGTlf.Items.Clear()


        'Utfører query ved hjelp av funksjonen query under klassen info. 
        Tabell = info.queryJoin("fornavn, etternavn, telefon", "bruker", "blodgiver ON bruker.person_nr = blodgiver.person_nr", "blodtype = '" & blodtype & "';")

        'Legger til kandidater basert på hva som er valgt i ComboBox
        For Each rad In Tabell.Rows
            'lstKandidater.Items.Add(rad("fornavn") & " " & rad("etternavn"))
            lstBGTlf.Items.Add(rad("fornavn") & " " & rad("etternavn") & ", " & rad("telefon"))
        Next

    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub
End Class