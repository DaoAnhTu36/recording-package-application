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
            txtTemplateDesc = new RichTextBox();
            dataGridViewListTemplate = new DataGridView();
            btnCancel = new Button();
            tableLayoutPanel2 = new TableLayoutPanel();
            tableLayoutPanel3 = new TableLayoutPanel();
            tableLayoutPanel1 = new TableLayoutPanel();
            ((System.ComponentModel.ISupportInitialize)dataGridViewListTemplate).BeginInit();
            tableLayoutPanel2.SuspendLayout();
            tableLayoutPanel3.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // btnSave
            // 
            btnSave.FlatStyle = FlatStyle.Flat;
            btnSave.Location = new Point(3, 149);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(95, 33);
            btnSave.TabIndex = 4;
            btnSave.Text = "Lưu template";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // socialMediaPlatformControl1
            // 
            socialMediaPlatformControl1.AutoScroll = true;
            socialMediaPlatformControl1.Location = new Point(159, 3);
            socialMediaPlatformControl1.Name = "socialMediaPlatformControl1";
            socialMediaPlatformControl1.Size = new Size(112, 76);
            socialMediaPlatformControl1.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(3, 0);
            label1.Name = "label1";
            label1.Size = new Size(124, 15);
            label1.TabIndex = 3;
            label1.Text = "Nền tảng mạng xã hội";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(3, 82);
            label2.Name = "label2";
            label2.Size = new Size(70, 15);
            label2.TabIndex = 4;
            label2.Text = "Loại bài viết";
            // 
            // articleTypeControl1
            // 
            articleTypeControl1.AutoScroll = true;
            articleTypeControl1.Location = new Point(159, 85);
            articleTypeControl1.Name = "articleTypeControl1";
            articleTypeControl1.Size = new Size(82, 58);
            articleTypeControl1.TabIndex = 2;
            // 
            // txtTemplateDesc
            // 
            txtTemplateDesc.Dock = DockStyle.Fill;
            txtTemplateDesc.Location = new Point(287, 3);
            txtTemplateDesc.Name = "txtTemplateDesc";
            txtTemplateDesc.Size = new Size(1606, 483);
            txtTemplateDesc.TabIndex = 3;
            txtTemplateDesc.Text = "";
            // 
            // dataGridViewListTemplate
            // 
            dataGridViewListTemplate.Dock = DockStyle.Fill;
            dataGridViewListTemplate.Location = new Point(3, 502);
            dataGridViewListTemplate.Name = "dataGridViewListTemplate";
            dataGridViewListTemplate.ReadOnly = true;
            dataGridViewListTemplate.Size = new Size(1904, 494);
            dataGridViewListTemplate.TabIndex = 1;
            dataGridViewListTemplate.Click += dataGridViewListTemplate_Click;
            // 
            // btnCancel
            // 
            btnCancel.BackColor = SystemColors.Control;
            btnCancel.FlatStyle = FlatStyle.Flat;
            btnCancel.ForeColor = SystemColors.ActiveCaptionText;
            btnCancel.Location = new Point(159, 149);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(95, 33);
            btnCancel.TabIndex = 5;
            btnCancel.Text = "Hủy thay đổi";
            btnCancel.UseVisualStyleBackColor = false;
            btnCancel.Click += btnCancel_Click;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 2;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 57.03125F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 42.96875F));
            tableLayoutPanel2.Controls.Add(label1, 0, 0);
            tableLayoutPanel2.Controls.Add(articleTypeControl1, 1, 1);
            tableLayoutPanel2.Controls.Add(label2, 0, 1);
            tableLayoutPanel2.Controls.Add(socialMediaPlatformControl1, 1, 0);
            tableLayoutPanel2.Controls.Add(btnSave, 0, 2);
            tableLayoutPanel2.Controls.Add(btnCancel, 1, 2);
            tableLayoutPanel2.Location = new Point(3, 3);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 3;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 55.90062F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 44.09938F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 336F));
            tableLayoutPanel2.Size = new Size(274, 483);
            tableLayoutPanel2.TabIndex = 8;
            // 
            // tableLayoutPanel3
            // 
            tableLayoutPanel3.ColumnCount = 1;
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel3.Controls.Add(tableLayoutPanel1, 0, 0);
            tableLayoutPanel3.Controls.Add(dataGridViewListTemplate, 0, 1);
            tableLayoutPanel3.Dock = DockStyle.Fill;
            tableLayoutPanel3.Location = new Point(0, 0);
            tableLayoutPanel3.Name = "tableLayoutPanel3";
            tableLayoutPanel3.RowCount = 2;
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel3.Size = new Size(1910, 999);
            tableLayoutPanel3.TabIndex = 9;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 14.9789028F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 85.0210953F));
            tableLayoutPanel1.Controls.Add(txtTemplateDesc, 1, 0);
            tableLayoutPanel1.Controls.Add(tableLayoutPanel2, 0, 0);
            tableLayoutPanel1.Location = new Point(3, 3);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Size = new Size(1896, 489);
            tableLayoutPanel1.TabIndex = 10;
            // 
            // frmTemplatePrompt
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1910, 999);
            Controls.Add(tableLayoutPanel3);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximumSize = new Size(1920, 1080);
            MinimumSize = new Size(1918, 1030);
            Name = "frmTemplatePrompt";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Template prompt AI";
            Load += frmTemplatePrompt_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridViewListTemplate).EndInit();
            tableLayoutPanel2.ResumeLayout(false);
            tableLayoutPanel2.PerformLayout();
            tableLayoutPanel3.ResumeLayout(false);
            tableLayoutPanel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private Button btnSave;
        private UserControls.SocialMediaPlatformControl socialMediaPlatformControl1;
        private Label label1;
        private Label label2;
        private UserControls.ArticleTypeControl articleTypeControl1;
        private RichTextBox txtTemplateDesc;
        private DataGridView dataGridViewListTemplate;
        private Button btnCancel;
        private TableLayoutPanel tableLayoutPanel2;
        private TableLayoutPanel tableLayoutPanel3;
        private TableLayoutPanel tableLayoutPanel1;
    }
}