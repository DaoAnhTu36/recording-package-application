namespace SellerCenter.Forms
{
    partial class frmPermission
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPermission));
            tableLayoutPanel1 = new TableLayoutPanel();
            tableLayoutPanel2 = new TableLayoutPanel();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            txtPermissionCode = new TextBox();
            txtPermissionName = new TextBox();
            txtDescription = new RichTextBox();
            btnSave = new Button();
            btnCancel = new Button();
            dataGridView1 = new DataGridView();
            tableLayoutPanel1.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Controls.Add(tableLayoutPanel2, 0, 0);
            tableLayoutPanel1.Controls.Add(dataGridView1, 0, 1);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 2;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 22.1997986F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 77.8002F));
            tableLayoutPanel1.Size = new Size(1902, 991);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 2;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 21.462265F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 78.537735F));
            tableLayoutPanel2.Controls.Add(label1, 0, 0);
            tableLayoutPanel2.Controls.Add(label2, 0, 1);
            tableLayoutPanel2.Controls.Add(label3, 0, 2);
            tableLayoutPanel2.Controls.Add(txtPermissionCode, 1, 0);
            tableLayoutPanel2.Controls.Add(txtPermissionName, 1, 1);
            tableLayoutPanel2.Controls.Add(txtDescription, 1, 2);
            tableLayoutPanel2.Controls.Add(btnSave, 0, 3);
            tableLayoutPanel2.Controls.Add(btnCancel, 1, 3);
            tableLayoutPanel2.Location = new Point(3, 3);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 4;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 105F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 38F));
            tableLayoutPanel2.Size = new Size(424, 214);
            tableLayoutPanel2.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(3, 0);
            label1.Name = "label1";
            label1.Size = new Size(60, 15);
            label1.TabIndex = 0;
            label1.Text = "Mã quyền";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(3, 35);
            label2.Name = "label2";
            label2.Size = new Size(62, 15);
            label2.TabIndex = 1;
            label2.Text = "Tên quyền";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(3, 70);
            label3.Name = "label3";
            label3.Size = new Size(38, 15);
            label3.TabIndex = 2;
            label3.Text = "Mô tả";
            // 
            // txtPermissionCode
            // 
            txtPermissionCode.Dock = DockStyle.Fill;
            txtPermissionCode.Location = new Point(94, 3);
            txtPermissionCode.Name = "txtPermissionCode";
            txtPermissionCode.Size = new Size(327, 23);
            txtPermissionCode.TabIndex = 3;
            // 
            // txtPermissionName
            // 
            txtPermissionName.Dock = DockStyle.Fill;
            txtPermissionName.Location = new Point(94, 38);
            txtPermissionName.Name = "txtPermissionName";
            txtPermissionName.Size = new Size(327, 23);
            txtPermissionName.TabIndex = 4;
            // 
            // txtDescription
            // 
            txtDescription.Dock = DockStyle.Fill;
            txtDescription.Location = new Point(94, 73);
            txtDescription.Name = "txtDescription";
            txtDescription.Size = new Size(327, 99);
            txtDescription.TabIndex = 5;
            txtDescription.Text = "";
            // 
            // btnSave
            // 
            btnSave.Location = new Point(3, 178);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(75, 23);
            btnSave.TabIndex = 6;
            btnSave.Text = "Lưu";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(94, 178);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(75, 23);
            btnCancel.TabIndex = 7;
            btnCancel.Text = "Hủy";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(3, 223);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(240, 150);
            dataGridView1.TabIndex = 0;
            dataGridView1.CellClick += dataGridView1_CellClick;
            // 
            // frmPermission
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1902, 991);
            Controls.Add(tableLayoutPanel1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximumSize = new Size(1920, 1080);
            MinimumSize = new Size(1918, 1030);
            Name = "frmPermission";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "frmPermission";
            Load += frmPermission_Load;
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel2.ResumeLayout(false);
            tableLayoutPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private DataGridView dataGridView1;
        private TableLayoutPanel tableLayoutPanel2;
        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox txtPermissionCode;
        private TextBox txtPermissionName;
        private RichTextBox txtDescription;
        private Button btnSave;
        private Button btnCancel;
    }
}