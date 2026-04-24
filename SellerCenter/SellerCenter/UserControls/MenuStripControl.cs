using SellerCenter.Forms;

namespace SellerCenter.UserControls
{
    public partial class MenuStripControl : UserControl
    {
        public MenuStrip CreateMenu(Form parentForm)
        {
            var menuStrip = new MenuStrip();

            // ===== PRODUCT =====
            var productMenu = new ToolStripMenuItem("Sản phẩm");
            var addProduct = new ToolStripMenuItem("Thêm sản phẩm");
            addProduct.Click += (s, e) => new frmCreateNewProduct().Show();
            var listProduct = new ToolStripMenuItem("Danh sách");
            listProduct.Click += (s, e) => new frmProductManager().Show();
            productMenu.DropDownItems.Add(addProduct);
            productMenu.DropDownItems.Add(listProduct);

            menuStrip.Items.Add(productMenu);

            return menuStrip;
        }
    }
}