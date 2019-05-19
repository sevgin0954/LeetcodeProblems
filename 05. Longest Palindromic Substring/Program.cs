using System;

class Program
{
    static void Main()
    {
        var str = "bb";
        Console.WriteLine(LongestPalindrome(str));
    }

    public static string LongestPalindrome(string str)
    {
        if (str.Length < 2)
        {
            return str;
        }

        int bestStartIndex = 0;
        int bestLength = 1;

        bool[,] isPalindrome = new bool[str.Length, str.Length];
        for (int endIndex = 1; endIndex < str.Length; endIndex++)
        {
            for (int startIndex = 0; startIndex < endIndex; startIndex++)
            {   
                bool isInnerWordPalindrome = isPalindrome[startIndex + 1, endIndex - 1] || endIndex - startIndex <= 2;
                if (str[startIndex] == str[endIndex] && isInnerWordPalindrome)
                {
                    isPalindrome[startIndex, endIndex] = true;

                    int currentLength = endIndex - startIndex + 1;
                    if (currentLength > bestLength)
                    {
                        bestStartIndex = startIndex;
                        bestLength = currentLength;
                    }
                }
            }
        }

        return str.Substring(bestStartIndex, bestLength);
    }
}