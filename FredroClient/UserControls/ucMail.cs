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
using FredroClient.Models.DatabaseObjectModels.Tables;

namespace FredroClient.UserControls
{
    internal sealed partial class ucMail : ucBase
    {
        public string ParentFormText { get; private set; }

        private CredentialModel _model;
        private bool _isInit = false;

        public ucMail()
        {
            InitializeComponent();
        }

        public void InitModel(CredentialModel model)
        {
            if (!_isInit)
            {
                _model = model;
                _isInit = true;
            }
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            if (!isDesignMode)
            {
                gcMessages.DataSource = _model.Messages.Where(x => x.IsIncoming);
                var inMessCount = _model.Messages.Where(x => x.IsIncoming).Count();
                var outMessCount = _model.Messages.Where(x => x.IsOutcoming).Count();
                gcFolders.DataSource = new List<Folder>()
                {
                    new Folder($"Входящие            {inMessCount.ToString()}"),
                    new Folder($"Отправленные     {outMessCount.ToString()}"),
                    new Folder($"Удалённые")
                };
                InitEvents();
                wevFolders.FocusedRowHandle = 0;
                wevMessages.FocusedRowHandle = 0;
                meBody.BackColor = lcMessage.BackColor;
                statusStrip.Items[0].Text = "Демо версия почтового клиента.";
                statusStrip.Items[1].Text = ""; // "Евгений Федорук, +7(952)383-23-01";
            }
        }

        private void InitEvents()
        {
            wevFolders.FocusedRowChanged += WevFolders_FocusedRowChanged;
            wevMessages.FocusedRowChanged += WevMessages_FocusedRowChanged;
            btnReply.Click += BtnReply_Click;
            btnSendResponse.Click += BtnSendResponse_Click;
            btnCancelResponce.Click += BtnCancelResponce_Click;
            btnSendNew.Click += BtnSendNew_Click;
            btnResend.Click += BtnResend_Click;
            btnAddDeal.Click += BtnAddDeal_Click;
            btnAddClient.Click += BtnAddClient_Click;
            meResponseBody.TextChanged += MeResponseBody_TextChanged;
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
            lciAddClient.Visibility = lciAddDeal.Visibility =
            esMessageButtons.Visibility = esClientButtons.Visibility = 
                isVisible ? LayoutVisibility.Always : LayoutVisibility.Never;
        }

        private void WevMessages_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            if (wevMessages.IsDataRow(wevMessages.FocusedRowHandle))
            {
                var row = wevMessages.GetFocusedRow() as TheMessage;
                row.IsRead = true;
                FredroHelper.UpdateMessage(row);
                labelSubject.Text = row.Subject.Length > 60 ? row.Subject.Substring(0, 60) + "..." : row.Subject;
                labelSubject.ToolTip = row.Subject;
                labelFrom.Text = row.FromFullRaw;
                labelTo.Text = $"кому: {row.ToFullRaw}".Length > 85 ? $"кому: {row.ToFullRaw}".Substring(0, 85) + "..." : $"кому: {row.ToFullRaw}";
                labelTo.ToolTip = $"кому: {row.ToFullRaw}";
                labelDate.Text = $"{CultureInfo.GetCultureInfo("ru-RU").DateTimeFormat.GetAbbreviatedDayName(row.Date.Value.DayOfWeek)}, {row.Date.Value.ToLongDateString()}";
                meBody.Text = row.Body;
                SetResponseBodyVisibility(false);
                gcMessages.RefreshDataSource();
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
                    gcMessages.DataSource = _model.Messages.Where(x => x.IsIncoming);
                    ParentFormText = ParentForm.Text = $"Входящие - {_model.Creds.Username} - Почтовый бизнес-клиент";
                }
                else if (row.Caption.Contains("Отправленные"))
                {
                    SetMessageButtonsVisibility(false);
                    gcMessages.DataSource = _model.Messages.Where(x => x.IsOutcoming);
                    ParentFormText = ParentForm.Text = $"Отправленные - {_model.Creds.Username} - Почтовый бизнес-клиент";
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
            using (var frm = new frmSendNew(_model.Creds, _model.Settings.Smtp))
            {
                frm.ShowDialog();
            }
        }

        private async void BtnSendResponse_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(meResponseBody.Text))
            {
                try
                {
                    var focusedMessage = wevMessages.GetFocusedRow() as TheMessage;
                    var responseMessage = new TheMessage();
                    responseMessage.Body = meResponseBody.Text;
                    responseMessage.FromAddress = focusedMessage.ToAddress;
                    responseMessage.FromDisplayName = $"ФрэдроКлиент";
                    responseMessage.ToAddress = focusedMessage.FromAddress;
                    responseMessage.ToDisplayName = focusedMessage.FromDisplayName;
                    responseMessage.Subject = focusedMessage.Subject;

                    await FredroHelper.SendEmailAsync(responseMessage, _model.Creds, _model.Settings.Smtp);

                    FredroMessageBox.ShowSucces("Письмо отправлено!");

                    meResponseBody.Text = "";
                    SetResponseBodyVisibility(false);
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

        private void BtnAddClient_Click(object sender, EventArgs e)
        {
            using (var frm = new frmPerformer())
            {
                frm.ShowDialog();
            }
        }

        private void btnAddTask_Click(object sender, EventArgs e)
        {
            using (var frm = new frmSchedule())
            {
                frm.ShowDialog();
            }
        }

        private void BtnResend_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }


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
