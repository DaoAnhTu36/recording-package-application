namespace SellerCenter.Forms
{
    partial class frmBigSellerTiktok
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmBigSellerTiktok));
            webViewBigSellerTiktok = new Microsoft.Web.WebView2.WinForms.WebView2();
            ((System.ComponentModel.ISupportInitialize)webViewBigSellerTiktok).BeginInit();
            SuspendLayout();
            // 
            // webViewBigSellerTiktok
            // 
            webViewBigSellerTiktok.AllowExternalDrop = true;
            webViewBigSellerTiktok.CreationProperties = null;
            webViewBigSellerTiktok.DefaultBackgroundColor = Color.White;
            webViewBigSellerTiktok.Dock = DockStyle.Fill;
            webViewBigSellerTiktok.Location = new Point(0, 0);
            webViewBigSellerTiktok.MaximumSize = new Size(1920, 1080);
            webViewBigSellerTiktok.MinimumSize = new Size(1920, 1080);
            webViewBigSellerTiktok.Name = "webViewBigSellerTiktok";
            webViewBigSellerTiktok.Size = new Size(1920, 1080);
            webViewBigSellerTiktok.TabIndex = 0;
            webViewBigSellerTiktok.ZoomFactor = 1D;
            // 
            // frmBigSellerTiktok
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1904, 1041);
            Controls.Add(webViewBigSellerTiktok);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximumSize = new Size(1920, 1080);
            MinimumSize = new Size(1918, 1030);
            Name = "frmBigSellerTiktok";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "BigSeller Tiktok";
            WindowState = FormWindowState.Maximized;
            Load += frmBigSellerTiktok_Load;
            ((System.ComponentModel.ISupportInitialize)webViewBigSellerTiktok).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Microsoft.Web.WebView2.WinForms.WebView2 webViewBigSellerTiktok;
    }
}