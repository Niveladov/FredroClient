using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using TwinklCRM.Client.BaseGUI;
using TwinklCRM.Client.Models;
using TwinklCRM.DAL.Models;

namespace TwinklCRM.Client.Forms
{
    internal partial class frmLogin : TwinkleBaseXtraForm
    {
        private readonly FormDragger _dragger;
        private readonly Credentials _creds;
        private bool _isEnterPressed;
        public frmLogin()
        {
            InitializeComponent();
            _dragger = new FormDragger();
            _creds = new Credentials();
            InitControls();
            InitEvents();
        }

        private void InitEvents()
        {
            teUsername.KeyDown += CredentialControl_KeyDown;
            tePassword.KeyDown += CredentialControl_KeyDown;

            teUsername.KeyPress += CredentialControl_KeyPress;
            tePassword.KeyPress += CredentialControl_KeyPress;
        }

        private void InitControls()
        {
            teUsername.DataBindings.Add(new Binding("EditValue", _creds, nameof(_creds.Login),
                true, DataSourceUpdateMode.OnPropertyChanged));
            tePassword.DataBindings.Add(new Binding("EditValue", _creds, nameof(_creds.Password),
                true, DataSourceUpdateMode.OnPropertyChanged));
        }

        private void OpenMail()
        {
            if (string.IsNullOrWhiteSpace(_creds.Login))
            {
                teUsername.ErrorText = "Ошибка. Необходимо ввести логин";
            }
            else if (string.IsNullOrWhiteSpace(_creds.Password))
            {
                tePassword.ErrorText = "Ошибка. Необходимо ввести пароль";
            }
            else
            {
                teUsername.ErrorText = string.Empty;
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

        private void TeUsername_Enter(object sender, EventArgs e)
        {
            peUsername.Image = Properties.Resources.user_blue_32x32;
            panelUsername.BackColor = Color.FromArgb(3, 186, 255); //blue
            teUsername.ForeColor = Color.FromArgb(3, 186, 255); //blue

            pePassword.Image = string.IsNullOrWhiteSpace(tePassword.EditValue.ToString()) ? 
                Properties.Resources.password_lock_white_32x32 :
                Properties.Resources.password_unlock_white_32x32;
            panelPassword.BackColor = Color.FromArgb(247, 247, 247); //white
            tePassword.ForeColor = Color.FromArgb(247, 247, 247); //white
        }

        private void TePassword_Enter(object sender, EventArgs e)
        {
            pePassword.Image = string.IsNullOrWhiteSpace(tePassword.EditValue.ToString()) ? 
                Properties.Resources.password_lock_blue_32x32 :
                Properties.Resources.password_unlock_blue_32x32;
            panelPassword.BackColor = Color.FromArgb(3, 186, 255); //blue
            tePassword.ForeColor = Color.FromArgb(3, 186, 255); //blue

            peUsername.Image = Properties.Resources.user_white_32x32;
            panelUsername.BackColor = Color.FromArgb(247, 247, 247); //white
            teUsername.ForeColor = Color.FromArgb(247, 247, 247); //white
        }

        private void TePassword_TextChanged(object sender, EventArgs e)
        {
            pePassword.Image = string.IsNullOrWhiteSpace(tePassword.EditValue.ToString()) ?
                ( tePassword.IsEditorActive ? Properties.Resources.password_lock_blue_32x32 : Properties.Resources.password_lock_white_32x32) :
                ( tePassword.IsEditorActive ? Properties.Resources.password_unlock_blue_32x32 : Properties.Resources.password_unlock_white_32x32);
        }

        private void DraggedControl_MouseDown(object sender, MouseEventArgs e)
        {
            _dragger.IsDrag = true;
            _dragger.StartPoint = new Point(e.X, e.Y);
        }

        private void DraggedControl_MouseMove(object sender, MouseEventArgs e)
        {
            if (_dragger.IsDrag)
            {
                var p = PointToScreen(e.Location);
                this.Location = new Point(p.X - _dragger.StartPoint.X, p.Y - _dragger.StartPoint.Y);
            }
        }

        private void DraggedControl_MouseUp(object sender, MouseEventArgs e)
        {
            _dragger.IsDrag = false;
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

        private void BtnClose_Click(object sender, EventArgs e)
        {
            timer.Start();
        }

        private void BtnLogin_Click(object sender, EventArgs e)
        {
            OpenMail();
        }
    }
}
