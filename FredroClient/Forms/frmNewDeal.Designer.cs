namespace FredroClient.Forms
{
    partial class frmNewDeal
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
            this.btnClose = new DevExpress.XtraEditors.SimpleButton();
            this.btnSave = new DevExpress.XtraEditors.SimpleButton();
            this.description = new DevExpress.XtraEditors.MemoEdit();
            this.route = new DevExpress.XtraEditors.MemoEdit();
            this.performer = new DevExpress.XtraEditors.SearchLookUpEdit();
            this.searchLookUpEdit3View = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.vehicle = new DevExpress.XtraEditors.SearchLookUpEdit();
            this.searchLookUpEdit2View = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.customer = new DevExpress.XtraEditors.SearchLookUpEdit();
            this.searchLookUpEdit1View = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.start = new DevExpress.XtraEditors.DateEdit();
            this.end = new DevExpress.XtraEditors.DateEdit();
            this.lcgMain = new DevExpress.XtraLayout.LayoutControlGroup();
            this.lciEnd = new DevExpress.XtraLayout.LayoutControlItem();
            this.lciStart = new DevExpress.XtraLayout.LayoutControlItem();
            this.lciCustomer = new DevExpress.XtraLayout.LayoutControlItem();
            this.lciVehicle = new DevExpress.XtraLayout.LayoutControlItem();
            this.lciRoute = new DevExpress.XtraLayout.LayoutControlItem();
            this.lciDescription = new DevExpress.XtraLayout.LayoutControlItem();
            this.lciPerformer = new DevExpress.XtraLayout.LayoutControlItem();
            this.lciClose = new DevExpress.XtraLayout.LayoutControlItem();
            this.lciSave = new DevExpress.XtraLayout.LayoutControlItem();
            ((System.ComponentModel.ISupportInitialize)(this.lcMain)).BeginInit();
            this.lcMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.description.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.route.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.performer.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchLookUpEdit3View)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vehicle.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchLookUpEdit2View)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.customer.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchLookUpEdit1View)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.start.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.start.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.end.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.end.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lcgMain)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciEnd)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciStart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciCustomer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciVehicle)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciRoute)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciDescription)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciPerformer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciClose)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciSave)).BeginInit();
            this.SuspendLayout();
            // 
            // lcMain
            // 
            this.lcMain.Appearance.Control.Font = new System.Drawing.Font("Tahoma", 10F);
            this.lcMain.Appearance.Control.Options.UseFont = true;
            this.lcMain.Controls.Add(this.btnClose);
            this.lcMain.Controls.Add(this.btnSave);
            this.lcMain.Controls.Add(this.description);
            this.lcMain.Controls.Add(this.route);
            this.lcMain.Controls.Add(this.performer);
            this.lcMain.Controls.Add(this.vehicle);
            this.lcMain.Controls.Add(this.customer);
            this.lcMain.Controls.Add(this.start);
            this.lcMain.Controls.Add(this.end);
            this.lcMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lcMain.Location = new System.Drawing.Point(0, 0);
            this.lcMain.Name = "lcMain";
            this.lcMain.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = new System.Drawing.Rectangle(439, 78, 250, 350);
            this.lcMain.Root = this.lcgMain;
            this.lcMain.Size = new System.Drawing.Size(384, 294);
            this.lcMain.TabIndex = 0;
            this.lcMain.Text = "layoutControl1";
            // 
            // btnClose
            // 
            this.btnClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClose.Location = new System.Drawing.Point(193, 259);
            this.btnClose.Name = "btnClose";
            this.btnClose.ShowFocusRectangle = DevExpress.Utils.DefaultBoolean.False;
            this.btnClose.Size = new System.Drawing.Size(184, 28);
            this.btnClose.StyleController = this.lcMain;
            this.btnClose.TabIndex = 9;
            this.btnClose.Text = "Закрыть";
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnSave
            // 
            this.btnSave.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSave.Location = new System.Drawing.Point(7, 259);
            this.btnSave.Name = "btnSave";
            this.btnSave.ShowFocusRectangle = DevExpress.Utils.DefaultBoolean.False;
            this.btnSave.Size = new System.Drawing.Size(182, 28);
            this.btnSave.StyleController = this.lcMain;
            this.btnSave.TabIndex = 8;
            this.btnSave.Text = "Сохранить";
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // description
            // 
            this.description.EnterMoveNextControl = true;
            this.description.Location = new System.Drawing.Point(86, 197);
            this.description.Name = "description";
            this.description.Properties.NullValuePrompt = "Описание, комментарий...";
            this.description.Properties.NullValuePromptShowForEmptyValue = true;
            this.description.Properties.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.description.Size = new System.Drawing.Size(291, 58);
            this.description.StyleController = this.lcMain;
            this.description.TabIndex = 7;
            // 
            // route
            // 
            this.route.EnterMoveNextControl = true;
            this.route.Location = new System.Drawing.Point(86, 137);
            this.route.Name = "route";
            this.route.Properties.NullValuePrompt = "Маршрут...";
            this.route.Properties.NullValuePromptShowForEmptyValue = true;
            this.route.Properties.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.route.Size = new System.Drawing.Size(291, 56);
            this.route.StyleController = this.lcMain;
            this.route.TabIndex = 6;
            // 
            // performer
            // 
            this.performer.EnterMoveNextControl = true;
            this.performer.Location = new System.Drawing.Point(86, 85);
            this.performer.Name = "performer";
            this.performer.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.performer.Properties.NullText = "";
            this.performer.Properties.NullValuePrompt = "Исполнитель...";
            this.performer.Properties.NullValuePromptShowForEmptyValue = true;
            this.performer.Properties.View = this.searchLookUpEdit3View;
            this.performer.Size = new System.Drawing.Size(291, 22);
            this.performer.StyleController = this.lcMain;
            this.performer.TabIndex = 4;
            // 
            // searchLookUpEdit3View
            // 
            this.searchLookUpEdit3View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.searchLookUpEdit3View.Name = "searchLookUpEdit3View";
            this.searchLookUpEdit3View.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.searchLookUpEdit3View.OptionsView.ShowGroupPanel = false;
            // 
            // vehicle
            // 
            this.vehicle.EnterMoveNextControl = true;
            this.vehicle.Location = new System.Drawing.Point(86, 111);
            this.vehicle.Name = "vehicle";
            this.vehicle.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.vehicle.Properties.NullText = "";
            this.vehicle.Properties.NullValuePrompt = "Транспортное средство...";
            this.vehicle.Properties.NullValuePromptShowForEmptyValue = true;
            this.vehicle.Properties.View = this.searchLookUpEdit2View;
            this.vehicle.Size = new System.Drawing.Size(291, 22);
            this.vehicle.StyleController = this.lcMain;
            this.vehicle.TabIndex = 5;
            // 
            // searchLookUpEdit2View
            // 
            this.searchLookUpEdit2View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.searchLookUpEdit2View.Name = "searchLookUpEdit2View";
            this.searchLookUpEdit2View.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.searchLookUpEdit2View.OptionsView.ShowGroupPanel = false;
            // 
            // customer
            // 
            this.customer.EnterMoveNextControl = true;
            this.customer.Location = new System.Drawing.Point(86, 59);
            this.customer.Name = "customer";
            this.customer.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.customer.Properties.NullText = "";
            this.customer.Properties.NullValuePrompt = "Заказчик...";
            this.customer.Properties.NullValuePromptShowForEmptyValue = true;
            this.customer.Properties.View = this.searchLookUpEdit1View;
            this.customer.Size = new System.Drawing.Size(291, 22);
            this.customer.StyleController = this.lcMain;
            this.customer.TabIndex = 3;
            // 
            // searchLookUpEdit1View
            // 
            this.searchLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.searchLookUpEdit1View.Name = "searchLookUpEdit1View";
            this.searchLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.searchLookUpEdit1View.OptionsView.ShowGroupPanel = false;
            // 
            // start
            // 
            this.start.EditValue = null;
            this.start.EnterMoveNextControl = true;
            this.start.Location = new System.Drawing.Point(86, 7);
            this.start.Name = "start";
            this.start.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.start.Properties.CalendarTimeEditing = DevExpress.Utils.DefaultBoolean.True;
            this.start.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.start.Properties.DisplayFormat.FormatString = "f";
            this.start.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.start.Properties.EditFormat.FormatString = "f";
            this.start.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.start.Properties.Mask.EditMask = "f";
            this.start.Properties.NullValuePrompt = "Дата и время начала...";
            this.start.Properties.NullValuePromptShowForEmptyValue = true;
            this.start.Size = new System.Drawing.Size(291, 22);
            this.start.StyleController = this.lcMain;
            this.start.TabIndex = 1;
            // 
            // end
            // 
            this.end.EditValue = null;
            this.end.EnterMoveNextControl = true;
            this.end.Location = new System.Drawing.Point(86, 33);
            this.end.Name = "end";
            this.end.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.end.Properties.CalendarTimeEditing = DevExpress.Utils.DefaultBoolean.True;
            this.end.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.end.Properties.DisplayFormat.FormatString = "f";
            this.end.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.end.Properties.EditFormat.FormatString = "f";
            this.end.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.end.Properties.Mask.EditMask = "f";
            this.end.Properties.NullValuePrompt = "Дата и время окончания...";
            this.end.Properties.NullValuePromptShowForEmptyValue = true;
            this.end.Size = new System.Drawing.Size(291, 22);
            this.end.StyleController = this.lcMain;
            this.end.TabIndex = 2;
            // 
            // lcgMain
            // 
            this.lcgMain.AppearanceItemCaption.Font = new System.Drawing.Font("Tahoma", 10F);
            this.lcgMain.AppearanceItemCaption.Options.UseFont = true;
            this.lcgMain.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.lcgMain.GroupBordersVisible = false;
            this.lcgMain.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.lciEnd,
            this.lciStart,
            this.lciCustomer,
            this.lciVehicle,
            this.lciRoute,
            this.lciDescription,
            this.lciPerformer,
            this.lciClose,
            this.lciSave});
            this.lcgMain.Location = new System.Drawing.Point(0, 0);
            this.lcgMain.Name = "Root";
            this.lcgMain.Padding = new DevExpress.XtraLayout.Utils.Padding(5, 5, 5, 5);
            this.lcgMain.Size = new System.Drawing.Size(384, 294);
            this.lcgMain.TextVisible = false;
            // 
            // lciEnd
            // 
            this.lciEnd.Control = this.end;
            this.lciEnd.Location = new System.Drawing.Point(0, 26);
            this.lciEnd.Name = "lciEnd";
            this.lciEnd.Size = new System.Drawing.Size(374, 26);
            this.lciEnd.Text = "Окончание";
            this.lciEnd.TextSize = new System.Drawing.Size(76, 16);
            // 
            // lciStart
            // 
            this.lciStart.Control = this.start;
            this.lciStart.Location = new System.Drawing.Point(0, 0);
            this.lciStart.Name = "lciStart";
            this.lciStart.Size = new System.Drawing.Size(374, 26);
            this.lciStart.Text = "Начало";
            this.lciStart.TextSize = new System.Drawing.Size(76, 16);
            // 
            // lciCustomer
            // 
            this.lciCustomer.Control = this.customer;
            this.lciCustomer.Location = new System.Drawing.Point(0, 52);
            this.lciCustomer.Name = "lciCustomer";
            this.lciCustomer.Size = new System.Drawing.Size(374, 26);
            this.lciCustomer.Text = "Заказчик";
            this.lciCustomer.TextSize = new System.Drawing.Size(76, 16);
            // 
            // lciVehicle
            // 
            this.lciVehicle.Control = this.vehicle;
            this.lciVehicle.Location = new System.Drawing.Point(0, 104);
            this.lciVehicle.Name = "lciVehicle";
            this.lciVehicle.Size = new System.Drawing.Size(374, 26);
            this.lciVehicle.Text = "ТС";
            this.lciVehicle.TextSize = new System.Drawing.Size(76, 16);
            // 
            // lciRoute
            // 
            this.lciRoute.Control = this.route;
            this.lciRoute.Location = new System.Drawing.Point(0, 130);
            this.lciRoute.MaxSize = new System.Drawing.Size(0, 60);
            this.lciRoute.MinSize = new System.Drawing.Size(80, 60);
            this.lciRoute.Name = "lciRoute";
            this.lciRoute.Size = new System.Drawing.Size(374, 60);
            this.lciRoute.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.lciRoute.Text = "Маршрут";
            this.lciRoute.TextSize = new System.Drawing.Size(76, 16);
            // 
            // lciDescription
            // 
            this.lciDescription.Control = this.description;
            this.lciDescription.Location = new System.Drawing.Point(0, 190);
            this.lciDescription.Name = "lciDescription";
            this.lciDescription.Size = new System.Drawing.Size(374, 62);
            this.lciDescription.Text = "Описание";
            this.lciDescription.TextSize = new System.Drawing.Size(76, 16);
            // 
            // lciPerformer
            // 
            this.lciPerformer.Control = this.performer;
            this.lciPerformer.Location = new System.Drawing.Point(0, 78);
            this.lciPerformer.Name = "lciPerformer";
            this.lciPerformer.Size = new System.Drawing.Size(374, 26);
            this.lciPerformer.Text = "Исполнитель";
            this.lciPerformer.TextSize = new System.Drawing.Size(76, 16);
            // 
            // lciClose
            // 
            this.lciClose.Control = this.btnClose;
            this.lciClose.Location = new System.Drawing.Point(186, 252);
            this.lciClose.MaxSize = new System.Drawing.Size(0, 32);
            this.lciClose.MinSize = new System.Drawing.Size(64, 32);
            this.lciClose.Name = "lciClose";
            this.lciClose.Size = new System.Drawing.Size(188, 32);
            this.lciClose.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.lciClose.TextSize = new System.Drawing.Size(0, 0);
            this.lciClose.TextVisible = false;
            // 
            // lciSave
            // 
            this.lciSave.Control = this.btnSave;
            this.lciSave.Location = new System.Drawing.Point(0, 252);
            this.lciSave.MaxSize = new System.Drawing.Size(0, 32);
            this.lciSave.MinSize = new System.Drawing.Size(77, 32);
            this.lciSave.Name = "lciSave";
            this.lciSave.Size = new System.Drawing.Size(186, 32);
            this.lciSave.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.lciSave.TextSize = new System.Drawing.Size(0, 0);
            this.lciSave.TextVisible = false;
            // 
            // frmNewDeal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 294);
            this.Controls.Add(this.lcMain);
            this.Margin = new System.Windows.Forms.Padding(3);
            this.MaximumSize = new System.Drawing.Size(466, 409);
            this.MinimumSize = new System.Drawing.Size(400, 333);
            this.Name = "frmNewDeal";
            this.Text = "Новая заявка(сделка)";
            ((System.ComponentModel.ISupportInitialize)(this.lcMain)).EndInit();
            this.lcMain.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.description.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.route.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.performer.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchLookUpEdit3View)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vehicle.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchLookUpEdit2View)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.customer.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchLookUpEdit1View)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.start.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.start.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.end.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.end.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lcgMain)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciEnd)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciStart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciCustomer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciVehicle)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciRoute)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciDescription)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciPerformer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciClose)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciSave)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraLayout.LayoutControl lcMain;
        private DevExpress.XtraLayout.LayoutControlGroup lcgMain;
        private DevExpress.XtraEditors.DateEdit start;
        private DevExpress.XtraEditors.DateEdit end;
        private DevExpress.XtraLayout.LayoutControlItem lciEnd;
        private DevExpress.XtraLayout.LayoutControlItem lciStart;
        private DevExpress.XtraEditors.SearchLookUpEdit performer;
        private DevExpress.XtraGrid.Views.Grid.GridView searchLookUpEdit3View;
        private DevExpress.XtraEditors.SearchLookUpEdit vehicle;
        private DevExpress.XtraGrid.Views.Grid.GridView searchLookUpEdit2View;
        private DevExpress.XtraEditors.SearchLookUpEdit customer;
        private DevExpress.XtraGrid.Views.Grid.GridView searchLookUpEdit1View;
        private DevExpress.XtraLayout.LayoutControlItem lciCustomer;
        private DevExpress.XtraLayout.LayoutControlItem lciVehicle;
        private DevExpress.XtraLayout.LayoutControlItem lciPerformer;
        private DevExpress.XtraEditors.MemoEdit description;
        private DevExpress.XtraEditors.MemoEdit route;
        private DevExpress.XtraLayout.LayoutControlItem lciRoute;
        private DevExpress.XtraLayout.LayoutControlItem lciDescription;
        private DevExpress.XtraEditors.SimpleButton btnClose;
        private DevExpress.XtraEditors.SimpleButton btnSave;
        private DevExpress.XtraLayout.LayoutControlItem lciClose;
        private DevExpress.XtraLayout.LayoutControlItem lciSave;
    }
}