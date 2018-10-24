namespace FredroClient
{
    partial class frmStart
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
            DevExpress.XtraLayout.ColumnDefinition columnDefinition4 = new DevExpress.XtraLayout.ColumnDefinition();
            DevExpress.XtraLayout.ColumnDefinition columnDefinition5 = new DevExpress.XtraLayout.ColumnDefinition();
            DevExpress.XtraLayout.RowDefinition rowDefinition1 = new DevExpress.XtraLayout.RowDefinition();
            DevExpress.XtraLayout.RowDefinition rowDefinition2 = new DevExpress.XtraLayout.RowDefinition();
            DevExpress.XtraLayout.RowDefinition rowDefinition3 = new DevExpress.XtraLayout.RowDefinition();
            DevExpress.XtraLayout.RowDefinition rowDefinition4 = new DevExpress.XtraLayout.RowDefinition();
            DevExpress.XtraLayout.RowDefinition rowDefinition5 = new DevExpress.XtraLayout.RowDefinition();
            DevExpress.XtraLayout.RowDefinition rowDefinition6 = new DevExpress.XtraLayout.RowDefinition();
            DevExpress.XtraLayout.RowDefinition rowDefinition7 = new DevExpress.XtraLayout.RowDefinition();
            this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.lcMain = new DevExpress.XtraLayout.LayoutControl();
            this.lcgMain = new DevExpress.XtraLayout.LayoutControlGroup();
            this.teLogin = new DevExpress.XtraEditors.TextEdit();
            this.lciLogin = new DevExpress.XtraLayout.LayoutControlItem();
            this.tePassword = new DevExpress.XtraEditors.TextEdit();
            this.lciPassword = new DevExpress.XtraLayout.LayoutControlItem();
            this.sleHostname = new DevExpress.XtraEditors.SearchLookUpEdit();
            this.lciHostname = new DevExpress.XtraLayout.LayoutControlItem();
            this.searchLookUpEdit1View = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.btnEnter = new DevExpress.XtraEditors.SimpleButton();
            this.lciEnter = new DevExpress.XtraLayout.LayoutControlItem();
            this.btnCancel = new DevExpress.XtraEditors.SimpleButton();
            this.lciCancel = new DevExpress.XtraLayout.LayoutControlItem();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lcMain)).BeginInit();
            this.lcMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lcgMain)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.teLogin.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciLogin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tePassword.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciPassword)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sleHostname.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciHostname)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchLookUpEdit1View)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciEnter)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciCancel)).BeginInit();
            this.SuspendLayout();
            // 
            // layoutControl1
            // 
            this.layoutControl1.Location = new System.Drawing.Point(320, 136);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.Root = this.layoutControlGroup1;
            this.layoutControl1.Size = new System.Drawing.Size(180, 120);
            this.layoutControl1.TabIndex = 0;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // layoutControlGroup1
            // 
            this.layoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.layoutControlGroup1.GroupBordersVisible = false;
            this.layoutControlGroup1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup1.Name = "layoutControlGroup1";
            this.layoutControlGroup1.Size = new System.Drawing.Size(180, 120);
            this.layoutControlGroup1.TextVisible = false;
            // 
            // lcMain
            // 
            this.lcMain.Appearance.Control.Font = new System.Drawing.Font("Tahoma", 10F);
            this.lcMain.Appearance.Control.Options.UseFont = true;
            this.lcMain.Controls.Add(this.btnCancel);
            this.lcMain.Controls.Add(this.btnEnter);
            this.lcMain.Controls.Add(this.sleHostname);
            this.lcMain.Controls.Add(this.tePassword);
            this.lcMain.Controls.Add(this.teLogin);
            this.lcMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lcMain.Location = new System.Drawing.Point(0, 0);
            this.lcMain.Name = "lcMain";
            this.lcMain.Root = this.lcgMain;
            this.lcMain.Size = new System.Drawing.Size(382, 273);
            this.lcMain.TabIndex = 1;
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
            this.lciHostname,
            this.lciEnter,
            this.lciCancel});
            this.lcgMain.LayoutMode = DevExpress.XtraLayout.Utils.LayoutMode.Table;
            this.lcgMain.Location = new System.Drawing.Point(0, 0);
            this.lcgMain.Name = "lcgMain";
            this.lcgMain.OptionsTableLayoutGroup.AutoSizeDefaultDefinitionLength = 50;
            columnDefinition1.SizeType = System.Windows.Forms.SizeType.Percent;
            columnDefinition1.Width = 10D;
            columnDefinition2.SizeType = System.Windows.Forms.SizeType.Percent;
            columnDefinition2.Width = 10D;
            columnDefinition3.SizeType = System.Windows.Forms.SizeType.Percent;
            columnDefinition3.Width = 60D;
            columnDefinition4.SizeType = System.Windows.Forms.SizeType.Percent;
            columnDefinition4.Width = 10D;
            columnDefinition5.SizeType = System.Windows.Forms.SizeType.Percent;
            columnDefinition5.Width = 10D;
            this.lcgMain.OptionsTableLayoutGroup.ColumnDefinitions.AddRange(new DevExpress.XtraLayout.ColumnDefinition[] {
            columnDefinition1,
            columnDefinition2,
            columnDefinition3,
            columnDefinition4,
            columnDefinition5});
            rowDefinition1.Height = 50D;
            rowDefinition1.SizeType = System.Windows.Forms.SizeType.Percent;
            rowDefinition2.Height = 38D;
            rowDefinition2.SizeType = System.Windows.Forms.SizeType.AutoSize;
            rowDefinition3.Height = 38D;
            rowDefinition3.SizeType = System.Windows.Forms.SizeType.AutoSize;
            rowDefinition4.Height = 38D;
            rowDefinition4.SizeType = System.Windows.Forms.SizeType.AutoSize;
            rowDefinition5.Height = 38D;
            rowDefinition5.SizeType = System.Windows.Forms.SizeType.AutoSize;
            rowDefinition6.Height = 38D;
            rowDefinition6.SizeType = System.Windows.Forms.SizeType.AutoSize;
            rowDefinition7.Height = 50D;
            rowDefinition7.SizeType = System.Windows.Forms.SizeType.Percent;
            this.lcgMain.OptionsTableLayoutGroup.RowDefinitions.AddRange(new DevExpress.XtraLayout.RowDefinition[] {
            rowDefinition1,
            rowDefinition2,
            rowDefinition3,
            rowDefinition4,
            rowDefinition5,
            rowDefinition6,
            rowDefinition7});
            this.lcgMain.Size = new System.Drawing.Size(382, 273);
            this.lcgMain.TextVisible = false;
            // 
            // teLogin
            // 
            this.teLogin.Location = new System.Drawing.Point(52, 84);
            this.teLogin.Name = "teLogin";
            this.teLogin.Properties.NullValuePrompt = "Введите логин...";
            this.teLogin.Properties.NullValuePromptShowForEmptyValue = true;
            this.teLogin.Size = new System.Drawing.Size(277, 28);
            this.teLogin.StyleController = this.lcMain;
            this.teLogin.TabIndex = 4;
            // 
            // lciLogin
            // 
            this.lciLogin.Control = this.teLogin;
            this.lciLogin.Location = new System.Drawing.Point(35, 67);
            this.lciLogin.Name = "lciLogin";
            this.lciLogin.OptionsTableLayoutItem.ColumnIndex = 1;
            this.lciLogin.OptionsTableLayoutItem.ColumnSpan = 3;
            this.lciLogin.OptionsTableLayoutItem.RowIndex = 2;
            this.lciLogin.Padding = new DevExpress.XtraLayout.Utils.Padding(5, 5, 5, 5);
            this.lciLogin.Size = new System.Drawing.Size(287, 38);
            this.lciLogin.TextSize = new System.Drawing.Size(0, 0);
            this.lciLogin.TextVisible = false;
            // 
            // tePassword
            // 
            this.tePassword.Location = new System.Drawing.Point(52, 122);
            this.tePassword.Name = "tePassword";
            this.tePassword.Properties.NullValuePrompt = "Введите пароль...";
            this.tePassword.Properties.NullValuePromptShowForEmptyValue = true;
            this.tePassword.Properties.PasswordChar = '*';
            this.tePassword.Size = new System.Drawing.Size(277, 28);
            this.tePassword.StyleController = this.lcMain;
            this.tePassword.TabIndex = 5;
            // 
            // lciPassword
            // 
            this.lciPassword.Control = this.tePassword;
            this.lciPassword.Location = new System.Drawing.Point(35, 105);
            this.lciPassword.Name = "lciPassword";
            this.lciPassword.OptionsTableLayoutItem.ColumnIndex = 1;
            this.lciPassword.OptionsTableLayoutItem.ColumnSpan = 3;
            this.lciPassword.OptionsTableLayoutItem.RowIndex = 3;
            this.lciPassword.Padding = new DevExpress.XtraLayout.Utils.Padding(5, 5, 5, 5);
            this.lciPassword.Size = new System.Drawing.Size(287, 38);
            this.lciPassword.TextSize = new System.Drawing.Size(0, 0);
            this.lciPassword.TextVisible = false;
            // 
            // sleHostname
            // 
            this.sleHostname.EditValue = "Выберите почтовый сервер";
            this.sleHostname.Location = new System.Drawing.Point(52, 46);
            this.sleHostname.Name = "sleHostname";
            this.sleHostname.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.sleHostname.Properties.NullText = "";
            this.sleHostname.Properties.NullValuePrompt = "Выберите почтовый сервер...";
            this.sleHostname.Properties.NullValuePromptShowForEmptyValue = true;
            this.sleHostname.Properties.View = this.searchLookUpEdit1View;
            this.sleHostname.Size = new System.Drawing.Size(277, 28);
            this.sleHostname.StyleController = this.lcMain;
            this.sleHostname.TabIndex = 6;
            // 
            // lciHostname
            // 
            this.lciHostname.Control = this.sleHostname;
            this.lciHostname.Location = new System.Drawing.Point(35, 29);
            this.lciHostname.Name = "lciHostname";
            this.lciHostname.OptionsTableLayoutItem.ColumnIndex = 1;
            this.lciHostname.OptionsTableLayoutItem.ColumnSpan = 3;
            this.lciHostname.OptionsTableLayoutItem.RowIndex = 1;
            this.lciHostname.Padding = new DevExpress.XtraLayout.Utils.Padding(5, 5, 5, 5);
            this.lciHostname.Size = new System.Drawing.Size(287, 38);
            this.lciHostname.TextSize = new System.Drawing.Size(0, 0);
            this.lciHostname.TextVisible = false;
            // 
            // searchLookUpEdit1View
            // 
            this.searchLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.searchLookUpEdit1View.Name = "searchLookUpEdit1View";
            this.searchLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.searchLookUpEdit1View.OptionsView.ShowGroupPanel = false;
            // 
            // btnEnter
            // 
            this.btnEnter.Location = new System.Drawing.Point(88, 160);
            this.btnEnter.Name = "btnEnter";
            this.btnEnter.Size = new System.Drawing.Size(205, 28);
            this.btnEnter.StyleController = this.lcMain;
            this.btnEnter.TabIndex = 7;
            this.btnEnter.Text = "Войти";
            // 
            // lciEnter
            // 
            this.lciEnter.Control = this.btnEnter;
            this.lciEnter.Location = new System.Drawing.Point(71, 143);
            this.lciEnter.Name = "lciEnter";
            this.lciEnter.OptionsTableLayoutItem.ColumnIndex = 2;
            this.lciEnter.OptionsTableLayoutItem.RowIndex = 4;
            this.lciEnter.Padding = new DevExpress.XtraLayout.Utils.Padding(5, 5, 5, 5);
            this.lciEnter.Size = new System.Drawing.Size(215, 38);
            this.lciEnter.TextSize = new System.Drawing.Size(0, 0);
            this.lciEnter.TextVisible = false;
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(88, 198);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(205, 28);
            this.btnCancel.StyleController = this.lcMain;
            this.btnCancel.TabIndex = 8;
            this.btnCancel.Text = "Закрыть";
            // 
            // lciCancel
            // 
            this.lciCancel.Control = this.btnCancel;
            this.lciCancel.Location = new System.Drawing.Point(71, 181);
            this.lciCancel.Name = "lciCancel";
            this.lciCancel.OptionsTableLayoutItem.ColumnIndex = 2;
            this.lciCancel.OptionsTableLayoutItem.RowIndex = 5;
            this.lciCancel.Padding = new DevExpress.XtraLayout.Utils.Padding(5, 5, 5, 5);
            this.lciCancel.Size = new System.Drawing.Size(215, 38);
            this.lciCancel.TextSize = new System.Drawing.Size(0, 0);
            this.lciCancel.TextVisible = false;
            // 
            // frmStart
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(382, 273);
            this.Controls.Add(this.lcMain);
            this.Controls.Add(this.layoutControl1);
            this.Name = "frmStart";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Вход";
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lcMain)).EndInit();
            this.lcMain.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.lcgMain)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.teLogin.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciLogin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tePassword.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciPassword)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sleHostname.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciHostname)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchLookUpEdit1View)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciEnter)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciCancel)).EndInit();
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
        private DevExpress.XtraEditors.SearchLookUpEdit sleHostname;
        private DevExpress.XtraGrid.Views.Grid.GridView searchLookUpEdit1View;
        private DevExpress.XtraLayout.LayoutControlItem lciHostname;
        private DevExpress.XtraEditors.SimpleButton btnEnter;
        private DevExpress.XtraLayout.LayoutControlItem lciEnter;
        private DevExpress.XtraEditors.SimpleButton btnCancel;
        private DevExpress.XtraLayout.LayoutControlItem lciCancel;
    }
}

