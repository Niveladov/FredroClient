using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwinklCRM.DAL.Models
{
    public sealed class Credentials
    {
        public const string DefaultLogin = "Логин";
        public const string DefaultPassword = "Пароль";

        public string Login { get; set; } = DefaultLogin;
        public string Password { get; set; } = DefaultPassword;
    }

}
