using System;

namespace consolesweeper
{
    public class SweeperGrid
    {
        public int[,] board = new int[10, 10];

        Random generator = new Random();


        public SweeperGrid()
        {
            for (int y = 0; y < board.GetLength(1); y++)
            {
                for (int x = 0; x < board.GetLength(1); x++)
                {
                    board[x, y] = 9;

                    int x1 = generator.Next(1,11);
                    int y1 = generator.Next(1,11);

                    if (board[x, y] == board[x1, y1]){
                        board[x1 ,y1] = 10;
                    }
                }

            }
        }

        public void CheckPosition(int x2, int y2)
        {
            if (board[x2, y2] == 9)
            {
                System.Console.WriteLine("false");
            }
            else if (board[x2, y2] == 10)
            {
                System.Console.WriteLine("true");
            }
        }

        public void Draw()
        {
            for (int y = 0; y < board.GetLength(1); y++)
            {
                for (int x = 0; x < board.GetLength(1); x++)
                {
                    Console.Write(board[x,y]);
                }
                System.Console.WriteLine();
            }
        }
    }
}
