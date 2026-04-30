namespace SellerCenter.Infrastructure.Models
{
    public class MenuModel
    {
        public long Id { get; set; }
        public string? MenuCode { get; set; }
        public string? MenuName { get; set; }
        public long? ParentId { get; set; }
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