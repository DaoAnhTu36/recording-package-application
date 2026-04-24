using SellerCenter.Helpers;

namespace SellerCenter
{
    public partial class Form1 : Form
    {
        private Form? currentForm;
        private Dictionary<string, Form> formCache = new();

        public Form1()
        {
            InitializeComponent();
        }

        public void OpenForm(Form form)
        {
            string key = form.GetType().Name;

            if (formCache.ContainsKey(key))
            {
                form = formCache[key];
            }
            else
            {
                formCache[key] = form;
            }

            foreach (Control ctrl in panelMain.Controls)
                ctrl.Visible = false;

            form.TopLevel = false;
            form.Dock = DockStyle.Fill;

            if (!panelMain.Controls.Contains(form))
                panelMain.Controls.Add(form);

            form.Show();
            form.BringToFront();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            UIHelper.InitMenu(this, panelMain);
        }
    }
}