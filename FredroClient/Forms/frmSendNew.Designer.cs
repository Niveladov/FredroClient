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
            this.btnSend = new DevExpress.XtraEditors.SimpleButton();
            this.meBody = new DevExpress.XtraEditors.MemoEdit();
            this.teSubject = new DevExpress.XtraEditors.TextEdit();
            this.teTo = new DevExpress.XtraEditors.TextEdit();
            this.lcgMain = new DevExpress.XtraLayout.LayoutControlGroup();
            this.lciTo = new DevExpress.XtraLayout.LayoutControlItem();
            this.lciSubject = new DevExpress.XtraLayout.LayoutControlItem();
            this.lciBody = new DevExpress.XtraLayout.LayoutControlItem();
            this.emptySpaceItem1 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.lciSend = new DevExpress.XtraLayout.LayoutControlItem();
            ((System.ComponentModel.ISupportInitialize)(this.lcMain)).BeginInit();
            this.lcMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.meBody.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.teSubject.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.teTo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lcgMain)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciTo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciSubject)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciBody)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciSend)).BeginInit();
            this.SuspendLayout();
            // 
            // lcMain
            // 
            this.lcMain.Appearance.Control.Font = new System.Drawing.Font("Tahoma", 10F);
            this.lcMain.Appearance.Control.Options.UseFont = true;
            this.lcMain.Controls.Add(this.btnSend);
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
            // btnSend
            // 
            this.btnSend.AllowFocus = false;
            this.btnSend.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSend.Location = new System.Drawing.Point(7, 508);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(107, 38);
            this.btnSend.StyleController = this.lcMain;
            this.btnSend.TabIndex = 7;
            this.btnSend.Text = "Отправить";
            // 
            // meBody
            // 
            this.meBody.Location = new System.Drawing.Point(7, 71);
            this.meBody.Name = "meBody";
            this.meBody.Properties.NullValuePrompt = "Сообщение...";
            this.meBody.Properties.NullValuePromptShowForEmptyValue = true;
            this.meBody.Properties.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.meBody.Size = new System.Drawing.Size(768, 433);
            this.meBody.StyleController = this.lcMain;
            this.meBody.TabIndex = 6;
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
            // teTo
            // 
            this.teTo.Location = new System.Drawing.Point(7, 7);
            this.teTo.Name = "teTo";
            this.teTo.Properties.NullValuePrompt = "Кому";
            this.teTo.Properties.NullValuePromptShowForEmptyValue = true;
            this.teTo.Size = new System.Drawing.Size(768, 28);
            this.teTo.StyleController = this.lcMain;
            this.teTo.TabIndex = 4;
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
            this.lciBody,
            this.emptySpaceItem1,
            this.lciSend});
            this.lcgMain.Location = new System.Drawing.Point(0, 0);
            this.lcgMain.Name = "lcgMain";
            this.lcgMain.Padding = new DevExpress.XtraLayout.Utils.Padding(5, 5, 5, 5);
            this.lcgMain.Size = new System.Drawing.Size(782, 553);
            this.lcgMain.TextVisible = false;
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
            // lciSubject
            // 
            this.lciSubject.Control = this.teSubject;
            this.lciSubject.Location = new System.Drawing.Point(0, 32);
            this.lciSubject.Name = "lciSubject";
            this.lciSubject.Size = new System.Drawing.Size(772, 32);
            this.lciSubject.TextSize = new System.Drawing.Size(0, 0);
            this.lciSubject.TextVisible = false;
            // 
            // lciBody
            // 
            this.lciBody.Control = this.meBody;
            this.lciBody.Location = new System.Drawing.Point(0, 64);
            this.lciBody.Name = "lciBody";
            this.lciBody.Size = new System.Drawing.Size(772, 437);
            this.lciBody.TextSize = new System.Drawing.Size(0, 0);
            this.lciBody.TextVisible = false;
            // 
            // emptySpaceItem1
            // 
            this.emptySpaceItem1.AllowHotTrack = false;
            this.emptySpaceItem1.Location = new System.Drawing.Point(111, 501);
            this.emptySpaceItem1.MinSize = new System.Drawing.Size(104, 24);
            this.emptySpaceItem1.Name = "emptySpaceItem1";
            this.emptySpaceItem1.Size = new System.Drawing.Size(661, 42);
            this.emptySpaceItem1.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.emptySpaceItem1.TextSize = new System.Drawing.Size(0, 0);
            // 
            // lciSend
            // 
            this.lciSend.Control = this.btnSend;
            this.lciSend.Location = new System.Drawing.Point(0, 501);
            this.lciSend.MaxSize = new System.Drawing.Size(111, 42);
            this.lciSend.MinSize = new System.Drawing.Size(111, 42);
            this.lciSend.Name = "lciSend";
            this.lciSend.Size = new System.Drawing.Size(111, 42);
            this.lciSend.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.lciSend.TextSize = new System.Drawing.Size(0, 0);
            this.lciSend.TextVisible = false;
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
            ((System.ComponentModel.ISupportInitialize)(this.meBody.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.teSubject.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.teTo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lcgMain)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciTo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciSubject)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciBody)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciSend)).EndInit();
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
        private DevExpress.XtraEditors.SimpleButton btnSend;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem1;
        private DevExpress.XtraLayout.LayoutControlItem lciSend;
    }
}