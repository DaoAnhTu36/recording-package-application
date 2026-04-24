namespace SellerCenter
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            menu = new MenuStrip();
            menuOrder = new ToolStripMenuItem();
            subMenuNewRecording = new ToolStripMenuItem();
            subMenuRecordHistory = new ToolStripMenuItem();
            menuBigSeller = new ToolStripMenuItem();
            subMenuShopee = new ToolStripMenuItem();
            subMenuTiktok = new ToolStripMenuItem();
            menuPageManager = new ToolStripMenuItem();
            subMenuNewPost = new ToolStripMenuItem();
            menuItemNewPost = new ToolStripMenuItem();
            menuItemFacebook = new ToolStripMenuItem();
            menuItemTiktok = new ToolStripMenuItem();
            menuItemShopee = new ToolStripMenuItem();
            subMenuManager = new ToolStripMenuItem();
            menuProductManager = new ToolStripMenuItem();
            subMenuCreateNewProduct = new ToolStripMenuItem();
            subMenuProducts = new ToolStripMenuItem();
            menu.SuspendLayout();
            SuspendLayout();
            // 
            // menu
            // 
            menu.Items.AddRange(new ToolStripItem[] { menuOrder, menuBigSeller, menuPageManager, menuProductManager });
            menu.Location = new Point(0, 0);
            menu.Name = "menu";
            menu.Size = new Size(800, 24);
            menu.TabIndex = 0;
            menu.Text = "menu";
            // 
            // menuOrder
            // 
            menuOrder.DropDownItems.AddRange(new ToolStripItem[] { subMenuNewRecording, subMenuRecordHistory });
            menuOrder.Name = "menuOrder";
            menuOrder.Size = new Size(147, 20);
            menuOrder.Text = "Quản lý video sản phẩm";
            // 
            // subMenuNewRecording
            // 
            subMenuNewRecording.Name = "subMenuNewRecording";
            subMenuNewRecording.Size = new Size(195, 22);
            subMenuNewRecording.Text = "Quay video đóng hàng";
            subMenuNewRecording.Click += subMenuNewRecording_Click;
            // 
            // subMenuRecordHistory
            // 
            subMenuRecordHistory.Name = "subMenuRecordHistory";
            subMenuRecordHistory.Size = new Size(195, 22);
            subMenuRecordHistory.Text = "Lịch sử";
            subMenuRecordHistory.Click += subMenuRecordHistory_Click;
            // 
            // menuBigSeller
            // 
            menuBigSeller.DropDownItems.AddRange(new ToolStripItem[] { subMenuShopee, subMenuTiktok });
            menuBigSeller.Name = "menuBigSeller";
            menuBigSeller.Size = new Size(64, 20);
            menuBigSeller.Text = "BigSeller";
            menuBigSeller.Click += menuBigSeller_Click;
            // 
            // subMenuShopee
            // 
            subMenuShopee.Name = "subMenuShopee";
            subMenuShopee.Size = new Size(113, 22);
            subMenuShopee.Text = "Shopee";
            subMenuShopee.Click += subMenuShopee_Click;
            // 
            // subMenuTiktok
            // 
            subMenuTiktok.Name = "subMenuTiktok";
            subMenuTiktok.Size = new Size(113, 22);
            subMenuTiktok.Text = "Tiktok";
            subMenuTiktok.Click += subMenuTiktok_Click;
            // 
            // menuPageManager
            // 
            menuPageManager.DropDownItems.AddRange(new ToolStripItem[] { subMenuNewPost, subMenuManager });
            menuPageManager.Name = "menuPageManager";
            menuPageManager.Size = new Size(66, 20);
            menuPageManager.Text = "Đăng bài";
            // 
            // subMenuNewPost
            // 
            subMenuNewPost.DropDownItems.AddRange(new ToolStripItem[] { menuItemNewPost, menuItemFacebook, menuItemTiktok, menuItemShopee });
            subMenuNewPost.Name = "subMenuNewPost";
            subMenuNewPost.Size = new Size(118, 22);
            subMenuNewPost.Text = "Tạo mới";
            // 
            // menuItemNewPost
            // 
            menuItemNewPost.Name = "menuItemNewPost";
            menuItemNewPost.Size = new Size(125, 22);
            menuItemNewPost.Text = "Bài viết";
            menuItemNewPost.Click += menuItemNewPost_Click;
            // 
            // menuItemFacebook
            // 
            menuItemFacebook.Name = "menuItemFacebook";
            menuItemFacebook.Size = new Size(125, 22);
            menuItemFacebook.Text = "Facebook";
            // 
            // menuItemTiktok
            // 
            menuItemTiktok.Name = "menuItemTiktok";
            menuItemTiktok.Size = new Size(125, 22);
            menuItemTiktok.Text = "Tiktok";
            // 
            // menuItemShopee
            // 
            menuItemShopee.Name = "menuItemShopee";
            menuItemShopee.Size = new Size(125, 22);
            menuItemShopee.Text = "Shopee";
            // 
            // subMenuManager
            // 
            subMenuManager.Name = "subMenuManager";
            subMenuManager.Size = new Size(118, 22);
            subMenuManager.Text = "Quản lý";
            // 
            // menuProductManager
            // 
            menuProductManager.DropDownItems.AddRange(new ToolStripItem[] { subMenuCreateNewProduct, subMenuProducts });
            menuProductManager.Name = "menuProductManager";
            menuProductManager.Size = new Size(115, 20);
            menuProductManager.Text = "Quản lý sản phẩm";
            // 
            // subMenuCreateNewProduct
            // 
            subMenuCreateNewProduct.Name = "subMenuCreateNewProduct";
            subMenuCreateNewProduct.Size = new Size(180, 22);
            subMenuCreateNewProduct.Text = "Thêm mới";
            subMenuCreateNewProduct.Click += subMenuCreateNewProduct_Click;
            // 
            // subMenuProducts
            // 
            subMenuProducts.Name = "subMenuProducts";
            subMenuProducts.Size = new Size(180, 22);
            subMenuProducts.Text = "Danh sách";
            subMenuProducts.Click += subMenuProducts_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(menu);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MainMenuStrip = menu;
            Name = "Form1";
            Text = "Seller Center";
            menu.ResumeLayout(false);
            menu.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menu;
        private ToolStripMenuItem menuOrder;
        private ToolStripMenuItem subMenuRecordHistory;
        private ToolStripMenuItem subMenuNewRecording;
        private ToolStripMenuItem menuBigSeller;
        private ToolStripMenuItem subMenuShopee;
        private ToolStripMenuItem subMenuTiktok;
        private ToolStripMenuItem menuPageManager;
        private ToolStripMenuItem subMenuNewPost;
        private ToolStripMenuItem menuItemFacebook;
        private ToolStripMenuItem menuItemTiktok;
        private ToolStripMenuItem menuItemShopee;
        private ToolStripMenuItem subMenuManager;
        private ToolStripMenuItem menuItemNewPost;
        private ToolStripMenuItem menuProductManager;
        private ToolStripMenuItem subMenuCreateNewProduct;
        private ToolStripMenuItem subMenuProducts;
    }
}
