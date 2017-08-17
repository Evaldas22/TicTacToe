using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TicTacToe.Data;

namespace TicTacToe.Workers
{
    class InputConverter
    {
        public (bool valid, int[] convertedInput) Convert(string userInput)
        {
            userInput = userInput.Replace(" ", ""); 
            if (userInput.Contains(','))
            {
                string[] inputToArray = userInput.Split(',');
                int number1, number2;

                bool isConvertedFirstNumber = int.TryParse(inputToArray[0], out number1);
                bool isConvertedSecondNumber = int.TryParse(inputToArray[1], out number2);

                if ((isConvertedFirstNumber && isConvertedSecondNumber) &&
                (number1 <= 3 && number1 > 0) && (number2 <= 3 && number2 > 0))
                {
                    return (true, new int[] { number1, number2 });
                }
            }

            //tell that wrong coordinates were entered
            ColorWriteLines.WrongCoordinatesRed();

            return (false, new int[] { });
        }
    }
}
