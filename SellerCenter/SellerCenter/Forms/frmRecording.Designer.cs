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
            btnStart = new Button();
            btnEnd = new Button();
            historyScanBarcode = new ListBox();
            btnUploadYoutube = new Button();
            lblStatus = new Label();
            progressBar1 = new ProgressBar();
            tableLayoutPanel1 = new TableLayoutPanel();
            btnCheckOrder = new Button();
            label2 = new Label();
            lblBarcodeScan = new Label();
            lblRecordStatus = new Label();
            tableLayoutPanel2 = new TableLayoutPanel();
            tableLayoutPanel3 = new TableLayoutPanel();
            ((System.ComponentModel.ISupportInitialize)pictureBoxCamera).BeginInit();
            tableLayoutPanel1.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            tableLayoutPanel3.SuspendLayout();
            SuspendLayout();
            // 
            // pictureBoxCamera
            // 
            pictureBoxCamera.Dock = DockStyle.Fill;
            pictureBoxCamera.Location = new Point(3, 230);
            pictureBoxCamera.Name = "pictureBoxCamera";
            pictureBoxCamera.Size = new Size(1896, 758);
            pictureBoxCamera.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBoxCamera.TabIndex = 1;
            pictureBoxCamera.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 11F);
            label1.ForeColor = SystemColors.InactiveCaptionText;
            label1.Location = new Point(150, 0);
            label1.Name = "label1";
            label1.Size = new Size(97, 20);
            label1.TabIndex = 4;
            label1.Text = "Mã đơn hàng";
            // 
            // btnStart
            // 
            btnStart.BackColor = SystemColors.ControlLightLight;
            btnStart.Dock = DockStyle.Fill;
            btnStart.Enabled = false;
            btnStart.Font = new Font("Microsoft Sans Serif", 8.25F);
            btnStart.ForeColor = SystemColors.ActiveCaptionText;
            btnStart.Location = new Point(3, 46);
            btnStart.Name = "btnStart";
            btnStart.Size = new Size(141, 44);
            btnStart.TabIndex = 2;
            btnStart.Text = "Bắt đầu";
            btnStart.UseVisualStyleBackColor = false;
            btnStart.Click += btnStart_Click;
            // 
            // btnEnd
            // 
            btnEnd.BackColor = SystemColors.ControlLightLight;
            btnEnd.Dock = DockStyle.Fill;
            btnEnd.Enabled = false;
            btnEnd.Font = new Font("Microsoft Sans Serif", 8.25F);
            btnEnd.ForeColor = SystemColors.ActiveCaptionText;
            btnEnd.Location = new Point(3, 96);
            btnEnd.Name = "btnEnd";
            btnEnd.Size = new Size(141, 37);
            btnEnd.TabIndex = 3;
            btnEnd.Text = "Kết thúc";
            btnEnd.UseVisualStyleBackColor = false;
            btnEnd.Click += btnEnd_Click;
            // 
            // historyScanBarcode
            // 
            historyScanBarcode.Dock = DockStyle.Fill;
            historyScanBarcode.Font = new Font("Segoe UI", 10F);
            historyScanBarcode.FormattingEnabled = true;
            historyScanBarcode.ItemHeight = 17;
            historyScanBarcode.Location = new Point(583, 3);
            historyScanBarcode.Name = "historyScanBarcode";
            historyScanBarcode.Size = new Size(1310, 183);
            historyScanBarcode.TabIndex = 12;
            // 
            // btnUploadYoutube
            // 
            btnUploadYoutube.BackColor = SystemColors.ControlLightLight;
            btnUploadYoutube.Dock = DockStyle.Fill;
            btnUploadYoutube.Enabled = false;
            btnUploadYoutube.Font = new Font("Microsoft Sans Serif", 8.25F);
            btnUploadYoutube.ForeColor = SystemColors.ActiveCaptionText;
            btnUploadYoutube.Location = new Point(3, 139);
            btnUploadYoutube.Name = "btnUploadYoutube";
            btnUploadYoutube.Size = new Size(141, 41);
            btnUploadYoutube.TabIndex = 4;
            btnUploadYoutube.Text = "Tải lên Youtube";
            btnUploadYoutube.UseVisualStyleBackColor = false;
            btnUploadYoutube.Click += btnUploadYoutube_Click;
            // 
            // lblStatus
            // 
            lblStatus.AutoSize = true;
            lblStatus.Font = new Font("Segoe UI", 11F);
            lblStatus.Location = new Point(150, 136);
            lblStatus.Name = "lblStatus";
            lblStatus.Size = new Size(50, 20);
            lblStatus.TabIndex = 15;
            lblStatus.Text = "label4";
            lblStatus.Visible = false;
            // 
            // progressBar1
            // 
            progressBar1.Dock = DockStyle.Fill;
            progressBar1.Location = new Point(309, 139);
            progressBar1.Name = "progressBar1";
            progressBar1.Size = new Size(262, 41);
            progressBar1.TabIndex = 16;
            progressBar1.Visible = false;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 3;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 48.0769234F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 51.9230766F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 267F));
            tableLayoutPanel1.Controls.Add(btnCheckOrder, 0, 0);
            tableLayoutPanel1.Controls.Add(lblStatus, 1, 3);
            tableLayoutPanel1.Controls.Add(btnStart, 0, 1);
            tableLayoutPanel1.Controls.Add(btnEnd, 0, 2);
            tableLayoutPanel1.Controls.Add(btnUploadYoutube, 0, 3);
            tableLayoutPanel1.Controls.Add(label1, 1, 0);
            tableLayoutPanel1.Controls.Add(label2, 1, 1);
            tableLayoutPanel1.Controls.Add(lblBarcodeScan, 2, 0);
            tableLayoutPanel1.Controls.Add(lblRecordStatus, 2, 1);
            tableLayoutPanel1.Controls.Add(progressBar1, 2, 3);
            tableLayoutPanel1.Dock = DockStyle.Top;
            tableLayoutPanel1.Location = new Point(3, 3);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 4;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 46.5116272F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 53.4883728F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 43F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 46F));
            tableLayoutPanel1.Size = new Size(574, 183);
            tableLayoutPanel1.TabIndex = 17;
            // 
            // btnCheckOrder
            // 
            btnCheckOrder.BackColor = SystemColors.ControlLightLight;
            btnCheckOrder.Dock = DockStyle.Fill;
            btnCheckOrder.Enabled = false;
            btnCheckOrder.Font = new Font("Microsoft Sans Serif", 8.25F);
            btnCheckOrder.ForeColor = SystemColors.ActiveCaptionText;
            btnCheckOrder.Location = new Point(3, 3);
            btnCheckOrder.Name = "btnCheckOrder";
            btnCheckOrder.Size = new Size(141, 37);
            btnCheckOrder.TabIndex = 1;
            btnCheckOrder.Text = "Kiểm tra đơn";
            btnCheckOrder.UseVisualStyleBackColor = false;
            btnCheckOrder.Click += btnCheckOrder_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 11F);
            label2.ForeColor = SystemColors.InfoText;
            label2.Location = new Point(150, 43);
            label2.Name = "label2";
            label2.Size = new Size(75, 20);
            label2.TabIndex = 5;
            label2.Text = "Trạng thái";
            // 
            // lblBarcodeScan
            // 
            lblBarcodeScan.AutoSize = true;
            lblBarcodeScan.Font = new Font("Segoe UI", 11F);
            lblBarcodeScan.Location = new Point(309, 0);
            lblBarcodeScan.Name = "lblBarcodeScan";
            lblBarcodeScan.Size = new Size(115, 20);
            lblBarcodeScan.TabIndex = 6;
            lblBarcodeScan.Text = "Đang chờ scan...";
            // 
            // lblRecordStatus
            // 
            lblRecordStatus.AutoSize = true;
            lblRecordStatus.Font = new Font("Segoe UI", 11F);
            lblRecordStatus.Location = new Point(309, 43);
            lblRecordStatus.Name = "lblRecordStatus";
            lblRecordStatus.Size = new Size(82, 20);
            lblRecordStatus.TabIndex = 7;
            lblRecordStatus.Text = "Đang chờ...";
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 2;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 1316F));
            tableLayoutPanel2.Controls.Add(historyScanBarcode, 1, 0);
            tableLayoutPanel2.Controls.Add(tableLayoutPanel1, 0, 0);
            tableLayoutPanel2.Location = new Point(3, 3);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 1;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.Size = new Size(1896, 189);
            tableLayoutPanel2.TabIndex = 18;
            // 
            // tableLayoutPanel3
            // 
            tableLayoutPanel3.ColumnCount = 1;
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel3.Controls.Add(tableLayoutPanel2, 0, 0);
            tableLayoutPanel3.Controls.Add(pictureBoxCamera, 0, 1);
            tableLayoutPanel3.Dock = DockStyle.Fill;
            tableLayoutPanel3.Location = new Point(0, 0);
            tableLayoutPanel3.Name = "tableLayoutPanel3";
            tableLayoutPanel3.RowCount = 2;
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 22.9061546F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 77.09384F));
            tableLayoutPanel3.Size = new Size(1902, 991);
            tableLayoutPanel3.TabIndex = 19;
            // 
            // frmRecording
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1902, 991);
            Controls.Add(tableLayoutPanel3);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximumSize = new Size(1920, 1080);
            MinimumSize = new Size(1918, 1030);
            Name = "frmRecording";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Quay video đóng gói hàng";
            Load += frmRecording_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBoxCamera).EndInit();
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            tableLayoutPanel2.ResumeLayout(false);
            tableLayoutPanel3.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private PictureBox pictureBoxCamera;
        private Label label1;
        private Button btnStart;
        private Button btnEnd;
        private ListBox historyScanBarcode;
        private Button btnUploadYoutube;
        private Label lblStatus;
        private ProgressBar progressBar1;
        private TableLayoutPanel tableLayoutPanel1;
        private TableLayoutPanel tableLayoutPanel2;
        private TableLayoutPanel tableLayoutPanel3;
        private Button btnCheckOrder;
        private Label label2;
        private Label lblBarcodeScan;
        private Label lblRecordStatus;
    }
}