using SellerCenter.Infrastructure.Models;
using SellerCenter.Service.DTO;

namespace SellerCenter.Service
{
    public interface IPackingSessionService : IService<PackingSessionModel>
    {
        public List<PackingSessionAllRes> GetAllSessions();

        public void InsertSession(string barcode, string localPath);

        public void UpdateSession(string barcode, string youtubeUrl);

        public bool IsBarcodeExists(string barcode);

        public Task<List<PackingSessionAllRes>> GetHistoryRecordByBarcode(string? barcode, DateTime? fromDate, DateTime? toDate);
    }
}