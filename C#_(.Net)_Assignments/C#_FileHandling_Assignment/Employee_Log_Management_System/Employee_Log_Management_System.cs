using System;
using System.IO;
using System.Collections.Generic;

class EmployeeLog
{
    static string filePath = "employee_log.txt";

    static void Main()
    {
        if (!File.Exists(filePath))
        {
            File.Create(filePath).Close();
        }

        int choice = 0;

        do
        {
            Console.WriteLine("\n1. Add Login Entry");
            Console.WriteLine("2. Update Logout Time");
            Console.WriteLine("3. View Logs");
            Console.WriteLine("4. Exit");
            Console.Write("Enter choice: ");

            int.TryParse(Console.ReadLine(), out choice);

            switch (choice)
            {
                case 1:
                    AddLogin();
                    break;
                case 2:
                    UpdateLogout();
                    break;
                case 3:
                    ViewLogs();
                    break;
                case 4:
                    Console.WriteLine("Exiting...");
                    break;
                default:
                    Console.WriteLine("Invalid choice");
                    break;
            }

        } while (choice != 4);
    }

    static void AddLogin()
    {
        try
        {
            Console.Write("Enter Employee ID: ");
            string id = Console.ReadLine() ?? "";

            Console.Write("Enter Name: ");
            string name = Console.ReadLine() ?? "";

            if (id == "" || name == "")
            {
                Console.WriteLine("Invalid input");
                return;
            }

            string loginTime = DateTime.Now.ToString();
            string logoutTime = "NA";

            using (StreamWriter sw = new StreamWriter(filePath, true))
            {
                sw.WriteLine(id + "|" + name + "|" + loginTime + "|" + logoutTime);
            }

            Console.WriteLine("Login entry added.");
        }
        catch (Exception e)
        {
            Console.WriteLine("Error: " + e.Message);
        }
    }

    static void UpdateLogout()
    {
        try
        {
            Console.Write("Enter Employee ID: ");
            string id = Console.ReadLine() ?? "";

            if (id == "")
            {
                Console.WriteLine("Invalid input");
                return;
            }

            List<string> lines = new List<string>(File.ReadAllLines(filePath));
            bool updated = false;

            for (int i = 0; i < lines.Count; i++)
            {
                string[] parts = lines[i].Split('|');

                if (parts.Length == 4 && parts[0] == id && parts[3] == "NA")
                {
                    parts[3] = DateTime.Now.ToString();
                    lines[i] = string.Join("|", parts);
                    updated = true;
                    break;
                }
            }

            File.WriteAllLines(filePath, lines);

            if (updated)
                Console.WriteLine("Logout time updated.");
            else
                Console.WriteLine("Employee not found or already logged out.");
        }
        catch (Exception e)
        {
            Console.WriteLine("Error: " + e.Message);
        }
    }

    static void ViewLogs()
    {
        try
        {
            string[] lines = File.ReadAllLines(filePath);

            if (lines.Length == 0)
            {
                Console.WriteLine("No records found.");
                return;
            }

            Console.WriteLine("\nEmployee Logs:");
            foreach (var line in lines)
            {
                Console.WriteLine(line);
            }
        }
        catch (Exception e)
        {
            Console.WriteLine("Error: " + e.Message);
        }
    }
}