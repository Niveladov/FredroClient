namespace FredroClient.Forms
{
    partial class frmNewPerformer
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
            this.btnSave = new DevExpress.XtraEditors.SimpleButton();
            this.btnClose = new DevExpress.XtraEditors.SimpleButton();
            this.source = new DevExpress.XtraEditors.TextEdit();
            this.emailAddress = new DevExpress.XtraEditors.TextEdit();
            this.phoneNumber = new DevExpress.XtraEditors.TextEdit();
            this.subjectName = new DevExpress.XtraEditors.TextEdit();
            this.lcgMain = new DevExpress.XtraLayout.LayoutControlGroup();
            this.lciSubjectName = new DevExpress.XtraLayout.LayoutControlItem();
            this.lciPhoneNumber = new DevExpress.XtraLayout.LayoutControlItem();
            this.lciEmailAddress = new DevExpress.XtraLayout.LayoutControlItem();
            this.lciSource = new DevExpress.XtraLayout.LayoutControlItem();
            this.lciClose = new DevExpress.XtraLayout.LayoutControlItem();
            this.lciSave = new DevExpress.XtraLayout.LayoutControlItem();
            ((System.ComponentModel.ISupportInitialize)(this.lcMain)).BeginInit();
            this.lcMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.source.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emailAddress.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.phoneNumber.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.subjectName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lcgMain)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciSubjectName)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciPhoneNumber)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciEmailAddress)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciClose)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciSave)).BeginInit();
            this.SuspendLayout();
            // 
            // lcMain
            // 
            this.lcMain.Appearance.Control.Font = new System.Drawing.Font("Tahoma", 10F);
            this.lcMain.Appearance.Control.Options.UseFont = true;
            this.lcMain.Controls.Add(this.btnSave);
            this.lcMain.Controls.Add(this.btnClose);
            this.lcMain.Controls.Add(this.source);
            this.lcMain.Controls.Add(this.emailAddress);
            this.lcMain.Controls.Add(this.phoneNumber);
            this.lcMain.Controls.Add(this.subjectName);
            this.lcMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lcMain.Location = new System.Drawing.Point(0, 0);
            this.lcMain.Name = "lcMain";
            this.lcMain.Root = this.lcgMain;
            this.lcMain.Size = new System.Drawing.Size(462, 179);
            this.lcMain.TabIndex = 0;
            this.lcMain.Text = "layoutControl1";
            // 
            // btnSave
            // 
            this.btnSave.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSave.Location = new System.Drawing.Point(7, 135);
            this.btnSave.Name = "btnSave";
            this.btnSave.ShowFocusRectangle = DevExpress.Utils.DefaultBoolean.False;
            this.btnSave.Size = new System.Drawing.Size(222, 28);
            this.btnSave.StyleController = this.lcMain;
            this.btnSave.TabIndex = 9;
            this.btnSave.Text = "Сохранить";
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnClose
            // 
            this.btnClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClose.Location = new System.Drawing.Point(233, 135);
            this.btnClose.Name = "btnClose";
            this.btnClose.ShowFocusRectangle = DevExpress.Utils.DefaultBoolean.False;
            this.btnClose.Size = new System.Drawing.Size(222, 28);
            this.btnClose.StyleController = this.lcMain;
            this.btnClose.TabIndex = 8;
            this.btnClose.Text = "Закрыть";
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // source
            // 
            this.source.Location = new System.Drawing.Point(85, 103);
            this.source.Name = "source";
            this.source.Properties.NullValuePrompt = "Источник...";
            this.source.Properties.NullValuePromptShowForEmptyValue = true;
            this.source.Size = new System.Drawing.Size(370, 28);
            this.source.StyleController = this.lcMain;
            this.source.TabIndex = 7;
            // 
            // emailAddress
            // 
            this.emailAddress.Location = new System.Drawing.Point(85, 71);
            this.emailAddress.Name = "emailAddress";
            this.emailAddress.Properties.Mask.EditMask = "(\\w+([-+.]\\w+)*@\\w+([-.]\\w+)*\\.\\w+([-.]\\w+)*)(, (\\w+([-+.]\\w+)*@\\w+([-.]\\w+)*\\.\\w" +
    "+([-.]\\w+)*))*";
            this.emailAddress.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.RegEx;
            this.emailAddress.Properties.NullValuePrompt = "Адресс электронной почты...";
            this.emailAddress.Properties.NullValuePromptShowForEmptyValue = true;
            this.emailAddress.Size = new System.Drawing.Size(370, 28);
            this.emailAddress.StyleController = this.lcMain;
            this.emailAddress.TabIndex = 6;
            // 
            // phoneNumber
            // 
            this.phoneNumber.Location = new System.Drawing.Point(85, 39);
            this.phoneNumber.Name = "phoneNumber";
            this.phoneNumber.Properties.Mask.EditMask = "[+][7]\\(\\d{3}\\)\\d{3}-\\d{2}-\\d{2}(, [+][7]\\(\\d{3}\\)\\d{3}-\\d{2}-\\d{2})*";
            this.phoneNumber.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.RegEx;
            this.phoneNumber.Properties.NullValuePrompt = "Номера телефонов...";
            this.phoneNumber.Properties.NullValuePromptShowForEmptyValue = true;
            this.phoneNumber.Size = new System.Drawing.Size(370, 28);
            this.phoneNumber.StyleController = this.lcMain;
            this.phoneNumber.TabIndex = 5;
            // 
            // subjectName
            // 
            this.subjectName.Location = new System.Drawing.Point(85, 7);
            this.subjectName.Name = "subjectName";
            this.subjectName.Properties.NullValuePrompt = "Название юр. или физ. лица...";
            this.subjectName.Properties.NullValuePromptShowForEmptyValue = true;
            this.subjectName.Size = new System.Drawing.Size(370, 28);
            this.subjectName.StyleController = this.lcMain;
            this.subjectName.TabIndex = 4;
            // 
            // lcgMain
            // 
            this.lcgMain.AppearanceItemCaption.Font = new System.Drawing.Font("Tahoma", 10F);
            this.lcgMain.AppearanceItemCaption.Options.UseFont = true;
            this.lcgMain.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.lcgMain.GroupBordersVisible = false;
            this.lcgMain.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.lciSubjectName,
            this.lciPhoneNumber,
            this.lciEmailAddress,
            this.lciSource,
            this.lciClose,
            this.lciSave});
            this.lcgMain.Location = new System.Drawing.Point(0, 0);
            this.lcgMain.Name = "lcgMain";
            this.lcgMain.Padding = new DevExpress.XtraLayout.Utils.Padding(5, 5, 5, 5);
            this.lcgMain.Size = new System.Drawing.Size(462, 179);
            this.lcgMain.TextVisible = false;
            // 
            // lciSubjectName
            // 
            this.lciSubjectName.Control = this.subjectName;
            this.lciSubjectName.Location = new System.Drawing.Point(0, 0);
            this.lciSubjectName.Name = "lciSubjectName";
            this.lciSubjectName.Size = new System.Drawing.Size(452, 32);
            this.lciSubjectName.Text = "Название";
            this.lciSubjectName.TextSize = new System.Drawing.Size(75, 21);
            // 
            // lciPhoneNumber
            // 
            this.lciPhoneNumber.Control = this.phoneNumber;
            this.lciPhoneNumber.Location = new System.Drawing.Point(0, 32);
            this.lciPhoneNumber.Name = "lciPhoneNumber";
            this.lciPhoneNumber.Size = new System.Drawing.Size(452, 32);
            this.lciPhoneNumber.Text = "Телефон";
            this.lciPhoneNumber.TextSize = new System.Drawing.Size(75, 21);
            // 
            // lciEmailAddress
            // 
            this.lciEmailAddress.Control = this.emailAddress;
            this.lciEmailAddress.Location = new System.Drawing.Point(0, 64);
            this.lciEmailAddress.Name = "lciEmailAddress";
            this.lciEmailAddress.Size = new System.Drawing.Size(452, 32);
            this.lciEmailAddress.Text = "Имэйл";
            this.lciEmailAddress.TextSize = new System.Drawing.Size(75, 21);
            // 
            // lciSource
            // 
            this.lciSource.Control = this.source;
            this.lciSource.Location = new System.Drawing.Point(0, 96);
            this.lciSource.Name = "lciSource";
            this.lciSource.Size = new System.Drawing.Size(452, 32);
            this.lciSource.Text = "Источник";
            this.lciSource.TextSize = new System.Drawing.Size(75, 21);
            // 
            // lciClose
            // 
            this.lciClose.Control = this.btnClose;
            this.lciClose.Location = new System.Drawing.Point(226, 128);
            this.lciClose.MaxSize = new System.Drawing.Size(0, 32);
            this.lciClose.MinSize = new System.Drawing.Size(121, 32);
            this.lciClose.Name = "lciClose";
            this.lciClose.Size = new System.Drawing.Size(226, 41);
            this.lciClose.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.lciClose.TextSize = new System.Drawing.Size(0, 0);
            this.lciClose.TextVisible = false;
            // 
            // lciSave
            // 
            this.lciSave.Control = this.btnSave;
            this.lciSave.Location = new System.Drawing.Point(0, 128);
            this.lciSave.MaxSize = new System.Drawing.Size(0, 32);
            this.lciSave.MinSize = new System.Drawing.Size(121, 32);
            this.lciSave.Name = "lciSave";
            this.lciSave.Size = new System.Drawing.Size(226, 41);
            this.lciSave.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.lciSave.TextSize = new System.Drawing.Size(0, 0);
            this.lciSave.TextVisible = false;
            // 
            // frmNewCustomer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(462, 179);
            this.Controls.Add(this.lcMain);
            this.MaximumSize = new System.Drawing.Size(480, 226);
            this.MinimumSize = new System.Drawing.Size(480, 226);
            this.Name = "frmNewCustomer";
            this.Text = "Новый исполнитель";
            ((System.ComponentModel.ISupportInitialize)(this.lcMain)).EndInit();
            this.lcMain.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.source.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emailAddress.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.phoneNumber.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.subjectName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lcgMain)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciSubjectName)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciPhoneNumber)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciEmailAddress)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciClose)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciSave)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraLayout.LayoutControl lcMain;
        private DevExpress.XtraLayout.LayoutControlGroup lcgMain;
        private DevExpress.XtraEditors.TextEdit source;
        private DevExpress.XtraEditors.TextEdit emailAddress;
        private DevExpress.XtraEditors.TextEdit phoneNumber;
        private DevExpress.XtraEditors.TextEdit subjectName;
        private DevExpress.XtraLayout.LayoutControlItem lciSubjectName;
        private DevExpress.XtraLayout.LayoutControlItem lciPhoneNumber;
        private DevExpress.XtraLayout.LayoutControlItem lciEmailAddress;
        private DevExpress.XtraLayout.LayoutControlItem lciSource;
        private DevExpress.XtraEditors.SimpleButton btnSave;
        private DevExpress.XtraEditors.SimpleButton btnClose;
        private DevExpress.XtraLayout.LayoutControlItem lciClose;
        private DevExpress.XtraLayout.LayoutControlItem lciSave;
    }
}