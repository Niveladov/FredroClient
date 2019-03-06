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
        private FormDragger _dragger;

        public frmMain()
        {
            InitializeComponent();
            _dragger = new FormDragger();
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

        private class FormDragger
        {
            public bool IsDrag = false;
            public Point StartPoint = new Point(0, 0);
        }

        private void btnMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
    }
}
