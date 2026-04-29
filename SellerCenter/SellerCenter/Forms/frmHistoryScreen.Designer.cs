namespace SellerCenter.Forms
{
    partial class frmHistoryScreen
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmHistoryScreen));
            label2 = new Label();
            label3 = new Label();
            fromDate = new DateTimePicker();
            toDate = new DateTimePicker();
            label4 = new Label();
            txtBarcode = new TextBox();
            listRecord = new DataGridView();
            btnSearch = new Button();
            btnReset = new Button();
            axWindowsMediaPlayer1 = new AxWMPLib.AxWindowsMediaPlayer();
            tableLayoutPanel1 = new TableLayoutPanel();
            tableLayoutPanel2 = new TableLayoutPanel();
            tableLayoutPanel3 = new TableLayoutPanel();
            ((System.ComponentModel.ISupportInitialize)listRecord).BeginInit();
            ((System.ComponentModel.ISupportInitialize)axWindowsMediaPlayer1).BeginInit();
            tableLayoutPanel1.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            tableLayoutPanel3.SuspendLayout();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F);
            label2.Location = new Point(3, 41);
            label2.Name = "label2";
            label2.Size = new Size(65, 21);
            label2.TabIndex = 1;
            label2.Text = "Từ ngày";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F);
            label3.Location = new Point(3, 82);
            label3.Name = "label3";
            label3.Size = new Size(76, 21);
            label3.TabIndex = 2;
            label3.Text = "Đến ngày";
            // 
            // fromDate
            // 
            fromDate.Cursor = Cursors.Hand;
            fromDate.Dock = DockStyle.Fill;
            fromDate.Font = new Font("Segoe UI", 13F);
            fromDate.Location = new Point(125, 44);
            fromDate.Name = "fromDate";
            fromDate.Size = new Size(319, 31);
            fromDate.TabIndex = 2;
            // 
            // toDate
            // 
            toDate.Cursor = Cursors.Hand;
            toDate.Dock = DockStyle.Fill;
            toDate.Font = new Font("Segoe UI", 13F);
            toDate.Location = new Point(125, 85);
            toDate.Name = "toDate";
            toDate.Size = new Size(319, 31);
            toDate.TabIndex = 3;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F);
            label4.Location = new Point(3, 0);
            label4.Name = "label4";
            label4.Size = new Size(103, 21);
            label4.TabIndex = 5;
            label4.Text = "Mã đơn hàng";
            // 
            // txtBarcode
            // 
            txtBarcode.BorderStyle = BorderStyle.FixedSingle;
            txtBarcode.Cursor = Cursors.Hand;
            txtBarcode.Dock = DockStyle.Fill;
            txtBarcode.Font = new Font("Segoe UI", 13F);
            txtBarcode.Location = new Point(125, 3);
            txtBarcode.Name = "txtBarcode";
            txtBarcode.Size = new Size(319, 31);
            txtBarcode.TabIndex = 1;
            txtBarcode.WordWrap = false;
            txtBarcode.TextChanged += txtBarcode_TextChanged;
            // 
            // listRecord
            // 
            listRecord.AllowUserToAddRows = false;
            listRecord.Dock = DockStyle.Fill;
            listRecord.Location = new Point(3, 523);
            listRecord.Name = "listRecord";
            listRecord.ReadOnly = true;
            listRecord.Size = new Size(1898, 515);
            listRecord.TabIndex = 7;
            // 
            // btnSearch
            // 
            btnSearch.BackColor = SystemColors.Control;
            btnSearch.FlatStyle = FlatStyle.Flat;
            btnSearch.Font = new Font("Segoe UI", 13F);
            btnSearch.ForeColor = SystemColors.ControlText;
            btnSearch.Location = new Point(3, 125);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(94, 36);
            btnSearch.TabIndex = 4;
            btnSearch.Text = "Tìm kiếm";
            btnSearch.UseVisualStyleBackColor = false;
            btnSearch.Click += btnSearch_Click;
            // 
            // btnReset
            // 
            btnReset.BackColor = SystemColors.Control;
            btnReset.FlatStyle = FlatStyle.Flat;
            btnReset.Font = new Font("Segoe UI", 13F);
            btnReset.ForeColor = SystemColors.ControlText;
            btnReset.Location = new Point(125, 125);
            btnReset.Name = "btnReset";
            btnReset.Size = new Size(94, 36);
            btnReset.TabIndex = 5;
            btnReset.Text = "Đặt lại";
            btnReset.UseVisualStyleBackColor = false;
            // 
            // axWindowsMediaPlayer1
            // 
            axWindowsMediaPlayer1.Dock = DockStyle.Fill;
            axWindowsMediaPlayer1.Enabled = true;
            axWindowsMediaPlayer1.Location = new Point(456, 3);
            axWindowsMediaPlayer1.Name = "axWindowsMediaPlayer1";
            axWindowsMediaPlayer1.OcxState = (AxHost.State)resources.GetObject("axWindowsMediaPlayer1.OcxState");
            axWindowsMediaPlayer1.Size = new Size(1439, 508);
            axWindowsMediaPlayer1.TabIndex = 10;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 27.2930641F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 72.70693F));
            tableLayoutPanel1.Controls.Add(label4, 0, 0);
            tableLayoutPanel1.Controls.Add(txtBarcode, 1, 0);
            tableLayoutPanel1.Controls.Add(btnReset, 1, 3);
            tableLayoutPanel1.Controls.Add(label2, 0, 1);
            tableLayoutPanel1.Controls.Add(btnSearch, 0, 3);
            tableLayoutPanel1.Controls.Add(fromDate, 1, 1);
            tableLayoutPanel1.Controls.Add(label3, 0, 2);
            tableLayoutPanel1.Controls.Add(toDate, 1, 2);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(3, 3);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 4;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 40F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 385F));
            tableLayoutPanel1.Size = new Size(447, 508);
            tableLayoutPanel1.TabIndex = 11;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 2;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 23.86723F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 76.1327744F));
            tableLayoutPanel2.Controls.Add(tableLayoutPanel1, 0, 0);
            tableLayoutPanel2.Controls.Add(axWindowsMediaPlayer1, 1, 0);
            tableLayoutPanel2.Dock = DockStyle.Fill;
            tableLayoutPanel2.Location = new Point(3, 3);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 1;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.Size = new Size(1898, 514);
            tableLayoutPanel2.TabIndex = 0;
            // 
            // tableLayoutPanel3
            // 
            tableLayoutPanel3.ColumnCount = 1;
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel3.Controls.Add(tableLayoutPanel2, 0, 0);
            tableLayoutPanel3.Controls.Add(listRecord, 0, 1);
            tableLayoutPanel3.Dock = DockStyle.Fill;
            tableLayoutPanel3.Location = new Point(0, 0);
            tableLayoutPanel3.Name = "tableLayoutPanel3";
            tableLayoutPanel3.RowCount = 2;
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel3.Size = new Size(1904, 1041);
            tableLayoutPanel3.TabIndex = 0;
            // 
            // frmHistoryScreen
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1904, 1041);
            Controls.Add(tableLayoutPanel3);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximumSize = new Size(1920, 1080);
            MinimumSize = new Size(1918, 1030);
            Name = "frmHistoryScreen";
            Text = "Lịch sử video";
            Load += frmHistoryScreen_Load;
            ((System.ComponentModel.ISupportInitialize)listRecord).EndInit();
            ((System.ComponentModel.ISupportInitialize)axWindowsMediaPlayer1).EndInit();
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            tableLayoutPanel2.ResumeLayout(false);
            tableLayoutPanel3.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private Label label2;
        private Label label3;
        private DateTimePicker fromDate;
        private DateTimePicker toDate;
        private Label label4;
        private TextBox txtBarcode;
        private DataGridView listRecord;
        private Button btnSearch;
        private Button btnReset;
        private AxWMPLib.AxWindowsMediaPlayer axWindowsMediaPlayer1;
        private TableLayoutPanel tableLayoutPanel1;
        private TableLayoutPanel tableLayoutPanel2;
        private TableLayoutPanel tableLayoutPanel3;
    }
}