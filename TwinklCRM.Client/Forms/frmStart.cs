using DevExpress.LookAndFeel;
using DevExpress.Utils;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Controls;
using TwinklCRM.Client.BaseGUI;
using TwinklCRM.Client.ExtraClasses;
using TwinklCRM.Client.Models;
using TwinklCRM.DAL.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TwinklCRM.Client.Forms
{
    internal sealed partial class frmStart : TwinkleBaseXtraForm
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
            {
                _isEnterPressed = true;
            }
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
                var splashForm = new frmSplashScreen();
                var splashScreenThread = new Thread(new ThreadStart(()
                    => Application.Run(splashForm)));
                splashScreenThread.SetApartmentState(ApartmentState.STA);
                splashScreenThread.Start();

                using (var frm = new frmMain(splashForm, _creds))
                {
                    frm.FormClosed += (s, args) => Show();
                    frm.ShowDialog();
                }
            }
        }

        private void btnEnter_Click(object sender, EventArgs e)
        {
            OpenMail();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            //Close();
            timer.Start();
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            if (this.Opacity > 0.0)
            {
                this.Opacity -= 0.1;
            }
            else
            {
                timer.Stop();
                Application.Exit();
            }
        }
    }
}
