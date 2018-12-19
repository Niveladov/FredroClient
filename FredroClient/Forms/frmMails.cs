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
            ucMail.InitModel(model);
            InitEvents();
        }

        private void InitEvents()
        {
            tcgModes.SelectedPageChanged += TcgModes_SelectedPageChanged;
            FormClosed += FrmMails_FormClosed;
        }

        private void TcgModes_SelectedPageChanged(object sender, DevExpress.XtraLayout.LayoutTabPageChangedEventArgs e)
        {
            if (e.Page == lcgScheduler)
            {
                Text = "Календарь заявок(сделок) - Почтовый бизнес-клиент";
            }
            else if (e.Page == lcgMails)
            {
                Text = ucMail.ParentFormText;
            }
        }

        private void FrmMails_FormClosed(object sender, FormClosedEventArgs e)
        {
            //ParentForm.Show();
        }

    }
}
