using System;

class Program
{
    static void Main()
    {
        Console.WriteLine(Reverse(-123));
    }

    public static int Reverse(int num)
    {
        var isNumNegative = false;
        if (num < 0)
        {
            isNumNegative = true;
        }

        var numAsString = "";
        if (isNumNegative)
        {
            numAsString = (num * -1).ToString();
        }
        else
        {
            numAsString = num.ToString();
        }
        var reversedString = ReverseString(numAsString);

        var result = 0;
        var isParseSuccessful = int.TryParse(reversedString, out result);
        if (isParseSuccessful)
        {
            if (isNumNegative)
            {
                result *= -1;
            }

            return result;
        }
        else
        {
            return 0;
        }
    }

    private static string ReverseString(string str)
    {
        var strAsArray = str.ToCharArray();
        Array.Reverse(strAsArray);

        var result = string.Join("", strAsArray);
        return result;
    }
}