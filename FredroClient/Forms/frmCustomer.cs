﻿using TwinkleClient.BaseGUI;
using TwinkleClient.ExtraClasses;
using TwinkleClient.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TwinkleClient.Forms
{
    internal partial class frmCustomer : TwinkleBaseXtraForm
    {
        private readonly CustomerModel _customerModel;

        public frmCustomer()
        {
            InitializeComponent();
            _customerModel = new CustomerModel();
            InitControls();
        }

        private void InitControls()
        {
            subjectName.DataBindings.Add(new Binding("EditValue", _customerModel.CurrentCustomer, nameof(_customerModel.CurrentCustomer.SubjectName),
                true, DataSourceUpdateMode.OnPropertyChanged));
            phoneNumber.DataBindings.Add(new Binding("EditValue", _customerModel.CurrentCustomer, nameof(_customerModel.CurrentCustomer.PhoneNumber),
                true, DataSourceUpdateMode.OnPropertyChanged));
            emailAddress.DataBindings.Add(new Binding("EditValue", _customerModel.CurrentCustomer, nameof(_customerModel.CurrentCustomer.EmailAddress),
                true, DataSourceUpdateMode.OnPropertyChanged));
            source.DataBindings.Add(new Binding("EditValue", _customerModel.CurrentCustomer, nameof(_customerModel.CurrentCustomer.Source),
                true, DataSourceUpdateMode.OnPropertyChanged));
        }

        private async void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                await _customerModel.Save();
                TwinkleMessageBox.ShowSucces("Заказчик успешно сохранен!");
                DialogResult = DialogResult.OK;
            }
            catch (Exception ex)
            {
                TwinkleMessageBox.ShowError($"Заказчик не сохранен! {ex.Message}");
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }
    }
}
