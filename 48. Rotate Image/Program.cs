class Program
{
    static void Main()
    {
        var matrix = new int[][]
        {
            new int[] { 1, 2, 3 },
            new int[] { 4, 5, 6 },
            new int[] { 7, 8, 9 }
        };

        Rotate(matrix);
        Print.PrintLine(matrix);
    }

    public static void Rotate(int[][] matrix)
    {
        int n = matrix.GetLength(0);

        for (int rowCol = 0; rowCol < n / 2; rowCol++)
        {
            for (int col = rowCol; col < n - 1 - rowCol; col++)
            {
                int[] upperRowIndex = new int[] { rowCol, col };
                int[] rightColIndex = new int[] { col, n - rowCol - 1 };
                int[] bottomRowIndex = new int[] { n - rowCol - 1, n - col - 1 };
                int[] leftColIndex = new int[] { n - col - 1, rowCol };

                int upperLeft = matrix[upperRowIndex[0]][upperRowIndex[1]];

                // Move from bottom left to up
                matrix[upperRowIndex[0]][upperRowIndex[1]] = matrix[leftColIndex[0]][leftColIndex[1]];

                // Move from bottom right to left
                matrix[leftColIndex[0]][leftColIndex[1]] = matrix[bottomRowIndex[0]][bottomRowIndex[1]];

                // Move from upper right to bottom
                matrix[bottomRowIndex[0]][bottomRowIndex[1]] = matrix[rightColIndex[0]][rightColIndex[1]];

                // Move from upper left to right
                matrix[rightColIndex[0]][rightColIndex[1]] = upperLeft;
            }
        }
    }
}