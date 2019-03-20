using DevExpress.Utils.Drawing;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.ViewInfo;
using TwinkleClient.BaseGUI;
using TwinkleClient.ExtraClasses;
using TwinkleClient.MailService;
using TwinkleClient.Models;
using TwinkleDAL.Models.DatabaseObjectModels.Tables;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace TwinkleClient.Forms
{
    internal sealed partial class frmSendNew : TwinkleBaseXtraForm
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
            if (_model.UserEmailBoxes.Length > 0)
            {
                sleFrom.Properties.DisplayMember = nameof(CachedEmailBox.Login);
                sleFrom.Properties.ValueMember = nameof(CachedEmailBox.Id);
                sleFrom.Properties.PopulateViewColumns();
                sleFrom.Properties.View.Columns[nameof(CachedEmailBox.Id)].Visible = false;
                sleFrom.Properties.View.Columns[nameof(CachedEmailBox.IsDel)].Visible = false;
                sleFrom.Properties.View.Columns[nameof(CachedEmailBox.CreatedBy)].Visible = false;
                sleFrom.Properties.View.Columns[nameof(CachedEmailBox.CreationDate)].Visible = false;
                sleFrom.Properties.View.Columns[nameof(CachedEmailBox.UserId)].Visible = false;
                sleFrom.Properties.View.Columns[nameof(CachedEmailBox.User)].Visible = false;
                sleFrom.Properties.View.Columns[nameof(CachedEmailBox.EmailServerId)].Visible = false;
                sleFrom.Properties.View.Columns[nameof(CachedEmailBox.EmailServer)].Visible = false;
                sleFrom.Properties.View.Columns[nameof(CachedEmailBox.OutgoingEmailServerParamId)].Visible = false;
                sleFrom.Properties.View.Columns[nameof(CachedEmailBox.OutgoingEmailServerParam)].Visible = false;
                sleFrom.Properties.View.Columns[nameof(CachedEmailBox.IncomingEmailServerParamId)].Visible = false;
                sleFrom.Properties.View.Columns[nameof(CachedEmailBox.IncomingEmailServerParam)].Visible = false;
                sleFrom.Properties.View.Columns[nameof(CachedEmailBox.Password)].Visible = false;
                sleFrom.Properties.View.Columns[nameof(CachedEmailBox.Login)].Caption = "Почтовый адрес";
                sleFrom.DataBindings.Add(new Binding("EditValue", _model, nameof(_model.FromEmailBoxId),
                        true, DataSourceUpdateMode.OnPropertyChanged));
            }
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

                    TwinkleMessageBox.ShowSucces("Письмо отправлено!");
                }
                catch (Exception ex)
                {
                    TwinkleMessageBox.ShowError($"Письмо не отправлено! {ex.Message}");
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
                TwinkleMessageBox.ShowError("Нельзя отправить пустое сообщение!");
            }
        }
        
      

    }

}
