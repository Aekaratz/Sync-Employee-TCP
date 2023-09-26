using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

namespace SyncDataApp
{
    class SentEmail
    {
        public static void SentToEmail()
        {
            string logPath = ConfigurationManager.AppSettings["logPath"];

            string mailaddress = ConfigurationManager.AppSettings["From"];
            string sendto = ConfigurationManager.AppSettings["To"];
            ////////////////////////////////////////////////////////////////

            string SMTPServer = ConfigurationManager.AppSettings["SMTPServer"];
            string password = ConfigurationManager.AppSettings["EPassword"];
            string Email = ConfigurationManager.AppSettings["Email"];
            string port = ConfigurationManager.AppSettings["port"];

            string Subject = ConfigurationManager.AppSettings["Subject"];
            string Body = ConfigurationManager.AppSettings["Body"];


            var Port = Int16.Parse(port);


            // Set up the email message
            MailMessage message = new MailMessage();
            message.From = new MailAddress(mailaddress);
            message.To.Add(sendto);
            message.Subject=Subject;
            message.Body = Body;
            System.Net.Mail.Attachment attachment;
            attachment = new System.Net.Mail.Attachment(logPath);
            message.Attachments.Add(attachment);

            // Set up the SMTP client
            SmtpClient smtpClient = new SmtpClient(SMTPServer);
            smtpClient.Port = Port;
            smtpClient.Credentials = new NetworkCredential(Email,password);
            smtpClient.EnableSsl = true;

            try
            {
                // Send the email
                smtpClient.Send(message);
                Console.WriteLine("Email sent successfully.");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Failed to send email: " + ex.Message);
            }

        }
    }
}
