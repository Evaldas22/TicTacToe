using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToe.Data
{
    class ColorWriteLines
    {
        public static void PlaceTakenRed()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("This place is already taken!!");
            Console.ForegroundColor = ConsoleColor.Black;
        }

        public static void WrongCoordinatesRed()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Please enter valid coordinates!!");
            Console.ForegroundColor = ConsoleColor.Black;
        }

        public static void CongratsFirstPlayerGreen()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(Constants.CongratsFirstPlayer);
            Console.ForegroundColor = ConsoleColor.Black;
        }

        public static void DrawYellow()
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("It's Draw!");
            Console.ForegroundColor = ConsoleColor.Black;
        }

        public static void CongratsSecondPlayerGreen()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(Constants.CongratsSecondPlayer);
            Console.ForegroundColor = ConsoleColor.Black;
        }
    }
}
