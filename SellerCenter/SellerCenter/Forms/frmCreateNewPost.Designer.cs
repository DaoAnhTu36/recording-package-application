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
            txtProductDesc = new RichTextBox();
            label4 = new Label();
            txtQuantitPost = new NumericUpDown();
            lstTemplate = new ComboBox();
            label6 = new Label();
            btnCreatePost = new Button();
            txtResponseChatGPT = new RichTextBox();
            tableLayoutPanel2 = new TableLayoutPanel();
            tableLayoutPanel3 = new TableLayoutPanel();
            tableLayoutPanel4 = new TableLayoutPanel();
            ((System.ComponentModel.ISupportInitialize)txtQuantitPost).BeginInit();
            tableLayoutPanel2.SuspendLayout();
            tableLayoutPanel3.SuspendLayout();
            tableLayoutPanel4.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(3, 0);
            label1.Name = "label1";
            label1.Size = new Size(79, 15);
            label1.TabIndex = 0;
            label1.Text = "Mã sản phẩm";
            // 
            // txtProductCode
            // 
            txtProductCode.Dock = DockStyle.Fill;
            txtProductCode.Location = new Point(140, 3);
            txtProductCode.Name = "txtProductCode";
            txtProductCode.Size = new Size(383, 23);
            txtProductCode.TabIndex = 1;
            txtProductCode.TextChanged += txtProductCode_TextChanged;
            txtProductCode.KeyUp += txtProductCode_KeyUp;
            txtProductCode.Leave += txtProductCode_Leave;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(3, 44);
            label2.Name = "label2";
            label2.Size = new Size(81, 15);
            label2.TabIndex = 2;
            label2.Text = "Tên sản phẩm";
            // 
            // txtProductName
            // 
            txtProductName.Dock = DockStyle.Fill;
            txtProductName.Location = new Point(140, 47);
            txtProductName.Name = "txtProductName";
            txtProductName.Size = new Size(383, 23);
            txtProductName.TabIndex = 3;
            // 
            // txtProductDesc
            // 
            txtProductDesc.Dock = DockStyle.Fill;
            txtProductDesc.Location = new Point(3, 3);
            txtProductDesc.Name = "txtProductDesc";
            txtProductDesc.Size = new Size(943, 829);
            txtProductDesc.TabIndex = 5;
            txtProductDesc.Text = "";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(3, 88);
            label4.Name = "label4";
            label4.Size = new Size(95, 15);
            label4.TabIndex = 6;
            label4.Text = "Số lượng bài viết";
            // 
            // txtQuantitPost
            // 
            txtQuantitPost.Location = new Point(140, 91);
            txtQuantitPost.Maximum = new decimal(new int[] { 5, 0, 0, 0 });
            txtQuantitPost.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            txtQuantitPost.Name = "txtQuantitPost";
            txtQuantitPost.Size = new Size(64, 23);
            txtQuantitPost.TabIndex = 8;
            txtQuantitPost.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // lstTemplate
            // 
            lstTemplate.Dock = DockStyle.Fill;
            lstTemplate.FormattingEnabled = true;
            lstTemplate.Location = new Point(140, 131);
            lstTemplate.Name = "lstTemplate";
            lstTemplate.Size = new Size(383, 23);
            lstTemplate.TabIndex = 11;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(3, 128);
            label6.Name = "label6";
            label6.Size = new Size(86, 15);
            label6.TabIndex = 12;
            label6.Text = "Chọn template";
            // 
            // btnCreatePost
            // 
            btnCreatePost.Location = new Point(3, 165);
            btnCreatePost.Name = "btnCreatePost";
            btnCreatePost.Size = new Size(113, 23);
            btnCreatePost.TabIndex = 14;
            btnCreatePost.Text = "Tạo bài viết";
            btnCreatePost.UseVisualStyleBackColor = true;
            btnCreatePost.Click += btnCreatePost_Click;
            // 
            // txtResponseChatGPT
            // 
            txtResponseChatGPT.Dock = DockStyle.Fill;
            txtResponseChatGPT.Location = new Point(952, 3);
            txtResponseChatGPT.Name = "txtResponseChatGPT";
            txtResponseChatGPT.Size = new Size(943, 829);
            txtResponseChatGPT.TabIndex = 6;
            txtResponseChatGPT.Text = "";
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 2;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 26.0456276F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 73.95438F));
            tableLayoutPanel2.Controls.Add(label1, 0, 0);
            tableLayoutPanel2.Controls.Add(txtProductCode, 1, 0);
            tableLayoutPanel2.Controls.Add(label2, 0, 1);
            tableLayoutPanel2.Controls.Add(btnCreatePost, 0, 4);
            tableLayoutPanel2.Controls.Add(txtProductName, 1, 1);
            tableLayoutPanel2.Controls.Add(label4, 0, 2);
            tableLayoutPanel2.Controls.Add(lstTemplate, 1, 3);
            tableLayoutPanel2.Controls.Add(label6, 0, 3);
            tableLayoutPanel2.Controls.Add(txtQuantitPost, 1, 2);
            tableLayoutPanel2.Location = new Point(3, 3);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 5;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 40F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 34F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 32F));
            tableLayoutPanel2.Size = new Size(526, 194);
            tableLayoutPanel2.TabIndex = 17;
            // 
            // tableLayoutPanel3
            // 
            tableLayoutPanel3.ColumnCount = 1;
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel3.Controls.Add(tableLayoutPanel4, 0, 1);
            tableLayoutPanel3.Controls.Add(tableLayoutPanel2, 0, 0);
            tableLayoutPanel3.Dock = DockStyle.Fill;
            tableLayoutPanel3.Location = new Point(0, 0);
            tableLayoutPanel3.Name = "tableLayoutPanel3";
            tableLayoutPanel3.RowCount = 2;
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 19.2122955F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 80.7877045F));
            tableLayoutPanel3.Size = new Size(1904, 1041);
            tableLayoutPanel3.TabIndex = 18;
            // 
            // tableLayoutPanel4
            // 
            tableLayoutPanel4.ColumnCount = 2;
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel4.Controls.Add(txtResponseChatGPT, 1, 0);
            tableLayoutPanel4.Controls.Add(txtProductDesc, 0, 0);
            tableLayoutPanel4.Dock = DockStyle.Fill;
            tableLayoutPanel4.Location = new Point(3, 203);
            tableLayoutPanel4.Name = "tableLayoutPanel4";
            tableLayoutPanel4.RowCount = 1;
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel4.Size = new Size(1898, 835);
            tableLayoutPanel4.TabIndex = 19;
            // 
            // frmCreateNewPost
            // 
            AutoScaleMode = AutoScaleMode.None;
            ClientSize = new Size(1904, 1041);
            Controls.Add(tableLayoutPanel3);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximumSize = new Size(1920, 1080);
            MinimumSize = new Size(1918, 1030);
            Name = "frmCreateNewPost";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Tạo bài viết mới";
            WindowState = FormWindowState.Maximized;
            Load += frmCreateNewPost_Load;
            ((System.ComponentModel.ISupportInitialize)txtQuantitPost).EndInit();
            tableLayoutPanel2.ResumeLayout(false);
            tableLayoutPanel2.PerformLayout();
            tableLayoutPanel3.ResumeLayout(false);
            tableLayoutPanel4.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private TextBox txtProductCode;
        private Label label2;
        private TextBox txtProductName;
        private RichTextBox txtProductDesc;
        private Label label4;
        private NumericUpDown txtQuantitPost;
        private UserControls.SocialMediaPlatformControl socialMediaPlatformControl1;
        private ComboBox lstTemplate;
        private Label label6;
        private Button btnCreatePost;
        private RichTextBox txtResponseChatGPT;
        private TableLayoutPanel tableLayoutPanel2;
        private TableLayoutPanel tableLayoutPanel3;
        private TableLayoutPanel tableLayoutPanel4;
    }
}