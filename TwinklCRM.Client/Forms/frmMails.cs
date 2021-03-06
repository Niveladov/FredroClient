﻿using TwinklCRM.Client.BaseGUI;
using TwinklCRM.Client.ExtraClasses;
using TwinklCRM.Client.Models;
using TwinklCRM.DAL.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TwinklCRM.Client.Forms
{
    internal sealed partial class frmMails : TwinkleBaseXtraForm
    {
        public frmMails(TwinkleBaseXtraForm splashScreenForm, Credentials creds)
        {
            try
            {
                //throw new Exception("Huesos, axaxa!");
                InitializeComponent();
                //ucMails.Init(creds);
                InitEvents();
            }
            catch (ServerException ex)
            {
                TwinkleMessageBox.ShowError(ex.Message);
            }
            finally
            {
                splashScreenForm?.Invoke(new Action(() => splashScreenForm.Close()));
                splashScreenForm?.Dispose();
            }
        }

        private void InitEvents()
        {
            tcgModes.SelectedPageChanged += TcgModes_SelectedPageChanged;
            FormClosing += FrmMails_FormClosing;
        }

        private void TcgModes_SelectedPageChanged(object sender, DevExpress.XtraLayout.LayoutTabPageChangedEventArgs e)
        {
            if (e.Page == lcgScheduler)
            {
                Text = "Календарь заявок(сделок) - Почтовый бизнес-клиент";
            }
            else if (e.Page == lcgMails)
            {
                Text = ucMails.ParentFormText;
            }
        }

        private void FrmMails_FormClosing(object sender, FormClosingEventArgs e)
        {
            var result = TwinkleMessageBox.ShowQuestionYesNo("Вы хотите выйти?");
            e.Cancel = (result == DialogResult.No);
        }

    }
}
