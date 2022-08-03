using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Mail;

namespace infotepAssistControl.controller
{
    public class ImailController
    {
        public bool mensaje { get; set; }

        public void mensajes(string correo_destino , string adjunto )
        {

                string reporte_de_origen = @"reportesinfotep@gmail.com";
                string contrasena = @"II121231234";
            //    string reporte_de_destino = @"pinales946@gmail.com";
            //    string path = @"C:\Users\Franklyn\Desktop\fondo de pantalla\654247.jpg";

                MailMessage este_mail = new MailMessage(reporte_de_origen,$@"{correo_destino}", "Reporte de estudiantes ", "<b>Bienvenido<b>");
                //este_mail.Priority = este_mail.Priority + 1;
                este_mail.Attachments.Add(new Attachment(/*direccion*/adjunto));
                este_mail.IsBodyHtml = true;


                SmtpClient smtp = new SmtpClient("smtp.gmail.com");
                smtp.EnableSsl = true;
                smtp.UseDefaultCredentials = false;
                smtp.Port = 587;
                smtp.Credentials = new System.Net.NetworkCredential(reporte_de_origen, contrasena);
            try
            {
                smtp.Send(este_mail);
                smtp.Dispose();
                mensaje = false;
            }
            catch (Exception )
            {
            
               mensaje = true;
                
            }


                
        }
    }
}
