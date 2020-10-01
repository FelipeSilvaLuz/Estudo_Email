using Estudo_Email.Models;
using System;
using System.Net;
using System.Net.Mail;

namespace Estudo_Email.Services
{
    public class Email
    {
        public void EnviarEmail(LayoutEmail email)
        {
            MailMessage emailMessage = new MailMessage(email.Remetente, email.Destinatario)
            {
                Subject = email?.Titulo,
                IsBodyHtml = true,
                Body = email.Assunto,
            };

            SmtpClient smtpClient = new SmtpClient();
            smtpClient.Host = "smtp.gmail.com";
            smtpClient.Port = 587;
            smtpClient.DeliveryMethod = SmtpDeliveryMethod.Network;
            smtpClient.UseDefaultCredentials = false;
            smtpClient.EnableSsl = true;
            smtpClient.Credentials = new NetworkCredential("felipedasilvata24@gmail.com", "SENHA DO EMAIL...");

            try
            {
                smtpClient.Send(emailMessage);
            }
            catch (Exception ex)
            {
                Console.Error.WriteLine(ex);
            }

            return;
        }
    }
}