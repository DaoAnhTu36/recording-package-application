using SellerCenter.Infrastructure;
using SellerCenter.Infrastructure.Models;
using System.Data;

namespace SellerCenter.Service.Implementation
{
    public class Service<T> : IService<T> where T : class, IEntity, new()
    {
        private readonly IRepository<T> _repo;

        public Service(IRepository<T> repo)
        {
            _repo = repo;
        }

        public long Create(T entity)
        {
            return _repo.Create(entity);
        }

        public List<T> GetAllList()
        {
            return _repo.GetAllList();
        }

        public DataTable GetAll()
        {
            return _repo.GetAll();
        }

        public DataTable SearchByKey(string tableName, string keyword, params string[] columns)
        {
            return _repo.SearchByKey(tableName, keyword, columns);
        }

        public bool IsExists(string tableName, string keyword, string columns)
        {
            return _repo.IsExists(tableName, keyword, columns);
        }

        public bool IsExistMulti(string tableName, Dictionary<string, object> keyValues)
        {
            return _repo.IsExistMulti(tableName, keyValues);
        }

        public T GetById(long id)
        {
            return _repo.GetById(id);
        }

        public bool Update(T entity)
        {
            return _repo.Update(entity);
        }

        public bool Delete(long id)
        {
            return _repo.Delete(id);
        }

        public List<T> GetMulti<T>(string tableName, Dictionary<string, object> keyValues)
        {
            return _repo.GetMulti<T>(tableName, keyValues);
        }
    }
}