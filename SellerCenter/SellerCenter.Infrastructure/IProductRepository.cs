using SellerCenter.Infrastructure.Models;

namespace SellerCenter.Infrastructure
{
    public interface IProductRepository : IRepository<ProductModel>
    {
        public ProductModel? GetByProductCode(string productCode);
    }
}