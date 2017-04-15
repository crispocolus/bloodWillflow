Imports System.IO
Imports System.Linq
Public Class egenerklaering

    Private Sub egenerklaering_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ComboBox1.Items.AddRange(File.ReadAllLines("land.txt"))

        Dim rButton As RadioButton = Panel1.Controls.OfType(Of RadioButton).FirstOrDefault(Function(r) r.Checked = True)


    End Sub

    Private Sub ChangeFind()


    End Sub

    Private Sub btnEgenNext_Click(sender As Object, e As EventArgs) Handles btnEgenNext.Click

        TabControl1.SelectedIndex = TabControl1.SelectedIndex + 1


        For Each c As Control In Me.Controls
            If c.GetType Is GetType(RadioButton) Then
                AddHandler DirectCast(c, RadioButton).CheckedChanged, AddressOf changeFind()
            End If
        Next
        'For Each b As RadioButton In Panel1.Controls.OfType(Of RadioButton)()
        '    If b.Checked = True Then
        '        MsgBox("I hope that will help you")
        '    Else
        '        MsgBox("trykk knapp")
        '    End If
        'Next


    End Sub





    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        TabControl1.SelectedIndex = TabControl1.SelectedIndex + 1
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        TabControl1.SelectedIndex = TabControl1.SelectedIndex + 1
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        TabControl1.SelectedIndex = TabControl1.SelectedIndex + 1
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        TabControl1.SelectedIndex = TabControl1.SelectedIndex + 1
    End Sub
End Class