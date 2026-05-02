using SellerCenter.Infrastructure;
using SellerCenter.Infrastructure.Models;

namespace SellerCenter.Service.Implementation
{
    public class MenuService : Service<MenuModel>, IMenuService
    {
        private readonly IMenuRepository _menuRepo;

        public MenuService(IMenuRepository menuRepo) : base(menuRepo)
        {
            _menuRepo = menuRepo;
        }

        public async Task<List<MenuViewModel>> GetAllWithParentName()
        {
            return await _menuRepo.GetAllWithParentName();
        }
    }
}