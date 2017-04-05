Imports System.IO
Public Class egenerklaering

    Private Sub egenerklaering_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ComboBox1.Items.AddRange(File.ReadAllLines("land.txt"))
    End Sub


End Class