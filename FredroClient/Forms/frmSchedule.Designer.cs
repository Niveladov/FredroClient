namespace FredroClient.Forms
{
    partial class frmSchedule
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
            DevExpress.XtraScheduler.TimeRuler timeRuler1 = new DevExpress.XtraScheduler.TimeRuler();
            DevExpress.XtraScheduler.TimeRuler timeRuler2 = new DevExpress.XtraScheduler.TimeRuler();
            DevExpress.XtraScheduler.TimeScaleYear timeScaleYear1 = new DevExpress.XtraScheduler.TimeScaleYear();
            DevExpress.XtraScheduler.TimeScaleQuarter timeScaleQuarter1 = new DevExpress.XtraScheduler.TimeScaleQuarter();
            DevExpress.XtraScheduler.TimeScaleMonth timeScaleMonth1 = new DevExpress.XtraScheduler.TimeScaleMonth();
            DevExpress.XtraScheduler.TimeScaleWeek timeScaleWeek1 = new DevExpress.XtraScheduler.TimeScaleWeek();
            DevExpress.XtraScheduler.TimeScaleDay timeScaleDay1 = new DevExpress.XtraScheduler.TimeScaleDay();
            DevExpress.XtraScheduler.TimeScaleHour timeScaleHour1 = new DevExpress.XtraScheduler.TimeScaleHour();
            DevExpress.XtraScheduler.TimeScale15Minutes timeScale15Minutes1 = new DevExpress.XtraScheduler.TimeScale15Minutes();
            DevExpress.XtraScheduler.TimeRuler timeRuler3 = new DevExpress.XtraScheduler.TimeRuler();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSchedule));
            this.schedulerMain = new DevExpress.XtraScheduler.SchedulerControl();
            this.storageMain = new DevExpress.XtraScheduler.SchedulerStorage();
            this.splitVertical = new System.Windows.Forms.SplitContainer();
            this.resourcesTreeMain = new DevExpress.XtraScheduler.UI.ResourcesTree();
            this.resourceTreeColumn = new DevExpress.XtraScheduler.Native.ResourceTreeColumn();
            this.groupControlMain = new DevExpress.XtraEditors.GroupControl();
            this.splitHorizontal = new DevExpress.XtraEditors.SplitContainerControl();
            this.gcFreeDeals = new DevExpress.XtraGrid.GridControl();
            this.gvFreeDeals = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colDateStart = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDateEnd = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colRoute = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCustomerId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPerformerId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDescription = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.schedulerMain)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.storageMain)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitVertical)).BeginInit();
            this.splitVertical.Panel1.SuspendLayout();
            this.splitVertical.Panel2.SuspendLayout();
            this.splitVertical.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.resourcesTreeMain)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControlMain)).BeginInit();
            this.groupControlMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitHorizontal)).BeginInit();
            this.splitHorizontal.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gcFreeDeals)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvFreeDeals)).BeginInit();
            this.SuspendLayout();
            // 
            // schedulerMain
            // 
            this.schedulerMain.ActiveViewType = DevExpress.XtraScheduler.SchedulerViewType.Timeline;
            this.schedulerMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.schedulerMain.GroupType = DevExpress.XtraScheduler.SchedulerGroupType.Resource;
            this.schedulerMain.Location = new System.Drawing.Point(0, 0);
            this.schedulerMain.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.schedulerMain.Name = "schedulerMain";
            this.schedulerMain.Size = new System.Drawing.Size(791, 331);
            this.schedulerMain.Start = new System.DateTime(2018, 12, 10, 0, 0, 0, 0);
            this.schedulerMain.Storage = this.storageMain;
            this.schedulerMain.TabIndex = 0;
            this.schedulerMain.Text = "scMain";
            this.schedulerMain.Views.DayView.Enabled = false;
            this.schedulerMain.Views.DayView.TimeRulers.Add(timeRuler1);
            this.schedulerMain.Views.FullWeekView.TimeRulers.Add(timeRuler2);
            this.schedulerMain.Views.GanttView.Enabled = false;
            this.schedulerMain.Views.MonthView.Enabled = false;
            timeScaleYear1.Enabled = false;
            timeScaleQuarter1.Enabled = false;
            timeScaleMonth1.Enabled = false;
            timeScaleWeek1.Enabled = false;
            timeScale15Minutes1.Enabled = false;
            this.schedulerMain.Views.TimelineView.Scales.Add(timeScaleYear1);
            this.schedulerMain.Views.TimelineView.Scales.Add(timeScaleQuarter1);
            this.schedulerMain.Views.TimelineView.Scales.Add(timeScaleMonth1);
            this.schedulerMain.Views.TimelineView.Scales.Add(timeScaleWeek1);
            this.schedulerMain.Views.TimelineView.Scales.Add(timeScaleDay1);
            this.schedulerMain.Views.TimelineView.Scales.Add(timeScaleHour1);
            this.schedulerMain.Views.TimelineView.Scales.Add(timeScale15Minutes1);
            this.schedulerMain.Views.TimelineView.ShowResourceHeaders = false;
            this.schedulerMain.Views.WeekView.Enabled = false;
            this.schedulerMain.Views.WorkWeekView.Enabled = false;
            this.schedulerMain.Views.WorkWeekView.TimeRulers.Add(timeRuler3);
            // 
            // splitVertical
            // 
            this.splitVertical.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitVertical.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.splitVertical.Location = new System.Drawing.Point(0, 0);
            this.splitVertical.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.splitVertical.Name = "splitVertical";
            // 
            // splitVertical.Panel1
            // 
            this.splitVertical.Panel1.Controls.Add(this.resourcesTreeMain);
            this.splitVertical.Panel1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            // 
            // splitVertical.Panel2
            // 
            this.splitVertical.Panel2.Controls.Add(this.schedulerMain);
            this.splitVertical.Panel2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.splitVertical.Size = new System.Drawing.Size(998, 331);
            this.splitVertical.SplitterDistance = 204;
            this.splitVertical.SplitterWidth = 3;
            this.splitVertical.TabIndex = 1;
            // 
            // resourcesTreeMain
            // 
            this.resourcesTreeMain.Columns.AddRange(new DevExpress.XtraTreeList.Columns.TreeListColumn[] {
            this.resourceTreeColumn});
            this.resourcesTreeMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.resourcesTreeMain.KeyFieldName = "Id";
            this.resourcesTreeMain.Location = new System.Drawing.Point(0, 0);
            this.resourcesTreeMain.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.resourcesTreeMain.Name = "resourcesTreeMain";
            this.resourcesTreeMain.OptionsBehavior.Editable = false;
            this.resourcesTreeMain.OptionsBehavior.ReadOnly = true;
            this.resourcesTreeMain.ParentFieldName = "ParentId";
            this.resourcesTreeMain.PreviewFieldName = "Name";
            this.resourcesTreeMain.SchedulerControl = this.schedulerMain;
            this.resourcesTreeMain.Size = new System.Drawing.Size(204, 331);
            this.resourcesTreeMain.TabIndex = 0;
            // 
            // resourceTreeColumn
            // 
            this.resourceTreeColumn.Caption = "Транспортное средство";
            this.resourceTreeColumn.FieldName = "Name";
            this.resourceTreeColumn.ImageIndex = -10;
            this.resourceTreeColumn.Name = "resourceTreeColumn";
            this.resourceTreeColumn.OptionsColumn.AllowFocus = false;
            this.resourceTreeColumn.SortMode = DevExpress.XtraGrid.ColumnSortMode.DisplayText;
            this.resourceTreeColumn.SortOrder = System.Windows.Forms.SortOrder.Ascending;
            this.resourceTreeColumn.Visible = true;
            this.resourceTreeColumn.VisibleIndex = 0;
            // 
            // groupControlMain
            // 
            this.groupControlMain.AutoSize = true;
            this.groupControlMain.Controls.Add(this.splitHorizontal);
            this.groupControlMain.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.groupControlMain.CustomHeaderButtons.AddRange(new DevExpress.XtraEditors.ButtonPanel.IBaseButton[] {
            new DevExpress.XtraEditors.ButtonsPanelControl.GroupBoxButton("Button", null, -1, DevExpress.XtraEditors.ButtonPanel.ImageLocation.Default, DevExpress.XtraBars.Docking2010.ButtonStyle.PushButton, "", false, -1, false, null, false, false, true, null, null, -1),
            new DevExpress.XtraEditors.ButtonsPanelControl.GroupBoxButton("Button", null, -1, DevExpress.XtraEditors.ButtonPanel.ImageLocation.Default, DevExpress.XtraBars.Docking2010.ButtonStyle.PushButton, "", false, -1, false, null, false, false, true, null, null, -1),
            new DevExpress.XtraEditors.ButtonsPanelControl.GroupBoxButton("Назад", ((System.Drawing.Image)(resources.GetObject("groupControlMain.CustomHeaderButtons"))), false, true, "Назад"),
            new DevExpress.XtraEditors.ButtonsPanelControl.GroupBoxButton("На дату", ((System.Drawing.Image)(resources.GetObject("groupControlMain.CustomHeaderButtons1"))), false, true, "Перейти на дату"),
            new DevExpress.XtraEditors.ButtonsPanelControl.GroupBoxButton("На сегодня", ((System.Drawing.Image)(resources.GetObject("groupControlMain.CustomHeaderButtons2"))), false, true, "Перейти на сегодня"),
            new DevExpress.XtraEditors.ButtonsPanelControl.GroupBoxButton("Вперёд", ((System.Drawing.Image)(resources.GetObject("groupControlMain.CustomHeaderButtons3"))), false, true, "Вперёд")});
            this.groupControlMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupControlMain.Location = new System.Drawing.Point(0, 0);
            this.groupControlMain.Name = "groupControlMain";
            this.groupControlMain.Size = new System.Drawing.Size(1002, 623);
            this.groupControlMain.TabIndex = 2;
            this.groupControlMain.CustomButtonClick += new DevExpress.XtraBars.Docking2010.BaseButtonEventHandler(this.groupControlMain_CustomButtonClick);
            // 
            // splitHorizontal
            // 
            this.splitHorizontal.CollapsePanel = DevExpress.XtraEditors.SplitCollapsePanel.Panel2;
            this.splitHorizontal.CustomHeaderButtons.AddRange(new DevExpress.XtraEditors.ButtonPanel.IBaseButton[] {
            new DevExpress.XtraEditors.ButtonsPanelControl.GroupBoxButton()});
            this.splitHorizontal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitHorizontal.FixedPanel = DevExpress.XtraEditors.SplitFixedPanel.Panel2;
            this.splitHorizontal.Horizontal = false;
            this.splitHorizontal.Location = new System.Drawing.Point(2, 45);
            this.splitHorizontal.Name = "splitHorizontal";
            this.splitHorizontal.Panel1.Controls.Add(this.splitVertical);
            this.splitHorizontal.Panel1.Text = "Panel1";
            this.splitHorizontal.Panel2.Controls.Add(this.gcFreeDeals);
            this.splitHorizontal.Panel2.Text = "Panel2";
            this.splitHorizontal.Size = new System.Drawing.Size(998, 576);
            this.splitHorizontal.SplitterPosition = 239;
            this.splitHorizontal.TabIndex = 2;
            this.splitHorizontal.Text = "splitContainerControl1";
            // 
            // gcFreeDeals
            // 
            this.gcFreeDeals.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gcFreeDeals.Location = new System.Drawing.Point(0, 0);
            this.gcFreeDeals.MainView = this.gvFreeDeals;
            this.gcFreeDeals.Name = "gcFreeDeals";
            this.gcFreeDeals.Size = new System.Drawing.Size(998, 239);
            this.gcFreeDeals.TabIndex = 0;
            this.gcFreeDeals.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvFreeDeals});
            // 
            // gvFreeDeals
            // 
            this.gvFreeDeals.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colDateStart,
            this.colDateEnd,
            this.colRoute,
            this.colCustomerId,
            this.colPerformerId,
            this.colDescription});
            this.gvFreeDeals.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.None;
            this.gvFreeDeals.GridControl = this.gcFreeDeals;
            this.gvFreeDeals.Name = "gvFreeDeals";
            this.gvFreeDeals.OptionsBehavior.Editable = false;
            // 
            // colDateStart
            // 
            this.colDateStart.Caption = "Начало";
            this.colDateStart.DisplayFormat.FormatString = "f";
            this.colDateStart.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.colDateStart.FieldName = "DateStart";
            this.colDateStart.Name = "colDateStart";
            this.colDateStart.Visible = true;
            this.colDateStart.VisibleIndex = 0;
            // 
            // colDateEnd
            // 
            this.colDateEnd.Caption = "Окончание";
            this.colDateEnd.DisplayFormat.FormatString = "f";
            this.colDateEnd.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.colDateEnd.FieldName = "DateEnd";
            this.colDateEnd.Name = "colDateEnd";
            this.colDateEnd.Visible = true;
            this.colDateEnd.VisibleIndex = 1;
            // 
            // colRoute
            // 
            this.colRoute.Caption = "Маршрут";
            this.colRoute.FieldName = "Route";
            this.colRoute.Name = "colRoute";
            this.colRoute.Visible = true;
            this.colRoute.VisibleIndex = 2;
            // 
            // colCustomerId
            // 
            this.colCustomerId.Caption = "Заказчик";
            this.colCustomerId.FieldName = "CustomerId";
            this.colCustomerId.Name = "colCustomerId";
            this.colCustomerId.Visible = true;
            this.colCustomerId.VisibleIndex = 3;
            // 
            // colPerformerId
            // 
            this.colPerformerId.Caption = "Исполнитель";
            this.colPerformerId.FieldName = "PerformerId";
            this.colPerformerId.Name = "colPerformerId";
            this.colPerformerId.Visible = true;
            this.colPerformerId.VisibleIndex = 4;
            // 
            // colDescription
            // 
            this.colDescription.Caption = "Описание";
            this.colDescription.FieldName = "Description";
            this.colDescription.Name = "colDescription";
            this.colDescription.Visible = true;
            this.colDescription.VisibleIndex = 5;
            // 
            // frmSchedule
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1002, 623);
            this.Controls.Add(this.groupControlMain);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MinimumSize = new System.Drawing.Size(800, 545);
            this.Name = "frmSchedule";
            this.Text = "Календарь сделок";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FrmSchedule_Load);
            ((System.ComponentModel.ISupportInitialize)(this.schedulerMain)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.storageMain)).EndInit();
            this.splitVertical.Panel1.ResumeLayout(false);
            this.splitVertical.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitVertical)).EndInit();
            this.splitVertical.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.resourcesTreeMain)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControlMain)).EndInit();
            this.groupControlMain.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitHorizontal)).EndInit();
            this.splitHorizontal.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gcFreeDeals)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvFreeDeals)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraScheduler.SchedulerControl schedulerMain;
        private DevExpress.XtraScheduler.SchedulerStorage storageMain;
        private System.Windows.Forms.SplitContainer splitVertical;
        private DevExpress.XtraScheduler.UI.ResourcesTree resourcesTreeMain;
        private DevExpress.XtraScheduler.Native.ResourceTreeColumn resourceTreeColumn;
        private DevExpress.XtraEditors.GroupControl groupControlMain;
        private DevExpress.XtraEditors.SplitContainerControl splitHorizontal;
        private DevExpress.XtraGrid.GridControl gcFreeDeals;
        private DevExpress.XtraGrid.Views.Grid.GridView gvFreeDeals;
        private DevExpress.XtraGrid.Columns.GridColumn colDateStart;
        private DevExpress.XtraGrid.Columns.GridColumn colDateEnd;
        private DevExpress.XtraGrid.Columns.GridColumn colRoute;
        private DevExpress.XtraGrid.Columns.GridColumn colCustomerId;
        private DevExpress.XtraGrid.Columns.GridColumn colPerformerId;
        private DevExpress.XtraGrid.Columns.GridColumn colDescription;
    }
}