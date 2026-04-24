using SellerCenter.Commons;

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
    }
}