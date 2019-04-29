using DevExpress.XtraGrid;
using DevExpress.XtraGrid.Registrator;
using DevExpress.XtraGrid.Views.Base;
using DevExpress.XtraGrid.Views.Grid;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TwinklCRM.Client.ExtraClasses;

namespace TwinklCRM.Client.BaseGUI
{
    [ToolboxItem(true)]
    internal sealed class GridControlBase : GridControl
    {
        public bool HideReferenceFields { get; set; } = true;

        public GridControlBase()
        {
            DataSourceChanged += GridControlBase_DataSourceChanged;
        }

        protected override BaseView CreateDefaultView()
        {
            return this.CreateView(nameof(GridViewBase));
        }

        protected override void RegisterAvailableViewsCore(InfoCollection collection)
        {
            base.RegisterAvailableViewsCore(collection);
            collection.Add(new GridViewBaseRegistrator());
        }

        private void GridControlBase_DataSourceChanged(object sender, EventArgs e)
        {
            foreach (var view in ViewCollection)
            {
                var gridView = view as GridView;
                if (gridView != null)
                {
                    gridView.PopulateColumns();
                    GridViewHelper.LoadDefaultColumnSettings(gridView, HideReferenceFields);
                }
            }
        }

    }
}
