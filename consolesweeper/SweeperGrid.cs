using System;

namespace consolesweeper
{
    public class SweeperGrid
    {
        public int[,] board = new int[5, 5];

        Random generator = new Random();



        public SweeperGrid()
        {
            for (int y = 0; y < board.GetLength(1); y++)
            {
                for (int x = 0; x < board.GetLength(1); x++)
                {
                    board[x, y] = 9;
                }
            }
            for (int n = 0; n < 10; n++)
            {
                int ypos = genrator.Next(1, 11);

                int xpos = generator.Next(1, 11);

                board[xpos, ypos] = 10;
            }
        }

        public void CheckPosition(int x1, int x2)
        {
            if (board[x1, x2] == 9)
            {
                System.Console.WriteLine("false");
            }
            else if (board[x1, x2] == 10)
            {
                System.Console.WriteLine("true");
            }
        }

        public void Draw()
        {
            for (int y = 0; y < board.GetLength(1); y++)
            {
                for (int x = 0; x < board.GetLength; x++)
                {
                    
                }
            }
        }
    }
}
