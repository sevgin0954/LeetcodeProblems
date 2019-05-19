using System;
using System.Collections.Generic;

public class Print
{
    public static void PrintNumbersCollections(IList<IList<int>> numbersCollections)
    {
        foreach (var combination in numbersCollections)
        {
            Console.WriteLine(string.Join(", ", combination));
        }
    }
}