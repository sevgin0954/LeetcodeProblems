using System.Collections.Generic;

class Program
{
    static void Main()
    {
        var paranthesis = GenerateParenthesis(3);
        Print.PrintLine(paranthesis);
    }

    public static IList<string> GenerateParenthesis(int n)
    {
        var paranthesis = new List<string>();
        GenerateParenthesisRecursion(paranthesis, new char[n * 2]);

        return paranthesis;
    }

    public static void GenerateParenthesisRecursion(
        IList<string> paranthesis, char[] current, int index = 0)
    {
        if (index == current.Length)
        {
            if (IsParenthesisValid(current))
            {
                paranthesis.Add(string.Join("", current));
            }
        }
        else
        {
            current[index] = '(';
            GenerateParenthesisRecursion(paranthesis, current, index + 1);
            current[index] = ')';
            GenerateParenthesisRecursion(paranthesis, current, index + 1);
        }
    }

    private static bool IsParenthesisValid(char[] parenthesis)
    {
        var balance = 0;
        foreach (var ch in parenthesis)
        {
            if (ch == '(')
            {
                balance++;
            }
            else
            {
                balance--;
            }

            if (balance < 0)
            {
                return false;
            }
        }

        if (balance == 0)
        {
            return true;
        }
        else
        {
            return false;
        }
    }
}