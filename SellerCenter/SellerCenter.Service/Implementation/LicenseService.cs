using System.Security.Cryptography;
using System.Text;

namespace SellerCenter.Service.Implementation
{
    public class LicenseService
    {
        private static string secret = "my-secret-key";

        public static string GenerateLicense(string machineId)
        {
            using (var hmac = new HMACSHA256(Encoding.UTF8.GetBytes(secret)))
            {
                var hash = hmac.ComputeHash(Encoding.UTF8.GetBytes(machineId));
                return Convert.ToBase64String(hash).Substring(0, 16);
            }
        }

        public static bool ValidateLicense(string license)
        {
            string machineId = GetMachineId();
            string validKey = GenerateLicense(machineId);
            return license == validKey;
        }

        public static string GetMachineId()
        {
            return Environment.MachineName;
        }
    }
}