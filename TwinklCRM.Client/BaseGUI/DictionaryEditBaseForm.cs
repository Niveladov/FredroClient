using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Controls;
using DevExpress.XtraGrid.Columns;
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
        private DbObjectBaseModel _dataSource;
        private BusinessObjectServiceClient _boServiceClient;
        private string[] _systemFields = new string[] { "Id", "CreatedBy", "IsDel", "CreationDate" };

        public DictionaryEditBaseForm(DbObjectBaseModel dataSource, BusinessObjectServiceClient boServiceClient, string caption)
        {
            InitializeComponent();
            _dataSource = dataSource;
            _boServiceClient = boServiceClient;
            CreateDataSourceControls();
            Text = caption;
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

                var editControl = GetPropertyEditControl(property);

                lcMain.Controls.Add(editControl);
                controlItem.Control = editControl;
                
                lcMain.EndUpdate();
            }
        }

        private BaseEdit GetPropertyEditControl(PropertyInfo property)
        {
            var dictionaryType = property.GetDictionaryTypeByAttr();
            if (dictionaryType != null)
            {
                var searchLookUpEdit = new SearchLookUpEdit();

                searchLookUpEdit.Name = property.Name;
                searchLookUpEdit.Properties.PopupFindMode = FindMode.Default;
                searchLookUpEdit.Properties.TextEditStyle = TextEditStyles.Standard;
                searchLookUpEdit.Properties.PopupFilterMode = PopupFilterMode.Default;
                searchLookUpEdit.Properties.PopupFilterMode = PopupFilterMode.Default;
                searchLookUpEdit.Properties.AllowFocused = false;
                searchLookUpEdit.Properties.NullValuePromptShowForEmptyValue = true;
                searchLookUpEdit.Properties.NullValuePrompt = "Выберите значение...";

                searchLookUpEdit.Properties.Buttons.Add(new EditorButton() { Caption = "Добавить", Kind = ButtonPredefines.Plus });
                searchLookUpEdit.Properties.Buttons.Add(new EditorButton() { Caption = "Изменить", Kind = ButtonPredefines.Right });
                searchLookUpEdit.EditValueChanged += (o, a) =>
                {
                    var sle = (SearchLookUpEdit)o;
                    sle.Properties.Buttons[2].Visible = sle.EditValue != null;
                };
                searchLookUpEdit.ButtonPressed += SearchLookUpEdit_ButtonPressed;
                searchLookUpEdit.CustomDisplayText += SearchLookUpEdit_CustomDisplayText;

                searchLookUpEdit.Properties.DataSource = GetAll(dictionaryType);
                searchLookUpEdit.Properties.ValueMember = "Id";
                searchLookUpEdit.Properties.PopulateViewColumns();
                GridViewHelper.LoadDefaultColumnSettings(searchLookUpEdit.Properties.View, true);
                searchLookUpEdit.DataBindings.Add(new Binding("EditValue", _dataSource, property.Name, true, DataSourceUpdateMode.OnPropertyChanged));
                return searchLookUpEdit;
            }
            else if (property.PropertyType == typeof(DateTime) || property.PropertyType == typeof(DateTime?))
            {
                var dateEdit = new DateEdit();
                dateEdit.Name = property.Name;
                dateEdit.Properties.NullValuePromptShowForEmptyValue = true;
                dateEdit.Properties.NullValuePrompt = "Введите значение...";
                dateEdit.DataBindings.Add(new Binding("EditValue", _dataSource, property.Name, true, DataSourceUpdateMode.OnPropertyChanged));
                return dateEdit;
            }
            else if (property.PropertyType == typeof(bool) || property.PropertyType == typeof(bool?))
            {
                var checkEdit = new CheckEdit();
                checkEdit.Name = property.Name;
                checkEdit.Text = string.Empty;
                checkEdit.DataBindings.Add(new Binding("Checked", _dataSource, property.Name, true, DataSourceUpdateMode.OnPropertyChanged));
                return checkEdit;
            }
            else if (property.PropertyType == typeof(long) || property.PropertyType == typeof(long?) || property.PropertyType == typeof(int) || property.PropertyType == typeof(int?))
            {
                var spinEdit = new SpinEdit();
                spinEdit.Name = property.Name;
                spinEdit.Properties.IsFloatValue = false;
                spinEdit.DataBindings.Add(new Binding("EditValue", _dataSource, property.Name, true, DataSourceUpdateMode.OnPropertyChanged));
                return spinEdit;
            }
            else if (property.PropertyType == typeof(decimal) || property.PropertyType == typeof(decimal?))
            {
                SpinEdit spinEdit = new SpinEdit();
                spinEdit.Name = property.Name;
                spinEdit.Properties.IsFloatValue = true;
                spinEdit.DataBindings.Add(new Binding("EditValue", _dataSource, property.Name, true, DataSourceUpdateMode.OnPropertyChanged));
                return spinEdit;
            }
            else
            {
                TextEdit textEdit = new TextEdit();
                textEdit.Name = property.Name;
                textEdit.Properties.NullValuePromptShowForEmptyValue = true;
                textEdit.Properties.NullValuePrompt = "Введите значение...";
                textEdit.DataBindings.Add(new Binding("EditValue", _dataSource, property.Name, true, DataSourceUpdateMode.OnPropertyChanged));
                return textEdit;
            }
        }

        private bool PropertyCanBeChanged(PropertyInfo property)
        {
            return !(_systemFields.Contains(property.Name) || property.PropertyType == typeof(byte[]));
        }

        private void Save(DbObjectBaseModel targetObject)
        {
            var dataSourceType = _dataSource.GetType();
            if (dataSourceType.GetProperty("Id").GetValue(_dataSource) != null)
            {
                Update(_dataSource);
            }
            else
            {
                Insert(_dataSource);
            }
        }

        private DbObjectBaseModel[] GetAll(Type dataSourceType)
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
            else if (dataSourceType == typeof(DictionaryVehicleCapacityColor))
            {
                dataSource = _boServiceClient.GetAllVehicleCapacityColors();
            }
            return dataSource;
        }

        private void Insert(DbObjectBaseModel targetObject)
        {
            if (targetObject is DictionaryEmailFolderType)
            {
                var emailFolderType = targetObject as DictionaryEmailFolderType;
                _boServiceClient.InsertEmailFolderType(emailFolderType);
            }
            else if (targetObject is DictionaryEmailServer)
            {
                var emailServer = targetObject as DictionaryEmailServer;
                _boServiceClient.InsertEmailServer(emailServer);
            }
            else if (targetObject is DictionaryEmailServerParam)
            {
                var emailServerParam = targetObject as DictionaryEmailServerParam;
                _boServiceClient.InsertEmailServerParam(emailServerParam);
            }
            else if (targetObject is DictionaryTripType)
            {
                var tripType = targetObject as DictionaryTripType;
                _boServiceClient.InsertTripType(tripType);
            }
            else if (targetObject is DictionaryVehicleType)
            {
                var vehicleType = targetObject as DictionaryVehicleType;
                _boServiceClient.InsertVehicleType(vehicleType);
            }
            else if (targetObject is DictionaryVehicleCapacityColor)
            {
                var vehicleCapacityColor = targetObject as DictionaryVehicleCapacityColor;
                _boServiceClient.InsertVehicleCapacityColor(vehicleCapacityColor);
            }
        }

        private void Update(DbObjectBaseModel targetObject)
        {
            if (targetObject is DictionaryEmailFolderType)
            {
                var emailFolderType = targetObject as DictionaryEmailFolderType;
                _boServiceClient.UpdateEmailFolderType(emailFolderType);
            }
            else if (targetObject is DictionaryEmailServer)
            {
                var emailServer = targetObject as DictionaryEmailServer;
                _boServiceClient.UpdateEmailServer(emailServer);
            }
            else if (targetObject is DictionaryEmailServerParam)
            {
                var emailServerParam = targetObject as DictionaryEmailServerParam;
                _boServiceClient.UpdateEmailServerParam(emailServerParam);
            }
            else if (targetObject is DictionaryTripType)
            {
                var tripType = targetObject as DictionaryTripType;
                _boServiceClient.UpdateTripType(tripType);
            }
            else if (targetObject is DictionaryVehicleType)
            {
                var vehicleType = targetObject as DictionaryVehicleType;
                _boServiceClient.UpdateVehicleType(vehicleType);
            }
            else if (targetObject is DictionaryVehicleCapacityColor)
            {
                var vehicleCapacityColor = targetObject as DictionaryVehicleCapacityColor;
                _boServiceClient.UpdateVehicleCapacityColor(vehicleCapacityColor);
            }
        }

        private string GetDisplayText(SearchLookUpEdit sle)
        {
            if (sle.EditValue == null || string.IsNullOrEmpty(sle.EditValue.ToString()))
            {
                return string.Empty;
            }
            else
            {
                List<string> listOfValues = new List<string>();
                var dictionaryType = sle.Tag as Type;
                foreach (GridColumn column in sle.Properties.View.Columns)
                {
                    if (column.Visible)
                    {
                        var value = sle.Properties.View.GetFocusedRowCellValue(column);
                        if (value != null)
                        {
                            listOfValues.Add(value.ToString());
                        }
                    }
                }
                return string.Join(" | ", listOfValues);
            }
        }

        private void SearchLookUpEdit_CustomDisplayText(object sender, CustomDisplayTextEventArgs e)
        {
            var sle = sender as SearchLookUpEdit;
            e.DisplayText = GetDisplayText(sle);
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
            Save(_dataSource);
            DialogResult = DialogResult.OK;
        }
    }
}
