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
                    intNumber = RouletteWheel.Spin().Item1;
                    if (intNumber == 37)
                    {
                        Console.WriteLine("You won!");
                    }
                }

                else if (int.Parse(stringNumber) <= 36 && int.Parse(stringNumber) >= 0)
                {
                    intNumber = RouletteWheel.Spin().Item1;
                    var number = int.Parse(stringNumber);
                    if (intNumber == number)
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
                    Console.WriteLine("Please enter a valid number between 00 and 36");
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
        static public void EvensAndOddsBet()
        {
            //Evens/Odds: even or odd numbers
            try
            {
                Console.Write("Enter 1 to bet even; enter 2 to bet odd: ");
                var stringNumber = Console.ReadLine();
                var intNumber = 0;
                if (stringNumber == "1")
                {
                    intNumber = RouletteWheel.Spin().Item1;
                    if (intNumber % 2 == 0)
                    {
                        Console.WriteLine("You won!");
                    }
                    else
                    {
                        Console.WriteLine("Sorry, you lost.");
                    }
                }

                else if (stringNumber == "2")
                {
                    intNumber = RouletteWheel.Spin().Item1;
                    if (intNumber % 3 == 0)
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
                    Console.WriteLine("Please enter either 1 or 2.");
                }
            }
            catch
            {
                Console.WriteLine("Please enter either 1 or 2.");
            }
            finally
            {
                Console.WriteLine("Please select a bet.");
            }
        }
        static public void RedsAndBlacksBet()
        {
            //Reds/Blacks: red or black colored numbers
            try
            {
                Console.Write("Enter 1 to bet red; enter 2 to bet black: ");
                var stringNumber = Console.ReadLine();
                if (stringNumber == "1")
                {
                    var color = RouletteWheel.Spin().Item2;
                    if (color == "Red")
                    {
                        Console.WriteLine("You won!");
                    }
                    else
                    {
                        Console.WriteLine("Sorry, you lost.");
                    }
                }

                else if (stringNumber == "2")
                {
                    var color = RouletteWheel.Spin().Item2;
                    if (color == "Black")
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
                    Console.WriteLine("Please enter either 1 or 2.");
                }
            }
            catch
            {
                Console.WriteLine("Please enter either 1 or 2.");
            }
            finally
            {
                Console.WriteLine("Please select a bet.");
            }
        }
        static public void LowsAndHighsBet()
        {
            //Lows/Highs: low (1 – 18) or high (19 – 36) numbers.
            try
            {
                Console.Write("Enter 1 to bet low(1-18); enter 2 to bet high(19-36): ");
                var stringNumber = Console.ReadLine();
                var intNumber = 0;
                if (stringNumber == "1")
                {
                    intNumber = RouletteWheel.Spin().Item1;
                    if (intNumber >=1 && intNumber <= 18)
                    {
                        Console.WriteLine("You won!");
                    }
                    else
                    {
                        Console.WriteLine("Sorry, you lost.");
                    }
                }

                else if (stringNumber == "2")
                {
                    intNumber = RouletteWheel.Spin().Item1;
                    if (intNumber >= 19 && intNumber <= 36)
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
                    Console.WriteLine("Please enter either 1 or 2.");
                }
            }
            catch
            {
                Console.WriteLine("Please enter either 1 or 2.");
            }
            finally
            {
                Console.WriteLine("Please select a bet.");
            }
        }
        static public void DozensBet()
        {
            //Dozens: row thirds, 1 – 12, 13 – 24, 25 – 36
            try
            {
                Console.Write("Enter 1 to bet the first third(1-12); enter 2 to bet the second third(13-24); enter 3 to bet the last third(25-36): ");
                var stringNumber = Console.ReadLine();
                var intNumber = 0;
                if (stringNumber == "1")
                {
                    intNumber = RouletteWheel.Spin().Item1;
                    if (intNumber >= 1 && intNumber <= 12)
                    {
                        Console.WriteLine("You won!");
                    }
                    else
                    {
                        Console.WriteLine("Sorry, you lost.");
                    }
                }
                else if (stringNumber == "2")
                {
                    intNumber = RouletteWheel.Spin().Item1;
                    if (intNumber >= 13 && intNumber <= 24)
                    {
                        Console.WriteLine("You won!");
                    }
                    else
                    {
                        Console.WriteLine("Sorry, you lost.");
                    }
                }

                else if (stringNumber == "3")
                {
                    intNumber = RouletteWheel.Spin().Item1;
                    if (intNumber >= 25 && intNumber <= 36)
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
                    Console.WriteLine("Please enter either 1, 2, or 3.");
                }
            }
            catch
            {
                Console.WriteLine("Please enter either 1, 2, or 3.");
            }
            finally
            {
                Console.WriteLine("Please select a bet.");
            }
        }
        static public void ColumnsBet()
        {
            //Columns: first, second, or third columns

            try
            {
                Console.Write("Enter 1 to bet the first column; enter 2 to bet the second column; enter 3 to bet the third column: ");
                int[] column = new int[12];
                var intNumber = 0;
                var consoleNumber = int.Parse(Console.ReadLine());
                if (consoleNumber >=1 && consoleNumber <= 3)
                {
                    intNumber = RouletteWheel.Spin().Item1;
                    column.SetValue(consoleNumber, 0);
                    for (int i = 0; i < column.Length-1; i++)
                    {
                        column[i+1] = column[i] + 3;
                    }
                    if (Array.Exists(column, num => num == intNumber))
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
                    Console.WriteLine("Please enter either 1, 2, or 3.");
                }
            }
            catch
            {
                Console.WriteLine("Please enter either 1, 2, or 3.");
            }
            finally
            {
                Console.WriteLine("Please select a bet.");
            }

        }
        static public void StreetBet()
        {
            //Street: rows, e.g., 1/2/3 or 22/23/24
            try
            {
                Console.WriteLine("Enter 1 to bet the last street (1,2,3): ");
                Console.WriteLine("Enter 2 to bet the last street (4,5,6): ");
                Console.WriteLine("Enter 3 to bet the last street (7,8,9): ");
                Console.WriteLine("Enter 4 to bet the last street (10,11,12): ");
                Console.WriteLine("Enter 5 to bet the last street (13,14,15): ");
                Console.WriteLine("Enter 6 to bet the last street (16,17,18): ");
                Console.WriteLine("Enter 7 to bet the last street (19,20,21): ");
                Console.WriteLine("Enter 8 to bet the last street (22,23,24): ");
                Console.WriteLine("Enter 9 to bet the last street (25,26,27): ");
                Console.WriteLine("Enter 10 to bet the last street (28,29,30): ");
                Console.WriteLine("Enter 11 to bet the last street (31,32,33): ");
                Console.WriteLine("Enter 12 to bet the last street (34,35,36): ");
                int[] column = new int[3];
                var intNumber = 0;
                var consoleNumber = int.Parse(Console.ReadLine());
                if (consoleNumber >=1 && consoleNumber <=12)
                {
                    intNumber = RouletteWheel.Spin().Item1;
                    column.SetValue(consoleNumber, 0);
                    for (int i = 0; i < column.Length - 1; i++)
                    {
                        column[i + 1] = column[i] + 1;
                    }
                    if (Array.Exists(column, num => num == intNumber))
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
                    Console.WriteLine("Please enter number from 1 to 12.");
                }
            }
            catch
            {
                Console.WriteLine("Please enter number from 1 to 12.");
            }
            finally
            {
                Console.WriteLine("Please select a bet.");
            }
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
