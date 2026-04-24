namespace SellerCenter.UserControls
{
    partial class VideoPreviewControl
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(VideoPreviewControl));
            axVideoPlayer = new AxWMPLib.AxWindowsMediaPlayer();
            ((System.ComponentModel.ISupportInitialize)axVideoPlayer).BeginInit();
            SuspendLayout();
            // 
            // axVideoPlayer
            // 
            axVideoPlayer.Dock = DockStyle.Fill;
            axVideoPlayer.Enabled = true;
            axVideoPlayer.Location = new Point(0, 0);
            axVideoPlayer.Name = "axVideoPlayer";
            axVideoPlayer.OcxState = (AxHost.State)resources.GetObject("axVideoPlayer.OcxState");
            axVideoPlayer.Size = new Size(150, 150);
            axVideoPlayer.TabIndex = 0;
            // 
            // VideoPreviewControl
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(axVideoPlayer);
            Name = "VideoPreviewControl";
            ((System.ComponentModel.ISupportInitialize)axVideoPlayer).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private AxWMPLib.AxWindowsMediaPlayer axVideoPlayer;
    }
}
