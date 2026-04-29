using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SellerCenter.Configurations
{
    public static class UIConfig
    {
        public static Font DefaultFont = new Font("Segoe UI", 10);
        public static Font HeaderFont = new Font("Segoe UI", 10, FontStyle.Bold);

        public static int ButtonHeight = 35;
        public static int ButtonWidth = 120;

        public static Color PrimaryColor = Color.FromArgb(0, 120, 215);
        public static Color DangerColor = Color.FromArgb(220, 53, 69);
        public static Color GrayColor = Color.Gray;

        public static Color GridHeaderBackColor = Color.FromArgb(240, 240, 240);
    }
}