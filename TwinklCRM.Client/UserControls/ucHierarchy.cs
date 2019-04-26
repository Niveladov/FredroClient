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
            }
        }

        private void RefreshCurrentDictionary()
        {
            switch (_dataSourceTableName)
            {
                case nameof(DictionaryEmailFolderType):
                    gcCurrentDictionary.DataSource = _boServiceClient.GetAllEmailFolderTypes();
                    break;
                case nameof(DictionaryEmailServer):
                    gcCurrentDictionary.DataSource = _boServiceClient.GetAllEmailServers();
                    break;
                case nameof(DictionaryEmailServerParam):
                    gcCurrentDictionary.DataSource = _boServiceClient.GetAllEmailServerParams();
                    break;
                case nameof(DictionaryTripType):
                    gcCurrentDictionary.DataSource = _boServiceClient.GetAllTripTypes();
                    break;
                case nameof(DictionaryVehicleType):
                    gcCurrentDictionary.DataSource = _boServiceClient.GetAllVehicleTypes();
                    break;
            }

        }
    }
}
