namespace SellerCenter.Forms
{
    partial class frmPostManager
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPostManager));
            dataGridViewPostContent = new DataGridView();
            id = new DataGridViewTextBoxColumn();
            product_code = new DataGridViewTextBoxColumn();
            title = new DataGridViewTextBoxColumn();
            content = new DataGridViewTextBoxColumn();
            hook = new DataGridViewTextBoxColumn();
            hashtag = new DataGridViewTextBoxColumn();
            created_at = new DataGridViewTextBoxColumn();
            updated_at = new DataGridViewTextBoxColumn();
            label1 = new Label();
            txtKeyword = new TextBox();
            txtTitle = new TextBox();
            txtContent = new RichTextBox();
            txtHook = new TextBox();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            btnSave = new Button();
            btnCancel = new Button();
            tableLayoutPanel1 = new TableLayoutPanel();
            label5 = new Label();
            txtHashtag = new RichTextBox();
            btnPost = new Button();
            lblPostStatus = new Label();
            label6 = new Label();
            videoPreviewControl1 = new SellerCenter.UserControls.VideoPreviewControl();
            tableLayoutPanel2 = new TableLayoutPanel();
            ((System.ComponentModel.ISupportInitialize)dataGridViewPostContent).BeginInit();
            tableLayoutPanel1.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            SuspendLayout();
            // 
            // dataGridViewPostContent
            // 
            dataGridViewPostContent.AllowUserToAddRows = false;
            dataGridViewPostContent.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewPostContent.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewPostContent.Columns.AddRange(new DataGridViewColumn[] { id, product_code, title, content, hook, hashtag, created_at, updated_at });
            dataGridViewPostContent.Dock = DockStyle.Fill;
            dataGridViewPostContent.Location = new Point(595, 3);
            dataGridViewPostContent.Name = "dataGridViewPostContent";
            dataGridViewPostContent.Size = new Size(1306, 1035);
            dataGridViewPostContent.TabIndex = 0;
            dataGridViewPostContent.Click += dataGridViewPostContent_Click;
            // 
            // id
            // 
            id.HeaderText = "ID";
            id.Name = "id";
            // 
            // product_code
            // 
            product_code.HeaderText = "Mã sản phẩm";
            product_code.Name = "product_code";
            // 
            // title
            // 
            title.HeaderText = "Tiêu đề";
            title.Name = "title";
            // 
            // content
            // 
            content.HeaderText = "Nội dung";
            content.Name = "content";
            // 
            // hook
            // 
            hook.HeaderText = "Câu hook";
            hook.Name = "hook";
            // 
            // hashtag
            // 
            hashtag.HeaderText = "Hashtag";
            hashtag.Name = "hashtag";
            // 
            // created_at
            // 
            created_at.HeaderText = "Thời gian tạo";
            created_at.Name = "created_at";
            // 
            // updated_at
            // 
            updated_at.HeaderText = "Thời gian cập nhật";
            updated_at.Name = "updated_at";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(3, 0);
            label1.Name = "label1";
            label1.Size = new Size(57, 15);
            label1.TabIndex = 1;
            label1.Text = "Tìm kiếm";
            // 
            // txtKeyword
            // 
            txtKeyword.Dock = DockStyle.Fill;
            txtKeyword.Location = new Point(117, 3);
            txtKeyword.Name = "txtKeyword";
            txtKeyword.Size = new Size(466, 23);
            txtKeyword.TabIndex = 1;
            txtKeyword.TextChanged += txtKeyword_TextChanged;
            txtKeyword.Leave += txtKeyword_Leave;
            // 
            // txtTitle
            // 
            txtTitle.Dock = DockStyle.Fill;
            txtTitle.Location = new Point(117, 37);
            txtTitle.Name = "txtTitle";
            txtTitle.Size = new Size(466, 23);
            txtTitle.TabIndex = 2;
            // 
            // txtContent
            // 
            txtContent.Location = new Point(117, 156);
            txtContent.Name = "txtContent";
            txtContent.Size = new Size(466, 427);
            txtContent.TabIndex = 5;
            txtContent.Text = "";
            // 
            // txtHook
            // 
            txtHook.Dock = DockStyle.Fill;
            txtHook.Location = new Point(117, 71);
            txtHook.Name = "txtHook";
            txtHook.Size = new Size(466, 23);
            txtHook.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(3, 34);
            label2.Name = "label2";
            label2.Size = new Size(46, 15);
            label2.TabIndex = 6;
            label2.Text = "Tiêu đề";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(3, 68);
            label3.Name = "label3";
            label3.Size = new Size(58, 15);
            label3.TabIndex = 7;
            label3.Text = "Câu hook";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(3, 153);
            label4.Name = "label4";
            label4.Size = new Size(57, 15);
            label4.TabIndex = 8;
            label4.Text = "Nội dung";
            // 
            // btnSave
            // 
            btnSave.Enabled = false;
            btnSave.FlatStyle = FlatStyle.Flat;
            btnSave.Location = new Point(3, 865);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(92, 31);
            btnSave.TabIndex = 6;
            btnSave.Text = "Lưu thay đổi";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // btnCancel
            // 
            btnCancel.Enabled = false;
            btnCancel.FlatStyle = FlatStyle.Flat;
            btnCancel.Location = new Point(117, 865);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(110, 31);
            btnCancel.TabIndex = 7;
            btnCancel.Text = "Hủy bỏ thay đổi";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 19.4539242F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 80.5460739F));
            tableLayoutPanel1.Controls.Add(label5, 0, 3);
            tableLayoutPanel1.Controls.Add(label2, 0, 1);
            tableLayoutPanel1.Controls.Add(txtTitle, 1, 1);
            tableLayoutPanel1.Controls.Add(txtKeyword, 1, 0);
            tableLayoutPanel1.Controls.Add(label1, 0, 0);
            tableLayoutPanel1.Controls.Add(label3, 0, 2);
            tableLayoutPanel1.Controls.Add(txtHook, 1, 2);
            tableLayoutPanel1.Controls.Add(txtContent, 1, 4);
            tableLayoutPanel1.Controls.Add(label4, 0, 4);
            tableLayoutPanel1.Controls.Add(txtHashtag, 1, 3);
            tableLayoutPanel1.Controls.Add(btnPost, 0, 7);
            tableLayoutPanel1.Controls.Add(lblPostStatus, 1, 7);
            tableLayoutPanel1.Controls.Add(btnSave, 0, 6);
            tableLayoutPanel1.Controls.Add(btnCancel, 1, 6);
            tableLayoutPanel1.Controls.Add(label6, 0, 5);
            tableLayoutPanel1.Controls.Add(videoPreviewControl1, 1, 5);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(3, 3);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 8;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 37F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 48F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 437F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 272F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 37F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 135F));
            tableLayoutPanel1.Size = new Size(586, 1035);
            tableLayoutPanel1.TabIndex = 12;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(3, 105);
            label5.Name = "label5";
            label5.Size = new Size(51, 15);
            label5.TabIndex = 12;
            label5.Text = "Hashtag";
            // 
            // txtHashtag
            // 
            txtHashtag.Dock = DockStyle.Fill;
            txtHashtag.Location = new Point(117, 108);
            txtHashtag.Name = "txtHashtag";
            txtHashtag.Size = new Size(466, 42);
            txtHashtag.TabIndex = 13;
            txtHashtag.Text = "";
            // 
            // btnPost
            // 
            btnPost.Enabled = false;
            btnPost.Location = new Point(3, 902);
            btnPost.Name = "btnPost";
            btnPost.Size = new Size(75, 23);
            btnPost.TabIndex = 14;
            btnPost.Text = "Đăng bài";
            btnPost.UseVisualStyleBackColor = true;
            btnPost.Click += btnPost_Click;
            // 
            // lblPostStatus
            // 
            lblPostStatus.AutoSize = true;
            lblPostStatus.Location = new Point(117, 899);
            lblPostStatus.Name = "lblPostStatus";
            lblPostStatus.Size = new Size(38, 15);
            lblPostStatus.TabIndex = 15;
            lblPostStatus.Text = "label6";
            lblPostStatus.Visible = false;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(3, 590);
            label6.Name = "label6";
            label6.Size = new Size(37, 15);
            label6.TabIndex = 16;
            label6.Text = "Video";
            // 
            // videoPreviewControl1
            // 
            videoPreviewControl1.Dock = DockStyle.Fill;
            videoPreviewControl1.Location = new Point(117, 593);
            videoPreviewControl1.Name = "videoPreviewControl1";
            videoPreviewControl1.Size = new Size(466, 266);
            videoPreviewControl1.TabIndex = 17;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 2;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 31.0924377F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 68.90756F));
            tableLayoutPanel2.Controls.Add(dataGridViewPostContent, 1, 0);
            tableLayoutPanel2.Controls.Add(tableLayoutPanel1, 0, 0);
            tableLayoutPanel2.Dock = DockStyle.Fill;
            tableLayoutPanel2.Location = new Point(0, 0);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 1;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.Size = new Size(1904, 1041);
            tableLayoutPanel2.TabIndex = 13;
            // 
            // frmPostManager
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1904, 1041);
            Controls.Add(tableLayoutPanel2);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximumSize = new Size(1920, 1080);
            MinimumSize = new Size(1918, 1030);
            Name = "frmPostManager";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Danh sách bài viết";
            Load += frmPostManager_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridViewPostContent).EndInit();
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            tableLayoutPanel2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataGridViewPostContent;
        private Label label1;
        private TextBox txtKeyword;
        private TextBox txtTitle;
        private RichTextBox txtContent;
        private TextBox txtHook;
        private Label label2;
        private Label label3;
        private Label label4;
        private Button btnSave;
        private Button btnCancel;
        private TableLayoutPanel tableLayoutPanel1;
        private TableLayoutPanel tableLayoutPanel2;
        private Label label5;
        private DataGridViewTextBoxColumn id;
        private DataGridViewTextBoxColumn product_code;
        private DataGridViewTextBoxColumn title;
        private DataGridViewTextBoxColumn content;
        private DataGridViewTextBoxColumn hook;
        private DataGridViewTextBoxColumn hashtag;
        private DataGridViewTextBoxColumn created_at;
        private DataGridViewTextBoxColumn updated_at;
        private RichTextBox txtHashtag;
        private Button btnPost;
        private Label lblPostStatus;
        private Label label6;
        private UserControls.VideoPreviewControl videoPreviewControl1;
    }
}