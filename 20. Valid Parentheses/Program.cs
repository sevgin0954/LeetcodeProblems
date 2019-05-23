using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        var brackets = "()]";
        Console.WriteLine(IsValid(brackets));
    }

    public static bool IsValid(string str)
    {
        var stack = new Stack<char>();
        var openingClosingBrackets = new Dictionary<char, char>()
        {
            { '(', ')' },
            { '[', ']' },
            { '{', '}' }
        };

        foreach (var ch in str)
        {
            if (openingClosingBrackets.ContainsKey(ch))
            {
                stack.Push(ch);
            }
            else
            {
                var topStack = ' ';
                if (stack.TryPop(out topStack) == false || openingClosingBrackets[topStack] != ch)
                {
                    return false;
                }
            }
        }

        if (stack.Count == 0)
        {
            return true;
        }
        else
        {
            return false;
        }
    }
}