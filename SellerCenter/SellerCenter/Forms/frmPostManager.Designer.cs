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
            image_url_1 = new DataGridViewTextBoxColumn();
            image_url_2 = new DataGridViewTextBoxColumn();
            image_url_3 = new DataGridViewTextBoxColumn();
            image_url_4 = new DataGridViewTextBoxColumn();
            image_url_5 = new DataGridViewTextBoxColumn();
            video_url = new DataGridViewTextBoxColumn();
            label1 = new Label();
            txtKeyword = new TextBox();
            txtTitle = new TextBox();
            txtContent = new RichTextBox();
            txtHook = new TextBox();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            panel1 = new Panel();
            btnSave = new Button();
            btnCancel = new Button();
            lblNotifyPost = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridViewPostContent).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // dataGridViewPostContent
            // 
            dataGridViewPostContent.AllowUserToAddRows = false;
            dataGridViewPostContent.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewPostContent.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewPostContent.Columns.AddRange(new DataGridViewColumn[] { id, product_code, title, content, hook, hashtag, created_at, updated_at, image_url_1, image_url_2, image_url_3, image_url_4, image_url_5, video_url });
            dataGridViewPostContent.Dock = DockStyle.Bottom;
            dataGridViewPostContent.Location = new Point(0, 362);
            dataGridViewPostContent.Name = "dataGridViewPostContent";
            dataGridViewPostContent.Size = new Size(1904, 679);
            dataGridViewPostContent.TabIndex = 0;
            dataGridViewPostContent.CellContentClick += dataGridViewPostContent_CellContentClick;
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
            // image_url_1
            // 
            image_url_1.HeaderText = "Ảnh 1";
            image_url_1.Name = "image_url_1";
            // 
            // image_url_2
            // 
            image_url_2.HeaderText = "Ảnh 2";
            image_url_2.Name = "image_url_2";
            // 
            // image_url_3
            // 
            image_url_3.HeaderText = "Ảnh 3";
            image_url_3.Name = "image_url_3";
            // 
            // image_url_4
            // 
            image_url_4.HeaderText = "Anh 4";
            image_url_4.Name = "image_url_4";
            // 
            // image_url_5
            // 
            image_url_5.HeaderText = "Ảnh 5";
            image_url_5.Name = "image_url_5";
            // 
            // video_url
            // 
            video_url.HeaderText = "Video";
            video_url.Name = "video_url";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(57, 15);
            label1.TabIndex = 1;
            label1.Text = "Tìm kiếm";
            // 
            // txtKeyword
            // 
            txtKeyword.Location = new Point(12, 27);
            txtKeyword.Name = "txtKeyword";
            txtKeyword.Size = new Size(456, 23);
            txtKeyword.TabIndex = 2;
            txtKeyword.TextChanged += textBox1_TextChanged;
            // 
            // txtTitle
            // 
            txtTitle.Location = new Point(3, 29);
            txtTitle.Name = "txtTitle";
            txtTitle.Size = new Size(1412, 23);
            txtTitle.TabIndex = 3;
            // 
            // txtContent
            // 
            txtContent.Location = new Point(3, 117);
            txtContent.Name = "txtContent";
            txtContent.Size = new Size(1412, 231);
            txtContent.TabIndex = 4;
            txtContent.Text = "";
            // 
            // txtHook
            // 
            txtHook.Location = new Point(3, 73);
            txtHook.Name = "txtHook";
            txtHook.Size = new Size(1412, 23);
            txtHook.TabIndex = 5;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(3, 11);
            label2.Name = "label2";
            label2.Size = new Size(46, 15);
            label2.TabIndex = 6;
            label2.Text = "Tiêu đề";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(3, 55);
            label3.Name = "label3";
            label3.Size = new Size(58, 15);
            label3.TabIndex = 7;
            label3.Text = "Câu hook";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(3, 99);
            label4.Name = "label4";
            label4.Size = new Size(57, 15);
            label4.TabIndex = 8;
            label4.Text = "Nội dung";
            // 
            // panel1
            // 
            panel1.Controls.Add(txtContent);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(txtTitle);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(txtHook);
            panel1.Controls.Add(label2);
            panel1.Location = new Point(474, -2);
            panel1.Name = "panel1";
            panel1.Size = new Size(1418, 351);
            panel1.TabIndex = 9;
            panel1.Visible = false;
            // 
            // btnSave
            // 
            btnSave.FlatStyle = FlatStyle.Flat;
            btnSave.Location = new Point(235, 318);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(108, 31);
            btnSave.TabIndex = 10;
            btnSave.Text = "Lưu thay đổi";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Visible = false;
            btnSave.Click += btnSave_Click;
            // 
            // btnCancel
            // 
            btnCancel.FlatStyle = FlatStyle.Flat;
            btnCancel.Location = new Point(349, 318);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(110, 31);
            btnCancel.TabIndex = 11;
            btnCancel.Text = "Hủy bỏ thay đổi";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Visible = false;
            btnCancel.Click += btnCancel_Click;
            // 
            // lblNotifyPost
            // 
            lblNotifyPost.AutoSize = true;
            lblNotifyPost.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            lblNotifyPost.ForeColor = Color.Red;
            lblNotifyPost.Location = new Point(12, 71);
            lblNotifyPost.Name = "lblNotifyPost";
            lblNotifyPost.Size = new Size(247, 25);
            lblNotifyPost.TabIndex = 12;
            lblNotifyPost.Text = "Đang đăng bài facebook...";
            lblNotifyPost.Visible = false;
            // 
            // frmPostManager
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1904, 1041);
            Controls.Add(lblNotifyPost);
            Controls.Add(btnCancel);
            Controls.Add(btnSave);
            Controls.Add(panel1);
            Controls.Add(txtKeyword);
            Controls.Add(label1);
            Controls.Add(dataGridViewPostContent);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximumSize = new Size(1920, 1080);
            MinimumSize = new Size(1918, 1030);
            Name = "frmPostManager";
            Text = "Danh sách bài viết";
            Load += frmPostManager_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridViewPostContent).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridViewPostContent;
        private Label label1;
        private TextBox txtKeyword;
        private DataGridViewTextBoxColumn id;
        private DataGridViewTextBoxColumn product_code;
        private DataGridViewTextBoxColumn title;
        private DataGridViewTextBoxColumn content;
        private DataGridViewTextBoxColumn hook;
        private DataGridViewTextBoxColumn hashtag;
        private DataGridViewTextBoxColumn created_at;
        private DataGridViewTextBoxColumn updated_at;
        private DataGridViewTextBoxColumn image_url_1;
        private DataGridViewTextBoxColumn image_url_2;
        private DataGridViewTextBoxColumn image_url_3;
        private DataGridViewTextBoxColumn image_url_4;
        private DataGridViewTextBoxColumn image_url_5;
        private DataGridViewTextBoxColumn video_url;
        private TextBox txtTitle;
        private RichTextBox txtContent;
        private TextBox txtHook;
        private Label label2;
        private Label label3;
        private Label label4;
        private Panel panel1;
        private Button btnSave;
        private Button btnCancel;
        private Label lblNotifyPost;
    }
}