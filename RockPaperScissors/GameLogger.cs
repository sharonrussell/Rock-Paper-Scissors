using System;

namespace RockPaperScissors
{
    public class GameLogger
    {
        public string LogWinner(string winner, int rounds)
        {
            return winner + " won after " + rounds + " rounds";
        }

        public void LogWinnerOfRound(string winner, Move winningMove, Move losingMove)
        {
            Console.WriteLine(winner + " " + winningMove.GetType().Name + " beats " + losingMove.GetType().Name);
        }

        public void LogRoundDraw(Move player1Move, Move player2Move, int rounds)
        {
            Console.WriteLine("\nRound " + rounds + " was a draw: " + player2Move.GetType().Name + " doesn't beat " + player1Move.GetType().Name);
        }

        public void LogRules(int maxRounds)
        {
            Console.WriteLine("ROCK PAPER SCISSORS\n");
            Console.WriteLine("Best of " + maxRounds + "\n");
        }
    }
}