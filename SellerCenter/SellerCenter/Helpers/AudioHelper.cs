namespace SellerCenter.Helpers
{
    public static class AudioHelper
    {
        public static void SoundPlay()
        {
            Console.Beep(1000, 200);
        }

        public static void SoundStop()
        {
            Console.Beep(600, 300);
        }
    }
}