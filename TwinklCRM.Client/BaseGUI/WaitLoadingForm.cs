﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraWaitForm;
using DevExpress.Skins;
using DevExpress.LookAndFeel;
using TwinklCRM.Client.Properties;

namespace TwinklCRM.Client.BaseGUI
{
    internal sealed partial class WaitLoadingForm : WaitForm
    {
        public WaitLoadingForm()
        {
            InitializeComponent();
            this.progressPanel.AutoHeight = true;
        }

        #region Overrides

        public override void SetCaption(string caption)
        {
            base.SetCaption(caption);
            this.progressPanel.Caption = caption;
        }
        public override void SetDescription(string description)
        {
            base.SetDescription(description);
            this.progressPanel.Description = description;
        }
        public override void ProcessCommand(Enum cmd, object arg)
        {
            base.ProcessCommand(cmd, arg);
        }

        #endregion
        
    }
}