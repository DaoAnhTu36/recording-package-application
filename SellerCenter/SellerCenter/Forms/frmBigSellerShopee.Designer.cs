namespace SellerCenter.Forms
{
    partial class frmBigSellerShopee
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmBigSellerShopee));
            webViewBigSellerShopee = new Microsoft.Web.WebView2.WinForms.WebView2();
            ((System.ComponentModel.ISupportInitialize)webViewBigSellerShopee).BeginInit();
            SuspendLayout();
            // 
            // webViewBigSellerShopee
            // 
            webViewBigSellerShopee.AllowExternalDrop = true;
            webViewBigSellerShopee.CreationProperties = null;
            webViewBigSellerShopee.DefaultBackgroundColor = Color.White;
            webViewBigSellerShopee.Dock = DockStyle.Fill;
            webViewBigSellerShopee.Location = new Point(0, 0);
            webViewBigSellerShopee.Name = "webViewBigSellerShopee";
            webViewBigSellerShopee.Size = new Size(800, 450);
            webViewBigSellerShopee.TabIndex = 0;
            webViewBigSellerShopee.ZoomFactor = 1D;
            // 
            // frmBigSellerShopee
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(webViewBigSellerShopee);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "frmBigSellerShopee";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "BigSeller Shopee";
            WindowState = FormWindowState.Maximized;
            Load += frmBigSeller_Load;
            ((System.ComponentModel.ISupportInitialize)webViewBigSellerShopee).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Microsoft.Web.WebView2.WinForms.WebView2 webViewBigSellerShopee;
    }
}