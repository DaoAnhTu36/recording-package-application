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
            txtFullName = new TextBox();
            label6 = new Label();
            formInfo = new TableLayoutPanel();
            tableLayoutPanel2 = new TableLayoutPanel();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            formInfo.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(3, 0);
            label1.Name = "label1";
            label1.Size = new Size(65, 15);
            label1.TabIndex = 0;
            label1.Text = "User Name";
            // 
            // txtUsername
            // 
            txtUsername.Dock = DockStyle.Fill;
            txtUsername.Location = new Point(132, 3);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(419, 23);
            txtUsername.TabIndex = 1;
            // 
            // txtEmail
            // 
            txtEmail.Dock = DockStyle.Fill;
            txtEmail.Location = new Point(132, 93);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(419, 23);
            txtEmail.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(3, 90);
            label2.Name = "label2";
            label2.Size = new Size(36, 15);
            label2.TabIndex = 2;
            label2.Text = "Email";
            // 
            // txtPassword
            // 
            txtPassword.Dock = DockStyle.Fill;
            txtPassword.Location = new Point(132, 137);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(419, 23);
            txtPassword.TabIndex = 4;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(3, 134);
            label3.Name = "label3";
            label3.Size = new Size(57, 15);
            label3.TabIndex = 4;
            label3.Text = "Password";
            label3.Click += label3_Click;
            // 
            // txtPhone
            // 
            txtPhone.Dock = DockStyle.Fill;
            txtPhone.Location = new Point(132, 177);
            txtPhone.Name = "txtPhone";
            txtPhone.Size = new Size(419, 23);
            txtPhone.TabIndex = 5;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(3, 174);
            label4.Name = "label4";
            label4.Size = new Size(41, 15);
            label4.TabIndex = 6;
            label4.Text = "Phone";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(3, 209);
            label5.Name = "label5";
            label5.Size = new Size(30, 15);
            label5.TabIndex = 8;
            label5.Text = "Role";
            // 
            // cbbRole
            // 
            cbbRole.Dock = DockStyle.Fill;
            cbbRole.FormattingEnabled = true;
            cbbRole.Location = new Point(132, 212);
            cbbRole.Name = "cbbRole";
            cbbRole.Size = new Size(419, 23);
            cbbRole.TabIndex = 6;
            // 
            // btnSave
            // 
            btnSave.FlatStyle = FlatStyle.Flat;
            btnSave.Location = new Point(3, 239);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(75, 20);
            btnSave.TabIndex = 7;
            btnSave.Text = "Lưu";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.FlatStyle = FlatStyle.Flat;
            btnUpdate.Location = new Point(132, 239);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(75, 20);
            btnUpdate.TabIndex = 8;
            btnUpdate.Text = "Cập nhật";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Visible = false;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.Location = new Point(3, 290);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(1896, 617);
            dataGridView1.TabIndex = 12;
            // 
            // txtFullName
            // 
            txtFullName.Dock = DockStyle.Fill;
            txtFullName.Location = new Point(132, 48);
            txtFullName.Name = "txtFullName";
            txtFullName.Size = new Size(419, 23);
            txtFullName.TabIndex = 2;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(3, 45);
            label6.Name = "label6";
            label6.Size = new Size(61, 15);
            label6.TabIndex = 13;
            label6.Text = "Full Name";
            // 
            // formInfo
            // 
            formInfo.ColumnCount = 2;
            formInfo.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 23.2851982F));
            formInfo.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 76.7148F));
            formInfo.Controls.Add(label1, 0, 0);
            formInfo.Controls.Add(txtFullName, 1, 1);
            formInfo.Controls.Add(btnSave, 0, 6);
            formInfo.Controls.Add(btnUpdate, 1, 6);
            formInfo.Controls.Add(txtUsername, 1, 0);
            formInfo.Controls.Add(label6, 0, 1);
            formInfo.Controls.Add(label5, 0, 5);
            formInfo.Controls.Add(cbbRole, 1, 5);
            formInfo.Controls.Add(label4, 0, 4);
            formInfo.Controls.Add(label2, 0, 2);
            formInfo.Controls.Add(txtEmail, 1, 2);
            formInfo.Controls.Add(txtPhone, 1, 4);
            formInfo.Controls.Add(label3, 0, 3);
            formInfo.Controls.Add(txtPassword, 1, 3);
            formInfo.Location = new Point(3, 3);
            formInfo.Name = "formInfo";
            formInfo.RowCount = 7;
            formInfo.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            formInfo.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            formInfo.RowStyles.Add(new RowStyle(SizeType.Absolute, 44F));
            formInfo.RowStyles.Add(new RowStyle(SizeType.Absolute, 40F));
            formInfo.RowStyles.Add(new RowStyle(SizeType.Absolute, 35F));
            formInfo.RowStyles.Add(new RowStyle(SizeType.Absolute, 27F));
            formInfo.RowStyles.Add(new RowStyle(SizeType.Absolute, 26F));
            formInfo.Size = new Size(554, 262);
            formInfo.TabIndex = 15;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 1;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.Controls.Add(formInfo, 0, 0);
            tableLayoutPanel2.Controls.Add(dataGridView1, 0, 1);
            tableLayoutPanel2.Dock = DockStyle.Fill;
            tableLayoutPanel2.Location = new Point(0, 0);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 2;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 28.75883F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 71.24117F));
            tableLayoutPanel2.Size = new Size(1910, 999);
            tableLayoutPanel2.TabIndex = 16;
            // 
            // frmEmployeeManager
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1910, 999);
            Controls.Add(tableLayoutPanel2);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximumSize = new Size(1920, 1080);
            MinimumSize = new Size(1918, 1030);
            Name = "frmEmployeeManager";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Quản lý nhân viên";
            Load += frmEmployeeManager_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            formInfo.ResumeLayout(false);
            formInfo.PerformLayout();
            tableLayoutPanel2.ResumeLayout(false);
            ResumeLayout(false);
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
        private TextBox txtFullName;
        private Label label6;
        private TableLayoutPanel formInfo;
        private TableLayoutPanel tableLayoutPanel2;
    }
}