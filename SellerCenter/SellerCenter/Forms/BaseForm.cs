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
        }
    }
}