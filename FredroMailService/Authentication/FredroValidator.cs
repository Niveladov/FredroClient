using FredroMailService.ExtraClasses;
using System;
using System.Collections.Generic;
using System.IdentityModel.Selectors;
using System.IdentityModel.Tokens;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace FredroMailService.Authentication
{
    internal class FredroValidator : UserNamePasswordValidator
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
