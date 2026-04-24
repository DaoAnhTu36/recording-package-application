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
        public string? Image_Url_1 { get; set; }
        public string? Image_Url_2 { get; set; }
        public string? Image_Url_3 { get; set; }
        public string? Image_Url_4 { get; set; }
        public string? Image_Url_5 { get; set; }
        public string? Video_Url { get; set; }
        public string? Hashtag { get; set; }
    }
}