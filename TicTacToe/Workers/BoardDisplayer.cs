using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToe.Workers
{
    class BoardDisplayer
    {
        public void Display(string[,] board)
        {
            //These two lines are for more undestandable UI
            Console.WriteLine("      x");
            Console.WriteLine("    1 2 3");

            for (int row = 0; row < board.GetLength(0); row++)
            {
                //This is also for UI
                if (row == 1) Console.Write($"y {row + 1}|");
                else Console.Write($"  {row + 1}|");

                for (int col = 0; col < board.GetLength(1); col++)
                {
                    Console.Write($"{board[row, col]}|");
                }
                Console.WriteLine();
            }
            Console.WriteLine();
        }
    }
}
