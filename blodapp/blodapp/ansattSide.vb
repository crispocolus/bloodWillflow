Public Class ansattSide
    Dim kommentar As String

    Public giverBehov As String = 1
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

    Private Sub btnInnkalling_Click(sender As Object, e As EventArgs) Handles btnInnkalling.Click

    End Sub

    Private Sub btnBehov_Click(sender As Object, e As EventArgs) Handles btnBehov.Click
        giverBehov = TextBox1.Text
        If IsNumeric(txtMengde) Then
            Label9.Text = "Du trenger minst: " & giverBehov & "antall blodgivere"
        Else
            MsgBox("Du må skrive et tall når du skriver literbehov")
        End If

    End Sub

    Private Sub CBoxBlodtype_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CBoxBlodtype.SelectedIndexChanged

    End Sub

    Private Sub ansattSide_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lastBlodType()
    End Sub
    Public Sub lastBlodType()
        Dim info As New info
        Dim CountTabell As New DataTable
        CBoxBlodtype.Items.Clear()

        CountTabell = info.query("blodtype", "blodgiver", "1 GROUP BY blodtype")

        For Each rad In CountTabell.Rows
            CBoxBlodtype.Items.Add(rad("blodtype"))
        Next
    End Sub


    'Public Sub query()
    '    Dim info As New info
    '    Dim sql As New SQL

    '    Dim resultatTab As New DataTable
    '    resultatTab = info.hentInfo()

    '    lstKandidater.Items.Clear()
    '    For Each rad As DataRow In resultatTab.Rows
    '        lstKandidater.Items.Add(rad("fornavn") & " " & rad("etternavn") & " " & rad("epost") & " " & rad("fdato"))
    '    Next
    'End Sub
End Class