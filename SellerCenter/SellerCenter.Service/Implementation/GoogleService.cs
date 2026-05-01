using Google.Apis.Auth.OAuth2;
using Google.Apis.Drive.v3;
using Google.Apis.Services;
using Google.Apis.Util.Store;

namespace SellerCenter.Service.Implementation
{
    public class GoogleService : IGoogleService
    {
        public async Task<string> UploadVideoToDrive(string filePath)
        {
            UserCredential credential;

            using (var stream = new FileStream("client_secret.json", FileMode.Open, FileAccess.Read))
            {
                credential = await GoogleWebAuthorizationBroker.AuthorizeAsync(
                    GoogleClientSecrets.FromStream(stream).Secrets,
                    new[] { DriveService.Scope.DriveFile },
                    "user",
                    CancellationToken.None,
                    new FileDataStore("DriveToken", true)
                );
            }

            var service = new DriveService(new BaseClientService.Initializer()
            {
                HttpClientInitializer = credential,
                ApplicationName = "SellerCenter"
            });

            var fileMetadata = new Google.Apis.Drive.v3.Data.File()
            {
                Name = Path.GetFileName(filePath)
            };

            FilesResource.CreateMediaUpload request;

            using (var stream = new FileStream(filePath, FileMode.Open))
            {
                request = service.Files.Create(fileMetadata, stream, "video/mp4");
                request.Fields = "id";

                await request.UploadAsync();
            }

            var file = request.ResponseBody;

            return file.Id;
        }
    }
}