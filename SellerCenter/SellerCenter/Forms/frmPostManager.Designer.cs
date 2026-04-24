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
            textBox1 = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dataGridViewPostContent).BeginInit();
            SuspendLayout();
            // 
            // dataGridViewPostContent
            // 
            dataGridViewPostContent.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewPostContent.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewPostContent.Columns.AddRange(new DataGridViewColumn[] { id, product_code, title, content, hook, hashtag, created_at, updated_at });
            dataGridViewPostContent.Dock = DockStyle.Bottom;
            dataGridViewPostContent.Location = new Point(0, 362);
            dataGridViewPostContent.Name = "dataGridViewPostContent";
            dataGridViewPostContent.Size = new Size(1904, 679);
            dataGridViewPostContent.TabIndex = 0;
            dataGridViewPostContent.AllowUserToAddRows = false;
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
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(57, 15);
            label1.TabIndex = 1;
            label1.Text = "Tìm kiếm";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(12, 27);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(456, 23);
            textBox1.TabIndex = 2;
            // 
            // frmPostManager
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1904, 1041);
            Controls.Add(textBox1);
            Controls.Add(label1);
            Controls.Add(dataGridViewPostContent);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximumSize = new Size(1920, 1080);
            MinimumSize = new Size(1918, 1030);
            Name = "frmPostManager";
            Text = "Danh sách bài viết";
            ((System.ComponentModel.ISupportInitialize)dataGridViewPostContent).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridViewPostContent;
        private DataGridViewTextBoxColumn id;
        private DataGridViewTextBoxColumn product_code;
        private DataGridViewTextBoxColumn title;
        private DataGridViewTextBoxColumn content;
        private DataGridViewTextBoxColumn hook;
        private DataGridViewTextBoxColumn hashtag;
        private DataGridViewTextBoxColumn created_at;
        private DataGridViewTextBoxColumn updated_at;
        private Label label1;
        private TextBox textBox1;
    }
}