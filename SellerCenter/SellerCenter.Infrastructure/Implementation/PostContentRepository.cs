using Microsoft.Extensions.Options;
using MySql.Data.MySqlClient;
using SellerCenter.Infrastructure.Configs.Model;
using SellerCenter.Infrastructure.Models;
using System.Data;

namespace SellerCenter.Infrastructure.Implementation
{
    public class PostContentRepository : Repository<PostContentModel>, IPostContentRepository
    {
        private readonly string _conn;

        public PostContentRepository(IOptions<DatabaseConfig> dbConfig) : base(dbConfig.Value.ConnectionString!)
        {
            _conn = dbConfig.Value.ConnectionString!;
        }
        public DataTable Search(string keyword)
        {
            using var conn = new MySqlConnection(_conn);
            using var cmd = new MySqlCommand(@"
            SELECT id, product_code, title, content, hook, image_url, video_url, hashtag, created_at, updated_at
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
    }
}