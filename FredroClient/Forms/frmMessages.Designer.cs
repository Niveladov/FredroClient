﻿namespace FredroClient.Forms
{
    sealed partial class frmMessages
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
            this.splitMessages = new DevExpress.XtraEditors.SplitContainerControl();
            this.gcMessages = new DevExpress.XtraGrid.GridControl();
            this.wevMessages = new DevExpress.XtraGrid.Views.WinExplorer.WinExplorerView();
            this.colFrom = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSubject = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colBody = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDate = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.splitMessages)).BeginInit();
            this.splitMessages.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gcMessages)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.wevMessages)).BeginInit();
            this.SuspendLayout();
            // 
            // splitMessages
            // 
            this.splitMessages.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitMessages.Location = new System.Drawing.Point(0, 0);
            this.splitMessages.Name = "splitMessages";
            this.splitMessages.Panel1.Controls.Add(this.gcMessages);
            this.splitMessages.Panel1.Text = "Panel1";
            this.splitMessages.Panel2.Text = "Panel2";
            this.splitMessages.Size = new System.Drawing.Size(782, 553);
            this.splitMessages.SplitterPosition = 421;
            this.splitMessages.TabIndex = 0;
            // 
            // gcMessages
            // 
            this.gcMessages.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gcMessages.Location = new System.Drawing.Point(0, 0);
            this.gcMessages.MainView = this.wevMessages;
            this.gcMessages.Name = "gcMessages";
            this.gcMessages.Size = new System.Drawing.Size(421, 553);
            this.gcMessages.TabIndex = 1;
            this.gcMessages.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.wevMessages});
            // 
            // wevMessages
            // 
            this.wevMessages.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colFrom,
            this.colSubject,
            this.colBody,
            this.colDate});
            this.wevMessages.ColumnSet.DescriptionColumn = this.colBody;
            this.wevMessages.ColumnSet.TextColumn = this.colSubject;
            this.wevMessages.GridControl = this.gcMessages;
            this.wevMessages.Name = "wevMessages";
            this.wevMessages.OptionsBehavior.Editable = false;
            this.wevMessages.OptionsView.Style = DevExpress.XtraGrid.Views.WinExplorer.WinExplorerViewStyle.Content;
            this.wevMessages.OptionsViewStyles.Content.ItemWidth = 407;
            this.wevMessages.OptionsViewStyles.Content.ShowDescription = DevExpress.Utils.DefaultBoolean.True;
            // 
            // colFrom
            // 
            this.colFrom.FieldName = "From";
            this.colFrom.Name = "colFrom";
            this.colFrom.Visible = true;
            this.colFrom.VisibleIndex = 0;
            // 
            // colSubject
            // 
            this.colSubject.FieldName = "Subject";
            this.colSubject.Name = "colSubject";
            this.colSubject.Visible = true;
            this.colSubject.VisibleIndex = 0;
            // 
            // colBody
            // 
            this.colBody.FieldName = "Body";
            this.colBody.Name = "colBody";
            this.colBody.Visible = true;
            this.colBody.VisibleIndex = 0;
            // 
            // colDate
            // 
            this.colDate.FieldName = "Date";
            this.colDate.Name = "colDate";
            this.colDate.Visible = true;
            this.colDate.VisibleIndex = 0;
            // 
            // frmMessages
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(782, 553);
            this.Controls.Add(this.splitMessages);
            this.Name = "frmMessages";
            this.Text = "";
            ((System.ComponentModel.ISupportInitialize)(this.splitMessages)).EndInit();
            this.splitMessages.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gcMessages)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.wevMessages)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.SplitContainerControl splitMessages;
        private DevExpress.XtraGrid.GridControl gcMessages;
        private DevExpress.XtraGrid.Views.WinExplorer.WinExplorerView wevMessages;
        private DevExpress.XtraGrid.Columns.GridColumn colFrom;
        private DevExpress.XtraGrid.Columns.GridColumn colSubject;
        private DevExpress.XtraGrid.Columns.GridColumn colBody;
        private DevExpress.XtraGrid.Columns.GridColumn colDate;
    }
}