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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject1 = new DevExpress.Utils.SerializableAppearanceObject();
            this.panelLeft = new DevExpress.XtraEditors.PanelControl();
            this.btnAudits = new System.Windows.Forms.Button();
            this.sidePanel = new System.Windows.Forms.Panel();
            this.btnMails = new System.Windows.Forms.Button();
            this.btnScheduler = new System.Windows.Forms.Button();
            this.btnUser = new System.Windows.Forms.Button();
            this.panelTop = new System.Windows.Forms.Panel();
            this.btnMinimize = new System.Windows.Forms.Button();
            this.labelCaption = new DevExpress.XtraEditors.LabelControl();
            this.search = new FredroClient.BaseGUI.CustomEdit();
            ((System.ComponentModel.ISupportInitialize)(this.panelLeft)).BeginInit();
            this.panelLeft.SuspendLayout();
            this.panelTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.search.Properties)).BeginInit();
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
            this.panelLeft.Location = new System.Drawing.Point(0, 49);
            this.panelLeft.Name = "panelLeft";
            this.panelLeft.Size = new System.Drawing.Size(70, 553);
            this.panelLeft.TabIndex = 0;
            // 
            // btnAudits
            // 
            this.btnAudits.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAudits.FlatAppearance.BorderSize = 0;
            this.btnAudits.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAudits.Image = global::FredroClient.Properties.Resources.blue_audit_32x32;
            this.btnAudits.Location = new System.Drawing.Point(6, 398);
            this.btnAudits.Name = "btnAudits";
            this.btnAudits.Size = new System.Drawing.Size(60, 51);
            this.btnAudits.TabIndex = 5;
            this.btnAudits.UseVisualStyleBackColor = true;
            // 
            // sidePanel
            // 
            this.sidePanel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.sidePanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(0)))), ((int)(((byte)(255)))));
            this.sidePanel.Location = new System.Drawing.Point(0, 240);
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
            this.btnMails.Location = new System.Drawing.Point(6, 240);
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
            this.btnScheduler.Location = new System.Drawing.Point(6, 319);
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
            this.btnUser.Location = new System.Drawing.Point(6, 477);
            this.btnUser.Name = "btnUser";
            this.btnUser.Size = new System.Drawing.Size(60, 51);
            this.btnUser.TabIndex = 2;
            this.btnUser.UseVisualStyleBackColor = true;
            // 
            // panelTop
            // 
            this.panelTop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(171)))), ((int)(((byte)(221)))));
            this.panelTop.Controls.Add(this.btnMinimize);
            this.panelTop.Controls.Add(this.labelCaption);
            this.panelTop.Controls.Add(this.search);
            this.panelTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTop.Location = new System.Drawing.Point(0, 0);
            this.panelTop.Name = "panelTop";
            this.panelTop.Size = new System.Drawing.Size(928, 49);
            this.panelTop.TabIndex = 4;
            // 
            // btnMinimize
            // 
            this.btnMinimize.BackColor = System.Drawing.Color.Transparent;
            this.btnMinimize.FlatAppearance.BorderSize = 0;
            this.btnMinimize.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(191)))), ((int)(((byte)(244)))));
            this.btnMinimize.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(171)))), ((int)(((byte)(221)))));
            this.btnMinimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMinimize.Image = ((System.Drawing.Image)(resources.GetObject("btnMinimize.Image")));
            this.btnMinimize.Location = new System.Drawing.Point(3, 3);
            this.btnMinimize.Name = "btnMinimize";
            this.btnMinimize.Size = new System.Drawing.Size(63, 43);
            this.btnMinimize.TabIndex = 5;
            this.btnMinimize.UseVisualStyleBackColor = false;
            this.btnMinimize.Click += new System.EventHandler(this.btnMinimize_Click);
            // 
            // labelCaption
            // 
            this.labelCaption.Appearance.Font = new System.Drawing.Font("Calibri", 13.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelCaption.Appearance.ForeColor = System.Drawing.Color.Snow;
            this.labelCaption.Location = new System.Drawing.Point(80, 11);
            this.labelCaption.Name = "labelCaption";
            this.labelCaption.Size = new System.Drawing.Size(119, 27);
            this.labelCaption.TabIndex = 2;
            this.labelCaption.Text = "Twinkle CRM";
            this.labelCaption.MouseDown += new System.Windows.Forms.MouseEventHandler(this.LabelCaptionMouseDown);
            this.labelCaption.MouseMove += new System.Windows.Forms.MouseEventHandler(this.LabelCaptionMouseMove);
            this.labelCaption.MouseUp += new System.Windows.Forms.MouseEventHandler(this.LabelCaptionMouseUp);
            // 
            // search
            // 
            this.search.Location = new System.Drawing.Point(317, 10);
            this.search.Name = "search";
            this.search.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(77)))), ((int)(((byte)(107)))));
            this.search.Properties.Appearance.Font = new System.Drawing.Font("Calibri", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.search.Properties.Appearance.ForeColor = System.Drawing.SystemColors.Window;
            this.search.Properties.Appearance.Options.UseBackColor = true;
            this.search.Properties.Appearance.Options.UseFont = true;
            this.search.Properties.Appearance.Options.UseForeColor = true;
            this.search.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat;
            serializableAppearanceObject1.BackColor = System.Drawing.Color.Black;
            serializableAppearanceObject1.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            serializableAppearanceObject1.Options.UseBackColor = true;
            serializableAppearanceObject1.Options.UseFont = true;
            this.search.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Search, "", -1, false, true, true, DevExpress.XtraEditors.ImageLocation.MiddleCenter, null, new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject1, "", null, null, true)});
            this.search.Properties.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.UltraFlat;
            this.search.Properties.LookAndFeel.UseDefaultLookAndFeel = false;
            this.search.Properties.NullValuePrompt = "Поиск...";
            this.search.Properties.NullValuePromptShowForEmptyValue = true;
            this.search.Properties.UseDefaultMode = true;
            this.search.Size = new System.Drawing.Size(286, 28);
            this.search.TabIndex = 1;
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
            this.panelTop.ResumeLayout(false);
            this.panelTop.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.search.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.PanelControl panelLeft;
        private System.Windows.Forms.Button btnUser;
        private System.Windows.Forms.Panel sidePanel;
        private System.Windows.Forms.Button btnMails;
        private System.Windows.Forms.Button btnScheduler;
        private System.Windows.Forms.Button btnAudits;
        private System.Windows.Forms.Panel panelTop;
        private BaseGUI.CustomEdit search;
        private DevExpress.XtraEditors.LabelControl labelCaption;
        private System.Windows.Forms.Button btnMinimize;
    }
}