namespace SellerCenter.Infrastructure.Models
{
    public class PostContentModel
    {
        public int Id { get; set; }
        public string? ProductCode { get; set; }
        public string? Title { get; set; }
        public string? Content { get; set; }
        public string? Hook { get; set; }
        public string? ImageUrl1 { get; set; }
        public string? ImageUrl2 { get; set; }
        public string? ImageUrl3 { get; set; }
        public string? ImageUrl4 { get; set; }
        public string? ImageUrl5 { get; set; }
        public string? VideoUrl { get; set; }
        public string? Hashtag { get; set; }
    }
}