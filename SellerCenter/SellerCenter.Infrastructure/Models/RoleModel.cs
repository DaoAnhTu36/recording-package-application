namespace SellerCenter.Infrastructure.Models
{
    public class RoleModel : IEntity
    {
        public long Id { get; set; }
        public string? RoleCode { get; set; }
        public string? RoleName { get; set; }
        public string? Description { get; set; }
        public bool IsActive { get; set; }
    }
}