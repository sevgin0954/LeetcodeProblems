using System;

namespace _79._Word_Search
{
    class Program
    {
        static void Main()
        {
            var board = new char[][]
            {
                new char[] { 'A', 'B', 'C', 'E'},
                new char[] { 'S', 'F', 'E', 'S'},
                new char[] { 'A', 'D', 'E', 'E'}
            };
            var word = "ABCEFSADEESE";

            var isWordExist = Exist(board, word);
            Console.WriteLine(isWordExist);
        }

        public static bool Exist(char[][] board, string word)
        {
            var rowsCount = board.Length;
            var colsCount = board[0].Length;
            for (int rowIndex = 0; rowIndex < rowsCount; rowIndex++)
            {
                for (int colIndex = 0; colIndex < colsCount; colIndex++)
                {
                    if (board[rowIndex][colIndex] == word[0])
                    {
                        var isWordExist = IsExistRec(board, rowIndex, colIndex, 0, word);
                        if (isWordExist)
                        {
                            return true;
                        }
                    }
                }
            }

            return false;
        }

        private static bool IsExistRec(
            char[][] board,
            int rowIndex,
            int colIndex,
            int index,
            string word)
        {
            if (index == word.Length)
            {
                return true;
            }
            if (IsCordinatesValidInMatrix(board, rowIndex, colIndex) == false)
            {
                return false;
            }
            if (IsAlreadyPassed(board, rowIndex, colIndex))
            {
                return false;
            }
            if (board[rowIndex][colIndex] != word[index])
            {
                return false;
            }

            var currentChar = board[rowIndex][colIndex];
            board[rowIndex][colIndex] = ' ';

            // Right
            var isExist = IsExistRec(board, rowIndex, colIndex + 1, index + 1, word);
            if (isExist)
            {
                return true;
            }

            // Down
            isExist = IsExistRec(board, rowIndex + 1, colIndex, index + 1, word);
            if (isExist)
            {
                return true;
            }

            // Left
            isExist = IsExistRec(board, rowIndex, colIndex - 1, index + 1, word);
            if (isExist)
            {
                return true;
            }

            // Up
            isExist = IsExistRec(board, rowIndex - 1, colIndex, index + 1, word);
            if (isExist)
            {
                return true;
            }

            board[rowIndex][colIndex] = currentChar;

            return false;
        }

        private static bool IsAlreadyPassed(char[][] board, int rowIndex, int colIndex)
        {
            return board[rowIndex][colIndex] == ' ';
        }

        private static bool IsCordinatesValidInMatrix(char[][] matrix, int rowIndex, int colIndex)
        {
            var isRowIndexValid = rowIndex >= 0 && rowIndex < matrix.Length;
            var isColIndexValid = colIndex >= 0 && colIndex < matrix[0].Length;

            return isRowIndexValid && isColIndexValid;
        }
    }
}