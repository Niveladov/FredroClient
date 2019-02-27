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
            DevExpress.XtraLayout.ColumnDefinition columnDefinition1 = new DevExpress.XtraLayout.ColumnDefinition();
            DevExpress.XtraLayout.ColumnDefinition columnDefinition2 = new DevExpress.XtraLayout.ColumnDefinition();
            DevExpress.XtraLayout.ColumnDefinition columnDefinition3 = new DevExpress.XtraLayout.ColumnDefinition();
            DevExpress.XtraLayout.ColumnDefinition columnDefinition4 = new DevExpress.XtraLayout.ColumnDefinition();
            DevExpress.XtraLayout.ColumnDefinition columnDefinition5 = new DevExpress.XtraLayout.ColumnDefinition();
            DevExpress.XtraLayout.RowDefinition rowDefinition1 = new DevExpress.XtraLayout.RowDefinition();
            DevExpress.XtraLayout.RowDefinition rowDefinition2 = new DevExpress.XtraLayout.RowDefinition();
            DevExpress.XtraLayout.RowDefinition rowDefinition3 = new DevExpress.XtraLayout.RowDefinition();
            DevExpress.XtraLayout.RowDefinition rowDefinition4 = new DevExpress.XtraLayout.RowDefinition();
            DevExpress.XtraLayout.RowDefinition rowDefinition5 = new DevExpress.XtraLayout.RowDefinition();
            DevExpress.XtraLayout.RowDefinition rowDefinition6 = new DevExpress.XtraLayout.RowDefinition();
            this.lcMain = new DevExpress.XtraLayout.LayoutControl();
            this.btnCancel = new DevExpress.XtraEditors.SimpleButton();
            this.btnEnter = new DevExpress.XtraEditors.SimpleButton();
            this.tePassword = new DevExpress.XtraEditors.TextEdit();
            this.teLogin = new DevExpress.XtraEditors.TextEdit();
            this.lcgMain = new DevExpress.XtraLayout.LayoutControlGroup();
            this.lciLogin = new DevExpress.XtraLayout.LayoutControlItem();
            this.lciPassword = new DevExpress.XtraLayout.LayoutControlItem();
            this.lciEnter = new DevExpress.XtraLayout.LayoutControlItem();
            this.lciCancel = new DevExpress.XtraLayout.LayoutControlItem();
            ((System.ComponentModel.ISupportInitialize)(this.lcMain)).BeginInit();
            this.lcMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tePassword.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.teLogin.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lcgMain)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciLogin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciPassword)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciEnter)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciCancel)).BeginInit();
            this.SuspendLayout();
            // 
            // lcMain
            // 
            this.lcMain.Appearance.Control.Font = new System.Drawing.Font("Tahoma", 10F);
            this.lcMain.Appearance.Control.Options.UseFont = true;
            this.lcMain.Controls.Add(this.btnCancel);
            this.lcMain.Controls.Add(this.btnEnter);
            this.lcMain.Controls.Add(this.tePassword);
            this.lcMain.Controls.Add(this.teLogin);
            this.lcMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lcMain.Location = new System.Drawing.Point(0, 0);
            this.lcMain.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lcMain.Name = "lcMain";
            this.lcMain.Root = this.lcgMain;
            this.lcMain.Size = new System.Drawing.Size(357, 160);
            this.lcMain.TabIndex = 1;
            // 
            // btnCancel
            // 
            this.btnCancel.AllowFocus = false;
            this.btnCancel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCancel.Location = new System.Drawing.Point(112, 117);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(132, 22);
            this.btnCancel.StyleController = this.lcMain;
            this.btnCancel.TabIndex = 8;
            this.btnCancel.Text = "Закрыть";
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnEnter
            // 
            this.btnEnter.AllowFocus = false;
            this.btnEnter.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEnter.Location = new System.Drawing.Point(112, 85);
            this.btnEnter.Name = "btnEnter";
            this.btnEnter.Size = new System.Drawing.Size(132, 22);
            this.btnEnter.StyleController = this.lcMain;
            this.btnEnter.TabIndex = 7;
            this.btnEnter.Text = "Войти";
            this.btnEnter.Click += new System.EventHandler(this.btnEnter_Click);
            // 
            // tePassword
            // 
            this.tePassword.Location = new System.Drawing.Point(34, 53);
            this.tePassword.Name = "tePassword";
            this.tePassword.Properties.NullValuePrompt = "     Введите пароль...";
            this.tePassword.Properties.NullValuePromptShowForEmptyValue = true;
            this.tePassword.Properties.PasswordChar = '*';
            this.tePassword.Size = new System.Drawing.Size(288, 22);
            this.tePassword.StyleController = this.lcMain;
            this.tePassword.TabIndex = 5;
            // 
            // teLogin
            // 
            this.teLogin.Location = new System.Drawing.Point(34, 21);
            this.teLogin.Name = "teLogin";
            this.teLogin.Properties.NullValuePrompt = "     Введите логин...";
            this.teLogin.Properties.NullValuePromptShowForEmptyValue = true;
            this.teLogin.Size = new System.Drawing.Size(288, 22);
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
            this.lciCancel});
            this.lcgMain.LayoutMode = DevExpress.XtraLayout.Utils.LayoutMode.Table;
            this.lcgMain.Location = new System.Drawing.Point(0, 0);
            this.lcgMain.Name = "lcgMain";
            this.lcgMain.OptionsTableLayoutGroup.AutoSizeDefaultDefinitionLength = 50;
            columnDefinition1.SizeType = System.Windows.Forms.SizeType.Percent;
            columnDefinition1.Width = 6D;
            columnDefinition2.SizeType = System.Windows.Forms.SizeType.Percent;
            columnDefinition2.Width = 23D;
            columnDefinition3.SizeType = System.Windows.Forms.SizeType.Percent;
            columnDefinition3.Width = 42D;
            columnDefinition4.SizeType = System.Windows.Forms.SizeType.Percent;
            columnDefinition4.Width = 23D;
            columnDefinition5.SizeType = System.Windows.Forms.SizeType.Percent;
            columnDefinition5.Width = 6D;
            this.lcgMain.OptionsTableLayoutGroup.ColumnDefinitions.AddRange(new DevExpress.XtraLayout.ColumnDefinition[] {
            columnDefinition1,
            columnDefinition2,
            columnDefinition3,
            columnDefinition4,
            columnDefinition5});
            rowDefinition1.Height = 6D;
            rowDefinition1.SizeType = System.Windows.Forms.SizeType.Absolute;
            rowDefinition2.Height = 32D;
            rowDefinition2.SizeType = System.Windows.Forms.SizeType.Absolute;
            rowDefinition3.Height = 32D;
            rowDefinition3.SizeType = System.Windows.Forms.SizeType.Absolute;
            rowDefinition4.Height = 32D;
            rowDefinition4.SizeType = System.Windows.Forms.SizeType.Absolute;
            rowDefinition5.Height = 32D;
            rowDefinition5.SizeType = System.Windows.Forms.SizeType.Absolute;
            rowDefinition6.Height = 6D;
            rowDefinition6.SizeType = System.Windows.Forms.SizeType.Absolute;
            this.lcgMain.OptionsTableLayoutGroup.RowDefinitions.AddRange(new DevExpress.XtraLayout.RowDefinition[] {
            rowDefinition1,
            rowDefinition2,
            rowDefinition3,
            rowDefinition4,
            rowDefinition5,
            rowDefinition6});
            this.lcgMain.Size = new System.Drawing.Size(357, 160);
            this.lcgMain.TextVisible = false;
            // 
            // lciLogin
            // 
            this.lciLogin.Control = this.teLogin;
            this.lciLogin.Location = new System.Drawing.Point(19, 6);
            this.lciLogin.Name = "lciLogin";
            this.lciLogin.OptionsTableLayoutItem.ColumnIndex = 1;
            this.lciLogin.OptionsTableLayoutItem.ColumnSpan = 3;
            this.lciLogin.OptionsTableLayoutItem.RowIndex = 1;
            this.lciLogin.Padding = new DevExpress.XtraLayout.Utils.Padding(5, 5, 5, 5);
            this.lciLogin.Size = new System.Drawing.Size(298, 32);
            this.lciLogin.TextSize = new System.Drawing.Size(0, 0);
            this.lciLogin.TextVisible = false;
            // 
            // lciPassword
            // 
            this.lciPassword.Control = this.tePassword;
            this.lciPassword.Location = new System.Drawing.Point(19, 38);
            this.lciPassword.Name = "lciPassword";
            this.lciPassword.OptionsTableLayoutItem.ColumnIndex = 1;
            this.lciPassword.OptionsTableLayoutItem.ColumnSpan = 3;
            this.lciPassword.OptionsTableLayoutItem.RowIndex = 2;
            this.lciPassword.Padding = new DevExpress.XtraLayout.Utils.Padding(5, 5, 5, 5);
            this.lciPassword.Size = new System.Drawing.Size(298, 32);
            this.lciPassword.TextSize = new System.Drawing.Size(0, 0);
            this.lciPassword.TextVisible = false;
            // 
            // lciEnter
            // 
            this.lciEnter.Control = this.btnEnter;
            this.lciEnter.Location = new System.Drawing.Point(97, 70);
            this.lciEnter.MaxSize = new System.Drawing.Size(0, 38);
            this.lciEnter.MinSize = new System.Drawing.Size(68, 38);
            this.lciEnter.Name = "lciEnter";
            this.lciEnter.OptionsTableLayoutItem.ColumnIndex = 2;
            this.lciEnter.OptionsTableLayoutItem.RowIndex = 3;
            this.lciEnter.Padding = new DevExpress.XtraLayout.Utils.Padding(5, 5, 5, 5);
            this.lciEnter.Size = new System.Drawing.Size(142, 32);
            this.lciEnter.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.lciEnter.TextSize = new System.Drawing.Size(0, 0);
            this.lciEnter.TextVisible = false;
            // 
            // lciCancel
            // 
            this.lciCancel.Control = this.btnCancel;
            this.lciCancel.Location = new System.Drawing.Point(97, 102);
            this.lciCancel.MaxSize = new System.Drawing.Size(0, 38);
            this.lciCancel.MinSize = new System.Drawing.Size(85, 38);
            this.lciCancel.Name = "lciCancel";
            this.lciCancel.OptionsTableLayoutItem.ColumnIndex = 2;
            this.lciCancel.OptionsTableLayoutItem.RowIndex = 4;
            this.lciCancel.Padding = new DevExpress.XtraLayout.Utils.Padding(5, 5, 5, 5);
            this.lciCancel.Size = new System.Drawing.Size(142, 32);
            this.lciCancel.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.lciCancel.TextSize = new System.Drawing.Size(0, 0);
            this.lciCancel.TextVisible = false;
            // 
            // frmStart
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(357, 160);
            this.Controls.Add(this.lcMain);
            this.FormBorderEffect = DevExpress.XtraEditors.FormBorderEffect.Glow;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(3);
            this.Name = "frmStart";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Почтовый бизнес-клиент";
            ((System.ComponentModel.ISupportInitialize)(this.lcMain)).EndInit();
            this.lcMain.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.tePassword.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.teLogin.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lcgMain)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciLogin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciPassword)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciEnter)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciCancel)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
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
    }
}

