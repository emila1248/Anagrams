using System;

namespace Anagrams
{
    public static class Program
    {
        [STAThread]
        static void Main()
        {
            using (var game = new Anagrams())
                game.Run();
        }
    }
}
