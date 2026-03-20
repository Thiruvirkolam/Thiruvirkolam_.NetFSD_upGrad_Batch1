using System;
using System.IO;
using System.Collections.Generic;

class StudentReport
{
    static void Main()
    {
        int choice = 0;

        do
        {
            Console.WriteLine("\n1. Create Report Card");
            Console.WriteLine("2. View Report Card");
            Console.WriteLine("3. Exit");
            Console.Write("Enter choice: ");

            int.TryParse(Console.ReadLine(), out choice);

            switch (choice)
            {
                case 1:
                    CreateReport();
                    break;
                case 2:
                    ViewReport();
                    break;
                case 3:
                    Console.WriteLine("Exiting...");
                    break;
                default:
                    Console.WriteLine("Invalid choice");
                    break;
            }

        } while (choice != 3);
    }

    static void CreateReport()
    {
        try
        {
            Console.Write("Enter Name: ");
            string name = Console.ReadLine() ?? "";

            Console.Write("Enter Roll Number: ");
            string roll = Console.ReadLine() ?? "";

            if (name == "" || roll == "")
            {
                Console.WriteLine("Invalid input");
                return;
            }

            Console.Write("Enter Marks for Subject 1: ");
            int.TryParse(Console.ReadLine(), out int m1);

            Console.Write("Enter Marks for Subject 2: ");
            int.TryParse(Console.ReadLine(), out int m2);

            Console.Write("Enter Marks for Subject 3: ");
            int.TryParse(Console.ReadLine(), out int m3);

            if (m1 < 0 || m2 < 0 || m3 < 0 || m1 > 100 || m2 > 100 || m3 > 100)
            {
                Console.WriteLine("Marks should be between 0 and 100");
                return;
            }

            int total = m1 + m2 + m3;
            double average = total / 3.0;

            string grade;

            if (average >= 75)
                grade = "A";
            else if (average >= 50)
                grade = "B";
            else if (average >= 35)
                grade = "C";
            else
                grade = "Fail";

            string content =
                "Student Name: " + name + Environment.NewLine +
                "Roll Number: " + roll + Environment.NewLine +
                "Marks: " + m1 + ", " + m2 + ", " + m3 + Environment.NewLine +
                "Total: " + total + Environment.NewLine +
                "Average: " + average + Environment.NewLine +
                "Grade: " + grade;

            string fileName = roll + ".txt";

            File.WriteAllText(fileName, content);

            Console.WriteLine("Report card generated successfully.");
        }
        catch (Exception e)
        {
            Console.WriteLine("Error: " + e.Message);
        }
    }

    static void ViewReport()
    {
        try
        {
            Console.Write("Enter Roll Number: ");
            string roll = Console.ReadLine() ?? "";

            if (roll == "")
            {
                Console.WriteLine("Invalid input");
                return;
            }

            string fileName = roll + ".txt";

            if (!File.Exists(fileName))
            {
                Console.WriteLine("Report not found.");
                return;
            }

            string content = File.ReadAllText(fileName);

            Console.WriteLine("\nReport Card:");
            Console.WriteLine(content);
        }
        catch (Exception e)
        {
            Console.WriteLine("Error: " + e.Message);
        }
    }
}