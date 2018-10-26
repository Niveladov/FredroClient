using DevExpress.Utils.Drawing;
using DevExpress.XtraEditors.ViewInfo;
using FredroClient.BaseGUI;
using FredroClient.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
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
                labelSubject.Text = $"Тема: {row.Subject}";
                labelFrom.Text = row.FromFullRaw;
                labelTo.Text = $"кому: {row.To}";
                labelDate.Text = row.Date;
                meBody.Text = row.Body;
                SetScrollBarVisibility();
                gcMessages.RefreshDataSource();
            }
        }
    }
}
