namespace SellerCenter.Forms
{
    partial class frmFacebookAppManager
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmFacebookAppManager));
            label1 = new Label();
            txtAppName = new TextBox();
            txtAppId = new TextBox();
            label2 = new Label();
            btnSave = new Button();
            btnUpdate = new Button();
            dataGridView1 = new DataGridView();
            id = new DataGridViewTextBoxColumn();
            app_id = new DataGridViewTextBoxColumn();
            app_name = new DataGridViewTextBoxColumn();
            app_secret = new DataGridViewTextBoxColumn();
            is_active = new DataGridViewTextBoxColumn();
            tableLayoutPanel1 = new TableLayoutPanel();
            tableLayoutPanel2 = new TableLayoutPanel();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            tableLayoutPanel1.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(3, 0);
            label1.Name = "label1";
            label1.Size = new Size(81, 15);
            label1.TabIndex = 0;
            label1.Text = "Tên ứng dụng";
            // 
            // txtAppName
            // 
            txtAppName.Dock = DockStyle.Fill;
            txtAppName.Location = new Point(111, 3);
            txtAppName.Name = "txtAppName";
            txtAppName.Size = new Size(405, 23);
            txtAppName.TabIndex = 1;
            // 
            // txtAppId
            // 
            txtAppId.Dock = DockStyle.Fill;
            txtAppId.Location = new Point(111, 49);
            txtAppId.Name = "txtAppId";
            txtAppId.Size = new Size(405, 23);
            txtAppId.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(3, 46);
            label2.Name = "label2";
            label2.Size = new Size(79, 15);
            label2.TabIndex = 2;
            label2.Text = "Mã ứng dụng";
            // 
            // btnSave
            // 
            btnSave.FlatStyle = FlatStyle.Flat;
            btnSave.Location = new Point(3, 95);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(75, 31);
            btnSave.TabIndex = 4;
            btnSave.Text = "Lưu";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.FlatStyle = FlatStyle.Flat;
            btnUpdate.Location = new Point(111, 95);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(75, 31);
            btnUpdate.TabIndex = 5;
            btnUpdate.Text = "Cập nhật";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Visible = false;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { id, app_id, app_name, app_secret, is_active });
            dataGridView1.Location = new Point(3, 157);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            dataGridView1.Size = new Size(1896, 822);
            dataGridView1.TabIndex = 6;
            // 
            // id
            // 
            id.HeaderText = "ID";
            id.Name = "id";
            // 
            // app_id
            // 
            app_id.HeaderText = "Mã ứng dụng";
            app_id.Name = "app_id";
            // 
            // app_name
            // 
            app_name.HeaderText = "Tên ứng dụng";
            app_name.Name = "app_name";
            // 
            // app_secret
            // 
            app_secret.HeaderText = "Mã bảo mật";
            app_secret.Name = "app_secret";
            // 
            // is_active
            // 
            is_active.HeaderText = "Trạng thái";
            is_active.Name = "is_active";
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20.809248F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 79.19075F));
            tableLayoutPanel1.Controls.Add(label1, 0, 0);
            tableLayoutPanel1.Controls.Add(txtAppName, 1, 0);
            tableLayoutPanel1.Controls.Add(label2, 0, 1);
            tableLayoutPanel1.Controls.Add(btnSave, 0, 2);
            tableLayoutPanel1.Controls.Add(btnUpdate, 1, 2);
            tableLayoutPanel1.Controls.Add(txtAppId, 1, 1);
            tableLayoutPanel1.Location = new Point(3, 3);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 3;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 39F));
            tableLayoutPanel1.Size = new Size(519, 132);
            tableLayoutPanel1.TabIndex = 7;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 1;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.Controls.Add(dataGridView1, 0, 1);
            tableLayoutPanel2.Controls.Add(tableLayoutPanel1, 0, 0);
            tableLayoutPanel2.Dock = DockStyle.Fill;
            tableLayoutPanel2.Location = new Point(0, 0);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 2;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 15.5398588F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 84.460144F));
            tableLayoutPanel2.Size = new Size(1902, 991);
            tableLayoutPanel2.TabIndex = 8;
            // 
            // frmFacebookAppManager
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1902, 991);
            Controls.Add(tableLayoutPanel2);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximumSize = new Size(1920, 1080);
            MinimumSize = new Size(1918, 1030);
            Name = "frmFacebookAppManager";
            Text = "Danh sách ứng dụng facebook";
            Load += frmFacebookAppManager_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            tableLayoutPanel2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private TextBox txtAppName;
        private TextBox txtAppId;
        private Label label2;
        private Button btnSave;
        private Button btnUpdate;
        private DataGridView dataGridView1;
        private TableLayoutPanel tableLayoutPanel1;
        private TableLayoutPanel tableLayoutPanel2;
        private DataGridViewTextBoxColumn id;
        private DataGridViewTextBoxColumn app_id;
        private DataGridViewTextBoxColumn app_name;
        private DataGridViewTextBoxColumn app_secret;
        private DataGridViewTextBoxColumn is_active;
    }
}