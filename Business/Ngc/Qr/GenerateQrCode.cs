using QRCoder;
using System.Net.Mail;
using System.Net.Mime;

namespace Business.Ngc.Qr
{
    internal static class GenerateQrCode
    {
        public static Attachment Obtener_Qr_PorTexto(string texto)
        {
            try
            {  
                var qrGenerator = new QRCodeGenerator();
                var qrCodeData = qrGenerator.CreateQrCode(texto, QRCodeGenerator.ECCLevel.Q);

                // PNG en forma de byte[]  
                PngByteQRCode qrCode = new PngByteQRCode(qrCodeData);
                byte[] qrCodeBytes = qrCode.GetGraphic(20);

                // Convertir el byte[] a MemoryStream  
                MemoryStream ms = new MemoryStream(qrCodeBytes);

                // Crear el adjunto  
                ContentType contentType = new ContentType(MediaTypeNames.Image.Png);
                Attachment attachment = new Attachment(ms, "qr.png", MediaTypeNames.Image.Png); 
                if (attachment.ContentDisposition != null)
                {
                    attachment.ContentDisposition.FileName = "qr.png";
                }

                attachment.ContentType = contentType;

                return attachment;
            }
            catch (Exception ex)
            {
                throw new Exception("Error al generar el código QR: " + ex.Message, ex);
            }
        }
    }
}
