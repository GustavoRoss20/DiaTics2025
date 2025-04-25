using QRCoder;
using System.Drawing;
using System.Drawing.Imaging;
using System.Net.Mail;
using System.Net.Mime;

namespace Business.Ngc.Qr
{
    internal static class GenerateQrCode
    {
        //public static Attachment Obtener_Qr_PorTexto(string texto)
        //{
        //    //try
        //    //{
        //    //    // Crear el generador de QR
        //    //    QRCodeGenerator qrGenerator = new QRCodeGenerator();
        //    //    QRCodeData qrCodeData = qrGenerator.CreateQrCode(texto, QRCodeGenerator.ECCLevel.Q);
        //    //    QRCode qrCode = new QRCode(qrCodeData);

        //    //    // Generar la imagen del QR
        //    //    using (Bitmap qrCodeImage = qrCode.GetGraphic(20))
        //    //    {
        //    //        // Convertir la imagen a un MemoryStream
        //    //        using (MemoryStream ms = new MemoryStream())
        //    //        {
        //    //            qrCodeImage.Save(ms, ImageFormat.Png);
        //    //            ms.Position = 0;

        //    //            // Crear el adjunto
        //    //            ContentType contentType = new ContentType(MediaTypeNames.Image.Png);
        //    //            Attachment attachment = new Attachment(ms, "qr", MediaTypeNames.Image.Png);
        //    //            attachment.ContentDisposition.FileName = "qr";
        //    //            attachment.ContentType = contentType;

        //    //            return attachment;
        //    //        }
        //    //    }
        //    //}
        //    //catch (Exception ex)
        //    //{
        //    //    throw new Exception("Error al generar el código QR: " + ex.Message);
        //    //}
        //}
    }
}
