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
            lstTemplate = new ComboBox();
            label6 = new Label();
            lblNotify = new Label();
            btnCreatePost = new Button();
            lblNotifyTemplate = new Label();
            tableLayoutPanel1 = new TableLayoutPanel();
            txtResponseChatGPT = new RichTextBox();
            ((System.ComponentModel.ISupportInitialize)txtQuantitPost).BeginInit();
            tableLayoutPanel1.SuspendLayout();
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
            txtProductCode.TextChanged += txtProductCode_TextChanged;
            txtProductCode.KeyUp += txtProductCode_KeyUp;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 75);
            label2.Name = "label2";
            label2.Size = new Size(81, 15);
            label2.TabIndex = 2;
            label2.Text = "Tên sản phẩm";
            // 
            // txtProductName
            // 
            txtProductName.Location = new Point(12, 93);
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
            txtProductDesc.Dock = DockStyle.Fill;
            txtProductDesc.Location = new Point(3, 3);
            txtProductDesc.Name = "txtProductDesc";
            txtProductDesc.Size = new Size(946, 827);
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
            txtQuantitPost.Size = new Size(64, 23);
            txtQuantitPost.TabIndex = 8;
            txtQuantitPost.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // lstTemplate
            // 
            lstTemplate.FormattingEnabled = true;
            lstTemplate.Location = new Point(293, 88);
            lstTemplate.Name = "lstTemplate";
            lstTemplate.Size = new Size(172, 23);
            lstTemplate.TabIndex = 11;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(293, 70);
            label6.Name = "label6";
            label6.Size = new Size(86, 15);
            label6.TabIndex = 12;
            label6.Text = "Chọn template";
            // 
            // lblNotify
            // 
            lblNotify.AutoSize = true;
            lblNotify.Font = new Font("Segoe UI", 6.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblNotify.ForeColor = Color.Red;
            lblNotify.Location = new Point(12, 52);
            lblNotify.Name = "lblNotify";
            lblNotify.Size = new Size(29, 12);
            lblNotify.TabIndex = 13;
            lblNotify.Text = "label5";
            lblNotify.Visible = false;
            // 
            // btnCreatePost
            // 
            btnCreatePost.Location = new Point(484, 25);
            btnCreatePost.Name = "btnCreatePost";
            btnCreatePost.Size = new Size(113, 23);
            btnCreatePost.TabIndex = 14;
            btnCreatePost.Text = "Tạo bài viết";
            btnCreatePost.UseVisualStyleBackColor = true;
            btnCreatePost.Click += btnCreatePost_Click;
            // 
            // lblNotifyTemplate
            // 
            lblNotifyTemplate.AutoSize = true;
            lblNotifyTemplate.Font = new Font("Segoe UI", 6.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblNotifyTemplate.ForeColor = Color.Red;
            lblNotifyTemplate.Location = new Point(293, 114);
            lblNotifyTemplate.Name = "lblNotifyTemplate";
            lblNotifyTemplate.Size = new Size(29, 12);
            lblNotifyTemplate.TabIndex = 15;
            lblNotifyTemplate.Text = "label5";
            lblNotifyTemplate.Visible = false;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Controls.Add(txtResponseChatGPT, 1, 0);
            tableLayoutPanel1.Controls.Add(txtProductDesc, 0, 0);
            tableLayoutPanel1.Dock = DockStyle.Bottom;
            tableLayoutPanel1.Location = new Point(0, 208);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Size = new Size(1904, 833);
            tableLayoutPanel1.TabIndex = 16;
            // 
            // txtResponseChatGPT
            // 
            txtResponseChatGPT.Dock = DockStyle.Fill;
            txtResponseChatGPT.Location = new Point(955, 3);
            txtResponseChatGPT.Name = "txtResponseChatGPT";
            txtResponseChatGPT.Size = new Size(946, 827);
            txtResponseChatGPT.TabIndex = 6;
            txtResponseChatGPT.Text = "";
            // 
            // frmCreateNewPost
            // 
            AutoScaleMode = AutoScaleMode.None;
            ClientSize = new Size(1904, 1041);
            Controls.Add(tableLayoutPanel1);
            Controls.Add(lblNotifyTemplate);
            Controls.Add(btnCreatePost);
            Controls.Add(lblNotify);
            Controls.Add(label6);
            Controls.Add(lstTemplate);
            Controls.Add(txtQuantitPost);
            Controls.Add(label4);
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
            tableLayoutPanel1.ResumeLayout(false);
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
        private UserControls.SocialMediaPlatformControl socialMediaPlatformControl1;
        private ComboBox lstTemplate;
        private Label label6;
        private Label lblNotify;
        private Button btnCreatePost;
        private Label lblNotifyTemplate;
        private TableLayoutPanel tableLayoutPanel1;
        private RichTextBox txtResponseChatGPT;
    }
}