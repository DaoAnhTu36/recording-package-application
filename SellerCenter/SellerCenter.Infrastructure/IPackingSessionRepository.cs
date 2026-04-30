using SellerCenter.Infrastructure.Models;
using System.Data;

namespace SellerCenter.Infrastructure
{
    public interface IPackingSessionRepository : IRepository<PackingSessionModel>
    {
        public DataTable GetAllSessions();

        public void InsertSession(string barcode, string localPath);

        public void UpdateSession(string barcode, string youtubeUrl);

        public bool IsBarcodeExists(string barcode);

        public Task<DataTable> GetHistoryRecordByBarcode(string? barcode, DateTime? fromDate, DateTime? toDate);
    }
}