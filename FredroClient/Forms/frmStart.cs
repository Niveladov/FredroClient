using DevExpress.Utils;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Controls;
using FredroClient.BaseGUI;
using FredroClient.ExtraClasses;
using FredroClient.Models;
using System;
using System.Collections.Generic;
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
        private readonly CredentialModel _model;

        public frmStart()
        {
            InitializeComponent();
            _model = new CredentialModel();
            InitControls();
        }

        private void InitControls()
        {
            var images = new ImageCollection();
            images.AddImage(Properties.Resources.gmail_32x32);
            images.AddImage(Properties.Resources.mailru_32x32);
            images.AddImage(Properties.Resources.yandex_32x32);

            icbeHostname.Properties.LargeImages = images;
            icbeHostname.Properties.Items.Add(new ImageComboBoxItem(Hostname.gmail.GetDescription(), (int)Hostname.gmail, 0));
            icbeHostname.Properties.Items.Add(new ImageComboBoxItem(Hostname.mail.GetDescription(), (int)Hostname.mail, 1));
            icbeHostname.Properties.Items.Add(new ImageComboBoxItem(Hostname.yandex.GetDescription(), (int)Hostname.yandex, 2));

            teLogin.DataBindings.Add(new Binding("EditValue", _model, nameof(_model.Login), 
                true, DataSourceUpdateMode.OnPropertyChanged));
            tePassword.DataBindings.Add(new Binding("EditValue", _model, nameof(_model.Password),
                true, DataSourceUpdateMode.OnPropertyChanged));
            icbeHostname.DataBindings.Add(new Binding("EditValue", _model, nameof(_model.HostnameId),
                true, DataSourceUpdateMode.OnPropertyChanged));
        }

        private void btnEnter_Click(object sender, EventArgs e)
        {
            var theMessages = _model.GetTheMessageList();
            using (var frm = new frmMessages(theMessages))
            {
                frm.ShowDialog();
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }


    }
}
