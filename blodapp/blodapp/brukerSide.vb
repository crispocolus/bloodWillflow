Public Class brukerSide

    Public Sub info()
        Dim info As New info
        Dim sql As New SQL

        MsgBox(LoginForm.bnavn)

        Dim resultatTab As New DataTable
        resultatTab = info.queryJoin("*", "bruker", "postnummer ON bruker.post_nr = postnummer.post_nr", "epost = jens@")

        ListBox6.Items.Clear()
        For Each rad As DataRow In resultatTab.Rows
            ListBox6.Items.Add(rad("fornavn") & " " & rad("etternavn") & " " & rad("epost") & " " & rad("fdato"))
        Next
    End Sub

    Private Sub brukerSide_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        info()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles btnAvbestillTime.Click

    End Sub
End Class