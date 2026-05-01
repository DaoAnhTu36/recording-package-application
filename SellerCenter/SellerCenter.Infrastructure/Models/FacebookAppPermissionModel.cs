using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace SellerCenter.Infrastructure.Models
{
    [Table("facebook_app_permissions")]
    public class FacebookAppPermissionModel : IEntity
    {
        [JsonPropertyName("id")]
        public long Id { get; set; }

        [JsonPropertyName("facebook_app_id")]
        public long FacebookAppId { get; set; }

        [JsonPropertyName("permission_name")]
        public string? PermissionName { get; set; }

        [JsonPropertyName("created_at")]
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