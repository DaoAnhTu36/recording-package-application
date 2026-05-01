using SellerCenter.Service;

namespace SellerCenter.Forms
{
    public partial class frmProductManager : BaseForm
    {
        private readonly ProductService? _productService;

        public frmProductManager()
        {
            InitializeComponent();
            _productService = new ProductService();
        }

        private void frmProductManager_Load(object sender, EventArgs e)
        {
            GetData();
        }

        private void txtKeyword_TextChanged(object sender, EventArgs e)
        {
            var keyword = txtKeyword.Text.Trim();
            if (string.IsNullOrEmpty(keyword))
            {
                GetData();
                return;
            }
            var dataSearch = _productService?.Search(keyword);
            dataGridView1.DataSource = dataSearch;
        }

        private void GetData()
        {
            var products = _productService?.GetAll();
            if (products == null || products.Rows.Count == 0)
            {
                dataGridView1.DataSource = null;
                return;
            }
            dataGridView1.DataSource = products;
            AddEditButtonColumn();
        }

        private void AddEditButtonColumn()
        {
            if (dataGridView1.Columns["btnDelete"] == null)
            {
                DataGridViewButtonColumn btnDelete = new DataGridViewButtonColumn
                {
                    Name = "btnDelete",
                    HeaderText = "Chỉnh sửa",
                    Text = "Xóa",
                    UseColumnTextForButtonValue = true,
                };
                dataGridView1.Columns.Add(btnDelete);
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            if (dataGridView1.Columns[e.ColumnIndex].Name == "btnDelete")
            {
                int id = Convert.ToInt32(
                    dataGridView1.Rows[e.RowIndex].Cells["id"].Value
                );
                var confirm = MessageBox.Show("Bạn có chắc muốn xóa không?", "Confirm", MessageBoxButtons.YesNo);
                if (confirm == DialogResult.Yes)
                {
                    _productService?.Delete(id);
                    dataGridView1.Rows.RemoveAt(e.RowIndex);
                }
            }
        }
    }
}