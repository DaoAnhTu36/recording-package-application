using SellerCenter.Helpers;
using SellerCenter.Infrastructure.Models;
using SellerCenter.Service;

namespace SellerCenter.Forms
{
    public partial class frmMenu : BaseForm
    {
        private readonly MenuService1 _menuService;
        private long _idEditing;
        private MenuModel? _menuModel;

        public frmMenu()
        {
            InitializeComponent();
            _menuService = new MenuService1();
        }

        private void frmMenu_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void LoadData()
        {
            var data = _menuService.GetAllWithParentName();
            dataGridView1.DataSource = data;
            var dataMenuParent = data.Select(x => new
            {
                IdMenuParent = x.Id,
                MenuParent = x.MenuName
            }).ToList();
            dataMenuParent.Insert(0, new { IdMenuParent = 0L, MenuParent = "None" }!);
            cbbMenuParent.DataSource = dataMenuParent;
            cbbMenuParent.DisplayMember = "MenuParent";
            cbbMenuParent.ValueMember = "IdMenuParent";
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            var parentId = (long?)cbbMenuParent.SelectedValue == 0 ? null : (long?)cbbMenuParent.SelectedValue;
            var menu = new MenuModel
            {
                MenuName = txtMenuName.Text,
                FormName = txtFormName.Text,
                IconName = txtIconName.Text,
                ParentId = parentId,
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
            FormReset();
        }

        private void FormReset()
        {
            FormHelper.ClearForm(this);
            _idEditing = 0;
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewHelper.HandleCellClick<MenuViewModel>(dataGridView1, e, item =>
            {
                _idEditing = item.Id;
                _menuModel = _menuService.GetById(_idEditing);
                txtMenuCode.Text = item.MenuCode;
                txtMenuName.Text = item.MenuName;
                txtFormName.Text = item.FormName;
                txtIconName.Text = item.IconName;
                txtSortOrder.Text = item.SortOrder.ToString();
                cbbMenuParent.SelectedValue = item.ParentId ?? 0;
            });
        }
    }
}