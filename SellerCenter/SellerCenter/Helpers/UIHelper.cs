using FontAwesome.Sharp;
using SellerCenter.Commons;
using SellerCenter.Configurations;
using System.Drawing.Drawing2D;

namespace SellerCenter.Helpers
{
    public static class UIHelper
    {
        public static void InitMenu(Form form, Panel panelMain)
        {
            if (form.MainMenuStrip != null)
                return;

            var builder = new MenuBuilder(form, panelMain);
            var menuStrip = builder.BuildFromJson();

            form.MainMenuStrip = menuStrip;
            form.Controls.Add(menuStrip);
        }

        public static void StyleButton(Button btn, Color? backColor = null)
        {
            btn.Height = UIConfig.ButtonHeight;
            btn.Width = UIConfig.ButtonWidth;
            btn.Font = UIConfig.DefaultFont;
            btn.BackColor = backColor ?? UIConfig.PrimaryColor;
            btn.ForeColor = Color.White;
            btn.FlatStyle = FlatStyle.Flat;
            btn.FlatAppearance.BorderSize = 0;
            btn.Cursor = Cursors.Hand;
        }

        public static void StyleDataGridView(DataGridView dgv)
        {
            dgv.Font = UIConfig.DefaultFont;
            dgv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgv.RowHeadersVisible = false;
            dgv.AllowUserToAddRows = false;
            dgv.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgv.EnableHeadersVisualStyles = false;
            dgv.AllowUserToDeleteRows = false;
            dgv.ClipboardCopyMode = DataGridViewClipboardCopyMode.Disable;
            dgv.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            dgv.RowTemplate.Height = 35;
            dgv.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            //dgv.AutoGenerateColumns = false;
            //dgv.DataBindingComplete += (s, e) =>
            //{
            //    dgv.AutoGenerateColumns = false;
            //};
        }

        public static void StyleTextBox(TextBox txt)
        {
            txt.Font = UIConfig.DefaultFont;
            txt.Height = 30;
        }

        public static void StyleComboBox(ComboBox cb)
        {
            cb.Font = UIConfig.DefaultFont;
            cb.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        public static void ApplyFormStyle(Form form)
        {
            form.Font = UIConfig.DefaultFont;
            form.BackColor = Color.White;
        }

        public static void StyleLabel(Label lbl)
        {
            lbl.Font = UIConfig.DefaultFont;
            lbl.ForeColor = Color.FromArgb(33, 37, 41);
            lbl.AutoSize = true;
        }

        public static void StyleRichTextBox(RichTextBox rtb)
        {
            rtb.Font = UIConfig.DefaultFont;
            rtb.ForeColor = Color.FromArgb(33, 37, 41);
            rtb.BorderStyle = BorderStyle.FixedSingle;
            rtb.BackColor = Color.White;
            rtb.Multiline = true;
            rtb.ScrollBars = RichTextBoxScrollBars.Vertical;
            rtb.Padding = new Padding(5);
            rtb.ShortcutsEnabled = true;
        }

        public static void ApplyAll(Control parent)
        {
            foreach (Control ctrl in parent.Controls)
            {
                if (ctrl is Button btn)
                    StyleButton(btn);
                else if (ctrl is TextBox txt)
                    StyleTextBox(txt);
                else if (ctrl is ComboBox cb)
                    StyleComboBox(cb);
                else if (ctrl is DataGridView dgv)
                    StyleDataGridView(dgv);
                else if (ctrl is Label lbl)
                    StyleLabel(lbl);
                else if (ctrl is RichTextBox rtb)
                    StyleRichTextBox(rtb);

                if (ctrl.HasChildren)
                    ApplyAll(ctrl);
            }
        }

        public static void StyleButtonHover(Button btn, Color normalColor, Color hoverColor)
        {
            btn.BackColor = normalColor;
            btn.ForeColor = Color.White;
            btn.FlatStyle = FlatStyle.Flat;
            btn.FlatAppearance.BorderSize = 0;
            btn.Cursor = Cursors.Hand;

            btn.MouseEnter += (s, e) =>
            {
                btn.BackColor = hoverColor;
            };

            btn.MouseLeave += (s, e) =>
            {
                btn.BackColor = normalColor;
            };
        }

        /// <summary>
        /// var btnPost = UIHelper.CreateIconButton(
        /// "Đăng bài",
        /// IconChar.PaperPlane,
        /// Color.FromArgb(0, 120, 215),
        /// btnPost_Click
        /// );
        /// </summary>
        /// <param name="text"></param>
        /// <param name="icon"></param>
        /// <param name="backColor"></param>
        /// <param name="onClick"></param>
        /// <param name="width"></param>
        /// <param name="height"></param>
        /// <returns></returns>
        public static IconButton CreateIconButton(
            string text,
            IconChar icon,
            Color backColor,
            EventHandler onClick,
            int width = 120,
            int height = 36
        )
        {
            var btn = new IconButton
            {
                Text = text,
                IconChar = icon,
                IconColor = Color.White,
                IconSize = 18,
                TextImageRelation = TextImageRelation.ImageBeforeText,
                ImageAlign = ContentAlignment.MiddleLeft,
                TextAlign = ContentAlignment.MiddleCenter,
                Padding = new Padding(12, 0, 12, 0),
                Margin = new Padding(5),
                Width = width,
                Height = height,
                BackColor = backColor,
                ForeColor = Color.White,
                FlatStyle = FlatStyle.Flat
            };
            btn.FlatAppearance.BorderSize = 0;
            btn.Cursor = Cursors.Hand;
            if (onClick != null)
                btn.Click += onClick;
            return btn;
        }

        private static void SetButtonRadius(Button btn, int radius)
        {
            var path = new GraphicsPath();

            int r = radius * 2;
            var rect = btn.ClientRectangle;

            path.AddArc(rect.X, rect.Y, r, r, 180, 90);
            path.AddArc(rect.Right - r, rect.Y, r, r, 270, 90);
            path.AddArc(rect.Right - r, rect.Bottom - r, r, r, 0, 90);
            path.AddArc(rect.X, rect.Bottom - r, r, r, 90, 90);

            path.CloseFigure();

            btn.Region = new Region(path);
        }
    }
}