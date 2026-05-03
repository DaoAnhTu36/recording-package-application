using MySql.Data.MySqlClient;
using SellerCenter.Infrastructure.Models;

namespace SellerCenter.Infrastructure
{
    public interface IPermissionRepository : IRepository<PermissionModel>
    {
    }
}