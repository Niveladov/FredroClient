﻿using TwinklCRM.MailboxServiceLibrary.ExtraClasses;
using System;
using System.IdentityModel.Selectors;
using System.IdentityModel.Tokens;

namespace TwinklCRM.MailboxServiceLibrary.Authentication
{
    internal class TwinkleValidator : UserNamePasswordValidator
    {
        public override void Validate(string userName, string password)
        {
            try
            {
                SessionContext.CreateInstance(userName, password);
            }
            catch (Exception ex)
            {
                throw new SecurityTokenException(ex.Message, ex);
            }
        }
    }
}
