namespace TwinklCRM.Client.Forms
{
    partial class frmSplashScreen
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
            DevExpress.XtraLayout.ColumnDefinition columnDefinition1 = new DevExpress.XtraLayout.ColumnDefinition();
            DevExpress.XtraLayout.ColumnDefinition columnDefinition2 = new DevExpress.XtraLayout.ColumnDefinition();
            DevExpress.XtraLayout.ColumnDefinition columnDefinition3 = new DevExpress.XtraLayout.ColumnDefinition();
            DevExpress.XtraLayout.RowDefinition rowDefinition1 = new DevExpress.XtraLayout.RowDefinition();
            DevExpress.XtraLayout.RowDefinition rowDefinition2 = new DevExpress.XtraLayout.RowDefinition();
            DevExpress.XtraLayout.RowDefinition rowDefinition3 = new DevExpress.XtraLayout.RowDefinition();
            DevExpress.XtraLayout.RowDefinition rowDefinition4 = new DevExpress.XtraLayout.RowDefinition();
            this.lcMaim = new DevExpress.XtraLayout.LayoutControl();
            this.labelBottom = new DevExpress.XtraEditors.LabelControl();
            this.labelMain = new DevExpress.XtraEditors.LabelControl();
            this.lcgMail = new DevExpress.XtraLayout.LayoutControlGroup();
            this.lciLabel = new DevExpress.XtraLayout.LayoutControlItem();
            this.lciLabelBottom = new DevExpress.XtraLayout.LayoutControlItem();
            ((System.ComponentModel.ISupportInitialize)(this.lcMaim)).BeginInit();
            this.lcMaim.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lcgMail)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciLabel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciLabelBottom)).BeginInit();
            this.SuspendLayout();
            // 
            // lcMaim
            // 
            this.lcMaim.Controls.Add(this.labelBottom);
            this.lcMaim.Controls.Add(this.labelMain);
            this.lcMaim.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lcMaim.Location = new System.Drawing.Point(0, 0);
            this.lcMaim.Name = "lcMaim";
            this.lcMaim.Root = this.lcgMail;
            this.lcMaim.Size = new System.Drawing.Size(500, 250);
            this.lcMaim.TabIndex = 0;
            // 
            // labelBottom
            // 
            this.labelBottom.Location = new System.Drawing.Point(84, 219);
            this.labelBottom.Name = "labelBottom";
            this.labelBottom.Size = new System.Drawing.Size(404, 19);
            this.labelBottom.StyleController = this.lcMaim;
            this.labelBottom.TabIndex = 5;
            this.labelBottom.Text = "Все права защищены законами Вселенной. ® iTwinkl Inc";
            // 
            // labelMain
            // 
            this.labelMain.Appearance.Font = new System.Drawing.Font("Navy Queen LT", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMain.Location = new System.Drawing.Point(84, 104);
            this.labelMain.Name = "labelMain";
            this.labelMain.Size = new System.Drawing.Size(332, 42);
            this.labelMain.StyleController = this.lcMaim;
            this.labelMain.TabIndex = 4;
            this.labelMain.Text = "Twinkle CRM";
            // 
            // lcgMail
            // 
            this.lcgMail.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.lcgMail.GroupBordersVisible = false;
            this.lcgMail.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.lciLabel,
            this.lciLabelBottom});
            this.lcgMail.LayoutMode = DevExpress.XtraLayout.Utils.LayoutMode.Table;
            this.lcgMail.Location = new System.Drawing.Point(0, 0);
            this.lcgMail.Name = "lcgMail";
            columnDefinition1.SizeType = System.Windows.Forms.SizeType.Percent;
            columnDefinition1.Width = 15D;
            columnDefinition2.SizeType = System.Windows.Forms.SizeType.Percent;
            columnDefinition2.Width = 70D;
            columnDefinition3.SizeType = System.Windows.Forms.SizeType.Percent;
            columnDefinition3.Width = 15D;
            this.lcgMail.OptionsTableLayoutGroup.ColumnDefinitions.AddRange(new DevExpress.XtraLayout.ColumnDefinition[] {
            columnDefinition1,
            columnDefinition2,
            columnDefinition3});
            rowDefinition1.Height = 40D;
            rowDefinition1.SizeType = System.Windows.Forms.SizeType.Percent;
            rowDefinition2.Height = 20D;
            rowDefinition2.SizeType = System.Windows.Forms.SizeType.Percent;
            rowDefinition3.Height = 30D;
            rowDefinition3.SizeType = System.Windows.Forms.SizeType.Percent;
            rowDefinition4.Height = 10D;
            rowDefinition4.SizeType = System.Windows.Forms.SizeType.Percent;
            this.lcgMail.OptionsTableLayoutGroup.RowDefinitions.AddRange(new DevExpress.XtraLayout.RowDefinition[] {
            rowDefinition1,
            rowDefinition2,
            rowDefinition3,
            rowDefinition4});
            this.lcgMail.Size = new System.Drawing.Size(500, 250);
            this.lcgMail.TextVisible = false;
            // 
            // lciLabel
            // 
            this.lciLabel.Control = this.labelMain;
            this.lciLabel.Location = new System.Drawing.Point(72, 92);
            this.lciLabel.MinSize = new System.Drawing.Size(67, 17);
            this.lciLabel.Name = "lciLabel";
            this.lciLabel.OptionsTableLayoutItem.ColumnIndex = 1;
            this.lciLabel.OptionsTableLayoutItem.RowIndex = 1;
            this.lciLabel.Size = new System.Drawing.Size(336, 46);
            this.lciLabel.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.lciLabel.TextSize = new System.Drawing.Size(0, 0);
            this.lciLabel.TextVisible = false;
            // 
            // lciLabelBottom
            // 
            this.lciLabelBottom.Control = this.labelBottom;
            this.lciLabelBottom.Location = new System.Drawing.Point(72, 207);
            this.lciLabelBottom.MinSize = new System.Drawing.Size(67, 17);
            this.lciLabelBottom.Name = "lciLabelBottom";
            this.lciLabelBottom.OptionsTableLayoutItem.ColumnIndex = 1;
            this.lciLabelBottom.OptionsTableLayoutItem.ColumnSpan = 2;
            this.lciLabelBottom.OptionsTableLayoutItem.RowIndex = 3;
            this.lciLabelBottom.Size = new System.Drawing.Size(408, 23);
            this.lciLabelBottom.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.lciLabelBottom.TextSize = new System.Drawing.Size(0, 0);
            this.lciLabelBottom.TextVisible = false;
            // 
            // frmSplashScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(500, 250);
            this.Controls.Add(this.lcMaim);
            this.FormBorderEffect = DevExpress.XtraEditors.FormBorderEffect.Glow;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmSplashScreen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmSplashScreen";
            ((System.ComponentModel.ISupportInitialize)(this.lcMaim)).EndInit();
            this.lcMaim.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.lcgMail)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciLabel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciLabelBottom)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraLayout.LayoutControl lcMaim;
        private DevExpress.XtraLayout.LayoutControlGroup lcgMail;
        private DevExpress.XtraEditors.LabelControl labelMain;
        private DevExpress.XtraLayout.LayoutControlItem lciLabel;
        private DevExpress.XtraEditors.LabelControl labelBottom;
        private DevExpress.XtraLayout.LayoutControlItem lciLabelBottom;
    }
}