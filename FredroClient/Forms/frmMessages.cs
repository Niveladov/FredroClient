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
            InitEvents();
            gcMessages.DataSource = messages;
            wevMessages.FocusedRowHandle = 0;
            Text = $"Входящие - {login} - Почтовый клиент";
        }

        private void InitEvents()
        {
            wevMessages.FocusedRowChanged += WevMessages_FocusedRowChanged;
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
                gcMessages.RefreshDataSource();
            }
        }
    }
}
