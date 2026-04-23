using SellerCenter.Forms;

namespace SellerCenter
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void subMenuNewRecording_Click(object sender, EventArgs e)
        {
            frmRecording frmRecording = new frmRecording();
            frmRecording.ShowDialog();
        }

        private void subMenuRecordHistory_Click(object sender, EventArgs e)
        {
            frmHistoryScreen frmHistoryScreen = new frmHistoryScreen();
            frmHistoryScreen.ShowDialog();
        }
    }
}