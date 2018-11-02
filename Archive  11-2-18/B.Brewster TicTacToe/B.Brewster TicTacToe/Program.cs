using System;

namespace B.Brewster_TicTacToe
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] board = new int[3, 3];
            for (int i = 0; i < board.GetLength(0); i++)
            {
                for (int j = 0; j < board.GetLength(1); j++)
                {
                    board[i, j] = i * j;
                }

            }
            printBoard(board);
            Console.WriteLine("What row do you want?:");
            string[] y = Console.ReadLine();
        }
        static void printBoard(int[,] board)
        {
            for (int i = 0; i < board.GetLength(0); i++)
            {
                for (int j = 0; j < board.GetLength(1); j++)
                {
                    if (board[i, j] > 9)
                    {
                        Console.Write(board[i, j] + " | ");
                    }
                    else
                    {
                        Console.Write(" " + board[i, j] + " | ");
                    }
                }
                Console.WriteLine();
            }
        }
    }
}
