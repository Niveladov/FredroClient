namespace FredroClient.Forms
{
    partial class frmMails
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
            this.lcMain = new DevExpress.XtraLayout.LayoutControl();
            this.ucMails = new FredroClient.UserControls.ucMails();
            this.lcgMain = new DevExpress.XtraLayout.LayoutControlGroup();
            this.tcgModes = new DevExpress.XtraLayout.TabbedControlGroup();
            this.lcgMails = new DevExpress.XtraLayout.LayoutControlGroup();
            this.lciMails = new DevExpress.XtraLayout.LayoutControlItem();
            this.lcgScheduler = new DevExpress.XtraLayout.LayoutControlGroup();
            ((System.ComponentModel.ISupportInitialize)(this.lcMain)).BeginInit();
            this.lcMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lcgMain)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tcgModes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lcgMails)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciMails)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lcgScheduler)).BeginInit();
            this.SuspendLayout();
            // 
            // lcMain
            // 
            this.lcMain.Controls.Add(this.ucMails);
            this.lcMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lcMain.Location = new System.Drawing.Point(0, 0);
            this.lcMain.Name = "lcMain";
            this.lcMain.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = new System.Drawing.Rectangle(461, 146, 566, 449);
            this.lcMain.OptionsFocus.AllowFocusTabbedGroups = false;
            this.lcMain.Root = this.lcgMain;
            this.lcMain.Size = new System.Drawing.Size(723, 446);
            this.lcMain.TabIndex = 0;
            this.lcMain.Text = "layoutControl1";
            // 
            // ucMails
            // 
            this.ucMails.Location = new System.Drawing.Point(1, 23);
            this.ucMails.Name = "ucMails";
            this.ucMails.Size = new System.Drawing.Size(717, 418);
            this.ucMails.TabIndex = 0;
            // 
            // lcgMain
            // 
            this.lcgMain.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.False;
            this.lcgMain.GroupBordersVisible = false;
            this.lcgMain.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.tcgModes});
            this.lcgMain.Location = new System.Drawing.Point(0, 0);
            this.lcgMain.Name = "lcgMain";
            this.lcgMain.Size = new System.Drawing.Size(723, 446);
            this.lcgMain.TextVisible = false;
            // 
            // tcgModes
            // 
            this.tcgModes.HeaderOrientation = DevExpress.XtraTab.TabOrientation.Horizontal;
            this.tcgModes.Location = new System.Drawing.Point(0, 0);
            this.tcgModes.MultiLine = DevExpress.Utils.DefaultBoolean.False;
            this.tcgModes.Name = "tcgModes";
            this.tcgModes.Padding = new DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 0);
            this.tcgModes.SelectedTabPage = this.lcgMails;
            this.tcgModes.SelectedTabPageIndex = 0;
            this.tcgModes.ShowTabHeader = DevExpress.Utils.DefaultBoolean.True;
            this.tcgModes.Size = new System.Drawing.Size(723, 446);
            this.tcgModes.Spacing = new DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 0);
            this.tcgModes.TabPages.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.lcgMails,
            this.lcgScheduler});
            this.tcgModes.TextLocation = DevExpress.Utils.Locations.Default;
            // 
            // lcgMails
            // 
            this.lcgMails.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.lciMails});
            this.lcgMails.Location = new System.Drawing.Point(0, 0);
            this.lcgMails.Name = "lcgMails";
            this.lcgMails.Padding = new DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 0);
            this.lcgMails.Size = new System.Drawing.Size(717, 418);
            this.lcgMails.Text = "Почта";
            // 
            // lciMails
            // 
            this.lciMails.Control = this.ucMails;
            this.lciMails.Location = new System.Drawing.Point(0, 0);
            this.lciMails.Name = "lciMails";
            this.lciMails.Padding = new DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 0);
            this.lciMails.Size = new System.Drawing.Size(717, 418);
            this.lciMails.TextSize = new System.Drawing.Size(0, 0);
            this.lciMails.TextVisible = false;
            // 
            // lcgScheduler
            // 
            this.lcgScheduler.CustomizationFormText = "Tab2";
            this.lcgScheduler.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.False;
            this.lcgScheduler.Location = new System.Drawing.Point(0, 0);
            this.lcgScheduler.Name = "lcgScheduler";
            this.lcgScheduler.Size = new System.Drawing.Size(717, 418);
            this.lcgScheduler.Text = "Календарь";
            this.lcgScheduler.TextLocation = DevExpress.Utils.Locations.Default;
            // 
            // frmMails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(723, 446);
            this.Controls.Add(this.lcMain);
            this.Name = "frmMails";
            this.Text = "frmMails";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.lcMain)).EndInit();
            this.lcMain.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.lcgMain)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tcgModes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lcgMails)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciMails)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lcgScheduler)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraLayout.LayoutControl lcMain;
        private UserControls.ucMails ucMails;
        private DevExpress.XtraLayout.LayoutControlGroup lcgMain;
        private DevExpress.XtraLayout.TabbedControlGroup tcgModes;
        private DevExpress.XtraLayout.LayoutControlGroup lcgMails;
        private DevExpress.XtraLayout.LayoutControlItem lciMails;
        private DevExpress.XtraLayout.LayoutControlGroup lcgScheduler;
    }
}