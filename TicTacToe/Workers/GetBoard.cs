using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToe.Workers
{
    class BoardInitializer
    {
        public string[,] GetBoard()
        {
            string[,] board = new string[3, 3];

            for (int row = 0; row < board.GetLength(0); row++)
            {
                for (int col = 0; col < board.GetLength(1); col++)
                {
                    board[row, col] = "-";
                }
            }

            return board;
        }
    }
}
