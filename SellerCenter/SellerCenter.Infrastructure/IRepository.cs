using SellerCenter.Infrastructure.Models;
using System.Data;

namespace SellerCenter.Infrastructure
{
    public interface IRepository<T> where T : IEntity
    {
        long Create(T entity);

        List<T> GetAllList();

        DataTable GetAll();

        DataTable SearchByKey(string tableName, string keyword, params string[] columns);

        bool IsExists(string tableName, string keyword, string columns);

        bool IsExistMulti(string tableName, Dictionary<string, object> keyValues);

        List<T> GetMulti<T>(string tableName, Dictionary<string, object> keyValues);

        T GetById(long id);

        bool Update(T entity);

        bool Delete(long id);
    }
}