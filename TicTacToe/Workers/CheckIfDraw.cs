using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToe.Workers
{
    class CheckIfDraw
    {
        public bool Check(string[,] board)
        {
            for (int row = 0; row < board.GetLength(0); row++)
            {
                for (int col = 0; col < board.GetLength(1); col++)
                {
                    if (board[row, col].Equals("-")) return false;
                }
            }
            return true;
        }
    }
}
