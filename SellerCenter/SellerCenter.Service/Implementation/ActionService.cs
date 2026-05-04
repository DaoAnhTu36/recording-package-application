using SellerCenter.Infrastructure;
using SellerCenter.Infrastructure.Models;

namespace SellerCenter.Service.Implementation
{
    public class ActionService : Service<ActionModel>, IActionService
    {
        private readonly IActionRepository _repository;

        public ActionService(IActionRepository repository) : base(repository)
        {
            _repository = repository;
        }
    }
}