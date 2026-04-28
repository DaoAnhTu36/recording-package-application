using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SellerCenter.Models
{
    public class FacebookConfig
    {
        public string? AppId { get; set; }
        public string? AppSecret { get; set; }
        public string? PageId { get; set; }
        public string? PageToken { get; set; }
        public string? GraphVersion { get; set; }
        public string? RedirectUri { get; set; }
    }
}