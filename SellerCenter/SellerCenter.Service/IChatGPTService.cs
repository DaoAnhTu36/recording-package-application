using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SellerCenter.Service
{
    public interface IChatGPTService
    {
        public Task<string> SendRequest(string message, List<string> imagePaths);
    }
}
