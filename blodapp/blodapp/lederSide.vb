Public Class lederSide
    Dim kommentar As String

    Private Sub lederSide_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.CenterToParent()
    End Sub



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
        sendInnkalling()
    End Sub

    Private Sub endrePwBtn_Click(sender As Object, e As EventArgs) Handles endrePwBtn.Click
        Dim pros As New prosedyrer
        pros.endrePw(LoginForm.bnavn)
    End Sub

    Public Sub sendInnkalling()
        Dim info As New info
        MsgBox(tappeKalender.SelectionStart.ToString("yyyy/MM/dd") & " " & ComboBox2.SelectedItem & ":" & ComboBox3.SelectedItem & ":00")

        Dim ItemSelected As String
        ItemSelected = CType(lstKandidater.SelectedItem, listItem).value

        info.sendInnkalling(ItemSelected, InputBox("Her skriver du din tekst"), tappeKalender.SelectionStart.ToString("yyyy/MM/dd") & " " & ComboBox2.SelectedItem & ":" & ComboBox3.SelectedItem & ":00")
    End Sub

    Private Sub CBoxBlodtype_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CBoxBlodtype.SelectedIndexChanged
        Dim blodtype As String

        blodtype = CBoxBlodtype.Text

        hentBlodGiver(blodtype)
    End Sub

    Public Class listItem
        Public display As String
        Public value As Decimal
        Public Overrides Function ToString() As String
            Return Me.display
        End Function
    End Class

    Public Sub hentBlodGiver(blodtype As String)
        'Importerer info - klassen som inneholder query-funksjon
        Dim info As New info
        'Lager en ny tabell som inneholder data fra query
        Dim Tabell As New DataTable
        'Dim pNummerTabell As New DataTable()
        'Tømmer combo - box før query
        lstKandidater.Items.Clear()


        'Utfører query ved hjelp av funksjonen query under klassen info. 
        Tabell = info.queryJoin("fornavn, etternavn, bruker.person_nr", "bruker", "blodgiver ON bruker.person_nr = blodgiver.person_nr", "blodtype = '" & blodtype & "';")
        'pNummerTabell = Tabell

        'Legger til kandidater basert på hva som er valgt i ComboBox
        For Each rad In Tabell.Rows
            lstKandidater.Items.Add(rad("fornavn") & " " & rad("etternavn"))
            lstKandidater.Items.Add(New listItem With {.display = rad("fornavn") & " " & rad("etternavn") & ToString(), .value = rad("person_nr")})
            'pNummerTabell.Add(rad("person_nr").ToString)
            'MsgBox(pNummerTabell.IndexOf())
        Next
        Dim sResult As String = ""

        'For Each elem As String In pNummerTabell
        '    MsgBox(elem)
        'Next
    End Sub

    Private Sub lstKandidater_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lstKandidater.SelectedIndexChanged

    End Sub


    'Private Sub btnBehov_Click(sender As Object, e As EventArgs) Handles btnBehov.Click
    '    If IsNumeric(txtMengde) Then
    '        Label9.Text = "Du trenger minst: " & giverBehov & "antall blodgivere"
    '    Else
    '        MsgBox("Du må skrive et tall når du skriver literbehov")
    '    End If

    'End Sub
End Class