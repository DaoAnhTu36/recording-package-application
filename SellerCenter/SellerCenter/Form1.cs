using SellerCenter.Forms;

namespace SellerCenter
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void subMenuNewRecording_Click(object sender, EventArgs e)
        {
            var screen = new frmRecording();
            screen.ShowDialog();
        }

        private void subMenuRecordHistory_Click(object sender, EventArgs e)
        {
            var screen = new frmHistoryScreen();
            screen.ShowDialog();
        }

        private void menuBigSeller_Click(object sender, EventArgs e)
        {
        }

        private void subMenuShopee_Click(object sender, EventArgs e)
        {
            var screen = new frmBigSellerShopee();
            screen.ShowDialog();
        }

        private void subMenuTiktok_Click(object sender, EventArgs e)
        {
            var screen = new frmBigSellerTiktok();
            screen.ShowDialog();
        }

        private void menuItemNewPost_Click(object sender, EventArgs e)
        {
            var screen = new frmCreateNewPost();
            screen.ShowDialog();
        }

        private void subMenuCreateNewProduct_Click(object sender, EventArgs e)
        {
            var screen = new frmCreateNewProduct();
            screen.ShowDialog();
        }

        private void subMenuProducts_Click(object sender, EventArgs e)
        {
            var screen = new frmProductManager();
            screen.ShowDialog();
        }
    }
}