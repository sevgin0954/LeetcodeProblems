using System;
using System.Text;

class Program
{
    static void Main()
    {
        Console.WriteLine(CountAndSay(5));
    }

    public static string CountAndSay(int n)
    {
        var result = new StringBuilder();
        result.Append("1");

        while (n > 1)
        {
            var currentResult = new StringBuilder();
            var currentLetterCount = 1;
            for (int i = 0; i < result.Length; i++)
            {
                if (i + 1 < result.Length && result[i] == result[i + 1])
                {
                    currentLetterCount++;
                }
                else
                {
                    currentResult.Append(currentLetterCount.ToString() + result[i]);
                    currentLetterCount = 1;
                }
            }
            result = currentResult;
            n--;
        }

        return result.ToString();
    }
}