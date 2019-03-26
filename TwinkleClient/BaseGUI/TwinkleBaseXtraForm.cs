using DevExpress.XtraEditors;
using TwinklCRM.Client.ExtraClasses;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TwinklCRM.Client.BaseGUI
{
    internal partial class TwinkleBaseXtraForm : XtraForm
    {
        protected WaitingHelper waitingHelper = null;

        public TwinkleBaseXtraForm()
        {
            InitializeComponent();
        }
    }
}
