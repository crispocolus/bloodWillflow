﻿Public Class MsgBoxCustom

    Public button1click As Boolean
    Public button2click As Boolean
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        button1click = True
        Me.Close()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        button2click = True
        Me.Close()
    End Sub
End Class