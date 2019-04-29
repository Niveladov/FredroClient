using DevExpress.XtraGrid;
using DevExpress.XtraGrid.Views.Grid;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwinklCRM.Client.BaseGUI
{
    internal sealed class GridViewBase : GridView
    {
        public Type DataSourceType { get; set; }

        public GridViewBase() : base(null) { }

        public GridViewBase(GridControl gridControl) : base(gridControl)  { }

    }
}
