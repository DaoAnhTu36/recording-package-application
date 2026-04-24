using MySql.Data.MySqlClient;
using SellerCenter.Infrastructure.Models;
using System.Data;

namespace SellerCenter.Infrastructure
{
    public class PostContentRepository
    {
        private DatabaseRepository _db;

        public PostContentRepository()
        {
            _db = new DatabaseRepository();
        }

        public DataTable GetAll()
        {
            using var conn = _db.GetConnection();
            using var cmd = new MySqlCommand("SELECT id, product_code, title, content, hook, image_url_1, image_url_2, image_url_3, image_url_4, image_url_5, video_url, hashtag, created_at, updated_at FROM post_content ORDER BY id DESC", conn);
            using var adapter = new MySqlDataAdapter(cmd);

            var dt = new DataTable();
            adapter.Fill(dt);
            return dt;
        }

        public int Insert(PostContentModel item)
        {
            using var conn = _db.GetConnection();

            string sql = @"
                INSERT INTO post_content
                (product_code, title, content, hook, image_url_1, image_url_2, image_url_3, image_url_4, image_url_5, video_url, hashtag, created_at, updated_at)
                VALUES
                (@product_code, @title, @content, @hook, @image_url_1, @image_url_2, @image_url_3, @image_url_4, @image_url_5, @video_url, @hashtag, NOW(), NOW());

                SELECT LAST_INSERT_ID();";

            using var cmd = new MySqlCommand(sql, conn);
            AddParams(cmd, item);

            conn.Open();
            return Convert.ToInt32(cmd.ExecuteScalar());
        }

        public bool Update(PostContentModel item)
        {
            using var conn = _db.GetConnection();

            string sql = @"
                UPDATE post_content
                SET
                    product_code = @product_code,
                    title = @title,
                    content = @content,
                    hook = @hook,
                    image_url_1 = @image_url_1,
                    image_url_2 = @image_url_2,
                    image_url_3 = @image_url_3,
                    image_url_4 = @image_url_4,
                    image_url_5 = @image_url_5,
                    video_url = @video_url,
                    hashtag = @hashtag,
                    updated_at = NOW()
                WHERE id = @id;";

            using var cmd = new MySqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("@id", item.Id);
            AddParams(cmd, item);

            conn.Open();
            return cmd.ExecuteNonQuery() > 0;
        }

        public bool Delete(int id)
        {
            using var conn = _db.GetConnection();

            string sql = "DELETE FROM post_content WHERE id = @id";

            using var cmd = new MySqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("@id", id);

            conn.Open();
            return cmd.ExecuteNonQuery() > 0;
        }

        public DataTable Search(string keyword)
        {
            using var conn = _db.GetConnection();
            using var cmd = new MySqlCommand(@"
            SELECT id, product_code, title, content, hook, image_url_1, image_url_2, image_url_3, image_url_4, image_url_5, video_url, hashtag, created_at, updated_at
            FROM post_content
            WHERE
                title LIKE @keyword
                OR product_code LIKE @keyword
            ORDER BY id DESC;", conn);
            cmd.Parameters.AddWithValue("@keyword", $"%{keyword}%");
            using var adapter = new MySqlDataAdapter(cmd);
            var table = new DataTable();
            adapter.Fill(table);
            return table;
        }

        public PostContentModel? GetById(long id)
        {
            using var conn = _db.GetConnection();
            using var cmd = new MySqlCommand(@"
            SELECT id, product_code, title, content, hook, image_url_1, image_url_2, image_url_3, image_url_4, image_url_5, video_url, hashtag, created_at, updated_at FROM post_content
            WHERE id = @id;", conn);

            cmd.Parameters.AddWithValue("@id", id);

            conn.Open();
            using var reader = cmd.ExecuteReader();

            if (!reader.Read()) return null;

            return new PostContentModel
            {
                Id = reader.GetInt32("id"),
                Title = reader.GetString("title"),
                ProductCode = reader.GetString("product_code"),
                Content = reader["content"]?.ToString(),
                Hook = reader["hook"]?.ToString(),
                ImageUrl1 = reader["image_url_1"]?.ToString(),
                ImageUrl2 = reader["image_url_2"]?.ToString(),
                ImageUrl3 = reader["image_url_3"]?.ToString(),
                ImageUrl4 = reader["image_url_4"]?.ToString(),
                ImageUrl5 = reader["image_url_5"]?.ToString(),
                VideoUrl = reader["video_url"]?.ToString(),
                Hashtag = reader["hashtag"]?.ToString()
            };
        }

        private void AddParams(MySqlCommand cmd, PostContentModel item)
        {
            cmd.Parameters.AddWithValue("@product_code", item.ProductCode ?? "");
            cmd.Parameters.AddWithValue("@title", item.Title ?? "");
            cmd.Parameters.AddWithValue("@content", item.Content ?? "");
            cmd.Parameters.AddWithValue("@hook", item.Hook ?? "");
            cmd.Parameters.AddWithValue("@image_url_1", item.ImageUrl1 ?? "");
            cmd.Parameters.AddWithValue("@image_url_2", item.ImageUrl2 ?? "");
            cmd.Parameters.AddWithValue("@image_url_3", item.ImageUrl3 ?? "");
            cmd.Parameters.AddWithValue("@image_url_4", item.ImageUrl4 ?? "");
            cmd.Parameters.AddWithValue("@image_url_5", item.ImageUrl5 ?? "");
            cmd.Parameters.AddWithValue("@video_url", item.VideoUrl ?? "");
            cmd.Parameters.AddWithValue("@hashtag", item.Hashtag ?? "");
        }
    }
}