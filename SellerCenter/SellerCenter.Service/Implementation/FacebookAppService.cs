using SellerCenter.Infrastructure;
using SellerCenter.Infrastructure.Models;

namespace SellerCenter.Service.Implementation
{
    public class FacebookAppService : Service<FacebookAppModel>, IFacebookAppService
    {
        private readonly IFacebookAppsRepository _repository;

        public FacebookAppService(IFacebookAppsRepository repository) : base(repository)
        {
            _repository = repository;
        }
    }
}