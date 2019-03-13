using FredroClient.BaseGUI;
using FredroClient.ExtraClasses;
using FredroDAL.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FredroClient.Forms
{
    internal sealed partial class frmMain : FredroBaseXtraForm
    {
        private readonly FormDragger _dragger;
        private readonly SlidePanelAgent _sliderAgent;

        public frmMain(FredroBaseXtraForm splashScreenForm, Credentials creds)
        {
            try
            {
                //throw new Exception("Huesos, axaxa!");
                InitializeComponent();
                _dragger = new FormDragger();
                _sliderAgent = new SlidePanelAgent(ucUserInfo.Width);
                ucMails.Init(creds);
                InitEvents();
                InitStatusStrip();
            }
            catch (ServerException ex)
            {
                FredroMessageBox.ShowError(ex.Message);
            }
            finally
            {
                splashScreenForm?.Invoke(new Action(() => splashScreenForm.Close()));
                splashScreenForm?.Dispose();
            }
        }

        private void InitStatusStrip()
        {
            statusStrip.Items[0].Text = "Демо версия клиента Twinkle.";
            statusStrip.Items[1].Text = ""; // "Евгений Федорук, +7(952)383-23-01";
        }

        private void InitEvents()
        {
            btnMails.Click += OnCategoryBtnClick;
            btnScheduler.Click += OnCategoryBtnClick;
            btnAudits.Click += OnCategoryBtnClick;
            btnUser.Click += OnCategoryBtnClick;

            FormClosing += FrmMails_FormClosing;
        }

        #region Event Handlers
        private void OnCategoryBtnClick(object sender, EventArgs e)
        {
            var btn = sender as Button;
            if (btn != null)
            {
                focusedPanel.Height = btn.Height;
                focusedPanel.Top = btn.Top;
                switch(btn.Name)
                {
                    case nameof(btnMails):
                        tcgModes.SelectedTabPage = lcgMails;
                        break;
                    case nameof(btnScheduler):
                        tcgModes.SelectedTabPage = lcgScheduler;
                        break;
                    case nameof(btnAudits):
                        tcgModes.SelectedTabPage = lcgAudits;
                        break;
                    case nameof(btnUser):
                        tcgModes.SelectedTabPage = lcgUser;
                        break;
                }
            }
        }

        private void LabelCaptionMouseDown(object sender, MouseEventArgs e)
        {
            _dragger.IsDrag = true;
            _dragger.StartPoint = new Point(e.X, e.Y);
        }

        private void LabelCaptionMouseMove(object sender, MouseEventArgs e)
        {
            if (_dragger.IsDrag)
            {
                var p = PointToScreen(e.Location);
                this.Location = new Point(p.X - _dragger.StartPoint.X, p.Y - _dragger.StartPoint.Y);
                this.WindowState = FormWindowState.Normal;
            }
        }

        private void LabelCaptionMouseUp(object sender, MouseEventArgs e)
        {
            _dragger.IsDrag = false;
            if (this.Location.Y < 5)
            {
                //StartPosition = FormStartPosition.Manual;
                //var allScreens = Screen.AllScreens;
                //var xLocation = this.Location.X;
                //var currentScreen = allScreens.Single(x => (x.Bounds.X < xLocation && (x.Bounds.X + x.Bounds.Width) > xLocation));
                //setFormLocation(this, currentScreen);
                //this.MaximizedBounds = currentScreen.Bounds;
                //this.Location = currentScreen.Bounds.Location;
                //this.SetDisplayRectLocation(currentScreen.Bounds.Location.X, currentScreen.Bounds.Location.Y);
                //this.SetBounds(currentScreen.Bounds.X, currentScreen.Bounds.Y, currentScreen.Bounds.Width, currentScreen.Bounds.Height);
                //this.SetBounds()
                ////this.TopMost = true;
                //this.FormBorderStyle = FormBorderStyle.FixedDialog;
                this.WindowState = FormWindowState.Maximized;
                //this.FormBorderStyle = FormBorderStyle.None;
                //this.SetBounds(currentScreen.Bounds.X, currentScreen.Bounds.Y, currentScreen.Bounds.Width, currentScreen.Bounds.Height);
                //this.SetDesktopBounds(currentScreen.Bounds.X, currentScreen.Bounds.Y, currentScreen.Bounds.Width, currentScreen.Bounds.Height);
                //this.WindowState = FormWindowState.Normal;
                //this.WindowState = FormWindowState.Maximized;
            }
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            if (_sliderAgent.IsHidden)
            {
                panelSlide.Width = panelSlide.Width + 100;
                if (panelSlide.Width >= _sliderAgent.PanelMaxWidth)
                {
                    timer.Stop();
                    _sliderAgent.IsHidden = false;
                    Refresh();
                }
            }
            else
            {
                panelSlide.Width = panelSlide.Width - 100;
                if (panelSlide.Width <= 0)
                {
                    timer.Stop();
                    _sliderAgent.IsHidden = true;
                    Refresh();
                }
            }
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            timer.Start();
        }

        private void peAvatar_MouseClick(object sender, MouseEventArgs e)
        {
            timer.Start();
        }

        private void peAvatar_MouseDown(object sender, MouseEventArgs e)
        {
            peAvatar.BackColor = ColorTranslator.FromHtml("#4260b2"); //66, 96, 178
        }

        private void peAvatar_MouseUp(object sender, MouseEventArgs e)
        {
            peAvatar.BackColor = ColorTranslator.FromHtml("#46abdd"); //70, 171, 221
        }

        private void btnMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void FrmMails_FormClosing(object sender, FormClosingEventArgs e)
        {
            var result = FredroMessageBox.ShowQuestionYesNo("Вы хотите выйти?");
            e.Cancel = (result == DialogResult.No);
        }
        #endregion

        #region Helper classes
        private class FormDragger
        {
            public bool IsDrag = false;
            public Point StartPoint = new Point(0, 0);
        }

        private class SlidePanelAgent
        {
            public int PanelMaxWidth { get; }
            public bool IsHidden { get; set; }

            public SlidePanelAgent(int panelMaxWidth)
            {
                PanelMaxWidth = panelMaxWidth;
                IsHidden = true;
            }

        }
        #endregion
    }
}
