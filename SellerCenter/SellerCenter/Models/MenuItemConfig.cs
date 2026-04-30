namespace SellerCenter.Models
{
    public class MenuItemConfig
    {
        public long Id { get; set; }
        public string? Title { get; set; }
        public string? Form { get; set; }
        public List<MenuItemConfig>? Children { get; set; }
    }
}