namespace SellerCenter.Infrastructure.Models
{
    public class PromptTemplateModel
    {
        public long Id { get; set; }
        public string? Platform { get; set; }
        public string? PostType { get; set; }
        public string? TemplateContent { get; set; }
        public string? title { get; set; }
        public bool IsActive { get; set; }
    }
}