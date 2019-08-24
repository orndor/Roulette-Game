using System;

namespace Roulette_Game
{
    class App
    {
        public void Run()
        {
            do
            {
                Console.Clear();
                var numbersBoard = GameBoard.GenerateGameBoard();
                var spinResults = RouletteWheel.Spin();
                var randomNumber = spinResults.Item1;
                var color = spinResults.Item2;
                var wheeleNumber = spinResults.Item3;

                System.Console.WriteLine("The following bets would have won:\n");

                Bet.NumbersBet(wheeleNumber);
                Bet.EvensAndOddsBet(randomNumber);

                //If you roll a '00' or '0' don't even bother running the other bets that can't win.
                if (randomNumber != 37 && randomNumber != 0)
                {
                    Bet.RedsAndBlacksBet(color);
                    Bet.LowsAndHighsBet(randomNumber);
                    Bet.DozensBet(randomNumber);
                    Bet.ColumnsBet(randomNumber, numbersBoard);
                    Bet.StreetBet(randomNumber, numbersBoard);
                    Bet.SixNumbersBet(randomNumber, numbersBoard);
                    Bet.SplitBet(randomNumber, numbersBoard);
                    Bet.CornerBet(randomNumber, numbersBoard);
                }
                Console.WriteLine("\n\nHit Space Bar to play again...");
            } while (Console.ReadKey().Key == ConsoleKey.Spacebar);

        }

    }
}
