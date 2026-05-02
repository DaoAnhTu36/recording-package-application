using SellerCenter.Infrastructure.Models;

namespace SellerCenter.Infrastructure
{
    public interface IMenuRepository : IRepository<MenuModel>
    {
        public Task<List<MenuViewModel>> GetAllWithParentName();

        public Task<List<MenuModel>> GetActiveVisible();

        public Task<MenuModel> GetByCode(string menuCode);

        public Task<List<MenuModel>> GetByParentId(long? parentId);

        public Task<bool> SoftDelete(long id);
    }
}