Imports System.Net.Mail
Imports System.IO
Imports System.Net

Public Class NotificationForm


    Private Sub btnSend_Click(sender As Object, e As EventArgs) Handles btnSend.Click
        Try
            Dim smtp As New SmtpClient("smtp.gmail.com")
            Dim Email As New MailMessage
            smtp.UseDefaultCredentials = False
            smtp.Credentials = New Net.NetworkCredential("2205802@students.kcau.ac.ke", "41271623")
            smtp.Port = 587
            smtp.EnableSsl = True
            smtp.Host = "smtp.gmail.com"
            Email = New MailMessage()
            Email.From = New MailAddress(txtToAddress.Text)
            Email.To.Add(txtToAddress.Text)
            Email.IsBodyHtml = False
            Email.Body = txtBody.Text
            smtp.Send(Email)
            MsgBox("Email Sent", MsgBoxStyle.Information)
            Me.Close()
        Catch ex As Exception

            MsgBox("Error: " & ex.Message, MsgBoxStyle.Critical)
        End Try
    End Sub

    Private Sub NotificationForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class