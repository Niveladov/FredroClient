using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FredroClient.BaseGUI
{
    [ToolboxItem(true)]
    public class RoundedPictureEdit : PictureEdit
    {
        public RoundedPictureEdit() : base()
        {
            this.BackColor = Color.Transparent;
        }


        protected override void OnResize(EventArgs e)
        {
            base.OnResize(e);
            DrawRoundedRectangle(this.CreateGraphics(), this.ClientRectangle, ClientRectangle.Height / 2, new Pen(Color.Black));
        }

        private void DrawRoundedRectangle(Graphics graphics, Rectangle Bounds, int CornerRadius, Pen DrawPen)
        {
            int strokeOffset = Convert.ToInt32(Math.Ceiling(DrawPen.Width));
            Bounds = Rectangle.Inflate(Bounds, -strokeOffset, -strokeOffset);

            DrawPen.EndCap = DrawPen.StartCap = LineCap.Round;

            using (GraphicsPath graphicsPath = new GraphicsPath())
            {
                graphicsPath.AddArc(Bounds.X, Bounds.Y, CornerRadius, CornerRadius, 180, 90);
                graphicsPath.AddArc(Bounds.X + Bounds.Width - CornerRadius, Bounds.Y, CornerRadius, CornerRadius, 270, 90);
                graphicsPath.AddArc(Bounds.X + Bounds.Width - CornerRadius, Bounds.Y + Bounds.Height - CornerRadius, CornerRadius, CornerRadius, 0, 90);
                graphicsPath.AddArc(Bounds.X, Bounds.Y + Bounds.Height - CornerRadius, CornerRadius, CornerRadius, 90, 90);
                graphicsPath.CloseAllFigures();

                graphics.SmoothingMode = SmoothingMode.HighQuality;
                graphics.DrawPath(DrawPen, graphicsPath);

                this.Region = new Region(graphicsPath);
            }
        }
    }
}
