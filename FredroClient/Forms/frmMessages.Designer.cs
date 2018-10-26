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
            this.colFromDisplayName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSubject = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colBody = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPictureMail = new DevExpress.XtraGrid.Columns.GridColumn();
            this.lcMessage = new DevExpress.XtraLayout.LayoutControl();
            this.btnRemove = new DevExpress.XtraEditors.SimpleButton();
            this.btnResend = new DevExpress.XtraEditors.SimpleButton();
            this.btnReply = new DevExpress.XtraEditors.SimpleButton();
            this.meBody = new DevExpress.XtraEditors.MemoEdit();
            this.peUser = new DevExpress.XtraEditors.PictureEdit();
            this.labelDate = new DevExpress.XtraEditors.LabelControl();
            this.labelTo = new DevExpress.XtraEditors.LabelControl();
            this.labelSubject = new DevExpress.XtraEditors.LabelControl();
            this.labelFrom = new DevExpress.XtraEditors.LabelControl();
            this.lcgMessage = new DevExpress.XtraLayout.LayoutControlGroup();
            this.lciFrom = new DevExpress.XtraLayout.LayoutControlItem();
            this.lciTo = new DevExpress.XtraLayout.LayoutControlItem();
            this.lciSubject = new DevExpress.XtraLayout.LayoutControlItem();
            this.lciDate = new DevExpress.XtraLayout.LayoutControlItem();
            this.separator = new DevExpress.XtraLayout.SimpleSeparator();
            this.lciPictureUser = new DevExpress.XtraLayout.LayoutControlItem();
            this.lciBody = new DevExpress.XtraLayout.LayoutControlItem();
            this.emptySpaceItem1 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem3 = new DevExpress.XtraLayout.LayoutControlItem();
            this.emptySpaceItem2 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.colFrom = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.splitMessages)).BeginInit();
            this.splitMessages.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gcMessages)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.wevMessages)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lcMessage)).BeginInit();
            this.lcMessage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.meBody.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.peUser.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lcgMessage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciFrom)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciTo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciSubject)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciDate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.separator)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciPictureUser)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciBody)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem2)).BeginInit();
            this.SuspendLayout();
            // 
            // splitMessages
            // 
            this.splitMessages.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitMessages.Location = new System.Drawing.Point(0, 0);
            this.splitMessages.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.splitMessages.Name = "splitMessages";
            this.splitMessages.Panel1.Controls.Add(this.gcMessages);
            this.splitMessages.Panel1.Text = "Panel1";
            this.splitMessages.Panel2.Controls.Add(this.lcMessage);
            this.splitMessages.Panel2.Text = "Panel2";
            this.splitMessages.Size = new System.Drawing.Size(989, 562);
            this.splitMessages.SplitterPosition = 419;
            this.splitMessages.TabIndex = 0;
            // 
            // gcMessages
            // 
            this.gcMessages.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gcMessages.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gcMessages.Location = new System.Drawing.Point(0, 0);
            this.gcMessages.MainView = this.wevMessages;
            this.gcMessages.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gcMessages.Name = "gcMessages";
            this.gcMessages.Size = new System.Drawing.Size(419, 562);
            this.gcMessages.TabIndex = 1;
            this.gcMessages.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.wevMessages});
            // 
            // wevMessages
            // 
            this.wevMessages.Appearance.ItemDescriptionNormal.ForeColor = System.Drawing.Color.LightYellow;
            this.wevMessages.Appearance.ItemDescriptionNormal.Options.UseForeColor = true;
            this.wevMessages.Appearance.ItemNormal.Font = new System.Drawing.Font("Tahoma", 10F);
            this.wevMessages.Appearance.ItemNormal.ForeColor = System.Drawing.Color.LightYellow;
            this.wevMessages.Appearance.ItemNormal.Options.UseFont = true;
            this.wevMessages.Appearance.ItemNormal.Options.UseForeColor = true;
            this.wevMessages.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colFromDisplayName,
            this.colSubject,
            this.colBody,
            this.colDate,
            this.colPictureMail});
            this.wevMessages.ColumnSet.DescriptionColumn = this.colSubject;
            this.wevMessages.ColumnSet.SmallImageColumn = this.colPictureMail;
            this.wevMessages.ColumnSet.TextColumn = this.colFromDisplayName;
            this.wevMessages.GridControl = this.gcMessages;
            this.wevMessages.Name = "wevMessages";
            this.wevMessages.OptionsBehavior.Editable = false;
            this.wevMessages.OptionsFind.AlwaysVisible = true;
            this.wevMessages.OptionsView.ImageLayoutMode = DevExpress.Utils.Drawing.ImageLayoutMode.MiddleCenter;
            this.wevMessages.OptionsView.Style = DevExpress.XtraGrid.Views.WinExplorer.WinExplorerViewStyle.Content;
            this.wevMessages.OptionsViewStyles.Content.ItemWidth = 405;
            this.wevMessages.OptionsViewStyles.Content.ShowDescription = DevExpress.Utils.DefaultBoolean.True;
            // 
            // colFromDisplayName
            // 
            this.colFromDisplayName.FieldName = "FromDisplayName";
            this.colFromDisplayName.Name = "colFromDisplayName";
            this.colFromDisplayName.Visible = true;
            this.colFromDisplayName.VisibleIndex = 0;
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
            this.colBody.VisibleIndex = 1;
            // 
            // colDate
            // 
            this.colDate.FieldName = "Date";
            this.colDate.Name = "colDate";
            this.colDate.Visible = true;
            this.colDate.VisibleIndex = 0;
            // 
            // colPictureMail
            // 
            this.colPictureMail.FieldName = "PictureMail";
            this.colPictureMail.Name = "colPictureMail";
            this.colPictureMail.Visible = true;
            this.colPictureMail.VisibleIndex = 2;
            // 
            // lcMessage
            // 
            this.lcMessage.Appearance.Control.Font = new System.Drawing.Font("Tahoma", 10F);
            this.lcMessage.Appearance.Control.Options.UseFont = true;
            this.lcMessage.Controls.Add(this.btnRemove);
            this.lcMessage.Controls.Add(this.btnResend);
            this.lcMessage.Controls.Add(this.btnReply);
            this.lcMessage.Controls.Add(this.meBody);
            this.lcMessage.Controls.Add(this.peUser);
            this.lcMessage.Controls.Add(this.labelDate);
            this.lcMessage.Controls.Add(this.labelTo);
            this.lcMessage.Controls.Add(this.labelSubject);
            this.lcMessage.Controls.Add(this.labelFrom);
            this.lcMessage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lcMessage.Location = new System.Drawing.Point(0, 0);
            this.lcMessage.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.lcMessage.Name = "lcMessage";
            this.lcMessage.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = new System.Drawing.Rectangle(424, 341, 633, 350);
            this.lcMessage.Root = this.lcgMessage;
            this.lcMessage.Size = new System.Drawing.Size(564, 562);
            this.lcMessage.TabIndex = 0;
            this.lcMessage.Text = "layoutControl1";
            // 
            // btnRemove
            // 
            this.btnRemove.Location = new System.Drawing.Point(249, 7);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(117, 28);
            this.btnRemove.StyleController = this.lcMessage;
            this.btnRemove.TabIndex = 12;
            this.btnRemove.Text = "Удалить";
            // 
            // btnResend
            // 
            this.btnResend.Location = new System.Drawing.Point(128, 7);
            this.btnResend.Name = "btnResend";
            this.btnResend.Size = new System.Drawing.Size(117, 28);
            this.btnResend.StyleController = this.lcMessage;
            this.btnResend.TabIndex = 11;
            this.btnResend.Text = "Переслать";
            // 
            // btnReply
            // 
            this.btnReply.Location = new System.Drawing.Point(7, 7);
            this.btnReply.Name = "btnReply";
            this.btnReply.Size = new System.Drawing.Size(117, 28);
            this.btnReply.StyleController = this.lcMessage;
            this.btnReply.TabIndex = 10;
            this.btnReply.Text = "Ответить";
            // 
            // meBody
            // 
            this.meBody.Location = new System.Drawing.Point(7, 128);
            this.meBody.Name = "meBody";
            this.meBody.Properties.AllowHtmlDraw = DevExpress.Utils.DefaultBoolean.True;
            this.meBody.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.meBody.Size = new System.Drawing.Size(550, 427);
            this.meBody.StyleController = this.lcMessage;
            this.meBody.TabIndex = 9;
            // 
            // peUser
            // 
            this.peUser.EditValue = global::FredroClient.Properties.Resources.user_64x64;
            this.peUser.Location = new System.Drawing.Point(7, 71);
            this.peUser.Name = "peUser";
            this.peUser.Properties.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.peUser.Properties.Appearance.Options.UseBackColor = true;
            this.peUser.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.peUser.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.Auto;
            this.peUser.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Zoom;
            this.peUser.Size = new System.Drawing.Size(43, 43);
            this.peUser.StyleController = this.lcMessage;
            this.peUser.TabIndex = 8;
            // 
            // labelDate
            // 
            this.labelDate.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.Horizontal;
            this.labelDate.Location = new System.Drawing.Point(486, 71);
            this.labelDate.Name = "labelDate";
            this.labelDate.Size = new System.Drawing.Size(71, 21);
            this.labelDate.StyleController = this.lcMessage;
            this.labelDate.TabIndex = 7;
            this.labelDate.Text = "labelDate";
            // 
            // labelTo
            // 
            this.labelTo.Location = new System.Drawing.Point(54, 96);
            this.labelTo.Name = "labelTo";
            this.labelTo.Size = new System.Drawing.Size(503, 18);
            this.labelTo.StyleController = this.lcMessage;
            this.labelTo.TabIndex = 6;
            this.labelTo.Text = "labelTo";
            // 
            // labelSubject
            // 
            this.labelSubject.Appearance.Font = new System.Drawing.Font("Tahoma", 14F);
            this.labelSubject.Location = new System.Drawing.Point(7, 39);
            this.labelSubject.Name = "labelSubject";
            this.labelSubject.Size = new System.Drawing.Size(123, 28);
            this.labelSubject.StyleController = this.lcMessage;
            this.labelSubject.TabIndex = 5;
            this.labelSubject.Text = "labelSubject";
            // 
            // labelFrom
            // 
            this.labelFrom.Location = new System.Drawing.Point(54, 71);
            this.labelFrom.Name = "labelFrom";
            this.labelFrom.Size = new System.Drawing.Size(428, 21);
            this.labelFrom.StyleController = this.lcMessage;
            this.labelFrom.TabIndex = 4;
            this.labelFrom.Text = "lableFrom";
            // 
            // lcgMessage
            // 
            this.lcgMessage.AppearanceGroup.Font = new System.Drawing.Font("Tahoma", 10F);
            this.lcgMessage.AppearanceGroup.Options.UseFont = true;
            this.lcgMessage.AppearanceItemCaption.Font = new System.Drawing.Font("Tahoma", 10F);
            this.lcgMessage.AppearanceItemCaption.Options.UseFont = true;
            this.lcgMessage.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.lcgMessage.GroupBordersVisible = false;
            this.lcgMessage.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.lciFrom,
            this.lciTo,
            this.lciSubject,
            this.lciDate,
            this.separator,
            this.lciPictureUser,
            this.lciBody,
            this.emptySpaceItem1,
            this.layoutControlItem1,
            this.layoutControlItem2,
            this.layoutControlItem3,
            this.emptySpaceItem2});
            this.lcgMessage.Location = new System.Drawing.Point(0, 0);
            this.lcgMessage.Name = "Root";
            this.lcgMessage.Padding = new DevExpress.XtraLayout.Utils.Padding(5, 5, 5, 5);
            this.lcgMessage.Size = new System.Drawing.Size(564, 562);
            this.lcgMessage.TextVisible = false;
            // 
            // lciFrom
            // 
            this.lciFrom.Control = this.labelFrom;
            this.lciFrom.Location = new System.Drawing.Point(47, 64);
            this.lciFrom.MinSize = new System.Drawing.Size(50, 17);
            this.lciFrom.Name = "lciFrom";
            this.lciFrom.Size = new System.Drawing.Size(432, 25);
            this.lciFrom.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.lciFrom.TextSize = new System.Drawing.Size(0, 0);
            this.lciFrom.TextVisible = false;
            // 
            // lciTo
            // 
            this.lciTo.Control = this.labelTo;
            this.lciTo.Location = new System.Drawing.Point(47, 89);
            this.lciTo.MinSize = new System.Drawing.Size(46, 20);
            this.lciTo.Name = "lciTo";
            this.lciTo.Size = new System.Drawing.Size(507, 22);
            this.lciTo.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.lciTo.TextSize = new System.Drawing.Size(0, 0);
            this.lciTo.TextVisible = false;
            // 
            // lciSubject
            // 
            this.lciSubject.Control = this.labelSubject;
            this.lciSubject.Location = new System.Drawing.Point(0, 32);
            this.lciSubject.Name = "lciSubject";
            this.lciSubject.Size = new System.Drawing.Size(554, 32);
            this.lciSubject.TextSize = new System.Drawing.Size(0, 0);
            this.lciSubject.TextVisible = false;
            // 
            // lciDate
            // 
            this.lciDate.Control = this.labelDate;
            this.lciDate.Location = new System.Drawing.Point(479, 64);
            this.lciDate.Name = "lciDate";
            this.lciDate.Size = new System.Drawing.Size(75, 25);
            this.lciDate.TextSize = new System.Drawing.Size(0, 0);
            this.lciDate.TextVisible = false;
            // 
            // separator
            // 
            this.separator.AllowHotTrack = false;
            this.separator.Location = new System.Drawing.Point(0, 116);
            this.separator.Name = "separator";
            this.separator.Size = new System.Drawing.Size(554, 2);
            // 
            // lciPictureUser
            // 
            this.lciPictureUser.Control = this.peUser;
            this.lciPictureUser.Location = new System.Drawing.Point(0, 64);
            this.lciPictureUser.MaxSize = new System.Drawing.Size(47, 47);
            this.lciPictureUser.MinSize = new System.Drawing.Size(47, 47);
            this.lciPictureUser.Name = "lciPictureUser";
            this.lciPictureUser.Size = new System.Drawing.Size(47, 47);
            this.lciPictureUser.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.lciPictureUser.TextSize = new System.Drawing.Size(0, 0);
            this.lciPictureUser.TextVisible = false;
            // 
            // lciBody
            // 
            this.lciBody.Control = this.meBody;
            this.lciBody.Location = new System.Drawing.Point(0, 118);
            this.lciBody.Name = "lciBody";
            this.lciBody.Padding = new DevExpress.XtraLayout.Utils.Padding(2, 2, 5, 2);
            this.lciBody.Size = new System.Drawing.Size(554, 434);
            this.lciBody.TextSize = new System.Drawing.Size(0, 0);
            this.lciBody.TextVisible = false;
            // 
            // emptySpaceItem1
            // 
            this.emptySpaceItem1.AllowHotTrack = false;
            this.emptySpaceItem1.Location = new System.Drawing.Point(0, 111);
            this.emptySpaceItem1.MaxSize = new System.Drawing.Size(0, 5);
            this.emptySpaceItem1.MinSize = new System.Drawing.Size(10, 5);
            this.emptySpaceItem1.Name = "emptySpaceItem1";
            this.emptySpaceItem1.Size = new System.Drawing.Size(554, 5);
            this.emptySpaceItem1.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.emptySpaceItem1.TextSize = new System.Drawing.Size(0, 0);
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.btnReply;
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem1.MaxSize = new System.Drawing.Size(121, 32);
            this.layoutControlItem1.MinSize = new System.Drawing.Size(121, 32);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(121, 32);
            this.layoutControlItem1.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.layoutControlItem1.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem1.TextVisible = false;
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.Control = this.btnResend;
            this.layoutControlItem2.Location = new System.Drawing.Point(121, 0);
            this.layoutControlItem2.MaxSize = new System.Drawing.Size(121, 32);
            this.layoutControlItem2.MinSize = new System.Drawing.Size(121, 32);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.Size = new System.Drawing.Size(121, 32);
            this.layoutControlItem2.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.layoutControlItem2.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem2.TextVisible = false;
            // 
            // layoutControlItem3
            // 
            this.layoutControlItem3.Control = this.btnRemove;
            this.layoutControlItem3.Location = new System.Drawing.Point(242, 0);
            this.layoutControlItem3.MaxSize = new System.Drawing.Size(121, 32);
            this.layoutControlItem3.MinSize = new System.Drawing.Size(121, 32);
            this.layoutControlItem3.Name = "layoutControlItem3";
            this.layoutControlItem3.Size = new System.Drawing.Size(121, 32);
            this.layoutControlItem3.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.layoutControlItem3.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem3.TextVisible = false;
            // 
            // emptySpaceItem2
            // 
            this.emptySpaceItem2.AllowHotTrack = false;
            this.emptySpaceItem2.Location = new System.Drawing.Point(363, 0);
            this.emptySpaceItem2.Name = "emptySpaceItem2";
            this.emptySpaceItem2.Size = new System.Drawing.Size(191, 32);
            this.emptySpaceItem2.TextSize = new System.Drawing.Size(0, 0);
            // 
            // colFrom
            // 
            this.colFrom.FieldName = "From";
            this.colFrom.Name = "colFrom";
            this.colFrom.Visible = true;
            this.colFrom.VisibleIndex = 0;
            // 
            // frmMessages
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(989, 562);
            this.Controls.Add(this.splitMessages);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "frmMessages";
            this.Text = "";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.splitMessages)).EndInit();
            this.splitMessages.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gcMessages)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.wevMessages)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lcMessage)).EndInit();
            this.lcMessage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.meBody.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.peUser.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lcgMessage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciFrom)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciTo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciSubject)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciDate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.separator)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciPictureUser)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciBody)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.SplitContainerControl splitMessages;
        private DevExpress.XtraGrid.GridControl gcMessages;
        private DevExpress.XtraGrid.Views.WinExplorer.WinExplorerView wevMessages;
        private DevExpress.XtraGrid.Columns.GridColumn colFromDisplayName;
        private DevExpress.XtraGrid.Columns.GridColumn colSubject;
        private DevExpress.XtraGrid.Columns.GridColumn colBody;
        private DevExpress.XtraGrid.Columns.GridColumn colDate;
        private DevExpress.XtraGrid.Columns.GridColumn colPictureMail;
        private DevExpress.XtraGrid.Columns.GridColumn colFrom;
        private DevExpress.XtraLayout.LayoutControl lcMessage;
        private DevExpress.XtraLayout.LayoutControlGroup lcgMessage;
        private DevExpress.XtraEditors.LabelControl labelDate;
        private DevExpress.XtraEditors.LabelControl labelTo;
        private DevExpress.XtraEditors.LabelControl labelSubject;
        private DevExpress.XtraEditors.LabelControl labelFrom;
        private DevExpress.XtraLayout.LayoutControlItem lciFrom;
        private DevExpress.XtraLayout.LayoutControlItem lciTo;
        private DevExpress.XtraLayout.LayoutControlItem lciSubject;
        private DevExpress.XtraLayout.LayoutControlItem lciDate;
        private DevExpress.XtraLayout.SimpleSeparator separator;
        private DevExpress.XtraEditors.PictureEdit peUser;
        private DevExpress.XtraLayout.LayoutControlItem lciPictureUser;
        private DevExpress.XtraEditors.MemoEdit meBody;
        private DevExpress.XtraLayout.LayoutControlItem lciBody;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem1;
        private DevExpress.XtraEditors.SimpleButton btnRemove;
        private DevExpress.XtraEditors.SimpleButton btnResend;
        private DevExpress.XtraEditors.SimpleButton btnReply;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem3;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem2;
    }
}