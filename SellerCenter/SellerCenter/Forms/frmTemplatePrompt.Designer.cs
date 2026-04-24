namespace SellerCenter.Forms
{
    partial class frmTemplatePrompt
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmTemplatePrompt));
            btnSave = new Button();
            socialMediaPlatformControl1 = new SellerCenter.UserControls.SocialMediaPlatformControl();
            label1 = new Label();
            label2 = new Label();
            articleTypeControl1 = new SellerCenter.UserControls.ArticleTypeControl();
            tableLayoutPanel1 = new TableLayoutPanel();
            txtTemplateDesc = new RichTextBox();
            dataGridViewListTemplate = new DataGridView();
            btnCancel = new Button();
            id = new DataGridViewTextBoxColumn();
            title = new DataGridViewTextBoxColumn();
            platform = new DataGridViewTextBoxColumn();
            post_type = new DataGridViewTextBoxColumn();
            template_content = new DataGridViewTextBoxColumn();
            is_active = new DataGridViewTextBoxColumn();
            created_at = new DataGridViewTextBoxColumn();
            updated_at = new DataGridViewTextBoxColumn();
            tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewListTemplate).BeginInit();
            SuspendLayout();
            // 
            // btnSave
            // 
            btnSave.FlatStyle = FlatStyle.Flat;
            btnSave.Location = new Point(12, 146);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(95, 38);
            btnSave.TabIndex = 1;
            btnSave.Text = "Lưu template";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // socialMediaPlatformControl1
            // 
            socialMediaPlatformControl1.AutoScroll = true;
            socialMediaPlatformControl1.Location = new Point(12, 38);
            socialMediaPlatformControl1.Name = "socialMediaPlatformControl1";
            socialMediaPlatformControl1.Size = new Size(121, 83);
            socialMediaPlatformControl1.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 20);
            label1.Name = "label1";
            label1.Size = new Size(124, 15);
            label1.TabIndex = 3;
            label1.Text = "Nền tảng mạng xã hội";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(168, 20);
            label2.Name = "label2";
            label2.Size = new Size(70, 15);
            label2.TabIndex = 4;
            label2.Text = "Loại bài viết";
            // 
            // articleTypeControl1
            // 
            articleTypeControl1.AutoScroll = true;
            articleTypeControl1.Location = new Point(168, 38);
            articleTypeControl1.Name = "articleTypeControl1";
            articleTypeControl1.Size = new Size(82, 83);
            articleTypeControl1.TabIndex = 5;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Controls.Add(txtTemplateDesc, 0, 0);
            tableLayoutPanel1.Controls.Add(dataGridViewListTemplate, 1, 0);
            tableLayoutPanel1.Dock = DockStyle.Bottom;
            tableLayoutPanel1.Location = new Point(0, 190);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Size = new Size(1902, 801);
            tableLayoutPanel1.TabIndex = 6;
            // 
            // txtTemplateDesc
            // 
            txtTemplateDesc.Dock = DockStyle.Fill;
            txtTemplateDesc.Location = new Point(3, 3);
            txtTemplateDesc.Name = "txtTemplateDesc";
            txtTemplateDesc.Size = new Size(945, 795);
            txtTemplateDesc.TabIndex = 0;
            txtTemplateDesc.Text = "";
            // 
            // dataGridViewListTemplate
            // 
            dataGridViewListTemplate.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewListTemplate.Columns.AddRange(new DataGridViewColumn[] { id, title, platform, post_type, template_content, is_active, created_at, updated_at });
            dataGridViewListTemplate.Dock = DockStyle.Fill;
            dataGridViewListTemplate.Location = new Point(954, 3);
            dataGridViewListTemplate.Name = "dataGridViewListTemplate";
            dataGridViewListTemplate.ReadOnly = true;
            dataGridViewListTemplate.Size = new Size(945, 795);
            dataGridViewListTemplate.TabIndex = 1;
            dataGridViewListTemplate.CellContentClick += dataGridViewListTemplate_CellContentClick;
            dataGridViewListTemplate.AllowUserToAddRows = false;
            // 
            // btnCancel
            // 
            btnCancel.BackColor = Color.Red;
            btnCancel.FlatStyle = FlatStyle.Flat;
            btnCancel.ForeColor = SystemColors.ControlLightLight;
            btnCancel.Location = new Point(143, 146);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(95, 38);
            btnCancel.TabIndex = 7;
            btnCancel.Text = "Hủy thay đổi";
            btnCancel.UseVisualStyleBackColor = false;
            btnCancel.Click += btnCancel_Click;
            // 
            // id
            // 
            id.HeaderText = "id";
            id.Name = "id";
            id.ReadOnly = true;
            // 
            // title
            // 
            title.HeaderText = "Tiêu đề";
            title.Name = "title";
            title.ReadOnly = true;
            // 
            // platform
            // 
            platform.HeaderText = "Nền tảng";
            platform.Name = "platform";
            platform.ReadOnly = true;
            // 
            // post_type
            // 
            post_type.HeaderText = "Loại bài viết";
            post_type.Name = "post_type";
            post_type.ReadOnly = true;
            // 
            // template_content
            // 
            template_content.HeaderText = "Nội dung";
            template_content.Name = "template_content";
            template_content.ReadOnly = true;
            // 
            // is_active
            // 
            is_active.HeaderText = "Trạng thái";
            is_active.Name = "is_active";
            is_active.ReadOnly = true;
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
            // frmTemplatePrompt
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1902, 991);
            Controls.Add(btnCancel);
            Controls.Add(tableLayoutPanel1);
            Controls.Add(articleTypeControl1);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(socialMediaPlatformControl1);
            Controls.Add(btnSave);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximumSize = new Size(1920, 1080);
            MinimumSize = new Size(1918, 1030);
            Name = "frmTemplatePrompt";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Template prompt AI";
            Load += frmTemplatePrompt_Load;
            tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridViewListTemplate).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button btnSave;
        private UserControls.SocialMediaPlatformControl socialMediaPlatformControl1;
        private Label label1;
        private Label label2;
        private UserControls.ArticleTypeControl articleTypeControl1;
        private TableLayoutPanel tableLayoutPanel1;
        private RichTextBox txtTemplateDesc;
        private DataGridView dataGridViewListTemplate;
        private Button btnCancel;
        private DataGridViewTextBoxColumn id;
        private DataGridViewTextBoxColumn title;
        private DataGridViewTextBoxColumn platform;
        private DataGridViewTextBoxColumn post_type;
        private DataGridViewTextBoxColumn template_content;
        private DataGridViewTextBoxColumn is_active;
        private DataGridViewTextBoxColumn created_at;
        private DataGridViewTextBoxColumn updated_at;
    }
}