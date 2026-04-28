namespace SellerCenter.Infrastructure.Models
{
    public class FacebookAppModel
    {
        public long Id { get; set; }
        public string? AppName { get; set; }
        public string? AppId { get; set; }
        public string? AppSecret { get; set; }
        public bool IsActive { get; set; }
    }
}