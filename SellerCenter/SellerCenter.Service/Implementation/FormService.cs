using SellerCenter.Infrastructure;
using SellerCenter.Infrastructure.Models;

namespace SellerCenter.Service.Implementation
{
    public class FormService : Service<FormModel>, IFormService
    {
        private readonly IFormRepository _repository;

        public FormService(IFormRepository repository) : base(repository)
        {
            _repository = repository;
        }
    }
}