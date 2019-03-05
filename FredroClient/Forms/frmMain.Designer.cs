namespace FredroClient.Forms
{
    partial class frmMain
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
            this.panelLeft = new DevExpress.XtraEditors.PanelControl();
            this.btnAudits = new System.Windows.Forms.Button();
            this.sidePanel = new System.Windows.Forms.Panel();
            this.btnMails = new System.Windows.Forms.Button();
            this.btnScheduler = new System.Windows.Forms.Button();
            this.btnUser = new System.Windows.Forms.Button();
            this.panelTop = new DevExpress.XtraEditors.PanelControl();
            ((System.ComponentModel.ISupportInitialize)(this.panelLeft)).BeginInit();
            this.panelLeft.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelTop)).BeginInit();
            this.SuspendLayout();
            // 
            // panelLeft
            // 
            this.panelLeft.Controls.Add(this.btnAudits);
            this.panelLeft.Controls.Add(this.sidePanel);
            this.panelLeft.Controls.Add(this.btnMails);
            this.panelLeft.Controls.Add(this.btnScheduler);
            this.panelLeft.Controls.Add(this.btnUser);
            this.panelLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelLeft.Location = new System.Drawing.Point(0, 50);
            this.panelLeft.Name = "panelLeft";
            this.panelLeft.Size = new System.Drawing.Size(70, 552);
            this.panelLeft.TabIndex = 0;
            // 
            // btnAudits
            // 
            this.btnAudits.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAudits.FlatAppearance.BorderSize = 0;
            this.btnAudits.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAudits.Image = global::FredroClient.Properties.Resources.blue_audit_32x32;
            this.btnAudits.Location = new System.Drawing.Point(6, 397);
            this.btnAudits.Name = "btnAudits";
            this.btnAudits.Size = new System.Drawing.Size(60, 51);
            this.btnAudits.TabIndex = 5;
            this.btnAudits.UseVisualStyleBackColor = true;
            // 
            // sidePanel
            // 
            this.sidePanel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.sidePanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(0)))), ((int)(((byte)(255)))));
            this.sidePanel.Location = new System.Drawing.Point(0, 239);
            this.sidePanel.Name = "sidePanel";
            this.sidePanel.Size = new System.Drawing.Size(6, 51);
            this.sidePanel.TabIndex = 3;
            // 
            // btnMails
            // 
            this.btnMails.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMails.FlatAppearance.BorderSize = 0;
            this.btnMails.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMails.Image = global::FredroClient.Properties.Resources.blue_email_32x32;
            this.btnMails.Location = new System.Drawing.Point(6, 239);
            this.btnMails.Name = "btnMails";
            this.btnMails.Size = new System.Drawing.Size(60, 51);
            this.btnMails.TabIndex = 4;
            this.btnMails.UseVisualStyleBackColor = true;
            // 
            // btnScheduler
            // 
            this.btnScheduler.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnScheduler.FlatAppearance.BorderSize = 0;
            this.btnScheduler.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnScheduler.Image = global::FredroClient.Properties.Resources.blue_calendar_32x32;
            this.btnScheduler.Location = new System.Drawing.Point(6, 318);
            this.btnScheduler.Name = "btnScheduler";
            this.btnScheduler.Size = new System.Drawing.Size(60, 51);
            this.btnScheduler.TabIndex = 4;
            this.btnScheduler.UseVisualStyleBackColor = true;
            // 
            // btnUser
            // 
            this.btnUser.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnUser.FlatAppearance.BorderSize = 0;
            this.btnUser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUser.Image = global::FredroClient.Properties.Resources.blue_user_32x32;
            this.btnUser.Location = new System.Drawing.Point(6, 476);
            this.btnUser.Name = "btnUser";
            this.btnUser.Size = new System.Drawing.Size(60, 51);
            this.btnUser.TabIndex = 2;
            this.btnUser.UseVisualStyleBackColor = true;
            // 
            // panelTop
            // 
            this.panelTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTop.Location = new System.Drawing.Point(0, 0);
            this.panelTop.Name = "panelTop";
            this.panelTop.Size = new System.Drawing.Size(928, 50);
            this.panelTop.TabIndex = 1;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(928, 602);
            this.Controls.Add(this.panelLeft);
            this.Controls.Add(this.panelTop);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmMain";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.panelLeft)).EndInit();
            this.panelLeft.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.panelTop)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.PanelControl panelLeft;
        private DevExpress.XtraEditors.PanelControl panelTop;
        private System.Windows.Forms.Button btnUser;
        private System.Windows.Forms.Panel sidePanel;
        private System.Windows.Forms.Button btnMails;
        private System.Windows.Forms.Button btnScheduler;
        private System.Windows.Forms.Button btnAudits;
    }
}