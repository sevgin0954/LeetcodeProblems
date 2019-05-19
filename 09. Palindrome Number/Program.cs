using System;

class Program
{
    static void Main()
    {
        Console.WriteLine(IsPalindrome(1212));
    }

    public static bool IsPalindrome(int num)
    {
        var numAsString = num.ToString();

        int startIndex = 0;
        int endIndex = numAsString.Length - 1;
        while (startIndex < endIndex)
        {
            if (numAsString[startIndex] != numAsString[endIndex])
            {
                return false;
            }

            startIndex++;
            endIndex--;
        }

        return true;
    }
}