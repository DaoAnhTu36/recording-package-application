using Microsoft.Extensions.Options;
using MySql.Data.MySqlClient;
using SellerCenter.Infrastructure.Configs.Model;
using SellerCenter.Infrastructure.Models;

namespace SellerCenter.Infrastructure.Implementation
{
    public class ProductRepository : Repository<ProductModel>, IProductRepository
    {
        private readonly string _conn;

        public ProductRepository(IOptions<DatabaseConfig> dbConfig) : base(dbConfig.Value.ConnectionString!)
        {
            _conn = dbConfig.Value.ConnectionString!;
        }

        public ProductModel? GetByProductCode(string productCode)
        {
            using var conn = new MySqlConnection(_conn);
            using var cmd = new MySqlCommand(@"
            SELECT id, product_name, product_code, description, image_url, video_url
            FROM products
            WHERE product_code = @product_code;", conn);
            cmd.Parameters.AddWithValue("@product_code", productCode);
            conn.Open();
            using var reader = cmd.ExecuteReader();
            if (!reader.Read()) return null;
            return new ProductModel
            {
                Id = reader.GetInt64("id"),
                ProductName = reader.GetString("product_name"),
                ProductCode = reader.GetString("product_code"),
                Description = reader["description"]?.ToString(),
                ImageUrl = reader["image_url"]?.ToString(),
                VideoUrl = reader["video_url"]?.ToString()
            };
        }
    }
}