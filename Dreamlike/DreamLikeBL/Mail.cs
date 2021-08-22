using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

namespace DreamLikeBL
{
    public class Mail
    {
        public bool SendEmail(string subject, string message, string address)
        {
            string email = "t0548561711@gmail.com";
            string password = "tr171111";

            var loginInfo = new NetworkCredential(email, password);
            var msg = new MailMessage();
            var smtpClient = new SmtpClient("smtp.gmail.com", 587);

            msg.From = new MailAddress(email);
            msg.To.Add(new MailAddress(address));
            msg.Subject = subject;
            msg.Body = message;
            msg.IsBodyHtml = true;

            smtpClient.EnableSsl = true;
            smtpClient.UseDefaultCredentials = false;
            smtpClient.Credentials = loginInfo;

            try
            {
                smtpClient.Send(msg);
                return true;
            }
            catch(Exception e)
            {
                throw e;
                //return false;
            }

        }
    }
}
