using FredroMailService.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace FredroMailService.ExtraClasses
{
    internal static class MethodExtensions
    {
        const string PLAIN_TEXT = "text/plain";
        const string HTML_TEXT = "text/html";

        public static string GetDescription(this Enum enumValue)
        {
            //Tries to find a DescriptionAttribute for a potential friendly name
            //for the enum
            MemberInfo[] memberInfo = enumValue.GetType().GetMember(enumValue.ToString());
            if (memberInfo != null && memberInfo.Length > 0)
            {
                object[] attrs = memberInfo[0].GetCustomAttributes(typeof(DescriptionAttribute), false);

                if (attrs != null && attrs.Length > 0)
                {
                    //Pull out the description value
                    return ((DescriptionAttribute)attrs[0]).Description;
                }
            }
            //If we have no description attribute, just return the ToString of the enum
            return enumValue.ToString();
        }

        public static List<IProtocol> GetServerSettings(this Enum enumValue)
        {
            List<IProtocol> protocols = new List<IProtocol>();
            MemberInfo[] memberInfo = enumValue.GetType().GetMember(enumValue.ToString());
            if (memberInfo != null && memberInfo.Length > 0)
            {
                object[] protocolAttrs = memberInfo[0].GetCustomAttributes(typeof(ProtocolAttribute), true);
                if (protocolAttrs != null && protocolAttrs.Length > 0)
                {
                    var popAttr = protocolAttrs.OfType<PopAttribute>().SingleOrDefault();
                    if (popAttr != null)
                    {
                        var popProtocol = new PopProtocol(popAttr.Hostname, popAttr.Port, popAttr.UseSsl);
                        protocols.Add(popProtocol);
                    }

                    var smtpAttr = protocolAttrs.OfType<SmtpAttribute>().SingleOrDefault();
                    if (popAttr != null)
                    {
                        var smtpProtocol = new SmtpProtocol(smtpAttr.Hostname, smtpAttr.Port, smtpAttr.UseSsl);
                        protocols.Add(smtpProtocol);
                    }

                    var imapAttr = protocolAttrs.OfType<ImapAttribute>().SingleOrDefault();
                    if (imapAttr != null)
                    {
                        var imapProtocol = new ImapProtocol(imapAttr.Hostname, imapAttr.Port, imapAttr.UseSsl);
                        protocols.Add(imapProtocol);
                    }
                }
            }
            return protocols;
        }
    }
}
