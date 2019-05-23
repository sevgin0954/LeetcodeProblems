using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        //var sudokuBoard = new char[][]
        //{
        //    new char[] { '8','3','.','.','7','.','.','.','.'},
        //    new char[] {'6','.','.','1','9','5','.','.','.'},
        //    new char[] {'.','9','8','.','.','.','.','6','.'},
        //    new char[] {'8','.','.','.','6','.','.','.','3'},
        //    new char[] {'4','.','.','8','.','3','.','.','1'},
        //    new char[] {'7','.','.','.','2','.','.','.','6'},
        //    new char[] {'.','6','.','.','.','.','2','8','.'},
        //    new char[] {'.','.','.','4','1','9','.','.','5'},
        //    new char[] {'.','.','.','.','8','.','.','7','9'}
        //};
        var sudokuBoard = new char[][]
        {
            new char[] {'5','3','.','.','7','.','.','.','.'},
            new char[] {'6','.','.','1','9','5','.','.','.'},
            new char[] {'.','9','8','.','.','.','.','6','.'},
            new char[] {'8','.','.','.','6','.','.','.','3'},
            new char[] {'4','.','.','8','.','3','.','.','1'},
            new char[] {'7','.','.','.','2','.','.','.','6'},
            new char[] {'.','6','.','.','.','.','2','8','.'},
            new char[] {'.','.','.','4','1','9','.','.','5'},
            new char[] {'.','.','.','.','8','.','.','7','9'},
        };

        Console.WriteLine(IsValidSudoku(sudokuBoard));
    }

    public static bool IsValidSudoku(char[][] board)
    {
        var isSubSudokusValid = ValidateSubSudokues(board);
        if (isSubSudokusValid == false)
        {
            return false;
        }

        var isSudokusRowsValid = ValidateSudokuRows(board);
        if (isSudokusRowsValid == false)
        {
            return false;
        }

        var isSudokuColsValid = ValidateSudokuCols(board);
        if (isSudokuColsValid == false)
        {
            return false;
        }

        return true;
    }

    private static bool ValidateSubSudokues(char[][] board)
    {
        for (int row = 0; row < board.Length; row += 3)
        {
            for (int col = 0; col < board[0].Length; col += 3)
            {
                if (Is3x3SubSudokuValid(board, row, col) == false)
                {
                    return false;
                }
            }
        }

        return true;
    }

    private static bool ValidateSudokuRows(char[][] board)
    {
        for (int col = 0; col < board[0].Length; col++)
        {
            var hashSet = new HashSet<int>();
            for (int row = 0; row < board.Length; row++)
            {
                if (board[row][col] == '.')
                {
                    continue;
                }

                if (hashSet.Contains(board[row][col]))
                {
                    return false;
                }
                else
                {
                    hashSet.Add(board[row][col]);
                }
            }
        }

        return true;
    }

    private static bool ValidateSudokuCols(char[][] board)
    {
        for (int row = 0; row < board.Length; row++)
        {
            var hashSet = new HashSet<int>();
            for (int col = 0; col < board[0].Length; col++)
            {
                if (board[row][col] == '.')
                {
                    continue;
                }

                if (hashSet.Contains(board[row][col]))
                {
                    return false;
                }
                else
                {
                    hashSet.Add(board[row][col]);
                }
            }
        }

        return true;
    }
    private static bool Is3x3SubSudokuValid(char[][] board, int startRowIndex, int startColIndex)
    {
        var hashSet = new HashSet<int>();
        for (int row = startRowIndex; row <= startRowIndex + 2; row++)
        {
            for (int col = startColIndex; col <= startColIndex + 2; col++)
            {
                if (board[row][col] == '.')
                {
                    continue;
                }

                if (hashSet.Contains(board[row][col]))
                {
                    return false;
                }
                else
                {
                    hashSet.Add(board[row][col]);
                }
            }
        }

        return true;
    }
}