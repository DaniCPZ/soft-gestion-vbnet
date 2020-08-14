Imports System.Net
Imports System.Net.Mail
Public MustInherit Class MasterEmialServer
    Private smtpCliente As SmtpClient
    Protected remitente As String
    Protected password As String
    Protected host As String
    Protected port As Integer
    Protected ssl As Boolean

    Protected Sub inicializar()
        smtpCliente = New SmtpClient()
        smtpCliente.Credentials = New NetworkCredential(remitente, password)
        smtpCliente.Host = host
        smtpCliente.Port = port
        smtpCliente.EnableSsl = ssl
    End Sub
    Public Sub enviarCorreo(asunto As String, cuerpo As String, destinatarios As List(Of String))
        Dim mensajeEmail As New MailMessage
        Try
            mensajeEmail.From = New MailAddress(remitente)
            For Each destinatario As String In destinatarios
                mensajeEmail.To.Add(destinatario)
            Next
            mensajeEmail.Subject = asunto
            mensajeEmail.Body = cuerpo
            mensajeEmail.Priority = MailPriority.Normal
            smtpCliente.Send(mensajeEmail)
        Catch ex As Exception
        Finally
            mensajeEmail.Dispose()
            smtpCliente.Dispose()
        End Try
    End Sub

End Class
