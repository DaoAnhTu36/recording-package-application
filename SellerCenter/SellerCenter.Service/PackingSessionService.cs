using SellerCenter.Infrastructure;
using System.Data;

namespace SellerCenter.Service
{
    public class PackingSessionService
    {
        private PackingSessionRepository _instance;

        public PackingSessionService()
        {
            _instance = new PackingSessionRepository();
        }

        public DataTable GetAllSessions()
        {
            return _instance.GetAllSessions();
        }

        public void InsertSession(string barcode, string videoPath)
        {
            _instance.InsertSession(barcode, videoPath);
        }

        public void UpdateSession(string barcode, string youtubeUrl)
        {
            _instance.UpdateSession(barcode, youtubeUrl);
        }

        public bool IsBarcodeExists(string barcode)
        {
            return _instance.IsBarcodeExists(barcode);
        }

        public async Task<DataTable> GetHistoryRecordByBarcode(string? barcode, DateTime? fromDate, DateTime? toDate)
        {
            return await _instance.GetHistoryRecordByBarcode(barcode, fromDate, toDate);
        }
    }
}