namespace SellerCenter.Forms
{
    partial class frmProductManager
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmProductManager));
            dataGridView1 = new DataGridView();
            id = new DataGridViewTextBoxColumn();
            product_code = new DataGridViewTextBoxColumn();
            product_name = new DataGridViewTextBoxColumn();
            description = new DataGridViewTextBoxColumn();
            image_url = new DataGridViewTextBoxColumn();
            video_url = new DataGridViewTextBoxColumn();
            created_at = new DataGridViewTextBoxColumn();
            updated_at = new DataGridViewTextBoxColumn();
            label1 = new Label();
            txtKeyword = new TextBox();
            tableLayoutPanel1 = new TableLayoutPanel();
            tableLayoutPanel2 = new TableLayoutPanel();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            tableLayoutPanel1.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { id, product_code, product_name, description, image_url, video_url, created_at, updated_at });
            dataGridView1.Dock = DockStyle.Fill;
            dataGridView1.Location = new Point(3, 3);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.Size = new Size(1874, 960);
            dataGridView1.TabIndex = 0;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // id
            // 
            id.HeaderText = "id";
            id.Name = "id";
            id.ReadOnly = true;
            // 
            // product_code
            // 
            product_code.HeaderText = "Mã sản phẩm";
            product_code.Name = "product_code";
            product_code.ReadOnly = true;
            // 
            // product_name
            // 
            product_name.HeaderText = "Tên sản phẩm";
            product_name.Name = "product_name";
            product_name.ReadOnly = true;
            // 
            // description
            // 
            description.HeaderText = "Mô tả sản phẩm";
            description.Name = "description";
            description.ReadOnly = true;
            // 
            // image_url
            // 
            image_url.HeaderText = "Link image";
            image_url.Name = "image_url";
            image_url.ReadOnly = true;
            // 
            // video_url
            // 
            video_url.HeaderText = "Link video";
            video_url.Name = "video_url";
            video_url.ReadOnly = true;
            // 
            // created_at
            // 
            created_at.HeaderText = "Thời gian tạo";
            created_at.Name = "created_at";
            created_at.ReadOnly = true;
            // 
            // updated_at
            // 
            updated_at.HeaderText = "Thời gian cập nhật";
            updated_at.Name = "updated_at";
            updated_at.ReadOnly = true;
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
            txtKeyword.Location = new Point(76, 3);
            txtKeyword.Name = "txtKeyword";
            txtKeyword.Size = new Size(490, 23);
            txtKeyword.TabIndex = 1;
            txtKeyword.TextChanged += txtKeyword_TextChanged;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 3.88297868F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 96.11702F));
            tableLayoutPanel1.Controls.Add(label1, 0, 0);
            tableLayoutPanel1.Controls.Add(txtKeyword, 1, 0);
            tableLayoutPanel1.Location = new Point(12, 12);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Size = new Size(1880, 45);
            tableLayoutPanel1.TabIndex = 3;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 1;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.Controls.Add(dataGridView1, 0, 0);
            tableLayoutPanel2.Location = new Point(12, 63);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 1;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.Size = new Size(1880, 966);
            tableLayoutPanel2.TabIndex = 4;
            // 
            // frmProductManager
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1904, 1041);
            Controls.Add(tableLayoutPanel2);
            Controls.Add(tableLayoutPanel1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximumSize = new Size(1920, 1080);
            MinimumSize = new Size(1918, 1030);
            Name = "frmProductManager";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Quản lý sản phẩm";
            Load += frmProductManager_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            tableLayoutPanel2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn id;
        private DataGridViewTextBoxColumn product_code;
        private DataGridViewTextBoxColumn product_name;
        private DataGridViewTextBoxColumn description;
        private DataGridViewTextBoxColumn image_url;
        private DataGridViewTextBoxColumn video_url;
        private DataGridViewTextBoxColumn created_at;
        private DataGridViewTextBoxColumn updated_at;
        private Label label1;
        private TextBox txtKeyword;
        private TableLayoutPanel tableLayoutPanel1;
        private TableLayoutPanel tableLayoutPanel2;
    }
}