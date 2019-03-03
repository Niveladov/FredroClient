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

        public frmSendNew(MailServiceClient mailServiceClient)
        {
            InitializeComponent();
            _model = new NewMailModel(mailServiceClient);
            InitControls();
            InitEvents();
        }

        private void InitEvents()
        {
            meBody.TextChanged += MeBody_TextChanged;
            btnSend.Click += BtnSend_Click;
        }

        private void InitControls()
        {
            sleFrom.Properties.DataSource = _model.UserEmailBoxes;
            sleFrom.Properties.DisplayMember = nameof(CachedEmailBox.Login);
            sleFrom.Properties.ValueMember = nameof(CachedEmailBox.Id);
            sleFrom.DataBindings.Add(new Binding("EditValue", _model, nameof(_model.FromEmailBoxId),
                true, DataSourceUpdateMode.OnPropertyChanged));
        }

        private void MeBody_TextChanged(object sender, EventArgs e)
        {
            var memoEdit = sender as MemoEdit;
            if (memoEdit != null) memoEdit.SetScrollBarVisibility();
        }

        private void BtnSend_Click(object sender, EventArgs e)
        {
            if (_model.FromEmailBoxId.HasValue && !string.IsNullOrWhiteSpace(meBody.Text))
            {
                try
                {
                    sleFrom.ErrorText = string.Empty;
                    var responseMail = new TheMail();
                    responseMail.Body = meBody.Text;
                    responseMail.FromAddress = _model.FromEmailBoxAddress;
                    responseMail.FromDisplayName = "ФрэдроКлиент";
                    responseMail.ToAddress = teTo.Text;
                    responseMail.Subject = teSubject.Text;
                    responseMail.ChachedEmailBoxId = _model.FromEmailBoxId;

                    _model.SendMail(responseMail);

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
            else if (!_model.FromEmailBoxId.HasValue)
            {
                sleFrom.ErrorText = "Ошибка. Необходимо указать почтовый адрес, с которого будет отправлено письмо.";
            }
            else
            {
                FredroMessageBox.ShowError("Нельзя отправить пустое сообщение!");
            }
        }
        
        private sealed class NewMailModel
        {
            private MailServiceClient _serviceClient;

            private int? _fromEmalBoxId;
            public int? FromEmailBoxId
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
            public CachedEmailBox[] UserEmailBoxes { get; }

            public NewMailModel(MailServiceClient serviceClient)
            {
                try
                {
                    _serviceClient = serviceClient;
                    UserEmailBoxes = _serviceClient.GetUserEmailBoxes();
                    FromEmailBoxId = UserEmailBoxes.First().Id.Value;
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }

            internal void SendMail(TheMail responseMail)
            {
                try
                {
                    _serviceClient.SendMail(responseMail);
                }
                catch(Exception ex)
                {
                    throw ex;
                }
            }
        }

    }

}
