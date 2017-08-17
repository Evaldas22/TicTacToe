using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToe.Workers
{
    class WinnnerChecker
    {
        public bool Check(string[,] board, string sign) => CheckIfWinInRows(board, sign) || CheckIfWinInCols(board, sign) || CheckIfWinInCross(board, sign);

        private bool CheckIfWinInRows(string[,] board,string sign)
        {
            int count = 0;

            for (int row = 0; row < 3; row++)   
            {
                for (int col = 0; col < 3; col++)   
                {
                    if (board[row, col] == sign) count++;
                }
                if (count == 3) return true;
                count = 0;
            }

            return false;
        }

        private bool CheckIfWinInCols(string[,] board, string sign)
        {
            int count = 0;

            for (int col = 0; col < 3; col++)
            {
                for (int row = 0; row < 3; row++)
                {
                    if (board[row, col] == sign) count++;
                }
                if (count == 3) return true;
                count = 0;
            }

            return false;
        }

        private bool CheckIfWinInCross(string[,] board, string sign)
        {
            if (board[0, 0] == sign && board[1, 1] == sign && board[2, 2] == sign) return true;
            else if (board[0, 2] == sign && board[1, 1] == sign && board[2, 0] == sign) return true;
            return false;
        }
    }
}
