using SellerCenter.Helpers;
using SellerCenter.Infrastructure.Models;
using SellerCenter.Service;

namespace SellerCenter.Forms
{
    public partial class frmAction : BaseForm
    {
        private readonly IActionService _actionService;

        public frmAction()
        {
            InitializeComponent();
            _actionService = ServiceLocator.Get<IActionService>();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            var key = txtActionKey.Text.Trim();
            var name = txtActionName.Text.Trim();
            if (string.IsNullOrEmpty(key) || string.IsNullOrEmpty(name))
            {
                MessageBox.Show("Vui lòng điền đầy đủ thông tin form");
                return;
            }
            var form = new ActionModel
            {
                ActionKey = key,
                ActionName = name,
                IsActive = true
            };
            _actionService.Create(form);
            OnClear();
            GetAllAction();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            OnClear();
        }

        private void OnInit()
        {
            GetAllAction();
        }

        private void OnClear()
        {
            FormHelper.ClearForm(this);
        }

        private void GetAllAction()
        {
            var data = _actionService.GetAll();
            dataGridView1.DataSource = data;
        }

        private void frmAction_Load(object sender, EventArgs e)
        {
            OnInit();
        }
    }
}