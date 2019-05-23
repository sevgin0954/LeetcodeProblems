using System;

class Program
{
    static void Main()
    {
        Console.WriteLine(StrStr("mississippi", "issip"));
    }

    public static int StrStr(string haystack, string needle)
    {
        if (string.IsNullOrEmpty(needle))
        {
            return 0;
        }

        var needleCurrentIndex = 0;
        for (int i = 0; i < haystack.Length; i++)
        {
            if (haystack[i] == needle[needleCurrentIndex])
            {
                needleCurrentIndex++;
                if (needleCurrentIndex == needle.Length)
                {
                    return (i + 1) - needle.Length;
                }
            }
            else
            {
                i -= needleCurrentIndex;
                needleCurrentIndex = 0;
            }
        }

        return -1;
    }
}