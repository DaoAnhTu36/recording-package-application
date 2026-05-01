using SellerCenter.Infrastructure;
using SellerCenter.Infrastructure.Models;

namespace SellerCenter.Service.Implementation
{
    public class EmployeeFacebookAppsService : Service<EmployeeFacebookAppModel>, IEmployeeFacebookAppsService
    {
        private readonly IEmployeeFacebookAppsRepository _repository;

        public EmployeeFacebookAppsService(IEmployeeFacebookAppsRepository repository) : base(repository)
        {
            _repository = repository;
        }
    }
}