using SellerCenter.Infrastructure.Models;

namespace SellerCenter.Service
{
    public interface IProductService : IService<ProductModel>
    {
        public ProductModel? GetByProductCode(string productCode);
    }
}