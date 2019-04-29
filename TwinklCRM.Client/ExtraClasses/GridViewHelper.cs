using DevExpress.XtraGrid.Columns;
using DevExpress.XtraGrid.Views.Grid;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwinklCRM.Client.ExtraClasses
{
    internal static class GridViewHelper
    {
        private static string[] SystemColumns = new string[]
        {
            "Id",
            "IsDel",
            "CreationDate",
            "CreatedBy",
            "UpdateDate",
            "UpdatedBy",
            "UserId",
        };

        public static void LoadDefaultColumnSettings(GridView gridView, bool hideReferenceFields = true)
        {
            foreach (GridColumn column in gridView.Columns)
            {
                if ((column.FieldName.EndsWith("Id") && hideReferenceFields) || SystemColumns.Contains(column.FieldName))
                {
                    column.Visible = false;
                    column.OptionsColumn.AllowShowHide = false;
                    column.OptionsFilter.AllowFilter = false;
                    continue;
                }
            }
        }

    }
}
