namespace SellerCenter.UserControls
{
    public partial class ImagePreviewControl : UserControl
    {
        public string? SelectedImagePath { get; private set; }

        public ImagePreviewControl()
        {
            InitializeComponent();
            SetDefaultImage();
        }

        public void PreviewImage(string imagePath)
        {
            if (string.IsNullOrWhiteSpace(imagePath) || !File.Exists(imagePath))
            {
                SetDefaultImage();
                return;
            }

            picPreview.Image?.Dispose();

            using var fs = new FileStream(imagePath, FileMode.Open, FileAccess.Read);
            picPreview.Image = Image.FromStream(fs);
            picPreview.SizeMode = PictureBoxSizeMode.Zoom;
            SelectedImagePath = imagePath;
        }

        public void SetDefaultImage()
        {
            picPreview.Image?.Dispose();
            picPreview.Image = Properties.Resources.no_image;
            picPreview.SizeMode = PictureBoxSizeMode.Zoom;
            SelectedImagePath = null;
        }

        public void Clear()
        {
            SetDefaultImage();
        }
    }
}