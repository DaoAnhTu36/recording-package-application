using SellerCenter.Infrastructure.Models;

namespace SellerCenter.Infrastructure
{
    public interface IFacebookAppPermissionsRepository : IRepository<FacebookAppPermissionModel>
    {
        public Task<List<FacebookAppPermissionWithAppNameModel>> GetWithAppName();
    }
}