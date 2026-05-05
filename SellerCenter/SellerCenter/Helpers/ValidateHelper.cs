using System.Text.RegularExpressions;

namespace SellerCenter.Helpers
{
    public static class ValidateHelper
    {
        public static bool IsValidTrackingCode(string code)
        {
            //var pattern = @"^(SPX|SPE|SP|GYW)\d{8,15}$|^\d{9,12}$|^[A-Z]{2}\d{9,13}(VN)?$";
            //return Regex.IsMatch(code, pattern);
            return true;
        }
    }
}