using SellerCenter.Infrastructure;
using SellerCenter.Infrastructure.Models;

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

        public List<T> GetAll()
        {
            return _repo.GetAll();
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
    }
}