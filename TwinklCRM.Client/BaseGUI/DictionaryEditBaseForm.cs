using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Controls;
using DevExpress.XtraLayout;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TwinklCRM.Client.BusinessObjectService;
using TwinklCRM.Client.ExtraClasses;
using TwinklCRM.DAL.Attributes;
using TwinklCRM.DAL.Extensions;
using TwinklCRM.DAL.Models.DatabaseObjectModels;
using TwinklCRM.DAL.Models.DatabaseObjectModels.Tables.Dictionaries;

namespace TwinklCRM.Client.BaseGUI
{
    internal partial class DictionaryEditBaseForm : TwinkleBaseXtraForm
    {
        private object _dataSource;
        private BusinessObjectServiceClient _boServiceClient;
        private string[] _systemFields = new string[] { "Id", "CreatedBy", "IsDel", "CreationDate" };

        public DictionaryEditBaseForm(object dataSource, BusinessObjectServiceClient boServiceClient)
        {
            InitializeComponent();
            _dataSource = dataSource;
            _boServiceClient = boServiceClient;
            CreateDataSourceControls();
        }

        private bool PropertyCanBeChanged(PropertyInfo property)
        {
            return !(_systemFields.Contains(property.Name) || property.PropertyType == typeof(byte[]));
        }

        private DbObjectBaseModel[] GetDataSourceByType(Type dataSourceType)
        {
            DbObjectBaseModel[] dataSource = null;
            if (dataSourceType == typeof(DictionaryEmailFolderType))
            {
                dataSource = _boServiceClient.GetAllEmailFolderTypes();
            }
            else if (dataSourceType == typeof(DictionaryEmailServer))
            {
                dataSource = _boServiceClient.GetAllEmailServers();
            }
            else if (dataSourceType == typeof(DictionaryEmailServerParam))
            {
                dataSource = _boServiceClient.GetAllEmailServerParams();
            }
            else if (dataSourceType == typeof(DictionaryTripType))
            {
                dataSource = _boServiceClient.GetAllTripTypes();
            }
            else if (dataSourceType == typeof(DictionaryVehicleType))
            {
                dataSource = _boServiceClient.GetAllVehicleTypes();
            }
            return dataSource;
        }

        private void CreateDataSourceControls()
        {
            var dataSourceType = _dataSource.GetType();

            if (dataSourceType.IsGenericType && dataSourceType.GetGenericTypeDefinition() == typeof(List<>))
            {
                return;
                //dataSourceType = dataSourceType.GetGenericArguments()[0];
            }

            foreach (var property in dataSourceType.GetProperties())
            {
                if (!PropertyCanBeChanged(property)) continue;

                lcMain.BeginUpdate();

                var controlItem = lcgMain.AddItem();
                controlItem.ControlMinSize = new Size() { Height = 0, Width = 0 };
                controlItem.MinSize = new Size() { Height = 0, Width = 0 };
                controlItem.FillControlToClientArea = false;
                controlItem.TextAlignMode = TextAlignModeItem.UseParentOptions;
                controlItem.Text = property.GetFieldCaptionByAttr();
                controlItem.Name = "lci" + property.Name;

                var dictionaryType = property.GetDictionaryTypeByAttr();
                if (dictionaryType != null)
                {
                    var searchLookUpEdit = new SearchLookUpEdit();

                    searchLookUpEdit.Name = property.Name;
                    searchLookUpEdit.Properties.AppearanceFocused.BackColor = Color.Transparent;
                    searchLookUpEdit.Properties.PopupFindMode = FindMode.Default;
                    searchLookUpEdit.Properties.TextEditStyle = TextEditStyles.Standard;
                    searchLookUpEdit.Properties.PopupFilterMode = PopupFilterMode.Default;
                    searchLookUpEdit.Properties.PopupFilterMode = PopupFilterMode.Default;
                    searchLookUpEdit.Properties.NullText = "Введите значение";

                    this.Controls.Add(searchLookUpEdit);
                    controlItem.Control = searchLookUpEdit;

                    searchLookUpEdit.Properties.Buttons.Add(new EditorButton() { Caption = "Добавить", Kind = ButtonPredefines.Plus });
                    searchLookUpEdit.Properties.Buttons.Add(new EditorButton() { Caption = "Изменить", Kind = ButtonPredefines.Right});
                    searchLookUpEdit.EditValueChanged += (o, a) =>
                    {
                        var sle = (SearchLookUpEdit)o;
                        sle.Properties.Buttons[2].Visible = sle.EditValue != null && sle.EditValue != DBNull.Value;
                    };
                    searchLookUpEdit.ButtonPressed += new ButtonPressedEventHandler(SearchLookUpEdit_ButtonPressed);

                    searchLookUpEdit.Properties.DataSource = GetDataSourceByType(dictionaryType);
                    searchLookUpEdit.Properties.DisplayMember = "Name";
                    searchLookUpEdit.Properties.ValueMember = "Id";
                    GridViewHelper.LoadDefaultColumnSettings(searchLookUpEdit.Properties.View, true);
                    searchLookUpEdit.DataBindings.Add(new Binding("EditValue", _dataSource, property.Name, true, DataSourceUpdateMode.OnPropertyChanged));
                    
                }
                else if (property.PropertyType == typeof(DateTime) || property.PropertyType == typeof(Nullable<DateTime>))
                {
                    var dateEdit = new DateEdit();
                    dateEdit.Name = property.Name;
                    dateEdit.DataBindings.Add(new Binding("EditValue", _dataSource, property.Name, true, DataSourceUpdateMode.OnPropertyChanged));
                    lcMain.Controls.Add(dateEdit);
                    controlItem.Control = dateEdit;
                }
                else if (property.PropertyType == typeof(bool) || property.PropertyType == typeof(Nullable<bool>))
                {
                    var checkEdit = new CheckEdit();
                    checkEdit.Name = property.Name;
                    checkEdit.DataBindings.Add(new Binding("Checked", _dataSource, property.Name, true, DataSourceUpdateMode.OnPropertyChanged));
                    lcMain.Controls.Add(checkEdit);
                    controlItem.Control = checkEdit;
                }
                else if (property.PropertyType == typeof(long) || property.PropertyType == typeof(Nullable<long>) || property.PropertyType == typeof(int) || property.PropertyType == typeof(Nullable<int>))
                {
                    var spinEdit = new SpinEdit();
                    spinEdit.Name = property.Name;
                    spinEdit.DataBindings.Add(new Binding("EditValue", _dataSource, property.Name, true, DataSourceUpdateMode.OnPropertyChanged));
                    lcMain.Controls.Add(spinEdit);
                    controlItem.Control = spinEdit;
                }
                else if (property.PropertyType == typeof(decimal) || property.PropertyType == typeof(Nullable<decimal>))
                {
                    SpinEdit te = new SpinEdit();
                    te.Name = property.Name;
                    te.DataBindings.Add(new Binding("EditValue", _dataSource, property.Name, true, DataSourceUpdateMode.OnPropertyChanged));
                    lcMain.Controls.Add(te);
                    controlItem.Control = te;
                }
                else
                {
                    TextEdit te = new TextEdit();
                    te.Name = property.Name;
                    te.DataBindings.Add(new Binding("EditValue", _dataSource, property.Name, true, DataSourceUpdateMode.OnPropertyChanged));
                    lcMain.Controls.Add(te);
                    controlItem.Control = te;
                }

                lcMain.EndUpdate();
            }
        }
        
        private void SearchLookUpEdit_ButtonPressed(object sender, ButtonPressedEventArgs e)
        {
            //var sle = (SearchLookUpEdit)sender;
            //if (e.Button.Kind == ButtonPredefines.Plus)
            //{
            //    sleButtonTag tag = (sleButtonTag)e.Button.Tag;
            //    using (var frm = new BoundLayoutForm(Activator.CreateInstance(tag.type), FormActionType.Create))
            //    {
            //        if (frm.ShowDialog() == DialogResult.OK)
            //        {
            //            dataSource.GetType().GetProperty(tag.propertyName).SetValue(dataSource, Convert.ToInt64(frm.result), null);
            //        }
            //    }

            //    if (sle.Properties.DataSource is XPServerCollectionSource)
            //    {
            //        var xpServerCollectionSource = (XPServerCollectionSource)sle.Properties.DataSource;
            //        xpServerCollectionSource.Session.DropIdentityMap();
            //        xpServerCollectionSource.Reload();
            //    }

            //}
            //else if (e.Button.Kind == ButtonPredefines.Right)
            //{
            //    if (((BSSearchLookUpEdit)sender).EditValue == null || ((BSSearchLookUpEdit)sender).EditValue == DBNull.Value)
            //        return;
            //    sleButtonTag tag = (sleButtonTag)e.Button.Tag;
            //    object source = Activator.CreateInstance(tag.type);
            //    long id = Convert.ToInt32(sle.EditValue);
            //    ((MyBaseModel)source).GetByID(id);
            //    BoundLayoutForm frm = new BoundLayoutForm(source, FormActionType.Edit);
            //    if (frm.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            //    {
            //        dataSource.GetType().GetProperty(tag.propertyName).SetValue(dataSource, Convert.ToInt64(frm.result), null);
            //    }

            //    if (sle.Properties.DataSource is XPServerCollectionSource)
            //    {
            //        var xpServerCollectionSource = (XPServerCollectionSource)sle.Properties.DataSource;
            //        xpServerCollectionSource.Session.DropIdentityMap();
            //        xpServerCollectionSource.Reload();
            //    }
            //}
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            //switch (actionType)
            //{
            //    case FormActionType.Edit:
            //        ((MyBaseModel)DataSource).Update();
            //        result = dataSource.GetType().GetProperty("id").GetValue(dataSource, null);
            //        break;
            //    case FormActionType.Create:
            //        result = ((MyBaseModel)DataSource).Insert();
            //        actionType = FormActionType.Edit;
            //        break;
            //}
            if (_dataSource.GetType().GetProperty("Id").GetValue(_dataSource) != null)
            {
                //Update
            }
            else
            {
                //Create
            }
            DialogResult = DialogResult.OK;
        }
    }
}
