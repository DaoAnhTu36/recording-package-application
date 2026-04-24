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
            label1 = new Label();
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
            ((System.ComponentModel.ISupportInitialize)listRecord).BeginInit();
            ((System.ComponentModel.ISupportInitialize)axWindowsMediaPlayer1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(10, 9);
            label1.Name = "label1";
            label1.Size = new Size(237, 25);
            label1.TabIndex = 0;
            label1.Text = "Tìm kiếm video sản phẩm";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F);
            label2.Location = new Point(10, 111);
            label2.Name = "label2";
            label2.Size = new Size(65, 21);
            label2.TabIndex = 1;
            label2.Text = "Từ ngày";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F);
            label3.Location = new Point(10, 180);
            label3.Name = "label3";
            label3.Size = new Size(76, 21);
            label3.TabIndex = 2;
            label3.Text = "Đến ngày";
            // 
            // fromDate
            // 
            fromDate.Cursor = Cursors.Hand;
            fromDate.Font = new Font("Segoe UI", 13F);
            fromDate.Location = new Point(10, 135);
            fromDate.Name = "fromDate";
            fromDate.Size = new Size(285, 31);
            fromDate.TabIndex = 3;
            // 
            // toDate
            // 
            toDate.Cursor = Cursors.Hand;
            toDate.Font = new Font("Segoe UI", 13F);
            toDate.Location = new Point(10, 204);
            toDate.Name = "toDate";
            toDate.Size = new Size(285, 31);
            toDate.TabIndex = 4;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F);
            label4.Location = new Point(10, 45);
            label4.Name = "label4";
            label4.Size = new Size(103, 21);
            label4.TabIndex = 5;
            label4.Text = "Mã đơn hàng";
            // 
            // txtBarcode
            // 
            txtBarcode.BorderStyle = BorderStyle.FixedSingle;
            txtBarcode.Cursor = Cursors.Hand;
            txtBarcode.Font = new Font("Segoe UI", 13F);
            txtBarcode.Location = new Point(12, 69);
            txtBarcode.Name = "txtBarcode";
            txtBarcode.PlaceholderText = "Mã đơn hàng";
            txtBarcode.Size = new Size(283, 31);
            txtBarcode.TabIndex = 6;
            txtBarcode.WordWrap = false;
            txtBarcode.TextChanged += txtBarcode_TextChanged;
            // 
            // listRecord
            // 
            listRecord.Dock = DockStyle.Bottom;
            listRecord.Location = new Point(0, 657);
            listRecord.Name = "listRecord";
            listRecord.ReadOnly = true;
            listRecord.Size = new Size(1904, 384);
            listRecord.TabIndex = 7;
            // 
            // btnSearch
            // 
            btnSearch.BackColor = Color.DodgerBlue;
            btnSearch.FlatStyle = FlatStyle.Flat;
            btnSearch.Font = new Font("Segoe UI", 13F);
            btnSearch.ForeColor = SystemColors.ControlLightLight;
            btnSearch.Location = new Point(10, 255);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(136, 36);
            btnSearch.TabIndex = 8;
            btnSearch.Text = "Tìm kiếm";
            btnSearch.UseVisualStyleBackColor = false;
            btnSearch.Click += btnSearch_Click;
            // 
            // btnReset
            // 
            btnReset.BackColor = Color.Red;
            btnReset.FlatStyle = FlatStyle.Flat;
            btnReset.Font = new Font("Segoe UI", 13F);
            btnReset.ForeColor = SystemColors.ControlLightLight;
            btnReset.Location = new Point(159, 255);
            btnReset.Name = "btnReset";
            btnReset.Size = new Size(136, 36);
            btnReset.TabIndex = 9;
            btnReset.Text = "Đặt lại";
            btnReset.UseVisualStyleBackColor = false;
            // 
            // axWindowsMediaPlayer1
            // 
            axWindowsMediaPlayer1.Dock = DockStyle.Right;
            axWindowsMediaPlayer1.Enabled = true;
            axWindowsMediaPlayer1.Location = new Point(1003, 0);
            axWindowsMediaPlayer1.Name = "axWindowsMediaPlayer1";
            axWindowsMediaPlayer1.OcxState = (AxHost.State)resources.GetObject("axWindowsMediaPlayer1.OcxState");
            axWindowsMediaPlayer1.Size = new Size(901, 657);
            axWindowsMediaPlayer1.TabIndex = 10;
            // 
            // frmHistoryScreen
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1904, 1041);
            Controls.Add(axWindowsMediaPlayer1);
            Controls.Add(btnReset);
            Controls.Add(btnSearch);
            Controls.Add(listRecord);
            Controls.Add(txtBarcode);
            Controls.Add(label4);
            Controls.Add(toDate);
            Controls.Add(fromDate);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximumSize = new Size(1920, 1080);
            MinimumSize = new Size(1918, 1030);
            Name = "frmHistoryScreen";
            Text = "Lịch sử video";
            Load += frmHistoryScreen_Load;
            ((System.ComponentModel.ISupportInitialize)listRecord).EndInit();
            ((System.ComponentModel.ISupportInitialize)axWindowsMediaPlayer1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
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
    }
}