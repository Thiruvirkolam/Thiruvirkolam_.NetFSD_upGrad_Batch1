using System;
using System.Collections.Generic;
using System.Text;

class Student
{
    public int Id { get; set; }
    public string? Name { get; set; }
    public int Marks { get; set; }

    public Student(int id, string? name, int marks)
    {
        Id = id;
        Name = name;
        Marks = marks;
    }
}

class Program
{
    static void Main()
    {
        Dictionary<int, Student> students = new Dictionary<int, Student>();
        students.Add(1, new Student(1, "Ashwin", 85));
        students.Add(2, new Student(2, "Thiru", 72));
        students.Add(3, new Student(3, "Rithick", 90));
        students.Add(4, new Student(4, "Kowshik", 65));
        students.Add(5, new Student(5, "Kishore", 78));

        int searchId = 3;
        if (students.ContainsKey(searchId))
        {
            var s = students[searchId];
            Console.WriteLine($"Found: {s.Id} {s.Name} {s.Marks}");
        }

        int checkId = 6;
        Console.WriteLine(students.ContainsKey(checkId) ? "Exists" : "Does not exist");

        int updateId = 2;
        if (students.ContainsKey(updateId))
        {
            students[updateId].Marks = 80;
        }

        int removeId = 4;
        students.Remove(removeId);

        Console.WriteLine("\nStudents with marks above 75:");
        foreach (var s in students.Values)
        {
            if (s.Marks > 75)
            {
                Console.WriteLine($"{s.Id} {s.Name} {s.Marks}");
            }
        }
    }
}