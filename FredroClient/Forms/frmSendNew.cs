using DevExpress.Utils.Drawing;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.ViewInfo;
using FredroClient.BaseGUI;
using FredroClient.ExtraClasses;
using FredroClient.MailService;
using FredroClient.Models;
using FredroDAL.Models.DatabaseObjectModels.Tables;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace FredroClient.Forms
{
    internal sealed partial class frmSendNew : FredroBaseXtraForm
    {
        private NewMailModel _model;

        public frmSendNew(MailServiceClient serviceClient)
        {
            InitializeComponent();

            InitEvents();
        }

        private void InitEvents()
        {
            meBody.TextChanged += MeBody_TextChanged;
            btnSend.Click += BtnSend_Click;
        }

        private void MeBody_TextChanged(object sender, EventArgs e)
        {
            var memoEdit = sender as MemoEdit;
            if (memoEdit != null) memoEdit.SetScrollBarVisibility();
        }

        private async void BtnSend_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(meBody.Text))
            {
                try
                {
                    var responseMail = new TheMail();
                    responseMail.Body = meBody.Text;
                    responseMail.FromAddress = _model.FromEmailBoxAddress;
                    responseMail.FromDisplayName = "ФрэдроКлиент";
                    responseMail.ToAddress = teTo.Text;
                    responseMail.Subject = teSubject.Text;
                    responseMail.ChachedEmailBoxId = _model.FromEmailBoxId;


                    FredroMessageBox.ShowSucces("Письмо отправлено!");
                }
                catch (Exception ex)
                {
                    FredroMessageBox.ShowError($"Письмо не отправлено! {ex.Message}");
                }
                finally
                {
                    Close();
                }
            }
            else
            {
                FredroMessageBox.ShowError("Нельзя отправить пустое сообщение!");
            }
        }


        private sealed class NewMailModel
        {
            private int _fromEmalBoxId;
            public int FromEmailBoxId
            {
                get { return _fromEmalBoxId; }
                set
                {
                    if (_fromEmalBoxId != value)
                    {
                        _fromEmalBoxId = value;
                        FromEmailBoxAddress = UserEmailBoxes.Single(x => x.Id == value).Login;
                    }
                }
            }
            public string FromEmailBoxAddress { get; private set; }
            public List<CachedEmailBox> UserEmailBoxes { get; }
            public MailServiceClient ServiceClient { get; }

            public NewMailModel(MailServiceClient serviceClient)
            {
                ServiceClient = serviceClient;
                var userEmailBoxes = ServiceClient.GetUserEmailBoxes();

            }
        }

    }
}
