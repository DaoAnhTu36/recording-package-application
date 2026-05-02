namespace SellerCenter.Infrastructure.Models
{
    public class ChatGPTModel
    {
        public List<ItemResponse>? Data { get; set; }
    }

    public class ItemResponse
    {
        public string? Title { get; set; }
        public string? Content { get; set; }
        public string? Hook { get; set; }
        public string? Hashtag { get; set; }
    }
}