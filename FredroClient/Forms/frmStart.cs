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
    internal sealed partial class frmStart : FredroBaseXtraForm
    {
        private readonly CredentialModel _model;
        private bool _isEnterPressed;

        public frmStart()
        {
            InitializeComponent();
            waitingHelper = new WaitingHelper(this);
            _model = new CredentialModel();
            InitControls();
            InitEvents();
        }

        private void InitEvents()
        {
            teLogin.KeyDown += CredentialControl_KeyDown;
            tePassword.KeyDown += CredentialControl_KeyDown;
            icbeHostname.KeyDown += CredentialControl_KeyDown;
            
            teLogin.KeyPress += CredentialControl_KeyPress;
            tePassword.KeyPress += CredentialControl_KeyPress;
            icbeHostname.KeyPress += CredentialControl_KeyPress;
            
            //teLogin.Validating += TeLogin_Validating;
        }

        private void TeLogin_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(_model.Creds.Username))
            {
                e.Cancel = true;
            }
        }

        private void CredentialControl_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (_isEnterPressed)
            {
                OpenMail();
            }
        }

        private void CredentialControl_KeyDown(object sender, KeyEventArgs e)
        {
            _isEnterPressed = false;
            if (e.KeyCode == Keys.Enter)
                _isEnterPressed = true;
        }

        private void InitControls()
        {
            var images = new ImageCollection();
            images.AddImage(Properties.Resources.gmail_32x32);
            images.AddImage(Properties.Resources.mailru_32x32);
            images.AddImage(Properties.Resources.yandex_32x32);

            icbeHostname.Properties.LargeImages = images;
            icbeHostname.Properties.Items.Add(new ImageComboBoxItem(Server.gmail.GetDescription(), (int)Server.gmail, 0));
            icbeHostname.Properties.Items.Add(new ImageComboBoxItem(Server.mail.GetDescription(), (int)Server.mail, 1));
            icbeHostname.Properties.Items.Add(new ImageComboBoxItem(Server.yandex.GetDescription(), (int)Server.yandex, 2));

            teLogin.DataBindings.Add(new Binding("EditValue", _model.Creds, nameof(_model.Creds.Username), 
                true, DataSourceUpdateMode.OnPropertyChanged));
            tePassword.DataBindings.Add(new Binding("EditValue", _model.Creds, nameof(_model.Creds.Password),
                true, DataSourceUpdateMode.OnPropertyChanged));
            icbeHostname.DataBindings.Add(new Binding("EditValue", _model, nameof(_model.CurrentServerId),
                true, DataSourceUpdateMode.OnPropertyChanged));
        }

        private void OpenMail()
        {
            waitingHelper.Show();
            _model.LoadMessages();
            waitingHelper.Hide();
            if (_model.Mails == null) return;
            Hide();
            using (var frm = new frmMails(_model))
            {
                frm.FormClosed += (s, args) =>
                {
                    Show();
                };
                frm.ShowDialog();
            }
        }

        private void btnEnter_Click(object sender, EventArgs e)
        {
            OpenMail();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }


    }
}
