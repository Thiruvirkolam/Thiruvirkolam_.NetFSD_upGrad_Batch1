using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main()
    {
        var numbers = new List<int> { 1, 2, 3, 2, 4, 5, 3, 6 };

        var distinctNums = numbers.Distinct();
        Console.WriteLine("Unique Numbers:");
        foreach (var n in distinctNums)
            Console.WriteLine(n);

        var duplicates = numbers.GroupBy(n => n)
                                .Where(g => g.Count() > 1)
                                .Select(g => g.Key);

        Console.WriteLine("\nDuplicate Numbers:");
        foreach (var n in duplicates)
            Console.WriteLine(n);

        var occurrence = numbers.GroupBy(n => n)
                                .Select(g => new { Number = g.Key, Count = g.Count() });

        Console.WriteLine("\nOccurrence Count:");
        foreach (var x in occurrence)
            Console.WriteLine(x.Number + " -> " + x.Count);
    }
}