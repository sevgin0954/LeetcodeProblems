using System;

class Program
{
    static void Main()
    {
        Console.WriteLine(MyAtoi("+-2"));
    }

    public static int MyAtoi(string str)
    {
        str = str.TrimStart(' ');
        if (str.Length == 0)
        {
            return 0;
        }

        int numLength = 0;
        string numAsString = "";
        int strIndex = 0;
        if (str[0] == '-' || str[0] == '+')
        {
            strIndex++;
            numAsString += str[0];
        }

        while (strIndex < str.Length && char.IsNumber(str[strIndex]))
        {
            numAsString += str[strIndex];
            strIndex++;
            numLength++;
        }

        int result = 0;
        if (numLength == 0)
        {
            result = 0;
        }
        else
        {
            var isParseSuccessful = int.TryParse(numAsString, out result);
            if (isParseSuccessful == false)
            {
                result = str[0] == '-' ? int.MinValue : int.MaxValue;
            }
        }

        return result;
    }
}