using DevExpress.Utils.Drawing;
using DevExpress.XtraEditors.ViewInfo;
using FredroClient.BaseGUI;
using FredroClient.ExtraClasses;
using FredroClient.Models;
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
            MemoEditViewInfo vi = this.meBody.GetViewInfo() as MemoEditViewInfo;
            GraphicsCache cache = new GraphicsCache(meBody.CreateGraphics());
            int h = (vi as IHeightAdaptable).CalcHeight(cache, vi.MaskBoxRect.Width);
            ObjectInfoArgs args = new ObjectInfoArgs();
            args.Bounds = new Rectangle(0, 0, vi.ClientRect.Width, h);
            Rectangle rect = vi.BorderPainter.CalcBoundsByClientRectangle(args);
            cache.Dispose();
            meBody.Properties.ScrollBars = rect.Height > meBody.Height ? ScrollBars.Vertical : ScrollBars.None;
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
