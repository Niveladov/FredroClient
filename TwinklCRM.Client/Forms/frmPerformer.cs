﻿using TwinklCRM.Client.BaseGUI;
using TwinklCRM.Client.ExtraClasses;
using TwinklCRM.Client.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TwinklCRM.Client.BusinessObjectService;

namespace TwinklCRM.Client.Forms
{
    internal partial class frmPerformer : TwinkleBaseXtraForm
    {
        private readonly PerformerModel _performerModel;

        public frmPerformer(BusinessObjectServiceClient boServiceClient)
        {
            InitializeComponent();
            _performerModel = new PerformerModel(boServiceClient);
            InitControls();
        }

        private void InitControls()
        {
            subjectName.DataBindings.Add(new Binding("EditValue", _performerModel.CurrentPerformer, nameof(_performerModel.CurrentPerformer.SubjectName),
                true, DataSourceUpdateMode.OnPropertyChanged));
            phoneNumber.DataBindings.Add(new Binding("EditValue", _performerModel.CurrentPerformer, nameof(_performerModel.CurrentPerformer.PhoneNumber),
                true, DataSourceUpdateMode.OnPropertyChanged));
            emailAddress.DataBindings.Add(new Binding("EditValue", _performerModel.CurrentPerformer, nameof(_performerModel.CurrentPerformer.EmailAddress),
                true, DataSourceUpdateMode.OnPropertyChanged));
            source.DataBindings.Add(new Binding("EditValue", _performerModel.CurrentPerformer, nameof(_performerModel.CurrentPerformer.Source),
                true, DataSourceUpdateMode.OnPropertyChanged));
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                _performerModel.Save();
                TwinkleMessageBox.ShowSucces("Исполнитель успешно сохранен!");
                DialogResult = DialogResult.OK;
            }
            catch (Exception ex)
            {
                TwinkleMessageBox.ShowError($"Исполнитель не сохранен! {ex.Message}");
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }
    }
}
