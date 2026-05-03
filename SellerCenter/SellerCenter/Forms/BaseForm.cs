using SellerCenter.Helpers;

namespace SellerCenter.Forms
{
    public class BaseForm : Form
    {
        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            FormHelper.SetFullWorkingScreen(this);
            UIHelper.ApplyAll(this);
            this.Name = "Seller Center";
            this.Icon = Properties.Resources.AppIcon;
            this.MaximumSize = new Size(1920, 1080);
            this.MinimumSize = new Size(1920, 1080);
        }
    }
}