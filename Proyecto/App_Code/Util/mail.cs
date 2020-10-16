using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Web;

/// <summary>
/// Descripción breve de Correo
/// </summary>
public class mail
{
    public mail()
    {
        //
        // TODO: Agregar aquí la lógica del constructor
        //
    }

    public void enviarCorreo(String correoDestino, String user_name)
    {

        try
        {

            var Emailtemplate = new System.IO.StreamReader(AppDomain.CurrentDomain.BaseDirectory.Insert(AppDomain.CurrentDomain.BaseDirectory.Length, "Template\\mailer.html"));
            var strBody = string.Format(Emailtemplate.ReadToEnd(), user_name);
            Emailtemplate.Close(); Emailtemplate.Dispose(); Emailtemplate = null;


            strBody = strBody.Replace("#TOKEN#", user_name);
            MailMessage mail = new MailMessage();
            SmtpClient SmtpServer = new SmtpClient("smtp.gmail.com");
            mail.From = new MailAddress("soporte@gmail.com", "Soporte");
            SmtpServer.Host = "smtp.gmail.com";
            mail.Subject = "Soporte Votacion";
            mail.Body = strBody;
            mail.To.Add(correoDestino);
            mail.IsBodyHtml = true;
            mail.Priority = MailPriority.Normal;
            SmtpServer.Port = 587; 
            SmtpServer.Credentials = new System.Net.NetworkCredential("is20pasaportes@gmail.com", "tueomzhsfsvorbfq");
            SmtpServer.EnableSsl = true;
            SmtpServer.Send(mail);
        }
        catch (Exception ex)
        {

        }
    }
}