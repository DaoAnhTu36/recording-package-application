namespace SellerCenter.Forms
{
    partial class frmCreateNewProduct
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCreateNewProduct));
            label1 = new Label();
            txtProductName = new TextBox();
            label2 = new Label();
            txtProductDesc = new RichTextBox();
            btnChooseImage = new Button();
            btnSave = new Button();
            btnChooseVideo = new Button();
            imageList1 = new ImageList(components);
            txtProductCode = new TextBox();
            label3 = new Label();
            multiImagePreviewControl1 = new SellerCenter.UserControls.MultiImagePreviewControl();
            videoPreviewControl1 = new SellerCenter.UserControls.VideoPreviewControl();
            tableLayoutPanel1 = new TableLayoutPanel();
            tableLayoutPanel2 = new TableLayoutPanel();
            btnCancel = new Button();
            tableLayoutPanel1.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(3, 50);
            label1.Name = "label1";
            label1.Size = new Size(81, 15);
            label1.TabIndex = 0;
            label1.Text = "Tên sản phẩm";
            // 
            // txtProductName
            // 
            txtProductName.Dock = DockStyle.Fill;
            txtProductName.Location = new Point(121, 53);
            txtProductName.Name = "txtProductName";
            txtProductName.Size = new Size(394, 23);
            txtProductName.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(3, 0);
            label2.Name = "label2";
            label2.Size = new Size(93, 15);
            label2.TabIndex = 2;
            label2.Text = "Mô tả sản phẩm";
            // 
            // txtProductDesc
            // 
            txtProductDesc.Dock = DockStyle.Fill;
            txtProductDesc.Location = new Point(3, 38);
            txtProductDesc.Name = "txtProductDesc";
            txtProductDesc.Size = new Size(596, 360);
            txtProductDesc.TabIndex = 3;
            txtProductDesc.Text = "";
            // 
            // btnChooseImage
            // 
            btnChooseImage.FlatStyle = FlatStyle.Flat;
            btnChooseImage.Location = new Point(605, 3);
            btnChooseImage.Name = "btnChooseImage";
            btnChooseImage.Size = new Size(75, 23);
            btnChooseImage.TabIndex = 4;
            btnChooseImage.Text = "Chọn ảnh";
            btnChooseImage.UseVisualStyleBackColor = true;
            btnChooseImage.Click += btnChooseImage_Click;
            // 
            // btnSave
            // 
            btnSave.Location = new Point(12, 525);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(75, 23);
            btnSave.TabIndex = 6;
            btnSave.Text = "Lưu";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // btnChooseVideo
            // 
            btnChooseVideo.FlatStyle = FlatStyle.Flat;
            btnChooseVideo.Location = new Point(1265, 3);
            btnChooseVideo.Name = "btnChooseVideo";
            btnChooseVideo.Size = new Size(113, 23);
            btnChooseVideo.TabIndex = 5;
            btnChooseVideo.Text = "Chọn video";
            btnChooseVideo.UseVisualStyleBackColor = true;
            btnChooseVideo.Click += btnChooseVideo_Click;
            // 
            // imageList1
            // 
            imageList1.ColorDepth = ColorDepth.Depth32Bit;
            imageList1.ImageSize = new Size(16, 16);
            imageList1.TransparentColor = Color.Transparent;
            // 
            // txtProductCode
            // 
            txtProductCode.Dock = DockStyle.Fill;
            txtProductCode.Location = new Point(121, 3);
            txtProductCode.Name = "txtProductCode";
            txtProductCode.Size = new Size(394, 23);
            txtProductCode.TabIndex = 1;
            txtProductCode.Leave += txtProductCode_Leave;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(3, 0);
            label3.Name = "label3";
            label3.Size = new Size(79, 15);
            label3.TabIndex = 10;
            label3.Text = "Mã sản phẩm";
            // 
            // multiImagePreviewControl1
            // 
            multiImagePreviewControl1.Dock = DockStyle.Fill;
            multiImagePreviewControl1.Location = new Point(605, 38);
            multiImagePreviewControl1.Name = "multiImagePreviewControl1";
            multiImagePreviewControl1.Size = new Size(654, 360);
            multiImagePreviewControl1.TabIndex = 11;
            // 
            // videoPreviewControl1
            // 
            videoPreviewControl1.Dock = DockStyle.Fill;
            videoPreviewControl1.Location = new Point(1265, 38);
            videoPreviewControl1.Name = "videoPreviewControl1";
            videoPreviewControl1.Size = new Size(612, 360);
            videoPreviewControl1.TabIndex = 12;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 3;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 47.7317543F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 52.2682457F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 617F));
            tableLayoutPanel1.Controls.Add(btnChooseVideo, 2, 0);
            tableLayoutPanel1.Controls.Add(multiImagePreviewControl1, 1, 1);
            tableLayoutPanel1.Controls.Add(videoPreviewControl1, 2, 1);
            tableLayoutPanel1.Controls.Add(btnChooseImage, 1, 0);
            tableLayoutPanel1.Controls.Add(txtProductDesc, 0, 1);
            tableLayoutPanel1.Controls.Add(label2, 0, 0);
            tableLayoutPanel1.Location = new Point(12, 118);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 2;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 8.72818F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 91.27182F));
            tableLayoutPanel1.Size = new Size(1880, 401);
            tableLayoutPanel1.TabIndex = 13;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 2;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 22.7799225F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 77.22008F));
            tableLayoutPanel2.Controls.Add(label3, 0, 0);
            tableLayoutPanel2.Controls.Add(txtProductCode, 1, 0);
            tableLayoutPanel2.Controls.Add(label1, 0, 1);
            tableLayoutPanel2.Controls.Add(txtProductName, 1, 1);
            tableLayoutPanel2.Location = new Point(12, 12);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 2;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.Size = new Size(518, 100);
            tableLayoutPanel2.TabIndex = 14;
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(93, 525);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(75, 23);
            btnCancel.TabIndex = 15;
            btnCancel.Text = "Hủy bỏ";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // frmCreateNewProduct
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1904, 1041);
            Controls.Add(btnCancel);
            Controls.Add(tableLayoutPanel2);
            Controls.Add(tableLayoutPanel1);
            Controls.Add(btnSave);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximumSize = new Size(1920, 1080);
            MinimumSize = new Size(1918, 1030);
            Name = "frmCreateNewProduct";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Thêm sản phẩm mới";
            Load += frmCreateNewProduct_Load;
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            tableLayoutPanel2.ResumeLayout(false);
            tableLayoutPanel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private TextBox txtProductName;
        private Label label2;
        private RichTextBox txtProductDesc;
        private Button btnChooseImage;
        private Button btnSave;
        private Button btnChooseVideo;
        private ImageList imageList1;
        private TextBox txtProductCode;
        private Label label3;
        private UserControls.MultiImagePreviewControl multiImagePreviewControl1;
        private UserControls.VideoPreviewControl videoPreviewControl1;
        private TableLayoutPanel tableLayoutPanel1;
        private TableLayoutPanel tableLayoutPanel2;
        private Button btnCancel;
    }
}