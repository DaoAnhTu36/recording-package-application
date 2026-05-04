using SellerCenter.Helper;
using SellerCenter.Infrastructure;
using SellerCenter.Infrastructure.Models;

namespace SellerCenter.Service.Implementation
{
    public class EmployeeService : Service<EmployeeModel>, IEmployeeService
    {
        private readonly IEmployeeRepository _employeeRepository;

        public EmployeeService(IEmployeeRepository employeeRepository) : base(employeeRepository)
        {
            _employeeRepository = employeeRepository;
        }

        public async Task<EmployeeModel> Login(string login, string password)
        {
            var user = await _employeeRepository.Login(login);
            if (user == null)
                return null!;
            if (!PasswordHelper.VerifyPassword(password, user.PasswordHash!))
                return null!;
            var token = await _employeeRepository.CreateSession(user.Id, IPHelper.GetLocalIp());
            SessionManager.SetSession(user, token);
            SessionManager.SetAppId("1220008870022055");
            return user;
        }

        public async Task Logout()
        {
            await _employeeRepository.Logout();
        }

        public async Task<bool> UpdatePassword(long id, string newPassword)
        {
            return await _employeeRepository.UpdatePassword(id, newPassword);
        }

        public async Task<bool> UpdateRole(long id, long roleId)
        {
            return await _employeeRepository.UpdateRole(id, roleId);
        }
    }
}