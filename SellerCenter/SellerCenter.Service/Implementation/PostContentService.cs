using SellerCenter.Infrastructure;
using SellerCenter.Infrastructure.Models;
using System.Data;

namespace SellerCenter.Service.Implementation
{
    public class PostContentService : Service<PostContentModel>, IPostContentRepository
    {
        private readonly IPostContentRepository _repository;

        public PostContentService(IPostContentRepository repository) : base(repository)
        {
            _repository = repository;
        }

        public DataTable Search(string keyword)
        {
            return _repository.Search(keyword);
        }
    }
}