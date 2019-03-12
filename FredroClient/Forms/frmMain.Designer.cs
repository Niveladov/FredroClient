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
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject2 = new DevExpress.Utils.SerializableAppearanceObject();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.panelLeft = new DevExpress.XtraEditors.PanelControl();
            this.sidePanel = new System.Windows.Forms.Panel();
            this.panelTop = new System.Windows.Forms.Panel();
            this.labelCaption = new DevExpress.XtraEditors.LabelControl();
            this.search = new FredroClient.BaseGUI.CustomEdit();
            this.lcMain = new DevExpress.XtraLayout.LayoutControl();
            this.ucScheduler = new FredroClient.UserControls.ucScheduler();
            this.ucMails = new FredroClient.UserControls.ucMails();
            this.lcgMain = new DevExpress.XtraLayout.LayoutControlGroup();
            this.tcgModes = new DevExpress.XtraLayout.TabbedControlGroup();
            this.lcgMails = new DevExpress.XtraLayout.LayoutControlGroup();
            this.lciMails = new DevExpress.XtraLayout.LayoutControlItem();
            this.lcgScheduler = new DevExpress.XtraLayout.LayoutControlGroup();
            this.lciScheduler = new DevExpress.XtraLayout.LayoutControlItem();
            this.lcgAudits = new DevExpress.XtraLayout.LayoutControlGroup();
            this.lcgUser = new DevExpress.XtraLayout.LayoutControlGroup();
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel2 = new System.Windows.Forms.ToolStripStatusLabel();
            this.btnAudits = new System.Windows.Forms.Button();
            this.btnMails = new System.Windows.Forms.Button();
            this.btnScheduler = new System.Windows.Forms.Button();
            this.btnUser = new System.Windows.Forms.Button();
            this.btnHome = new System.Windows.Forms.Button();
            this.btnMinimize = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.panelLeft)).BeginInit();
            this.panelLeft.SuspendLayout();
            this.panelTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.search.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lcMain)).BeginInit();
            this.lcMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lcgMain)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tcgModes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lcgMails)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciMails)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lcgScheduler)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciScheduler)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lcgAudits)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lcgUser)).BeginInit();
            this.statusStrip.SuspendLayout();
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
            this.panelLeft.Location = new System.Drawing.Point(0, 40);
            this.panelLeft.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panelLeft.Name = "panelLeft";
            this.panelLeft.Size = new System.Drawing.Size(60, 427);
            this.panelLeft.TabIndex = 0;
            // 
            // sidePanel
            // 
            this.sidePanel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.sidePanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(0)))), ((int)(((byte)(255)))));
            this.sidePanel.Location = new System.Drawing.Point(0, 173);
            this.sidePanel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.sidePanel.Name = "sidePanel";
            this.sidePanel.Size = new System.Drawing.Size(5, 41);
            this.sidePanel.TabIndex = 3;
            // 
            // panelTop
            // 
            this.panelTop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(171)))), ((int)(((byte)(221)))));
            this.panelTop.Controls.Add(this.btnHome);
            this.panelTop.Controls.Add(this.btnMinimize);
            this.panelTop.Controls.Add(this.labelCaption);
            this.panelTop.Controls.Add(this.search);
            this.panelTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTop.Location = new System.Drawing.Point(0, 0);
            this.panelTop.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panelTop.Name = "panelTop";
            this.panelTop.Size = new System.Drawing.Size(795, 40);
            this.panelTop.TabIndex = 4;
            // 
            // labelCaption
            // 
            this.labelCaption.Appearance.Font = new System.Drawing.Font("Calibri", 13.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelCaption.Appearance.ForeColor = System.Drawing.Color.Snow;
            this.labelCaption.Location = new System.Drawing.Point(69, 9);
            this.labelCaption.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.labelCaption.Name = "labelCaption";
            this.labelCaption.Size = new System.Drawing.Size(98, 22);
            this.labelCaption.TabIndex = 2;
            this.labelCaption.Text = "Twinkle CRM";
            this.labelCaption.MouseDown += new System.Windows.Forms.MouseEventHandler(this.LabelCaptionMouseDown);
            this.labelCaption.MouseMove += new System.Windows.Forms.MouseEventHandler(this.LabelCaptionMouseMove);
            this.labelCaption.MouseUp += new System.Windows.Forms.MouseEventHandler(this.LabelCaptionMouseUp);
            // 
            // search
            // 
            this.search.Location = new System.Drawing.Point(350, 8);
            this.search.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.search.Name = "search";
            this.search.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(77)))), ((int)(((byte)(107)))));
            this.search.Properties.Appearance.Font = new System.Drawing.Font("Calibri", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.search.Properties.Appearance.ForeColor = System.Drawing.SystemColors.Window;
            this.search.Properties.Appearance.Options.UseBackColor = true;
            this.search.Properties.Appearance.Options.UseFont = true;
            this.search.Properties.Appearance.Options.UseForeColor = true;
            this.search.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat;
            serializableAppearanceObject2.BackColor = System.Drawing.Color.Black;
            serializableAppearanceObject2.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            serializableAppearanceObject2.Options.UseBackColor = true;
            serializableAppearanceObject2.Options.UseFont = true;
            this.search.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Search, "", -1, false, true, true, DevExpress.XtraEditors.ImageLocation.MiddleCenter, null, new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject2, "", null, null, true)});
            this.search.Properties.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.UltraFlat;
            this.search.Properties.LookAndFeel.UseDefaultLookAndFeel = false;
            this.search.Properties.NullValuePrompt = "Поиск...";
            this.search.Properties.NullValuePromptShowForEmptyValue = true;
            this.search.Properties.UseDefaultMode = true;
            this.search.Size = new System.Drawing.Size(300, 24);
            this.search.TabIndex = 1;
            // 
            // lcMain
            // 
            this.lcMain.Controls.Add(this.ucScheduler);
            this.lcMain.Controls.Add(this.ucMails);
            this.lcMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lcMain.Location = new System.Drawing.Point(60, 40);
            this.lcMain.Name = "lcMain";
            this.lcMain.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = new System.Drawing.Rectangle(487, 260, 532, 350);
            this.lcMain.Root = this.lcgMain;
            this.lcMain.Size = new System.Drawing.Size(735, 427);
            this.lcMain.TabIndex = 5;
            // 
            // ucScheduler
            // 
            this.ucScheduler.Location = new System.Drawing.Point(1, 1);
            this.ucScheduler.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.ucScheduler.Name = "ucScheduler";
            this.ucScheduler.Size = new System.Drawing.Size(733, 425);
            this.ucScheduler.TabIndex = 5;
            // 
            // ucMails
            // 
            this.ucMails.Location = new System.Drawing.Point(1, 1);
            this.ucMails.Name = "ucMails";
            this.ucMails.Size = new System.Drawing.Size(733, 425);
            this.ucMails.TabIndex = 4;
            // 
            // lcgMain
            // 
            this.lcgMain.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.False;
            this.lcgMain.GroupBordersVisible = false;
            this.lcgMain.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.tcgModes});
            this.lcgMain.Location = new System.Drawing.Point(0, 0);
            this.lcgMain.Name = "Root";
            this.lcgMain.Size = new System.Drawing.Size(735, 427);
            this.lcgMain.TextVisible = false;
            // 
            // tcgModes
            // 
            this.tcgModes.HeaderAutoFill = DevExpress.Utils.DefaultBoolean.True;
            this.tcgModes.Location = new System.Drawing.Point(0, 0);
            this.tcgModes.Name = "tcgModes";
            this.tcgModes.Padding = new DevExpress.XtraLayout.Utils.Padding(-2, -2, -2, -2);
            this.tcgModes.SelectedTabPage = this.lcgMails;
            this.tcgModes.SelectedTabPageIndex = 0;
            this.tcgModes.ShowTabHeader = DevExpress.Utils.DefaultBoolean.False;
            this.tcgModes.Size = new System.Drawing.Size(735, 427);
            this.tcgModes.TabPages.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.lcgMails,
            this.lcgScheduler,
            this.lcgAudits,
            this.lcgUser});
            // 
            // lcgMails
            // 
            this.lcgMails.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.lciMails});
            this.lcgMails.Location = new System.Drawing.Point(0, 0);
            this.lcgMails.Name = "lcgMails";
            this.lcgMails.Size = new System.Drawing.Size(733, 425);
            // 
            // lciMails
            // 
            this.lciMails.Control = this.ucMails;
            this.lciMails.Location = new System.Drawing.Point(0, 0);
            this.lciMails.Name = "lciMails";
            this.lciMails.Padding = new DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 0);
            this.lciMails.Size = new System.Drawing.Size(733, 425);
            this.lciMails.TextSize = new System.Drawing.Size(0, 0);
            this.lciMails.TextVisible = false;
            // 
            // lcgScheduler
            // 
            this.lcgScheduler.CustomizationFormText = "Tab2";
            this.lcgScheduler.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.lciScheduler});
            this.lcgScheduler.Location = new System.Drawing.Point(0, 0);
            this.lcgScheduler.Name = "lcgScheduler";
            this.lcgScheduler.Size = new System.Drawing.Size(733, 425);
            // 
            // lciScheduler
            // 
            this.lciScheduler.Control = this.ucScheduler;
            this.lciScheduler.Location = new System.Drawing.Point(0, 0);
            this.lciScheduler.Name = "lciScheduler";
            this.lciScheduler.Padding = new DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 0);
            this.lciScheduler.Size = new System.Drawing.Size(733, 425);
            this.lciScheduler.TextSize = new System.Drawing.Size(0, 0);
            this.lciScheduler.TextVisible = false;
            // 
            // lcgAudits
            // 
            this.lcgAudits.Location = new System.Drawing.Point(0, 0);
            this.lcgAudits.Name = "lcgAudits";
            this.lcgAudits.Size = new System.Drawing.Size(733, 425);
            // 
            // lcgUser
            // 
            this.lcgUser.Location = new System.Drawing.Point(0, 0);
            this.lcgUser.Name = "lcgUser";
            this.lcgUser.Size = new System.Drawing.Size(733, 425);
            // 
            // statusStrip
            // 
            this.statusStrip.AutoSize = false;
            this.statusStrip.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(139)))), ((int)(((byte)(175)))));
            this.statusStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1,
            this.toolStripStatusLabel2});
            this.statusStrip.Location = new System.Drawing.Point(0, 467);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Size = new System.Drawing.Size(795, 22);
            this.statusStrip.TabIndex = 8;
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(101, 17);
            this.toolStripStatusLabel1.Text = "toolStripLeftText";
            // 
            // toolStripStatusLabel2
            // 
            this.toolStripStatusLabel2.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.toolStripStatusLabel2.Name = "toolStripStatusLabel2";
            this.toolStripStatusLabel2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.toolStripStatusLabel2.Size = new System.Drawing.Size(679, 17);
            this.toolStripStatusLabel2.Spring = true;
            this.toolStripStatusLabel2.Text = "tsslRightText";
            this.toolStripStatusLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnAudits
            // 
            this.btnAudits.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAudits.FlatAppearance.BorderSize = 0;
            this.btnAudits.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAudits.Image = global::FredroClient.Properties.Resources.blue_audit_32x32;
            this.btnAudits.Location = new System.Drawing.Point(5, 301);
            this.btnAudits.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAudits.Name = "btnAudits";
            this.btnAudits.Size = new System.Drawing.Size(51, 41);
            this.btnAudits.TabIndex = 5;
            this.btnAudits.UseVisualStyleBackColor = true;
            // 
            // btnMails
            // 
            this.btnMails.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMails.FlatAppearance.BorderSize = 0;
            this.btnMails.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMails.Image = global::FredroClient.Properties.Resources.blue_email_32x32;
            this.btnMails.Location = new System.Drawing.Point(5, 173);
            this.btnMails.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnMails.Name = "btnMails";
            this.btnMails.Size = new System.Drawing.Size(51, 41);
            this.btnMails.TabIndex = 4;
            this.btnMails.UseVisualStyleBackColor = true;
            // 
            // btnScheduler
            // 
            this.btnScheduler.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnScheduler.FlatAppearance.BorderSize = 0;
            this.btnScheduler.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnScheduler.Image = global::FredroClient.Properties.Resources.blue_calendar_32x32;
            this.btnScheduler.Location = new System.Drawing.Point(5, 237);
            this.btnScheduler.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnScheduler.Name = "btnScheduler";
            this.btnScheduler.Size = new System.Drawing.Size(51, 41);
            this.btnScheduler.TabIndex = 4;
            this.btnScheduler.UseVisualStyleBackColor = true;
            // 
            // btnUser
            // 
            this.btnUser.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnUser.FlatAppearance.BorderSize = 0;
            this.btnUser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUser.Image = global::FredroClient.Properties.Resources.blue_user_32x32;
            this.btnUser.Location = new System.Drawing.Point(5, 366);
            this.btnUser.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnUser.Name = "btnUser";
            this.btnUser.Size = new System.Drawing.Size(51, 41);
            this.btnUser.TabIndex = 2;
            this.btnUser.UseVisualStyleBackColor = true;
            // 
            // btnHome
            // 
            this.btnHome.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnHome.FlatAppearance.BorderSize = 0;
            this.btnHome.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHome.Image = global::FredroClient.Properties.Resources.ava_32x32;
            this.btnHome.Location = new System.Drawing.Point(757, 1);
            this.btnHome.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(37, 37);
            this.btnHome.TabIndex = 6;
            this.btnHome.UseVisualStyleBackColor = true;
            this.btnHome.Click += new System.EventHandler(this.btnHome_Click);
            // 
            // btnMinimize
            // 
            this.btnMinimize.BackColor = System.Drawing.Color.Transparent;
            this.btnMinimize.FlatAppearance.BorderSize = 0;
            this.btnMinimize.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(191)))), ((int)(((byte)(244)))));
            this.btnMinimize.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(171)))), ((int)(((byte)(221)))));
            this.btnMinimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMinimize.Image = ((System.Drawing.Image)(resources.GetObject("btnMinimize.Image")));
            this.btnMinimize.Location = new System.Drawing.Point(3, 2);
            this.btnMinimize.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnMinimize.Name = "btnMinimize";
            this.btnMinimize.Size = new System.Drawing.Size(54, 35);
            this.btnMinimize.TabIndex = 5;
            this.btnMinimize.UseVisualStyleBackColor = false;
            this.btnMinimize.Click += new System.EventHandler(this.btnMinimize_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(795, 489);
            this.Controls.Add(this.lcMain);
            this.Controls.Add(this.panelLeft);
            this.Controls.Add(this.panelTop);
            this.Controls.Add(this.statusStrip);
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
            ((System.ComponentModel.ISupportInitialize)(this.lcMain)).EndInit();
            this.lcMain.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.lcgMain)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tcgModes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lcgMails)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciMails)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lcgScheduler)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciScheduler)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lcgAudits)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lcgUser)).EndInit();
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
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
        private DevExpress.XtraLayout.LayoutControl lcMain;
        private DevExpress.XtraLayout.LayoutControlGroup lcgMain;
        private UserControls.ucScheduler ucScheduler;
        private UserControls.ucMails ucMails;
        private DevExpress.XtraLayout.TabbedControlGroup tcgModes;
        private DevExpress.XtraLayout.LayoutControlGroup lcgScheduler;
        private DevExpress.XtraLayout.LayoutControlItem lciScheduler;
        private DevExpress.XtraLayout.LayoutControlGroup lcgMails;
        private DevExpress.XtraLayout.LayoutControlItem lciMails;
        private DevExpress.XtraLayout.LayoutControlGroup lcgAudits;
        private DevExpress.XtraLayout.LayoutControlGroup lcgUser;
        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel2;
        private System.Windows.Forms.Button btnHome;
    }
}