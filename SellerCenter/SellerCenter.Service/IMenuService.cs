using SellerCenter.Infrastructure.Models;

namespace SellerCenter.Service
{
    public interface IMenuService : IService<MenuModel>
    {
        public Task<List<MenuViewModel>> GetAllWithParentName();
    }
}