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
    internal sealed partial class frmMain : FredroBaseXtraForm
    {
        public frmMain()
        {
            InitializeComponent();
            InitEvents();
        }

        private void InitEvents()
        {
            btnMails.Click += OnCategoryBtnClick;
            btnScheduler.Click += OnCategoryBtnClick;
            btnAudits.Click += OnCategoryBtnClick;
            btnUser.Click += OnCategoryBtnClick;
        }

        private void OnCategoryBtnClick(object sender, EventArgs e)
        {
            var btn = sender as Button;
            if (btn != null)
            {
                sidePanel.Height = btn.Height;
                sidePanel.Top = btn.Top;
            }
        }
    }
}
