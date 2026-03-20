using System;
using System.IO;
using System.Collections.Generic;

class MiniNotepad
{
    static void Main()
    {
        int choice = 0;

        do
        {
            Console.WriteLine("\n1. Create New File");
            Console.WriteLine("2. Write to File");
            Console.WriteLine("3. Read File");
            Console.WriteLine("4. Append Text");
            Console.WriteLine("5. Delete File");
            Console.WriteLine("6. Exit");
            Console.Write("Enter choice: ");

            int.TryParse(Console.ReadLine(), out choice);

            switch (choice)
            {
                case 1:
                    CreateFile();
                    break;
                case 2:
                    WriteFile();
                    break;
                case 3:
                    ReadFile();
                    break;
                case 4:
                    AppendFile();
                    break;
                case 5:
                    DeleteFile();
                    break;
                case 6:
                    Console.WriteLine("Exiting...");
                    break;
                default:
                    Console.WriteLine("Invalid choice");
                    break;
            }

        } while (choice != 6);
    }

    static void CreateFile()
    {
        try
        {
            Console.Write("Enter file name: ");
            string name = Console.ReadLine() ?? "";

            if (name == "")
            {
                Console.WriteLine("Invalid input");
                return;
            }

            string fileName = name + ".txt";

            using (FileStream fs = new FileStream(fileName, FileMode.Create))
            {
            }

            Console.WriteLine("File created successfully.");
        }
        catch (UnauthorizedAccessException)
        {
            Console.WriteLine("Access denied.");
        }
        catch (Exception e)
        {
            Console.WriteLine("Error: " + e.Message);
        }
    }

    static void WriteFile()
    {
        try
        {
            Console.Write("Enter file name: ");
            string name = Console.ReadLine() ?? "";

            if (name == "")
            {
                Console.WriteLine("Invalid input");
                return;
            }

            string fileName = name + ".txt";

            using (FileStream fs = new FileStream(fileName, FileMode.Create))
            using (StreamWriter sw = new StreamWriter(fs))
            {
                Console.WriteLine("Enter text (type END to stop):");

                while (true)
                {
                    string line = Console.ReadLine() ?? "";
                    if (line.ToUpper() == "END")
                        break;

                    sw.WriteLine(line);
                }
            }

            Console.WriteLine("Content written successfully.");
        }
        catch (UnauthorizedAccessException)
        {
            Console.WriteLine("Access denied.");
        }
        catch (Exception e)
        {
            Console.WriteLine("Error: " + e.Message);
        }
    }

    static void ReadFile()
    {
        try
        {
            Console.Write("Enter file name: ");
            string name = Console.ReadLine() ?? "";

            if (name == "")
            {
                Console.WriteLine("Invalid input");
                return;
            }

            string fileName = name + ".txt";

            if (!File.Exists(fileName))
            {
                Console.WriteLine("File not found.");
                return;
            }

            using (FileStream fs = new FileStream(fileName, FileMode.Open))
            using (StreamReader sr = new StreamReader(fs))
            {
                Console.WriteLine("\nFile Content:");
                Console.WriteLine(sr.ReadToEnd());
            }
        }
        catch (UnauthorizedAccessException)
        {
            Console.WriteLine("Access denied.");
        }
        catch (Exception e)
        {
            Console.WriteLine("Error: " + e.Message);
        }
    }

    static void AppendFile()
    {
        try
        {
            Console.Write("Enter file name: ");
            string name = Console.ReadLine() ?? "";

            if (name == "")
            {
                Console.WriteLine("Invalid input");
                return;
            }

            string fileName = name + ".txt";

            if (!File.Exists(fileName))
            {
                Console.WriteLine("File not found.");
                return;
            }

            using (FileStream fs = new FileStream(fileName, FileMode.Append))
            using (StreamWriter sw = new StreamWriter(fs))
            {
                Console.WriteLine("Enter text to append (type END to stop):");

                while (true)
                {
                    string line = Console.ReadLine() ?? "";
                    if (line.ToUpper() == "END")
                        break;

                    sw.WriteLine(line);
                }
            }

            Console.WriteLine("Content appended successfully.");
        }
        catch (UnauthorizedAccessException)
        {
            Console.WriteLine("Access denied.");
        }
        catch (Exception e)
        {
            Console.WriteLine("Error: " + e.Message);
        }
    }

    static void DeleteFile()
    {
        try
        {
            Console.Write("Enter file name: ");
            string name = Console.ReadLine() ?? "";

            if (name == "")
            {
                Console.WriteLine("Invalid input");
                return;
            }

            string fileName = name + ".txt";

            if (!File.Exists(fileName))
            {
                Console.WriteLine("File not found.");
                return;
            }

            File.Delete(fileName);

            Console.WriteLine("File deleted successfully.");
        }
        catch (UnauthorizedAccessException)
        {
            Console.WriteLine("Access denied.");
        }
        catch (Exception e)
        {
            Console.WriteLine("Error: " + e.Message);
        }
    }
}