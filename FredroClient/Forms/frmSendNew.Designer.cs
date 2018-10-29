namespace FredroClient.Forms
{
    sealed partial class frmSendNew
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
            this.lcgMain = new DevExpress.XtraLayout.LayoutControlGroup();
            this.teTo = new DevExpress.XtraEditors.TextEdit();
            this.lciTo = new DevExpress.XtraLayout.LayoutControlItem();
            this.teSubject = new DevExpress.XtraEditors.TextEdit();
            this.lciSubject = new DevExpress.XtraLayout.LayoutControlItem();
            this.meBody = new DevExpress.XtraEditors.MemoEdit();
            this.lciBody = new DevExpress.XtraLayout.LayoutControlItem();
            ((System.ComponentModel.ISupportInitialize)(this.lcMain)).BeginInit();
            this.lcMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lcgMain)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.teTo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciTo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.teSubject.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciSubject)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.meBody.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciBody)).BeginInit();
            this.SuspendLayout();
            // 
            // lcMain
            // 
            this.lcMain.Appearance.Control.Font = new System.Drawing.Font("Tahoma", 10F);
            this.lcMain.Appearance.Control.Options.UseFont = true;
            this.lcMain.Controls.Add(this.meBody);
            this.lcMain.Controls.Add(this.teSubject);
            this.lcMain.Controls.Add(this.teTo);
            this.lcMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lcMain.Location = new System.Drawing.Point(0, 0);
            this.lcMain.Name = "lcMain";
            this.lcMain.Root = this.lcgMain;
            this.lcMain.Size = new System.Drawing.Size(782, 553);
            this.lcMain.TabIndex = 0;
            this.lcMain.Text = "layoutControl1";
            // 
            // lcgMain
            // 
            this.lcgMain.AppearanceItemCaption.Font = new System.Drawing.Font("Tahoma", 10F);
            this.lcgMain.AppearanceItemCaption.Options.UseFont = true;
            this.lcgMain.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.lcgMain.GroupBordersVisible = false;
            this.lcgMain.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.lciTo,
            this.lciSubject,
            this.lciBody});
            this.lcgMain.Location = new System.Drawing.Point(0, 0);
            this.lcgMain.Name = "lcgMain";
            this.lcgMain.Padding = new DevExpress.XtraLayout.Utils.Padding(5, 5, 5, 5);
            this.lcgMain.Size = new System.Drawing.Size(782, 553);
            this.lcgMain.TextVisible = false;
            // 
            // teTo
            // 
            this.teTo.Location = new System.Drawing.Point(7, 7);
            this.teTo.Name = "teTo";
            this.teTo.Properties.NullValuePrompt = "Кому...";
            this.teTo.Properties.NullValuePromptShowForEmptyValue = true;
            this.teTo.Size = new System.Drawing.Size(768, 28);
            this.teTo.StyleController = this.lcMain;
            this.teTo.TabIndex = 4;
            // 
            // lciTo
            // 
            this.lciTo.Control = this.teTo;
            this.lciTo.Location = new System.Drawing.Point(0, 0);
            this.lciTo.Name = "lciTo";
            this.lciTo.Size = new System.Drawing.Size(772, 32);
            this.lciTo.TextSize = new System.Drawing.Size(0, 0);
            this.lciTo.TextVisible = false;
            // 
            // teSubject
            // 
            this.teSubject.Location = new System.Drawing.Point(7, 39);
            this.teSubject.Name = "teSubject";
            this.teSubject.Properties.NullValuePrompt = "Тема";
            this.teSubject.Properties.NullValuePromptShowForEmptyValue = true;
            this.teSubject.Size = new System.Drawing.Size(768, 28);
            this.teSubject.StyleController = this.lcMain;
            this.teSubject.TabIndex = 5;
            // 
            // lciSubject
            // 
            this.lciSubject.Control = this.teSubject;
            this.lciSubject.Location = new System.Drawing.Point(0, 32);
            this.lciSubject.Name = "lciSubject";
            this.lciSubject.Size = new System.Drawing.Size(772, 32);
            this.lciSubject.TextSize = new System.Drawing.Size(0, 0);
            this.lciSubject.TextVisible = false;
            // 
            // meBody
            // 
            this.meBody.Location = new System.Drawing.Point(7, 71);
            this.meBody.Name = "meBody";
            this.meBody.Properties.NullValuePrompt = "Сообщение...";
            this.meBody.Properties.NullValuePromptShowForEmptyValue = true;
            this.meBody.Size = new System.Drawing.Size(768, 475);
            this.meBody.StyleController = this.lcMain;
            this.meBody.TabIndex = 6;
            // 
            // lciBody
            // 
            this.lciBody.Control = this.meBody;
            this.lciBody.Location = new System.Drawing.Point(0, 64);
            this.lciBody.Name = "lciBody";
            this.lciBody.Size = new System.Drawing.Size(772, 479);
            this.lciBody.TextSize = new System.Drawing.Size(0, 0);
            this.lciBody.TextVisible = false;
            // 
            // frmSendNew
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(782, 553);
            this.Controls.Add(this.lcMain);
            this.Name = "frmSendNew";
            this.Text = "Новое сообщение";
            ((System.ComponentModel.ISupportInitialize)(this.lcMain)).EndInit();
            this.lcMain.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.lcgMain)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.teTo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciTo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.teSubject.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciSubject)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.meBody.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciBody)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraLayout.LayoutControl lcMain;
        private DevExpress.XtraLayout.LayoutControlGroup lcgMain;
        private DevExpress.XtraEditors.MemoEdit meBody;
        private DevExpress.XtraEditors.TextEdit teSubject;
        private DevExpress.XtraEditors.TextEdit teTo;
        private DevExpress.XtraLayout.LayoutControlItem lciTo;
        private DevExpress.XtraLayout.LayoutControlItem lciSubject;
        private DevExpress.XtraLayout.LayoutControlItem lciBody;
    }
}