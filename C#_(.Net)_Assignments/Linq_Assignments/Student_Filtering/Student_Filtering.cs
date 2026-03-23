using System;
using System.Collections.Generic;
using System.Linq;

class Student
{
    public int Id { get; set; }
    public string? Name { get; set; }
    public int Age { get; set; }
    public int Marks { get; set; }
}

class Program
{
    static void Main()
    {
        var students = new List<Student>
        {
            new Student{Id=1,Name="Thiru",Age=20,Marks=80},
            new Student{Id=2,Name="Kishore",Age=17,Marks=70},
            new Student{Id=3,Name="Kowshik",Age=22,Marks=90},
            new Student{Id=4,Name="Rithick",Age=25,Marks=60}
        };

        var highMarks = students.Where(s => s.Marks > 75);
        Console.WriteLine("Marks > 75:");
        foreach (var s in highMarks)
            Console.WriteLine(s.Name + " " + s.Marks);

        var ageRange = students.Where(s => s.Age >= 18 && s.Age <= 25);
        Console.WriteLine("\nAge between 18 and 25:");
        foreach (var s in ageRange)
            Console.WriteLine(s.Name + " " + s.Age);

        var sortedMarks = students.OrderByDescending(s => s.Marks);
        Console.WriteLine("\nSorted by Marks (Descending):");
        foreach (var s in sortedMarks)
            Console.WriteLine(s.Name + " " + s.Marks);

        var nameMarks = students.Select(s => new { s.Name, s.Marks });
        Console.WriteLine("\nName and Marks:");
        foreach (var s in nameMarks)
            Console.WriteLine(s.Name + " " + s.Marks);
    }
}
