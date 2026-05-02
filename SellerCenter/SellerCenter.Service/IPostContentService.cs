using SellerCenter.Infrastructure.Models;
using System.Data;

namespace SellerCenter.Service
{
    public interface IPostContentService : IService<PostContentModel>
    {
        public DataTable Search(string keyword);
    }
}