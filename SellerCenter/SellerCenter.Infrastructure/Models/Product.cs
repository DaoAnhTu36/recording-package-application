namespace SellerCenter.Infrastructure.Models
{
    public class Product
    {
        public long Id { get; set; }
        public string? ProductName { get; set; }
        public string? ProductCode { get; set; }
        public string? Description { get; set; }
        public string? ImageUrl { get; set; }
        public string? VideoUrl { get; set; }
    }
}