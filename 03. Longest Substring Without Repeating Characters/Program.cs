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
        int bestLength = 0;

        int currentLength = 0;
        int currentStartIndex = 0;
        Dictionary<char, int> lettersIndexes = new Dictionary<char, int>();
        for (int currentIndex = 0; currentIndex < str.Length; currentIndex++)
        {
            var currentLetter = str[currentIndex];

            if (lettersIndexes.ContainsKey(currentLetter) == false || lettersIndexes[currentLetter] < currentStartIndex)
            {
                currentLength++;
            }
            else
            {
                currentStartIndex = lettersIndexes[currentLetter];
                currentLength = currentIndex - currentStartIndex;
            }

            if (currentLength > bestLength)
            {
                bestLength = currentLength;
            }
            lettersIndexes[currentLetter] = currentIndex;
        }

        return bestLength;
    }
}