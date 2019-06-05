namespace TwinklCRM.Client.BaseGUI
{
    partial class DictionaryEditBaseForm
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
            this.panelBottom = new System.Windows.Forms.Panel();
            this.lcBottom = new DevExpress.XtraLayout.LayoutControl();
            this.btnSave = new DevExpress.XtraEditors.SimpleButton();
            this.btnCancel = new DevExpress.XtraEditors.SimpleButton();
            this.lcgBottom = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            this.lcMain = new DevExpress.XtraLayout.LayoutControl();
            this.lcgMain = new DevExpress.XtraLayout.LayoutControlGroup();
            this.panelBottom.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lcBottom)).BeginInit();
            this.lcBottom.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lcgBottom)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lcMain)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lcgMain)).BeginInit();
            this.SuspendLayout();
            // 
            // panelBottom
            // 
            this.panelBottom.Controls.Add(this.lcBottom);
            this.panelBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelBottom.Location = new System.Drawing.Point(0, 503);
            this.panelBottom.MaximumSize = new System.Drawing.Size(0, 50);
            this.panelBottom.MinimumSize = new System.Drawing.Size(0, 50);
            this.panelBottom.Name = "panelBottom";
            this.panelBottom.Size = new System.Drawing.Size(782, 50);
            this.panelBottom.TabIndex = 0;
            // 
            // lcBottom
            // 
            this.lcBottom.Controls.Add(this.btnSave);
            this.lcBottom.Controls.Add(this.btnCancel);
            this.lcBottom.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lcBottom.Location = new System.Drawing.Point(0, 0);
            this.lcBottom.Name = "lcBottom";
            this.lcBottom.Root = this.lcgBottom;
            this.lcBottom.Size = new System.Drawing.Size(782, 50);
            this.lcBottom.TabIndex = 0;
            this.lcBottom.Text = "layoutControl1";
            // 
            // btnSave
            // 
            this.btnSave.Appearance.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnSave.Appearance.Options.UseFont = true;
            this.btnSave.Location = new System.Drawing.Point(4, 4);
            this.btnSave.Name = "btnSave";
            this.btnSave.ShowFocusRectangle = DevExpress.Utils.DefaultBoolean.False;
            this.btnSave.Size = new System.Drawing.Size(389, 42);
            this.btnSave.StyleController = this.lcBottom;
            this.btnSave.TabIndex = 5;
            this.btnSave.Text = "Сохранить";
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Appearance.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnCancel.Appearance.Options.UseFont = true;
            this.btnCancel.Location = new System.Drawing.Point(397, 4);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.ShowFocusRectangle = DevExpress.Utils.DefaultBoolean.False;
            this.btnCancel.Size = new System.Drawing.Size(381, 42);
            this.btnCancel.StyleController = this.lcBottom;
            this.btnCancel.TabIndex = 4;
            this.btnCancel.Text = "Закрыть";
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // lcgBottom
            // 
            this.lcgBottom.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.lcgBottom.GroupBordersVisible = false;
            this.lcgBottom.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem1,
            this.layoutControlItem2});
            this.lcgBottom.Location = new System.Drawing.Point(0, 0);
            this.lcgBottom.Name = "lcgBottom";
            this.lcgBottom.Padding = new DevExpress.XtraLayout.Utils.Padding(2, 2, 2, 2);
            this.lcgBottom.Size = new System.Drawing.Size(782, 50);
            this.lcgBottom.TextVisible = false;
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.btnCancel;
            this.layoutControlItem1.Location = new System.Drawing.Point(393, 0);
            this.layoutControlItem1.MinSize = new System.Drawing.Size(95, 31);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(385, 46);
            this.layoutControlItem1.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.layoutControlItem1.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem1.TextVisible = false;
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.Control = this.btnSave;
            this.layoutControlItem2.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem2.MinSize = new System.Drawing.Size(95, 31);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.Size = new System.Drawing.Size(393, 46);
            this.layoutControlItem2.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.layoutControlItem2.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem2.TextVisible = false;
            // 
            // lcMain
            // 
            this.lcMain.Appearance.Control.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lcMain.Appearance.Control.Options.UseFont = true;
            this.lcMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lcMain.Location = new System.Drawing.Point(0, 0);
            this.lcMain.Name = "lcMain";
            this.lcMain.Root = this.lcgMain;
            this.lcMain.Size = new System.Drawing.Size(782, 503);
            this.lcMain.TabIndex = 1;
            // 
            // lcgMain
            // 
            this.lcgMain.AppearanceGroup.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lcgMain.AppearanceGroup.Options.UseFont = true;
            this.lcgMain.AppearanceItemCaption.Font = new System.Drawing.Font("Calibri", 10.2F);
            this.lcgMain.AppearanceItemCaption.Options.UseFont = true;
            this.lcgMain.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.lcgMain.GroupBordersVisible = false;
            this.lcgMain.Location = new System.Drawing.Point(0, 0);
            this.lcgMain.Name = "lcgMain";
            this.lcgMain.Size = new System.Drawing.Size(782, 503);
            this.lcgMain.TextVisible = false;
            // 
            // DictionaryEditBaseForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(782, 553);
            this.Controls.Add(this.lcMain);
            this.Controls.Add(this.panelBottom);
            this.Name = "DictionaryEditBaseForm";
            this.Text = "DictionaryEditBaseForm";
            this.panelBottom.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.lcBottom)).EndInit();
            this.lcBottom.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.lcgBottom)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lcMain)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lcgMain)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelBottom;
        private DevExpress.XtraLayout.LayoutControl lcMain;
        private DevExpress.XtraLayout.LayoutControlGroup lcgMain;
        private DevExpress.XtraLayout.LayoutControl lcBottom;
        private DevExpress.XtraLayout.LayoutControlGroup lcgBottom;
        private DevExpress.XtraEditors.SimpleButton btnSave;
        private DevExpress.XtraEditors.SimpleButton btnCancel;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
    }
}