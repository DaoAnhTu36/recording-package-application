using SellerCenter.Infrastructure;
using SellerCenter.Infrastructure.Models;

namespace SellerCenter.Service.Implementation
{
    public class ProductService : Service<ProductModel>, IProductService
    {
        private readonly IProductRepository _repository;

        public ProductService(IProductRepository repository) : base(repository)
        {
            _repository = repository;
        }

        public ProductModel? GetByProductCode(string productCode)
        {
            return _repository.GetByProductCode(productCode);
        }
    }
}