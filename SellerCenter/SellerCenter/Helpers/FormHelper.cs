namespace SellerCenter.Helpers
{
    public static class FormHelper
    {
        public static void SetFullWorkingScreen(Form form)
        {
            var screen = Screen.FromControl(form).WorkingArea;
            //form.Location = new Point(screen.X, screen.Y);
            form.Size = new Size(screen.Width, screen.Height);
            form.StartPosition = FormStartPosition.CenterScreen;
        }

        public static void SetMaximized(Form form)
        {
            form.WindowState = FormWindowState.Maximized;
        }

        public static void ApplyDefaultForm(Form form)
        {
            form.StartPosition = FormStartPosition.CenterScreen;
            form.Font = new Font("Segoe UI", 10);
            form.BackColor = Color.White;
            form.MinimumSize = new Size(1200, 800);

            SetMaximized(form);
        }

        public static void ClearForm(Control parent)
        {
            foreach (Control ctrl in parent.Controls)
            {
                if (ctrl is TextBox txt)
                    txt.Clear();
                else if (ctrl is RichTextBox rtb)
                    rtb.Clear();
                else if (ctrl is ComboBox cb)
                    cb.SelectedIndex = -1;
                else if (ctrl is CheckBox chk)
                    chk.Checked = false;
                else if (ctrl is RadioButton rb)
                    rb.Checked = false;
                else if (ctrl is NumericUpDown num)
                    num.Value = num.Minimum;
                else if (ctrl is DateTimePicker dt)
                    dt.Value = DateTime.Now;
                else if (ctrl is AxWMPLib.AxWindowsMediaPlayer wmp)
                {
                    wmp.Ctlcontrols.stop();
                    wmp.URL = string.Empty;
                }

                if (ctrl.HasChildren)
                    ClearForm(ctrl);
            }
            var focusCtrl = FindControlByTabIndex(parent, 1);
            focusCtrl?.Focus();
        }

        public static Control FindControlByTabIndex(Control parent, int tabIndex)
        {
            foreach (Control ctrl in parent.Controls)
            {
                if (ctrl.TabIndex == tabIndex && ctrl.CanFocus)
                    return ctrl;

                if (ctrl.HasChildren)
                {
                    var child = FindControlByTabIndex(ctrl, tabIndex);
                    if (child != null)
                        return child;
                }
            }
            return null;
        }
    }
}