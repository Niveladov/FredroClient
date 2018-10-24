using DevExpress.XtraEditors;
using FredroClient.BaseGUI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FredroClient.Forms
{
    public sealed partial class frmStart : FredroBaseXtraForm
    {
        public frmStart()
        {
            InitializeComponent();
            InitControls();
        }

        private void InitControls()
        {
            //sleHostname.DataBindings.Add();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnEnter_Click(object sender, EventArgs e)
        {

        }
    }
}
