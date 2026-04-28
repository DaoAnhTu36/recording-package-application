using SellerCenter.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SellerCenter.Service
{
    public class FacebookService
    {
        private readonly FacebookRepository _facebookRepository;

        public FacebookService()
        {
            _facebookRepository = new FacebookRepository();
        }

        public async Task<string> PostFacebookAsync(string pageId, string pageToken, string message)
        {
            return await _facebookRepository.PostFacebookAsync(pageId, pageToken, message);
        }
    }
}