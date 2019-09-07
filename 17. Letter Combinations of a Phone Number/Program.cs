using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        var combinations = LetterCombinations("23");
        Console.WriteLine(string.Join(" ", combinations));
    }

    public static IList<string> LetterCombinations(string digits)
    {
        if (digits.Length == 0)
        {
            return new List<string>();
        }

        var digitsLetters = new Dictionary<char, string>(8)
        {
            { '2', "abc" },
            { '3', "def" },
            { '4', "ghi" },
            { '5', "jkl" },
            { '6', "mno" },
            { '7', "pqrs" },
            { '8', "tuv" },
            { '9', "wxyz" }
        };

        var letters = GetLettersFromDigits(digits, digitsLetters);
        var combinations = new List<string>();
        GenerateAllCombinations(combinations, letters, new char[digits.Length]);

        return combinations;
    }

    private static string[] GetLettersFromDigits(string digits, Dictionary<char, string> digitsLetters)
    {
        List<string> letters = new List<string>();
        foreach (var digit in digits)
        {
            letters.Add(digitsLetters[digit]);
        }

        return letters.ToArray();
    }

    public static void GenerateAllCombinations(
        List<string> resultCombination,
        string[] letters,
        char[] currentCombination,
        int index = 0)
    {
        if (index == letters.Length)
        {
            var currentCombinationString = string.Join("", currentCombination);
            resultCombination.Add(currentCombinationString);

            return;
        }

        var currentLetters = letters[index];
        for (int i = 0; i < currentLetters.Length; i++)
        {
            currentCombination[index] = currentLetters[i];
            GenerateAllCombinations(resultCombination, letters, currentCombination, index + 1);
        }
    }
}