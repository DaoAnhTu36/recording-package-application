namespace SellerCenter.Forms
{
    partial class frmFacebookAppPermission
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmFacebookAppPermission));
            label1 = new Label();
            cbbAppId = new ComboBox();
            label2 = new Label();
            txtPermissionName = new TextBox();
            btnSave = new Button();
            btnUpdate = new Button();
            dataGridView1 = new DataGridView();
            id = new DataGridViewTextBoxColumn();
            app_id = new DataGridViewTextBoxColumn();
            app_name = new DataGridViewTextBoxColumn();
            permission_name = new DataGridViewTextBoxColumn();
            created_at = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(60, 15);
            label1.TabIndex = 0;
            label1.Text = "Ứng dụng";
            // 
            // cbbAppId
            // 
            cbbAppId.FormattingEnabled = true;
            cbbAppId.Location = new Point(12, 27);
            cbbAppId.Name = "cbbAppId";
            cbbAppId.Size = new Size(245, 23);
            cbbAppId.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 53);
            label2.Name = "label2";
            label2.Size = new Size(88, 15);
            label2.TabIndex = 2;
            label2.Text = "Quyền truy cập";
            // 
            // txtPermissionName
            // 
            txtPermissionName.Location = new Point(12, 71);
            txtPermissionName.Name = "txtPermissionName";
            txtPermissionName.Size = new Size(245, 23);
            txtPermissionName.TabIndex = 3;
            // 
            // btnSave
            // 
            btnSave.FlatStyle = FlatStyle.Flat;
            btnSave.Location = new Point(12, 100);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(75, 29);
            btnSave.TabIndex = 4;
            btnSave.Text = "Lưu";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.FlatStyle = FlatStyle.Flat;
            btnUpdate.Location = new Point(182, 100);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(75, 29);
            btnUpdate.TabIndex = 5;
            btnUpdate.Text = "Cập nhật";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Visible = false;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.ClipboardCopyMode = DataGridViewClipboardCopyMode.Disable;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { id, app_id, app_name, permission_name, created_at });
            dataGridView1.Dock = DockStyle.Bottom;
            dataGridView1.Location = new Point(0, 194);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(1902, 797);
            dataGridView1.TabIndex = 6;
            // 
            // id
            // 
            id.HeaderText = "Mã quyền";
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
            // permission_name
            // 
            permission_name.HeaderText = "Tên quyền";
            permission_name.Name = "permission_name";
            // 
            // created_at
            // 
            created_at.HeaderText = "Thời gian tạo";
            created_at.Name = "created_at";
            // 
            // frmFacebookAppPermission
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1902, 991);
            Controls.Add(dataGridView1);
            Controls.Add(btnUpdate);
            Controls.Add(btnSave);
            Controls.Add(txtPermissionName);
            Controls.Add(label2);
            Controls.Add(cbbAppId);
            Controls.Add(label1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximumSize = new Size(1920, 1080);
            MinimumSize = new Size(1918, 1030);
            Name = "frmFacebookAppPermission";
            Text = "Quyền truy cập facebook";
            Load += frmFacebookAppPermission_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private ComboBox cbbAppId;
        private Label label2;
        private TextBox txtPermissionName;
        private Button btnSave;
        private Button btnUpdate;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn id;
        private DataGridViewTextBoxColumn app_id;
        private DataGridViewTextBoxColumn app_name;
        private DataGridViewTextBoxColumn permission_name;
        private DataGridViewTextBoxColumn created_at;
    }
}