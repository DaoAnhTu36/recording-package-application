using SellerCenter.Infrastructure.Models;

namespace SellerCenter.Infrastructure
{
    public interface IEmployeeRepository : IRepository<EmployeeModel>
    {
        public Task<EmployeeModel> Login(string login);

        public Task<string> CreateSession(long userId, string ipLocal);

        public Task Logout();

        public Task<bool> UpdatePassword(long id, string newPassword);
    }
}