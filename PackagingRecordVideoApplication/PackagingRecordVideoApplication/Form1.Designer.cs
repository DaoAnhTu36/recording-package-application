namespace PackagingRecordVideoApplication
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            pictureBoxCamera = new PictureBox();
            label1 = new Label();
            label2 = new Label();
            lblBarcodeScan = new Label();
            lblRecordStatus = new Label();
            dgvFileVideo = new DataGridView();
            btnStart = new Button();
            btnEnd = new Button();
            btnCheckOrder = new Button();
            historyScanBarcode = new ListBox();
            ((System.ComponentModel.ISupportInitialize)pictureBoxCamera).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvFileVideo).BeginInit();
            SuspendLayout();
            // 
            // pictureBoxCamera
            // 
            pictureBoxCamera.Location = new Point(12, 215);
            pictureBoxCamera.Name = "pictureBoxCamera";
            pictureBoxCamera.Size = new Size(900, 814);
            pictureBoxCamera.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBoxCamera.TabIndex = 1;
            pictureBoxCamera.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 11F);
            label1.Location = new Point(12, 53);
            label1.Name = "label1";
            label1.Size = new Size(97, 20);
            label1.TabIndex = 4;
            label1.Text = "Mã đơn hàng";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 11F);
            label2.Location = new Point(12, 88);
            label2.Name = "label2";
            label2.Size = new Size(75, 20);
            label2.TabIndex = 5;
            label2.Text = "Trạng thái";
            // 
            // lblBarcodeScan
            // 
            lblBarcodeScan.AutoSize = true;
            lblBarcodeScan.Font = new Font("Segoe UI", 11F);
            lblBarcodeScan.Location = new Point(115, 53);
            lblBarcodeScan.Name = "lblBarcodeScan";
            lblBarcodeScan.Size = new Size(115, 20);
            lblBarcodeScan.TabIndex = 6;
            lblBarcodeScan.Text = "Đang chờ scan...";
            // 
            // lblRecordStatus
            // 
            lblRecordStatus.AutoSize = true;
            lblRecordStatus.Font = new Font("Segoe UI", 11F);
            lblRecordStatus.Location = new Point(115, 88);
            lblRecordStatus.Name = "lblRecordStatus";
            lblRecordStatus.Size = new Size(82, 20);
            lblRecordStatus.TabIndex = 7;
            lblRecordStatus.Text = "Đang chờ...";
            // 
            // dgvFileVideo
            // 
            dgvFileVideo.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvFileVideo.Location = new Point(918, 215);
            dgvFileVideo.Name = "dgvFileVideo";
            dgvFileVideo.Size = new Size(900, 814);
            dgvFileVideo.TabIndex = 8;
            // 
            // btnStart
            // 
            btnStart.BackColor = SystemColors.AppWorkspace;
            btnStart.Enabled = false;
            btnStart.FlatStyle = FlatStyle.Flat;
            btnStart.Location = new Point(12, 125);
            btnStart.Name = "btnStart";
            btnStart.Size = new Size(75, 23);
            btnStart.TabIndex = 9;
            btnStart.Text = "Bắt đầu";
            btnStart.UseVisualStyleBackColor = false;
            btnStart.Click += btnStart_Click;
            // 
            // btnEnd
            // 
            btnEnd.BackColor = SystemColors.AppWorkspace;
            btnEnd.Enabled = false;
            btnEnd.FlatStyle = FlatStyle.Flat;
            btnEnd.Location = new Point(93, 125);
            btnEnd.Name = "btnEnd";
            btnEnd.Size = new Size(75, 23);
            btnEnd.TabIndex = 10;
            btnEnd.Text = "Kết thúc";
            btnEnd.UseVisualStyleBackColor = false;
            btnEnd.Click += btnEnd_Click;
            // 
            // btnCheckOrder
            // 
            btnCheckOrder.BackColor = SystemColors.AppWorkspace;
            btnCheckOrder.FlatStyle = FlatStyle.Flat;
            btnCheckOrder.Location = new Point(12, 12);
            btnCheckOrder.Name = "btnCheckOrder";
            btnCheckOrder.Size = new Size(156, 23);
            btnCheckOrder.TabIndex = 11;
            btnCheckOrder.Text = "Kiểm tra đơn";
            btnCheckOrder.UseVisualStyleBackColor = false;
            btnCheckOrder.Click += btnCheckOrder_Click;
            // 
            // historyScanBarcode
            // 
            historyScanBarcode.FormattingEnabled = true;
            historyScanBarcode.Location = new Point(472, 14);
            historyScanBarcode.Name = "historyScanBarcode";
            historyScanBarcode.Size = new Size(440, 184);
            historyScanBarcode.TabIndex = 12;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1904, 1041);
            Controls.Add(historyScanBarcode);
            Controls.Add(btnCheckOrder);
            Controls.Add(btnEnd);
            Controls.Add(btnStart);
            Controls.Add(dgvFileVideo);
            Controls.Add(lblRecordStatus);
            Controls.Add(lblBarcodeScan);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(pictureBoxCamera);
            Name = "Form1";
            Text = "Phần mềm quay video đóng gói hàng";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBoxCamera).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvFileVideo).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private PictureBox pictureBoxCamera;
        private Label label1;
        private Label label2;
        private Label lblBarcodeScan;
        private Label lblRecordStatus;
        private DataGridView dgvFileVideo;
        private Button btnStart;
        private Button btnEnd;
        private Button btnCheckOrder;
        private ListBox historyScanBarcode;
    }
}
