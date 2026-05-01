using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace SellerCenter.Infrastructure.Models
{
    [Table("menus")]
    public class MenuModel : IEntity
    {
        [JsonPropertyName("id")]
        public long Id { get; set; }

        [JsonPropertyName("menu_code")]
        public string? MenuCode { get; set; }

        [JsonPropertyName("menu_name")]
        public string? MenuName { get; set; }

        [JsonPropertyName("parent_id")]
        public long? ParentId { get; set; }

        [JsonPropertyName("form_name")]
        public string? FormName { get; set; }

        [JsonPropertyName("route_key")]
        public string? RouteKey { get; set; }

        [JsonPropertyName("icon_name")]
        public string? IconName { get; set; }

        [JsonPropertyName("sort_order")]
        public int SortOrder { get; set; }

        [JsonPropertyName("sort_order")]
        public string? PermissionCode { get; set; }

        [JsonPropertyName("is_active")]
        public bool IsActive { get; set; }

        [JsonPropertyName("is_visible")]
        public bool IsVisible { get; set; }

        [JsonPropertyName("created_at")]
        public DateTime CreatedAt { get; set; }

        [JsonPropertyName("updated_at")]
        public DateTime? UpdatedAt { get; set; }
    }

    public class MenuViewModel
    {
        public long Id { get; set; }
        public string? MenuCode { get; set; }
        public string? MenuName { get; set; }
        public long? ParentId { get; set; }
        public string? ParentName { get; set; }
        public string? FormName { get; set; }
        public string? RouteKey { get; set; }
        public string? IconName { get; set; }
        public int SortOrder { get; set; }
        public string? PermissionCode { get; set; }
        public bool IsActive { get; set; }
        public bool IsVisible { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime? UpdatedAt { get; set; }
    }
}