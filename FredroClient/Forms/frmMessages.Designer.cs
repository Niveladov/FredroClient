namespace FredroClient.Forms
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMessages));
            this.splitMessages = new DevExpress.XtraEditors.SplitContainerControl();
            this.gcMessages = new DevExpress.XtraGrid.GridControl();
            this.wevMessages = new DevExpress.XtraGrid.Views.WinExplorer.WinExplorerView();
            this.colFromDisplayName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSubject = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colBody = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPictureMail = new DevExpress.XtraGrid.Columns.GridColumn();
            this.lcMessage = new DevExpress.XtraLayout.LayoutControl();
            this.btnSendResponse = new DevExpress.XtraEditors.SimpleButton();
            this.meResponseBody = new DevExpress.XtraEditors.MemoEdit();
            this.ddbMove = new DevExpress.XtraEditors.DropDownButton();
            this.btnAddTask = new DevExpress.XtraEditors.SimpleButton();
            this.btnAddDeal = new DevExpress.XtraEditors.SimpleButton();
            this.btnAddClient = new DevExpress.XtraEditors.SimpleButton();
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
            this.lciReply = new DevExpress.XtraLayout.LayoutControlItem();
            this.lciResend = new DevExpress.XtraLayout.LayoutControlItem();
            this.lciRemove = new DevExpress.XtraLayout.LayoutControlItem();
            this.esMessageButtons = new DevExpress.XtraLayout.EmptySpaceItem();
            this.lciAddClient = new DevExpress.XtraLayout.LayoutControlItem();
            this.lciAddDeal = new DevExpress.XtraLayout.LayoutControlItem();
            this.lciAddTask = new DevExpress.XtraLayout.LayoutControlItem();
            this.esClientButtons = new DevExpress.XtraLayout.EmptySpaceItem();
            this.lciMove = new DevExpress.XtraLayout.LayoutControlItem();
            this.lciResponseBody = new DevExpress.XtraLayout.LayoutControlItem();
            this.lciSendResponse = new DevExpress.XtraLayout.LayoutControlItem();
            this.esResponseArea = new DevExpress.XtraLayout.EmptySpaceItem();
            this.colFrom = new DevExpress.XtraGrid.Columns.GridColumn();
            this.splitMain = new DevExpress.XtraEditors.SplitContainerControl();
            this.lcMessageTypes = new DevExpress.XtraLayout.LayoutControl();
            this.btnSendNew = new DevExpress.XtraEditors.SimpleButton();
            this.gcFolders = new DevExpress.XtraGrid.GridControl();
            this.wevFolders = new DevExpress.XtraGrid.Views.WinExplorer.WinExplorerView();
            this.colCaption = new DevExpress.XtraGrid.Columns.GridColumn();
            this.lcgMessageTypes = new DevExpress.XtraLayout.LayoutControlGroup();
            this.lciMessageTypes = new DevExpress.XtraLayout.LayoutControlItem();
            this.lciSendNew = new DevExpress.XtraLayout.LayoutControlItem();
            this.lcMain = new DevExpress.XtraLayout.LayoutControl();
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.tsslLeftText = new System.Windows.Forms.ToolStripStatusLabel();
            this.tsslRightText = new System.Windows.Forms.ToolStripStatusLabel();
            this.panelTop = new DevExpress.XtraEditors.PanelControl();
            this.lcTopPanel = new DevExpress.XtraLayout.LayoutControl();
            this.labelFredro = new DevExpress.XtraEditors.LabelControl();
            this.peFredroLabel = new DevExpress.XtraEditors.PictureEdit();
            this.peSettings = new DevExpress.XtraEditors.PictureEdit();
            this.peAva = new DevExpress.XtraEditors.PictureEdit();
            this.lcgTopPanel = new DevExpress.XtraLayout.LayoutControlGroup();
            this.lciAva = new DevExpress.XtraLayout.LayoutControlItem();
            this.emptySpaceItem4 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.emptySpaceItem5 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.lciSettings = new DevExpress.XtraLayout.LayoutControlItem();
            this.lciFredroLabel = new DevExpress.XtraLayout.LayoutControlItem();
            this.lciLabel = new DevExpress.XtraLayout.LayoutControlItem();
            this.emptySpaceItem6 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.lcgMain = new DevExpress.XtraLayout.LayoutControlGroup();
            this.lciSplitMain = new DevExpress.XtraLayout.LayoutControlItem();
            this.lciPanelTop = new DevExpress.XtraLayout.LayoutControlItem();
            this.lciStatusStrip = new DevExpress.XtraLayout.LayoutControlItem();
            ((System.ComponentModel.ISupportInitialize)(this.splitMessages)).BeginInit();
            this.splitMessages.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gcMessages)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.wevMessages)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lcMessage)).BeginInit();
            this.lcMessage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.meResponseBody.Properties)).BeginInit();
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
            ((System.ComponentModel.ISupportInitialize)(this.lciReply)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciResend)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciRemove)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.esMessageButtons)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciAddClient)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciAddDeal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciAddTask)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.esClientButtons)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciMove)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciResponseBody)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciSendResponse)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.esResponseArea)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitMain)).BeginInit();
            this.splitMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lcMessageTypes)).BeginInit();
            this.lcMessageTypes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gcFolders)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.wevFolders)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lcgMessageTypes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciMessageTypes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciSendNew)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lcMain)).BeginInit();
            this.lcMain.SuspendLayout();
            this.statusStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelTop)).BeginInit();
            this.panelTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lcTopPanel)).BeginInit();
            this.lcTopPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.peFredroLabel.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.peSettings.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.peAva.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lcgTopPanel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciAva)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciSettings)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciFredroLabel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciLabel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lcgMain)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciSplitMain)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciPanelTop)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciStatusStrip)).BeginInit();
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
            this.splitMessages.Size = new System.Drawing.Size(805, 471);
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
            this.gcMessages.Size = new System.Drawing.Size(419, 471);
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
            this.wevMessages.OptionsFind.ShowFindButton = false;
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
            this.lcMessage.Controls.Add(this.btnSendResponse);
            this.lcMessage.Controls.Add(this.meResponseBody);
            this.lcMessage.Controls.Add(this.ddbMove);
            this.lcMessage.Controls.Add(this.btnAddTask);
            this.lcMessage.Controls.Add(this.btnAddDeal);
            this.lcMessage.Controls.Add(this.btnAddClient);
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
            this.lcMessage.Name = "lcMessage";
            this.lcMessage.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = new System.Drawing.Rectangle(424, 341, 633, 350);
            this.lcMessage.Root = this.lcgMessage;
            this.lcMessage.Size = new System.Drawing.Size(381, 471);
            this.lcMessage.TabIndex = 0;
            this.lcMessage.Text = "layoutControl1";
            // 
            // btnSendResponse
            // 
            this.btnSendResponse.AllowFocus = false;
            this.btnSendResponse.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSendResponse.Location = new System.Drawing.Point(411, 419);
            this.btnSendResponse.Name = "btnSendResponse";
            this.btnSendResponse.Size = new System.Drawing.Size(95, 28);
            this.btnSendResponse.StyleController = this.lcMessage;
            this.btnSendResponse.TabIndex = 19;
            this.btnSendResponse.Text = "Отправить";
            // 
            // meResponseBody
            // 
            this.meResponseBody.Location = new System.Drawing.Point(7, 339);
            this.meResponseBody.Name = "meResponseBody";
            this.meResponseBody.Properties.AllowHtmlDraw = DevExpress.Utils.DefaultBoolean.True;
            this.meResponseBody.Properties.NullValuePrompt = "Ответить...";
            this.meResponseBody.Properties.NullValuePromptShowForEmptyValue = true;
            this.meResponseBody.Properties.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.meResponseBody.Size = new System.Drawing.Size(499, 76);
            this.meResponseBody.StyleController = this.lcMessage;
            this.meResponseBody.TabIndex = 18;
            // 
            // ddbMove
            // 
            this.ddbMove.AllowFocus = false;
            this.ddbMove.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ddbMove.Enabled = false;
            this.ddbMove.Location = new System.Drawing.Point(370, 7);
            this.ddbMove.Name = "ddbMove";
            this.ddbMove.Size = new System.Drawing.Size(126, 28);
            this.ddbMove.StyleController = this.lcMessage;
            this.ddbMove.TabIndex = 17;
            this.ddbMove.Text = "Переместить";
            // 
            // btnAddTask
            // 
            this.btnAddTask.AllowFocus = false;
            this.btnAddTask.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddTask.Enabled = false;
            this.btnAddTask.Location = new System.Drawing.Point(257, 120);
            this.btnAddTask.Name = "btnAddTask";
            this.btnAddTask.Size = new System.Drawing.Size(121, 28);
            this.btnAddTask.StyleController = this.lcMessage;
            this.btnAddTask.TabIndex = 15;
            this.btnAddTask.Text = "Новая задача";
            // 
            // btnAddDeal
            // 
            this.btnAddDeal.AllowFocus = false;
            this.btnAddDeal.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddDeal.Enabled = false;
            this.btnAddDeal.Location = new System.Drawing.Point(132, 120);
            this.btnAddDeal.Name = "btnAddDeal";
            this.btnAddDeal.Size = new System.Drawing.Size(121, 28);
            this.btnAddDeal.StyleController = this.lcMessage;
            this.btnAddDeal.TabIndex = 14;
            this.btnAddDeal.Text = "Новая сделка";
            // 
            // btnAddClient
            // 
            this.btnAddClient.AllowFocus = false;
            this.btnAddClient.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddClient.Enabled = false;
            this.btnAddClient.Location = new System.Drawing.Point(7, 120);
            this.btnAddClient.Name = "btnAddClient";
            this.btnAddClient.Size = new System.Drawing.Size(121, 28);
            this.btnAddClient.StyleController = this.lcMessage;
            this.btnAddClient.TabIndex = 13;
            this.btnAddClient.Text = "Новый клиент";
            // 
            // btnRemove
            // 
            this.btnRemove.AllowFocus = false;
            this.btnRemove.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRemove.Enabled = false;
            this.btnRemove.Location = new System.Drawing.Point(249, 7);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(117, 28);
            this.btnRemove.StyleController = this.lcMessage;
            this.btnRemove.TabIndex = 12;
            this.btnRemove.Text = "Удалить";
            // 
            // btnResend
            // 
            this.btnResend.AllowFocus = false;
            this.btnResend.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnResend.Enabled = false;
            this.btnResend.Location = new System.Drawing.Point(128, 7);
            this.btnResend.Name = "btnResend";
            this.btnResend.Size = new System.Drawing.Size(117, 28);
            this.btnResend.StyleController = this.lcMessage;
            this.btnResend.TabIndex = 11;
            this.btnResend.Text = "Переслать";
            // 
            // btnReply
            // 
            this.btnReply.AllowFocus = false;
            this.btnReply.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnReply.Location = new System.Drawing.Point(7, 7);
            this.btnReply.Name = "btnReply";
            this.btnReply.Size = new System.Drawing.Size(117, 28);
            this.btnReply.StyleController = this.lcMessage;
            this.btnReply.TabIndex = 10;
            this.btnReply.Text = "Ответить";
            // 
            // meBody
            // 
            this.meBody.Location = new System.Drawing.Point(7, 155);
            this.meBody.Name = "meBody";
            this.meBody.Properties.AllowHtmlDraw = DevExpress.Utils.DefaultBoolean.True;
            this.meBody.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.meBody.Size = new System.Drawing.Size(499, 180);
            this.meBody.StyleController = this.lcMessage;
            this.meBody.TabIndex = 9;
            // 
            // peUser
            // 
            this.peUser.EditValue = global::FredroClient.Properties.Resources.user_64x64;
            this.peUser.Location = new System.Drawing.Point(7, 66);
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
            this.labelDate.Location = new System.Drawing.Point(453, 66);
            this.labelDate.Name = "labelDate";
            this.labelDate.Size = new System.Drawing.Size(53, 16);
            this.labelDate.StyleController = this.lcMessage;
            this.labelDate.TabIndex = 7;
            this.labelDate.Text = "labelDate";
            // 
            // labelTo
            // 
            this.labelTo.Location = new System.Drawing.Point(54, 86);
            this.labelTo.Name = "labelTo";
            this.labelTo.Size = new System.Drawing.Size(452, 23);
            this.labelTo.StyleController = this.lcMessage;
            this.labelTo.TabIndex = 6;
            this.labelTo.Text = "labelTo";
            // 
            // labelSubject
            // 
            this.labelSubject.Appearance.Font = new System.Drawing.Font("Tahoma", 14F);
            this.labelSubject.Location = new System.Drawing.Point(7, 39);
            this.labelSubject.Name = "labelSubject";
            this.labelSubject.Size = new System.Drawing.Size(102, 23);
            this.labelSubject.StyleController = this.lcMessage;
            this.labelSubject.TabIndex = 5;
            this.labelSubject.Text = "labelSubject";
            // 
            // labelFrom
            // 
            this.labelFrom.Location = new System.Drawing.Point(54, 66);
            this.labelFrom.Name = "labelFrom";
            this.labelFrom.Size = new System.Drawing.Size(395, 16);
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
            this.lciReply,
            this.lciResend,
            this.lciRemove,
            this.esMessageButtons,
            this.lciAddClient,
            this.lciAddDeal,
            this.lciAddTask,
            this.esClientButtons,
            this.lciMove,
            this.lciResponseBody,
            this.lciSendResponse,
            this.esResponseArea});
            this.lcgMessage.Location = new System.Drawing.Point(0, 0);
            this.lcgMessage.Name = "Root";
            this.lcgMessage.Padding = new DevExpress.XtraLayout.Utils.Padding(5, 5, 5, 5);
            this.lcgMessage.Size = new System.Drawing.Size(513, 454);
            this.lcgMessage.TextVisible = false;
            // 
            // lciFrom
            // 
            this.lciFrom.Control = this.labelFrom;
            this.lciFrom.Location = new System.Drawing.Point(47, 59);
            this.lciFrom.MinSize = new System.Drawing.Size(50, 17);
            this.lciFrom.Name = "lciFrom";
            this.lciFrom.Size = new System.Drawing.Size(399, 20);
            this.lciFrom.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.lciFrom.TextSize = new System.Drawing.Size(0, 0);
            this.lciFrom.TextVisible = false;
            // 
            // lciTo
            // 
            this.lciTo.Control = this.labelTo;
            this.lciTo.Location = new System.Drawing.Point(47, 79);
            this.lciTo.MinSize = new System.Drawing.Size(46, 20);
            this.lciTo.Name = "lciTo";
            this.lciTo.Size = new System.Drawing.Size(456, 27);
            this.lciTo.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.lciTo.TextSize = new System.Drawing.Size(0, 0);
            this.lciTo.TextVisible = false;
            // 
            // lciSubject
            // 
            this.lciSubject.Control = this.labelSubject;
            this.lciSubject.Location = new System.Drawing.Point(0, 32);
            this.lciSubject.Name = "lciSubject";
            this.lciSubject.Size = new System.Drawing.Size(503, 27);
            this.lciSubject.TextSize = new System.Drawing.Size(0, 0);
            this.lciSubject.TextVisible = false;
            // 
            // lciDate
            // 
            this.lciDate.Control = this.labelDate;
            this.lciDate.Location = new System.Drawing.Point(446, 59);
            this.lciDate.Name = "lciDate";
            this.lciDate.Size = new System.Drawing.Size(57, 20);
            this.lciDate.TextSize = new System.Drawing.Size(0, 0);
            this.lciDate.TextVisible = false;
            // 
            // separator
            // 
            this.separator.AllowHotTrack = false;
            this.separator.Location = new System.Drawing.Point(0, 111);
            this.separator.Name = "separator";
            this.separator.Size = new System.Drawing.Size(503, 2);
            // 
            // lciPictureUser
            // 
            this.lciPictureUser.Control = this.peUser;
            this.lciPictureUser.Location = new System.Drawing.Point(0, 59);
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
            this.lciBody.Location = new System.Drawing.Point(0, 145);
            this.lciBody.Name = "lciBody";
            this.lciBody.Padding = new DevExpress.XtraLayout.Utils.Padding(2, 2, 5, 2);
            this.lciBody.Size = new System.Drawing.Size(503, 187);
            this.lciBody.TextSize = new System.Drawing.Size(0, 0);
            this.lciBody.TextVisible = false;
            // 
            // emptySpaceItem1
            // 
            this.emptySpaceItem1.AllowHotTrack = false;
            this.emptySpaceItem1.Location = new System.Drawing.Point(0, 106);
            this.emptySpaceItem1.MaxSize = new System.Drawing.Size(0, 5);
            this.emptySpaceItem1.MinSize = new System.Drawing.Size(10, 5);
            this.emptySpaceItem1.Name = "emptySpaceItem1";
            this.emptySpaceItem1.Size = new System.Drawing.Size(503, 5);
            this.emptySpaceItem1.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.emptySpaceItem1.TextSize = new System.Drawing.Size(0, 0);
            // 
            // lciReply
            // 
            this.lciReply.Control = this.btnReply;
            this.lciReply.Location = new System.Drawing.Point(0, 0);
            this.lciReply.MaxSize = new System.Drawing.Size(121, 32);
            this.lciReply.MinSize = new System.Drawing.Size(121, 32);
            this.lciReply.Name = "lciReply";
            this.lciReply.Size = new System.Drawing.Size(121, 32);
            this.lciReply.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.lciReply.TextSize = new System.Drawing.Size(0, 0);
            this.lciReply.TextVisible = false;
            // 
            // lciResend
            // 
            this.lciResend.Control = this.btnResend;
            this.lciResend.Location = new System.Drawing.Point(121, 0);
            this.lciResend.MaxSize = new System.Drawing.Size(121, 32);
            this.lciResend.MinSize = new System.Drawing.Size(121, 32);
            this.lciResend.Name = "lciResend";
            this.lciResend.Size = new System.Drawing.Size(121, 32);
            this.lciResend.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.lciResend.TextSize = new System.Drawing.Size(0, 0);
            this.lciResend.TextVisible = false;
            // 
            // lciRemove
            // 
            this.lciRemove.Control = this.btnRemove;
            this.lciRemove.Location = new System.Drawing.Point(242, 0);
            this.lciRemove.MaxSize = new System.Drawing.Size(121, 32);
            this.lciRemove.MinSize = new System.Drawing.Size(121, 32);
            this.lciRemove.Name = "lciRemove";
            this.lciRemove.Size = new System.Drawing.Size(121, 32);
            this.lciRemove.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.lciRemove.TextSize = new System.Drawing.Size(0, 0);
            this.lciRemove.TextVisible = false;
            // 
            // esMessageButtons
            // 
            this.esMessageButtons.AllowHotTrack = false;
            this.esMessageButtons.Location = new System.Drawing.Point(493, 0);
            this.esMessageButtons.MaxSize = new System.Drawing.Size(0, 32);
            this.esMessageButtons.MinSize = new System.Drawing.Size(10, 32);
            this.esMessageButtons.Name = "esMessageButtons";
            this.esMessageButtons.Size = new System.Drawing.Size(10, 32);
            this.esMessageButtons.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.esMessageButtons.TextSize = new System.Drawing.Size(0, 0);
            // 
            // lciAddClient
            // 
            this.lciAddClient.Control = this.btnAddClient;
            this.lciAddClient.Location = new System.Drawing.Point(0, 113);
            this.lciAddClient.MaxSize = new System.Drawing.Size(125, 32);
            this.lciAddClient.MinSize = new System.Drawing.Size(125, 32);
            this.lciAddClient.Name = "lciAddClient";
            this.lciAddClient.Size = new System.Drawing.Size(125, 32);
            this.lciAddClient.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.lciAddClient.TextSize = new System.Drawing.Size(0, 0);
            this.lciAddClient.TextVisible = false;
            // 
            // lciAddDeal
            // 
            this.lciAddDeal.Control = this.btnAddDeal;
            this.lciAddDeal.Location = new System.Drawing.Point(125, 113);
            this.lciAddDeal.MaxSize = new System.Drawing.Size(125, 32);
            this.lciAddDeal.MinSize = new System.Drawing.Size(125, 32);
            this.lciAddDeal.Name = "lciAddDeal";
            this.lciAddDeal.Size = new System.Drawing.Size(125, 32);
            this.lciAddDeal.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.lciAddDeal.TextSize = new System.Drawing.Size(0, 0);
            this.lciAddDeal.TextVisible = false;
            // 
            // lciAddTask
            // 
            this.lciAddTask.Control = this.btnAddTask;
            this.lciAddTask.Location = new System.Drawing.Point(250, 113);
            this.lciAddTask.MaxSize = new System.Drawing.Size(125, 32);
            this.lciAddTask.MinSize = new System.Drawing.Size(125, 32);
            this.lciAddTask.Name = "lciAddTask";
            this.lciAddTask.Size = new System.Drawing.Size(125, 32);
            this.lciAddTask.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.lciAddTask.TextSize = new System.Drawing.Size(0, 0);
            this.lciAddTask.TextVisible = false;
            // 
            // esClientButtons
            // 
            this.esClientButtons.AllowHotTrack = false;
            this.esClientButtons.Location = new System.Drawing.Point(375, 113);
            this.esClientButtons.MaxSize = new System.Drawing.Size(0, 32);
            this.esClientButtons.MinSize = new System.Drawing.Size(10, 32);
            this.esClientButtons.Name = "esClientButtons";
            this.esClientButtons.Size = new System.Drawing.Size(128, 32);
            this.esClientButtons.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.esClientButtons.TextSize = new System.Drawing.Size(0, 0);
            // 
            // lciMove
            // 
            this.lciMove.Control = this.ddbMove;
            this.lciMove.Location = new System.Drawing.Point(363, 0);
            this.lciMove.MaxSize = new System.Drawing.Size(130, 32);
            this.lciMove.MinSize = new System.Drawing.Size(130, 32);
            this.lciMove.Name = "lciMove";
            this.lciMove.Size = new System.Drawing.Size(130, 32);
            this.lciMove.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.lciMove.TextSize = new System.Drawing.Size(0, 0);
            this.lciMove.TextVisible = false;
            // 
            // lciResponseBody
            // 
            this.lciResponseBody.Control = this.meResponseBody;
            this.lciResponseBody.Location = new System.Drawing.Point(0, 332);
            this.lciResponseBody.Name = "lciResponseBody";
            this.lciResponseBody.Size = new System.Drawing.Size(503, 80);
            this.lciResponseBody.TextSize = new System.Drawing.Size(0, 0);
            this.lciResponseBody.TextVisible = false;
            this.lciResponseBody.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
            // 
            // lciSendResponse
            // 
            this.lciSendResponse.Control = this.btnSendResponse;
            this.lciSendResponse.Location = new System.Drawing.Point(404, 412);
            this.lciSendResponse.MaxSize = new System.Drawing.Size(99, 32);
            this.lciSendResponse.MinSize = new System.Drawing.Size(99, 32);
            this.lciSendResponse.Name = "lciSendResponse";
            this.lciSendResponse.Size = new System.Drawing.Size(99, 32);
            this.lciSendResponse.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.lciSendResponse.TextSize = new System.Drawing.Size(0, 0);
            this.lciSendResponse.TextVisible = false;
            // 
            // esResponseArea
            // 
            this.esResponseArea.AllowHotTrack = false;
            this.esResponseArea.Location = new System.Drawing.Point(0, 412);
            this.esResponseArea.Name = "esResponseArea";
            this.esResponseArea.Size = new System.Drawing.Size(404, 32);
            this.esResponseArea.TextSize = new System.Drawing.Size(0, 0);
            // 
            // colFrom
            // 
            this.colFrom.FieldName = "From";
            this.colFrom.Name = "colFrom";
            this.colFrom.Visible = true;
            this.colFrom.VisibleIndex = 0;
            // 
            // splitMain
            // 
            this.splitMain.Location = new System.Drawing.Point(0, 40);
            this.splitMain.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.splitMain.Name = "splitMain";
            this.splitMain.Panel1.Controls.Add(this.lcMessageTypes);
            this.splitMain.Panel1.Text = "Panel1";
            this.splitMain.Panel2.Controls.Add(this.splitMessages);
            this.splitMain.Panel2.Text = "Panel2";
            this.splitMain.Size = new System.Drawing.Size(1013, 471);
            this.splitMain.SplitterPosition = 203;
            this.splitMain.TabIndex = 1;
            this.splitMain.Text = "splitContainerControl1";
            // 
            // lcMessageTypes
            // 
            this.lcMessageTypes.Controls.Add(this.btnSendNew);
            this.lcMessageTypes.Controls.Add(this.gcFolders);
            this.lcMessageTypes.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lcMessageTypes.Location = new System.Drawing.Point(0, 0);
            this.lcMessageTypes.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lcMessageTypes.Name = "lcMessageTypes";
            this.lcMessageTypes.Root = this.lcgMessageTypes;
            this.lcMessageTypes.Size = new System.Drawing.Size(203, 471);
            this.lcMessageTypes.TabIndex = 0;
            this.lcMessageTypes.Text = "layoutControl1";
            // 
            // btnSendNew
            // 
            this.btnSendNew.Appearance.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnSendNew.Appearance.Options.UseFont = true;
            this.btnSendNew.CausesValidation = false;
            this.btnSendNew.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSendNew.Location = new System.Drawing.Point(5, 5);
            this.btnSendNew.Name = "btnSendNew";
            this.btnSendNew.ShowFocusRectangle = DevExpress.Utils.DefaultBoolean.False;
            this.btnSendNew.Size = new System.Drawing.Size(193, 37);
            this.btnSendNew.StyleController = this.lcMessageTypes;
            this.btnSendNew.TabIndex = 5;
            this.btnSendNew.Text = "Написать";
            // 
            // gcFolders
            // 
            this.gcFolders.Location = new System.Drawing.Point(0, 47);
            this.gcFolders.MainView = this.wevFolders;
            this.gcFolders.Name = "gcFolders";
            this.gcFolders.Size = new System.Drawing.Size(203, 424);
            this.gcFolders.TabIndex = 4;
            this.gcFolders.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.wevFolders});
            // 
            // wevFolders
            // 
            this.wevFolders.Appearance.ItemHovered.Font = new System.Drawing.Font("Tahoma", 11F);
            this.wevFolders.Appearance.ItemHovered.Options.UseFont = true;
            this.wevFolders.Appearance.ItemNormal.Font = new System.Drawing.Font("Tahoma", 10F);
            this.wevFolders.Appearance.ItemNormal.Options.UseFont = true;
            this.wevFolders.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.wevFolders.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colCaption});
            this.wevFolders.ColumnSet.TextColumn = this.colCaption;
            this.wevFolders.GridControl = this.gcFolders;
            this.wevFolders.Name = "wevFolders";
            this.wevFolders.OptionsBehavior.Editable = false;
            this.wevFolders.OptionsView.Style = DevExpress.XtraGrid.Views.WinExplorer.WinExplorerViewStyle.Small;
            this.wevFolders.OptionsViewStyles.Small.ImageToTextIndent = -10;
            this.wevFolders.OptionsViewStyles.Small.ShowDescription = DevExpress.Utils.DefaultBoolean.False;
            // 
            // colCaption
            // 
            this.colCaption.FieldName = "Caption";
            this.colCaption.Name = "colCaption";
            this.colCaption.Visible = true;
            this.colCaption.VisibleIndex = 0;
            // 
            // lcgMessageTypes
            // 
            this.lcgMessageTypes.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.False;
            this.lcgMessageTypes.GroupBordersVisible = false;
            this.lcgMessageTypes.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.lciMessageTypes,
            this.lciSendNew});
            this.lcgMessageTypes.Location = new System.Drawing.Point(0, 0);
            this.lcgMessageTypes.Name = "lcgMessageTypes";
            this.lcgMessageTypes.Padding = new DevExpress.XtraLayout.Utils.Padding(5, 5, 5, 5);
            this.lcgMessageTypes.Size = new System.Drawing.Size(203, 471);
            this.lcgMessageTypes.TextVisible = false;
            // 
            // lciMessageTypes
            // 
            this.lciMessageTypes.Control = this.gcFolders;
            this.lciMessageTypes.Location = new System.Drawing.Point(0, 47);
            this.lciMessageTypes.Name = "lciMessageTypes";
            this.lciMessageTypes.Padding = new DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 0);
            this.lciMessageTypes.Size = new System.Drawing.Size(203, 424);
            this.lciMessageTypes.TextSize = new System.Drawing.Size(0, 0);
            this.lciMessageTypes.TextVisible = false;
            // 
            // lciSendNew
            // 
            this.lciSendNew.Control = this.btnSendNew;
            this.lciSendNew.Location = new System.Drawing.Point(0, 0);
            this.lciSendNew.MaxSize = new System.Drawing.Size(0, 47);
            this.lciSendNew.MinSize = new System.Drawing.Size(63, 47);
            this.lciSendNew.Name = "lciSendNew";
            this.lciSendNew.Padding = new DevExpress.XtraLayout.Utils.Padding(5, 5, 5, 5);
            this.lciSendNew.Size = new System.Drawing.Size(203, 47);
            this.lciSendNew.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.lciSendNew.TextSize = new System.Drawing.Size(0, 0);
            this.lciSendNew.TextVisible = false;
            // 
            // lcMain
            // 
            this.lcMain.Controls.Add(this.statusStrip);
            this.lcMain.Controls.Add(this.panelTop);
            this.lcMain.Controls.Add(this.splitMain);
            this.lcMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lcMain.Location = new System.Drawing.Point(0, 0);
            this.lcMain.Name = "lcMain";
            this.lcMain.Root = this.lcgMain;
            this.lcMain.Size = new System.Drawing.Size(1013, 531);
            this.lcMain.TabIndex = 2;
            this.lcMain.Text = "layoutControl1";
            // 
            // statusStrip
            // 
            this.statusStrip.AutoSize = false;
            this.statusStrip.BackColor = System.Drawing.Color.Transparent;
            this.statusStrip.Dock = System.Windows.Forms.DockStyle.None;
            this.statusStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsslLeftText,
            this.tsslRightText});
            this.statusStrip.Location = new System.Drawing.Point(0, 511);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Size = new System.Drawing.Size(1013, 20);
            this.statusStrip.TabIndex = 4;
            this.statusStrip.Text = "statusStrip1";
            // 
            // tsslLeftText
            // 
            this.tsslLeftText.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tsslLeftText.Name = "tsslLeftText";
            this.tsslLeftText.Size = new System.Drawing.Size(101, 15);
            this.tsslLeftText.Text = "toolStripLeftText";
            // 
            // tsslRightText
            // 
            this.tsslRightText.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tsslRightText.Name = "tsslRightText";
            this.tsslRightText.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.tsslRightText.Size = new System.Drawing.Size(897, 15);
            this.tsslRightText.Spring = true;
            this.tsslRightText.Text = "tsslRightText";
            this.tsslRightText.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panelTop
            // 
            this.panelTop.Controls.Add(this.lcTopPanel);
            this.panelTop.Location = new System.Drawing.Point(0, 0);
            this.panelTop.Name = "panelTop";
            this.panelTop.Size = new System.Drawing.Size(1013, 40);
            this.panelTop.TabIndex = 2;
            // 
            // lcTopPanel
            // 
            this.lcTopPanel.Controls.Add(this.labelFredro);
            this.lcTopPanel.Controls.Add(this.peFredroLabel);
            this.lcTopPanel.Controls.Add(this.peSettings);
            this.lcTopPanel.Controls.Add(this.peAva);
            this.lcTopPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lcTopPanel.Location = new System.Drawing.Point(2, 2);
            this.lcTopPanel.Name = "lcTopPanel";
            this.lcTopPanel.Root = this.lcgTopPanel;
            this.lcTopPanel.Size = new System.Drawing.Size(1009, 36);
            this.lcTopPanel.TabIndex = 1;
            this.lcTopPanel.Text = "layoutControl1";
            // 
            // labelFredro
            // 
            this.labelFredro.Appearance.Font = new System.Drawing.Font("Tahoma", 12F);
            this.labelFredro.Appearance.ForeColor = System.Drawing.Color.LavenderBlush;
            this.labelFredro.Location = new System.Drawing.Point(136, 4);
            this.labelFredro.Name = "labelFredro";
            this.labelFredro.Size = new System.Drawing.Size(207, 28);
            this.labelFredro.StyleController = this.lcTopPanel;
            this.labelFredro.TabIndex = 7;
            this.labelFredro.Text = "Фрэдро клиент";
            // 
            // peFredroLabel
            // 
            this.peFredroLabel.EditValue = global::FredroClient.Properties.Resources.FredroClient3;
            this.peFredroLabel.Location = new System.Drawing.Point(12, 2);
            this.peFredroLabel.Name = "peFredroLabel";
            this.peFredroLabel.Properties.AllowFocused = false;
            this.peFredroLabel.Properties.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.peFredroLabel.Properties.Appearance.Options.UseBackColor = true;
            this.peFredroLabel.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.peFredroLabel.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.Auto;
            this.peFredroLabel.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Zoom;
            this.peFredroLabel.Size = new System.Drawing.Size(118, 32);
            this.peFredroLabel.StyleController = this.lcTopPanel;
            this.peFredroLabel.TabIndex = 6;
            // 
            // peSettings
            // 
            this.peSettings.Cursor = System.Windows.Forms.Cursors.Hand;
            this.peSettings.EditValue = global::FredroClient.Properties.Resources.menu_icon3_64x64;
            this.peSettings.Location = new System.Drawing.Point(935, 8);
            this.peSettings.Name = "peSettings";
            this.peSettings.Properties.AllowFocused = false;
            this.peSettings.Properties.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.peSettings.Properties.Appearance.Options.UseBackColor = true;
            this.peSettings.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.peSettings.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.Auto;
            this.peSettings.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Zoom;
            this.peSettings.Size = new System.Drawing.Size(20, 20);
            this.peSettings.StyleController = this.lcTopPanel;
            this.peSettings.TabIndex = 5;
            // 
            // peAva
            // 
            this.peAva.Cursor = System.Windows.Forms.Cursors.Hand;
            this.peAva.EditValue = ((object)(resources.GetObject("peAva.EditValue")));
            this.peAva.Location = new System.Drawing.Point(965, 2);
            this.peAva.Name = "peAva";
            this.peAva.Properties.AllowFocused = false;
            this.peAva.Properties.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.peAva.Properties.Appearance.Options.UseBackColor = true;
            this.peAva.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.peAva.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.Auto;
            this.peAva.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Zoom;
            this.peAva.Size = new System.Drawing.Size(32, 32);
            this.peAva.StyleController = this.lcTopPanel;
            this.peAva.TabIndex = 4;
            // 
            // lcgTopPanel
            // 
            this.lcgTopPanel.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.lcgTopPanel.GroupBordersVisible = false;
            this.lcgTopPanel.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.lciAva,
            this.emptySpaceItem4,
            this.emptySpaceItem5,
            this.lciSettings,
            this.lciFredroLabel,
            this.lciLabel,
            this.emptySpaceItem6});
            this.lcgTopPanel.Location = new System.Drawing.Point(0, 0);
            this.lcgTopPanel.Name = "lcgTopPanel";
            this.lcgTopPanel.Padding = new DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 0);
            this.lcgTopPanel.Size = new System.Drawing.Size(1009, 36);
            this.lcgTopPanel.TextVisible = false;
            // 
            // lciAva
            // 
            this.lciAva.Control = this.peAva;
            this.lciAva.Location = new System.Drawing.Point(963, 0);
            this.lciAva.MaxSize = new System.Drawing.Size(36, 36);
            this.lciAva.MinSize = new System.Drawing.Size(36, 36);
            this.lciAva.Name = "lciAva";
            this.lciAva.Size = new System.Drawing.Size(36, 36);
            this.lciAva.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.lciAva.TextSize = new System.Drawing.Size(0, 0);
            this.lciAva.TextVisible = false;
            // 
            // emptySpaceItem4
            // 
            this.emptySpaceItem4.AllowHotTrack = false;
            this.emptySpaceItem4.Location = new System.Drawing.Point(347, 0);
            this.emptySpaceItem4.Name = "emptySpaceItem4";
            this.emptySpaceItem4.Size = new System.Drawing.Size(580, 36);
            this.emptySpaceItem4.TextSize = new System.Drawing.Size(0, 0);
            // 
            // emptySpaceItem5
            // 
            this.emptySpaceItem5.AllowHotTrack = false;
            this.emptySpaceItem5.Location = new System.Drawing.Point(999, 0);
            this.emptySpaceItem5.MaxSize = new System.Drawing.Size(10, 36);
            this.emptySpaceItem5.MinSize = new System.Drawing.Size(10, 36);
            this.emptySpaceItem5.Name = "emptySpaceItem5";
            this.emptySpaceItem5.Size = new System.Drawing.Size(10, 36);
            this.emptySpaceItem5.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.emptySpaceItem5.TextSize = new System.Drawing.Size(0, 0);
            // 
            // lciSettings
            // 
            this.lciSettings.Control = this.peSettings;
            this.lciSettings.Location = new System.Drawing.Point(927, 0);
            this.lciSettings.MaxSize = new System.Drawing.Size(36, 36);
            this.lciSettings.MinSize = new System.Drawing.Size(36, 36);
            this.lciSettings.Name = "lciSettings";
            this.lciSettings.Padding = new DevExpress.XtraLayout.Utils.Padding(8, 8, 8, 8);
            this.lciSettings.Size = new System.Drawing.Size(36, 36);
            this.lciSettings.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.lciSettings.TextSize = new System.Drawing.Size(0, 0);
            this.lciSettings.TextVisible = false;
            // 
            // lciFredroLabel
            // 
            this.lciFredroLabel.Control = this.peFredroLabel;
            this.lciFredroLabel.Location = new System.Drawing.Point(10, 0);
            this.lciFredroLabel.MaxSize = new System.Drawing.Size(122, 36);
            this.lciFredroLabel.MinSize = new System.Drawing.Size(122, 36);
            this.lciFredroLabel.Name = "lciFredroLabel";
            this.lciFredroLabel.Size = new System.Drawing.Size(122, 36);
            this.lciFredroLabel.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.lciFredroLabel.TextSize = new System.Drawing.Size(0, 0);
            this.lciFredroLabel.TextVisible = false;
            this.lciFredroLabel.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
            // 
            // lciLabel
            // 
            this.lciLabel.Control = this.labelFredro;
            this.lciLabel.Location = new System.Drawing.Point(132, 0);
            this.lciLabel.MinSize = new System.Drawing.Size(215, 32);
            this.lciLabel.Name = "lciLabel";
            this.lciLabel.Padding = new DevExpress.XtraLayout.Utils.Padding(4, 4, 4, 4);
            this.lciLabel.Size = new System.Drawing.Size(215, 36);
            this.lciLabel.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.lciLabel.TextSize = new System.Drawing.Size(0, 0);
            this.lciLabel.TextVisible = false;
            // 
            // emptySpaceItem6
            // 
            this.emptySpaceItem6.AllowHotTrack = false;
            this.emptySpaceItem6.Location = new System.Drawing.Point(0, 0);
            this.emptySpaceItem6.MaxSize = new System.Drawing.Size(10, 0);
            this.emptySpaceItem6.MinSize = new System.Drawing.Size(10, 10);
            this.emptySpaceItem6.Name = "emptySpaceItem6";
            this.emptySpaceItem6.Size = new System.Drawing.Size(10, 36);
            this.emptySpaceItem6.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.emptySpaceItem6.TextSize = new System.Drawing.Size(0, 0);
            // 
            // lcgMain
            // 
            this.lcgMain.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.False;
            this.lcgMain.GroupBordersVisible = false;
            this.lcgMain.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.lciSplitMain,
            this.lciPanelTop,
            this.lciStatusStrip});
            this.lcgMain.Location = new System.Drawing.Point(0, 0);
            this.lcgMain.Name = "lcgMain";
            this.lcgMain.Size = new System.Drawing.Size(1013, 531);
            this.lcgMain.TextVisible = false;
            // 
            // lciSplitMain
            // 
            this.lciSplitMain.Control = this.splitMain;
            this.lciSplitMain.Location = new System.Drawing.Point(0, 40);
            this.lciSplitMain.Name = "lciSplitMain";
            this.lciSplitMain.Padding = new DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 0);
            this.lciSplitMain.Size = new System.Drawing.Size(1013, 471);
            this.lciSplitMain.TextSize = new System.Drawing.Size(0, 0);
            this.lciSplitMain.TextVisible = false;
            // 
            // lciPanelTop
            // 
            this.lciPanelTop.Control = this.panelTop;
            this.lciPanelTop.Location = new System.Drawing.Point(0, 0);
            this.lciPanelTop.MaxSize = new System.Drawing.Size(0, 40);
            this.lciPanelTop.MinSize = new System.Drawing.Size(5, 40);
            this.lciPanelTop.Name = "lciPanelTop";
            this.lciPanelTop.Padding = new DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 0);
            this.lciPanelTop.Size = new System.Drawing.Size(1013, 40);
            this.lciPanelTop.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.lciPanelTop.TextSize = new System.Drawing.Size(0, 0);
            this.lciPanelTop.TextVisible = false;
            // 
            // lciStatusStrip
            // 
            this.lciStatusStrip.Control = this.statusStrip;
            this.lciStatusStrip.Location = new System.Drawing.Point(0, 511);
            this.lciStatusStrip.MaxSize = new System.Drawing.Size(0, 20);
            this.lciStatusStrip.MinSize = new System.Drawing.Size(100, 20);
            this.lciStatusStrip.Name = "lciStatusStrip";
            this.lciStatusStrip.Padding = new DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 0);
            this.lciStatusStrip.Size = new System.Drawing.Size(1013, 20);
            this.lciStatusStrip.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.lciStatusStrip.TextSize = new System.Drawing.Size(0, 0);
            this.lciStatusStrip.TextVisible = false;
            // 
            // frmMessages
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1013, 531);
            this.Controls.Add(this.lcMain);
            this.Margin = new System.Windows.Forms.Padding(3, 3, 3, 3);
            this.Name = "frmMessages";
            this.Text = "";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.splitMessages)).EndInit();
            this.splitMessages.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gcMessages)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.wevMessages)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lcMessage)).EndInit();
            this.lcMessage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.meResponseBody.Properties)).EndInit();
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
            ((System.ComponentModel.ISupportInitialize)(this.lciReply)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciResend)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciRemove)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.esMessageButtons)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciAddClient)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciAddDeal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciAddTask)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.esClientButtons)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciMove)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciResponseBody)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciSendResponse)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.esResponseArea)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitMain)).EndInit();
            this.splitMain.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.lcMessageTypes)).EndInit();
            this.lcMessageTypes.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gcFolders)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.wevFolders)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lcgMessageTypes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciMessageTypes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciSendNew)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lcMain)).EndInit();
            this.lcMain.ResumeLayout(false);
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelTop)).EndInit();
            this.panelTop.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.lcTopPanel)).EndInit();
            this.lcTopPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.peFredroLabel.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.peSettings.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.peAva.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lcgTopPanel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciAva)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciSettings)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciFredroLabel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciLabel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lcgMain)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciSplitMain)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciPanelTop)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciStatusStrip)).EndInit();
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
        private DevExpress.XtraLayout.LayoutControlItem lciReply;
        private DevExpress.XtraLayout.LayoutControlItem lciResend;
        private DevExpress.XtraLayout.LayoutControlItem lciRemove;
        private DevExpress.XtraLayout.EmptySpaceItem esMessageButtons;
        private DevExpress.XtraEditors.SimpleButton btnAddTask;
        private DevExpress.XtraEditors.SimpleButton btnAddDeal;
        private DevExpress.XtraEditors.SimpleButton btnAddClient;
        private DevExpress.XtraLayout.LayoutControlItem lciAddDeal;
        private DevExpress.XtraLayout.LayoutControlItem lciAddTask;
        private DevExpress.XtraLayout.LayoutControlItem lciAddClient;
        private DevExpress.XtraLayout.EmptySpaceItem esClientButtons;
        private DevExpress.XtraEditors.DropDownButton ddbMove;
        private DevExpress.XtraLayout.LayoutControlItem lciMove;
        private DevExpress.XtraEditors.SplitContainerControl splitMain;
        private DevExpress.XtraLayout.LayoutControl lcMessageTypes;
        private DevExpress.XtraLayout.LayoutControlGroup lcgMessageTypes;
        private DevExpress.XtraGrid.GridControl gcFolders;
        private DevExpress.XtraGrid.Views.WinExplorer.WinExplorerView wevFolders;
        private DevExpress.XtraLayout.LayoutControlItem lciMessageTypes;
        private DevExpress.XtraGrid.Columns.GridColumn colCaption;
        private DevExpress.XtraEditors.SimpleButton btnSendNew;
        private DevExpress.XtraLayout.LayoutControlItem lciSendNew;
        private DevExpress.XtraEditors.MemoEdit meResponseBody;
        private DevExpress.XtraLayout.LayoutControlItem lciResponseBody;
        private DevExpress.XtraEditors.SimpleButton btnSendResponse;
        private DevExpress.XtraLayout.LayoutControlItem lciSendResponse;
        private DevExpress.XtraLayout.EmptySpaceItem esResponseArea;
        private DevExpress.XtraLayout.LayoutControl lcMain;
        private DevExpress.XtraLayout.LayoutControlGroup lcgMain;
        private DevExpress.XtraLayout.LayoutControlItem lciSplitMain;
        private DevExpress.XtraEditors.PanelControl panelTop;
        private DevExpress.XtraLayout.LayoutControlItem lciPanelTop;
        private System.Windows.Forms.StatusStrip statusStrip;
        private DevExpress.XtraLayout.LayoutControlItem lciStatusStrip;
        private System.Windows.Forms.ToolStripStatusLabel tsslLeftText;
        private System.Windows.Forms.ToolStripStatusLabel tsslRightText;
        private DevExpress.XtraLayout.LayoutControl lcTopPanel;
        private DevExpress.XtraEditors.PictureEdit peAva;
        private DevExpress.XtraLayout.LayoutControlGroup lcgTopPanel;
        private DevExpress.XtraLayout.LayoutControlItem lciAva;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem4;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem5;
        private DevExpress.XtraEditors.PictureEdit peSettings;
        private DevExpress.XtraLayout.LayoutControlItem lciSettings;
        private DevExpress.XtraEditors.PictureEdit peFredroLabel;
        private DevExpress.XtraLayout.LayoutControlItem lciFredroLabel;
        private DevExpress.XtraEditors.LabelControl labelFredro;
        private DevExpress.XtraLayout.LayoutControlItem lciLabel;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem6;
    }
}