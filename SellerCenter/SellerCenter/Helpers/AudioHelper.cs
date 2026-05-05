namespace SellerCenter.Helpers
{
    public static class AudioHelper
    {
        public static void PlaySound()
        {
            Console.Beep(1000, 200);
        }

        public static void StopSound()
        {
            Console.Beep(600, 300);
        }
    }
}