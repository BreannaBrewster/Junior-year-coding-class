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
            int w = 0;
            char player = ' ';
            int y = 3;
            int x = 3;
            bool v = false;
            while (v != true)
            {    
            char[] k = new char[] { 'X', 'O' };
                k[w] = k[w++];
            
                //printBoard(board);
                Console.Write("Player " + w + ", What row do you want?:");
                y = Convert.ToInt32(Console.ReadLine());
                Console.Write("What column do you want?:");
                x = Convert.ToInt32(Console.ReadLine());
                ProcessTurn(board, player, y, x, w, k);
                Console.WriteLine("  0  1   2 ");
                for (int i = 0; i<board.GetLength(0); i++)
                {
                    if (w > 1)
                    {
                        w = 0;
                    }
                    
                    Console.Write(i);
                    for (int j=0; j<board.GetLength(1); j++)
                    {
                        if (i == y && j == x && board[i, j] == ' ')
                        {

                            Console.Write(k[w] + " | ");
                        }
                        else if(board[i, j] != 'X' && board[i, j] != 'O')
                        { 
                            Console.Write("  | ");
                        }
                    }
                    Console.WriteLine();
                }
                VarifyBoard(board);
            }
        }
        static void printBoard(int[,] board)
        { 
            Console.WriteLine("  0  1   2 ");
            for (int i = 0; i < board.GetLength(0); i++)
            {
                Console.Write(i);
                for (int j = 0; j < board.GetLength(1); j++)
                {
                    board[i, j] = ' ';
                   Console.Write("  | ");
                }
                Console.WriteLine();
            }
        }
        static void VarifyBoard(int[,] board)
        {
            for (int i = 0; i < board.GetLength(0); i++)
            {
                for (int j = 0; j < board.GetLength(1); j++)
                {
                    if (board[i, j] != ' ')
                    {
                        if (board[i, j] == 'X' || board[i, j] == 'O')
                        {
                            for (i = 0; i <= 2; i++)
                            {
                                for (j = 0; j <= 2; j++)
                                {
                                    if (board[i, j] == 'X' || board[i, j] == 'O')
                                    {
                                        for (i = 0; i <= 1; i++)
                                        {
                                            for (j = 0; j <= 1; j++)
                                            {
                                                if (board[i, j] == 'X' || board[i, j] == 'O')
                                                {
                                                    bool v = true;
                                                    if (board[i, j] == 'X')
                                                    {
                                                        Console.WriteLine("Player 1 Wins!");
                                                    }
                                                    else if (board[i, j] == 'O')
                                                    {
                                                        Console.WriteLine("Player 2 Wins!");
                                                    }
                                                }
                                            }
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
            }
        }

        static void ProcessTurn(int[,] board, char player, int y, int x, int w, char[] k)
        {

            Console.WriteLine();
            for (int i = y; i ==y; i++)
            {

                for (int j = x; j == x; j++)
                {
                    if (i == y && j == x && board[i, j] != ' ' && board[i, j] != ' ')
                    {
                        Console.WriteLine("That spot is already choosen");
                    }
                }
            }
        }
    }
}