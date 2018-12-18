using FredroClient.BaseGUI;
using FredroClient.Models;
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
    internal sealed partial class frmMails : FredroBaseXtraForm
    {
        public frmMails(CredentialModel model)
        {
            InitializeComponent();
            ucMails.Init(model);
        }
    }
}
