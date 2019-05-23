using System;
using System.Collections.Generic;

public class Print
{
    public static void PrintLine(IList<IList<int>> numbersCollections)
    {
        foreach (var combination in numbersCollections)
        {
            Console.WriteLine(string.Join(", ", combination));
        }
    }

    public static void PrintLine(IList<string> collection)
    {
        foreach (var currentStr in collection)
        {
            Console.WriteLine(currentStr);
        }
    }
}