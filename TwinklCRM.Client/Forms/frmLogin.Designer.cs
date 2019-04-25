namespace TwinklCRM.Client.Forms
{
    partial class frmLogin
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.peArrows = new DevExpress.XtraEditors.PictureEdit();
            this.peUsername = new DevExpress.XtraEditors.PictureEdit();
            this.tbUsername = new System.Windows.Forms.TextBox();
            this.panelUsername = new System.Windows.Forms.Panel();
            this.panelPassword = new System.Windows.Forms.Panel();
            this.tbPassword = new System.Windows.Forms.TextBox();
            this.pePassword = new DevExpress.XtraEditors.PictureEdit();
            this.btnLogin = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.panelTop = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.peArrows.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.peUsername.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pePassword.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // peArrows
            // 
            this.peArrows.EditValue = global::TwinklCRM.Client.Properties.Resources.arrows_blue_64x64;
            this.peArrows.Location = new System.Drawing.Point(125, 40);
            this.peArrows.Name = "peArrows";
            this.peArrows.Properties.AllowFocused = false;
            this.peArrows.Properties.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.peArrows.Properties.Appearance.Options.UseBackColor = true;
            this.peArrows.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.peArrows.Properties.ReadOnly = true;
            this.peArrows.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.Auto;
            this.peArrows.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Zoom;
            this.peArrows.Size = new System.Drawing.Size(56, 64);
            this.peArrows.TabIndex = 0;
            // 
            // peUsername
            // 
            this.peUsername.EditValue = global::TwinklCRM.Client.Properties.Resources.user_white_32x32;
            this.peUsername.Location = new System.Drawing.Point(44, 135);
            this.peUsername.Name = "peUsername";
            this.peUsername.Properties.AllowFocused = false;
            this.peUsername.Properties.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.peUsername.Properties.Appearance.Options.UseBackColor = true;
            this.peUsername.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.peUsername.Properties.ReadOnly = true;
            this.peUsername.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.Auto;
            this.peUsername.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Zoom;
            this.peUsername.Size = new System.Drawing.Size(28, 32);
            this.peUsername.TabIndex = 1;
            // 
            // tbUsername
            // 
            this.tbUsername.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.tbUsername.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbUsername.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbUsername.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(247)))), ((int)(((byte)(247)))));
            this.tbUsername.Location = new System.Drawing.Point(77, 142);
            this.tbUsername.Name = "tbUsername";
            this.tbUsername.Size = new System.Drawing.Size(186, 25);
            this.tbUsername.TabIndex = 2;
            this.tbUsername.Text = "Логин";
            this.tbUsername.Enter += new System.EventHandler(this.tbUsername_Enter);
            // 
            // panelUsername
            // 
            this.panelUsername.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(247)))), ((int)(((byte)(247)))));
            this.panelUsername.Location = new System.Drawing.Point(44, 173);
            this.panelUsername.Name = "panelUsername";
            this.panelUsername.Size = new System.Drawing.Size(219, 1);
            this.panelUsername.TabIndex = 3;
            // 
            // panelPassword
            // 
            this.panelPassword.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(247)))), ((int)(((byte)(247)))));
            this.panelPassword.Location = new System.Drawing.Point(44, 235);
            this.panelPassword.Name = "panelPassword";
            this.panelPassword.Size = new System.Drawing.Size(219, 1);
            this.panelPassword.TabIndex = 6;
            // 
            // tbPassword
            // 
            this.tbPassword.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.tbPassword.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbPassword.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbPassword.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(247)))), ((int)(((byte)(247)))));
            this.tbPassword.Location = new System.Drawing.Point(77, 204);
            this.tbPassword.Name = "tbPassword";
            this.tbPassword.Size = new System.Drawing.Size(186, 25);
            this.tbPassword.TabIndex = 3;
            this.tbPassword.Text = "Пароль";
            this.tbPassword.Enter += new System.EventHandler(this.tbPassword_Enter);
            // 
            // pePassword
            // 
            this.pePassword.EditValue = global::TwinklCRM.Client.Properties.Resources.password_lock_white_32x32;
            this.pePassword.Location = new System.Drawing.Point(44, 197);
            this.pePassword.Name = "pePassword";
            this.pePassword.Properties.AllowFocused = false;
            this.pePassword.Properties.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.pePassword.Properties.Appearance.Options.UseBackColor = true;
            this.pePassword.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.pePassword.Properties.ReadOnly = true;
            this.pePassword.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.Auto;
            this.pePassword.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Zoom;
            this.pePassword.Size = new System.Drawing.Size(28, 32);
            this.pePassword.TabIndex = 4;
            // 
            // btnLogin
            // 
            this.btnLogin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(186)))), ((int)(((byte)(255)))));
            this.btnLogin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogin.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnLogin.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.btnLogin.Location = new System.Drawing.Point(44, 283);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(219, 40);
            this.btnLogin.TabIndex = 4;
            this.btnLogin.Text = "Войти";
            this.btnLogin.UseVisualStyleBackColor = false;
            this.btnLogin.Click += new System.EventHandler(this.BtnLogin_Click);
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.btnClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnClose.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(186)))), ((int)(((byte)(255)))));
            this.btnClose.Location = new System.Drawing.Point(44, 340);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(219, 40);
            this.btnClose.TabIndex = 1;
            this.btnClose.Text = "Закрыть";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.BtnClose_Click);
            // 
            // timer
            // 
            this.timer.Interval = 30;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // panelTop
            // 
            this.panelTop.Location = new System.Drawing.Point(10, 4);
            this.panelTop.Name = "panelTop";
            this.panelTop.Size = new System.Drawing.Size(285, 30);
            this.panelTop.TabIndex = 7;
            this.panelTop.MouseDown += new System.Windows.Forms.MouseEventHandler(this.PanelTop_MouseDown);
            this.panelTop.MouseMove += new System.Windows.Forms.MouseEventHandler(this.PanelTop_MouseMove);
            this.panelTop.MouseUp += new System.Windows.Forms.MouseEventHandler(this.PanelTop_MouseUp);
            // 
            // frmLogin
            // 
            this.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.Appearance.Options.UseBackColor = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(306, 440);
            this.Controls.Add(this.panelTop);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.panelPassword);
            this.Controls.Add(this.tbPassword);
            this.Controls.Add(this.pePassword);
            this.Controls.Add(this.panelUsername);
            this.Controls.Add(this.tbUsername);
            this.Controls.Add(this.peUsername);
            this.Controls.Add(this.peArrows);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmLogin";
            ((System.ComponentModel.ISupportInitialize)(this.peArrows.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.peUsername.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pePassword.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.PictureEdit peArrows;
        private DevExpress.XtraEditors.PictureEdit peUsername;
        private System.Windows.Forms.TextBox tbUsername;
        private System.Windows.Forms.Panel panelUsername;
        private System.Windows.Forms.Panel panelPassword;
        private System.Windows.Forms.TextBox tbPassword;
        private DevExpress.XtraEditors.PictureEdit pePassword;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.Panel panelTop;
    }
}