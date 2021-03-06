﻿Imports MySql.Data.MySqlClient

Public Class LoginForm
    'Brukes for å vite hvem som er innlogget og antall forsøk på å logge inn
    Public bnavn As String
    Public attempts As Integer

    Private Sub LoginForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'sentrerer vinduet til midten av skjermen
        Me.CenterToScreen()
    End Sub

    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        loggInn()

    End Sub

    Private Sub llblLoginReg_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles llblLoginReg.LinkClicked
        'Viser registreringskjema når brukeren trykker på "Registrer" knappen
        RegistrerForm.Show()
        Me.Hide()
    End Sub

    'knapp for glemt passord
    Private Sub llblLoginFgtPwd_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles llblLoginFgtPwd.LinkClicked
        Dim pros As New prosedyrer
        pros.glemtPw()
    End Sub

    Private Sub loggInn()
        'Lager et nytt SQL og et nytt Login-objekt. 
        Dim connect As New SQL
        Dim logginntest As New Login
        Dim pHash As New passordHash

        'Skriver brukernavn til logginntest-objektet
        logginntest.brukernavn = txtLoginBrukernavn.Text.Replace("'", "\'")

        'Skriver passordet til en variabel som brukes i hasingen
        Dim unhashed As String = txtLoginPwd.Text

        'Definerer en ny variabel for saltet
        Dim salt As String = 0

        bnavn = txtLoginBrukernavn.Text

        'Funksjon for å hente salt fra databasen. 
        Try
            Dim oppkobling = connect.oppkobling
            oppkobling.Open()

            Dim sqlSporring = "select salt from bruker where epost=@brukernavn"
            Dim sql As New MySqlCommand(sqlSporring, oppkobling)

            sql.Parameters.AddWithValue("@brukernavn", bnavn)
            sql.ExecuteNonQuery()

            Dim leser = sql.ExecuteReader()
            While leser.Read()
                salt = (leser("salt"))
            End While

            leser.Close()
            oppkobling.Close()


        Catch ex As MySqlException
            MessageBox.Show("Noe gikk galt: " & ex.Message)
        End Try

        Dim hashed As String
        hashed = pHash.lagSaltetHash(unhashed, salt)

        logginntest.passord = hashed

        'sender info videre til innlogging i SQLConnection
        logginntest.innlogging()

    End Sub
End Class
