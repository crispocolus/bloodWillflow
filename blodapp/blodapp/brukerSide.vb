Public Class brukerSide
    Private Sub brukerSide_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'info()
        sjekkMelding()
    End Sub


    Private Sub btnLoggUt_Click(sender As Object, e As EventArgs) Handles btnLoggUt.Click
        LoginForm.bnavn = ""
        Me.Hide()
        LoginForm.Show()
        MsgBox("Du er nå logget ut")
    End Sub

    Public Sub info()
        Dim info As New info
        Dim sql As New SQL

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

    Public Sub sjekkMelding()
        Dim info As New info
        Dim sql As New SQL

        Dim resultatTab As New DataTable
        resultatTab = info.queryJoin("innkallinger.person_nr, innkallinger.oppmote", "innkallinger", "bruker ON bruker.person_nr = innkallinger.person_nr", "innkallinger.status = 0;")

        If resultatTab.Rows.Count > 0 Then
            MsgBox("DU HAR FÅTT EN INNKALLING!!!!!!")
            For Each rad As DataRow In resultatTab.Rows
                innkallingLst.Items.Add(rad("person_nr") & rad("oppmote"))
            Next
        Else
        End If
    End Sub
End Class