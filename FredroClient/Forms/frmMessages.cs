using DevExpress.Utils.Drawing;
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
        public frmMessages(List<TheMessage> messages, string login)
        {
            InitializeComponent();
            gcMessages.DataSource = messages;
            gcMessageTypes.DataSource = new List<MessageTypes>()
            {
                new MessageTypes($"Входящие                 {messages.Count.ToString()}"),
                new MessageTypes("Готовые"),
                new MessageTypes("Отправленные"),
                new MessageTypes("Удалённые")
            };
            Text = $"Входящие - {login} - Почтовый клиент";
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            InitEvents();
            wevMessages.FocusedRowHandle = 0;
            meBody.BackColor = lcMessage.BackColor;
        }

        private void InitEvents()
        {
            wevMessages.FocusedRowChanged += WevMessages_FocusedRowChanged;
            btnReply.Click += BtnReply_Click;
        }

        private void SetScrollBarVisibility()
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

        private void WevMessages_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            if (wevMessages.IsDataRow(wevMessages.FocusedRowHandle))
            {
                var row = wevMessages.GetFocusedRow() as TheMessage;
                row.IsRead = true;
                labelSubject.Text = row.Subject.Length > 60 ? row.Subject.Substring(0, 60) + "...": row.Subject;
                labelSubject.ToolTip = row.Subject;
                labelFrom.Text = row.FromFullRaw;
                labelTo.Text = $"кому: {row.To}".Length > 85 ? $"кому: {row.To}".Substring(0, 85) + "..." : $"кому: {row.To}";
                labelTo.ToolTip = $"кому: {row.To}";
                labelDate.Text = $"{CultureInfo.GetCultureInfo("ru-RU").DateTimeFormat.GetAbbreviatedDayName(row.Date.Value.DayOfWeek)}, {row.Date.Value.ToLongDateString()}";
                meBody.Text = row.Body;
                SetScrollBarVisibility();
                gcMessages.RefreshDataSource();
            }
        }

        private void BtnReply_Click(object sender, EventArgs e)
        {
            lciReplyBody.Visibility = LayoutVisibility.Always;
        }

        private sealed class MessageTypes
        {
            public string MessageType { get; set; }

            public MessageTypes(string messageType)
            {
                MessageType = messageType;
            }
        }


    }
}
