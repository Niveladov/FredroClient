﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TwinklCRM.Client.Models;
using DevExpress.XtraEditors.ViewInfo;
using DevExpress.Utils.Drawing;
using DevExpress.XtraLayout.Utils;
using TwinklCRM.Client.ExtraClasses;
using System.Globalization;
using TwinklCRM.Client.Forms;
using TwinklCRM.Client.BaseGUI;
using DevExpress.XtraEditors;
using TwinklCRM.DAL.Models.DatabaseObjectModels.Tables;
using TwinklCRM.DAL.Models;
using System.Runtime.Remoting;
using TwinklCRM.Client.BusinessObjectService;

namespace TwinklCRM.Client.UserControls
{
    internal sealed partial class ucMails : ucBase
    {
        public string ParentFormText { get; private set; }

        private MailModel _model;
        private bool _isInit = false;
        private bool _isMailButtonsVisible = true;
        private bool _isEnableMailView = true;
        //  ToDo:
        //      to move from field to another place
        private BusinessObjectServiceClient _boServiceClient;

        public ucMails()
        {
            InitializeComponent();
            SetIncomingBehavior();
        }

        public void Init(BusinessObjectServiceClient boServiceClient, Credentials creds)
        {
            try
            {
                if (!_isInit)
                {
                    _model = new MailModel(creds);
                    _boServiceClient = boServiceClient;
                    InitEvents();
                    SetMailButtonsVisibility(false);
                    SetResponseBodyVisibility(false);
                    _model.JoinToServer();
                    _isInit = true;
                }
            }
            catch (ServerException ex)
            {
                throw ex;
            }
            catch (Exception ex)
            {
                TwinkleMessageBox.ShowError(ex.Message);
            }
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            if (!isDesignMode)
            {
                meBody.BackColor = lcMessage.BackColor;
            }
        }

        public void FilterMails(string text)
        {
            wevMails.FindFilterText = text;
        }

        private void InitEvents()
        {
            _model.NewMailsRecieved += OnNewMailRecieved;

            btnInboxMails.Click += OnFolderClick;
            btnOutboxMails.Click += OnFolderClick;
            btnDeletedMails.Click += OnFolderClick;

            wevMails.FocusedRowChanged += WevMails_FocusedRowChanged;
            btnReply.Click += BtnReply_Click;
            btnSendResponse.Click += BtnSendResponse_Click;
            btnCancelResponce.Click += BtnCancelResponce_Click;
            btnSendNew.Click += BtnSendNew_Click;
            btnResend.Click += BtnResend_Click;
            btnAddDeal.Click += BtnAddDeal_Click;
            meResponseBody.TextChanged += MeResponseBody_TextChanged;
        }

        private void RefreshData()
        {
            DisableMailView();
            var mailHandler = wevMails.FocusedRowHandle;
            gcMails.DataSource = GetCurrentFolderMails();
            wevMails.FocusedRowHandle = mailHandler;
            EnableMailView();
        }

        private List<TheMail> GetCurrentFolderMails()
        {
            List<TheMail> mails = null;
            var incomingMails = _model.MyMails.Where(x => x.IsIncoming).ToList();
            var outgoingMails = _model.MyMails.Where(x => x.IsOutcoming).ToList();
            if (btnOutboxMails.Tag != null)
            {
                mails = outgoingMails;
            }
            else if (btnInboxMails.Tag != null)
            {
                mails = incomingMails;
            }
            return mails;
        }

        private void SetResponseBodyVisibility(bool isVisible)
        {
            if (!isVisible) meResponseBody.Text = "";

            lciResponseBody.Visibility = lciSendResponse.Visibility =
            lciCancelResponce.Visibility = esResponseArea.Visibility = 
                isVisible ? LayoutVisibility.Always : LayoutVisibility.Never;

            meBody.SetScrollBarVisibility();
        }

        private void SetMailButtonsVisibility(bool isVisible)
        {
            if (_isMailButtonsVisible != isVisible)
            {
                lciReply.Visibility = lciResend.Visibility =
                lciRemove.Visibility = lciMove.Visibility =
                lciAddDeal.Visibility = esMessageButtons.Visibility =
                esClientButtons.Visibility = isVisible ?
                    LayoutVisibility.Always : LayoutVisibility.Never;
                _isMailButtonsVisible = isVisible;
            }
        }

        /// <summary>
        ///     Enable the opening of mail for viewing.
        /// </summary>
        private void EnableMailView()
        {
            _isEnableMailView = true;
        }

        /// <summary>
        ///     Disable the opening of mail for viewing.
        /// </summary>
        private void DisableMailView()
        {
            _isEnableMailView = false;
        }

        private void FocusInvalidMail()
        {
            wevMails.FocusedRowHandle = -1;
        }

        private void ClearControlFocus()
        {
            panelFolders.Focus();
        }

        private void InitIncomingMailsData()
        {
            var incomingMails = _model.MyMails.Where(x => x.IsIncoming).ToList();
            gcMails.DataSource = incomingMails;
        }

        private void InitOutcomingMailsData()
        {
            var outgoingMails = _model.MyMails.Where(x => x.IsOutcoming).ToList();
            gcMails.DataSource = outgoingMails;
        }

        private void InitDeletedMailsData()
        {
            gcMails.DataSource = null;
        }

        private void SetIncomingMailsAppearence()
        {
            btnInboxMails.Font = new Font("Calibri", 12, FontStyle.Bold);
            btnInboxMails.Image = Properties.Resources.inbox_blue_16x16;
            btnInboxMails.ForeColor = Color.DeepSkyBlue;

            var defaultFont = new Font("Calibri", 10.8f , FontStyle.Bold);
            var defaultColor = Color.Gainsboro;
            btnOutboxMails.Font = defaultFont;
            btnOutboxMails.ForeColor = defaultColor;
            btnOutboxMails.Image = Properties.Resources.telegram_grey_16x16;
            btnDeletedMails.Font = defaultFont;
            btnDeletedMails.ForeColor = defaultColor;
            btnDeletedMails.Image = Properties.Resources.deleted_mail_grey_16x16;
        }

        private void SetOutcomingMailsAppearence()
        {
            btnOutboxMails.Font = new Font("Calibri", 12, FontStyle.Bold);
            btnOutboxMails.ForeColor = Color.DeepSkyBlue;
            btnOutboxMails.Image = Properties.Resources.telegram_blue_16x16;

            var defaultFont = new Font("Calibri", 10.8f, FontStyle.Bold);
            var defaultColor = Color.Gainsboro;
            btnInboxMails.Font = defaultFont;
            btnInboxMails.ForeColor = defaultColor;
            btnInboxMails.Image = Properties.Resources.inbox_grey_16x16;
            btnDeletedMails.Font = defaultFont;
            btnDeletedMails.ForeColor = defaultColor;
            btnDeletedMails.Image = Properties.Resources.deleted_mail_grey_16x16;
        }

        private void SetDeletedMailsAppearence()
        {
            btnDeletedMails.Font = new Font("Calibri", 12, FontStyle.Bold);
            btnDeletedMails.ForeColor = Color.DeepSkyBlue;
            btnDeletedMails.Image = Properties.Resources.deleted_mail_blue_16x16;

            var defaultFont = new Font("Calibri", 10.8f, FontStyle.Bold);
            var defaultColor = Color.Gainsboro;
            btnOutboxMails.Font = defaultFont;
            btnOutboxMails.ForeColor = defaultColor;
            btnOutboxMails.Image = Properties.Resources.telegram_grey_16x16;
            btnInboxMails.Font = defaultFont;
            btnInboxMails.ForeColor = defaultColor;
            btnInboxMails.Image = Properties.Resources.inbox_grey_16x16;
        }

        private void SetIncomingBehavior()
        {
            MarkIncomingTags();
            SetIncomingMailsAppearence();
        }

        private void SetOutcomingBehavior()
        {
            MarkOutcomingTags();
            SetOutcomingMailsAppearence();
        }

        private void SetDeletedBehavior()
        {
            MarkDeletedTags();
            SetDeletedMailsAppearence();
        }

        private void MarkIncomingTags()
        {
            btnInboxMails.Tag = true;
            btnOutboxMails.Tag = null;
            btnDeletedMails.Tag = null;
        }

        private void MarkOutcomingTags()
        {
            btnInboxMails.Tag = null;
            btnOutboxMails.Tag = true;
            btnDeletedMails.Tag = null;
        }

        private void MarkDeletedTags()
        {
            btnInboxMails.Tag = null;
            btnOutboxMails.Tag = null;
            btnDeletedMails.Tag = true;
        }

        private void IncomingMailsClickActions()
        {
            DisableMailView();
            InitIncomingMailsData();
            FocusInvalidMail();
            EnableMailView();
            SetIncomingBehavior();
        }

        private void OutcomingMailsClickActions()
        {
            DisableMailView();
            InitOutcomingMailsData();
            FocusInvalidMail();
            EnableMailView();
            SetOutcomingBehavior();
        }

        private void DeletedMailsClickActions()
        {
            DisableMailView();
            InitDeletedMailsData();
            FocusInvalidMail();
            EnableMailView();
            SetDeletedBehavior();
        }

        #region EventHandlers

        private void OnNewMailRecieved(object sender, EventArgs e)
        {
            RefreshData();
        }

        private void OnFolderClick(object sender, EventArgs e)
        {
            var btn = sender as Button;
            if (btn != null)
            {
                switch (btn.Name)
                {
                    case nameof(btnInboxMails):
                        IncomingMailsClickActions();
                        break;
                    case nameof(btnOutboxMails):
                        OutcomingMailsClickActions();
                        break;
                    case nameof(btnDeletedMails):
                        DeletedMailsClickActions();
                        break;
                }
            }
        }

        private void WevMails_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            if (_isEnableMailView && wevMails.IsDataRow(wevMails.FocusedRowHandle) && wevMails.FocusedRowHandle == e.FocusedRowHandle)
            {
                var mail = wevMails.GetFocusedRow() as TheMail;
                SetMailButtonsVisibility(mail.IsIncoming);
                if (!mail.IsRead)
                {
                    mail.IsRead = true;
                    _model.UpdateMail(mail);
                }

                labelSubject.Text = mail.Subject.Length > 60 ? mail.Subject.Substring(0, 60) + "..." : mail.Subject;
                labelSubject.ToolTip = mail.Subject;
                labelFrom.Text = mail.FromFullRaw;
                labelTo.Text = $"кому: {mail.ToFullRaw}".Length > 85 ? $"кому: {mail.ToFullRaw}".Substring(0, 85) + "..." : $"кому: {mail.ToFullRaw}";
                labelTo.ToolTip = $"кому: {mail.ToFullRaw}";
                labelDate.Text = $"{CultureInfo.GetCultureInfo("ru-RU").DateTimeFormat.GetAbbreviatedDayName(mail.Date.Value.DayOfWeek)}, {mail.Date.Value.ToLongDateString()}";

                meBody.Text = mail.Body;

                SetResponseBodyVisibility(false);

                gcMails.RefreshDataSource();
            }
        }

        private void btnSendNew_MouseDown(object sender, MouseEventArgs e)
        {
            btnSendNew.OnHoverBorderColor = Color.Transparent;
        }

        private void btnSendNew_MouseUp(object sender, MouseEventArgs e)
        {
            btnSendNew.OnHoverBorderColor = Color.FromArgb(65, 119, 225);
        }

        private void MeResponseBody_TextChanged(object sender, EventArgs e)
        {
            meResponseBody.SetScrollBarVisibility();
        }

        private void BtnReply_Click(object sender, EventArgs e)
        {
            SetResponseBodyVisibility(true);
        }

        private void BtnSendNew_Click(object sender, EventArgs e)
        {
            ClearControlFocus();
            using (var frm = new frmSendNew(_model.ServiceClient))
            {
                frm.ShowDialog();
            }
        }

        private void BtnSendResponse_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(meResponseBody.Text))
            {
                try
                {
                    var focusedMail = wevMails.GetFocusedRow() as TheMail;
                    var responseMail = new TheMail();
                    responseMail.Body = meResponseBody.Text;
                    responseMail.FromAddress = focusedMail.ToAddress;
                    responseMail.FromDisplayName = $"ФрэдроКлиент";
                    responseMail.ToAddress = focusedMail.FromAddress;
                    responseMail.ToDisplayName = focusedMail.FromDisplayName;
                    responseMail.Subject = focusedMail.Subject;
                    responseMail.ChachedEmailBoxId = focusedMail.ChachedEmailBoxId;

                    _model.SendMail(responseMail);

                    TwinkleMessageBox.ShowSucces("Письмо отправлено!");

                    meResponseBody.Text = "";
                    SetResponseBodyVisibility(false);
                }
                catch (Exception ex)
                {
                    TwinkleMessageBox.ShowError($"Ответ не отправлен! {ex.Message}");
                }
            }
            else
            {
                TwinkleMessageBox.ShowError("Нельзя отправить пустой ответ!");
            }
        }

        private void BtnCancelResponce_Click(object sender, EventArgs e)
        {
            SetResponseBodyVisibility(false);
        }

        private void BtnAddDeal_Click(object sender, EventArgs e)
        {
            using (var frm = new frmDeal(_boServiceClient))
            {
                frm.ShowDialog();
            }
        }

        private void BtnResend_Click(object sender, EventArgs e)
        {

        }
        #endregion
    }
}
