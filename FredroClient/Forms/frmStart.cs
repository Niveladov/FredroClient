using DevExpress.Utils;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Controls;
using FredroClient.BaseGUI;
using FredroClient.ExtraClasses;
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
        //private readonly CredentialModel _model;

        public frmStart()
        {
            InitializeComponent();
            //InitControls();
        }

        private void InitImageollection()
        {
            var images = new ImageCollection();
            images.AddImage(Properties.Resources.gmail_32x32);
            images.AddImage(Properties.Resources.mailru_32x32);
            images.AddImage(Properties.Resources.yandex_32x32);

            icbMaterial.SmallImages = images;
            icbAcceptedMaterial.SmallImages = images;

            icbMaterial.Items.Add(new ImageComboBoxItem("Кровушка", (long)101, 0));
            icbMaterial.Items.Add(new ImageComboBoxItem("Мочушка", (long)103, 1));
            icbAcceptedMaterial.Items.Add(new ImageComboBoxItem("Кровушка", (long)101, 0));
            icbAcceptedMaterial.Items.Add(new ImageComboBoxItem("Мочушка", (long)103, 1));
        }


        //private void InitControls()
        //{
        //    sleHostname.DataBindings.Add(new Binding("EditValue", _model, nameof(_model.CurrentServer), true, DataSourceUpdateMode.OnPropertyChanged));
        //}

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
                [Description("Сервер входящей почты - pop.gmail.com")]
                [Port(995)]
                gmail,
                [Description("Сервер входящей почты - pop.mail.ru")]
                [Port(995)]
                mail,
                [Description("Сервер входящей почты - pop.yandex.ru")]
                [Port(995)]
                yandex
            }
            public string UserName { get; set; }
            public string Password { get; set; }
            public EmailServer CurrentServer { get; set; }

        }

    }
}
