using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace SellerCenter.Infrastructure.Models
{
    [Table("facebook_apps")]
    public class FacebookAppModel : IEntity
    {
        [JsonPropertyName("id")]
        public long Id { get; set; }

        [JsonPropertyName("app_name")]
        public string? AppName { get; set; }

        [JsonPropertyName("app_id")]
        public string? AppId { get; set; }

        [JsonPropertyName("app_secret")]
        public string? AppSecret { get; set; }

        [JsonPropertyName("is_active")]
        public bool IsActive { get; set; }

        [JsonPropertyName("created_at")]
        public DateTime CreatedAt { get; set; }

        [JsonPropertyName("updated_at")]
        public DateTime UpdatedAt { get; set; }
    }
}