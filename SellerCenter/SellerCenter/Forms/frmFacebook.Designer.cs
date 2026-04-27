namespace SellerCenter.Forms
{
    partial class frmFacebook
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmFacebook));
            webView21 = new Microsoft.Web.WebView2.WinForms.WebView2();
            txtUserToken = new TextBox();
            txtPageId = new TextBox();
            txtPageToken = new TextBox();
            btnPostFacebook = new Button();
            txtContent = new TextBox();
            btnGetToken = new Button();
            txtAppId = new TextBox();
            ((System.ComponentModel.ISupportInitialize)webView21).BeginInit();
            SuspendLayout();
            // 
            // webView21
            // 
            webView21.AllowExternalDrop = true;
            webView21.CreationProperties = null;
            webView21.DefaultBackgroundColor = Color.White;
            webView21.Dock = DockStyle.Bottom;
            webView21.Location = new Point(0, 188);
            webView21.Name = "webView21";
            webView21.Size = new Size(1902, 803);
            webView21.TabIndex = 0;
            webView21.ZoomFactor = 1D;
            // 
            // txtUserToken
            // 
            txtUserToken.Location = new Point(12, 12);
            txtUserToken.Name = "txtUserToken";
            txtUserToken.Size = new Size(297, 23);
            txtUserToken.TabIndex = 1;
            // 
            // txtPageId
            // 
            txtPageId.Location = new Point(12, 41);
            txtPageId.Name = "txtPageId";
            txtPageId.Size = new Size(297, 23);
            txtPageId.TabIndex = 2;
            // 
            // txtPageToken
            // 
            txtPageToken.Location = new Point(12, 70);
            txtPageToken.Name = "txtPageToken";
            txtPageToken.Size = new Size(297, 23);
            txtPageToken.TabIndex = 3;
            // 
            // btnPostFacebook
            // 
            btnPostFacebook.Location = new Point(382, 41);
            btnPostFacebook.Name = "btnPostFacebook";
            btnPostFacebook.Size = new Size(84, 35);
            btnPostFacebook.TabIndex = 4;
            btnPostFacebook.Text = "Đăng bài";
            btnPostFacebook.UseVisualStyleBackColor = true;
            btnPostFacebook.Click += btnPostFacebook_Click;
            // 
            // txtContent
            // 
            txtContent.Location = new Point(382, 12);
            txtContent.Name = "txtContent";
            txtContent.Size = new Size(297, 23);
            txtContent.TabIndex = 5;
            // 
            // btnGetToken
            // 
            btnGetToken.Location = new Point(12, 147);
            btnGetToken.Name = "btnGetToken";
            btnGetToken.Size = new Size(84, 35);
            btnGetToken.TabIndex = 6;
            btnGetToken.Text = "Get Token";
            btnGetToken.UseVisualStyleBackColor = true;
            btnGetToken.Click += btnGetToken_Click;
            // 
            // txtAppId
            // 
            txtAppId.Location = new Point(12, 99);
            txtAppId.Name = "txtAppId";
            txtAppId.Size = new Size(297, 23);
            txtAppId.TabIndex = 7;
            // 
            // frmFacebook
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1902, 991);
            Controls.Add(txtAppId);
            Controls.Add(btnGetToken);
            Controls.Add(txtContent);
            Controls.Add(btnPostFacebook);
            Controls.Add(txtPageToken);
            Controls.Add(txtPageId);
            Controls.Add(txtUserToken);
            Controls.Add(webView21);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximumSize = new Size(1920, 1080);
            MinimumSize = new Size(1918, 1030);
            Name = "frmFacebook";
            Text = "Đăng nhập facebook";
            Load += frmFacebook_Load;
            ((System.ComponentModel.ISupportInitialize)webView21).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Microsoft.Web.WebView2.WinForms.WebView2 webView21;
        private TextBox txtUserToken;
        private TextBox txtPageId;
        private TextBox txtPageToken;
        private Button btnPostFacebook;
        private TextBox txtContent;
        private Button btnGetToken;
        private TextBox txtAppId;
    }
}