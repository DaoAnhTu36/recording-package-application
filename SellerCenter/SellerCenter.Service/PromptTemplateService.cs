using SellerCenter.Infrastructure;
using SellerCenter.Infrastructure.Models;
using System.Data;

namespace SellerCenter.Service
{
    public class PromptTemplateService
    {
        private PromptTemplateRepository _instance;

        public PromptTemplateService()
        {
            _instance = new PromptTemplateRepository();
        }

        public DataTable GetAll()
        {
            return _instance.GetAll();
        }

        public PromptTemplate? GetById(long id)
        {
            return _instance.GetById(id);
        }

        public long Insert(PromptTemplate template)
        {
            return _instance.Insert(template);
        }

        public bool Update(PromptTemplate template)
        {
            return _instance.Update(template);
        }

        public bool Delete(long id)
        {
            return _instance.Delete(id);
        }

        public DataTable Search(string keyword)
        {
            return _instance.Search(keyword);
        }
    }
}