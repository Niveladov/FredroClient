using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TwinklCRM.Client.BaseGUI
{
    public partial class ucBase : UserControl
    {
        protected bool isDesignMode = (LicenseManager.UsageMode == LicenseUsageMode.Designtime);

        public ucBase()
        {
            InitializeComponent();
        }
    }
}
