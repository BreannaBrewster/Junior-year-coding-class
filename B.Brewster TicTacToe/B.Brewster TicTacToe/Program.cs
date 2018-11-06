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
                                i++;
                                if(board[i,j] == 'X')
                                {
                                    i++;
                                    if (board[i, j] == 'X')
                                    {
                                        bool v = true;
                                        Console.WriteLine("Player 1 Wins!");
                                    }
                                    else
                                    {
                                        break;
                                    }
                                }
                                break;
                                
                            }
                            else if (board[i, j] == 'O')
                            {
                                if (board[i + 1, j] == 'O')
                                {
                                    if (board[i + 2, j] == 'O')
                                    {
                                        bool v = true;
                                        Console.WriteLine("Player 2 Wins!");
                                    }
                                    else
                                    {
                                        break;
                                    }
                                }
                                else if(board[i+1, j+1]== 'O')
                                {
                                    if (board[i + 1, j + 1] == 'O')
                                    {
                                        Console.WriteLine("Player 2 Wins!");
                                    }
                                } 
                                else
                                {
                                    break;
                                }

                            }
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
            for (int i = y; i < board.GetLength(0); i++)
            {
                for (int j = x; j < board.GetLength(1); j++)
                {
                    if (i == y && j == x)
                    {
                        if (board[i, j] != ' ')
                        {
                            Console.WriteLine("That spot is already choosen");
                        }
                    }
                }
                Console.WriteLine();
            }
        }
    }
}