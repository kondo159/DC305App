using System;
using System.Configuration;
using System.Net;
using System.Net.Mail;

namespace DC305RoomManagementClassLibrary
{
    public static class SMTPHelper
    {
        // Getting Email Credential from App.config file
        public static NetworkCredential EmailCredential
        {
            get
            {
                return new NetworkCredential()
                {
                    UserName = ConfigurationManager.AppSettings.Get("EmailUser"),
                    Password = ConfigurationManager.AppSettings.Get("EmailPassword")
                };
            }
        }

        // Getting SMTPServer name from App.config file
        public static string SMTPServerName
        {
            get
            {
                return ConfigurationManager.AppSettings.Get("SMTPServer");
            }
        }

        // Setting SMTPServer Port
        public static int SMTPServerPort
        {
            get
            {
                return 587;
            }
        }

        // Send Email Notification (Recipient of Email, Content of Email, Subject of Email)
        public static void SendEmail(string Recipient, string EmailBody, string EmailSubject)
        {
            // Create Mail
            try
            {
                MailMessage mailMsg = new MailMessage(EmailCredential.UserName, Recipient);

                mailMsg.Subject = EmailSubject;
                mailMsg.Body = EmailBody;

                SmtpClient smtpClient = new SmtpClient(SMTPServerName, SMTPServerPort);
                smtpClient.Credentials = EmailCredential;
                smtpClient.EnableSsl = true;
                smtpClient.DeliveryMethod = SmtpDeliveryMethod.Network;
                smtpClient.Send(mailMsg);
            }
            catch (Exception err)
            {
                throw;
            }
            
        }
    }
}