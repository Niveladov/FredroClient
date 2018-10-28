namespace FredroClient.Forms
{
    sealed partial class frmStart
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected sealed override void Dispose(bool disposing)
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
            DevExpress.XtraLayout.ColumnDefinition columnDefinition6 = new DevExpress.XtraLayout.ColumnDefinition();
            DevExpress.XtraLayout.ColumnDefinition columnDefinition7 = new DevExpress.XtraLayout.ColumnDefinition();
            DevExpress.XtraLayout.ColumnDefinition columnDefinition8 = new DevExpress.XtraLayout.ColumnDefinition();
            DevExpress.XtraLayout.ColumnDefinition columnDefinition9 = new DevExpress.XtraLayout.ColumnDefinition();
            DevExpress.XtraLayout.ColumnDefinition columnDefinition10 = new DevExpress.XtraLayout.ColumnDefinition();
            DevExpress.XtraLayout.RowDefinition rowDefinition8 = new DevExpress.XtraLayout.RowDefinition();
            DevExpress.XtraLayout.RowDefinition rowDefinition9 = new DevExpress.XtraLayout.RowDefinition();
            DevExpress.XtraLayout.RowDefinition rowDefinition10 = new DevExpress.XtraLayout.RowDefinition();
            DevExpress.XtraLayout.RowDefinition rowDefinition11 = new DevExpress.XtraLayout.RowDefinition();
            DevExpress.XtraLayout.RowDefinition rowDefinition12 = new DevExpress.XtraLayout.RowDefinition();
            DevExpress.XtraLayout.RowDefinition rowDefinition13 = new DevExpress.XtraLayout.RowDefinition();
            DevExpress.XtraLayout.RowDefinition rowDefinition14 = new DevExpress.XtraLayout.RowDefinition();
            this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.lcMain = new DevExpress.XtraLayout.LayoutControl();
            this.icbeHostname = new DevExpress.XtraEditors.ImageComboBoxEdit();
            this.btnCancel = new DevExpress.XtraEditors.SimpleButton();
            this.btnEnter = new DevExpress.XtraEditors.SimpleButton();
            this.tePassword = new DevExpress.XtraEditors.TextEdit();
            this.teLogin = new DevExpress.XtraEditors.TextEdit();
            this.lcgMain = new DevExpress.XtraLayout.LayoutControlGroup();
            this.lciLogin = new DevExpress.XtraLayout.LayoutControlItem();
            this.lciPassword = new DevExpress.XtraLayout.LayoutControlItem();
            this.lciEnter = new DevExpress.XtraLayout.LayoutControlItem();
            this.lciCancel = new DevExpress.XtraLayout.LayoutControlItem();
            this.lciEmailServer = new DevExpress.XtraLayout.LayoutControlItem();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lcMain)).BeginInit();
            this.lcMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.icbeHostname.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tePassword.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.teLogin.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lcgMain)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciLogin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciPassword)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciEnter)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciCancel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciEmailServer)).BeginInit();
            this.SuspendLayout();
            // 
            // layoutControl1
            // 
            this.layoutControl1.Location = new System.Drawing.Point(274, 110);
            this.layoutControl1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.Root = this.layoutControlGroup1;
            this.layoutControl1.Size = new System.Drawing.Size(154, 98);
            this.layoutControl1.TabIndex = 0;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // layoutControlGroup1
            // 
            this.layoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.layoutControlGroup1.GroupBordersVisible = false;
            this.layoutControlGroup1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup1.Name = "layoutControlGroup1";
            this.layoutControlGroup1.Size = new System.Drawing.Size(154, 98);
            this.layoutControlGroup1.TextVisible = false;
            // 
            // lcMain
            // 
            this.lcMain.Appearance.Control.Font = new System.Drawing.Font("Tahoma", 10F);
            this.lcMain.Appearance.Control.Options.UseFont = true;
            this.lcMain.Controls.Add(this.icbeHostname);
            this.lcMain.Controls.Add(this.btnCancel);
            this.lcMain.Controls.Add(this.btnEnter);
            this.lcMain.Controls.Add(this.tePassword);
            this.lcMain.Controls.Add(this.teLogin);
            this.lcMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lcMain.Location = new System.Drawing.Point(0, 0);
            this.lcMain.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lcMain.Name = "lcMain";
            this.lcMain.Root = this.lcgMain;
            this.lcMain.Size = new System.Drawing.Size(499, 222);
            this.lcMain.TabIndex = 1;
            // 
            // icbeHostname
            // 
            this.icbeHostname.Location = new System.Drawing.Point(63, 35);
            this.icbeHostname.Name = "icbeHostname";
            this.icbeHostname.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.False;
            this.icbeHostname.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.icbeHostname.Properties.NullValuePrompt = "Выберете сервер входящей почты...";
            this.icbeHostname.Size = new System.Drawing.Size(373, 22);
            this.icbeHostname.StyleController = this.lcMain;
            this.icbeHostname.TabIndex = 9;
            // 
            // btnCancel
            // 
            this.btnCancel.AllowFocus = false;
            this.btnCancel.Location = new System.Drawing.Point(111, 164);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(277, 23);
            this.btnCancel.StyleController = this.lcMain;
            this.btnCancel.TabIndex = 8;
            this.btnCancel.Text = "Закрыть";
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnEnter
            // 
            this.btnEnter.AllowFocus = false;
            this.btnEnter.Location = new System.Drawing.Point(111, 131);
            this.btnEnter.Name = "btnEnter";
            this.btnEnter.Size = new System.Drawing.Size(277, 23);
            this.btnEnter.StyleController = this.lcMain;
            this.btnEnter.TabIndex = 7;
            this.btnEnter.Text = "Войти";
            this.btnEnter.Click += new System.EventHandler(this.btnEnter_Click);
            // 
            // tePassword
            // 
            this.tePassword.Location = new System.Drawing.Point(63, 99);
            this.tePassword.Name = "tePassword";
            this.tePassword.Properties.NullValuePrompt = "     Введите пароль...";
            this.tePassword.Properties.NullValuePromptShowForEmptyValue = true;
            this.tePassword.Properties.PasswordChar = '*';
            this.tePassword.Size = new System.Drawing.Size(373, 22);
            this.tePassword.StyleController = this.lcMain;
            this.tePassword.TabIndex = 5;
            // 
            // teLogin
            // 
            this.teLogin.Location = new System.Drawing.Point(63, 67);
            this.teLogin.Name = "teLogin";
            this.teLogin.Properties.NullValuePrompt = "     Введите логин...";
            this.teLogin.Properties.NullValuePromptShowForEmptyValue = true;
            this.teLogin.Size = new System.Drawing.Size(373, 22);
            this.teLogin.StyleController = this.lcMain;
            this.teLogin.TabIndex = 4;
            // 
            // lcgMain
            // 
            this.lcgMain.AppearanceGroup.Font = new System.Drawing.Font("Tahoma", 10F);
            this.lcgMain.AppearanceGroup.Options.UseFont = true;
            this.lcgMain.AppearanceItemCaption.Font = new System.Drawing.Font("Tahoma", 10F);
            this.lcgMain.AppearanceItemCaption.Options.UseFont = true;
            this.lcgMain.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.lcgMain.GroupBordersVisible = false;
            this.lcgMain.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.lciLogin,
            this.lciPassword,
            this.lciEnter,
            this.lciCancel,
            this.lciEmailServer});
            this.lcgMain.LayoutMode = DevExpress.XtraLayout.Utils.LayoutMode.Table;
            this.lcgMain.Location = new System.Drawing.Point(0, 0);
            this.lcgMain.Name = "lcgMain";
            this.lcgMain.OptionsTableLayoutGroup.AutoSizeDefaultDefinitionLength = 50;
            columnDefinition6.SizeType = System.Windows.Forms.SizeType.Percent;
            columnDefinition6.Width = 10D;
            columnDefinition7.SizeType = System.Windows.Forms.SizeType.Percent;
            columnDefinition7.Width = 10D;
            columnDefinition8.SizeType = System.Windows.Forms.SizeType.Percent;
            columnDefinition8.Width = 60D;
            columnDefinition9.SizeType = System.Windows.Forms.SizeType.Percent;
            columnDefinition9.Width = 10D;
            columnDefinition10.SizeType = System.Windows.Forms.SizeType.Percent;
            columnDefinition10.Width = 10D;
            this.lcgMain.OptionsTableLayoutGroup.ColumnDefinitions.AddRange(new DevExpress.XtraLayout.ColumnDefinition[] {
            columnDefinition6,
            columnDefinition7,
            columnDefinition8,
            columnDefinition9,
            columnDefinition10});
            rowDefinition8.Height = 50D;
            rowDefinition8.SizeType = System.Windows.Forms.SizeType.Percent;
            rowDefinition9.Height = 32D;
            rowDefinition9.SizeType = System.Windows.Forms.SizeType.AutoSize;
            rowDefinition10.Height = 32D;
            rowDefinition10.SizeType = System.Windows.Forms.SizeType.AutoSize;
            rowDefinition11.Height = 32D;
            rowDefinition11.SizeType = System.Windows.Forms.SizeType.AutoSize;
            rowDefinition12.Height = 33D;
            rowDefinition12.SizeType = System.Windows.Forms.SizeType.AutoSize;
            rowDefinition13.Height = 33D;
            rowDefinition13.SizeType = System.Windows.Forms.SizeType.AutoSize;
            rowDefinition14.Height = 50D;
            rowDefinition14.SizeType = System.Windows.Forms.SizeType.Percent;
            this.lcgMain.OptionsTableLayoutGroup.RowDefinitions.AddRange(new DevExpress.XtraLayout.RowDefinition[] {
            rowDefinition8,
            rowDefinition9,
            rowDefinition10,
            rowDefinition11,
            rowDefinition12,
            rowDefinition13,
            rowDefinition14});
            this.lcgMain.Size = new System.Drawing.Size(499, 222);
            this.lcgMain.TextVisible = false;
            // 
            // lciLogin
            // 
            this.lciLogin.Control = this.teLogin;
            this.lciLogin.Location = new System.Drawing.Point(48, 52);
            this.lciLogin.Name = "lciLogin";
            this.lciLogin.OptionsTableLayoutItem.ColumnIndex = 1;
            this.lciLogin.OptionsTableLayoutItem.ColumnSpan = 3;
            this.lciLogin.OptionsTableLayoutItem.RowIndex = 2;
            this.lciLogin.Padding = new DevExpress.XtraLayout.Utils.Padding(5, 5, 5, 5);
            this.lciLogin.Size = new System.Drawing.Size(383, 32);
            this.lciLogin.TextSize = new System.Drawing.Size(0, 0);
            this.lciLogin.TextVisible = false;
            // 
            // lciPassword
            // 
            this.lciPassword.Control = this.tePassword;
            this.lciPassword.Location = new System.Drawing.Point(48, 84);
            this.lciPassword.Name = "lciPassword";
            this.lciPassword.OptionsTableLayoutItem.ColumnIndex = 1;
            this.lciPassword.OptionsTableLayoutItem.ColumnSpan = 3;
            this.lciPassword.OptionsTableLayoutItem.RowIndex = 3;
            this.lciPassword.Padding = new DevExpress.XtraLayout.Utils.Padding(5, 5, 5, 5);
            this.lciPassword.Size = new System.Drawing.Size(383, 32);
            this.lciPassword.TextSize = new System.Drawing.Size(0, 0);
            this.lciPassword.TextVisible = false;
            // 
            // lciEnter
            // 
            this.lciEnter.Control = this.btnEnter;
            this.lciEnter.Location = new System.Drawing.Point(96, 116);
            this.lciEnter.Name = "lciEnter";
            this.lciEnter.OptionsTableLayoutItem.ColumnIndex = 2;
            this.lciEnter.OptionsTableLayoutItem.RowIndex = 4;
            this.lciEnter.Padding = new DevExpress.XtraLayout.Utils.Padding(5, 5, 5, 5);
            this.lciEnter.Size = new System.Drawing.Size(287, 33);
            this.lciEnter.TextSize = new System.Drawing.Size(0, 0);
            this.lciEnter.TextVisible = false;
            // 
            // lciCancel
            // 
            this.lciCancel.Control = this.btnCancel;
            this.lciCancel.Location = new System.Drawing.Point(96, 149);
            this.lciCancel.Name = "lciCancel";
            this.lciCancel.OptionsTableLayoutItem.ColumnIndex = 2;
            this.lciCancel.OptionsTableLayoutItem.RowIndex = 5;
            this.lciCancel.Padding = new DevExpress.XtraLayout.Utils.Padding(5, 5, 5, 5);
            this.lciCancel.Size = new System.Drawing.Size(287, 33);
            this.lciCancel.TextSize = new System.Drawing.Size(0, 0);
            this.lciCancel.TextVisible = false;
            // 
            // lciEmailServer
            // 
            this.lciEmailServer.Control = this.icbeHostname;
            this.lciEmailServer.Location = new System.Drawing.Point(48, 20);
            this.lciEmailServer.Name = "lciEmailServer";
            this.lciEmailServer.OptionsTableLayoutItem.ColumnIndex = 1;
            this.lciEmailServer.OptionsTableLayoutItem.ColumnSpan = 3;
            this.lciEmailServer.OptionsTableLayoutItem.RowIndex = 1;
            this.lciEmailServer.Padding = new DevExpress.XtraLayout.Utils.Padding(5, 5, 5, 5);
            this.lciEmailServer.Size = new System.Drawing.Size(383, 32);
            this.lciEmailServer.TextSize = new System.Drawing.Size(0, 0);
            this.lciEmailServer.TextVisible = false;
            // 
            // frmStart
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(499, 222);
            this.Controls.Add(this.lcMain);
            this.Controls.Add(this.layoutControl1);
            this.Name = "frmStart";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Почтовый бизнес-клиент";
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lcMain)).EndInit();
            this.lcMain.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.icbeHostname.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tePassword.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.teLogin.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lcgMain)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciLogin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciPassword)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciEnter)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciCancel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciEmailServer)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
        private DevExpress.XtraLayout.LayoutControl lcMain;
        private DevExpress.XtraLayout.LayoutControlGroup lcgMain;
        private DevExpress.XtraEditors.TextEdit teLogin;
        private DevExpress.XtraLayout.LayoutControlItem lciLogin;
        private DevExpress.XtraEditors.TextEdit tePassword;
        private DevExpress.XtraLayout.LayoutControlItem lciPassword;
        private DevExpress.XtraEditors.SimpleButton btnEnter;
        private DevExpress.XtraLayout.LayoutControlItem lciEnter;
        private DevExpress.XtraEditors.SimpleButton btnCancel;
        private DevExpress.XtraLayout.LayoutControlItem lciCancel;
        private DevExpress.XtraEditors.ImageComboBoxEdit icbeHostname;
        private DevExpress.XtraLayout.LayoutControlItem lciEmailServer;
    }
}

