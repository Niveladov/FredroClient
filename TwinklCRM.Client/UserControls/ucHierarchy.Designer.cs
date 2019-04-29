namespace TwinklCRM.Client.UserControls
{
    partial class ucHierarchy
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ucHierarchy));
            this.sccMain = new DevExpress.XtraEditors.SplitContainerControl();
            this.nbcHeirarchy = new DevExpress.XtraNavBar.NavBarControl();
            this.nbgHierarchy = new DevExpress.XtraNavBar.NavBarGroup();
            this.navBarGroupControlContainer1 = new DevExpress.XtraNavBar.NavBarGroupControlContainer();
            this.tlDictionaries = new DevExpress.XtraTreeList.TreeList();
            this.tlcCaption = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.groupCurrentDictionary = new DevExpress.XtraEditors.GroupControl();
            this.gcCurrentDictionary = new TwinklCRM.Client.BaseGUI.GridControlBase();
            this.gvCurrentDictionary = new TwinklCRM.Client.BaseGUI.GridViewBase();
            ((System.ComponentModel.ISupportInitialize)(this.sccMain)).BeginInit();
            this.sccMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nbcHeirarchy)).BeginInit();
            this.nbcHeirarchy.SuspendLayout();
            this.navBarGroupControlContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tlDictionaries)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupCurrentDictionary)).BeginInit();
            this.groupCurrentDictionary.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gcCurrentDictionary)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvCurrentDictionary)).BeginInit();
            this.SuspendLayout();
            // 
            // sccMain
            // 
            this.sccMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.sccMain.Location = new System.Drawing.Point(0, 0);
            this.sccMain.Name = "sccMain";
            this.sccMain.Panel1.Controls.Add(this.nbcHeirarchy);
            this.sccMain.Panel1.Text = "Panel1";
            this.sccMain.Panel2.Controls.Add(this.groupCurrentDictionary);
            this.sccMain.Panel2.Text = "Panel2";
            this.sccMain.Size = new System.Drawing.Size(832, 582);
            this.sccMain.SplitterPosition = 425;
            this.sccMain.TabIndex = 0;
            this.sccMain.Text = "splitContainerControl1";
            // 
            // nbcHeirarchy
            // 
            this.nbcHeirarchy.ActiveGroup = this.nbgHierarchy;
            this.nbcHeirarchy.Appearance.GroupHeader.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.nbcHeirarchy.Appearance.GroupHeader.Options.UseFont = true;
            this.nbcHeirarchy.Appearance.NavigationPaneHeader.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.nbcHeirarchy.Appearance.NavigationPaneHeader.Options.UseFont = true;
            this.nbcHeirarchy.Controls.Add(this.navBarGroupControlContainer1);
            this.nbcHeirarchy.Dock = System.Windows.Forms.DockStyle.Fill;
            this.nbcHeirarchy.Groups.AddRange(new DevExpress.XtraNavBar.NavBarGroup[] {
            this.nbgHierarchy});
            this.nbcHeirarchy.Location = new System.Drawing.Point(0, 0);
            this.nbcHeirarchy.Name = "nbcHeirarchy";
            this.nbcHeirarchy.OptionsNavPane.ExpandedWidth = 425;
            this.nbcHeirarchy.OptionsNavPane.ShowExpandButton = false;
            this.nbcHeirarchy.OptionsNavPane.ShowOverflowPanel = false;
            this.nbcHeirarchy.OptionsNavPane.ShowSplitter = false;
            this.nbcHeirarchy.PaintStyleKind = DevExpress.XtraNavBar.NavBarViewKind.NavigationPane;
            this.nbcHeirarchy.Size = new System.Drawing.Size(425, 582);
            this.nbcHeirarchy.TabIndex = 0;
            // 
            // nbgHierarchy
            // 
            this.nbgHierarchy.Caption = "Справочники";
            this.nbgHierarchy.ControlContainer = this.navBarGroupControlContainer1;
            this.nbgHierarchy.Expanded = true;
            this.nbgHierarchy.GroupClientHeight = 468;
            this.nbgHierarchy.GroupStyle = DevExpress.XtraNavBar.NavBarGroupStyle.ControlContainer;
            this.nbgHierarchy.Name = "nbgHierarchy";
            // 
            // navBarGroupControlContainer1
            // 
            this.navBarGroupControlContainer1.Appearance.BackColor = System.Drawing.SystemColors.Control;
            this.navBarGroupControlContainer1.Appearance.Options.UseBackColor = true;
            this.navBarGroupControlContainer1.Controls.Add(this.tlDictionaries);
            this.navBarGroupControlContainer1.Name = "navBarGroupControlContainer1";
            this.navBarGroupControlContainer1.Size = new System.Drawing.Size(425, 502);
            this.navBarGroupControlContainer1.TabIndex = 0;
            // 
            // tlDictionaries
            // 
            this.tlDictionaries.Appearance.Row.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tlDictionaries.Appearance.Row.Options.UseFont = true;
            this.tlDictionaries.Appearance.SelectedRow.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tlDictionaries.Appearance.SelectedRow.Options.UseFont = true;
            this.tlDictionaries.ColumnPanelRowHeight = 30;
            this.tlDictionaries.Columns.AddRange(new DevExpress.XtraTreeList.Columns.TreeListColumn[] {
            this.tlcCaption});
            this.tlDictionaries.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlDictionaries.Location = new System.Drawing.Point(0, 0);
            this.tlDictionaries.Name = "tlDictionaries";
            this.tlDictionaries.Size = new System.Drawing.Size(425, 502);
            this.tlDictionaries.TabIndex = 0;
            // 
            // tlcCaption
            // 
            this.tlcCaption.AppearanceCell.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tlcCaption.AppearanceCell.Options.UseFont = true;
            this.tlcCaption.AppearanceHeader.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tlcCaption.AppearanceHeader.Options.UseFont = true;
            this.tlcCaption.Caption = "Название";
            this.tlcCaption.FieldName = "Caption";
            this.tlcCaption.Name = "tlcCaption";
            this.tlcCaption.OptionsColumn.AllowEdit = false;
            this.tlcCaption.OptionsColumn.ReadOnly = true;
            this.tlcCaption.Visible = true;
            this.tlcCaption.VisibleIndex = 0;
            // 
            // groupCurrentDictionary
            // 
            this.groupCurrentDictionary.Controls.Add(this.gcCurrentDictionary);
            this.groupCurrentDictionary.CustomHeaderButtons.AddRange(new DevExpress.XtraEditors.ButtonPanel.IBaseButton[] {
            new DevExpress.XtraEditors.ButtonsPanelControl.GroupBoxButton("btnAdd", ((System.Drawing.Image)(resources.GetObject("groupCurrentDictionary.CustomHeaderButtons"))), false, true, ""),
            new DevExpress.XtraEditors.ButtonsPanelControl.GroupBoxButton("btnEdit", ((System.Drawing.Image)(resources.GetObject("groupCurrentDictionary.CustomHeaderButtons1"))), false, true, ""),
            new DevExpress.XtraEditors.ButtonsPanelControl.GroupBoxButton("btnDelete", ((System.Drawing.Image)(resources.GetObject("groupCurrentDictionary.CustomHeaderButtons2"))), false, true, ""),
            new DevExpress.XtraEditors.ButtonsPanelControl.GroupBoxButton("btnRefresh", ((System.Drawing.Image)(resources.GetObject("groupCurrentDictionary.CustomHeaderButtons3"))), false, true, "")});
            this.groupCurrentDictionary.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupCurrentDictionary.Location = new System.Drawing.Point(0, 0);
            this.groupCurrentDictionary.Name = "groupCurrentDictionary";
            this.groupCurrentDictionary.Size = new System.Drawing.Size(401, 582);
            this.groupCurrentDictionary.TabIndex = 0;
            // 
            // gcCurrentDictionary
            // 
            this.gcCurrentDictionary.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gcCurrentDictionary.HideReferenceFields = true;
            this.gcCurrentDictionary.Location = new System.Drawing.Point(2, 45);
            this.gcCurrentDictionary.MainView = this.gvCurrentDictionary;
            this.gcCurrentDictionary.Name = "gcCurrentDictionary";
            this.gcCurrentDictionary.Size = new System.Drawing.Size(397, 535);
            this.gcCurrentDictionary.TabIndex = 1;
            this.gcCurrentDictionary.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvCurrentDictionary});
            // 
            // gvCurrentDictionary
            // 
            this.gvCurrentDictionary.GridControl = this.gcCurrentDictionary;
            this.gvCurrentDictionary.Name = "gvCurrentDictionary";
            this.gvCurrentDictionary.OptionsBehavior.Editable = false;
            // 
            // ucHierarchy
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.sccMain);
            this.Name = "ucHierarchy";
            this.Size = new System.Drawing.Size(832, 582);
            ((System.ComponentModel.ISupportInitialize)(this.sccMain)).EndInit();
            this.sccMain.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.nbcHeirarchy)).EndInit();
            this.nbcHeirarchy.ResumeLayout(false);
            this.navBarGroupControlContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.tlDictionaries)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupCurrentDictionary)).EndInit();
            this.groupCurrentDictionary.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gcCurrentDictionary)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvCurrentDictionary)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.SplitContainerControl sccMain;
        private DevExpress.XtraNavBar.NavBarControl nbcHeirarchy;
        private DevExpress.XtraNavBar.NavBarGroup nbgHierarchy;
        private DevExpress.XtraNavBar.NavBarGroupControlContainer navBarGroupControlContainer1;
        private DevExpress.XtraTreeList.TreeList tlDictionaries;
        private DevExpress.XtraTreeList.Columns.TreeListColumn tlcCaption;
        private DevExpress.XtraEditors.GroupControl groupCurrentDictionary;
        private BaseGUI.GridControlBase gcCurrentDictionary;
        private BaseGUI.GridViewBase gvCurrentDictionary;
    }
}
