﻿Imports MySql.Data.MySqlClient
Public Class SQL
    'Her ligger oppkoblingsdata, pluss en variabel for å se om tilkobling er 'aktiv'
    Public oppkobling = New MySqlConnection("server=mysql.stud.iie.ntnu.no;database=g_oops_25;uid=g_oops_25;Pwd=M3PV7P9e;Convert Zero Datetime=true;")
    Public paakoblet As Boolean = False
End Class
Public Class Login
    'Bruker ligger som eget objekt
    Public brukernavn As String
    Public passord As String
    Public databasenavn As String
    Dim brukerstatus As String

    'Påloggingskode. Utføres når brukeren logger inn.
    Public Function innlogging()
        'Importerer diverse klasser for eksterne prosedyrer og funksjoner
        Dim connect As New SQL
        Dim oppkobling = connect.oppkobling
        Dim pros As New prosedyrer
        Dim info As New info
        'Importerer BrukerStat klassen
        Dim brukerstat As New BrukerStat
        Dim janei As Integer

        Try
            'Finner den potensielle brukeren i databasen
            Dim interTabell As New DataTable
            interTabell = info.query("*", "bruker", "epost = '" & brukernavn & "' AND hash = '" & passord & "'")

            'Sjekker om det kommer noe restultat tilbake. Hvis ja, sier "Logget på" og utfører sjekkBrukerStat() som sjekker hvilken type bruker det er
            If interTabell.Rows.Count > 0 Then
                brukerstat.sjekkBrukerStat(LoginForm.bnavn)
                connect.paakoblet = True
                LoginForm.attempts = 0
                Return connect.paakoblet
            End If
            'Hvis brukeren har prøvd å logge på med feil brukernavn/passord 3 ganger får de mulighet til å nullstille passordet
            If LoginForm.attempts = 2 Then 'tallet kan endres om man vil gi færre/flere forsøk
                janei = MsgBox("Du har skrevet inn feil brukernavn eller passord 3 ganger. Har du glemt passordet?", MsgBoxStyle.YesNo)
                If janei = DialogResult.Yes Then
                    pros.glemtPw()
                    Return "Glemt passord"
                End If
            Else
                'Øker forsøk for hver gang brukernavn eller passord blir skrevet feil
                MsgBox("Feil brukernavn eller passord")
                LoginForm.attempts += 1
                oppkobling.Close()
                Return "Feil brukernavn eller passord"
            End If
            oppkobling.Close()
            Return "oppkobling, close"
        Catch ex As MySqlException
            'Gir feilmelding om noe har gått galt
            MessageBox.Show("Noe gikk galt: " & ex.Message)
            Return ex.Message
        End Try
    End Function
End Class

Public Class BrukerStat
    Public Sub sjekkBrukerStat(bnavn As String)
        'Importerer oppkobling fra SQL klassen
        Dim connect As New SQL
        Dim oppkobling = connect.oppkobling

        Try
            'Åpner tilkobling mot databsen
            oppkobling.Open()

            'Definerer brukerstatus
            Dim brukerstatus As Integer = -1


            'SQL spørring som utføres
            Dim sqlSporring = "select brukerstatus from bruker where epost=@brukernavn"
            Dim sql As New MySqlCommand(sqlSporring, oppkobling)

            sql.Parameters.AddWithValue("@brukernavn", bnavn)
            'Utfører spørringen
            sql.ExecuteNonQuery()

            'Setter en leser på sql-spørringen
            Dim leser = sql.ExecuteReader()
            While leser.Read()
                brukerstatus = (leser("brukerstatus"))
            End While
            leser.Close()

            'Velger riktig side fra totalt 4 brukerstatuser
            Select Case brukerstatus
                Case "0"
                    brukerSide.Show()
                Case "1"
                    ansattSide.Show()
                Case "2"
                    lederSide.Show()
                Case "3"
                    adminSide.Show()
                Case Else
                    MsgBox("En feil oppstod: 'brukerstatus ikke funnet'. Vennligst kontakt personalet.")
            End Select
            oppkobling.Close()
            'Henter feil om noe gikk galt med spørringen
        Catch ex As MySqlException
            MessageBox.Show("Noe gikk galt: " & ex.Message)
        End Try
    End Sub
End Class

Public Class RegBruker
    'Viser til alle felt som fylles når man registerer bruker
    Public Sub sendInfo(postnr As String,
                        gtadresse As String,
                        pnummer As String,
                        brukerstatus As String,
                        fnavn As String,
                        enavn As String,
                        epost As String,
                        telefon As String,
                        fdato As String,
                        gateadresse As String,
                        passordHash As String,
                        salt As String
                        )
        'Importerer oppkobling fra SQL klassen
        Dim connect As New SQL
        Dim oppkobling = connect.oppkobling

        Try
            oppkobling.Open()

            'SQL spørring som utføres 
            Dim sqlSporring = "insert into adresse (post_nr, gateadresse, stednavn) values (@post_nr, @gtadresse)"

            Dim sql As New MySqlCommand(sqlSporring, oppkobling)

            sql.Parameters.AddWithValue("@post_nr", postnr)
            sql.Parameters.AddWithValue("@gtadresse", gtadresse)

            Dim sqlSporring2 = "insert into bruker (person_nr, brukerstatus, fornavn, etternavn, epost, telefon, fdato, post_nr, gateadresse, hash, salt) values (" & pnummer & ", 
                                                                                                                                                                  " & brukerstatus & ", 
                                                                                                                                                                  '" & fnavn & "', 
                                                                                                                                                                  '" & enavn & "', 
                                                                                                                                                                  '" & epost & "', 
                                                                                                                                                                  " & telefon & ", 
                                                                                                                                                                  " & fdato & ", 
                                                                                                                                                                  " & postnr & ", 
                                                                                                                                                                  '" & gateadresse & "', 
                                                                                                                                                                  '" & passordHash & "', 
                                                                                                                                                                  '" & salt & "');"

            Dim sql2 As New MySqlCommand(sqlSporring2, oppkobling)

            'Utfører SQL-spørringen
            sql2.ExecuteNonQuery()

            oppkobling.Close()
        Catch ex As Exception
            MessageBox.Show("Noe gikk galt " & ex.Message)
        End Try
    End Sub
End Class

Public Class soking
    'Søkefunksjon. Skal brukes for å søke etter ting i bruker-databasen
    Public Function sokBruker(sokeord As String, sorter As String)
        'Importerer oppkobling fra SQL klassen
        Dim connect As New SQL
        Dim oppkobling = connect.oppkobling
        Dim tabell As New DataTable
        Try
            oppkobling.Open()

            Dim sqlSporring = "Select * FROM bruker WHERE " & sorter & " = " & "'" & sokeord & "'"

            Dim SQL As New MySqlCommand(sqlSporring, oppkobling)

            Dim da As New MySqlDataAdapter
            da.SelectCommand = SQL
            da.Fill(tabell)
            Return tabell
            oppkobling.Close()

        Catch ex As Exception
            MessageBox.Show("Noe gikk galt: " & ex.Message)
            Return tabell
        End Try
    End Function
End Class

Public Class info
    'Generisk query-funksjon. Kan velge 'SELECT', 'FROM' og 'WHERE' som parametre. 
    Public Function query(velg As String, fra As String, hvor As String)
        'Importerer oppkobling fra SQL klassen
        Dim connect As New SQL
        Dim oppkobling = connect.oppkobling
        Dim tabell As New DataTable
        Try
            oppkobling.Open()

            Dim sqlSporring = "SELECT " & velg & " FROM " & fra & " WHERE " & hvor & ";"

            Dim SQL As New MySqlCommand(sqlSporring, oppkobling)

            Dim da As New MySqlDataAdapter
            da.SelectCommand = SQL
            da.Fill(tabell)
            Return tabell
            oppkobling.Close()
        Catch ex As Exception
            MessageBox.Show("Noe gikk galt: " & ex.Message)
            Return tabell
        End Try
    End Function

    'Generisk query-join funksjon. Kan velge 'SELECT', 'FROM', 'INNER JOIN' og 'WHERE' som parametre.  
    Public Function queryJoin(velg As String, fra As String, join As String, hvor As String)
        'Importerer oppkobling fra SQL klassen
        Dim connect As New SQL
        Dim oppkobling = connect.oppkobling
        Dim tabell As New DataTable
        Try
            oppkobling.Open()

            Dim sqlSporring = "SELECT " & velg & " FROM " & fra & " INNER JOIN " & join & " WHERE " & hvor & ";"

            Dim SQL As New MySqlCommand(sqlSporring, oppkobling)

            Dim da As New MySqlDataAdapter
            da.SelectCommand = SQL
            da.Fill(tabell)
            Return tabell
            oppkobling.Close()

        Catch ex As MySqlException
            MessageBox.Show("Noe gikk galt: " & ex.Message)
            Return tabell
        End Try
    End Function
    'Litt mer spesifikk query. Bruker 'INNER JOIN' og returnerer timer utifra dato. 
    Public Function queryDato(dato As String)
        'Importerer oppkobling fra SQL klassen
        Dim connect As New SQL
        Dim oppkobling = connect.oppkobling
        Dim tabell As New DataTable

        Try
            oppkobling.Open()

            Dim sqlSporring = "SELECT fritekst_innkalling, oppmote FROM innkallinger INNER JOIN bruker ON bruker.person_nr = innkallinger.person_nr WHERE oppmote = '" & dato & "' AND bruker.epost = '" & LoginForm.bnavn & "' ;"
            Dim SQL As New MySqlCommand(sqlSporring, oppkobling)

            SQL.Parameters.AddWithValue("dato", SqlDbType.DateTime).Value = dato

            Dim da As New MySqlDataAdapter
            da.SelectCommand = SQL
            da.Fill(tabell)
            Return tabell
            oppkobling.Close()

        Catch ex As Exception
            MessageBox.Show("Noe gikk galt: " & ex.Message)
            Return tabell
        End Try
    End Function
    'Genereisk queryUpdate-funksjon. Kan brukes til å oppdatere brukeredata f.eks. Har 'UPDATE', 'SET' og 'WHERE' som parametre. 
    Public Sub queryUpdate(table As String, hvorVerdi As String, where As String)

        'Importerer oppkobling fra SQL klassen
        Dim connect As New SQL
        Dim oppkobling = connect.oppkobling

        Try
            oppkobling.Open()
            Dim sqlSporring = "UPDATE " & table & " SET " & hvorVerdi & " WHERE " & where & ";"
            Dim SQL As New MySqlCommand(sqlSporring, oppkobling)
            SQL.ExecuteNonQuery()
            oppkobling.Close()

        Catch ex As Exception
            MessageBox.Show("Noe gikk galt: " & ex.Message)
        End Try
    End Sub
    'Prosedyre for å sende innkalling. Bruker person_nr, innkallingsTekst og dato som parametre. 
    Public Sub sendInnkalling(personnummer As String, innkallingTekst As String, dato As String)
        'Importerer oppkobling fra SQL klassen
        Dim connect As New SQL
        Dim oppkobling = connect.oppkobling

        Dim status As String = 0

        Try
            oppkobling.Open()

            Dim sqlSporring = "insert into innkallinger (person_nr, tid_sendt, status, fritekst_innkalling, oppmote) values (" & personnummer & ",  
                                                                                                                            CURDATE() , 
                                                                                                                           " & status & ", 
                                                                                                                           '" & innkallingTekst & "', 
                                                                                                                           '" & dato & "');" '
            Dim sql As New MySqlCommand(sqlSporring, oppkobling)
            sql.ExecuteNonQuery()
            oppkobling.Close()
        Catch ex As Exception
            MessageBox.Show("Noe gikk galt: " & ex.Message)
        End Try
    End Sub
End Class

Public Class EgenErk
    Public Sub sendEgenErk(pnummer As String)
        'Importerer oppkobling fra SQL klassen
        Dim info As New info
        Dim connect As New SQL
        Dim oppkobling = connect.oppkobling
        Dim skjema_id As String

        'Try
        oppkobling.Open()

        'SQL spørring som utføres 
        Dim sqlSporring = "insert into skjema (person_nr, dato) values (" & pnummer & ", CURDATE())"

        Dim sql As New MySqlCommand(sqlSporring, oppkobling)
        sql.ExecuteNonQuery()

        skjema_id = hentSenesteEgenErk(pnummer)

        info.queryUpdate("blodgiver", "sendSms = " & egenerklaering.svar(0) & ", sendEpost= '" & egenerklaering.svar(1) & "'", "person_nr = '" & pnummer & "'")
        Dim sqlSporring2 = "INSERT INTO skjema_besvar VALUES(" & hentDataTabLand(skjema_id, "Norge") & ");
                            INSERT INTO skjema_fire_uker VALUES(" & hentDataTab(skjema_id, 18, 22) & ");
                            INSERT INTO skjema_to_aar VALUES(" & hentDataTab(skjema_id, 23, 23) & ");               
                            INSERT INTO skjema_seks_mnd VALUES(" & hentDataTab(skjema_id, 24, 40) & ");
                            INSERT INTO skjema_livet VALUES(" & hentDataTab(skjema_id, 41, 55) & ");
                            INSERT INTO skjema_kvinner VALUES(" & hentDataTab(skjema_id, 56, 59) & ");
                            INSERT INTO skjema_menn VALUES(" & hentDataTab(skjema_id, 60, 60) & ")"

        MsgBox(sqlSporring2)

        Dim sql2 As New MySqlCommand(sqlSporring2, oppkobling)

        'Utfører SQL-spørringen
        sql2.ExecuteNonQuery()

        oppkobling.Close()
        'Catch ex As Exception
        'MessageBox.Show("Noe gikk galt " & ex.Message)
        'End Try
    End Sub

    Public Sub hentEgenErk(pnummer As String)
        'Importerer oppkobling fra SQL klassen
        Dim info As New info
        Dim connect As New SQL
        Dim oppkobling = connect.oppkobling
        Dim skjema_id As String
        Dim table As New DataTable
        Dim mottatSvar As New ArrayList()

        skjema_id = hentSenesteEgenErk(pnummer)


        table = info.query("*, NULL AS skjema_id", "skjema_besvar", "skjema_id = " & skjema_id & "")

        For Each kolonne In table.Columns
            mottatSvar.Add(kolonne)
        Next

        MsgBox(mottatSvar)

        info.query("*", "skjema_besvar", "pnummer = " & pnummer & "")

        info.query("*", "skjema_besvar", "pnummer = " & pnummer & "")

        info.query("*", "skjema_besvar", "pnummer = " & pnummer & "")

        info.query("*", "skjema_besvar", "pnummer = " & pnummer & "")

        info.query("*", "skjema_besvar", "pnummer = " & pnummer & "")
        info.query("*", "skjema_besvar", "pnummer = " & pnummer & "")

        'info.queryUpdate("blodgiver", "sendSms = " & egenerklaering.svar(0) & ", sendEpost= '" & egenerklaering.svar(1) & "'", "person_nr = '" & pnummer & "'")
        'Dim sqlSporring2 = "SELECT * FROM skjema_besvar VALUES(" & hentDataTabLand(skjema_id, "Norge") & ");
        '                    INSERT INTO skjema_fire_uker VALUES(" & hentDataTab(skjema_id, 18, 22) & ");
        '                    INSERT INTO skjema_to_aar VALUES(" & hentDataTab(skjema_id, 23, 23) & ");               
        '                    INSERT INTO skjema_seks_mnd VALUES(" & hentDataTab(skjema_id, 24, 40) & ");
        '                    INSERT INTO skjema_livet VALUES(" & hentDataTab(skjema_id, 41, 55) & ");
        '                    INSERT INTO skjema_kvinner VALUES(" & hentDataTab(skjema_id, 56, 59) & ");
        '                    INSERT INTO skjema_menn VALUES(" & hentDataTab(skjema_id, 60, 60) & ")"

        'Catch ex As Exception
        'MessageBox.Show("Noe gikk galt " & ex.Message)
        'End Try
    End Sub

    Public Function hentSenesteEgenErk(personnummer As String)
        Dim info As New info
        Dim tabell As New DataTable

        tabell = info.query("skjema_id", "skjema", "person_nr = " & personnummer & " ORDER BY skjema_id DESC LIMIT 1")
        For Each rad In tabell.Rows
            Return rad("skjema_id")
        Next

    End Function
    Public Function hentDataTabLand(skjema_id As String, land As String)
        Dim mid As String = skjema_id & ", "
        For i = 2 To 17
            If i < 17 Then
                mid += egenerklaering.svar(i) & ", "
            Else
                mid += "'" & land & "'"
            End If
        Next
        'MsgBox(mid)
        Return mid
    End Function
    Public Function hentDataTab(skjema_id As String, start As Double, slutt As Double)
        Dim mid As String = skjema_id & ", "

        If start = slutt Then
            mid = mid & egenerklaering.svar(start)
            Return mid
        Else
            MsgBox(start)
            MsgBox(slutt)
            For i = start To slutt
                If i = slutt Then
                    mid = mid & egenerklaering.svar(i)
                Else
                    mid = mid & egenerklaering.svar(i) & ", "
                End If
            Next
            'MsgBox(mid2)
            Return CStr(mid)
        End If
    End Function
End Class



