namespace SellerCenter.UserControls
{
    public partial class VideoPreviewControl : UserControl
    {
        public string? SelectedVideoPath { get; private set; }

        public VideoPreviewControl()
        {
            InitializeComponent();
        }

        public void PreviewVideo(string videoPath)
        {
            if (string.IsNullOrWhiteSpace(videoPath) || !File.Exists(videoPath))
            {
                Clear();
                return;
            }

            SelectedVideoPath = videoPath;

            axVideoPlayer.URL = videoPath;
            axVideoPlayer.Ctlcontrols.play();
        }

        public void Stop()
        {
            axVideoPlayer.Ctlcontrols.stop();
        }

        public void Clear()
        {
            SelectedVideoPath = null;

            axVideoPlayer.Ctlcontrols.stop();
            axVideoPlayer.URL = string.Empty;
        }
    }
}