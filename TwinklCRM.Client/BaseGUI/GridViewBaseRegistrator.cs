using DevExpress.XtraGrid;
using DevExpress.XtraGrid.Registrator;
using DevExpress.XtraGrid.Views.Base;
using DevExpress.XtraGrid.Views.Base.ViewInfo;
using DevExpress.XtraGrid.Views.Grid.ViewInfo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwinklCRM.Client.BaseGUI
{
    internal class GridViewBaseRegistrator : GridInfoRegistrator
    {
        public override string ViewName { get { return nameof(GridViewBase); } }
        public override BaseView CreateView(GridControl grid) { return new GridViewBase(grid as GridControl); }
        public override BaseViewInfo CreateViewInfo(BaseView view) { return new GridViewInfo(view as GridViewBase); }
    }

}
