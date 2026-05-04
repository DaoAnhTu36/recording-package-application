namespace SellerCenter.Forms
{
    partial class frmMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMenu));
            dataGridView1 = new DataGridView();
            tableLayoutPanel1 = new TableLayoutPanel();
            tableLayoutPanel2 = new TableLayoutPanel();
            tableLayoutPanel3 = new TableLayoutPanel();
            btnCancel = new Button();
            label6 = new Label();
            txtIconName = new TextBox();
            label5 = new Label();
            txtFormName = new TextBox();
            label4 = new Label();
            label3 = new Label();
            txtMenuName = new TextBox();
            label1 = new Label();
            txtMenuCode = new TextBox();
            label2 = new Label();
            cbbMenuParent = new ComboBox();
            txtSortOrder = new NumericUpDown();
            btnSave = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            tableLayoutPanel1.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            tableLayoutPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)txtSortOrder).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Dock = DockStyle.Fill;
            dataGridView1.Location = new Point(3, 3);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.Size = new Size(1892, 687);
            dataGridView1.TabIndex = 0;
            dataGridView1.CellClick += dataGridView1_CellClick;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Controls.Add(dataGridView1, 0, 0);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(3, 295);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Size = new Size(1898, 693);
            tableLayoutPanel1.TabIndex = 1;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 1;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.Controls.Add(tableLayoutPanel1, 0, 1);
            tableLayoutPanel2.Controls.Add(tableLayoutPanel3, 0, 0);
            tableLayoutPanel2.Dock = DockStyle.Fill;
            tableLayoutPanel2.Location = new Point(0, 0);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 2;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 29.52953F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 70.4704742F));
            tableLayoutPanel2.Size = new Size(1904, 991);
            tableLayoutPanel2.TabIndex = 2;
            // 
            // tableLayoutPanel3
            // 
            tableLayoutPanel3.ColumnCount = 2;
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 22.64529F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 77.3547058F));
            tableLayoutPanel3.Controls.Add(btnCancel, 1, 6);
            tableLayoutPanel3.Controls.Add(label6, 0, 5);
            tableLayoutPanel3.Controls.Add(txtIconName, 1, 4);
            tableLayoutPanel3.Controls.Add(label5, 0, 4);
            tableLayoutPanel3.Controls.Add(txtFormName, 1, 3);
            tableLayoutPanel3.Controls.Add(label4, 0, 3);
            tableLayoutPanel3.Controls.Add(label3, 0, 2);
            tableLayoutPanel3.Controls.Add(txtMenuName, 1, 1);
            tableLayoutPanel3.Controls.Add(label1, 0, 0);
            tableLayoutPanel3.Controls.Add(txtMenuCode, 1, 0);
            tableLayoutPanel3.Controls.Add(label2, 0, 1);
            tableLayoutPanel3.Controls.Add(cbbMenuParent, 1, 2);
            tableLayoutPanel3.Controls.Add(txtSortOrder, 1, 5);
            tableLayoutPanel3.Controls.Add(btnSave, 0, 6);
            tableLayoutPanel3.Location = new Point(3, 3);
            tableLayoutPanel3.Name = "tableLayoutPanel3";
            tableLayoutPanel3.RowCount = 7;
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Absolute, 33.3333321F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Absolute, 31.6666679F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Absolute, 32F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Absolute, 35F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Absolute, 32F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Absolute, 32F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Absolute, 107F));
            tableLayoutPanel3.Size = new Size(499, 286);
            tableLayoutPanel3.TabIndex = 2;
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(116, 199);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(75, 23);
            btnCancel.TabIndex = 8;
            btnCancel.Text = "Hủy";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(3, 164);
            label6.Name = "label6";
            label6.Size = new Size(59, 15);
            label6.TabIndex = 10;
            label6.Text = "Sort order";
            // 
            // txtIconName
            // 
            txtIconName.Dock = DockStyle.Fill;
            txtIconName.Location = new Point(116, 135);
            txtIconName.Name = "txtIconName";
            txtIconName.Size = new Size(380, 23);
            txtIconName.TabIndex = 5;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(3, 132);
            label5.Name = "label5";
            label5.Size = new Size(63, 15);
            label5.TabIndex = 8;
            label5.Text = "Icon name";
            // 
            // txtFormName
            // 
            txtFormName.Dock = DockStyle.Fill;
            txtFormName.Location = new Point(116, 100);
            txtFormName.Name = "txtFormName";
            txtFormName.Size = new Size(380, 23);
            txtFormName.TabIndex = 4;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(3, 97);
            label4.Name = "label4";
            label4.Size = new Size(49, 15);
            label4.TabIndex = 6;
            label4.Text = "Form ID";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(3, 65);
            label3.Name = "label3";
            label3.Size = new Size(60, 15);
            label3.TabIndex = 4;
            label3.Text = "Menu cha";
            // 
            // txtMenuName
            // 
            txtMenuName.Dock = DockStyle.Fill;
            txtMenuName.Location = new Point(116, 36);
            txtMenuName.Name = "txtMenuName";
            txtMenuName.Size = new Size(380, 23);
            txtMenuName.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(3, 0);
            label1.Name = "label1";
            label1.Size = new Size(58, 15);
            label1.TabIndex = 0;
            label1.Text = "Mã menu";
            // 
            // txtMenuCode
            // 
            txtMenuCode.Dock = DockStyle.Fill;
            txtMenuCode.Location = new Point(116, 3);
            txtMenuCode.Name = "txtMenuCode";
            txtMenuCode.Size = new Size(380, 23);
            txtMenuCode.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(3, 33);
            label2.Name = "label2";
            label2.Size = new Size(60, 15);
            label2.TabIndex = 2;
            label2.Text = "Tên menu";
            // 
            // cbbMenuParent
            // 
            cbbMenuParent.Dock = DockStyle.Fill;
            cbbMenuParent.FormattingEnabled = true;
            cbbMenuParent.Location = new Point(116, 68);
            cbbMenuParent.Name = "cbbMenuParent";
            cbbMenuParent.Size = new Size(380, 23);
            cbbMenuParent.TabIndex = 3;
            // 
            // txtSortOrder
            // 
            txtSortOrder.Dock = DockStyle.Fill;
            txtSortOrder.Location = new Point(116, 167);
            txtSortOrder.Name = "txtSortOrder";
            txtSortOrder.Size = new Size(380, 23);
            txtSortOrder.TabIndex = 6;
            // 
            // btnSave
            // 
            btnSave.Location = new Point(3, 199);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(75, 23);
            btnSave.TabIndex = 7;
            btnSave.Text = "Lưu";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // frmMenu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1904, 991);
            Controls.Add(tableLayoutPanel2);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximumSize = new Size(1920, 1080);
            MinimumSize = new Size(1918, 1030);
            Name = "frmMenu";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Cấu hình menu";
            Load += frmMenu_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel2.ResumeLayout(false);
            tableLayoutPanel3.ResumeLayout(false);
            tableLayoutPanel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)txtSortOrder).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataGridView1;
        private TableLayoutPanel tableLayoutPanel1;
        private TableLayoutPanel tableLayoutPanel2;
        private TableLayoutPanel tableLayoutPanel3;
        private Label label1;
        private TextBox txtMenuCode;
        private Label label5;
        private TextBox txtFormName;
        private Label label4;
        private Label label3;
        private TextBox txtMenuName;
        private Label label2;
        private ComboBox cbbMenuParent;
        private Label label6;
        private TextBox txtIconName;
        private NumericUpDown txtSortOrder;
        private Button btnCancel;
        private Button btnSave;
    }
}