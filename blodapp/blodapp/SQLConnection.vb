Imports MySql.Data.MySqlClient
Public Class Login
    Public brukernavn As String
    Public passord As String
    Public databasenavn As String
    'Public oppkobling As New MySqlConnection
    Private paakoblet As Boolean = False
    Public oppkobling = New MySqlConnection("server=mysql.stud.iie.ntnu.no;database=g_oops_25;uid=g_oops_25;Pwd=M3PV7P9e")
    Dim brukerstatus As String



    Public Sub innlogging()
        oppkobling.Open()
        Try
            Dim sqlSporring = "select * from bruker where epost=@brukernavn " & " and passord=@passord"
            Dim sql As New MySqlCommand(sqlSporring, oppkobling)

            sql.Parameters.AddWithValue("@brukernavn", brukernavn)
            sql.Parameters.AddWithValue("@passord", passord)

            Dim da As New MySqlDataAdapter
            Dim interTabell As New DataTable
            da.SelectCommand = sql
            da.Fill(interTabell)

            If interTabell.Rows.Count > 0 Then
                MsgBox("Logget på")
                paakoblet = True
                MsgBox(sjekkBrukerStat(brukernavn))
            Else
                MsgBox("Feil brukernavn eller passord")
                oppkobling.Close()
            End If
            oppkobling.Close()
        Catch ex As MySqlException
            MessageBox.Show("Noe gikk galt: " & ex.Message)
        End Try
    End Sub

    Public Function sjekkBrukerStat(bnavn As String)
        Try
            Dim brukerstatus As String
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
                    MsgBox("Du er en bruker")
                Case "1"
                    ansattSide.Show()
                    MsgBox("Du er en ansatt")
                Case "2"
                    adminSide.Show()
                    MsgBox("Du er en admin")
            End Select

            '**NOT WORKING **
            oppkobling.Close()
        Catch ex As MySqlException
            MessageBox.Show("Noe gikk galt: " & ex.Message)
        End Try
    End Function
End Class

'    Private brukernavn As String
'    Private passord As String
'    Private databasenavn As String
'    Private tjener As String

'    Private oppkobling As New MySqlConnection
'    Private connstring As String

'    Private sorter As String
'    Private status As Boolean = False
'    'Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
'    '    Try
'    '        Dim brukernavn = TextBox1.Text.Replace("'", "\'")
'    '        Dim passord = TextBox2.Text.Replace("'", "\'")
'    '        Dim sqlSporring = "select * from brukere where brukernavn=@brukernavn " & " and passord=@passord"
'    '        Dim sql As New MySqlCommand(sqlSporring, oppkobling)
'    '        'MsgBox("SQL-spørringen er: " & sqlSporring)

'    '        sql.Parameters.AddWithValue("@brukernavn", brukernavn)
'    '        sql.Parameters.AddWithValue("@passord", passord)

'    '        Dim da As New MySqlDataAdapter
'    '        Dim interTabell As New DataTable
'    '        da.SelectCommand = sql
'    '        da.Fill(interTabell)

'    '        If interTabell.Rows.Count > 0 Then
'    '            MsgBox("Logget på")
'    '            status = True
'    '            Label5.Text = "Bruker innlogget: " & brukernavn
'    '            MsgBox(lesTilfeldigVits())
'    '        Else
'    '            MsgBox("Feil brukernavn eller passord")
'    '            oppkobling.Close()
'    '        End If
'    '        oppkobling.Close()
'    '    Catch ex As MySqlException
'    '        MessageBox.Show("Noe gikk galt: " & ex.Message)
'    '    End Try

'    'End Sub

'    Private Function Sporring(ByVal sql As String) As DataTable
'        Dim tabell As New DataTable

'        If status = False Then
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
'    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

'        oppkobling = New MySqlConnection("server=mysql.stud.iie.ntnu.no;database=g_oops_25;uid=g_oops_25;Pwd=M3PV7P9e")
'        oppkobling.Open()
'    End Sub

'    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
'        Application.Exit()
'    End Sub

'    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
'        Sporring("CREATE TABLE Oving4 (Id int, Fornavn Char(25), Etternavn Char(25), Epost Char(25), Fdato Date)")
'        Sporring("INSERT INTO Oving4 (Id, Fornavn, Etternavn, Epost, Fdato) VALUES (1, 'Sven', 'Horgen', 'svenhorgen@gmail.com', '1985-12-23')")
'        Sporring("INSERT INTO Oving4 (Id, Fornavn, Etternavn, Epost, Fdato) VALUES (2, 'Kari', 'Svensen', 'sven.kari@hotmail.com', '1956-03-12')")
'        Sporring("INSERT INTO Oving4 (Id, Fornavn, Etternavn, Epost, Fdato) VALUES (3, 'Ove', 'Jensen', 'ove@jensen.no', '1978-05-11')")
'    End Sub

'    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
'        Dim tabell As New DataTable
'        tabell = Sporring("SELECT * FROM Oving4")

'        ListBox1.Items.Clear()
'        For Each rad As DataRow In tabell.Rows
'            ListBox1.Items.Add(rad("Id") & " " & rad("Fornavn") & " " & rad("Etternavn") & " " & rad("Epost") & " " & rad("Fdato"))
'        Next
'        oppkobling.Close()
'    End Sub

'    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
'        Dim sorter As String

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
'        tabell = Sporring("SELECT * FROM Oving4 ORDER By " & sorter)

'        ListBox1.Items.Clear()
'        For Each rad As DataRow In tabell.Rows
'            ListBox1.Items.Add(rad("Fornavn") & " " & rad("Etternavn") & " " & rad("Epost") & " " & rad("Fdato"))
'        Next

'    End Sub

'    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click

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
'        tabell = Sporring("SELECT * FROM Oving4 WHERE " & sorter & " = " & "'" & sok & "'")

'        ListBox1.Items.Clear()
'        For Each rad As DataRow In tabell.Rows
'            ListBox1.Items.Add(rad("Fornavn") & " " & rad("Etternavn") & " " & rad("Epost") & " " & rad("Fdato"))
'        Next
'    End Sub

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