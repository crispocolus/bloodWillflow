Imports System.Text.RegularExpressions
Imports System.Text
Public Class prosedyrer
    'Laster inn blodtype til bruk i forskjellige combo-boxer
    Public Function lastinnBlodtype()
        Dim info As New info
        Dim CountTabell As New DataTable
        CountTabell = info.query("blodtype", "blodgiver", "1 GROUP BY blodtype")
        Return CountTabell
    End Function

    'Sjekker om e-post adressen er gyldig
    Public Function validateEmail(emailAddress) As Boolean
        Dim epostChar As New Regex("@")
        If epostChar.IsMatch(emailAddress) Then
            Return True
        Else
            Return False
        End If
    End Function
    'Funksjon for å endre passord, avhengig av at bruker kan logge inn
    Public Sub endrePw(e_post As String)
        Dim info As New info
        Dim pHash As New passordHash
        Dim epost As New epost

        Dim newPass As String
        Dim connewPass As String
        Dim salt As String
        Dim hashPas As String

        newPass = InputBox("Skriv inn ditt ønskede passord")
        If newPass = "" Then
            MsgBox("Feltet kan ikke være blankt" & vbCrLf & "Passordet ble ikke oppdatert.")
            Exit Sub
        Else
            connewPass = InputBox("Bekreft passordet")

            If Not newPass = connewPass Then
                MsgBox("Passordene stemmer ikke overens.")
                Exit Sub
            End If
        End If
        salt = pHash.lagSalt
        hashPas = pHash.lagSaltetHash(newPass, salt)
        info.queryUpdate("bruker", "salt = '" & salt & "', hash = '" & hashPas & "'", "epost = '" & e_post & "' ")

        MsgBox("Ditt passord har blitt oppdatert")
    End Sub

    'Funksjon for glemt passord
    Public Sub glemtPw()
        Dim info As New info
        Dim pHash As New passordHash
        Dim epost As New epost
        Dim epostAdr As String
        Dim newPass As String
        Dim salt As String
        Dim hashPas As String
        Dim epostStat As Boolean
        epostAdr = InputBox("Skriv inn din e-post adresse")

        If validateEmail(epostAdr) = False Then
            MsgBox("Epost ikke godkjent." & vbCrLf & "Vennligst skriv inn en gyldig e-post adresse.")
        End If
        newPass = RndPass()
        salt = pHash.lagSalt
        hashPas = pHash.lagSaltetHash(newPass, salt)
        info.queryUpdate("bruker", "salt = '" & salt & "', hash = '" & hashPas & "'", "epost = '" & epostAdr & "' ")

        epostStat = epost.sendEpost("Ditt passord har blitt tilbakestilt", "Ditt nye passord er " & newPass & vbCrLf &
                        "Din e-post adresse er " & epostAdr & ". " & vbCrLf &
                        "Ta kontakt med support hvis du opplever problemer.", epostAdr)

        If epostStat = False Then
            MsgBox("En feil oppstod")
        Else
            MsgBox("Et nytt passord har blitt sendt til din epost-adresse.")
        End If
    End Sub

    'Genererer et tilfeldig passord ved reset
    Public Function RndPass()
        Dim s As String = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789"
        Dim r As New Random
        Dim sb As New StringBuilder
        For i As Integer = 1 To 8
            Dim idx As Integer = r.Next(0, 35)
            sb.Append(s.Substring(idx, 1))
        Next
        Return (sb.ToString())
    End Function

    'Generell funksjon for å logge ut
    Public Sub loggUt()
        LoginForm.bnavn = ""
        LoginForm.Show()
        MsgBox("Du er nå logget ut")
    End Sub
End Class


'Lar en item i listbox ha en annen verdi. Brukes til bla. "sendInnkalling" etc.
Public Class listItem
    Public display As String
    Public value As Decimal
    Public Overrides Function ToString() As String
        Return Me.display
    End Function
End Class
