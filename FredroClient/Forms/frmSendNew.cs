using DevExpress.Utils.Drawing;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.ViewInfo;
using FredroClient.BaseGUI;
using FredroClient.ExtraClasses;
using FredroClient.Models;
using FredroClient.Models.DatabaseObjectModels.Tables;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace FredroClient.Forms
{
    internal sealed partial class frmSendNew : FredroBaseXtraForm
    {
        private readonly Credentials _creds;
        private readonly SmtpProtocol _smtp;

        public frmSendNew(Credentials creds, SmtpProtocol smtp)
        {
            InitializeComponent();
            _creds = creds;
            _smtp = smtp;
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
                    var responseMessage = new TheMessage();
                    responseMessage.Body = meBody.Text;
                    responseMessage.FromAddress = _creds.Username;
                    responseMessage.FromDisplayName = "ФрэдроКлиент";
                    responseMessage.ToAddress = teTo.Text;
                    responseMessage.Subject = teSubject.Text;
                    
                    await FredroHelper.SendEmailAsync(responseMessage, _creds, _smtp);

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

    }
}
