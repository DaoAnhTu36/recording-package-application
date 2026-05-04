using SellerCenter.Infrastructure.Models;

namespace SellerCenter.Service
{
    public interface IEmployeeService : IService<EmployeeModel>
    {
        public Task<EmployeeModel> Login(string login, string password);

        public Task Logout();

        public Task<bool> UpdatePassword(long id, string newPassword);

        public Task<bool> UpdateRole(long id, long roleId);
    }
}