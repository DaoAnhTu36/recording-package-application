namespace SellerCenter.Forms
{
    partial class frmRole
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmRole));
            dataGridView1 = new DataGridView();
            btnSave = new Button();
            tableLayoutPanel1 = new TableLayoutPanel();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            txtRoleCode = new TextBox();
            txtRoleName = new TextBox();
            txtRoleDescription = new RichTextBox();
            btnCancel = new Button();
            label4 = new Label();
            chkStatus = new CheckBox();
            tableLayoutPanel2 = new TableLayoutPanel();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            tableLayoutPanel1.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Dock = DockStyle.Fill;
            dataGridView1.Location = new Point(3, 287);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(1896, 701);
            dataGridView1.TabIndex = 0;
            dataGridView1.CellClick += dataGridView1_CellClick;
            // 
            // btnSave
            // 
            btnSave.Location = new Point(3, 243);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(75, 23);
            btnSave.TabIndex = 1;
            btnSave.Text = "Lưu";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 21.9354839F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 78.0645142F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.Controls.Add(label1, 0, 0);
            tableLayoutPanel1.Controls.Add(label2, 0, 1);
            tableLayoutPanel1.Controls.Add(label3, 0, 2);
            tableLayoutPanel1.Controls.Add(txtRoleCode, 1, 0);
            tableLayoutPanel1.Controls.Add(txtRoleName, 1, 1);
            tableLayoutPanel1.Controls.Add(txtRoleDescription, 1, 2);
            tableLayoutPanel1.Controls.Add(btnSave, 0, 4);
            tableLayoutPanel1.Controls.Add(btnCancel, 1, 4);
            tableLayoutPanel1.Controls.Add(label4, 0, 3);
            tableLayoutPanel1.Controls.Add(chkStatus, 1, 3);
            tableLayoutPanel1.Location = new Point(3, 3);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 5;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 158F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 34F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 34F));
            tableLayoutPanel1.Size = new Size(465, 275);
            tableLayoutPanel1.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(3, 0);
            label1.Name = "label1";
            label1.Size = new Size(69, 15);
            label1.TabIndex = 2;
            label1.Text = "Mã chức vụ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(3, 24);
            label2.Name = "label2";
            label2.Size = new Size(71, 15);
            label2.TabIndex = 3;
            label2.Text = "Tên chức vụ";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(3, 48);
            label3.Name = "label3";
            label3.Size = new Size(38, 15);
            label3.TabIndex = 4;
            label3.Text = "Mô tả";
            // 
            // txtRoleCode
            // 
            txtRoleCode.Dock = DockStyle.Fill;
            txtRoleCode.Location = new Point(105, 3);
            txtRoleCode.Name = "txtRoleCode";
            txtRoleCode.Size = new Size(357, 23);
            txtRoleCode.TabIndex = 5;
            // 
            // txtRoleName
            // 
            txtRoleName.Dock = DockStyle.Fill;
            txtRoleName.Location = new Point(105, 27);
            txtRoleName.Name = "txtRoleName";
            txtRoleName.Size = new Size(357, 23);
            txtRoleName.TabIndex = 6;
            // 
            // txtRoleDescription
            // 
            txtRoleDescription.Dock = DockStyle.Fill;
            txtRoleDescription.Location = new Point(105, 51);
            txtRoleDescription.Name = "txtRoleDescription";
            txtRoleDescription.Size = new Size(357, 152);
            txtRoleDescription.TabIndex = 9;
            txtRoleDescription.Text = "";
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(105, 243);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(75, 23);
            btnCancel.TabIndex = 8;
            btnCancel.Text = "Hủy";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(3, 206);
            label4.Name = "label4";
            label4.Size = new Size(60, 15);
            label4.TabIndex = 10;
            label4.Text = "Trạng thái";
            // 
            // chkStatus
            // 
            chkStatus.AutoSize = true;
            chkStatus.Location = new Point(105, 209);
            chkStatus.Name = "chkStatus";
            chkStatus.Size = new Size(83, 19);
            chkStatus.TabIndex = 11;
            chkStatus.Text = "Hoạt động";
            chkStatus.UseVisualStyleBackColor = true;
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
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 28.65792F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 71.34208F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel2.Size = new Size(1902, 991);
            tableLayoutPanel2.TabIndex = 3;
            // 
            // frmRole
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1902, 991);
            Controls.Add(tableLayoutPanel2);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximumSize = new Size(1920, 1080);
            MinimumSize = new Size(1918, 1030);
            Name = "frmRole";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Chức vụ";
            Load += frmRole_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            tableLayoutPanel2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataGridView1;
        private Button btnSave;
        private TableLayoutPanel tableLayoutPanel1;
        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox txtRoleCode;
        private TextBox txtRoleName;
        private TableLayoutPanel tableLayoutPanel2;
        private Button btnCancel;
        private RichTextBox txtRoleDescription;
        private Label label4;
        private CheckBox chkStatus;
    }
}