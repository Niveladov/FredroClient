using DevExpress.Utils.Drawing;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.ViewInfo;
using DevExpress.XtraLayout.Utils;
using FredroClient.BaseGUI;
using FredroClient.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
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
            gcFolders.DataSource = new List<Folders>()
            {
                new Folders($"Входящие                 {_model.Messages.Count.ToString()}"),
                new Folders("Готовые"),
                new Folders("Отправленные"),
                new Folders("Удалённые")
            };
            Text = $"Входящие - {_model.Login} - Почтовый бизнес-клиент";
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            InitEvents();
            wevMessages.FocusedRowHandle = 0;
            meBody.BackColor = lcMessage.BackColor;
            //statusStrip.BackColor = meReplyBody.BackColor;
            statusStrip.Items[0].Text = "Демо версия почтового клиента.";
            statusStrip.Items[1].Text = "Евгений Федорук, +7(952)383-23-01";
            //panelTop.Appearance.BackColor = meReplyBody.BackColor;
            //panelTop.Appearance.Options.UseBackColor = true;
        }

        private void InitEvents()
        {
            wevMessages.FocusedRowChanged += WevMessages_FocusedRowChanged;
            btnReply.Click += BtnReply_Click;
            btnSendResponse.Click += BtnSendResponse_Click;
            btnSendNew.Click += BtnSendNew_Click;
            //meReplyBody.Leave += MeReplyBody_Leave;
            //meReplyBody.LostFocus += MeReplyBody_LostFocus;
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
            meBody.Properties.ScrollBars = rect.Height > meBody.Height ? ScrollBars.Vertical : ScrollBars.None;
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
            meResponseBody.Properties.ScrollBars = rect.Height > meResponseBody.Height ? ScrollBars.Vertical : ScrollBars.None;
        }

        private void SetResponseBodyVisibility(bool isVisible)
        {

            lciResponseBody.Visibility = lciSendResponse.Visibility = esResponseArea.Visibility =
                isVisible ? LayoutVisibility.Always : LayoutVisibility.Never;
        }

        private void WevMessages_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            if (wevMessages.IsDataRow(wevMessages.FocusedRowHandle))
            {
                var row = wevMessages.GetFocusedRow() as TheMessage;
                row.IsRead = true;
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
            using (var frm = new frmSendNew(_model))
            {
                frm.ShowDialog();
            }
        }

        private void BtnSendResponse_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(meResponseBody.Text))
            {
                var focusedMessage = wevMessages.GetFocusedRow() as TheMessage;
                var responseMessage = new TheMessage();
                responseMessage.Body = meResponseBody.Text;
                responseMessage.FromAddress = focusedMessage.ToAddress;
                responseMessage.FromDisplayName = $"ФрэдроКлиент: {focusedMessage.ToDisplayName}";
                responseMessage.ToAddress = focusedMessage.FromAddress;
                responseMessage.ToDisplayName = focusedMessage.FromDisplayName;
                responseMessage.Subject = focusedMessage.Subject;
                _model.SendNew(responseMessage, _model.Login, _model.Password);

                meResponseBody.Text = "";
                SetResponseBodyVisibility(false);
                SetMessageBodyScrollBarVisibility();
            }
            else
            {
                XtraMessageBox.Show("Нельзя отправить пустой ответ!", "Ошибка",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private sealed class Folders
        {
            public string Caption { get; set; }

            public Folders(string caption)
            {
                Caption = caption;
            }
        }


    }
}
