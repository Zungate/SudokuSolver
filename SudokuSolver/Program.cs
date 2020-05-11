using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SudokuSolver
{
    public class Program
    {
        public static int Counter { get; set; }
        public static bool Solve(int[,] board)
        {
            for (int y = 0; y < 9; y++)
            {
                for (int x = 0; x < 9; x++)
                {
                    if (board[y, x] == 0)
                    {
                        for (int val = 1; val < 10; val++)
                        {
                            if (IsValid(y, x, val, board))
                            {
                                //Recursive call
                                board[y, x] = val;
                                Solve(board);
                                Counter++;
                                //Backtracking
                                board[y, x] = 0;
                            }
                        }
                        return true;
                    }

                }
            }
            PrintBoard(board);
            return false;
        }
        
        public static bool IsValid(int row, int column, int value, int[,] board)
        {
            for (int i = 0; i < 9; i++)
            {
                if (board[row, i] == value)
                    return false;
            }

            for (int i = 0; i < 9; i++)
            {
                if (board[i, column] == value)
                    return false;
            }

            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    if (board[row - (row % 3) + i, column - (column % 3) + j] == value)
                        return false;
                }
            }
            return true;
        }

        public static void PrintBoard(int[,] board)
        {
            for (int y = 0; y < 9; y++)
            {
                for (int x = 0; x < 9; x++)
                {
                    Console.Write(board[y, x]);
                }
                Console.WriteLine();
            }

            Console.WriteLine($"\n{Counter} attempts.");
        }

        public static void Main(string[] args)
        {
            int[,] board = {
              { 5, 3, 0, 0, 7, 0, 0, 0, 0 },
              { 6, 0, 0, 1, 9, 5, 0, 0, 0 },
              { 0, 9, 8, 0, 0, 0, 0, 6, 0 },
              { 8, 0, 0, 0, 6, 0, 0, 6, 0 },
              { 4, 0, 0, 8, 0, 3, 0, 0, 1 },
              { 7, 0, 0, 0, 2, 0, 0, 0, 6 },
              { 0, 6, 0, 0, 0, 0, 2, 8, 0 },
              { 0, 0, 0, 4, 1, 9, 0, 0, 5 },
              { 0, 0, 0, 0, 8, 0, 0, 7, 9 }};

            Console.WriteLine( Solve(board));
           Console.ReadKey();
        }
    }
}
