using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        var str = "abba";
        Console.WriteLine(LengthOfLongestSubstring(str));
    }

    public static int LengthOfLongestSubstring(string str)
    {
        var charsIndexes = new Dictionary<char, int>(str.Length);
        var bestLength = 0;

        var currentLength = 0;
        var startIndex = 0;
        for (int i = 0; i < str.Length; i++)
        {
            var currentChar = str[i];
            if (charsIndexes.ContainsKey(currentChar) && charsIndexes[currentChar] >= startIndex)
            {
                startIndex = charsIndexes[currentChar] + 1;
                currentLength = i - startIndex;
            }

            currentLength++;
            if (currentLength > bestLength)
            {
                bestLength = currentLength;
            }

            charsIndexes[currentChar] = i;
        }

        return bestLength;
    }
}