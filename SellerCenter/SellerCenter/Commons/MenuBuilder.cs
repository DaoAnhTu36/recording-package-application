using Newtonsoft.Json;
using SellerCenter.Infrastructure.Models;
using SellerCenter.Models;
using SellerCenter.Service;
using System.Reflection;

namespace SellerCenter.Commons
{
    public class MenuBuilder
    {
        private readonly Form _parentForm;
        private readonly Panel _mainPanel;
        private readonly MenuService1 _menuService;

        public MenuBuilder(Form parentForm, Panel mainPanel)
        {
            _parentForm = parentForm;
            _mainPanel = mainPanel;
            _menuService = new MenuService1();
        }

        public MenuStrip BuildFromJson()
        {
            //var menuStrip = GenMenuStatic();
            var menuStrip = GenMenuLive();
            menuStrip.Renderer = new ModernMenuRenderer();
            menuStrip.BackColor = Color.White;
            menuStrip.ForeColor = Color.Black;
            menuStrip.Padding = new Padding(10, 5, 10, 5);
            menuStrip.Font = new Font("Segoe UI", 10);
            return menuStrip;
        }

        private MenuStrip GenMenuLive()
        {
            var raw = _menuService.GetAll()
                .Where(x => x.IsActive && x.IsVisible)
                .Select(x =>
                {
                    if (x.ParentId == 0) x.ParentId = null;
                    return x;
                })
                .ToList();
            var menuItems = BuildMenuTree(raw);
            var menuStrip = new MenuStrip();
            foreach (var item in menuItems)
            {
                menuStrip.Items.Add(CreateMenuItem(item));
            }
            return menuStrip;
        }

        private MenuStrip GenMenuStatic()
        {
            string jsonPath = Path.Combine(
                Application.StartupPath,
                "Configurations",
                "menu.json"
            );
            var json = File.ReadAllText(jsonPath);
            var menuItems = JsonConvert.DeserializeObject<List<MenuItemConfig>>(json);
            var menuStrip = new MenuStrip();

            foreach (var item in menuItems!)
            {
                menuStrip.Items.Add(CreateMenuItem(item));
            }
            return menuStrip;
        }

        public List<MenuItemConfig> BuildMenuTree(List<MenuModel> menus)
        {
            var map = new Dictionary<long, MenuItemConfig>();

            foreach (var m in menus)
            {
                if (map.ContainsKey(m.Id))
                    throw new Exception($"Duplicate Id: {m.Id}");

                map[m.Id] = new MenuItemConfig
                {
                    Id = m.Id,
                    Title = m.MenuName,
                    Form = m.FormName,
                    Children = new List<MenuItemConfig>()
                };
            }

            var roots = new List<MenuItemConfig>();

            foreach (var m in menus)
            {
                var node = map[m.Id];

                if (m.ParentId == null)
                {
                    roots.Add(node);
                }
                else if (map.ContainsKey(m.ParentId.Value))
                {
                    map[m.ParentId.Value].Children!.Add(node);
                }
                else
                {
                    roots.Add(node);
                }
            }

            void Sort(List<MenuItemConfig> list)
            {
                list.Sort((a, b) =>
                {
                    var aSort = menus.First(x => x.Id == a.Id).SortOrder;
                    var bSort = menus.First(x => x.Id == b.Id).SortOrder;
                    return aSort.CompareTo(bSort);
                });

                foreach (var item in list)
                    Sort(item.Children!);
            }

            Sort(roots);

            return roots;
        }

        private ToolStripMenuItem CreateMenuItem(MenuItemConfig item)
        {
            var menuItem = new ToolStripMenuItem(item.Title);

            if (item.Children != null && item.Children.Count > 0)
            {
                foreach (var child in item.Children)
                {
                    menuItem.DropDownItems.Add(CreateMenuItem(child));
                }
            }
            else if (!string.IsNullOrWhiteSpace(item.Form))
            {
                menuItem.Click += (s, e) => OpenFormByName(item.Form);
            }

            return menuItem;
        }

        private void OpenFormByName(string formName)
        {
            var formType = Assembly.GetExecutingAssembly()
                .GetTypes()
                .FirstOrDefault(t => t.Name == formName && typeof(Form).IsAssignableFrom(t));

            if (formType == null)
            {
                MessageBox.Show($"Không tìm thấy form: {formName}");
                return;
            }

            var instance = Activator.CreateInstance(formType);
            if (instance is not Form form)
            {
                MessageBox.Show($"Không thể khởi tạo form: {formName}");
                return;
            }

            OpenFormInPanel(form);
        }

        private void OpenFormInPanel(Form form)
        {
            _mainPanel.Controls.Clear();

            form.TopLevel = false;
            form.FormBorderStyle = FormBorderStyle.None;
            form.Dock = DockStyle.Fill;

            _mainPanel.Controls.Add(form);
            (_parentForm as Form1)?.OpenForm(form);
        }
    }
}