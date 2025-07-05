using System;
using System.ComponentModel;
using System.Collections.Generic;
using System.ComponentModel.Design;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Q5
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Noughts and crosses!");
            Console.WriteLine("  a   b   c ");
            Console.WriteLine("1   |   |   ");
            Console.WriteLine(" ---+---+---");
            Console.WriteLine("2   |   |   ");
            Console.WriteLine(" ---+---+---");
            Console.WriteLine("3   |   |   ");

            bool whosTurn = true;
            string turnPlayer = "";
            bool gaming = true;
            bool winningMove = false;
            bool tieMove = false;

            List<string> validCoordinates = new List<string>() { "a1", "a2", "a3", "b1", "b2", "b3", "c1", "c2", "c3" };
            List<string> inputCoordinatesX = new List<string>();
            List<string> inputCoordinatesO = new List<string>();

            string[,] playingField = new string[,]
            {
                { "   ", "   ", "   " },
                { "   ", "   ", "   " },
                { "   ", "   ", "   " },
            };

            while (gaming)
            {
                if (whosTurn)
                {
                    turnPlayer = "X";
                }
                else
                {
                    turnPlayer = "O";
                }

                Console.WriteLine($"{turnPlayer}'s turn to play:");
                string inputCoordinate = Console.ReadLine();

                bool validMove = false;

                if (validCoordinates.Contains(inputCoordinate))
                {
                    switch (inputCoordinate)
                    {
                        case "a1":
                            if (!inputCoordinatesX.Contains("a1") && !inputCoordinatesO.Contains("a1"))
                            {
                                if (whosTurn)
                                {
                                    inputCoordinatesX.Add(inputCoordinate);
                                }
                                else
                                {
                                    inputCoordinatesO.Add(inputCoordinate);
                                }
                                playingField[0, 0] = $" {turnPlayer} ";
                                VisualiseField(playingField);
                                validMove = true;
                            }
                            else
                            {
                                Console.WriteLine("Invalid position. Position must be unoccupied.");
                            }
                            break;

                        case "a2":
                            if (!inputCoordinatesX.Contains("a2") && !inputCoordinatesO.Contains("a2"))
                            {
                                if (whosTurn)
                                {
                                    inputCoordinatesX.Add(inputCoordinate);
                                }
                                else
                                {
                                    inputCoordinatesO.Add(inputCoordinate);
                                }
                                playingField[1, 0] = $" {turnPlayer} ";
                                VisualiseField(playingField);
                                validMove = true;
                            }
                            else
                            {
                                Console.WriteLine("Invalid position. Position must be unoccupied.");
                            }
                            break;

                        case "a3":
                            if (!inputCoordinatesX.Contains("a3") && !inputCoordinatesO.Contains("a3"))
                            {
                                if (whosTurn)
                                {
                                    inputCoordinatesX.Add(inputCoordinate);
                                }
                                else
                                {
                                    inputCoordinatesO.Add(inputCoordinate);
                                }
                                playingField[2, 0] = $" {turnPlayer} ";
                                VisualiseField(playingField);
                                validMove = true;
                            }
                            else
                            {
                                Console.WriteLine("Invalid position. Position must be unoccupied.");
                            }
                            break;

                        case "b1":
                            if (!inputCoordinatesX.Contains("b1") && !inputCoordinatesO.Contains("b1"))
                            {
                                if (whosTurn)
                                {
                                    inputCoordinatesX.Add(inputCoordinate);
                                }
                                else
                                {
                                    inputCoordinatesO.Add(inputCoordinate);
                                }
                                playingField[0, 1] = $" {turnPlayer} ";
                                VisualiseField(playingField);
                                validMove = true;
                            }
                            else
                            {
                                Console.WriteLine("Invalid position. Position must be unoccupied.");
                            }
                            break;

                        case "b2":
                            if (!inputCoordinatesX.Contains("b2") && !inputCoordinatesO.Contains("b2"))
                            {
                                if (whosTurn)
                                {
                                    inputCoordinatesX.Add(inputCoordinate);
                                }
                                else
                                {
                                    inputCoordinatesO.Add(inputCoordinate);
                                }
                                playingField[1, 1] = $" {turnPlayer} ";
                                VisualiseField(playingField);
                                validMove = true;
                            }
                            else
                            {
                                Console.WriteLine("Invalid position. Position must be unoccupied.");
                            }
                            break;

                        case "b3":
                            if (!inputCoordinatesX.Contains("b3") && !inputCoordinatesO.Contains("b3"))
                            {
                                if (whosTurn)
                                {
                                    inputCoordinatesX.Add(inputCoordinate);
                                }
                                else
                                {
                                    inputCoordinatesO.Add(inputCoordinate);
                                }
                                playingField[2, 1] = $" {turnPlayer} ";
                                VisualiseField(playingField);
                                validMove = true;
                            }
                            else
                            {
                                Console.WriteLine("Invalid position. Position must be unoccupied.");
                            }
                            break;

                        case "c1":
                            if (!inputCoordinatesX.Contains("c1") && !inputCoordinatesO.Contains("c1"))
                            {
                                if (whosTurn)
                                {
                                    inputCoordinatesX.Add(inputCoordinate);
                                }
                                else
                                {
                                    inputCoordinatesO.Add(inputCoordinate);
                                }
                                playingField[0, 2] = $" {turnPlayer} ";
                                VisualiseField(playingField);
                                validMove = true;
                            }
                            else
                            {
                                Console.WriteLine("Invalid position. Position must be unoccupied.");
                            }
                            break;

                        case "c2":
                            if (!inputCoordinatesX.Contains("c2") && !inputCoordinatesO.Contains("c2"))
                            {
                                if (whosTurn)
                                {
                                    inputCoordinatesX.Add(inputCoordinate);
                                }
                                else
                                {
                                    inputCoordinatesO.Add(inputCoordinate);
                                }
                                playingField[1, 2] = $" {turnPlayer} ";
                                VisualiseField(playingField);
                                validMove = true;
                            }
                            else
                            {
                                Console.WriteLine("Invalid position. Position must be unoccupied.");
                            }
                            break;

                        case "c3":
                            if (!inputCoordinatesX.Contains("c3") && !inputCoordinatesO.Contains("c3"))
                            {
                                if (whosTurn)
                                {
                                    inputCoordinatesX.Add(inputCoordinate);
                                }
                                else
                                {
                                    inputCoordinatesO.Add(inputCoordinate);
                                }
                                playingField[2, 2] = $" {turnPlayer} ";
                                VisualiseField(playingField);
                                validMove = true;
                            }
                            else
                            {
                                Console.WriteLine("Invalid position. Position must be unoccupied.");
                            }
                            break;

                        default:
                            Console.WriteLine("Invalid position. Position must be unoccupied.");
                            break;
                    }

                    for (int i = 0; i < inputCoordinatesX.Count; i++)
                    {

                        if (inputCoordinatesX.Contains("a1") && inputCoordinatesX.Contains("a2") && inputCoordinatesX.Contains("a3") ||
                            inputCoordinatesX.Contains("b1") && inputCoordinatesX.Contains("b2") && inputCoordinatesX.Contains("b3") ||
                            inputCoordinatesX.Contains("c1") && inputCoordinatesX.Contains("c2") && inputCoordinatesX.Contains("c3") ||
                            inputCoordinatesX.Contains("a1") && inputCoordinatesX.Contains("b2") && inputCoordinatesX.Contains("c3") ||
                            inputCoordinatesX.Contains("c1") && inputCoordinatesX.Contains("b2") && inputCoordinatesX.Contains("a3") ||
                            inputCoordinatesX.Contains("a1") && inputCoordinatesX.Contains("b1") && inputCoordinatesX.Contains("c1") ||
                            inputCoordinatesX.Contains("a2") && inputCoordinatesX.Contains("b2") && inputCoordinatesX.Contains("c2") ||
                            inputCoordinatesX.Contains("a3") && inputCoordinatesX.Contains("b3") && inputCoordinatesX.Contains("c3") ||
                            inputCoordinatesO.Contains("a1") && inputCoordinatesO.Contains("a2") && inputCoordinatesO.Contains("a3") ||
                            inputCoordinatesO.Contains("b1") && inputCoordinatesO.Contains("b2") && inputCoordinatesO.Contains("b3") ||
                            inputCoordinatesO.Contains("c1") && inputCoordinatesO.Contains("c2") && inputCoordinatesO.Contains("c3") ||
                            inputCoordinatesO.Contains("a1") && inputCoordinatesO.Contains("b2") && inputCoordinatesO.Contains("c3") ||
                            inputCoordinatesO.Contains("c1") && inputCoordinatesO.Contains("b2") && inputCoordinatesO.Contains("a3") ||
                            inputCoordinatesO.Contains("a1") && inputCoordinatesO.Contains("b1") && inputCoordinatesO.Contains("c1") ||
                            inputCoordinatesO.Contains("a2") && inputCoordinatesO.Contains("b2") && inputCoordinatesO.Contains("c2") ||
                            inputCoordinatesO.Contains("a3") && inputCoordinatesO.Contains("b3") && inputCoordinatesO.Contains("c3"))
                        {
                            winningMove = true;
                        }
                        
                         else if ((inputCoordinatesX.Contains("a1") || inputCoordinatesO.Contains("a1")) && (inputCoordinatesX.Contains("a2") || inputCoordinatesO.Contains("a2")) && (inputCoordinatesX.Contains("a3") || inputCoordinatesO.Contains("a3")) &&
                             (inputCoordinatesX.Contains("b1") || inputCoordinatesO.Contains("b1")) && (inputCoordinatesX.Contains("b2") || inputCoordinatesO.Contains("b2")) && (inputCoordinatesX.Contains("b3") || inputCoordinatesO.Contains("b3")) &&
                             (inputCoordinatesX.Contains("c1") || inputCoordinatesO.Contains("c1")) && (inputCoordinatesX.Contains("c2") || inputCoordinatesO.Contains("c2")) && (inputCoordinatesX.Contains("c3") || inputCoordinatesO.Contains("c3")))
                        {
                             tieMove = true;
                        }
                    }

                    if (winningMove)
                    {
                        Console.WriteLine($"{turnPlayer} wins!");
                        gaming = false;
                    }
                    else
                    {
                        if (inputCoordinatesX.Count + inputCoordinatesO.Count == 9)
                        {
                            tieMove = true;
                        }
                    }

                    if (tieMove)
                    {
                        Console.WriteLine("It's a tie!");
                        gaming = false;
                    }


                    if (validMove)
                    {
                        if (whosTurn)
                        {
                            whosTurn = false;
                        }
                        else
                        {
                            whosTurn = true;
                        }
                    }
                }
                else
                {
                    Console.WriteLine("Invalid position. Position must be of the format a1 and be on the board.");
                }
            }
        }

        static void VisualiseField(string[,] playingField)
        {
            Console.WriteLine("  a   b   c");
            Console.WriteLine($"1 {playingField[0, 0]}|{playingField[0, 1]}|{playingField[0, 2]}");
            Console.WriteLine("  ---+---+---");
            Console.WriteLine($"2 {playingField[1, 0]}|{playingField[1, 1]}|{playingField[1, 2]}");
            Console.WriteLine("  ---+---+---");
            Console.WriteLine($"3 {playingField[2, 0]}|{playingField[2, 1]}|{playingField[2, 2]}");
        }

    }
}
