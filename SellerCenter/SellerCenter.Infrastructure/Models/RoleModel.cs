using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace SellerCenter.Infrastructure.Models
{
    [Table("auth_roles")]
    public class RoleModel : IEntity
    {
        [JsonPropertyName("id")]
        public long Id { get; set; }

        [JsonPropertyName("role_code")]
        public string? RoleCode { get; set; }

        [JsonPropertyName("role_name")]
        public string? RoleName { get; set; }

        [JsonPropertyName("description")]
        public string? Description { get; set; }

        [JsonPropertyName("is_active")]
        public bool IsActive { get; set; }

        [JsonPropertyName("created_at")]
        public DateTime CreatedAt { get; set; }

        [JsonPropertyName("updated_at")]
        public DateTime UpdatedAt { get; set; }
    }
}