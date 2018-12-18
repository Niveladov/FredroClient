using DevExpress.Utils.Drawing;
using DevExpress.XtraEditors.ViewInfo;
using DevExpress.XtraLayout.Utils;
using FredroClient.BaseGUI;
using FredroClient.ExtraClasses;
using FredroClient.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Windows.Forms;

namespace FredroClient.Forms
{
    internal sealed partial class frmMessages : FredroBaseXtraForm
    {
        private readonly CredentialModel _model;

        public frmMessages(CredentialModel model)
        {
            InitializeComponent();
            _model = model;
            gcMessages.DataSource = _model.Messages;
            var inMessCount = _model.Messages.Where(x => x.IsIncoming).Count();
            var outMessCount = _model.Messages.Where(x => x.IsOutcoming).Count();
            gcFolders.DataSource = new List<Folder>()
            {
                new Folder($"Входящие            {inMessCount.ToString()}"),
                new Folder($"Отправленные     {outMessCount.ToString()}"),
                new Folder($"Удалённые")
            };
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            InitEvents();
            wevFolders.FocusedRowHandle = 0;
            wevMessages.FocusedRowHandle = 0;
            meBody.BackColor = lcMessage.BackColor;
            statusStrip.Items[0].Text = "Демо версия почтового клиента.";
            statusStrip.Items[1].Text = ""; // "Евгений Федорук, +7(952)383-23-01";
        }

        private void InitEvents()
        {
            wevFolders.FocusedRowChanged += WevFolders_FocusedRowChanged;
            wevMessages.FocusedRowChanged += WevMessages_FocusedRowChanged;
            btnReply.Click += BtnReply_Click;
            btnSendResponse.Click += BtnSendResponse_Click;
            btnSendNew.Click += BtnSendNew_Click;
            meResponseBody.TextChanged += MeResponseBody_TextChanged;
        }

        private void SetMessageBodyScrollBarVisibility()
        {
            MemoEditViewInfo vi = this.meBody.GetViewInfo() as MemoEditViewInfo;
            GraphicsCache cache = new GraphicsCache(meBody.CreateGraphics());
            int h = (vi as IHeightAdaptable).CalcHeight(cache, vi.MaskBoxRect.Width);
            ObjectInfoArgs args = new ObjectInfoArgs();
            args.Bounds = new Rectangle(0, 0, vi.ClientRect.Width, h);
            Rectangle rect = vi.BorderPainter.CalcBoundsByClientRectangle(args);
            cache.Dispose();
            meBody.Properties.ScrollBars = rect.Height > meBody.Height ? 
                ScrollBars.Vertical : ScrollBars.None;
        }

        private void SetResponseBodyScrollBarVisibility()
        {
            MemoEditViewInfo vi = this.meResponseBody.GetViewInfo() as MemoEditViewInfo;
            GraphicsCache cache = new GraphicsCache(meResponseBody.CreateGraphics());
            int h = (vi as IHeightAdaptable).CalcHeight(cache, vi.MaskBoxRect.Width);
            ObjectInfoArgs args = new ObjectInfoArgs();
            args.Bounds = new Rectangle(0, 0, vi.ClientRect.Width, h);
            Rectangle rect = vi.BorderPainter.CalcBoundsByClientRectangle(args);
            cache.Dispose();
            meResponseBody.Properties.ScrollBars = rect.Height > meResponseBody.Height ? 
                ScrollBars.Vertical : ScrollBars.None;
        }

        private void SetResponseBodyVisibility(bool isVisible)
        {

            lciResponseBody.Visibility = lciSendResponse.Visibility = 
            esResponseArea.Visibility = isVisible ? 
                LayoutVisibility.Always : LayoutVisibility.Never;
        }

        private void SetMessageButtonsVisibility(bool isVisible)
        {
            lciReply.Visibility = lciResend.Visibility =
            lciRemove.Visibility = lciMove.Visibility =
            lciAddClient.Visibility = lciAddDeal.Visibility =
            lciAddTask.Visibility =  esMessageButtons.Visibility =
            esClientButtons.Visibility = isVisible ? 
                LayoutVisibility.Always : LayoutVisibility.Never;
        }

        private void WevMessages_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            if (wevMessages.IsDataRow(wevMessages.FocusedRowHandle))
            {
                var row = wevMessages.GetFocusedRow() as TheMessage;
                row.IsRead = true;
                FredroHelper.UpdateMessage(row);
                labelSubject.Text = row.Subject.Length > 60 ? row.Subject.Substring(0, 60) + "...": row.Subject;
                labelSubject.ToolTip = row.Subject;
                labelFrom.Text = row.FromFullRaw;
                labelTo.Text = $"кому: {row.ToFullRaw}".Length > 85 ? $"кому: {row.ToFullRaw}".Substring(0, 85) + "..." : $"кому: {row.ToFullRaw}";
                labelTo.ToolTip = $"кому: {row.ToFullRaw}";
                labelDate.Text = $"{CultureInfo.GetCultureInfo("ru-RU").DateTimeFormat.GetAbbreviatedDayName(row.Date.Value.DayOfWeek)}, {row.Date.Value.ToLongDateString()}";
                meBody.Text = row.Body;
                SetResponseBodyVisibility(false);
                SetMessageBodyScrollBarVisibility();
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
                    Text = $"Входящие - {_model.Creds.Username} - Почтовый бизнес-клиент";
                }
                else if (row.Caption.Contains("Отправленные"))
                {
                    SetMessageButtonsVisibility(false);
                    gcMessages.DataSource = _model.Messages.Where(x => x.IsOutcoming);
                    Text = $"Отправленные - {_model.Creds.Username} - Почтовый бизнес-клиент";
                }
                wevFolders.FocusedRowChanged += WevFolders_FocusedRowChanged;
            }
        }

        private void MeResponseBody_TextChanged(object sender, EventArgs e)
        {
            SetResponseBodyScrollBarVisibility();
        }

        private void BtnReply_Click(object sender, EventArgs e)
        {
            SetResponseBodyVisibility(true);
            SetMessageBodyScrollBarVisibility();
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
                    SetMessageBodyScrollBarVisibility();
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

        private void btnAddDeal_Click(object sender, EventArgs e)
        {
            using (var frm = new frmNewDeal())
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
