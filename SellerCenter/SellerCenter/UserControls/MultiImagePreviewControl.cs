using System.Data;

namespace SellerCenter.UserControls
{
    public partial class MultiImagePreviewControl : UserControl
    {
        public List<string> SelectedImagePaths { get; private set; } = new();

        public MultiImagePreviewControl()
        {
            InitializeComponent();
            SetDefaultImage();
        }

        public void SetDefaultImage()
        {
            ClearImagesOnly();

            var pic = new PictureBox
            {
                Width = 120,
                Height = 120,
                SizeMode = PictureBoxSizeMode.Zoom,
                BorderStyle = BorderStyle.FixedSingle,
                Margin = new Padding(5),
                Image = Properties.Resources.no_image,
                Tag = "default"
            };

            flowImages.Controls.Add(pic);
        }

        private void ClearImagesOnly()
        {
            foreach (Control ctrl in flowImages.Controls)
            {
                if (ctrl is PictureBox pic)
                {
                    pic.Image?.Dispose();
                    pic.Image = null;
                }
            }

            flowImages.Controls.Clear();
        }

        public void PreviewImages(IEnumerable<string> imagePaths)
        {
            Clear();

            SelectedImagePaths = imagePaths
                .Where(File.Exists)
                .ToList();

            foreach (var path in SelectedImagePaths)
            {
                var pic = new PictureBox
                {
                    Width = 120,
                    Height = 120,
                    SizeMode = PictureBoxSizeMode.Zoom,
                    BorderStyle = BorderStyle.FixedSingle,
                    Margin = new Padding(5),
                    Image = LoadImageNoLock(path),
                    Tag = path
                };

                flowImages.Controls.Add(pic);
            }
        }

        private Image LoadImageNoLock(string path)
        {
            using var fs = new FileStream(path, FileMode.Open, FileAccess.Read);
            using var img = Image.FromStream(fs);
            return new Bitmap(img);
        }

        public void Clear()
        {
            foreach (Control ctrl in flowImages.Controls)
            {
                if (ctrl is PictureBox pic)
                {
                    pic.Image?.Dispose();
                    pic.Image = null;
                }
            }

            flowImages.Controls.Clear();
            SelectedImagePaths.Clear();
        }
    }
}