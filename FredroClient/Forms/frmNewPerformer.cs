using FredroClient.BaseGUI;
using FredroClient.ExtraClasses;
using FredroClient.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FredroClient.Forms
{
    internal partial class frmNewPerformer : FredroBaseXtraForm
    {
        private readonly NewPerformerModel _customerModel;

        public frmNewPerformer()
        {
            InitializeComponent();
            _customerModel = new NewPerformerModel();
            InitControls();
        }

        private void InitControls()
        {
            subjectName.DataBindings.Add(new Binding("EditValue", _customerModel.NewPerformer, nameof(_customerModel.NewPerformer.SubjectName),
                true, DataSourceUpdateMode.OnPropertyChanged));
            phoneNumber.DataBindings.Add(new Binding("EditValue", _customerModel.NewPerformer, nameof(_customerModel.NewPerformer.PhoneNumber),
                true, DataSourceUpdateMode.OnPropertyChanged));
            emailAddress.DataBindings.Add(new Binding("EditValue", _customerModel.NewPerformer, nameof(_customerModel.NewPerformer.EmailAddress),
                true, DataSourceUpdateMode.OnPropertyChanged));
            source.DataBindings.Add(new Binding("EditValue", _customerModel.NewPerformer, nameof(_customerModel.NewPerformer.Source),
                true, DataSourceUpdateMode.OnPropertyChanged));
        }

        private async void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                await _customerModel.Save();
                FredroMessageBox.ShowSucces("Исполнитель успешно сохранен!");
                Close();
            }
            catch (Exception ex)
            {
                FredroMessageBox.ShowError($"Исполнитель не сохранен! {ex.Message}");
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
