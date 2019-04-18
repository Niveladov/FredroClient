using TwinklCRM.DAL.Models.DatabaseObjectModels.Tables;
using TwinklCRM.MailboxServiceLibrary.Models;
using OpenPop.Mime;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace TwinklCRM.MailboxServiceLibrary.ExtraClasses
{
    internal static class MethodExtensions
    {
        const string PLAIN_TEXT = "text/plain";
        const string HTML_TEXT = "text/html";
        
        internal static TheMail GetTheMail(this Message mail)
        {
            var attachmentParts = mail.FindAllAttachments();
            var plainTextParts = mail.FindAllMessagePartsWithMediaType(PLAIN_TEXT);
            var htmlTextParts = mail.FindAllMessagePartsWithMediaType(HTML_TEXT);
            var theMail = new TheMail();
            theMail.Id = mail.Headers.MessageId;
            theMail.FromFullRaw = mail.Headers.From.Raw;
            theMail.FromAddress = mail.Headers.From.Address;
            theMail.FromDisplayName = mail.Headers.From.DisplayName;
            theMail.ToFullRaw = mail.Headers.To.FirstOrDefault()?.Raw;
            theMail.ToAddress = mail.Headers.To.FirstOrDefault()?.Address;
            theMail.ToDisplayName = mail.Headers.To.FirstOrDefault()?.DisplayName;
            theMail.Date = mail.Headers.DateSent;
            theMail.Subject = mail.Headers.Subject;
            theMail.Body = plainTextParts.FirstOrDefault()?.GetBodyAsText() ??
                                htmlTextParts.FirstOrDefault()?.GetBodyAsText();
            //---↓↓↓---костыль---↓↓↓---
            if (theMail.FromDisplayName.Contains("??") || theMail.Subject.Contains("??"))
            {
                var messageBytes = mail.RawMessage;
                var messageString = Encoding.UTF8.GetString(messageBytes);
                if (theMail.FromDisplayName.Contains("??"))
                {
                    var regexFrom = new Regex("From:\\s(.*)\r\n");
                    var matchFrom = regexFrom.Match(messageString);
                    var fullFromString = matchFrom.Value.Trim().Substring(6).Replace("\"", ""); //6 = "From: ".length
                    theMail.FromFullRaw = fullFromString;
                    theMail.FromDisplayName = fullFromString.Substring(0, fullFromString.IndexOf('<') - 1);
                }
                if (theMail.Subject.Contains("??"))
                {
                    var regexSubj = new Regex("Subject:\\s(.*)\r\n");
                    var matchSubj = regexSubj.Match(messageString);
                    var fullSubjString = matchSubj.Value.Trim().Substring(9); // = "Subject: ".length
                    theMail.Subject = fullSubjString;
                }
            }
            //---↑↑↑---костыль---↑↑↑---
            return theMail;
        }
    }
}
