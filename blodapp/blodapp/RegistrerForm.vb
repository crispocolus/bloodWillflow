﻿
Public Class RegistrerForm
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click, Me.KeyPress
        SjekkInfo(postnrTxt.Text, adresseTxt.Text, pnummerTxt.Text, fornavnTxt.Text, etternavnTxt.Text, epostTxt.Text, tlfTxt.Text, finnFdato(pnummerTxt.Text), passordcTxt.Text, passordTxt.Text)
    End Sub

    Private Sub RegistrerForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.CenterToParent()
    End Sub


    Public Sub SjekkInfo(post_nr As String, adresse As String, pnummer As String, fornavn As String, etternavn As String, epost As String, tlf As String, fdato As String, passordc As String, passord As String)
        Dim Registrering As New RegBruker
        Dim info As New info
        Dim pHash As New passordHash
        Dim pros As New prosedyrer

        Dim data As DataTable
        data = info.query("epost", "bruker", "epost = '" & epost & "';")

        'MsgBox(data.Rows.Count)

        Dim godkjentEpost As Boolean = False
        Dim godkjentTelefon As Boolean = False
        Dim godkjentPassord As Boolean = False

        If pros.validateEmail(epost) = True Then
            If data.Rows.Count > 0 Then
                Dim customMsgBox As New MsgBoxCustom
                customMsgBox.Label1.Text = "E-post er registrert fra før av. " & vbCrLf & "Vil du logge inn eller har du glemt passord?"
                customMsgBox.Button1.Text = "Gå til logg inn"
                customMsgBox.Button2.Text = "Gå til glemt passord"
                customMsgBox.Button3.Visible = True
                customMsgBox.Button3.Text = "Tilbake til registrering"
                customMsgBox.ShowDialog()

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
                'MsgBox(godkjentEpost)
            End If
        Else
            MsgBox("Epost ikke godkjent. Sjekk om du har husket @")
        End If

        If IsNumeric(tlf) And tlf.Length = 8 Then
            godkjentTelefon = True
        Else
            MsgBox("Telefonnummeret må være 8 siffer")
        End If

        If passordc = passord Then
            godkjentPassord = True
        Else
            MsgBox("Passordene du anga stemmer ikke overens")
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
            MsgBox("Registrering fullført." & vbCrLf & "Brukernavnet ditt er: " & epost & vbCrLf & vbCrLf & "Du kan nå gi samtykke ved resepsjonen")
            Me.Close()
            LoginForm.Show()
        End If
    End Sub

    Function finnFdato(person_nr As String)
        Dim fdato As String
        Dim i As Integer

        For i = 1 To 6
            fdato += (Mid(person_nr, i, 1))
        Next i

        MsgBox(fdato)
        Return fdato
    End Function

    Private Sub tilbakeBtn_Click(sender As Object, e As EventArgs) Handles tilbakeBtn.Click
        Me.Close()
        LoginForm.Show()
    End Sub


End Class