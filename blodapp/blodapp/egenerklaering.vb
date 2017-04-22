Imports System.IO
Imports System.Drawing
Public Class egenerklaering
    Public svar As New ArrayList()

    Private Sub egenerklaering_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cmbEgenLand.Items.AddRange(File.ReadAllLines("land.txt"))
        Me.CenterToParent()
    End Sub

    Private Sub nesteSide(sender As Object, e As EventArgs) Handles btnEgenNext1.Click, btnEgenNext2.Click, btnEgenNext3.Click, btnEgenNext4.Click, btnEgenNext5.Click
        nesteSide()
    End Sub

    Private Sub forrigeSide(sender As Object, e As EventArgs) Handles btnEgenBack1.Click, btnEgenBack2.Click, btnEgenBack3.Click, btnEgenBack4.Click, btnEgenBack5.Click
        forrigeSide()
    End Sub

    Private Sub nesteSide()
        TabControl1.SelectedIndex = TabControl1.SelectedIndex + 1
    End Sub

    Private Sub forrigeSide()
        TabControl1.SelectedIndex = TabControl1.SelectedIndex - 1
    End Sub

    Private Sub btnEgenSubmit_Click(sender As Object, e As EventArgs) Handles btnEgenSubmit.Click
        submitSkjema()
        Me.Close()
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
                        Else
                            nr += 1
                            svar.Add(0)
                        End If
                    Next
                Next
            Next

            dt = info.query("person_nr", "bruker", "epost = '" & LoginForm.bnavn & "'")
            For Each rad In dt.Rows
                pnummer = rad("person_nr")
            Next
            MsgBox(EgenErk.sendEgenErk(pnummer, cmbEgenLand.SelectedIndex))


        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Public Sub fyllSkjema(pnummer As String, skjema_id As String)
        Dim egenerk As New EgenErk
        Dim info As New info
        Dim tabell As New DataTable

        egenerk.hentEgenTabellBruker(pnummer, skjema_id)
        egenerk.hentEgenTabell("skjema_besvar", skjema_id)
        egenerk.svarTabell.Add(0)
        egenerk.hentEgenTabell("skjema_fire_uker", skjema_id)
        egenerk.hentEgenTabell("skjema_to_aar", skjema_id)
        egenerk.hentEgenTabell("skjema_seks_mnd", skjema_id)
        egenerk.hentEgenTabell("skjema_livet", skjema_id)
        egenerk.hentEgenTabell("skjema_kvinner", skjema_id)
        egenerk.hentEgenTabell("skjema_menn", skjema_id)

        tabell = info.query("Land_oppvokst", "skjema_besvar", "skjema_id = " & skjema_id & "")
        For Each rad In tabell.Rows
            MsgBox(rad("Land_oppvokst"))
            cmbEgenLand.Text = (rad("Land_oppvokst"))
        Next

        Dim idx = 0
        For Each tb In TabControl1.Controls.OfType(Of TabPage)()
            For Each pnl In tb.Controls.OfType(Of Panel)().OrderBy(Function(c) c.TabIndex)
                For Each cb In pnl.Controls.OfType(Of CheckBox)()
                    If idx = egenerk.svarTabell.Count - 1 Then
                        cb.Checked = egenerk.svarTabell(idx)
                        Exit Sub
                    Else
                        cb.Checked = egenerk.svarTabell(idx)
                        idx += 1
                    End If
                Next
            Next
        Next
    End Sub
End Class
