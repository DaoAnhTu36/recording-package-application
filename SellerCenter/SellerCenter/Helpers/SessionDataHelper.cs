using SellerCenter.Helper;
using SellerCenter.Infrastructure.Models;

namespace SellerCenter.Helpers
{
    public static class SessionDataHelper
    {
        public static EmployeeModel CurrentUser()
        {
            return (EmployeeModel)SessionManager.CurrentUser!;
        }
    }
}