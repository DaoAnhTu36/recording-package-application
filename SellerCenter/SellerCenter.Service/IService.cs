using SellerCenter.Infrastructure.Models;
using System.Data;

namespace SellerCenter.Service
{
    public interface IService<T> where T : IEntity
    {
        long Create(T entity);

        List<T> GetAllList();

        DataTable GetAll();

        T GetById(long id);

        bool Update(T entity);

        bool Delete(long id);

        bool IsExists(string tableName, string keyword, string columns);

        DataTable SearchByKey(string tableName, string keyword, params string[] columns);
    }
}