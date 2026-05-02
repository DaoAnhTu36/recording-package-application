using SellerCenter.Infrastructure.Models;
using System.Data;

namespace SellerCenter.Infrastructure
{
    public interface IPostContentRepository : IRepository<PostContentModel>
    {
        public DataTable Search(string keyword);
    }
}