using System;

namespace RockPaperScissors
{
    public static class App
    {
        public static void Main()
        {
            var game = new Game();

            while (game.NoWinners)
            {
                game.PlayRound();
            }

            Console.WriteLine("\n" + game.Winner);
            Console.WriteLine("\n" + "Press any key to exit..");
            Console.ReadKey();
        }
    }
}