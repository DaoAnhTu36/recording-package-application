using SellerCenter.Helpers;
using SellerCenter.Infrastructure.Models;
using SellerCenter.Service;

namespace SellerCenter.Forms
{
    public partial class frmMenu : BaseForm
    {
        private readonly MenuService _menuService;
        private long _idEditing;
        private MenuModel? _menuModel;

        public frmMenu()
        {
            InitializeComponent();
            _menuService = new MenuService();
        }

        private void frmMenu_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void LoadData()
        {
            var data = _menuService.GetAll();
            dataGridView1.DataSource = data;
            MappingData();
            cbbMenuParent.DataSource = data.Select(x => new
            {
                x.Id,
                x.MenuName
            });
            cbbMenuParent.DisplayMember = "menuName";
            cbbMenuParent.ValueMember = "id";
        }

        private void MappingData()
        {
            id.DataPropertyName = "id";
            menuName.DataPropertyName = "menuName";
            formName.DataPropertyName = "formName";
            iconName.DataPropertyName = "iconName";
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            var menu = new MenuModel
            {
                MenuName = txtMenuName.Text,
                FormName = txtFormName.Text,
                IconName = txtIconName.Text,
                ParentId = (long)cbbMenuParent.SelectedValue!,
                IsActive = true,
                IsVisible = true,
                MenuCode = txtMenuCode.Text,
                SortOrder = (int)txtSortOrder.Value,
            };
            if (_idEditing > 0)
            {
                _menuModel!.MenuName = menu.MenuName;
                _menuModel.FormName = menu.FormName;
                _menuModel.IconName = menu.IconName;
                _menuModel.ParentId = menu.ParentId;
                _menuModel.MenuCode = menu.MenuCode;
                _menuModel.SortOrder = menu.SortOrder;
                var result = _menuService.Update(_menuModel!);
                if (result)
                {
                    FormReset();
                    LoadData();
                }
                return;
            }
            var menuId = _menuService.Create(menu);
            if (menuId > 0)
            {
                FormReset();
                LoadData();
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
        }

        private void FormReset()
        {
            FormHelper.ClearForm(this);
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;
            var row = dataGridView1.Rows[e.RowIndex];
            var item = (MenuModel)row.DataBoundItem;
            _idEditing = item.Id;
            _menuModel = _menuService.GetById(_idEditing);
            txtMenuCode.Text = item.MenuCode;
            txtMenuName.Text = item.MenuName;
            txtFormName.Text = item.FormName;
            txtIconName.Text = item.IconName;
            txtSortOrder.Text = item.SortOrder.ToString();
            cbbMenuParent.SelectedValue = item.ParentId ?? 0;
        }
    }
}