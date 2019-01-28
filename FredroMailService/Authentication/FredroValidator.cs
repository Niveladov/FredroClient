using System;
using System.Collections.Generic;
using System.IdentityModel.Selectors;
using System.IdentityModel.Tokens;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FredroMailService.Authentication
{
    internal class FredroValidator : UserNamePasswordValidator
    {
        public override void Validate(string userName, string password)
        {
            if (!string.IsNullOrWhiteSpace(userName) || !string.IsNullOrWhiteSpace(password)) return;
            else throw new SecurityTokenException("Account is invalid");
        }
    }
}
