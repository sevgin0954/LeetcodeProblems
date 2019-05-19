using System;
using System.Text;

class Program
{
    static void Main()
    {
        var strs = new string[] { "flower", "flow", "flight" };
        Console.WriteLine(LongestCommonPrefix(strs));
    }

    public static string LongestCommonPrefix(string[] strs)
    {
        if (strs.Length == 0)
        {
            return "";
        }

        for (int i = 0; i < strs[0].Length; i++)
        {
            var ch = strs[0][i];
            for (int j = 1; j < strs.Length; j++)
            {
                if (strs[j].Length == i || strs[j][i] != ch)
                {
                    return strs[0].Substring(0, i);
                }
            }
        }

        return strs[0];
    }
}