using System;

namespace Roulette_Game
{
    class Bet
    {
        static public void NumbersBet(string wheelNumber)
        {
            Console.WriteLine($"Number {wheelNumber}");
        }
        static public void EvensAndOddsBet(int randomNumber)
        {
            //Evens/Odds: even or odd numbers
            if (randomNumber % 2 == 0 && randomNumber != 37)
            {
                Console.WriteLine("Evens/Odds bet (even)");
            }
            else if (randomNumber % 3 == 0 || randomNumber == 1 && randomNumber != 37)
            {
                Console.WriteLine("Evens/Odds bet (odd)");
            }
        }
        static public void RedsAndBlacksBet(string color)
        {
            //Reds/Blacks: red or black colored numbers
            if (color == "Red")
            {
                Console.WriteLine("Red/Black bet (Red)");
            }
            else
            {
                Console.WriteLine("Red/Black bet (Black)");
            }
        }
        static public void LowsAndHighsBet(int randomNumber)
        {
            //Lows/Highs: low (1 – 18) or high (19 – 36) numbers.
            if (randomNumber >= 1 && randomNumber <= 18)
            {
                Console.WriteLine("The first half (1-18)");
            }
            else
            {
                Console.WriteLine("The second half (19-36)");
            }
        }
        static public void DozensBet(int randomNumber)
        {
            //Dozens: row thirds, 1 – 12, 13 – 24, 25 – 36
            if (randomNumber >= 1 && randomNumber <= 12)
            {
                Console.WriteLine("The first 12 (1-12)");
            }
            else if (randomNumber >= 13 && randomNumber <= 24)
            {
                Console.WriteLine("The second 12 (13-24)");
            }
            else
            {
                Console.WriteLine("The third 12 (25-36)");
            }
        }
        static public void ColumnsBet(int randomNumber, int[,] numbersBoard)
        {
            //Columns: first, second, or third columns

            int rowNumber = GetRowNumber(randomNumber);
            if (numbersBoard[rowNumber, 0] == randomNumber)
            {
                Console.WriteLine($"Column 1 numbers (1, 4, 7, 10, 13, 16, 18, 22, 25, 28, 31, 34)");
            }
            else if (numbersBoard[rowNumber, 1] == randomNumber)
            {
                Console.WriteLine($"Column 2 numbers (2, 5, 8, 11, 14, 17, 20, 23, 26, 29, 32, 35)");
            }
            else
            {
                Console.WriteLine($"Column 3 numbers (3, 6, 9, 12, 15, 18, 21, 24, 27, 30, 33, 36)");
            }

        }
        static public void StreetBet(int randomNumber, int[,] numbersBoard)
        {
            //Street: rows, e.g., 1/2/3 or 22/23/24
            int rowNumber = GetRowNumber(randomNumber);

            Console.WriteLine($"Street bet numbers {numbersBoard[rowNumber, 0]} through {numbersBoard[rowNumber, 2]}");

        }
        static public void SixNumbersBet(int randomNumber, int[,] numbersBoard)
        {
            //6 Numbers: double rows, e.g., 1/2/3/4/5/6 or 22/23/24/25/26/26
            try
            {
                int counter = 1;
                for (int row = 0; row < 12; row++)
                {
                    for (int col = 0; col < 3; col++)
                    {
                        numbersBoard[row, col] = counter;
                        counter++;
                    }
                }
                if (randomNumber >= 1 && randomNumber <= 3)
                {
                    Console.WriteLine("Double row number 1 through 6");
                }
                else if (randomNumber >= 4 && randomNumber <= 33)
                {
                    int rowNumber = GetRowNumber(randomNumber);
                    int startingRow = rowNumber - 1;
                    int endingRow = rowNumber + 1;
                    Console.WriteLine($"Double row numbers {numbersBoard[startingRow, 0]} through {numbersBoard[rowNumber, 2]}");
                    Console.WriteLine($"Double row numbers {numbersBoard[rowNumber, 0]} through {numbersBoard[endingRow, 2]}");
                }
                else if (randomNumber >= 34 && randomNumber <= 36)
                {
                    Console.WriteLine("Double row numbers 31 through 36");
                }
                else {; }
            }
            catch
            {
                Console.WriteLine("Something went wrong...");
            }
        }
        static public void SplitBet(int randomNumber, int[,] numbersBoard)
        {
            //Split: at the edge of any two contiguous numbers, e.g., 1/2, 11/14, and 35/36
            int rowNumber = GetRowNumber(randomNumber);
            if (numbersBoard[rowNumber, 0] == randomNumber)
            {
                if (randomNumber == 1)
                {
                    Console.WriteLine("Split bet 1 and 2");
                    Console.WriteLine("Split bet 1 and 4");
                }
                else if (randomNumber == 34)
                {
                    Console.WriteLine("Split bet 34 and 35");
                    Console.WriteLine("Split bet 34 and 31");
                }
                else
                {
                    Console.WriteLine($"Split bet {numbersBoard[rowNumber, 0]} and {numbersBoard[rowNumber - 1, 0]}");
                    Console.WriteLine($"Split bet {numbersBoard[rowNumber, 0]} and {numbersBoard[rowNumber, 1]}");
                    Console.WriteLine($"Split bet {numbersBoard[rowNumber, 0]} and {numbersBoard[rowNumber + 1, 0]}");
                }
            }
            if (numbersBoard[rowNumber, 1] == randomNumber)
            {
                if (randomNumber == 2)
                {
                    Console.WriteLine($"Split bet {numbersBoard[rowNumber, 1]} and {numbersBoard[rowNumber, 0]}");
                    Console.WriteLine($"Split bet {numbersBoard[rowNumber, 1]} and {numbersBoard[rowNumber, 2]}");
                    Console.WriteLine($"Split bet {numbersBoard[rowNumber, 1]} and {numbersBoard[rowNumber + 1, 1]}");
                }
                else if (randomNumber == 35)
                {
                    Console.WriteLine($"Split bet {numbersBoard[rowNumber, 1]} and {numbersBoard[rowNumber - 1, 1]}");
                    Console.WriteLine($"Split bet {numbersBoard[rowNumber, 1]} and {numbersBoard[rowNumber, 0]}");
                    Console.WriteLine($"Split bet {numbersBoard[rowNumber, 1]} and {numbersBoard[rowNumber, 2]}");
                }
                else
                {
                    Console.WriteLine($"Split bet {numbersBoard[rowNumber, 1]} and {numbersBoard[rowNumber - 1, 1]}");
                    Console.WriteLine($"Split bet {numbersBoard[rowNumber, 1]} and {numbersBoard[rowNumber, 0]}");
                    Console.WriteLine($"Split bet {numbersBoard[rowNumber, 1]} and {numbersBoard[rowNumber, 2]}");
                    Console.WriteLine($"Split bet {numbersBoard[rowNumber, 1]} and {numbersBoard[rowNumber + 1, 1]}");
                }
            }
            if (numbersBoard[rowNumber, 2] == randomNumber)
            {
                if (randomNumber == 3)
                {
                    Console.WriteLine("Split bet 3 and 2");
                    Console.WriteLine("Split bet 3 and 6");
                }
                else if (randomNumber == 36)
                {
                    Console.WriteLine("Split bet 36 and 33");
                    Console.WriteLine("Split bet 36 and 35");
                }
                else
                {
                    Console.WriteLine($"Split bet {numbersBoard[rowNumber, 2]} and {numbersBoard[rowNumber - 1, 2]}");
                    Console.WriteLine($"Split bet {numbersBoard[rowNumber, 2]} and {numbersBoard[rowNumber, 1]}");
                    Console.WriteLine($"Split bet {numbersBoard[rowNumber, 2]} and {numbersBoard[rowNumber + 1, 2]}");
                }
            }
        }
        static public void CornerBet(int randomNumber, int[,] numbersBoard)
        {
            //Corner: at the intersection of any four contiguous numbers, e.g., 1/2/4/5, or 23/24/26/27
            int rowNumber = GetRowNumber(randomNumber);
            if (numbersBoard[rowNumber, 0] == randomNumber)
            {
                if (randomNumber == 1)
                {
                    Console.WriteLine("Corner bet 1, 2, 4, and 5");
                }
                else if (randomNumber == 34)
                {
                    Console.WriteLine("Corner bet 34, 31, 32, and 35");
                }
                else
                {
                    Console.WriteLine($"Corner bet {numbersBoard[rowNumber, 0]}, {numbersBoard[rowNumber, 0] - 3}, {numbersBoard[rowNumber, 0] - 2}, and {numbersBoard[rowNumber, 0] + 1}");
                    Console.WriteLine($"Corner bet {numbersBoard[rowNumber, 0]}, {numbersBoard[rowNumber, 0] + 1}, {numbersBoard[rowNumber, 0] + 3}, and {numbersBoard[rowNumber, 0] + 4}");
                }
            }
            if (numbersBoard[rowNumber, 1] == randomNumber)
            {
                if (randomNumber == 2)
                {
                    Console.WriteLine($"Corner bet {numbersBoard[rowNumber, 1]}, {numbersBoard[rowNumber, 1] - 1}, {numbersBoard[rowNumber, 1] + 2}, and {numbersBoard[rowNumber, 1] + 3}");
                    Console.WriteLine($"Corner bet {numbersBoard[rowNumber, 1]}, {numbersBoard[rowNumber, 1] + 1}, {numbersBoard[rowNumber, 1] + 3}, and {numbersBoard[rowNumber, 1] + 4}");
                }
                else if (randomNumber == 35)
                {
                    Console.WriteLine($"Corner bet {numbersBoard[rowNumber, 1]}, {numbersBoard[rowNumber, 1] - 4}, {numbersBoard[rowNumber, 1] - 3}, and {numbersBoard[rowNumber, 1] - 1}");
                    Console.WriteLine($"Corner bet {numbersBoard[rowNumber, 1]}, {numbersBoard[rowNumber, 1] - 3}, {numbersBoard[rowNumber, 1] - 2}, and {numbersBoard[rowNumber, 1] + 1}");
                }
                else
                {
                    Console.WriteLine($"Corner bet {numbersBoard[rowNumber, 1]}, {numbersBoard[rowNumber, 1] - 4}, {numbersBoard[rowNumber, 1] - 3}, and {numbersBoard[rowNumber, 1] - 1}");
                    Console.WriteLine($"Corner bet {numbersBoard[rowNumber, 1]}, {numbersBoard[rowNumber, 1] - 3}, {numbersBoard[rowNumber, 1] - 2}, and {numbersBoard[rowNumber, 1] + 1}");
                    Console.WriteLine($"Corner bet {numbersBoard[rowNumber, 1]}, {numbersBoard[rowNumber, 1] - 1}, {numbersBoard[rowNumber, 1] + 2}, and {numbersBoard[rowNumber, 1] + 3}");
                    Console.WriteLine($"Corner bet {numbersBoard[rowNumber, 1]}, {numbersBoard[rowNumber, 1] + 1}, {numbersBoard[rowNumber, 1] + 3}, and {numbersBoard[rowNumber, 1] + 4}");
                }
            }
            if (numbersBoard[rowNumber, 2] == randomNumber)
            {
                if (randomNumber == 3)
                {
                    Console.WriteLine("Corner bet 3, 2, 5, and 6");
                }
                else if (randomNumber == 36)
                {
                    Console.WriteLine("Corner bet 36, 32, 33, and 35");
                }
                else
                {
                    Console.WriteLine($"Corner bet {numbersBoard[rowNumber, 2]}, {numbersBoard[rowNumber, 2] - 4}, {numbersBoard[rowNumber, 2] - 3}, and {numbersBoard[rowNumber, 2] - 1}");
                    Console.WriteLine($"Corner bet {numbersBoard[rowNumber, 2]}, {numbersBoard[rowNumber, 2] - 1}, {numbersBoard[rowNumber, 2] + 2}, and {numbersBoard[rowNumber, 2] + 3}");
                }
            }
        }

        static private int GetRowNumber(int randomNumber)
        {
            int rowNumber = 0;
            if(randomNumber > 0)
            {
                rowNumber = (int)Math.Ceiling((double)randomNumber / 3.0) - 1;
            }
            return rowNumber;
        }
    }
}
