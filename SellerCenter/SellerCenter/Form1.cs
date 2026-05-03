using SellerCenter.Helpers;

namespace SellerCenter
{
    public partial class Form1 : Form
    {
        private Form? currentForm;

        public Form1()
        {
            InitializeComponent();
        }

        public void OpenForm(Form form)
        {
            if (currentForm != null)
            {
                currentForm.Close();
                panelMain.Controls.Remove(currentForm);
            }

            currentForm = form;

            form.TopLevel = false;
            form.Dock = DockStyle.Fill;

            panelMain.Controls.Add(form);
            var formName = form.Text;
            form.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Label label = new Label();
            UIHelper.InitMenu(this, panelMain, label);
        }
    }
}