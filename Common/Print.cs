using System;
using System.Collections.Generic;

public class Print
{
    public static void PrintLine(IList<IList<int>> numbersCollections)
    {
        foreach (var numbers in numbersCollections)
        {
            Console.WriteLine(string.Join(", ", numbers));
        }
    }

    public static void PrintLine(IList<IList<string>> stringsCollections)
    {
        foreach (var strings in stringsCollections)
        {
            Console.WriteLine(string.Join(", ", strings));
        }
    }

    public static void PrintLine(IList<string> collection)
    {
        foreach (var currentStr in collection)
        {
            Console.WriteLine(currentStr);
        }
    }

    public static void PrintLine(int[][] matrix)
    {
        for(int row = 0; row < matrix.Length; row++)
        {
            for (int col = 0; col < matrix[0].Length; col++)
            {
                Console.Write(matrix[row][col]);
            }

            Console.WriteLine();
        }
    }
}