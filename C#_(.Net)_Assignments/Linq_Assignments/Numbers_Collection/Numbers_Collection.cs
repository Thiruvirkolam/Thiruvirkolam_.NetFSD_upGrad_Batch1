using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main()
    {
        var numbers = new List<int> { 5, 10, 15, 20, 25, 30 };

        var evens = numbers.Where(n => n % 2 == 0);
        Console.WriteLine("Even Numbers:");
        foreach (var n in evens)
            Console.WriteLine(n);

        var greater15 = numbers.Where(n => n > 15);
        Console.WriteLine("\nNumbers > 15:");
        foreach (var n in greater15)
            Console.WriteLine(n);

        var squares = numbers.Select(n => n * n);
        Console.WriteLine("\nSquares:");
        foreach (var n in squares)
            Console.WriteLine(n);

        var divisibleBy5Count = numbers.Count(n => n % 5 == 0);
        Console.WriteLine("\nCount divisible by 5: " + divisibleBy5Count);
    }
}