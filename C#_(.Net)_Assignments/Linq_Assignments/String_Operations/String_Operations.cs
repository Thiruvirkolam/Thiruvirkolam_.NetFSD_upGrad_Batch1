using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main()
    {
        var names = new List<string> { "Ashwin", "Kiran", "Raghul", "Harish", "Krishna" };

        var startWithA = names.Where(n => n.StartsWith("A"));
        Console.WriteLine("Names starting with A:");
        foreach (var n in startWithA)
            Console.WriteLine(n);

        var sortedNames = names.OrderBy(n => n);
        Console.WriteLine("\nSorted Names:");
        foreach (var n in sortedNames)
            Console.WriteLine(n);

        var upperNames = names.Select(n => n.ToUpper());
        Console.WriteLine("\nUppercase Names:");
        foreach (var n in upperNames)
            Console.WriteLine(n);

        var lengthGreater4 = names.Where(n => n.Length > 4);
        Console.WriteLine("\nNames with length > 4:");
        foreach (var n in lengthGreater4)
            Console.WriteLine(n);
    }
}