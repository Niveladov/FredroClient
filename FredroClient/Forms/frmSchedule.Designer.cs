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
            this.components = new System.ComponentModel.Container();
            DevExpress.XtraScheduler.TimeRuler timeRuler1 = new DevExpress.XtraScheduler.TimeRuler();
            DevExpress.XtraScheduler.TimeRuler timeRuler2 = new DevExpress.XtraScheduler.TimeRuler();
            DevExpress.XtraScheduler.TimeRuler timeRuler3 = new DevExpress.XtraScheduler.TimeRuler();
            this.schedulerMain = new DevExpress.XtraScheduler.SchedulerControl();
            this.storageMain = new DevExpress.XtraScheduler.SchedulerStorage(this.components);
            this.splitMain = new System.Windows.Forms.SplitContainer();
            this.resourcesTreeMain = new DevExpress.XtraScheduler.UI.ResourcesTree();
            ((System.ComponentModel.ISupportInitialize)(this.schedulerMain)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.storageMain)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitMain)).BeginInit();
            this.splitMain.Panel1.SuspendLayout();
            this.splitMain.Panel2.SuspendLayout();
            this.splitMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.resourcesTreeMain)).BeginInit();
            this.SuspendLayout();
            // 
            // schedulerMain
            // 
            this.schedulerMain.ActiveViewType = DevExpress.XtraScheduler.SchedulerViewType.Timeline;
            this.schedulerMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.schedulerMain.Location = new System.Drawing.Point(0, 0);
            this.schedulerMain.Name = "schedulerMain";
            this.schedulerMain.Size = new System.Drawing.Size(758, 623);
            this.schedulerMain.Start = new System.DateTime(2018, 12, 14, 0, 0, 0, 0);
            this.schedulerMain.Storage = this.storageMain;
            this.schedulerMain.TabIndex = 0;
            this.schedulerMain.Text = "scMain";
            this.schedulerMain.Views.DayView.TimeRulers.Add(timeRuler1);
            this.schedulerMain.Views.FullWeekView.Enabled = true;
            this.schedulerMain.Views.FullWeekView.TimeRulers.Add(timeRuler2);
            this.schedulerMain.Views.WeekView.Enabled = false;
            this.schedulerMain.Views.WorkWeekView.TimeRulers.Add(timeRuler3);
            // 
            // splitMain
            // 
            this.splitMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitMain.Location = new System.Drawing.Point(0, 0);
            this.splitMain.Name = "splitMain";
            // 
            // splitMain.Panel1
            // 
            this.splitMain.Panel1.Controls.Add(this.resourcesTreeMain);
            // 
            // splitMain.Panel2
            // 
            this.splitMain.Panel2.Controls.Add(this.schedulerMain);
            this.splitMain.Size = new System.Drawing.Size(1002, 623);
            this.splitMain.SplitterDistance = 240;
            this.splitMain.TabIndex = 1;
            // 
            // resourcesTreeMain
            // 
            this.resourcesTreeMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.resourcesTreeMain.Location = new System.Drawing.Point(0, 0);
            this.resourcesTreeMain.Name = "resourcesTreeMain";
            this.resourcesTreeMain.OptionsBehavior.Editable = false;
            this.resourcesTreeMain.SchedulerControl = this.schedulerMain;
            this.resourcesTreeMain.Size = new System.Drawing.Size(240, 623);
            this.resourcesTreeMain.TabIndex = 0;
            // 
            // frmSchedule
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1002, 623);
            this.Controls.Add(this.splitMain);
            this.MinimumSize = new System.Drawing.Size(800, 600);
            this.Name = "frmSchedule";
            this.Text = "Календарь сделок";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.schedulerMain)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.storageMain)).EndInit();
            this.splitMain.Panel1.ResumeLayout(false);
            this.splitMain.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitMain)).EndInit();
            this.splitMain.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.resourcesTreeMain)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraScheduler.SchedulerControl schedulerMain;
        private DevExpress.XtraScheduler.SchedulerStorage storageMain;
        private System.Windows.Forms.SplitContainer splitMain;
        private DevExpress.XtraScheduler.UI.ResourcesTree resourcesTreeMain;
    }
}