using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace SellerCenter.Infrastructure.Models
{
    [Table("auth_actions")]
    public class ActionModel : IEntity
    {
        [JsonPropertyName("id")]
        public long Id { get; set; }

        [JsonPropertyName("action_key")]
        public string? ActionKey { get; set; }

        [JsonPropertyName("action_name")]
        public string? ActionName { get; set; }

        [JsonPropertyName("is_active")]
        public bool IsActive { get; set; }
    }
}