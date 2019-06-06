using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TwinklCRM.Client.BaseGUI;
using TwinklCRM.Client.BusinessObjectService;
using TwinklCRM.Client.ExtraClasses;
using TwinklCRM.DAL.Models.DatabaseObjectModels.Tables.Dictionaries;
using DevExpress.XtraGrid.Columns;
using System.Reflection;
using DevExpress.XtraEditors.Repository;
using TwinklCRM.DAL.Attributes;
using TwinklCRM.DAL.Models.DatabaseObjectModels;
using TwinklCRM.DAL.Extensions;

namespace TwinklCRM.Client.UserControls
{
    public partial class ucHierarchy : ucBase
    {
        private readonly WaitingHelper _waitingHelper;
        private BusinessObjectServiceClient _boServiceClient;
        private string _dataSourceTableName;

        private Type DataSourceType => gvCurrentDictionary.DataSourceType;
        private int? RowItemId => (int?)gvCurrentDictionary.GetFocusedRowCellValue("Id");
        private string Caption => tlDictionaries.FocusedNode[nameof(DictionaryHierarchy.Caption)].ToString();


        public ucHierarchy()
        {
            InitializeComponent();
            _waitingHelper = new WaitingHelper(ParentForm);
        }

        public void Init(BusinessObjectServiceClient boServiceClient)
        {
            _boServiceClient = boServiceClient;
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            if (!isDesignMode)
            {
                _waitingHelper.Show();
                InitTreeList();
                InitData();
                InitEvents();
                _waitingHelper.Hide();
            }
        }

        private void InitTreeList()
        {
            tlDictionaries.KeyFieldName = "Id";
            tlDictionaries.ParentFieldName = "ParentId";
        }

        private void InitData()
        {
            tlDictionaries.DataSource = _boServiceClient.GetAllHierarchies();
        }

        private void InitEvents()
        {
            tlDictionaries.FocusedNodeChanged += TlDictionaries_FocusedNodeChanged;
            groupCurrentDictionary.CustomButtonClick += GroupCurrentDictionary_CustomButtonClick;
        }

        private void RefreshCurrentDictionaryData()
        {
            Type dataSourceType = null;
            var dataSource = GetAll(_dataSourceTableName, out dataSourceType);

            gvCurrentDictionary.DataSourceType = dataSourceType;
            gcCurrentDictionary.DataSource = dataSource;
        }

        private void InitColumnEditors()
        {
            foreach (var property in DataSourceType.GetProperties())
            {
                var column = gvCurrentDictionary.Columns.ColumnByFieldName(property.Name);
                if (column != null && column.Visible)
                {
                    var dictionaryType = property.GetDictionaryTypeByAttr();
                    if (dictionaryType != null)
                    {
                        var repositoryEditor = new RepositoryItemSearchLookUpEdit();
                        repositoryEditor.DataSource = GetDataSourceByType(dictionaryType);
                        column.ColumnEdit = repositoryEditor;
                    }
                }
            }
        }

        private DbObjectBaseModel[] GetAll(string dataSourceTableName, out Type dataSourceType)
        { 
            switch (dataSourceTableName)
            {
                case nameof(DictionaryEmailFolderType):
                    dataSourceType = typeof(DictionaryEmailFolderType);
                    return _boServiceClient.GetAllEmailFolderTypes();
                case nameof(DictionaryEmailServer):
                    dataSourceType = typeof(DictionaryEmailServer);
                    return _boServiceClient.GetAllEmailServers();
                case nameof(DictionaryEmailServerParam):
                    dataSourceType = typeof(DictionaryEmailServerParam);
                    return _boServiceClient.GetAllEmailServerParams();
                case nameof(DictionaryTripType):
                    dataSourceType = typeof(DictionaryTripType);
                    return _boServiceClient.GetAllTripTypes();
                case nameof(DictionaryVehicleType):
                    dataSourceType = typeof(DictionaryVehicleType);
                    return _boServiceClient.GetAllVehicleTypes();
                default:
                    dataSourceType = null;
                    return null;
            }
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

        private void DeleteObject(Type dataSourceType, int objectId)
        {
            if (dataSourceType == typeof(DictionaryEmailFolderType))
            {
                _boServiceClient.DeleteEmailFolderType(objectId);
            }
            else if (dataSourceType == typeof(DictionaryEmailServer))
            {
                _boServiceClient.DeleteEmailServer(objectId);
            }
            else if (dataSourceType == typeof(DictionaryEmailServerParam))
            {
                _boServiceClient.DeleteEmailServerParam(objectId);
            }
            else if (dataSourceType == typeof(DictionaryTripType))
            {
                _boServiceClient.DeleteTripType(objectId);
            }
            else if (dataSourceType == typeof(DictionaryVehicleType))
            {
                _boServiceClient.DeleteVehicleType(objectId);
            }
        }

        private void AddNewRow()
        {
            var sourceObject = Activator.CreateInstance(DataSourceType);
            var sourceModel = sourceObject as DbObjectBaseModel;
            if (sourceModel != null)
            {
                OpenDictionaryEditForm(sourceModel);
            }
        }

        private void EditRow()
        {
            var sourceModel = gvCurrentDictionary.GetFocusedRow() as DbObjectBaseModel;
            if (sourceModel != null)
            {
                OpenDictionaryEditForm(sourceModel);
            }
        }

        private void OpenDictionaryEditForm(DbObjectBaseModel sourceModel)
        {
            using (var frm = new DictionaryEditBaseForm(sourceModel, _boServiceClient, Caption))
            {
                if (frm.ShowDialog() == DialogResult.OK)
                {
                    RefreshCurrentDictionaryData();
                }
            }
        }

        private void DeleteRow()
        {
            if (TwinkleMessageBox.ShowQuestionYesNo("Вы уверены, что хотите удалить запись?") == DialogResult.Yes)
            {
                _waitingHelper.Show();
                if (RowItemId.HasValue)
                {
                    DeleteObject(DataSourceType, RowItemId.Value);
                    RefreshCurrentDictionaryData();
                }
                _waitingHelper.Hide();
            }
        }

        #region Event Handlers

        private void GroupCurrentDictionary_CustomButtonClick(object sender, DevExpress.XtraBars.Docking2010.BaseButtonEventArgs e)
        {
            switch (e.Button.Properties.Caption)
            {
                case "btnAdd":
                    AddNewRow();
                    break;
                case "btnEdit":
                    EditRow();
                    break;
                case "btnDelete":
                    DeleteRow();
                    break;
                case "btnRefresh":
                    RefreshCurrentDictionaryData();
                    break;
            }

        }

        private void TlDictionaries_FocusedNodeChanged(object sender, DevExpress.XtraTreeList.FocusedNodeChangedEventArgs e)
        {
            var isCategory = (bool?)e.Node[nameof(DictionaryHierarchy.IsCategory)];
            if (isCategory.HasValue && !isCategory.Value)
            {
                _dataSourceTableName = e.Node[nameof(DictionaryHierarchy.Name)].ToString();
                RefreshCurrentDictionaryData();
                InitColumnEditors();
            }
        }

        #endregion

    }
}
