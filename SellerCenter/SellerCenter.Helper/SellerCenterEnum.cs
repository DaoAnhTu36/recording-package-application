namespace SellerCenter.Helper
{
    public enum SellerCenterEnum
    {
    }

    public enum UploadStatusEnum
    {
        Pending = 0,     // Chưa upload
        Uploading = 1,   // Đang upload
        Success = 2,     // Thành công
        Failed = 3       // Thất bại
    }

    public enum SocialPlatformEnum
    {
        Facebook = 1,
        TikTok = 2,
        YouTube = 3,
        Shopee = 4,
        Zalo = 5
    }

    public enum MediaTypeEnum
    {
        Image = 1,
        Video = 2
    }

    public enum ProductStatusEnum
    {
        Draft = 0,        // Nháp
        Active = 1,       // Đang hiển thị
        Inactive = 2      // Ngừng sử dụng
    }

    public static class UrlConstants
    {
        public const string YouTubeBaseUrl = "https://www.youtube.com/watch?v=";
    }

    public static class CharacterConstants
    {
        public const string Separator = "{|}";
    }
}