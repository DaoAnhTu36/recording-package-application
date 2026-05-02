namespace SellerCenter.Infrastructure.Configs.Model
{
    public class AppSettingConfig
    {
        public DatabaseConfig? DatabaseConfig { get; set; }
        public ChatGPTConfig? ChatGPTConfig { get; set; }
        public FacebookConfig? FacebookConfig { get; set; }
        public ShopeeConfig? ShopeeConfig { get; set; }
    }
}