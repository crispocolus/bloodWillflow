Imports System.IO
Imports System.Drawing
Public Class egenerklaering
    Public svar As New ArrayList(12)

    Private Sub egenerklaering_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'ComboBox1.Items.AddRange(File.ReadAllLines("land.txt"))
        Me.CenterToParent()
    End Sub

    Private Sub nesteSide(sender As Object, e As EventArgs) Handles btnEgenNext1.Click, btnEgenNext2.Click, btnEgenNext3.Click, btnEgenNext4.Click, btnEgenNext5.Click
        nesteSide()
    End Sub

    Private Sub forrigeSide(sender As Object, e As EventArgs) Handles btnEgenBack1.Click, btnEgenBack2.Click, btnEgenBack3.Click, btnEgenBack4.Click, btnEgenBack5.Click
        forrigeSide()
    End Sub
    Private Sub radEgenEpostJa_CheckedChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub nesteSide()
        TabControl1.SelectedIndex = TabControl1.SelectedIndex + 1
    End Sub

    Private Sub forrigeSide()
        TabControl1.SelectedIndex = TabControl1.SelectedIndex - 1
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles btnEgenSubmit.Click
        submitSkjema()
    End Sub

    Private Sub ChkSomFor_CheckedChanged(sender As Object, e As EventArgs) Handles ChkSomFor.CheckedChanged
        hentPersonalia()
    End Sub

    Private Sub hentPersonalia()
        Dim info As New info
        Dim tabell As New DataTable

        tabell = info.query("*", "bruker", "epost = '" & LoginForm.bnavn & "'")

        For Each rad In tabell.Rows
            txtEgenFornavn.Text = rad("fornavn")
            txtEgenEtternavn.Text = rad("etternavn")
            txtEgenPerson_nr.Text = rad("person_nr")
            txtEgenPrivatadresse.Text = rad("gateadresse")
            txtEgenPost_nr.Text = rad("post_nr")
            txtEgenTlf.Text = rad("telefon")
            txtEgenEpost.Text = rad("epost")
        Next
    End Sub

    Private Sub submitSkjema()
        Try
            Dim EgenErk As New EgenErk
            Dim info As New info
            Dim dt As New DataTable
            Dim pnummer As String = ""
            Dim nr As Integer = 0
            svar.Clear()

            For Each tb In TabControl1.Controls.OfType(Of TabPage)()
                For Each pnl In tb.Controls.OfType(Of Panel)().OrderBy(Function(c) c.TabIndex)
                    For Each cb In pnl.Controls.OfType(Of CheckBox)()
                        If cb.Checked = True Then
                            nr += 1
                            svar.Add(1)
                            'MsgBox(cb.Name & ", " & svar.Item(nr - 1) & ", nr: " & nr)
                        Else
                            nr += 1
                            svar.Add(0)
                            'MsgBox(cb.Name & ", " & svar.Item(nr - 1) & ", nr: " & nr)
                        End If
                    Next
                Next
            Next

            dt = info.query("person_nr", "bruker", "epost = '" & LoginForm.bnavn & "'")
            For Each rad In dt.Rows
                pnummer = rad("person_nr")
            Next
            EgenErk.sendEgenErk(pnummer)

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
End Class
