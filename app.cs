

namespace Roulette_Game
{
    class App
    {
        public void Run()
        {
            //Bet.NumbersBet();
            //Bet.EvensAndOddsBet();
            //Bet.RedsAndBlacksBet();
            //Bet.LowsAndHighsBet();
            //Bet.DozensBet();
            //Bet.ColumnsBet();
            //Bet.StreetBet();

            var spinResults = RouletteWheel.Spin();

            var randomNumber = spinResults.Item1;
            var color = spinResults.Item2;
            var wheeleNumber = spinResults.Item3;

            Bet.SixNumbersBet(randomNumber);
            Bet.SplitBet(randomNumber);
        }

    }
}
