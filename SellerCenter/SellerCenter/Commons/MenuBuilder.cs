using Newtonsoft.Json;
using SellerCenter.Models;
using System.Reflection;

namespace SellerCenter.Commons
{
    public class MenuBuilder
    {
        private readonly Form _parentForm;
        private readonly Panel _mainPanel;

        public MenuBuilder(Form parentForm, Panel mainPanel)
        {
            _parentForm = parentForm;
            _mainPanel = mainPanel;
        }

        public MenuStrip BuildFromJson()
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

            var form = (Form)Activator.CreateInstance(formType);
            OpenFormInPanel(form);
        }

        private void OpenFormInPanel(Form form)
        {
            _mainPanel.Controls.Clear();

            form.TopLevel = false;
            form.FormBorderStyle = FormBorderStyle.None;
            form.Dock = DockStyle.Fill;

            _mainPanel.Controls.Add(form);
            form.Show();
        }
    }
}