using DevExpress.XtraGrid;
using DevExpress.XtraGrid.Views.Grid;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwinklCRM.Client.BaseGUI
{
    [ToolboxItem(true)]
    internal sealed class GridControlBase : GridControl
    {
        public GridControlBase()
        {
            DataSourceChanged += GridControlBase_DataSourceChanged;
        }

        private void GridControlBase_DataSourceChanged(object sender, EventArgs e)
        {
            foreach (var view in ViewCollection)
            {
                var gridView = view as GridView;
                if (gridView != null)
                {
                    gridView.PopulateColumns();
                }
            }
        }

    }
}
