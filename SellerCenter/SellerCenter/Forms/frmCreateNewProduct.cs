using SellerCenter.Helper;
using SellerCenter.Helpers;
using SellerCenter.Infrastructure.Models;
using SellerCenter.Service;

namespace SellerCenter.Forms
{
    public partial class frmCreateNewProduct : Form
    {
        private List<string> selectedImagePaths = new List<string>();
        private string selectedVideoPath = string.Empty;
        private readonly ProductService _productService;

        public frmCreateNewProduct()
        {
            InitializeComponent();
            _productService = new ProductService();
        }

        private void btnChooseImage_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog ofd = new OpenFileDialog())
            {
                ofd.Title = "Chọn nhiều ảnh";
                ofd.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp;*.webp";
                ofd.Multiselect = true;

                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    selectedImagePaths = ofd.FileNames.ToList();
                    multiImagePreviewControl1.PreviewImages(ofd.FileNames);
                }
            }
        }

        private void btnChooseVideo_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog ofd = new OpenFileDialog())
            {
                ofd.Title = "Chọn video";
                ofd.Filter = "Video Files|*.mp4;*.avi;*.mov;*.mkv;*.wmv";

                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    selectedVideoPath = ofd.FileName;
                    videoPreviewControl1.PreviewVideo(selectedVideoPath);
                }
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!ValidateInput())
                return;
            var product = new ProductModel
            {
                ProductName = txtProductName.Text.Trim(),
                ProductCode = txtProductCode.Text.Trim().ToUpper(),
                Description = txtProductDesc.Text.Trim(),
                ImageUrl = string.Join(CharacterConstants.Separator, selectedImagePaths),
                VideoUrl = selectedVideoPath
            };
            var idProduct = _productService.Insert(product);
            if (idProduct > 0)
            {
                ResetProductForm();
            }
        }

        private void ResetProductForm()
        {
            txtProductName.Clear();
            txtProductCode.Clear();
            txtProductDesc.Clear();
            selectedImagePaths.Clear();
            selectedVideoPath = string.Empty;
            multiImagePreviewControl1.Clear();
            videoPreviewControl1.Clear();
            txtProductCode.Focus();
        }

        private void txtProductCode_Leave(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtProductCode.Text.Trim()) && _productService.ExistsByCode(txtProductCode.Text.Trim()))
            {
                MessageBox.Show("Mã sản phẩm đã tồn tại.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtProductCode.Focus();
            }
        }

        private bool ValidateInput()
        {
            if (string.IsNullOrWhiteSpace(txtProductCode.Text))
            {
                MessageBox.Show("Vui lòng nhập mã sản phẩm");
                txtProductCode.Focus();
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtProductName.Text))
            {
                MessageBox.Show("Vui lòng nhập tên sản phẩm");
                txtProductName.Focus();
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtProductDesc.Text))
            {
                MessageBox.Show("Vui lòng nhập mô tả");
                txtProductDesc.Focus();
                return false;
            }

            if (selectedImagePaths == null || selectedImagePaths.Count == 0)
            {
                MessageBox.Show("Vui lòng chọn ít nhất 1 ảnh");
                return false;
            }

            if (string.IsNullOrWhiteSpace(selectedVideoPath))
            {
                MessageBox.Show("Vui lòng chọn video");
                return false;
            }

            return true;
        }

        private void frmCreateNewProduct_Load(object sender, EventArgs e)
        {
            UIHelper.ApplyAll(this);
        }
    }
}