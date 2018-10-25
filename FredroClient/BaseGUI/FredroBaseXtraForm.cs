using DevExpress.XtraEditors;
using FredroClient.ExtraClasses;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FredroClient.BaseGUI
{
    internal partial class FredroBaseXtraForm : XtraForm
    {
        protected WaitingHelper waitingHelper = null;

        public FredroBaseXtraForm()
        {
            InitializeComponent();
        }
    }
}
