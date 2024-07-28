using System;
using System.Diagnostics;

public class SudokuSolver
{
    public static void Main()
    {
        Console.Title = "Sudoku Solver - Salih Uysal | 2024";

        char[][] board = new char[][]
        {
            new char[] {'.', '.', '9', '7', '4', '8', '.', '.', '.'},
            new char[] {'7', '.', '.', '.', '.', '.', '.', '.', '.'},
            new char[] {'.', '2', '.', '1', '.', '9', '.', '.', '.'},
            new char[] {'.', '.', '7', '.', '.', '.', '2', '4', '.'},
            new char[] {'.', '6', '4', '.', '1', '.', '5', '9', '.'},
            new char[] {'.', '9', '8', '.', '.', '.', '3', '.', '.'},
            new char[] {'.', '.', '.', '8', '.', '3', '.', '2', '.'},
            new char[] {'.', '.', '.', '.', '.', '.', '.', '.', '6'},
            new char[] {'.', '.', '.', '2', '7', '5', '9', '.', '.'}
        };

        char[][] board2 = new char[][]
        {
            new char[] {'5', '3', '.', '.', '7', '.', '.', '.', '.'},
            new char[] {'6', '.', '.', '1', '9', '5', '.', '.', '.'},
            new char[] {'.', '9', '8', '.', '.', '.', '.', '6', '.'},
            new char[] {'8', '.', '.', '.', '6', '.', '.', '.', '3'},
            new char[] {'4', '.', '.', '8', '.', '3', '.', '.', '1'},
            new char[] {'7', '.', '.', '.', '2', '.', '.', '.', '6'},
            new char[] {'.', '6', '.', '.', '.', '.', '2', '8', '.'},
            new char[] {'.', '.', '.', '4', '1', '9', '.', '.', '5'},
            new char[] {'.', '.', '.', '.', '8', '.', '.', '7', '9'}
        };

        Console.WriteLine(" -----------------------");
        Console.WriteLine("     U N S O L V E D    ");
        PrintSudokuBoard(board2);

        Console.WriteLine("");
        Console.WriteLine(" -----------------------");
        Console.WriteLine("       S O L V E D      ");

        Stopwatch stopwatch = Stopwatch.StartNew();
        SolveSudoku(board2);
        stopwatch.Stop();

        PrintSudokuBoard(board2);

        Console.WriteLine($"Runtime: {stopwatch.ElapsedMilliseconds} ms");
        Console.ReadLine();
    }

    public static void PrintSudokuBoard(char[][] board)
    {
        Console.WriteLine(" -----------------------");
        for (int i = 0; i < 9; i++)
        {
            Console.Write("| ");
            for (int j = 0; j < 9; j++)
            {
                Console.Write(board[i][j] + " ");
                if ((j + 1) % 3 == 0)
                {
                    Console.Write("| ");
                }
            }
            Console.WriteLine();
            if ((i + 1) % 3 == 0)
            {
                Console.WriteLine(" -----------------------");
            }
        }
    }

    public static bool SolveSudoku(char[][] board)
    {
        for (int row = 0; row < 9; row++)
        {
            for (int col = 0; col < 9; col++)
            {
                if (board[row][col] == '.')
                {
                    for (char num = '1'; num <= '9'; num++)
                    {
                        if (IsValid(board, row, col, num))
                        {
                            board[row][col] = num;
                            if (SolveSudoku(board))
                            {
                                return true;
                            }
                            board[row][col] = '.';
                        }
                    }
                    return false;
                }
            }
        }
        return true;
    }

    public static bool IsValid(char[][] board, int row, int col, char num)
    {
        for (int i = 0; i < 9; i++)
        {
            if (board[row][i] == num || board[i][col] == num || board[(row / 3) * 3 + i / 3][(col / 3) * 3 + i % 3] == num)
            {
                return false;
            }
        }
        return true;
    }
}
