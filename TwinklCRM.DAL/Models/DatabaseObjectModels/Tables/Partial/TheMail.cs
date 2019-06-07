using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwinklCRM.DAL.Models.DatabaseObjectModels.Tables
{
    public partial class TheMail
    {
        [NotMapped]
        public Bitmap PictureMail
        {
            get
            {
                return this.IsRead ? Properties.Resources.read_mail_32x38 : Properties.Resources.unread_mail_blue_32x32;
            }
        }
    }
}
