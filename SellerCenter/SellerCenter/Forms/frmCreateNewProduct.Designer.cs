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
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 67);
            label1.Name = "label1";
            label1.Size = new Size(81, 15);
            label1.TabIndex = 0;
            label1.Text = "Tên sản phẩm";
            // 
            // txtProductName
            // 
            txtProductName.Location = new Point(12, 85);
            txtProductName.Name = "txtProductName";
            txtProductName.Size = new Size(297, 23);
            txtProductName.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 133);
            label2.Name = "label2";
            label2.Size = new Size(93, 15);
            label2.TabIndex = 2;
            label2.Text = "Mô tả sản phẩm";
            // 
            // txtProductDesc
            // 
            txtProductDesc.Location = new Point(12, 151);
            txtProductDesc.Name = "txtProductDesc";
            txtProductDesc.Size = new Size(297, 232);
            txtProductDesc.TabIndex = 3;
            txtProductDesc.Text = "";
            // 
            // btnChooseImage
            // 
            btnChooseImage.FlatStyle = FlatStyle.Flat;
            btnChooseImage.Location = new Point(351, 122);
            btnChooseImage.Name = "btnChooseImage";
            btnChooseImage.Size = new Size(75, 23);
            btnChooseImage.TabIndex = 4;
            btnChooseImage.Text = "Chọn ảnh";
            btnChooseImage.UseVisualStyleBackColor = true;
            btnChooseImage.Click += btnChooseImage_Click;
            // 
            // btnSave
            // 
            btnSave.FlatStyle = FlatStyle.Flat;
            btnSave.Location = new Point(12, 389);
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
            btnChooseVideo.Location = new Point(710, 122);
            btnChooseVideo.Name = "btnChooseVideo";
            btnChooseVideo.Size = new Size(113, 23);
            btnChooseVideo.TabIndex = 7;
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
            txtProductCode.Location = new Point(12, 32);
            txtProductCode.Name = "txtProductCode";
            txtProductCode.Size = new Size(297, 23);
            txtProductCode.TabIndex = 1;
            txtProductCode.Leave += txtProductCode_Leave;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 14);
            label3.Name = "label3";
            label3.Size = new Size(79, 15);
            label3.TabIndex = 10;
            label3.Text = "Mã sản phẩm";
            // 
            // multiImagePreviewControl1
            // 
            multiImagePreviewControl1.Location = new Point(346, 151);
            multiImagePreviewControl1.Name = "multiImagePreviewControl1";
            multiImagePreviewControl1.Size = new Size(334, 232);
            multiImagePreviewControl1.TabIndex = 11;
            // 
            // videoPreviewControl1
            // 
            videoPreviewControl1.Location = new Point(710, 151);
            videoPreviewControl1.Name = "videoPreviewControl1";
            videoPreviewControl1.Size = new Size(401, 232);
            videoPreviewControl1.TabIndex = 12;
            // 
            // frmCreateNewProduct
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1123, 450);
            Controls.Add(videoPreviewControl1);
            Controls.Add(multiImagePreviewControl1);
            Controls.Add(txtProductCode);
            Controls.Add(label3);
            Controls.Add(btnChooseVideo);
            Controls.Add(btnSave);
            Controls.Add(btnChooseImage);
            Controls.Add(txtProductDesc);
            Controls.Add(label2);
            Controls.Add(txtProductName);
            Controls.Add(label1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximumSize = new Size(1139, 489);
            MinimumSize = new Size(1139, 489);
            Name = "frmCreateNewProduct";
            Text = "Thêm sản phẩm mới";
            ResumeLayout(false);
            PerformLayout();
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
    }
}