namespace SellerCenter.Service.DTO
{
    public class PackingSessionDTO
    {
    }

    public class PackingSessionAllRes
    {
        public long Id { get; set; }

        public string? Barcode { get; set; }

        public string? LocalPath { get; set; }

        public DateTime CreatedAt { get; set; }

        public string? YoutubeUrl { get; set; }
    }
}