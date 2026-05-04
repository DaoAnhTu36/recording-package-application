using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace SellerCenter.Infrastructure.Models
{
    [Table("role_permissions")]
    public class RolePermissionModel : IEntity
    {
        [JsonPropertyName("id")]
        public long Id { get; set; }

        [JsonPropertyName("role_id")]
        public long RoleId { get; set; }

        [JsonPropertyName("permission_id")]
        public long PermissionId { get; set; }

        [JsonPropertyName("is_active")]
        public bool IsActive { get; set; }
    }
}