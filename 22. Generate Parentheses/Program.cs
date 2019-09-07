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
        var parenthesis = new List<string>();

        GenerateParenthesisReccursion(parenthesis, new char[n * 2]);

        return parenthesis;
    }

    private static void GenerateParenthesisReccursion(
        List<string> output,
        char[] parenthesis,
        int depth = 0,
        int parenthesisCounter = 0)
    {
        if (parenthesisCounter < 0 || parenthesisCounter > parenthesis.Length / 2)
        {
            return;
        }
        if (depth >= parenthesis.Length)
        {
            if (parenthesisCounter == 0)
            {
                var parenthesisAsString = string.Join("", parenthesis);
                output.Add(parenthesisAsString);
            }

            return;
        }

        parenthesis[depth] = '(';
        GenerateParenthesisReccursion(output, parenthesis, depth + 1, parenthesisCounter + 1);

        parenthesis[depth] = ')';
        GenerateParenthesisReccursion(output, parenthesis, depth + 1, parenthesisCounter - 1);
    }
}