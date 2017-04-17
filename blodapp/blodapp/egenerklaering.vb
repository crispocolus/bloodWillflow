Imports System.IO
Imports System.Linq
Public Class egenerklaering

    Private Sub egenerklaering_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'ComboBox1.Items.AddRange(File.ReadAllLines("land.txt"))

        Dim RButtons As List(Of RadioButton) = New List(Of RadioButton)
        For Each C As Control In GroupBox1.Controls
            If TypeOf (C) Is RadioButton Then
                RButtons.Add(DirectCast(C, RadioButton))
            End If
        Next

    End Sub

    Private Sub btnEgenNext_Click(sender As Object, e As EventArgs) Handles btnEgenNext.Click
        TabControl1.SelectedIndex = TabControl1.SelectedIndex + 1
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

    Private Sub radEgenEpostJa_CheckedChanged(sender As Object, e As EventArgs) Handles radEgenEpostJa.CheckedChanged

    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Try
            Dim allPanel As New List(Of Control)
            For Each tpage As TabPage In Me.TabControl1.TabPages
                For Each pnl As Panel In FindControlRecursive(allPanel, Me, GetType(Panel)).OrderBy(Function(c) c.TabIndex)
                    For Each Ctrl In pnl.Controls
                        If Ctrl.checked Then
                            MsgBox(Ctrl.name)
                        End If
                    Next
                Next
            Next


        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Public Shared Function FindControlRecursive(ByVal list As List(Of Control), ByVal parent As Control, ByVal ctrlType As System.Type) As List(Of Control)
        If parent Is Nothing Then Return list
        If parent.GetType Is ctrlType Then
            list.Add(parent)
        End If
        For Each child As Control In parent.Controls
            FindControlRecursive(list, child, ctrlType)
        Next
        Return list
    End Function
End Class