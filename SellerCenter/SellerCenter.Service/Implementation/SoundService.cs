namespace SellerCenter.Service.Implementation
{
    public class SoundService : ISoundService
    {
        public async Task PlayStartAsync()
        {
            Console.Beep(1200, 100);
        }

        public async Task PlayStopAsync()
        {
            Console.Beep(600, 200);
        }
    }
}