using SellerCenter.Helpers;
using SellerCenter.Infrastructure.Models;
using SellerCenter.Service;

namespace SellerCenter.Forms
{
    public partial class frmForm : BaseForm
    {
        private readonly IFormService _formService;

        public frmForm()
        {
            InitializeComponent();
            _formService = ServiceLocator.Get<IFormService>();
        }

        private void frmForm_Load(object sender, EventArgs e)
        {
            OnInit();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            var formKey = txtFormKey.Text.Trim();
            var formName = txtFormName.Text.Trim();
            if (string.IsNullOrEmpty(formKey) || string.IsNullOrEmpty(formName))
            {
                MessageBox.Show("Vui lòng điền đầy đủ thông tin form");
                return;
            }
            var form = new FormModel
            {
                CreatedAt = DateTime.Now,
                FormKey = formKey,
                FormName = formName,
                IsActive = true
            };
            _formService.Create(form);
            OnClear();
            GetAll();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            OnClear();
        }

        private void OnInit()
        {
            GetAll();
        }

        private void OnClear()
        {
            FormHelper.ClearForm(this);
        }

        private void GetAll()
        {
            var lstForm = _formService.GetAll();
            dataGridView1.DataSource = lstForm;
        }
    }
}