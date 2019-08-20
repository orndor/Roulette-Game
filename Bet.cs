using System;
using System.Collections.Generic;
using System.Text;

namespace Roulette_Game
{
    class Bet
    {
        public void SelectBet()
        {
            Console.WriteLine("Valid Bets:");
            Console.WriteLine("1. Numbers: the number of the bin.");
            Console.WriteLine("2. Evens/Odds: even or odd numbers");
            Console.WriteLine("3. Reds/Blacks: red or black colored numbers");
            Console.WriteLine("4. Lows/Highs: low (1 – 18) or high (19 – 38) numbers.");
            Console.WriteLine("5. Dozens: row thirds, 1 – 12, 13 – 24, 25 – 36");
            Console.WriteLine("6. Columns: first, second, or third columns");
            Console.WriteLine("7. Street: rows, e.g., 1/2/3 or 22/23/24");
            Console.WriteLine("8. 6 Numbers: double rows, e.g., 1/2/3/4/5/6 or 22/23/24/25/26/26");
            Console.WriteLine("9. Split: at the edge of any two contiguous numbers, e.g., 1/2, 11/14, and 35/36");
            Console.WriteLine("10. Corner: at the intersection of any four contiguous numbers, e.g., 1/2/4/5, or 23/24/26/27");
        }
        static public void NumbersBet()
        {
            try
            {
                //Numbers: the number of the bin
                Console.Write("Enter the number you wish to bet on: ");
                var stringNumber = Console.ReadLine();
                var intNumber = 0;
                if (stringNumber == "00")
                {
                    intNumber = RouletteWheel.Spin();
                    if (intNumber == 0)
                    {
                        Console.WriteLine("You won!");
                    }
                }

                else if (int.Parse(stringNumber) <= 36 && int.Parse(stringNumber) >= 0)
                {
                    intNumber = RouletteWheel.Spin();
                    var number = int.Parse(stringNumber);
                    if (intNumber == ++number)
                    {
                        Console.WriteLine("You won!");
                    }
                    else
                    {
                        Console.WriteLine("Sorry, you lost.");
                    }
                }
                else
                {
                    Console.WriteLine("blah Please enter a valid number between 00 and 36");
                }
            }
            catch
            {
                Console.WriteLine("Please enter a valid number between 00 and 36");
            }
            finally
            {
                Console.WriteLine("Please select a bet.");
            }

        }
        public void EvensAndOddsBet()
        {
            //Evens/Odds: even or odd numbers

        }
        public void RedsAndBlacksBet()
        {
            //Reds/Blacks: red or black colored numbers

        }
        public void LowsAndHighsBet()
        {
            //Lows/Highs: low (1 – 18) or high (19 – 38) numbers.

        }
        public void DozensBet()
        {
            //Dozens: row thirds, 1 – 12, 13 – 24, 25 – 36

        }
        public void ColumnsBet()
        {
            //Columns: first, second, or third columns

        }
        public void StreetBet()
        {
            //Street: rows, e.g., 1/2/3 or 22/23/24

        }
        public void SixNumbersBet()
        {
            //6 Numbers: double rows, e.g., 1/2/3/4/5/6 or 22/23/24/25/26/26

        }
        public void SplitBet()
        {
            //Split: at the edge of any two contiguous numbers, e.g., 1/2, 11/14, and 35/36

        }
        public void CornerBet()
        {
            //Corner: at the intersection of any four contiguous numbers, e.g., 1/2/4/5, or 23/24/26/27

        }
    }
}
