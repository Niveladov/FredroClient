using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwinklCRM.DAL.Models.DatabaseObjectModels.Views
{
    public partial class ViewVehicle
    {
        [NotMapped]
        public Color SystemColor
        {
            get
            {
                return ColorTranslator.FromHtml(Color);
            }
        }
    }
}
