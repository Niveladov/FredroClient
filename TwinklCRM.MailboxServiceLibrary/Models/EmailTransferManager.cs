using TwinklCRM.DAL.Models.DatabaseObjectModels.Tables;
using TwinklCRM.MailboxServiceLibrary.ExtraClasses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

namespace TwinklCRM.MailboxServiceLibrary.Models.Enums
{
    internal interface IMailTransferManager
    {
       /// <summary>
       /// Send mail
       /// </summary>
        void SendMail(TheMail mail);
    }

    internal sealed class EmailTransferManager : IMailTransferManager
    {
        public void SendMail(TheMail mail)
        {
            try
            {
                var currentMailBox = SessionContext.Instance.CurrentUser.ChachedEmailBoxes.Single(x => x.Id == mail.ChachedEmailBoxId);
                var currentOutgoingParam = currentMailBox.OutgoingEmailServerParam;
                MailAddress from = new MailAddress(mail.FromAddress, mail.FromDisplayName);
                MailAddress to = new MailAddress(mail.ToAddress);
                MailMessage m = new MailMessage(from, to);

                //m.Attachments.Add(new Attachment("E://colors.txt"));
                m.Subject = mail.Subject;
                m.Body = mail.Body;
                m.IsBodyHtml = true;

                SmtpClient smtpClient = new SmtpClient(currentOutgoingParam.Hostname, currentOutgoingParam.Port);
                smtpClient.Credentials = new NetworkCredential(currentMailBox.Login, currentMailBox.Password);
                smtpClient.EnableSsl = currentOutgoingParam.UseSsl;
                smtpClient.Send(m);
            }
            catch
            {
                throw;
            }
        }
    }
}
