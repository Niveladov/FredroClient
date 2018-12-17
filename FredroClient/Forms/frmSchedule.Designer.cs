﻿namespace FredroClient.Forms
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
            this.components = new System.ComponentModel.Container();
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
            this.storageMain = new DevExpress.XtraScheduler.SchedulerStorage(this.components);
            this.splitMain = new System.Windows.Forms.SplitContainer();
            this.resourcesTreeMain = new DevExpress.XtraScheduler.UI.ResourcesTree();
            this.resourceTreeColumn = new DevExpress.XtraScheduler.Native.ResourceTreeColumn();
            this.groupControlMain = new DevExpress.XtraEditors.GroupControl();
            ((System.ComponentModel.ISupportInitialize)(this.schedulerMain)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.storageMain)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitMain)).BeginInit();
            this.splitMain.Panel1.SuspendLayout();
            this.splitMain.Panel2.SuspendLayout();
            this.splitMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.resourcesTreeMain)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControlMain)).BeginInit();
            this.groupControlMain.SuspendLayout();
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
            this.schedulerMain.Size = new System.Drawing.Size(791, 576);
            this.schedulerMain.Start = new System.DateTime(2018, 12, 10, 0, 0, 0, 0);
            this.schedulerMain.Storage = this.storageMain;
            this.schedulerMain.TabIndex = 0;
            this.schedulerMain.Text = "scMain";
            this.schedulerMain.Views.DayView.TimeRulers.Add(timeRuler1);
            this.schedulerMain.Views.FullWeekView.Enabled = true;
            this.schedulerMain.Views.FullWeekView.TimeRulers.Add(timeRuler2);
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
            this.schedulerMain.Views.WorkWeekView.TimeRulers.Add(timeRuler3);
            // 
            // splitMain
            // 
            this.splitMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitMain.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.splitMain.Location = new System.Drawing.Point(2, 45);
            this.splitMain.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.splitMain.Name = "splitMain";
            // 
            // splitMain.Panel1
            // 
            this.splitMain.Panel1.Controls.Add(this.resourcesTreeMain);
            this.splitMain.Panel1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            // 
            // splitMain.Panel2
            // 
            this.splitMain.Panel2.Controls.Add(this.schedulerMain);
            this.splitMain.Panel2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.splitMain.Size = new System.Drawing.Size(998, 576);
            this.splitMain.SplitterDistance = 204;
            this.splitMain.SplitterWidth = 3;
            this.splitMain.TabIndex = 1;
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
            this.resourcesTreeMain.Size = new System.Drawing.Size(204, 576);
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
            this.groupControlMain.Controls.Add(this.splitMain);
            this.groupControlMain.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.groupControlMain.CustomHeaderButtons.AddRange(new DevExpress.XtraEditors.ButtonPanel.IBaseButton[] {
            new DevExpress.XtraEditors.ButtonsPanelControl.GroupBoxButton("Button", null, -1, DevExpress.XtraEditors.ButtonPanel.ImageLocation.Default, DevExpress.XtraBars.Docking2010.ButtonStyle.PushButton, "", false, -1, false, null, false, false, true, null, null, -1),
            new DevExpress.XtraEditors.ButtonsPanelControl.GroupBoxButton("Button", null, -1, DevExpress.XtraEditors.ButtonPanel.ImageLocation.Default, DevExpress.XtraBars.Docking2010.ButtonStyle.PushButton, "", false, -1, false, null, false, false, true, null, null, -1),
            new DevExpress.XtraEditors.ButtonsPanelControl.GroupBoxButton("Button", null, -1, DevExpress.XtraEditors.ButtonPanel.ImageLocation.Default, DevExpress.XtraBars.Docking2010.ButtonStyle.PushButton, "", false, -1, false, null, false, false, true, null, null, -1),
            new DevExpress.XtraEditors.ButtonsPanelControl.GroupBoxButton("Button", null, -1, DevExpress.XtraEditors.ButtonPanel.ImageLocation.Default, DevExpress.XtraBars.Docking2010.ButtonStyle.PushButton, "", false, -1, false, null, false, false, true, null, null, -1),
            new DevExpress.XtraEditors.ButtonsPanelControl.GroupBoxButton("Previous", ((System.Drawing.Image)(resources.GetObject("groupControlMain.CustomHeaderButtons"))), false, true, "Назад"),
            new DevExpress.XtraEditors.ButtonsPanelControl.GroupBoxButton("Button", ((System.Drawing.Image)(resources.GetObject("groupControlMain.CustomHeaderButtons1"))), false, true, "На дату"),
            new DevExpress.XtraEditors.ButtonsPanelControl.GroupBoxButton("Next", ((System.Drawing.Image)(resources.GetObject("groupControlMain.CustomHeaderButtons2"))), false, true, "Вперёд")});
            this.groupControlMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupControlMain.Location = new System.Drawing.Point(0, 0);
            this.groupControlMain.Name = "groupControlMain";
            this.groupControlMain.Size = new System.Drawing.Size(1002, 623);
            this.groupControlMain.TabIndex = 2;
            this.groupControlMain.CustomButtonClick += new DevExpress.XtraBars.Docking2010.BaseButtonEventHandler(this.groupControlMain_CustomButtonClick);
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
            this.splitMain.Panel1.ResumeLayout(false);
            this.splitMain.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitMain)).EndInit();
            this.splitMain.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.resourcesTreeMain)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControlMain)).EndInit();
            this.groupControlMain.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraScheduler.SchedulerControl schedulerMain;
        private DevExpress.XtraScheduler.SchedulerStorage storageMain;
        private System.Windows.Forms.SplitContainer splitMain;
        private DevExpress.XtraScheduler.UI.ResourcesTree resourcesTreeMain;
        private DevExpress.XtraScheduler.Native.ResourceTreeColumn resourceTreeColumn;
        private DevExpress.XtraEditors.GroupControl groupControlMain;
    }
}