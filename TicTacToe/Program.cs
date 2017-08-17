using System;
using TicTacToe.Data;
using TicTacToe.Workers;

namespace TicTacToe
{
    class Program
    {
        private static readonly BoardInitializer _boardInitiliazer = new BoardInitializer();
        private static readonly BoardDisplayer _boardDisplayer = new BoardDisplayer();
        private static readonly InputConverter _inputConverter = new InputConverter();
        private static readonly TransferToBoard _transferToBoard = new TransferToBoard();
        private static readonly WinnnerChecker _winnnerChecker = new WinnnerChecker();
        private static readonly CheckIfDraw _checkIfDraw = new CheckIfDraw();

        static void Main(string[] args)
        {
            try
            {
                Console.ForegroundColor = ConsoleColor.Black;
                Console.BackgroundColor = ConsoleColor.White;

                Console.Clear();

                Console.WriteLine(Constants.Welcome + Environment.NewLine);
                bool playAgain = false;

                do
                {
                    string[,] board = _boardInitiliazer.GetBoard();
                    bool continueTheGame = true;

                    _boardDisplayer.Display(board);

                    bool isValid = false;
                    int[] player1Input, player2Input = new int[2];
                    bool turnIsComplete;

                    do
                    {
                        do
                        {
                            do
                            {
                                Console.WriteLine(Constants.FirstPlayerInput);
                                string playerOneInput = Console.ReadLine() ?? string.Empty;

                                (bool valid, int[] convertedPlayerInput) = _inputConverter.Convert(playerOneInput);
                                isValid = valid;
                                player1Input = convertedPlayerInput;
                                Console.WriteLine();

                            } while (!isValid);

                            (string[,] returnedBoard, bool success) = _transferToBoard.Transfer(board, player1Input, "X");
                            board = returnedBoard;
                            turnIsComplete = success;
                        } while (!turnIsComplete);


                        _boardDisplayer.Display(board);

                        if (_winnnerChecker.Check(board, "X"))
                        {
                            ColorWriteLines.CongratsFirstPlayerGreen();

                            continueTheGame = false;
                            string again;
                            do
                            {
                                Console.WriteLine(Constants.PlayAgain);
                                again = Console.ReadLine().ToUpper();
                            } while (!(again.Equals("Y") || again.Equals("N")));
                            if (again.Equals("Y"))
                            {
                                playAgain = true;
                                Console.Clear();
                                continue;
                            }
                            playAgain = false;
                            break;
                        }

                        if (_checkIfDraw.Check(board))
                        {
                            continueTheGame = false;
                            string again;
                            do
                            {
                                ColorWriteLines.DrawYellow();
                                Console.WriteLine(Constants.PlayAgain);

                                again = Console.ReadLine().ToUpper();
                            } while (!(again.Equals("Y") || again.Equals("N")));

                            if (again.Equals("Y"))
                            {
                                playAgain = true;
                                Console.Clear();
                                continue;
                            }
                            playAgain = false;
                            break;
                        }

                        do
                        {
                            do
                            {
                                Console.WriteLine(Constants.SecondPlayerInput);
                                string playerTwoInput = Console.ReadLine() ?? string.Empty;

                                (bool valid, int[] convertedPlayerInput) = _inputConverter.Convert(playerTwoInput);
                                isValid = valid;
                                player2Input = convertedPlayerInput;
                            } while (!isValid);

                            (string[,] returnedBoard, bool success) = _transferToBoard.Transfer(board, player2Input, "O");
                            board = returnedBoard;
                            turnIsComplete = success;

                        } while (!turnIsComplete);

                        _boardDisplayer.Display(board);

                        if (_winnnerChecker.Check(board, "O"))
                        {
                            ColorWriteLines.CongratsSecondPlayerGreen();
                            continueTheGame = false;
                            string again;
                            do
                            {
                                Console.WriteLine(Constants.PlayAgain);
                                again = Console.ReadLine().ToUpper();
                            } while (!(again.Equals("Y") || again.Equals("N")));

                            if (again.Equals("Y"))
                            {
                                playAgain = true;
                                Console.Clear();
                                continue;
                            }
                            playAgain = false;
                            break;
                        }

                    } while (continueTheGame);
                } while (playAgain);
                Console.WriteLine("Press any key to exit the application...");
                Console.ReadLine();
            }
            catch (Exception ex)    
            {
                Console.WriteLine("Error has occured: " + ex.Message);
            }
        }
    }
}