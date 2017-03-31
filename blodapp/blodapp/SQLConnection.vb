Imports MySql.Data.MySqlClient
Public Class SQL
    Public oppkobling = New MySqlConnection("server=mysql.stud.iie.ntnu.no;database=g_oops_25;uid=g_oops_25;Pwd=M3PV7P9e;Convert Zero Datetime=true;")
    Public paakoblet As Boolean = False
End Class
Public Class Login
    Public brukernavn As String
    Public passord As String
    Public databasenavn As String
    Dim brukerstatus As String

    'Påloggingskode. Utføres når brukeren logger inn.
    Public Function innlogging()
        'Importerer oppkobling fra SQL klassen
        Dim connect As New SQL
        Dim oppkobling = connect.oppkobling
        Dim pros As New prosedyrer
        'Importerer BrukerStat klassen
        Dim brukerstat As New BrukerStat
        Dim janei As Integer

        'Åpner tilkoblingen til databasen
        Try
            oppkobling.Open()

            'Finner brukeren i databasen
            Dim sqlSporring = "select * from bruker where epost=@brukernavn " & " and hash=@passordHash"

            'Setter opp en sql funksjon ved hjelp av spørringen og tilkoblingen
            Dim sql As New MySqlCommand(sqlSporring, oppkobling)

            'Gjør det mulig å bruke variabler i sql-kode
            sql.Parameters.AddWithValue("@brukernavn", brukernavn)
            sql.Parameters.AddWithValue("@passordHash", passord)

            'Fyller en tabell med resultat fra query
            Dim da As New MySqlDataAdapter
            Dim interTabell As New DataTable
            da.SelectCommand = sql
            da.Fill(interTabell)

            'Sjekker om det kommer noe restultat. Hvis ja, sier "Logget på" og utfører "sjekkBrukerStat()"
            If interTabell.Rows.Count > 0 Then
                MsgBox("Innlogget", MsgBoxStyle.Information)
                brukerstat.sjekkBrukerStat(LoginForm.bnavn)
                connect.paakoblet = True
                LoginForm.attempts = 0
                Return connect.paakoblet
            End If
            If LoginForm.attempts = 2 Then
                janei = MsgBox("Du har skrevet inn feil brukernavn eller passord 3 ganger. Har du glemt passordet?", MsgBoxStyle.YesNo)
                If janei = DialogResult.Yes Then
                    pros.glemtPw()
                End If
            Else
                MsgBox("Feil brukernavn eller passord")
                LoginForm.attempts += 1
                MsgBox(LoginForm.attempts)
                oppkobling.Close()
                Return "Feil brukernavn eller passord"
            End If
            oppkobling.Close()
        Catch ex As MySqlException
            'Gir feilmelding om 
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

            Dim sqlSporring = "select brukerstatus from bruker where epost=@brukernavn"
            Dim sql As New MySqlCommand(sqlSporring, oppkobling)

            sql.Parameters.AddWithValue("@brukernavn", bnavn)
            sql.ExecuteNonQuery()

            Dim leser = sql.ExecuteReader()
            While leser.Read()
                brukerstatus = (leser("brukerstatus"))
            End While
            leser.Close()

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
        Catch ex As MySqlException
            MessageBox.Show("Noe gikk galt: " & ex.Message)
        End Try
    End Sub
End Class

Public Class RegBruker
    Public Sub sendInfo(postnr As String,
                        gtadresse As String,
                        pnummer As String,
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

        Dim adresse_id As String

        Try
            oppkobling.Open()

            Dim sqlSporring = "insert into adresse (post_nr, gateadresse, stednavn) values (@post_nr, @gtadresse, @stdnavn)"

            Dim sql As New MySqlCommand(sqlSporring, oppkobling)

            sql.Parameters.AddWithValue("@post_nr", postnr)
            sql.Parameters.AddWithValue("@gtadresse", gtadresse)

            adresse_id = sql.LastInsertedId

            Dim sqlSporring2 = "insert into bruker (person_nr, brukerstatus, fornavn, etternavn, epost, telefon, fdato, post_nr,gateadresse, hash, salt) values (@person_nr, @brukerstatus, @fornavn, @etternavn, @epost, @telefon, @fdato, @post_nr,@gateadresse, @hash, @salt)"

            Dim sql2 As New MySqlCommand(sqlSporring2, oppkobling)
            sql2.Parameters.AddWithValue("@person_nr", pnummer)
            sql2.Parameters.AddWithValue("@brukerstatus", "0")
            sql2.Parameters.AddWithValue("@fornavn", fnavn)
            sql2.Parameters.AddWithValue("@etternavn", enavn)
            sql2.Parameters.AddWithValue("@epost", epost)
            sql2.Parameters.AddWithValue("@telefon", telefon)
            sql2.Parameters.AddWithValue("@fdato", fdato)
            sql2.Parameters.AddWithValue("@post_nr", postnr)
            sql2.Parameters.AddWithValue("@gateadresse", gateadresse)
            sql2.Parameters.AddWithValue("@hash", passordHash)
            sql2.Parameters.AddWithValue("@salt", salt)

            sql2.ExecuteNonQuery()

            oppkobling.Close()
        Catch ex As Exception
            MessageBox.Show("Noe gikk galt: " & ex.Message)
        End Try
    End Sub
End Class

Public Class soking

    Public Function sok(sokeord As String, sorter As String)
        'Importerer oppkobling fra SQL klassen
        Dim connect As New SQL
        Dim oppkobling = connect.oppkobling
        Dim tabell As New DataTable
        Try
            oppkobling.Open()

            Dim sqlSporring = "SELECT * FROM bruker WHERE " & sorter & " = " & "'" & sokeord & "'"

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

        Catch ex As Exception
            MessageBox.Show("Noe gikk galt: " & ex.Message)
            Return tabell
        End Try
    End Function

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


'    'Public Class HentData
'    Private Function HentData(ByVal sql As String) As DataTable
'        'Importerer oppkobling fra SQL klassen
'        Dim connect As New SQL
'        Dim oppkobling = connect.oppkobling

'        Dim tabell As New DataTable
'        If connect.paakoblet = False Then
'            MsgBox("Du er ikke logget inn")
'        Else
'            Try
'                oppkobling.Open()
'                Dim kommando As New MySqlCommand(sql, oppkobling)
'                Dim da As New MySqlDataAdapter
'                da.SelectCommand = kommando
'                da.Fill(tabell)
'                oppkobling.Close()
'            Catch ex As MySqlException
'                MessageBox.Show("Noe gikk galt: " & ex.Message)
'            End Try
'        End If
'        Return tabell
'    End Function
'End Class

'    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
'        Dim sok As String
'        sok = TextBox4.Text

'        Select Case ComboBox1.Text
'            Case "fornavn"
'                sorter = "Fornavn"
'            Case "etternavn"
'                sorter = "Etternavn"
'            Case "epost"
'                sorter = "Epost"
'            Case "fdato"
'                sorter = "Fdato"
'            Case "id"
'                sorter = "Id"
'        End Select

'        Dim tabell As New DataTable
'        tabell = Sporring("SELECT * FROM Oving4 WHERE " & sorter & " LIKE '%" & sok & "%'")

'        ListBox1.Items.Clear()
'        For Each rad As DataRow In tabell.Rows
'            ListBox1.Items.Add(rad("Fornavn") & " " & rad("Etternavn") & " " & rad("Epost") & " " & rad("Fdato"))
'        Next
'    End Sub

'    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
'        Dim age As Double
'        Dim totalAge As Double
'        Dim avgAge As Double

'        Try

'            Dim tabell As New DataTable
'            tabell = Sporring("SELECT Fdato FROM Oving4")

'            For Each rad As DataRow In tabell.Rows
'                Dim birthDate As Date = (rad("Fdato"))
'                Dim span As TimeSpan = Date.Now - birthDate
'                Dim days As Int32 = span.Days
'                age = span.Days / 365
'                totalAge += age
'            Next
'            avgAge = totalAge / tabell.Rows.Count
'            ListBox1.Items.Clear()
'            ListBox1.Items.Add("Gjenomsnittsalderen er " & avgAge)

'        Catch ex As MySqlException
'            MessageBox.Show("Det oppstod en feil: " & ex.Message)
'        End Try
'    End Sub

'    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click
'        Dim ageStorst As Double
'        Dim eldst As Double
'        Dim eldstNavn As String


'        Try
'            Dim tabell As New DataTable
'            tabell = Sporring("SELECT * FROM Oving4")

'            For Each rad As DataRow In tabell.Rows
'                Dim birthDate As Date = (rad("Fdato"))
'                Dim span As TimeSpan = Date.Now - birthDate
'                Dim days As Int32 = span.Days
'                ageStorst = span.Days / 365
'                If ageStorst > eldst Then
'                    eldst = ageStorst
'                    eldstNavn = rad("Fornavn")
'                End If
'            Next
'            ListBox1.Items.Clear()
'            ListBox1.Items.Add("Den eldste personen er " & eldstNavn)

'        Catch ex As MySqlException
'            MessageBox.Show("Det oppstod en feil: " & ex.Message)
'        End Try
'    End Sub

'    Private Sub Button10_Click(sender As Object, e As EventArgs) Handles Button10.Click
'        Dim ageMinst As Double
'        Dim yngst As Double = 999 'Det er meget usannsynelig at noen er over 999 år
'        Dim yngstNavn As String
'        Try

'            Dim tabell As New DataTable
'            tabell = Sporring("SELECT * FROM Oving4")

'            For Each rad As DataRow In tabell.Rows
'                Dim birthDate As Date = (rad("Fdato"))
'                Dim span As TimeSpan = Date.Now - birthDate
'                Dim days As Int32 = span.Days
'                ageMinst = span.Days / 365
'                If ageMinst < yngst Then
'                    yngst = ageMinst
'                    yngstNavn = rad("Fornavn")
'                    'ListBox1.Items.Add(yngstNavn & yngst)
'                End If
'            Next
'            ListBox1.Items.Clear()
'            ListBox1.Items.Add("Den yngste personen er " & yngstNavn)

'        Catch ex As MySqlException
'            MessageBox.Show("Det oppstod en feil: " & ex.Message)

'        End Try
'    End Sub

'    Private Sub Button11_Click(sender As Object, e As EventArgs) Handles Button11.Click
'        Dim nummer As Integer
'        nummer = (ComboBox2.SelectedIndex + 1)

'        Dim tabell As New DataTable
'        tabell = Sporring("SELECT * FROM Oving4 WHERE Id = '" & nummer & "'")

'        For Each rad As DataRow In tabell.Rows
'            TextBox5.Text = rad("Fornavn")
'            TextBox6.Text = rad("Etternavn")
'            TextBox7.Text = rad("Epost")
'            TextBox8.Text = rad("Fdato")
'            Return
'        Next
'    End Sub

'    Private Sub Button13_Click(sender As Object, e As EventArgs) Handles Button13.Click
'        ComboBox2.Items.Clear()
'        Dim CountTabell As New DataTable
'        CountTabell = Sporring("SELECT * FROM Oving4")

'        For i As Integer = 1 To CountTabell.Rows.Count
'            ComboBox2.Items.Add(i)
'        Next
'    End Sub

'    Private Sub Button12_Click(sender As Object, e As EventArgs) Handles Button12.Click
'        Dim nummer As Integer
'        nummer = (ComboBox2.SelectedIndex + 1)

'        Dim tabell As New DataTable
'        tabell = Sporring("UPDATE Oving4 SET Fornavn='" & TextBox5.Text & "', Etternavn='" & TextBox6.Text & "', Epost='" & TextBox7.Text & "' WHERE Id = '" & nummer & "'")
'    End Sub

'    Private Sub Button14_Click(sender As Object, e As EventArgs) Handles Button14.Click
'        status = False
'        Label5.Text = "Bruker innlogget: NaN"
'    End Sub

'    Private Sub Button15_Click(sender As Object, e As EventArgs) Handles Button15.Click
'        oppkobling.Open()

'        If status = False Then
'            MsgBox("Du har ikke logget inn")
'        Else
'            Try
'                Dim brukernavn = TextBox1.Text
'                Dim passord = TextBox2.Text
'                Dim sqlSporring = "insert into brukere (brukernavn, passord) values (@brukernavn, @passord)"

'                Dim sql As New MySqlCommand(sqlSporring, oppkobling)

'                sql.Parameters.AddWithValue("@brukernavn", brukernavn)
'                sql.Parameters.AddWithValue("@passord", passord)

'                sql.ExecuteNonQuery()
'                oppkobling.Close()
'                MsgBox("Du har opprettet bruker med id: " & sql.LastInsertedId)
'            Catch ex As Exception
'                MessageBox.Show("Noe gikk galt: " & ex.Message)
'            End Try
'        End If
'    End Sub

'    Private Sub Button16_Click(sender As Object, e As EventArgs) Handles Button16.Click
'        Dim sqlsporring = "select brukernavn from brukere"
'        Dim sql As New MySqlCommand(sqlsporring, oppkobling)
'        Dim leser = sql.ExecuteReader()

'        While leser.Read()
'            MsgBox("Bruker : " & leser("brukernavn"))
'        End While
'    End Sub

'    Private Function lesTilfeldigVits()
'        Dim output As String
'        Dim index As Integer = Math.Round(10 - 1 + 1) * Rnd() + 1

'        oppkobling.Close()
'        oppkobling.Open()

'        Dim sqlsporring2 = "select text from vits where id = '" & index & "'"
'        Dim sql2 As New MySqlCommand(sqlsporring2, oppkobling)
'        Dim leser = sql2.ExecuteReader()
'        While leser.Read()
'            output = leser("text")
'        End While
'        leser.Close()

'        Return output
'    End Function