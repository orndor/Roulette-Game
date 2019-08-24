namespace Roulette_Game
{
    class GameBoard
    {
        public static int[,] GenerateGameBoard()
        {
            int[,] numbersBoard = new int[12, 3];
            int counter = 1;
            for (int row = 0; row < 12; row++)
            {
                for (int col = 0; col < 3; col++)
                {
                    numbersBoard[row, col] = counter;
                    counter++;
                }
            }

            return numbersBoard;
        }
    }
}
