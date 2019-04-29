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

namespace TwinklCRM.Client.UserControls
{
    public partial class ucHierarchy : ucBase
    {
        private readonly WaitingHelper _waitingHelper;
        private BusinessObjectServiceClient _boServiceClient;
        private string _dataSourceTableName;

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
        }

        private void TlDictionaries_FocusedNodeChanged(object sender, DevExpress.XtraTreeList.FocusedNodeChangedEventArgs e)
        {
            var isCategory = (bool?)e.Node[nameof(DictionaryHierarchy.IsCategory)];
            if (isCategory.HasValue && !isCategory.Value)
            {
                _dataSourceTableName = e.Node[nameof(DictionaryHierarchy.Name)].ToString();
                RefreshCurrentDictionary();
                InitColumnEditors();
            }
        }

        private void RefreshCurrentDictionary()
        {
            switch (_dataSourceTableName)
            {
                case nameof(DictionaryEmailFolderType):
                    gvCurrentDictionary.DataSourceType = typeof(DictionaryEmailFolderType);
                    gcCurrentDictionary.DataSource = _boServiceClient.GetAllEmailFolderTypes();
                    break;
                case nameof(DictionaryEmailServer):
                    gvCurrentDictionary.DataSourceType = typeof(DictionaryEmailServer);
                    gcCurrentDictionary.DataSource = _boServiceClient.GetAllEmailServers();
                    break;
                case nameof(DictionaryEmailServerParam):
                    gvCurrentDictionary.DataSourceType = typeof(DictionaryEmailServerParam);
                    gcCurrentDictionary.DataSource = _boServiceClient.GetAllEmailServerParams();
                    break;
                case nameof(DictionaryTripType):
                    gvCurrentDictionary.DataSourceType = typeof(DictionaryTripType);
                    gcCurrentDictionary.DataSource = _boServiceClient.GetAllTripTypes();
                    break;
                case nameof(DictionaryVehicleType):
                    gvCurrentDictionary.DataSourceType = typeof(DictionaryVehicleType);
                    gcCurrentDictionary.DataSource = _boServiceClient.GetAllVehicleTypes();
                    break;
            }
        }

        private void InitColumnEditors()
        {
            var dataSourceType = gvCurrentDictionary.DataSourceType;
            
            foreach (var property in dataSourceType.GetProperties())
            {
                var column = gvCurrentDictionary.Columns.ColumnByFieldName(property.Name);
                if (column != null && column.Visible)
                {
                    var dictionaryType = GetDictionaryTypeByAttr(property);
                    if (dictionaryType != null)
                    {
                        var repositoryEditor = new RepositoryItemSearchLookUpEdit();
                        repositoryEditor.DataSource = GetDataSourceByType(dictionaryType);
                        column.ColumnEdit = repositoryEditor;
                    }
                }
            }
        }

        private Type GetDictionaryTypeByAttr(PropertyInfo dataSourceProp)
        {
            Type result = null;
            if (dataSourceProp != null)
            {
                var relatedTableAttr = (RelatedTableAttribute)dataSourceProp.GetCustomAttributes(typeof(RelatedTableAttribute), true).FirstOrDefault();
                if (relatedTableAttr != null)
                {
                    result = relatedTableAttr.RelatedDictionaryType;
                }
            }
            return result;
        }
        
        private object GetDataSourceByType(Type dataSourceType)
        {
            object dataSource = null;
            var repositoryEditor = new RepositoryItemSearchLookUpEdit();
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

    }
}
