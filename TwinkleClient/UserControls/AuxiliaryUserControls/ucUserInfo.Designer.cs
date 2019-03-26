namespace TwinklCRM.Client.UserControls.AuxiliaryUserControls
{
    partial class ucUserInfo
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.peAvatar = new DevExpress.XtraEditors.PictureEdit();
            this.lcUsername = new DevExpress.XtraEditors.LabelControl();
            this.lcLogin = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.peAvatar.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // peAvatar
            // 
            this.peAvatar.EditValue = global::TwinklCRM.Client.Properties.Resources.circle;
            this.peAvatar.Location = new System.Drawing.Point(3, 3);
            this.peAvatar.Name = "peAvatar";
            this.peAvatar.Properties.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.peAvatar.Properties.Appearance.Options.UseBackColor = true;
            this.peAvatar.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.peAvatar.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.Auto;
            this.peAvatar.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Zoom;
            this.peAvatar.Size = new System.Drawing.Size(94, 94);
            this.peAvatar.TabIndex = 0;
            // 
            // lcUsername
            // 
            this.lcUsername.Appearance.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lcUsername.Appearance.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lcUsername.Location = new System.Drawing.Point(119, 22);
            this.lcUsername.Name = "lcUsername";
            this.lcUsername.Size = new System.Drawing.Size(191, 27);
            this.lcUsername.TabIndex = 1;
            this.lcUsername.Text = "Администратор";
            // 
            // lcLogin
            // 
            this.lcLogin.Appearance.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lcLogin.Appearance.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lcLogin.Location = new System.Drawing.Point(119, 55);
            this.lcLogin.Name = "lcLogin";
            this.lcLogin.Size = new System.Drawing.Size(120, 21);
            this.lcLogin.TabIndex = 2;
            this.lcLogin.Text = "test@test.test";
            // 
            // ucUserInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.Controls.Add(this.lcLogin);
            this.Controls.Add(this.lcUsername);
            this.Controls.Add(this.peAvatar);
            this.Name = "ucUserInfo";
            this.Size = new System.Drawing.Size(352, 100);
            ((System.ComponentModel.ISupportInitialize)(this.peAvatar.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.PictureEdit peAvatar;
        private DevExpress.XtraEditors.LabelControl lcUsername;
        private DevExpress.XtraEditors.LabelControl lcLogin;
    }
}
