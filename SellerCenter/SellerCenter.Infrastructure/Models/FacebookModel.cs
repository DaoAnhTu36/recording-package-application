namespace SellerCenter.Infrastructure.Models
{
    public class FacebookErrorResponse
    {
        public FacebookError? error { get; set; }
    }

    public class FacebookError
    {
        public string? message { get; set; }
        public string? type { get; set; }
        public int? code { get; set; }
        public int? error_subcode { get; set; }
        public string? fbtrace_id { get; set; }
    }
}