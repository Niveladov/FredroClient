using FredroClient.BaseGUI;
using FredroClient.ExtraClasses;
using FredroClient.Models;
using FredroClient.Models.DatabaseObjectModels.Tables;
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
    internal partial class frmPerformer : FredroBaseXtraForm
    {
        private readonly PerformerModel _performerModel;

        public frmPerformer()
        {
            InitializeComponent();
            _performerModel = new PerformerModel();
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

        private async void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                await _performerModel.Save();
                FredroMessageBox.ShowSucces("Исполнитель успешно сохранен!");
                DialogResult = DialogResult.OK;
            }
            catch (Exception ex)
            {
                FredroMessageBox.ShowError($"Исполнитель не сохранен! {ex.Message}");
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }
    }
}
