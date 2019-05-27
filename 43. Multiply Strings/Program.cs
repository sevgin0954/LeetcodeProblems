using System;
using System.Text;

class Program
{
    static void Main()
    {
        Console.WriteLine(Multiply("123", "2") == "246");
        Console.WriteLine(Multiply("2", "123") == "246");
        Console.WriteLine(Multiply("12", "12") == "144");
        Console.WriteLine(Multiply("111", "1111") == "123321");
        Console.WriteLine(Multiply("5", "90") == "450");
        Console.WriteLine(Multiply("123", "456") == "56088");
    }

    public static string Multiply(string num1, string num2)
    {
        var result = "0";

        var shift = new StringBuilder();
        for (int i = num1.Length - 1; i >= 0; i--)
        {
            var currentNum1AsInt = num1[i] - '0';
            var currentNum1Sum = new StringBuilder();
            var left = 0;
            for (int j = num2.Length - 1; j >= 0; j--)
            {
                var currentNum2AsInt = num2[j] - '0';
                var currentNum2Sum = (currentNum1AsInt * currentNum2AsInt) + left;
                left = currentNum2Sum / 10;
                currentNum2Sum %= 10;

                currentNum1Sum.Append(currentNum2Sum);
            }

            if (left > 0)
            {
                currentNum1Sum.Append(left);
            }

            var currentNum1SumAsString = ReverseString(currentNum1Sum.ToString());
            currentNum1SumAsString += shift.ToString();
            shift.Append("0");

            result = Sum(result, currentNum1SumAsString);
        }

        return result;
    }

    public static string Sum(string num1, string num2)
    {
        var result = new StringBuilder();

        var left = 0;

        var num1CurrentIndex = num1.Length - 1;
        var num2CurrentIndex = num2.Length - 1;
        while (num1CurrentIndex >= 0 && num2CurrentIndex >= 0)
        {
            var currentNum1AsInt = num1[num1CurrentIndex] - '0';
            var currentNum2AsInt = num2[num2CurrentIndex] - '0';
            var currentSum = currentNum1AsInt + currentNum2AsInt + left;
            left = currentSum / 10;
            currentSum %= 10;

            num1CurrentIndex--;
            num2CurrentIndex--;

            result.Append(currentSum);
        }

        while (num1CurrentIndex >= 0)
        {
            var currentNumAsInt = num1[num1CurrentIndex] - '0';
            var currentSum = currentNumAsInt + left;
            left = currentSum / 10;
            currentSum %= 10;

            num1CurrentIndex--;

            result.Append(currentSum);
        }
        while (num2CurrentIndex >= 0)
        {
            var currentNumAsInt = num2[num2CurrentIndex] - '0';
            var currentSum = currentNumAsInt + left;
            left = currentSum / 10;
            currentSum %= 10;

            num2CurrentIndex--;

            result.Append(currentSum);
        }

        if (left > 0)
        {
            result.Append(left);
        }

        var resultAsString = result.ToString();
        resultAsString = resultAsString.TrimEnd('0');
        if (resultAsString.Length == 0)
        {
            return "0";
        }
        else
        {
            return ReverseString(resultAsString);
        }
    }

    private static string ReverseString(string str)
    {
        var strAsArray = str.ToCharArray();
        Array.Reverse(strAsArray);
        return string.Join("", strAsArray);
    }
}