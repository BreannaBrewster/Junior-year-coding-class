﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sudoku
{
    public class Program
    {
        static void Main(string[] args)
        {
            int userInput = 0;
            SudokuBoard board = new SudokuBoard();
            do
            {
                board.PrintBoard();
                Console.WriteLine();
                Console.WriteLine("Pick a menu option:");
                Console.WriteLine("1. Verify the board.");
                Console.WriteLine("2. Place a value on the board.");
                Console.WriteLine("3. Find legal digits for a given row/column.");
                Console.WriteLine("4. Solve the board completely.");
                Console.WriteLine("5. Exit program.");
                if (!int.TryParse(Console.ReadLine(), out userInput) || userInput < 1 || userInput > 4)
                {
                    Console.WriteLine();
                    Console.WriteLine("You have entered an incorrect input. Please try again.");
                    Console.WriteLine("Press any key to continue...");
                    Console.ReadKey();
                    Console.Clear();
                    continue;
                }

                switch (userInput)
                {
                    case 1:
                        VerifyBoard(board);
                        break;
                    case 2:
                        PlaceValue(board);
                        break;
                    case 3:
                        FindLegalDigits(board);
                        Console.WriteLine("Press any key to continue...");
                        Console.ReadKey();
                        break;
                    case 4:
                        if (SolveBoardIterativelyWithQueue(ref board))
                        {
                            Console.WriteLine("The board was solved successfully!");
                            board.PrintBoard();
                            Console.WriteLine("Press any key to continue...");
                            Console.ReadKey();
                        }
                        else
                        {
                            Console.WriteLine("The board was not solved correctly.");
                            board.PrintBoard();
                            Console.WriteLine("Press any key to continue...");
                            Console.ReadKey();
                        }
                        userInput = 5;
                        break;
                    case 5:
                        Console.WriteLine("Thanks for playing");
                        break;
                }
                Console.Clear();
            } while (userInput != 5);
        }

        /// <summary>
        /// Verifies if the board is satisfied.
        /// </summary>
        /// <param name="board">The board to work with</param>
        static void VerifyBoard(SudokuBoard board)
        {
            if (board.VerifyBoard())
            {
                Console.WriteLine("This board has been solved correctly!");
                Console.WriteLine("Press any key to continue...");
                Console.ReadKey();
            }
            else
            {
                Console.WriteLine("This board has been solved incorrectly.");
                Console.WriteLine("Press any key to continue...");
                Console.ReadKey();
            }
        }

        /// <summary>
        /// Get the user input and place a value on the board.
        /// </summary>
        /// <param name="board">The board to work with</param>
        static void PlaceValue(SudokuBoard board)
        {
            int val, row, col;
        GetRow:
            Console.WriteLine("Enter the row that you want to place (X) (0-8)");
            int userInput;
            if (!int.TryParse(Console.ReadLine(), out userInput) || userInput < 0 || userInput > 8)
            {
                Console.WriteLine("You have entered an incorrect input. Please try again.");

                goto GetRow;
            }
            row = userInput;

        GetCol:
            Console.WriteLine("Enter the col that you want to place (Y) (0-8)");
            if (!int.TryParse(Console.ReadLine(), out userInput) || userInput < 0 || userInput > 8)
            {
                Console.WriteLine("You have entered an incorrect input. Please try again.");

                goto GetCol;
            }
            col = userInput;

        GetVal:
            Console.WriteLine("Enter the value that you want to place (1-9)");
            if (!int.TryParse(Console.ReadLine(), out userInput) || userInput < 1 || userInput > 9)
            {
                Console.WriteLine("You have entered an incorrect input. Please try again.");

                goto GetVal;
            }
            val = userInput;

            if (!board.PlaceValue(val, row, col))
            {
                Console.WriteLine("PlaceValue returned false because of an invalid input. Try again.");
                goto GetRow;
            }
        }

        /// <summary>
        /// Calls the FindLegalDigits method on the board
        /// </summary>
        /// <param name="board">Board to check</param>
        public static void FindLegalDigits(SudokuBoard board)
        {
            int row, col;
        GetRow:
            Console.WriteLine("Enter the row that you want to check (0-8)");
            int userInput;
            if (!int.TryParse(Console.ReadLine(), out userInput) || userInput < 0 || userInput > 9)
            {
                Console.WriteLine("You have entered an incorrect input. Please try again.");

                goto GetRow;
            }
            row = userInput+1;

        GetCol:
            Console.WriteLine("Enter the col that you want to place (0-8)");
            if (!int.TryParse(Console.ReadLine(), out userInput) || userInput < 0 || userInput > 9)
            {
                Console.WriteLine("You have entered an incorrect input. Please try again.");

                goto GetCol;
            }
            col = userInput+1;

            Console.WriteLine();
            foreach (int validVal in board.FindLegalDigits(row - 1, col - 1))
            {
                Console.WriteLine(validVal + " is a legal digit for row " + (row-1) + " and column " + (col-1));
            }
            Console.WriteLine();
        }

        /// <summary>
        /// Algorithmically finds a solution (if there is one) to this sudoku puzzle.
        /// Make sure to assign the solved board back to the board argument
        /// </summary>
        /// <param name="board">The board to solve</param>
        /// <returns>True if the board was solved, false otherwise.</returns>
        public static bool SolveBoardIterativelyWithQueue(ref SudokuBoard board)
        {
            Queue<SudokuBoard> boards = new Queue<SudokuBoard>();
            boards.Enqueue(board);
            while (boards.Count > 0)
            {
                SudokuBoard tempBoard = boards.Dequeue();
                if (tempBoard.VerifyBoard() == true) //We only want to check one board every update, specifically the one board we are considering.
                {
                    board = tempBoard;
                    return true; //Just return true!
                }
                bool exit=false;
                for (int y=0; y<9; y++)
                {
                    for (int x = 0; x < 9; x++)
                    {
                        if (tempBoard.Board[x, y] == 0) //Common mistake, you want to look at tempBoard, not your original board
                        {
                            foreach (int i in tempBoard.FindLegalDigits(x, y))
                            {
                                //You have the right idea above, here is the right way.
                                SudokuBoard copiedBoard = new SudokuBoard(tempBoard); //Using our copy constructor in SudokuBoard.cs
                                copiedBoard.Board[x, y] = i; //Set the value
                                boards.Enqueue(copiedBoard); //Put the copied board on the queue
                            }
                            //TODO: At this point, we know we found the first empty space in the board, so I don't want to search for any other (on this specific board).
                            //Use a boolean to get out of the for loops we are currently in (the x and y for loops) so we can continue to the next iteration of the while loop.
                            exit = true;
                            break;
                        }
                    }
                    if(exit==true)
                    {
                        break;
                    }
                }
            }
            return false; //If we get to this point, we have not found a solution (likely due to bug)
        }
    }
}
