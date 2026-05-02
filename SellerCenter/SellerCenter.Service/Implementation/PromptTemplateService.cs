using SellerCenter.Infrastructure;
using SellerCenter.Infrastructure.Models;

namespace SellerCenter.Service.Implementation
{
    public class PromptTemplateService : Service<PromptTemplateModel>, IPromptTemplateService
    {
        private readonly IPromptTemplateRepository _repository;

        public PromptTemplateService(IPromptTemplateRepository repository) : base(repository)
        {
            _repository = repository;
        }
    }
}