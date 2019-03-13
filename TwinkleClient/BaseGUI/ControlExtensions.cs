using DevExpress.Utils.Drawing;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.ViewInfo;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TwinkleClient.BaseGUI
{
    public static class ControlExtensions
    {
        public static void SetScrollBarVisibility(this MemoEdit memoEdit)
        {
            MemoEditViewInfo vi = memoEdit.GetViewInfo() as MemoEditViewInfo;
            GraphicsCache cache = new GraphicsCache(memoEdit.CreateGraphics());
            int h = (vi as IHeightAdaptable).CalcHeight(cache, vi.MaskBoxRect.Width);
            ObjectInfoArgs args = new ObjectInfoArgs();
            args.Bounds = new Rectangle(0, 0, vi.ClientRect.Width, h);
            Rectangle rect = vi.BorderPainter.CalcBoundsByClientRectangle(args);
            cache.Dispose();
            memoEdit.Properties.ScrollBars = rect.Height > memoEdit.Height ?
                ScrollBars.Vertical : ScrollBars.None;
        }
    }
}
