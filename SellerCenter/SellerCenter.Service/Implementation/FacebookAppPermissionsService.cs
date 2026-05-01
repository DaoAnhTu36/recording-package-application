using SellerCenter.Infrastructure;
using SellerCenter.Infrastructure.Models;

namespace SellerCenter.Service.Implementation
{
    public class FacebookAppPermissionsService : Service<FacebookAppPermissionModel>, IFacebookAppPermissionsService
    {
        private readonly IFacebookAppPermissionsRepository _repository;

        public FacebookAppPermissionsService(IFacebookAppPermissionsRepository repository) : base(repository)
        {
            _repository = repository;
        }

        public async Task<List<FacebookAppPermissionWithAppNameModel>> GetWithAppName()
        {
            return await _repository.GetWithAppName();
        }
    }
}