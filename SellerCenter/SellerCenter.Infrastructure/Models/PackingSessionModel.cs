namespace SellerCenter.Infrastructure.Models
{
    public class PackingSessionModel : IEntity
    {
        public long Id { get; set; }
        public string? Barcode { get; set; }
        public string? LocalPath { get; set; }
        public DateTime CreatedAt { get; set; }
        public string? YoutubeUrl { get; set; }
    }
}