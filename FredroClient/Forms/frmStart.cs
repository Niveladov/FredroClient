using DevExpress.XtraEditors;
using FredroClient.BaseGUI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FredroClient.Forms
{
    public sealed partial class frmStart : FredroBaseXtraForm
    {
        private readonly CredentialModel _model;

        public frmStart()
        {
            InitializeComponent();
            InitControls();
        }

        private void InitControls()
        {
            sleHostname.DataBindings.Add(new Binding("EditValue", DataSource, property.Name, true, DataSourceUpdateMode.OnPropertyChanged));
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnEnter_Click(object sender, EventArgs e)
        {

        }

        private sealed class CredentialModel
        {
            public enum EmailServer
            {
                [Description("Gmail сервер. Пример: example@gmail.com")]
                gmail,
                [Description("Mail сервер. Пример: example@mail.ru")]
                mail,
                [Description("Yandex сервер. Пример: example@yandex.ru")]
                yandex
            }
            public string UserName { get; set; }
            public string Password { get; set; }
            public EmailServer CurrentServer { get; set; }

        }

        private sealed class EmailServer
        {

        }

    }
}
