namespace SellerCenter.Helpers
{
    public static class FormHelper
    {
        public static void SetFullWorkingScreen(Form form)
        {
            var screen = Screen.FromControl(form).WorkingArea;

            form.StartPosition = FormStartPosition.CenterScreen;
            form.Location = new Point(screen.X, screen.Y);
            form.Size = new Size(screen.Width, screen.Height);
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
    }
}