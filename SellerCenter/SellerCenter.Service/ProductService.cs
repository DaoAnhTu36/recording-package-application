using SellerCenter.Infrastructure;
using SellerCenter.Infrastructure.Models;
using System.Data;

namespace SellerCenter.Service
{
    public class ProductService
    {
        private ProductRepository _instance;

        public ProductService()
        {
            _instance = new ProductRepository();
        }

        public DataTable GetAll()
        {
            return _instance.GetAll();
        }

        public ProductModel? GetById(long id)
        {
            return _instance.GetById(id);
        }

        public long Insert(ProductModel product)
        {
            return _instance.Insert(product);
        }

        public bool Update(ProductModel product)
        {
            return _instance.Update(product);
        }

        public bool Delete(long id)
        {
            return _instance.Delete(id);
        }

        public DataTable Search(string keyword)
        {
            return _instance.Search(keyword);
        }

        public bool ExistsByCode(string productCode)
        {
            return _instance.ExistsByCode(productCode);
        }

        public ProductModel? GetByProductCode(string productCode)
        {
            return _instance.GetByProductCode(productCode);
        }
    }
}