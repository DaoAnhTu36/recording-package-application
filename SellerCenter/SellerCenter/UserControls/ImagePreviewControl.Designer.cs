namespace SellerCenter.UserControls
{
    partial class ImagePreviewControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            picPreview = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)picPreview).BeginInit();
            SuspendLayout();
            // 
            // picPreview
            // 
            picPreview.Location = new Point(3, 3);
            picPreview.Name = "picPreview";
            picPreview.Size = new Size(100, 50);
            picPreview.TabIndex = 0;
            picPreview.TabStop = false;
            picPreview.Dock = DockStyle.Fill;
            picPreview.SizeMode = PictureBoxSizeMode.Zoom;
            picPreview.BorderStyle = BorderStyle.FixedSingle;
            // 
            // ImagePreviewControl
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(picPreview);
            Name = "ImagePreviewControl";
            ((System.ComponentModel.ISupportInitialize)picPreview).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox picPreview;
    }
}
