using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace SellerCenter.Infrastructure.Models
{
    [Table("employee_facebook_apps")]
    public class EmployeeFacebookAppModel : IEntity
    {
        [JsonPropertyName("id")]
        public long Id { get; set; }

        [JsonPropertyName("employee_id")]
        public long EmployeeId { get; set; }

        [JsonPropertyName("facebook_app_id")]
        public long FacebookAppId { get; set; }

        [JsonPropertyName("can_view")]
        public bool CanView { get; set; }

        [JsonPropertyName("can_get_token")]
        public bool CanGetToken { get; set; }

        [JsonPropertyName("can_post")]
        public bool CanPost { get; set; }

        [JsonPropertyName("can_update")]
        public bool CanUpdate { get; set; }

        [JsonPropertyName("can_delete")]
        public bool CanDelete { get; set; }

        [JsonPropertyName("assigned_by")]
        public long? AssignedBy { get; set; }

        [JsonPropertyName("assigned_at")]
        public DateTime AssignedAt { get; set; }
    }
}