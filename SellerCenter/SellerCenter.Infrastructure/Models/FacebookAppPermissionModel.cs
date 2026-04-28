namespace SellerCenter.Infrastructure.Models
{
    public class FacebookAppPermissionModel
    {
        public long Id { get; set; }
        public long FacebookAppId { get; set; }
        public string? PermissionName { get; set; }
        public DateTime? CreatedAt { get; set; }
    }

    public class FacebookAppPermissionWithAppNameModel
    {
        public long Id { get; set; }
        public string? PermissionName { get; set; }
        public string? AppName { get; set; }
        public string? AppId { get; set; }
        public DateTime? CreatedAt { get; set; }
    }
}