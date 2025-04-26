using Business.Ngc.Qr;
using Business.Settings;
using Data;
using Microsoft.Extensions.Options;
using System.Net;
using System.Net.Mail;

public class EmailService
{
    readonly IOptions<EmailSettings> _mailSettings;

    public EmailService(IOptions<EmailSettings> mailSettings)
    {
        _mailSettings = mailSettings;
    }

    public void EnviarCorreoConQr(string destinatario, string textoQr)
    {
        try
        {
            // Crear QR como adjunto
            Attachment qrAttachment = GenerateQrCode.Obtener_Qr_PorTexto(textoQr);

            // Crear el mensaje
            MailMessage mensaje = new MailMessage
            {
                From = new MailAddress(_mailSettings.Value.From, _mailSettings.Value.DisplayName),
                Subject = "Aquí está tu código QR",
                Body = "Adjunto encontrarás tu código QR.",
                IsBodyHtml = false
            };

            mensaje.To.Add(destinatario);
            mensaje.Attachments.Add(qrAttachment);

            // Configurar el cliente SMTP
            using SmtpClient smtp = new SmtpClient(_mailSettings.Value.Host, _mailSettings.Value.Port)
            {
                Credentials = new NetworkCredential(_mailSettings.Value.UserName, _mailSettings.Value.Password),
                EnableSsl = _mailSettings.Value.UseSSL
            };

            // STARTTLS (si es necesario)
            if (_mailSettings.Value.UseStartTls)
            {
                smtp.EnableSsl = true; // en .NET esto también cubre STARTTLS
            }

            smtp.Send(mensaje);
            Console.WriteLine("Correo enviado correctamente.");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error al enviar el correo: {ex.Message}");
        }
    }
}
