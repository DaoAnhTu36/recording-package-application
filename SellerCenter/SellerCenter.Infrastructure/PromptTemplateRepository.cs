using MySql.Data.MySqlClient;
using SellerCenter.Infrastructure.Models;
using System.Data;

namespace SellerCenter.Infrastructure
{
    public class PromptTemplateRepository
    {
        private DatabaseRepository _db;

        public PromptTemplateRepository()
        {
            _db = new DatabaseRepository();
        }

        public DataTable GetAll()
        {
            using var conn = _db.GetConnection();
            using var cmd = new MySqlCommand(@"
            SELECT id, platform, post_type, template_content, is_active, created_at, updated_at
            FROM prompt_templates
            ORDER BY id DESC;", conn);

            using var adapter = new MySqlDataAdapter(cmd);
            var table = new DataTable();
            adapter.Fill(table);
            return table;
        }

        public PromptTemplate? GetById(long id)
        {
            using var conn = _db.GetConnection();
            using var cmd = new MySqlCommand(@"
            SELECT id, platform, post_type, template_content, is_active
            FROM prompt_templates
            WHERE id = @id;", conn);

            cmd.Parameters.AddWithValue("@id", id);

            conn.Open();
            using var reader = cmd.ExecuteReader();

            if (!reader.Read()) return null;

            return new PromptTemplate
            {
                Id = reader.GetInt64("id"),
                Platform = reader["platform"]?.ToString(),
                PostType = reader["post_type"]?.ToString(),
                TemplateContent = reader["template_content"]?.ToString(),
                IsActive = Convert.ToBoolean(reader["is_active"])
            };
        }

        public long Insert(PromptTemplate template)
        {
            using var conn = _db.GetConnection();
            using var cmd = new MySqlCommand(@"
            INSERT INTO prompt_templates
            (
                platform,
                post_type,
                template_content,
                is_active
            )
            VALUES
            (
                @platform,
                @post_type,
                @template_content,
                @is_active
            );
            SELECT LAST_INSERT_ID();", conn);

            cmd.Parameters.AddWithValue("@platform", template.Platform);
            cmd.Parameters.AddWithValue("@post_type", template.PostType);
            cmd.Parameters.AddWithValue("@template_content", template.TemplateContent);
            cmd.Parameters.AddWithValue("@is_active", template.IsActive);

            conn.Open();
            return Convert.ToInt64(cmd.ExecuteScalar());
        }

        public bool Update(PromptTemplate template)
        {
            using var conn = _db.GetConnection();
            using var cmd = new MySqlCommand(@"
            UPDATE prompt_templates
            SET
                platform = @platform,
                post_type = @post_type,
                template_content = @template_content,
                is_active = @is_active
            WHERE id = @id;", conn);

            cmd.Parameters.AddWithValue("@id", template.Id);
            cmd.Parameters.AddWithValue("@platform", template.Platform);
            cmd.Parameters.AddWithValue("@post_type", template.PostType);
            cmd.Parameters.AddWithValue("@template_content", template.TemplateContent);
            cmd.Parameters.AddWithValue("@is_active", template.IsActive);

            conn.Open();
            return cmd.ExecuteNonQuery() > 0;
        }

        public bool Delete(long id)
        {
            using var conn = _db.GetConnection();
            using var cmd = new MySqlCommand(@"
            DELETE FROM prompt_templates
            WHERE id = @id;", conn);

            cmd.Parameters.AddWithValue("@id", id);

            conn.Open();
            return cmd.ExecuteNonQuery() > 0;
        }

        public DataTable Search(string keyword)
        {
            using var conn = _db.GetConnection();
            using var cmd = new MySqlCommand(@"
            SELECT id, platform, post_type, template_content, is_active, created_at, updated_at
            FROM prompt_templates
            WHERE
                platform LIKE CONCAT('%', @keyword, '%')
                OR post_type LIKE CONCAT('%', @keyword, '%')
                OR template_content LIKE CONCAT('%', @keyword, '%')
            ORDER BY id DESC;", conn);

            cmd.Parameters.AddWithValue("@keyword", keyword);

            using var adapter = new MySqlDataAdapter(cmd);
            var table = new DataTable();
            adapter.Fill(table);
            return table;
        }
    }
}