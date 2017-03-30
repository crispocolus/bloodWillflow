Public Class lederSide
    Dim kommentar As String

    'Dim giverBehov As String = TextBox1.Text
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

    'Private Sub btnBehov_Click(sender As Object, e As EventArgs) Handles btnBehov.Click
    '    If IsNumeric(txtMengde) Then
    '        Label9.Text = "Du trenger minst: " & giverBehov & "antall blodgivere"
    '    Else
    '        MsgBox("Du må skrive et tall når du skriver literbehov")
    '    End If

    'End Sub
End Class