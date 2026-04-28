using SellerCenter.Infrastructure;
using SellerCenter.Infrastructure.Models;

namespace SellerCenter.Service
{
    public class FacebookAppsService
    {
        private readonly FacebookAppModelsRepository _repository;

        public FacebookAppsService()
        {
            _repository = new FacebookAppModelsRepository();
        }

        public long Create(string appName, string appId, string appSecret, bool isActive)
        {
            var model = new FacebookAppModel
            {
                AppName = appName,
                AppId = appId,
                AppSecret = appSecret,
                IsActive = isActive
            };
            return _repository.Create(model);
        }

        public List<FacebookAppModel> GetAll()
        {
            return _repository.GetAll();
        }

        public FacebookAppModel GetById(long id)
        { return _repository.GetById(id); }

        public bool Update(FacebookAppModel model)
        {
            return _repository.Update(model);
        }

        public bool Delete(long id)
        {
            return _repository.Delete(id);
        }
    }
}