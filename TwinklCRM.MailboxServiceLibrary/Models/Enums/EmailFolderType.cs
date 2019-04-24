using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwinklCRM.MailboxServiceLibrary.Models.Enums
{
    internal enum EmailFolderType
    {
        Inbox = 1,
        Outbox = 2,
        Spam = 3,
        Deleted = 4,
    }
}
