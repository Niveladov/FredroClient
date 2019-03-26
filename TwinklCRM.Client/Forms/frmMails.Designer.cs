namespace TwinklCRM.Client.Forms
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
            this.ucMails = new TwinklCRM.Client.UserControls.ucMails();
            this.lcgMain = new DevExpress.XtraLayout.LayoutControlGroup();
            this.tcgModes = new DevExpress.XtraLayout.TabbedControlGroup();
            this.lcgMails = new DevExpress.XtraLayout.LayoutControlGroup();
            this.lciMails = new DevExpress.XtraLayout.LayoutControlItem();
            this.lcgScheduler = new DevExpress.XtraLayout.LayoutControlGroup();
            this.ucScheduler = new TwinklCRM.Client.UserControls.ucScheduler();
            this.lciScheduler = new DevExpress.XtraLayout.LayoutControlItem();
            ((System.ComponentModel.ISupportInitialize)(this.lcMain)).BeginInit();
            this.lcMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lcgMain)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tcgModes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lcgMails)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciMails)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lcgScheduler)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciScheduler)).BeginInit();
            this.SuspendLayout();
            // 
            // lcMain
            // 
            this.lcMain.Controls.Add(this.ucScheduler);
            this.lcMain.Controls.Add(this.ucMails);
            this.lcMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lcMain.Location = new System.Drawing.Point(0, 0);
            this.lcMain.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.lcMain.Name = "lcMain";
            this.lcMain.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = new System.Drawing.Rectangle(461, 146, 566, 449);
            this.lcMain.OptionsFocus.AllowFocusTabbedGroups = false;
            this.lcMain.Root = this.lcgMain;
            this.lcMain.Size = new System.Drawing.Size(843, 549);
            this.lcMain.TabIndex = 0;
            this.lcMain.Text = "layoutControl1";
            // 
            // ucMails
            // 
            this.ucMails.Location = new System.Drawing.Point(-1, 25);
            this.ucMails.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ucMails.Name = "ucMails";
            this.ucMails.Size = new System.Drawing.Size(840, 520);
            this.ucMails.TabIndex = 1;
            // 
            // lcgMain
            // 
            this.lcgMain.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.False;
            this.lcgMain.GroupBordersVisible = false;
            this.lcgMain.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.tcgModes});
            this.lcgMain.Location = new System.Drawing.Point(0, 0);
            this.lcgMain.Name = "lcgMain";
            this.lcgMain.Size = new System.Drawing.Size(843, 549);
            this.lcgMain.TextVisible = false;
            // 
            // tcgModes
            // 
            this.tcgModes.HeaderOrientation = DevExpress.XtraTab.TabOrientation.Horizontal;
            this.tcgModes.Location = new System.Drawing.Point(0, 0);
            this.tcgModes.MultiLine = DevExpress.Utils.DefaultBoolean.True;
            this.tcgModes.Name = "tcgModes";
            this.tcgModes.Padding = new DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 0);
            this.tcgModes.SelectedTabPage = this.lcgMails;
            this.tcgModes.SelectedTabPageIndex = 0;
            this.tcgModes.ShowTabHeader = DevExpress.Utils.DefaultBoolean.True;
            this.tcgModes.Size = new System.Drawing.Size(843, 549);
            this.tcgModes.Spacing = new DevExpress.XtraLayout.Utils.Padding(-2, -2, -2, -2);
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
            this.lcgMails.Size = new System.Drawing.Size(840, 520);
            this.lcgMails.Text = "Почта";
            // 
            // lciMails
            // 
            this.lciMails.Control = this.ucMails;
            this.lciMails.Location = new System.Drawing.Point(0, 0);
            this.lciMails.Name = "lciMails";
            this.lciMails.Padding = new DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 0);
            this.lciMails.Size = new System.Drawing.Size(840, 520);
            this.lciMails.TextSize = new System.Drawing.Size(0, 0);
            this.lciMails.TextVisible = false;
            // 
            // lcgScheduler
            // 
            this.lcgScheduler.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.False;
            this.lcgScheduler.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.lciScheduler});
            this.lcgScheduler.Location = new System.Drawing.Point(0, 0);
            this.lcgScheduler.Name = "lcgScheduler";
            this.lcgScheduler.Size = new System.Drawing.Size(840, 520);
            this.lcgScheduler.Text = "Календарь";
            this.lcgScheduler.TextLocation = DevExpress.Utils.Locations.Default;
            // 
            // ucScheduler
            // 
            this.ucScheduler.Location = new System.Drawing.Point(-1, 25);
            this.ucScheduler.Name = "ucScheduler";
            this.ucScheduler.Size = new System.Drawing.Size(840, 520);
            this.ucScheduler.TabIndex = 0;
            // 
            // lciScheduler
            // 
            this.lciScheduler.Control = this.ucScheduler;
            this.lciScheduler.Location = new System.Drawing.Point(0, 0);
            this.lciScheduler.Name = "lciScheduler";
            this.lciScheduler.Padding = new DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 0);
            this.lciScheduler.Size = new System.Drawing.Size(840, 520);
            this.lciScheduler.TextSize = new System.Drawing.Size(0, 0);
            this.lciScheduler.TextVisible = false;
            // 
            // frmMails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(843, 549);
            this.Controls.Add(this.lcMain);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
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
            ((System.ComponentModel.ISupportInitialize)(this.lciScheduler)).EndInit();
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
        private UserControls.ucScheduler ucScheduler;
        private DevExpress.XtraLayout.LayoutControlItem lciScheduler;
    }
}