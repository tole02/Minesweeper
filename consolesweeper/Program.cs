using System;

namespace consolesweeper
{
    class Program
    {
        static void Main(string[] args)
        {
            System.Console.WriteLine("This is minesweeper, you will see a board with many different positions. In 10 of them there are mines that you must find.");

            SweeperGrid grid1 = new SweeperGrid();

            grid1.Draw();
            while(grid1.board== 10)
            System.Console.WriteLine("Now try to guess where the mines are, you do this by first writing an x value.");

            string x = Console.ReadLine();

            int x2 = int.Parse(x);

            System.Console.WriteLine("Good, now write a y value.");

            string y = Console.ReadLine();

            int y2 = int.Parse(y);

            grid1.CheckPosition(x2, y2);







            Console.ReadLine();
        }
    }
}
