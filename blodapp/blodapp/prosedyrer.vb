Imports System.Text.RegularExpressions
Imports System.Text
Public Class prosedyrer
    Public Function lastinnBlodtype()
        Dim info As New info
        Dim CountTabell As New DataTable
        CountTabell = info.query("blodtype", "blodgiver", "1 GROUP BY blodtype")
        Return CountTabell
    End Function
    Public Function validateEmail(emailAddress) As Boolean
        Dim epostChar As New Regex("@")
        If epostChar.IsMatch(emailAddress) Then
            Return True
        Else
            Return False
        End If
    End Function

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
            MsgBox("Epost ikke godkjent. Sjekk om du har husket @")
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
End Class
