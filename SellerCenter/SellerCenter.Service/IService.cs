using SellerCenter.Infrastructure.Models;

namespace SellerCenter.Service
{
    public interface IService<T> where T : IEntity
    {
        long Create(T entity);

        List<T> GetAll();

        T GetById(long id);

        bool Update(T entity);

        bool Delete(long id);
    }
}