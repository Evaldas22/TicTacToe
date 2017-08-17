using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TicTacToe.Data;

namespace TicTacToe.Workers
{
    class TransferToBoard
    {
        public (string[,] board, bool success) Transfer(string[,] board, int[] input, string sign)
        {
            if (SocketIsValid(board, input))
            {
                board[input[1] - 1, input[0] - 1] = sign;
                return (board, true);
            }
            else
            {
                ColorWriteLines.PlaceTakenRed();
                return (board, false);
            }
        }

        private bool SocketIsValid(string[,] board, int[] input) => board[input[1] - 1, input[0] - 1] == "-";
    }
}
