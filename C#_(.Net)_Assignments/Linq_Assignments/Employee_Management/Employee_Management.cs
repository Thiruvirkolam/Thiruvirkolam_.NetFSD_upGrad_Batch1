using System;
using System.Collections.Generic;
using System.Linq;

class Employee
{
    public int Id { get; set; }
    public string? Name { get; set; }
    public string? Department { get; set; }
    public double Salary { get; set; }
}

class Program
{
    static void Main()
    {
        var employees = new List<Employee>
        {
            new Employee{Id=1,Name="A",Department="IT",Salary=5000},
            new Employee{Id=2,Name="B",Department="HR",Salary=4000},
            new Employee{Id=3,Name="C",Department="IT",Salary=7000},
            new Employee{Id=4,Name="D",Department="Finance",Salary=6000}
        };

        var itEmployees = employees.Where(e => e.Department == "IT");
        Console.WriteLine("IT Employees:");
        foreach (var e in itEmployees)
            Console.WriteLine(e.Name + " " + e.Salary);

        var highestSalary = employees.OrderByDescending(e => e.Salary).FirstOrDefault();
        Console.WriteLine("\nHighest Salary Employee:");
        Console.WriteLine(highestSalary.Name + " " + highestSalary.Salary);

        var avgSalary = employees.Average(e => e.Salary);
        Console.WriteLine("\nAverage Salary: " + avgSalary);

        var groupByDept = employees.GroupBy(e => e.Department);
        Console.WriteLine("\nEmployees Grouped by Department:");
        foreach (var group in groupByDept)
        {
            Console.WriteLine(group.Key + ":");
            foreach (var e in group)
                Console.WriteLine("  " + e.Name);
        }

        var countByDept = employees.GroupBy(e => e.Department)
                                   .Select(g => new { Dept = g.Key, Count = g.Count() });

        Console.WriteLine("\nEmployee Count by Department:");
        foreach (var g in countByDept)
            Console.WriteLine(g.Dept + " " + g.Count);
    }
}