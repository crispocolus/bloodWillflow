Imports System.Net.Mail
Public Class epost
    'funksjon for å sende epost i diverse sammenhenger
    Public Function sendEpost(emne As String, message As String, mottaker As String)
        Try
            Dim Smtp_Server As New SmtpClient
            Dim e_mail As New MailMessage()
            Smtp_Server.UseDefaultCredentials = False
            'info for mailserver (gmail er brukt i dette tilfellet)
            Smtp_Server.Credentials = New Net.NetworkCredential("bloodflowas@gmail.com", "bloodwillflow")
            Smtp_Server.Port = 587
            Smtp_Server.EnableSsl = True
            Smtp_Server.Host = "smtp.gmail.com"

            e_mail = New MailMessage()
            e_mail.From = New MailAddress("bloodflowas@gmail.com")
            e_mail.To.Add(mottaker)
            e_mail.Subject = emne
            e_mail.IsBodyHtml = False
            e_mail.Body = message
            Smtp_Server.Send(e_mail)
            Return True

        Catch error_t As Exception
            MsgBox("Noe gikk galt: " & error_t.ToString & vbCrLf & "Vennligst ta kontakt med personalet")
            Return False
        End Try
    End Function
End Class
