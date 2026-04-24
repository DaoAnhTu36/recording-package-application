using SellerCenter.UserControls;

namespace SellerCenter.Forms
{
    public partial class frmProductManager : Form
    {
        public frmProductManager()
        {
            InitializeComponent();
        }

        private void frmProductManager_Load(object sender, EventArgs e)
        {
            var menu = new MenuStripControl().CreateMenu(this);
            this.MainMenuStrip = menu;
            this.Controls.Add(menu);
        }
    }
}