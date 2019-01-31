using DevExpress.Utils.Drawing;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.ViewInfo;
using FredroClient.BaseGUI;
using FredroClient.ExtraClasses;
using FredroClient.Models;
using FredroDAL.Models.DatabaseObjectModels.Tables;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace FredroClient.Forms
{
    internal sealed partial class frmSendNew : FredroBaseXtraForm
    {
        public frmSendNew()
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
                    throw new NotImplementedException();
                    //var responseMail = new TheMail();
                    //responseMail.Body = meBody.Text;
                    //responseMail.FromAddress = _creds.Username;
                    //responseMail.FromDisplayName = "ФрэдроКлиент";
                    //responseMail.ToAddress = teTo.Text;
                    //responseMail.Subject = teSubject.Text;

                    //await FredroHelper.SendEmailAsync(responseMail, _creds, _smtp);

                    //FredroMessageBox.ShowSucces("Письмо отправлено!");
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
