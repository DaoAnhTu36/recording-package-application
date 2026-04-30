using SellerCenter.Helper;
using SellerCenter.Infrastructure;
using SellerCenter.Infrastructure.Models;
using SellerCenter.Service.DTO;
using System.Data;

namespace SellerCenter.Service.Implementation
{
    [Scoped]
    public class PackingSessionService : Service<PackingSessionModel>, IPackingSessionService
    {
        private readonly IPackingSessionRepository _packingSessionRepository;

        public PackingSessionService(IPackingSessionRepository packingSessionRepository) : base(packingSessionRepository)
        {
            _packingSessionRepository = packingSessionRepository;
        }

        public List<PackingSessionAllRes> GetAllSessions()
        {
            var reval = new List<PackingSessionAllRes>();
            var data = _packingSessionRepository.GetAllSessions();
            foreach (DataRow row in data.Rows)
            {
                reval.Add(new PackingSessionAllRes
                {
                    Id = Convert.ToInt64(row["id"]),
                    Barcode = row["barcode"]?.ToString(),
                    LocalPath = row["local_path"]?.ToString(),
                    CreatedAt = Convert.ToDateTime(row["created_at"]),
                    YoutubeUrl = row["youtube_url"]?.ToString()
                });
            }
            return reval;
        }

        public void InsertSession(string barcode, string videoPath)
        {
            _packingSessionRepository.InsertSession(barcode, videoPath);
        }

        public void UpdateSession(string barcode, string youtubeUrl)
        {
            _packingSessionRepository.UpdateSession(barcode, youtubeUrl);
        }

        public bool IsBarcodeExists(string barcode)
        {
            return _packingSessionRepository.IsBarcodeExists(barcode);
        }

        public async Task<List<PackingSessionAllRes>> GetHistoryRecordByBarcode(string? barcode, DateTime? fromDate, DateTime? toDate)
        {
            var reval = new List<PackingSessionAllRes>();
            var data = await _packingSessionRepository.GetHistoryRecordByBarcode(barcode, fromDate, toDate);
            foreach (DataRow row in data.Rows)
            {
                reval.Add(new PackingSessionAllRes
                {
                    Id = Convert.ToInt64(row["id"]),
                    Barcode = row["barcode"]?.ToString(),
                    LocalPath = row["local_path"]?.ToString(),
                    CreatedAt = Convert.ToDateTime(row["created_at"]),
                    YoutubeUrl = row["youtube_url"]?.ToString()
                });
            }
            return reval;
        }
    }
}