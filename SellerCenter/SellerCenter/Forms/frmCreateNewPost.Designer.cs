namespace SellerCenter.Forms
{
    partial class frmCreateNewPost
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCreateNewPost));
            label1 = new Label();
            txtProductCode = new TextBox();
            label2 = new Label();
            txtProductName = new TextBox();
            label3 = new Label();
            txtProductDesc = new RichTextBox();
            label4 = new Label();
            txtQuantitPost = new NumericUpDown();
            label5 = new Label();
            socialMediaPlatformControl2 = new SellerCenter.UserControls.SocialMediaPlatformControl();
            ((System.ComponentModel.ISupportInitialize)txtQuantitPost).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 8);
            label1.Name = "label1";
            label1.Size = new Size(79, 15);
            label1.TabIndex = 0;
            label1.Text = "Mã sản phẩm";
            // 
            // txtProductCode
            // 
            txtProductCode.Location = new Point(12, 26);
            txtProductCode.Name = "txtProductCode";
            txtProductCode.Size = new Size(219, 23);
            txtProductCode.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 70);
            label2.Name = "label2";
            label2.Size = new Size(81, 15);
            label2.TabIndex = 2;
            label2.Text = "Tên sản phẩm";
            // 
            // txtProductName
            // 
            txtProductName.Location = new Point(12, 88);
            txtProductName.Name = "txtProductName";
            txtProductName.Size = new Size(219, 23);
            txtProductName.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 135);
            label3.Name = "label3";
            label3.Size = new Size(93, 15);
            label3.TabIndex = 4;
            label3.Text = "Mô tả sản phẩm";
            // 
            // txtProductDesc
            // 
            txtProductDesc.Location = new Point(12, 153);
            txtProductDesc.Name = "txtProductDesc";
            txtProductDesc.Size = new Size(219, 178);
            txtProductDesc.TabIndex = 5;
            txtProductDesc.Text = "";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(293, 8);
            label4.Name = "label4";
            label4.Size = new Size(95, 15);
            label4.TabIndex = 6;
            label4.Text = "Số lượng bài viết";
            // 
            // txtQuantitPost
            // 
            txtQuantitPost.Location = new Point(293, 27);
            txtQuantitPost.Maximum = new decimal(new int[] { 5, 0, 0, 0 });
            txtQuantitPost.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            txtQuantitPost.Name = "txtQuantitPost";
            txtQuantitPost.Size = new Size(120, 23);
            txtQuantitPost.TabIndex = 8;
            txtQuantitPost.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(293, 70);
            label5.Name = "label5";
            label5.Size = new Size(124, 15);
            label5.TabIndex = 9;
            label5.Text = "Nền tảng mạng xã hội";
            // 
            // socialMediaPlatformControl2
            // 
            socialMediaPlatformControl2.Location = new Point(293, 88);
            socialMediaPlatformControl2.Name = "socialMediaPlatformControl2";
            socialMediaPlatformControl2.Size = new Size(124, 243);
            socialMediaPlatformControl2.TabIndex = 10;
            // 
            // frmCreateNewPost
            // 
            AutoScaleMode = AutoScaleMode.None;
            ClientSize = new Size(1904, 1041);
            Controls.Add(socialMediaPlatformControl2);
            Controls.Add(label5);
            Controls.Add(txtQuantitPost);
            Controls.Add(label4);
            Controls.Add(txtProductDesc);
            Controls.Add(label3);
            Controls.Add(txtProductName);
            Controls.Add(label2);
            Controls.Add(txtProductCode);
            Controls.Add(label1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximumSize = new Size(1920, 1080);
            MinimumSize = new Size(1918, 1030);
            Name = "frmCreateNewPost";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Tạo bài viết mới";
            WindowState = FormWindowState.Maximized;
            Load += frmCreateNewPost_Load;
            ((System.ComponentModel.ISupportInitialize)txtQuantitPost).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtProductCode;
        private Label label2;
        private TextBox txtProductName;
        private Label label3;
        private RichTextBox txtProductDesc;
        private Label label4;
        private NumericUpDown txtQuantitPost;
        private Label label5;
        private UserControls.SocialMediaPlatformControl socialMediaPlatformControl1;
        private UserControls.SocialMediaPlatformControl socialMediaPlatformControl2;
    }
}