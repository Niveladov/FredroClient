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

namespace TwinklCRM.Client.UserControls
{
    public partial class ucHierarchy : ucBase
    {
        private readonly WaitingHelper _waitingHelper;
        private BusinessObjectServiceClient _boServiceClient;

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
            //throw new NotImplementedException();
        }

    }
}
