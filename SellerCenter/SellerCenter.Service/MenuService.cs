using SellerCenter.Infrastructure;
using SellerCenter.Infrastructure.Models;

namespace SellerCenter.Service
{
    public class MenuService
    {
        private readonly MenuRepository _repo;

        public MenuService()
        {
            _repo = new MenuRepository();
        }

        public long Create(MenuModel item)
        {
            if (string.IsNullOrWhiteSpace(item.MenuCode))
                throw new Exception("Mã menu không được để trống");

            if (string.IsNullOrWhiteSpace(item.MenuName))
                throw new Exception("Tên menu không được để trống");

            item.MenuCode = item.MenuCode.Trim().ToUpper();

            return _repo.Create(item);
        }

        public bool Update(MenuModel item)
        {
            if (item.Id <= 0)
                throw new Exception("ID menu không hợp lệ");

            item.MenuCode = item.MenuCode.Trim().ToUpper();

            return _repo.Update(item);
        }

        public List<MenuModel> GetAll()
        {
            return _repo.GetAll();
        }

        public List<MenuViewModel> GetAllWithParentName()
        {
            return _repo.GetAllWithParentName();
        }

        public List<MenuModel> GetActiveVisible()
        {
            return _repo.GetActiveVisible();
        }

        public bool Delete(long id)
        {
            return _repo.SoftDelete(id);
        }

        public MenuModel GetById(long id)
        {
            return _repo.GetById(id);
        }

        public MenuModel GetByCode(string menuCode)
        {
            return _repo.GetByCode(menuCode);
        }

        public List<MenuModel> GetByParentId(long? parentId)
        {
            return _repo.GetByParentId(parentId);
        }
    }
}