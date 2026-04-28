using SellerCenter.Infrastructure;
using SellerCenter.Infrastructure.Models;

namespace SellerCenter.Service
{
    public class FacebookAppPermissionsService
    {
        private readonly FacebookAppPermissionRepository _facebookAppPermissionRepository;

        public FacebookAppPermissionsService()
        {
            _facebookAppPermissionRepository = new FacebookAppPermissionRepository();
        }

        public long Create(long facebookAppId, string permissionName)
        {
            var item = new FacebookAppPermissionModel
            {
                FacebookAppId = facebookAppId,
                PermissionName = permissionName
            };
            return _facebookAppPermissionRepository.Create(item);
        }

        public List<FacebookAppPermissionModel> GetByFacebookAppId(long facebookAppId)
        {
            return _facebookAppPermissionRepository.GetByFacebookAppId(facebookAppId);
        }

        public List<FacebookAppPermissionModel> GetAll()
        {
            return _facebookAppPermissionRepository.GetAll();
        }

        public List<FacebookAppPermissionWithAppNameModel> GetWithAppName()
        {
            return _facebookAppPermissionRepository.GetWithAppName();
        }

        public bool Update(FacebookAppPermissionModel model)
        {
            return _facebookAppPermissionRepository.Update(model);
        }

        public bool Delete(long id)
        {
            return _facebookAppPermissionRepository.Delete(id);
        }

        public bool DeleteByFacebookAppId(long facebookAppId)
        {
            return _facebookAppPermissionRepository.DeleteByFacebookAppId(facebookAppId);
        }
    }
}