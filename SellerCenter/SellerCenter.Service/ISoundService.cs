namespace SellerCenter.Service
{
    public interface ISoundService
    {
        Task PlayStartAsync();

        Task PlayStopAsync();
    }
}