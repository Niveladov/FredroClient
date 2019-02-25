using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FredroClient.Models;
using DevExpress.XtraEditors.ViewInfo;
using DevExpress.Utils.Drawing;
using DevExpress.XtraLayout.Utils;
using FredroClient.ExtraClasses;
using System.Globalization;
using FredroClient.Forms;
using FredroClient.BaseGUI;
using DevExpress.XtraEditors;
using FredroDAL.Models.DatabaseObjectModels.Tables;
using FredroDAL.Models;

namespace FredroClient.UserControls
{
    internal sealed partial class ucMails : ucBase
    {
        public string ParentFormText { get; private set; }

        private MailModel _model;
        private bool _isInit = false;

        public ucMails()
        {
            InitializeComponent();
        }

        public void Init(Credentials creds)
        {
            if (!_isInit)
            {
                _model = new MailModel(creds);
                InitEvents();
                _model.LoadMails();
                _isInit = true;
            }
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            if (!isDesignMode)
            {
                gcMails.DataSource = _model.MyMails.Where(x => x.IsIncoming);
                var inMessCount = _model.MyMails.Where(x => x.IsIncoming).Count();
                var outMessCount = _model.MyMails.Where(x => x.IsOutcoming).Count();
                gcFolders.DataSource = new List<Folder>()
                {
                    new Folder($"Входящие            {inMessCount.ToString()}"),
                    new Folder($"Отправленные     {outMessCount.ToString()}"),
                    new Folder($"Удалённые")
                };
                //InitEvents();
                //wevFolders.FocusedRowHandle = 0;
                //wevMails.FocusedRowHandle = 0;
                meBody.BackColor = lcMessage.BackColor;
                statusStrip.Items[0].Text = "Демо версия почтового клиента.";
                statusStrip.Items[1].Text = ""; // "Евгений Федорук, +7(952)383-23-01";
            }
        }

        private void InitEvents()
        {
            _model.NewMailsRecieved += OnNewMailRecieved;

            wevFolders.FocusedRowChanged += WevFolders_FocusedRowChanged;
            wevMails.FocusedRowChanged += WevMails_FocusedRowChanged;
            btnReply.Click += BtnReply_Click;
            btnSendResponse.Click += BtnSendResponse_Click;
            btnCancelResponce.Click += BtnCancelResponce_Click;
            btnSendNew.Click += BtnSendNew_Click;
            btnResend.Click += BtnResend_Click;
            btnAddDeal.Click += BtnAddDeal_Click;
            meResponseBody.TextChanged += MeResponseBody_TextChanged;
        }

        private void RefreshData()
        {
            var mailHandler = wevMails.FocusedRowHandle;
            var folderHandler = wevFolders.FocusedRowHandle;
            var incomingMails = _model.MyMails.Where(x => x.IsIncoming).ToList();
            var outgoingMails = _model.MyMails.Where(x => x.IsOutcoming).ToList();
            gcMails.DataSource = incomingMails;
            gcFolders.DataSource = new List<Folder>()
                {
                    new Folder($"Входящие            {incomingMails.Count.ToString()}"),
                    new Folder($"Отправленные     {outgoingMails.Count.ToString()}"),
                    new Folder($"Удалённые")
                };
            wevMails.FocusedRowHandle = mailHandler;
            wevFolders.FocusedRowHandle = folderHandler;
        }

        private void SetResponseBodyVisibility(bool isVisible)
        {
            if (!isVisible) meResponseBody.Text = "";

            lciResponseBody.Visibility = lciSendResponse.Visibility =
            lciCancelResponce.Visibility = esResponseArea.Visibility = 
                isVisible ? LayoutVisibility.Always : LayoutVisibility.Never;

            meBody.SetScrollBarVisibility();
        }

        private void SetMessageButtonsVisibility(bool isVisible)
        {
            lciReply.Visibility = lciResend.Visibility =
            lciRemove.Visibility = lciMove.Visibility =
            lciAddDeal.Visibility = esMessageButtons.Visibility = 
            esClientButtons.Visibility = isVisible ? 
                LayoutVisibility.Always : LayoutVisibility.Never;
        }

        #region EventHandlers
        private void OnNewMailRecieved(object sender, EventArgs e)
        {
            RefreshData();
        }

        private void WevMails_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            if (wevMails.IsDataRow(wevMails.FocusedRowHandle))
            {
                var row = wevMails.GetFocusedRow() as TheMail;
                row.IsRead = true;
                //FredroHelper.UpdateMessage(row);
                labelSubject.Text = row.Subject.Length > 60 ? row.Subject.Substring(0, 60) + "..." : row.Subject;
                labelSubject.ToolTip = row.Subject;
                labelFrom.Text = row.FromFullRaw;
                labelTo.Text = $"кому: {row.ToFullRaw}".Length > 85 ? $"кому: {row.ToFullRaw}".Substring(0, 85) + "..." : $"кому: {row.ToFullRaw}";
                labelTo.ToolTip = $"кому: {row.ToFullRaw}";
                labelDate.Text = $"{CultureInfo.GetCultureInfo("ru-RU").DateTimeFormat.GetAbbreviatedDayName(row.Date.Value.DayOfWeek)}, {row.Date.Value.ToLongDateString()}";
                meBody.Text = row.Body;
                SetResponseBodyVisibility(false);
                gcMails.RefreshDataSource();
            }
        }

        private void WevFolders_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            if (wevFolders.IsDataRow(wevFolders.FocusedRowHandle))
            {
                wevFolders.FocusedRowChanged -= WevFolders_FocusedRowChanged;
                var row = wevFolders.GetFocusedRow() as Folder;
                if (row.Caption.Contains("Входящие"))
                {
                    SetMessageButtonsVisibility(true);
                    gcMails.DataSource = _model.MyMails.Where(x => x.IsIncoming);
                    ParentFormText = ParentForm.Text = $"Входящие - {_model.Creds.Login} - Почтовый бизнес-клиент";
                }
                else if (row.Caption.Contains("Отправленные"))
                {
                    SetMessageButtonsVisibility(false);
                    gcMails.DataSource = _model.MyMails.Where(x => x.IsOutcoming);
                    ParentFormText = ParentForm.Text = $"Отправленные - {_model.Creds.Login} - Почтовый бизнес-клиент";
                }
                wevFolders.FocusedRowChanged += WevFolders_FocusedRowChanged;
            }
        }

        private void MeResponseBody_TextChanged(object sender, EventArgs e)
        {
            meResponseBody.SetScrollBarVisibility();
        }

        private void BtnReply_Click(object sender, EventArgs e)
        {
            SetResponseBodyVisibility(true);
        }

        private void BtnSendNew_Click(object sender, EventArgs e)
        {
            using (var frm = new frmSendNew())
            {
                frm.ShowDialog();
            }
        }

        private void BtnSendResponse_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(meResponseBody.Text))
            {
                try
                {
                    throw new NotImplementedException();
                    //var focusedMessage = wevMessages.GetFocusedRow() as TheMail;
                    //var responseMessage = new TheMail();
                    //responseMessage.Body = meResponseBody.Text;
                    //responseMessage.FromAddress = focusedMessage.ToAddress;
                    //responseMessage.FromDisplayName = $"ФрэдроКлиент";
                    //responseMessage.ToAddress = focusedMessage.FromAddress;
                    //responseMessage.ToDisplayName = focusedMessage.FromDisplayName;
                    //responseMessage.Subject = focusedMessage.Subject;

                    ////await FredroHelper.SendEmailAsync(responseMessage, _model.Creds, _model.Settings.Smtp);

                    //FredroMessageBox.ShowSucces("Письмо отправлено!");

                    //meResponseBody.Text = "";
                    //SetResponseBodyVisibility(false);
                }
                catch (Exception ex)
                {
                    FredroMessageBox.ShowError($"Ответ не отправлен! {ex.Message}");
                }
            }
            else
            {
                FredroMessageBox.ShowError("Нельзя отправить пустой ответ!");
            }
        }

        private void BtnCancelResponce_Click(object sender, EventArgs e)
        {
            SetResponseBodyVisibility(false);
        }

        private void BtnAddDeal_Click(object sender, EventArgs e)
        {
            using (var frm = new frmDeal())
            {
                frm.ShowDialog();
            }
        }

        private void BtnResend_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }
        #endregion

        private sealed class Folder
        {
            public string Caption { get; set; }

            public Folder(string caption)
            {
                Caption = caption;
            }
        }
    }
}
