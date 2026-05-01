using SellerCenter.Infrastructure;
using SellerCenter.Infrastructure.Models;

namespace SellerCenter.Service
{
    public interface IFacebookAppPermissionsService : IService<FacebookAppPermissionModel>
    {
        public Task<List<FacebookAppPermissionWithAppNameModel>> GetWithAppName();
    }
}