using MySql.Data.MySqlClient;
using SellerCenter.Infrastructure.Models;
using System.Data;

namespace SellerCenter.Infrastructure
{
    public class ProductRepository
    {
        private DatabaseRepository _db;

        public ProductRepository()
        {
            _db = new DatabaseRepository();
        }

        public DataTable GetAll()
        {
            using var conn = _db.GetConnection();
            using var cmd = new MySqlCommand(@"
            SELECT id, product_name, product_code, description, image_url, video_url, created_at, updated_at
            FROM products
            ORDER BY id DESC;", conn);

            using var adapter = new MySqlDataAdapter(cmd);
            var table = new DataTable();
            adapter.Fill(table);
            return table;
        }

        public Product? GetById(long id)
        {
            using var conn = _db.GetConnection();
            using var cmd = new MySqlCommand(@"
            SELECT id, product_name, product_code, description, image_url, video_url
            FROM products
            WHERE id = @id;", conn);

            cmd.Parameters.AddWithValue("@id", id);

            conn.Open();
            using var reader = cmd.ExecuteReader();

            if (!reader.Read()) return null;

            return new Product
            {
                Id = reader.GetInt64("id"),
                ProductName = reader.GetString("product_name"),
                ProductCode = reader.GetString("product_code"),
                Description = reader["description"]?.ToString(),
                ImageUrl = reader["image_url"]?.ToString(),
                VideoUrl = reader["video_url"]?.ToString()
            };
        }

        public long Insert(Product product)
        {
            using var conn = _db.GetConnection();
            using var cmd = new MySqlCommand(@"
            INSERT INTO products
            (
                product_name,
                product_code,
                description,
                image_url,
                video_url
            )
            VALUES
            (
                @product_name,
                @product_code,
                @description,
                @image_url,
                @video_url
            );
            SELECT LAST_INSERT_ID();", conn);

            cmd.Parameters.AddWithValue("@product_name", product.ProductName);
            cmd.Parameters.AddWithValue("@product_code", product.ProductCode);
            cmd.Parameters.AddWithValue("@description", product.Description);
            cmd.Parameters.AddWithValue("@image_url", product.ImageUrl);
            cmd.Parameters.AddWithValue("@video_url", product.VideoUrl);

            conn.Open();
            return Convert.ToInt64(cmd.ExecuteScalar());
        }

        public bool Update(Product product)
        {
            using var conn = _db.GetConnection();
            using var cmd = new MySqlCommand(@"
            UPDATE products
            SET
                product_name = @product_name,
                product_code = @product_code,
                description = @description,
                image_url = @image_url,
                video_url = @video_url
            WHERE id = @id;", conn);

            cmd.Parameters.AddWithValue("@id", product.Id);
            cmd.Parameters.AddWithValue("@product_name", product.ProductName);
            cmd.Parameters.AddWithValue("@product_code", product.ProductCode);
            cmd.Parameters.AddWithValue("@description", product.Description);
            cmd.Parameters.AddWithValue("@image_url", product.ImageUrl);
            cmd.Parameters.AddWithValue("@video_url", product.VideoUrl);

            conn.Open();
            return cmd.ExecuteNonQuery() > 0;
        }

        public bool Delete(long id)
        {
            using var conn = _db.GetConnection();
            using var cmd = new MySqlCommand(@"
            DELETE FROM products
            WHERE id = @id;", conn);

            cmd.Parameters.AddWithValue("@id", id);

            conn.Open();
            return cmd.ExecuteNonQuery() > 0;
        }

        public DataTable Search(string keyword)
        {
            using var conn = _db.GetConnection();
            using var cmd = new MySqlCommand(@"
            SELECT id, product_name, product_code, description, image_url, video_url, created_at, updated_at
            FROM products
            WHERE product_name LIKE CONCAT('%', @keyword, '%')
            ORDER BY id DESC;", conn);

            cmd.Parameters.AddWithValue("@keyword", keyword);

            using var adapter = new MySqlDataAdapter(cmd);
            var table = new DataTable();
            adapter.Fill(table);
            return table;
        }

        public bool ExistsByCode(string productCode)
        {
            using var conn = _db.GetConnection();
            using var cmd = new MySqlCommand(@"SELECT 1 FROM products WHERE product_code = @product_code LIMIT 1;", conn);
            cmd.Parameters.AddWithValue("@product_code", productCode);
            conn.Open();
            var result = cmd.ExecuteScalar();
            return result != null;
        }
    }
}