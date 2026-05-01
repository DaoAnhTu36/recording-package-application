using SellerCenter.Helpers;
using SellerCenter.Infrastructure.Models;
using SellerCenter.Service;

namespace SellerCenter.Forms
{
    public partial class frmHistoryScreen : BaseForm
    {
        private CancellationTokenSource? cts;
        private readonly IPackingSessionService _sessionService;

        public frmHistoryScreen()
        {
            InitializeComponent();
            listRecord.CellDoubleClick += listRecord_CellDoubleClick!;
            RegisterGlobalEvents(this);
            _sessionService = ServiceLocator.Get<IPackingSessionService>();
        }

        private void frmHistoryScreen_Load(object sender, EventArgs e)
        {
            GetListVideoFiles();
        }

        private void GetListVideoFiles()
        {
            List<PackingSessionModel> dataSession = _sessionService.GetAll();
            listRecord.DataSource = dataSession;
        }

        private async void btnSearch_Click(object sender, EventArgs e)
        {
            var barcode = txtBarcode.Text.Trim();
            var dateFrom = fromDate.Value;
            var dateTo = toDate.Value;
            cts?.Cancel();
            cts = new CancellationTokenSource();

            try
            {
                await Task.Delay(300, cts.Token);
                var keyword = txtBarcode.Text.Trim();
                if (string.IsNullOrEmpty(keyword))
                {
                    GetListVideoFiles();
                }
                else
                {
                    var dt = await _sessionService.GetHistoryRecordByBarcode(barcode, dateFrom, dateTo);
                    listRecord.DataSource = dt;
                }
            }
            catch (TaskCanceledException) { }
        }

        private async void txtBarcode_TextChanged(object sender, EventArgs e)
        {
            var barcode = txtBarcode.Text.Trim();
            if (string.IsNullOrEmpty(barcode))
            {
                listRecord.DataSource = null;
                return;
            }
            cts?.Cancel();
            cts = new CancellationTokenSource();

            try
            {
                await Task.Delay(300, cts.Token);

                var keyword = txtBarcode.Text.Trim();
                if (string.IsNullOrEmpty(keyword))
                {
                    GetListVideoFiles();
                }
                else
                {
                    var dt = await _sessionService.GetHistoryRecordByBarcode(barcode, null, null);
                    listRecord.DataSource = dt;
                }
            }
            catch (TaskCanceledException) { }
        }

        private void listRecord_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;
            var row = listRecord.Rows[e.RowIndex];
            string? path = row.Cells["local_path"].Value?.ToString();
            if (File.Exists(path))
            {
                axWindowsMediaPlayer1.URL = path;
                axWindowsMediaPlayer1.Ctlcontrols.play();
            }
        }

        private void RegisterGlobalEvents(Control parent)
        {
            foreach (Control ctrl in parent.Controls)
            {
                ctrl.Click += (s, e) =>
                {
                    Logger.Info($"Click: {ctrl.Name}");
                };

                if (ctrl.HasChildren)
                    RegisterGlobalEvents(ctrl);
            }
        }
    }
}