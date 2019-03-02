using DevExpress.Utils;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Controls;
using FredroClient.BaseGUI;
using FredroClient.ExtraClasses;
using FredroClient.Models;
using FredroDAL.Models;
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
        private readonly Credentials _creds;
        private bool _isEnterPressed;

        public frmStart()
        {
            InitializeComponent();
            _creds = new Credentials();
            InitControls();
            InitEvents();
        }

        private void InitEvents()
        {
            teLogin.KeyDown += CredentialControl_KeyDown;
            tePassword.KeyDown += CredentialControl_KeyDown;
            
            teLogin.KeyPress += CredentialControl_KeyPress;
            tePassword.KeyPress += CredentialControl_KeyPress;

            //teLogin.Validating += TeLogin_Validating;
        }

        private void TeLogin_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(_creds.Login))
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
            teLogin.DataBindings.Add(new Binding("EditValue", _creds, nameof(_creds.Login), 
                true, DataSourceUpdateMode.OnPropertyChanged));
            tePassword.DataBindings.Add(new Binding("EditValue", _creds, nameof(_creds.Password),
                true, DataSourceUpdateMode.OnPropertyChanged));
        }

        private void OpenMail()
        {
            if (string.IsNullOrWhiteSpace(_creds.Login))
            {
                teLogin.ErrorText = "Ошибка. Необходимо ввести логин";
            }
            else if (string.IsNullOrWhiteSpace(_creds.Password))
            {
                tePassword.ErrorText = "Ошибка. Необходимо ввести пароль";
            }
            else
            {
                teLogin.ErrorText = string.Empty;
                tePassword.ErrorText = string.Empty;
                Hide();
                //using (var splashScreenForm = new frmSplashScreen())
                //{
                //    splashScreenForm.Show();
                    //Allow main UI thread to properly display splash screen form.
                    //Application.DoEvents();
                    using (var frm = new frmMails(_creds))
                    {
                        frm.FormClosed += (s, args) => Show();
                        //frm.Shown += (s, args) => splashScreenForm.Close();
                        frm.ShowDialog();
                    }
                //}
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
