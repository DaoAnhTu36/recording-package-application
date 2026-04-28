namespace SellerCenter.Forms
{
    partial class frmEmployeeManager
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmEmployeeManager));
            label1 = new Label();
            txtUsername = new TextBox();
            txtEmail = new TextBox();
            label2 = new Label();
            txtPassword = new TextBox();
            label3 = new Label();
            txtPhone = new TextBox();
            label4 = new Label();
            label5 = new Label();
            cbbRole = new ComboBox();
            btnSave = new Button();
            btnUpdate = new Button();
            dataGridView1 = new DataGridView();
            id = new DataGridViewTextBoxColumn();
            username = new DataGridViewTextBoxColumn();
            Email = new DataGridViewTextBoxColumn();
            full_name = new DataGridViewTextBoxColumn();
            phone = new DataGridViewTextBoxColumn();
            role = new DataGridViewTextBoxColumn();
            is_active = new DataGridViewTextBoxColumn();
            txtFullName = new TextBox();
            label6 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(65, 15);
            label1.TabIndex = 0;
            label1.Text = "User Name";
            // 
            // txtUsername
            // 
            txtUsername.Location = new Point(12, 27);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(264, 23);
            txtUsername.TabIndex = 1;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(12, 115);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(264, 23);
            txtEmail.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 97);
            label2.Name = "label2";
            label2.Size = new Size(36, 15);
            label2.TabIndex = 2;
            label2.Text = "Email";
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(12, 159);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(264, 23);
            txtPassword.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 141);
            label3.Name = "label3";
            label3.Size = new Size(57, 15);
            label3.TabIndex = 4;
            label3.Text = "Password";
            label3.Click += label3_Click;
            // 
            // txtPhone
            // 
            txtPhone.Location = new Point(12, 203);
            txtPhone.Name = "txtPhone";
            txtPhone.Size = new Size(264, 23);
            txtPhone.TabIndex = 7;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(12, 185);
            label4.Name = "label4";
            label4.Size = new Size(41, 15);
            label4.TabIndex = 6;
            label4.Text = "Phone";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(12, 229);
            label5.Name = "label5";
            label5.Size = new Size(30, 15);
            label5.TabIndex = 8;
            label5.Text = "Role";
            // 
            // cbbRole
            // 
            cbbRole.FormattingEnabled = true;
            cbbRole.Location = new Point(12, 247);
            cbbRole.Name = "cbbRole";
            cbbRole.Size = new Size(264, 23);
            cbbRole.TabIndex = 9;
            // 
            // btnSave
            // 
            btnSave.FlatStyle = FlatStyle.Flat;
            btnSave.Location = new Point(12, 276);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(75, 33);
            btnSave.TabIndex = 10;
            btnSave.Text = "Lưu";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.FlatStyle = FlatStyle.Flat;
            btnUpdate.Location = new Point(201, 276);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(75, 33);
            btnUpdate.TabIndex = 11;
            btnUpdate.Text = "Cập nhật";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.ClipboardCopyMode = DataGridViewClipboardCopyMode.Disable;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { id, username, Email, full_name, phone, role, is_active });
            dataGridView1.Dock = DockStyle.Bottom;
            dataGridView1.Location = new Point(0, 374);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            dataGridView1.Size = new Size(1902, 617);
            dataGridView1.TabIndex = 12;
            // 
            // id
            // 
            id.HeaderText = "ID";
            id.Name = "id";
            // 
            // username
            // 
            username.HeaderText = "Username";
            username.Name = "username";
            // 
            // Email
            // 
            Email.HeaderText = "Email";
            Email.Name = "Email";
            // 
            // full_name
            // 
            full_name.HeaderText = "Full name";
            full_name.Name = "full_name";
            // 
            // phone
            // 
            phone.HeaderText = "Phone";
            phone.Name = "phone";
            // 
            // role
            // 
            role.HeaderText = "Role";
            role.Name = "role";
            // 
            // is_active
            // 
            is_active.HeaderText = "Active";
            is_active.Name = "is_active";
            // 
            // txtFullName
            // 
            txtFullName.Location = new Point(12, 71);
            txtFullName.Name = "txtFullName";
            txtFullName.Size = new Size(264, 23);
            txtFullName.TabIndex = 14;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(12, 53);
            label6.Name = "label6";
            label6.Size = new Size(61, 15);
            label6.TabIndex = 13;
            label6.Text = "Full Name";
            // 
            // frmEmployeeManager
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1902, 991);
            Controls.Add(txtFullName);
            Controls.Add(label6);
            Controls.Add(dataGridView1);
            Controls.Add(btnUpdate);
            Controls.Add(btnSave);
            Controls.Add(cbbRole);
            Controls.Add(label5);
            Controls.Add(txtPhone);
            Controls.Add(label4);
            Controls.Add(txtPassword);
            Controls.Add(label3);
            Controls.Add(txtEmail);
            Controls.Add(label2);
            Controls.Add(txtUsername);
            Controls.Add(label1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximumSize = new Size(1920, 1080);
            MinimumSize = new Size(1918, 1030);
            Name = "frmEmployeeManager";
            Text = "Quản lý nhân viên";
            Load += frmEmployeeManager_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtUsername;
        private TextBox txtEmail;
        private Label label2;
        private TextBox txtPassword;
        private Label label3;
        private TextBox txtPhone;
        private Label label4;
        private Label label5;
        private ComboBox cbbRole;
        private Button btnSave;
        private Button btnUpdate;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn id;
        private DataGridViewTextBoxColumn username;
        private DataGridViewTextBoxColumn Email;
        private DataGridViewTextBoxColumn full_name;
        private DataGridViewTextBoxColumn phone;
        private DataGridViewTextBoxColumn role;
        private DataGridViewTextBoxColumn is_active;
        private TextBox txtFullName;
        private Label label6;
    }
}