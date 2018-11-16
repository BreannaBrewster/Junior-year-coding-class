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
            while (v == false)
            {
                for (w = 0; w < 3; w++)
                {
                    char[] k = new char[] { 'X', 'O' };
                    if (w == 0)
                    {
                        k[0] = 'X';
                    }
                    if(w ==1)
                    {
                        k[1] = 'O';
                    }
                    if (w > 1)
                    {
                        w = 0;
                    }
                    //printBoard(board);
                    Console.Write("Player " + (w +1) + ", What row do you want?:");
                    y = Convert.ToInt32(Console.ReadLine());
                    Console.Write("What column do you want?:");
                    x = Convert.ToInt32(Console.ReadLine());
                    ProcessTurn(board, y ,x);
                    NewBoard(board, player, y, x, w, k);
                    VarifyBoard(board);
                    
                }
            }
        }
        static void printBoard(int[,] board)
        {
            Console.WriteLine("   0   1    2 ");
            for (int i = 0; i < board.GetLength(0); i++)
            {
                Console.Write(i + "| ");
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
            //This is waaaaay over complicated. For this, just hard code each line like in the following comment, there would be 16 total.
            //if (board[0,0] == 'X' && board[0,1] == 'X' && board[0,2] == 'X')
            //{
            //    Console.WriteLine("X wins!");
            //}
            for (int i = 0; i < board.GetLength(0); i++)
            {
                for (int j = 0; j < board.GetLength(1); j++)
                {
                    if (board[i, j] != ' ')
                    {
                        if (board[i, j] == 'X' || board[i, j] == 'O')
                        {
                            if (board[i, j] == 'X')
                            {
                                if(board[i, j] == 'X' && board[i + 1, j] == 'X')
                                {
                                    if(board[i, j] == 'X' && board[i + 1, j] == 'X' && board[i + 2, j] == 'X')
                                    {
                                        Console.WriteLine("Player 1 Wins!");
                                        break;
                                    }
                                }
                            }
                            else if (board[i, j] == 'O')
                            {
                                if (board[i, j] == 'O' && board[i + 1, j] == 'O')
                                {
                                    if (board[i, j] == 'O' && board[i + 1, j] == 'O' && board[i + 2, j] == 'O')
                                    {
                                        Console.WriteLine("Player  Wins!");
                                        break;
                                    }
                                }
                            }
                            //else if(board[i+1, j+1]== 'O')
                            //{
                            //if (board[i + 1, j + 1] == 'O')
                            // {
                            //    Console.WriteLine("Player 2 Wins!");
                            //}
                            // } 
                            //else
                            //{
                            //    break;
                            //}

                            //}
                            else if (board[i, j] == ' ')
                            {
                                bool v = false;
                            }
                        }  
                    }
                }
            }
        }
        static void NewBoard(int[,] board, char player, int y, int x, int w, char[] k)
        {
            Console.WriteLine();
            Console.WriteLine("   0   1    2 ");
            for (int i = 0; i < board.GetLength(0); i++)
            {
                Console.Write(i + "|  ");
                for (int j = 0; j < board.GetLength(1); j++)
                {
                    if (board[i, j] == 'X')
                    {
                        Console.Write("X|  ");
                    }
                    else if (board[i, j] == 'O')
                    {
                        Console.Write("O|  ");
                    }
                    else if (i == y && j == x && board[i, j] == ' ')
                    {
                        if (w == 0)
                        {
                            board[i, j] = 'X';
                            Console.Write(k[w] + "|  ");
                        }
                        else if (w == 1)
                        {
                            board[i, j] = 'O';
                            Console.Write(k[w] + "|  ");
                        }
                        //Console.Write(k[w] + "| ");
                    }
                    else if (board[i, j] != 'X' && board[i, j] != 'O')
                    {
                        board[i, j] = ' ';
                        Console.Write(" |  ");
                    }
                }
                Console.WriteLine();
            }
        }
        static void ProcessTurn(int[,] board, int y, int x)
        {
            Console.WriteLine();
            //The code below does everything except the additional Console.WriteLine() without all the complexity.
            if (board[x, y] != ' ')
            {
                Console.WriteLine("That spot is already choosen");
            }
            //for (int i = y; i < board.GetLength(0); i++)
            //{
            //    for (int j = x; j < board.GetLength(1); j++)
            //    {
            //        if (i == y && j == x)
            //        {
            //            if (board[i, j] != ' ')
            //            {
            //                Console.WriteLine("That spot is already choosen");
            //            }
            //        }
            //    }
            //    Console.WriteLine();
            //}
        }
    }
}