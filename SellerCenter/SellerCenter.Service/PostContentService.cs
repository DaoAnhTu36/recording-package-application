using SellerCenter.Infrastructure;
using SellerCenter.Infrastructure.Models;
using System.Data;

namespace SellerCenter.Service
{
    public class PostContentService
    {
        private PostContentRepository _repository;

        public PostContentService()
        {
            _repository = new PostContentRepository();
        }

        public DataTable GetAll()
        {
            return _repository.GetAll();
        }

        public int Insert(PostContentModel item)
        {
            return _repository.Insert(item);
        }

        public bool Update(PostContentModel item)
        {
            return _repository.Update(item);
        }

        public bool Delete(int id)
        {
            return _repository.Delete(id);
        }
    }
}