using System.Net;
using System.Net.Sockets;

namespace SellerCenter.Helper
{
    public static class IPHelper
    {
        public static string GetLocalIp()
        {
            string ipAddress = "";

            var host = Dns.GetHostEntry(Dns.GetHostName());

            foreach (var ip in host.AddressList)
            {
                if (ip.AddressFamily == AddressFamily.InterNetwork)
                {
                    ipAddress = ip.ToString();
                    break;
                }
            }

            return ipAddress;
        }
    }
}