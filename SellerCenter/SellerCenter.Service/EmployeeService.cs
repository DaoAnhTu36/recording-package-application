using SellerCenter.Helper;
using SellerCenter.Infrastructure;
using SellerCenter.Infrastructure.Models;

namespace SellerCenter.Service
{
    public class EmployeeService
    {
        private readonly EmployeeRepository _employeeRepository;

        public EmployeeService()
        {
            _employeeRepository = new EmployeeRepository();
        }

        public EmployeeModel Login(string login, string password)
        {
            var user = _employeeRepository.Login(login);
            if (user == null)
                return null!;
            if (!PasswordHelper.VerifyPassword(password, user.PasswordHash!))
                return null!;
            var token = _employeeRepository.CreateSession(user.Id, IPHelper.GetLocalIp());
            SessionManager.SetSession(user, token);
            SessionManager.SetAppId("1220008870022055");
            return user;
        }

        public void Logout()
        {
            _employeeRepository.Logout();
        }

        public long Create(EmployeeModel item)
        {
            return _employeeRepository.Create(item);
        }

        public List<EmployeeModel> GetAll()
        {
            return _employeeRepository.GetAll();
        }

        public EmployeeModel GetById(long id)
        {
            return _employeeRepository.GetById(id);
        }

        public bool Update(EmployeeModel item)
        {
            return _employeeRepository.Update(item);
        }

        public bool UpdatePassword(long id, string newPassword)
        {
            return _employeeRepository.UpdatePassword(id, newPassword);
        }

        public bool Delete(long id)
        {
            return _employeeRepository.Delete(id);
        }
    }
}