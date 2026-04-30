using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SellerCenter.Commons
{
    public class ModernMenuRenderer : ToolStripProfessionalRenderer
    {
        public ModernMenuRenderer() : base(new ModernColorTable())
        {
        }

        protected override void OnRenderMenuItemBackground(ToolStripItemRenderEventArgs e)
        {
            var g = e.Graphics;
            var rect = new Rectangle(Point.Empty, e.Item.Size);

            if (e.Item.Selected)
            {
                using var brush = new SolidBrush(Color.FromArgb(240, 245, 255)); // hover
                g.FillRectangle(brush, rect);
            }
            else if (e.Item.Pressed)
            {
                using var brush = new SolidBrush(Color.FromArgb(220, 230, 250)); // active
                g.FillRectangle(brush, rect);
            }
            else
            {
                using var brush = new SolidBrush(Color.White);
                g.FillRectangle(brush, rect);
            }
        }

        protected override void OnRenderItemText(ToolStripItemTextRenderEventArgs e)
        {
            e.TextColor = Color.FromArgb(33, 37, 41); // text dark
            e.TextFont = new Font("Segoe UI", 10, FontStyle.Regular);
            base.OnRenderItemText(e);
        }

        protected override void OnRenderSeparator(ToolStripSeparatorRenderEventArgs e)
        {
            using var pen = new Pen(Color.FromArgb(230, 230, 230));
            e.Graphics.DrawLine(pen, 5, e.Item.Height / 2, e.Item.Width - 5, e.Item.Height / 2);
        }
    }

    public class ModernColorTable : ProfessionalColorTable
    {
        public override Color MenuStripGradientBegin => Color.White;
        public override Color MenuStripGradientEnd => Color.White;
        public override Color ToolStripDropDownBackground => Color.White;
        public override Color ImageMarginGradientBegin => Color.White;
        public override Color ImageMarginGradientMiddle => Color.White;
        public override Color ImageMarginGradientEnd => Color.White;
        public override Color MenuItemSelected => Color.FromArgb(240, 245, 255);
        public override Color MenuItemBorder => Color.FromArgb(200, 210, 230);
    }
}