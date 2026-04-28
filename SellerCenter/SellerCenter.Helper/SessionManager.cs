namespace SellerCenter.Helper
{
    public static class SessionManager
    {
        public static object? CurrentUser { get; private set; }
        public static string? SessionToken { get; private set; }
        public static string? FacebookUserToken { get; private set; }
        public static string? FacebookPageId { get; private set; }
        public static string? AppId { get; private set; }
        public static string? FacebookPageToken { get; private set; }

        public static void SetSession(object user, string token)
        {
            CurrentUser = user;
            SessionToken = token;
        }

        public static void SetFacebookUserToken(string token)
        {
            FacebookUserToken = token;
        }

        public static void SetFacebookPageId(string pageId)
        {
            FacebookPageId = pageId;
        }

        public static void SetFacebookPageToken(string pageToken)
        {
            FacebookPageToken = pageToken;
        }

        public static void SetAppId(string appId)
        {
            AppId = appId;
        }

        public static void ClearSession()
        {
            CurrentUser = null;
            SessionToken = null;
        }

        public static void ClearFacebookSession()
        {
            FacebookUserToken = null;
            FacebookPageToken = null;
            FacebookPageId = null;
        }
    }
}