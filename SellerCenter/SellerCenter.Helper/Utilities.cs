namespace SellerCenter.Helper
{
    public static class Utilities
    {
        public static string CreateFileName(string? barcode, out bool isSuccess)
        {
            isSuccess = false;
            var reval = string.Empty;
            if (barcode != null)
            {
                reval = $"ORDER_{barcode}_{DateTime.Now:HHmmss}.mp4";
                isSuccess = true;
            }
            return reval;
        }

        public static string CreatePath(string? startupPath, string? fileName, out bool isSuccess)
        {
            var reval = string.Empty;
            isSuccess = true;
            if (string.IsNullOrEmpty(fileName) || string.IsNullOrEmpty(startupPath))
            {
                isSuccess = false;
                return reval;
            }
            string basePath = Path.Combine(startupPath, "Videos");
            string dateFolder = DateTime.Now.ToString("yyyy-MM-dd");
            string folderPath = Path.Combine(basePath, dateFolder);
            Directory.CreateDirectory(folderPath);
            reval = Path.Combine(folderPath, fileName);
            return reval;
        }
    }
}