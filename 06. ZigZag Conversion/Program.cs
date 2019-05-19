using System;
using System.Collections.Generic;
using System.Text;

class Program
{
    static void Main()
    {
        var strInput = "PAYPALISHIRING";
        var rowsCount = 4;

        Console.WriteLine(Convert(strInput, rowsCount));
    }

    public static string Convert(string str, int rowsCount)
    {
        if (str.Length <= 2 || rowsCount == 1)
        {
            return str;
        }

        List<StringBuilder> rows = CreateStringBuilderCollection(rowsCount);
        var currentRow = 0;
        var direction = 1;
        for (int i = 0; i < str.Length; i++)
        {
            var currentChar = str[i];
            rows[currentRow].Append(currentChar);

            if (currentRow + 1 == rowsCount)
            {
                direction = -1;
            }
            else if (currentRow == 0)
            {
                direction = 1;
            }

            currentRow += direction;
        }

        var result = string.Join("", rows);
        return result;
    }

    private static List<StringBuilder> CreateStringBuilderCollection(int count)
    {
        List<StringBuilder> rows = new List<StringBuilder>();
        for (int row = 1; row <= count; row++)
        {
            rows.Add(new StringBuilder());
        }

        return rows;
    }
}