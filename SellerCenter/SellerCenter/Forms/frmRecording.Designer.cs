using System.Drawing.Drawing2D;

namespace SellerCenter.Forms
{
    partial class frmRecording
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmRecording));
            pictureBoxCamera = new PictureBox();
            label1 = new Label();
            label2 = new Label();
            lblBarcodeScan = new Label();
            lblRecordStatus = new Label();
            btnStart = new Button();
            btnEnd = new Button();
            btnCheckOrder = new Button();
            historyScanBarcode = new ListBox();
            label3 = new Label();
            btnUploadYoutube = new Button();
            lblStatus = new Label();
            progressBar1 = new ProgressBar();
            ((System.ComponentModel.ISupportInitialize)pictureBoxCamera).BeginInit();
            SuspendLayout();
            // 
            // pictureBoxCamera
            // 
            pictureBoxCamera.Location = new Point(12, 250);
            pictureBoxCamera.Name = "pictureBoxCamera";
            pictureBoxCamera.Size = new Size(900, 779);
            pictureBoxCamera.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBoxCamera.TabIndex = 1;
            pictureBoxCamera.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 11F);
            label1.ForeColor = SystemColors.MenuHighlight;
            label1.Location = new Point(12, 63);
            label1.Name = "label1";
            label1.Size = new Size(97, 20);
            label1.TabIndex = 4;
            label1.Text = "Mã đơn hàng";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 11F);
            label2.ForeColor = SystemColors.MenuHighlight;
            label2.Location = new Point(12, 98);
            label2.Name = "label2";
            label2.Size = new Size(75, 20);
            label2.TabIndex = 5;
            label2.Text = "Trạng thái";
            // 
            // lblBarcodeScan
            // 
            lblBarcodeScan.AutoSize = true;
            lblBarcodeScan.Font = new Font("Segoe UI", 11F);
            lblBarcodeScan.Location = new Point(115, 63);
            lblBarcodeScan.Name = "lblBarcodeScan";
            lblBarcodeScan.Size = new Size(115, 20);
            lblBarcodeScan.TabIndex = 6;
            lblBarcodeScan.Text = "Đang chờ scan...";
            // 
            // lblRecordStatus
            // 
            lblRecordStatus.AutoSize = true;
            lblRecordStatus.Font = new Font("Segoe UI", 11F);
            lblRecordStatus.Location = new Point(115, 98);
            lblRecordStatus.Name = "lblRecordStatus";
            lblRecordStatus.Size = new Size(82, 20);
            lblRecordStatus.TabIndex = 7;
            lblRecordStatus.Text = "Đang chờ...";
            // 
            // btnStart
            // 
            btnStart.BackColor = Color.Bisque;
            btnStart.Enabled = false;
            btnStart.FlatStyle = FlatStyle.Flat;
            btnStart.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            btnStart.Location = new Point(138, 12);
            btnStart.Name = "btnStart";
            btnStart.Size = new Size(93, 38);
            btnStart.TabIndex = 9;
            btnStart.Text = "Bắt đầu";
            btnStart.UseVisualStyleBackColor = false;
            btnStart.Click += btnStart_Click;
            // 
            // btnEnd
            // 
            btnEnd.BackColor = Color.Bisque;
            btnEnd.Enabled = false;
            btnEnd.FlatStyle = FlatStyle.Flat;
            btnEnd.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            btnEnd.Location = new Point(237, 12);
            btnEnd.Name = "btnEnd";
            btnEnd.Size = new Size(93, 38);
            btnEnd.TabIndex = 10;
            btnEnd.Text = "Kết thúc";
            btnEnd.UseVisualStyleBackColor = false;
            btnEnd.Click += btnEnd_Click;
            // 
            // btnCheckOrder
            // 
            btnCheckOrder.BackColor = Color.Bisque;
            btnCheckOrder.FlatStyle = FlatStyle.Flat;
            btnCheckOrder.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            btnCheckOrder.Location = new Point(12, 12);
            btnCheckOrder.Name = "btnCheckOrder";
            btnCheckOrder.Size = new Size(120, 38);
            btnCheckOrder.TabIndex = 11;
            btnCheckOrder.Text = "Kiểm tra đơn";
            btnCheckOrder.UseVisualStyleBackColor = false;
            btnCheckOrder.Click += btnCheckOrder_Click;
            // 
            // historyScanBarcode
            // 
            historyScanBarcode.Font = new Font("Segoe UI", 10F);
            historyScanBarcode.FormattingEnabled = true;
            historyScanBarcode.ItemHeight = 17;
            historyScanBarcode.Location = new Point(469, 42);
            historyScanBarcode.Name = "historyScanBarcode";
            historyScanBarcode.Size = new Size(443, 191);
            historyScanBarcode.TabIndex = 12;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 11F);
            label3.Location = new Point(469, 19);
            label3.Name = "label3";
            label3.Size = new Size(112, 20);
            label3.TabIndex = 13;
            label3.Text = "Lịch sử thao tác";
            // 
            // btnUploadYoutube
            // 
            btnUploadYoutube.BackColor = Color.Red;
            btnUploadYoutube.FlatStyle = FlatStyle.Flat;
            btnUploadYoutube.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnUploadYoutube.ForeColor = SystemColors.ControlLightLight;
            btnUploadYoutube.Location = new Point(12, 137);
            btnUploadYoutube.Name = "btnUploadYoutube";
            btnUploadYoutube.Size = new Size(318, 38);
            btnUploadYoutube.TabIndex = 14;
            btnUploadYoutube.Text = "Tải lên Youtube";
            btnUploadYoutube.UseVisualStyleBackColor = false;
            btnUploadYoutube.Click += btnUploadYoutube_Click;
            // 
            // lblStatus
            // 
            lblStatus.AutoSize = true;
            lblStatus.Font = new Font("Segoe UI", 11F);
            lblStatus.Location = new Point(12, 183);
            lblStatus.Name = "lblStatus";
            lblStatus.Size = new Size(50, 20);
            lblStatus.TabIndex = 15;
            lblStatus.Text = "label4";
            lblStatus.Visible = false;
            // 
            // progressBar1
            // 
            progressBar1.Location = new Point(12, 206);
            progressBar1.Name = "progressBar1";
            progressBar1.Size = new Size(318, 38);
            progressBar1.TabIndex = 16;
            // 
            // frmRecording
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1902, 991);
            Controls.Add(progressBar1);
            Controls.Add(lblStatus);
            Controls.Add(btnUploadYoutube);
            Controls.Add(label3);
            Controls.Add(historyScanBarcode);
            Controls.Add(btnCheckOrder);
            Controls.Add(btnEnd);
            Controls.Add(btnStart);
            Controls.Add(lblRecordStatus);
            Controls.Add(lblBarcodeScan);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(pictureBoxCamera);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximumSize = new Size(1920, 1080);
            MinimumSize = new Size(1918, 1030);
            Name = "frmRecording";
            Text = "Quay video đóng gói hàng";
            ((System.ComponentModel.ISupportInitialize)pictureBoxCamera).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private PictureBox pictureBoxCamera;
        private Label label1;
        private Label label2;
        private Label lblBarcodeScan;
        private Label lblRecordStatus;
        private Button btnStart;
        private Button btnEnd;
        private Button btnCheckOrder;
        private ListBox historyScanBarcode;
        private Label label3;
        private Button btnUploadYoutube;
        private Label lblStatus;
        private ProgressBar progressBar1;
    }
}