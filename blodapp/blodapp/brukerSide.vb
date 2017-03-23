Public Class brukerSide

    Public Sub info()


        Dim info As New info
        Dim sql As New SQL

        MsgBox(LoginForm.bnavn)

        Dim resultatTab As New DataTable
        resultatTab = info.queryJoin("*", "bruker", "postnummer ON bruker.post_nr = postnummer.post_nr", "epost = '" & LoginForm.bnavn & "';")
        'ListBox6.Items.Clear()
        For Each rad As DataRow In resultatTab.Rows
            'ListBox6.Items.Add(rad("fornavn") & " " & rad("etternavn") & " " & rad("telefon") & " " & rad("epost"))
            fornavnTxt.Text = (rad("fornavn"))
            etternavnTxt.Text = (rad("etternavn"))
            telefonTxt.Text = (rad("telefon"))
            epostTxt.Text = (rad("epost"))

        Next
    End Sub

    Private Sub brukerSide_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        info()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles btnAvbestillTime.Click

    End Sub

    Private Sub btnLoggUt_Click(sender As Object, e As EventArgs) Handles btnLoggUt.Click
        LoginForm.bnavn = ""
        Me.Hide()
        LoginForm.Show()
        MsgBox("Du er nå logget ut")
    End Sub
End Class