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

            var EmailTemplate = new System.IO.StreamReader(AppDomain.CurrentDomain.BaseDirectory.Insert(AppDomain.CurrentDomain.BaseDirectory.Length, "\\Template\\mailer.html"));
            var strBody = string.Format(EmailTemplate.ReadToEnd(), user_name);
            EmailTemplate.Close(); EmailTemplate.Dispose(); EmailTemplate = null;


            strBody = strBody.Replace("#TOKEN#", user_name);
            MailMessage mailM = new MailMessage();
            SmtpClient SmtpServer = new SmtpClient("smtp.gmail.com");
            mailM.From = new MailAddress("soporte@gmail.com", "Soporte");
            SmtpServer.Host = "smtp.gmail.com";
            mailM.Subject = "Soporte Votacion";
            mailM.Body = strBody;
            mailM.To.Add(correoDestino);
            mailM.IsBodyHtml = true;
            mailM.Priority = MailPriority.Normal;
            SmtpServer.Port = 587;
            SmtpServer.Credentials = new System.Net.NetworkCredential("votacion.proyecto2020@gmail.com", "negrorico2020");
            SmtpServer.EnableSsl = true;
            SmtpServer.Send(mailM);
        }
        catch (Exception)
        {
            throw;
        }
    }

    public void enviarCorreoAdmin(String correoDestino, String pass)
    {

        try
        {

            var EmailTemplate = new System.IO.StreamReader(AppDomain.CurrentDomain.BaseDirectory.Insert(AppDomain.CurrentDomain.BaseDirectory.Length, "\\Template\\mailer2.html"));
            var strBody = string.Format(EmailTemplate.ReadToEnd(), pass);
            EmailTemplate.Close(); EmailTemplate.Dispose(); EmailTemplate = null;


            strBody = strBody.Replace("#TOKEN#", pass);
            MailMessage mailM = new MailMessage();
            SmtpClient SmtpServer = new SmtpClient("smtp.gmail.com");
            mailM.From = new MailAddress("soporte@gmail.com", "Soporte");
            SmtpServer.Host = "smtp.gmail.com";
            mailM.Subject = "Soporte Votacion";
            mailM.Body = strBody;
            mailM.To.Add(correoDestino);
            mailM.IsBodyHtml = true;
            mailM.Priority = MailPriority.Normal;
            SmtpServer.Port = 587;
            SmtpServer.Credentials = new System.Net.NetworkCredential("votacion.proyecto2020@gmail.com", "negrorico2020");
            SmtpServer.EnableSsl = true;
            SmtpServer.Send(mailM);
        }
        catch (Exception)
        {
            throw;
        }
    }

    public void enviarCorreoVotado(String correoDestino, String user)
    {

        try
        {

            var EmailTemplate = new System.IO.StreamReader(AppDomain.CurrentDomain.BaseDirectory.Insert(AppDomain.CurrentDomain.BaseDirectory.Length, "\\Template\\mailer3.html"));
            var strBody = string.Format(EmailTemplate.ReadToEnd(), user);
            EmailTemplate.Close(); EmailTemplate.Dispose(); EmailTemplate = null;


            strBody = strBody.Replace("#TOKEN#", user);
            MailMessage mailM = new MailMessage();
            SmtpClient SmtpServer = new SmtpClient("smtp.gmail.com");
            mailM.From = new MailAddress("soporte@gmail.com", "Soporte");
            SmtpServer.Host = "smtp.gmail.com";
            mailM.Subject = "Soporte Votacion";
            mailM.Body = strBody;
            mailM.To.Add(correoDestino);
            mailM.IsBodyHtml = true;
            mailM.Priority = MailPriority.Normal;
            SmtpServer.Port = 587;
            SmtpServer.Credentials = new System.Net.NetworkCredential("votacion.proyecto2020@gmail.com", "negrorico2020");
            SmtpServer.EnableSsl = true;
            SmtpServer.Send(mailM);
        }
        catch (Exception)
        {
            throw;
        }
    }
}