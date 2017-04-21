﻿
Public Class RegistrerForm
    Private Sub btnRegistrer_Click(sender As Object, e As EventArgs) Handles btnRegistrer.Click, Me.KeyPress
        If SjekkInfo(postnrTxt.Text, adresseTxt.Text, pnummerTxt.Text, fornavnTxt.Text, etternavnTxt.Text, epostTxt.Text, tlfTxt.Text, finnFdato(pnummerTxt.Text), passordcTxt.Text, passordTxt.Text) = False Then
            MsgBox("Bruker ble ikke registrert")
        Else
            MsgBox("Registrering fullført." & vbCrLf & "Brukernavnet ditt er: " & epostTxt.Text & vbCrLf & vbCrLf & "Du kan nå gi samtykke ved resepsjonen")
        End If
    End Sub

    Private Sub RegistrerForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.CenterToParent()
    End Sub

    Public Function SjekkInfo(post_nr As String, adresse As String, pnummer As String, fornavn As String, etternavn As String, epost As String, tlf As String, fdato As String, passordc As String, passord As String)
        Dim Registrering As New RegBruker
        Dim info As New info
        Dim pHash As New passordHash
        Dim pros As New prosedyrer

        Dim data As DataTable
        data = info.query("epost", "bruker", "epost = '" & epost & "';")

        Dim godkjentEpost As Boolean = False
        Dim godkjentTelefon As Boolean = False
        Dim godkjentPassord As Boolean = False

        If pros.validateEmail(epost) = True Then
            If data.Rows.Count > 0 Then
                Dim customMsgBox As New MsgBoxCustom
                With customMsgBox
                    .Label1.Text = "E-post er registrert fra før av. " & vbCrLf & "Vil du logge inn eller har du glemt passord?"
                    .Button1.Text = "Logg inn"
                    .Button2.Text = "Glemt passord"
                    .Button3.Visible = True
                    .Button3.Text = "Tilbake til registrering"
                    .ShowDialog()
                End With

                If customMsgBox.button1click = True Then
                    Me.Close()
                    LoginForm.Show()
                ElseIf customMsgBox.button2click = True Then
                    Me.Close()
                    Dim glemtPw As New prosedyrer
                    glemtPw.glemtPw()
                ElseIf customMsgBox.button3click = True Then
                    customMsgBox.Close()
                End If

            Else
                godkjentEpost = True
            End If
        Else
            MsgBox("Epost ikke godkjent. Sjekk om du har husket @")
            Return False
        End If

        If IsNumeric(tlf) And tlf.Length = 8 Then
            godkjentTelefon = True
        Else
            MsgBox("Telefonnummeret må være 8 siffer")
            Return False
        End If

        If passordc = passord Then
            godkjentPassord = True
        Else
            MsgBox("Passordene du anga stemmer ikke overens")
            Return False
        End If

        'Når info er sjekket og godkjent så utføres funksjonen *sendInfo* som finnes i regbruker.vb
        If godkjentEpost = True And godkjentTelefon = True And godkjentPassord = True Then
            Dim salt As String
            Dim passordHash As String = ""
            salt = pHash.lagSalt
            passordHash = pHash.lagSaltetHash(passordTxt.Text, salt)

            Registrering.sendInfo(post_nr,
                                  adresse,
                                  pnummer,
                                  "0",
                                  fornavn,
                                  etternavn,
                                  epost,
                                  tlf,
                                  fdato,
                                  adresse,
                                  passordHash,
                                  salt)
            Return True
            Me.Close()
        End If
    End Function

    Function finnFdato(person_nr As String)
        Dim fdato As String = ""
        Dim i As Integer

        fdato += "1"
        fdato += "9"

        For i = 5 To 6
            If i = 6 Then
                fdato += (Mid(person_nr, i, 1)) & "-"
            Else
                fdato += (Mid(person_nr, i, 1))
            End If
        Next i

        For i = 3 To 4
            If i = 4 Then
                fdato += (Mid(person_nr, i, 1)) & "-"
            Else
                fdato += (Mid(person_nr, i, 1))
            End If
        Next i

        For i = 1 To 2
            fdato += (Mid(person_nr, i, 1))
        Next

        MsgBox(fdato)
        Return fdato
    End Function

    Private Sub btnTilbake_Click(sender As Object, e As EventArgs) Handles btnTilbake.Click
        Me.Close()
        LoginForm.Show()
    End Sub

    Private Sub chkJegHarLest_CheckedChanged(sender As Object, e As EventArgs) Handles chkJegHarLest.CheckedChanged
        If chkJegHarLest.Checked = True Then
            btnRegistrer.Enabled = True
        Else
            btnRegistrer.Enabled = False
        End If
    End Sub
End Class