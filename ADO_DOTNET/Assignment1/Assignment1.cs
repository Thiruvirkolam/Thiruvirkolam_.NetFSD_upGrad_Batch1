using System;
using Microsoft.Data.SqlClient;

class Program
{
    static string cs = "Server=Thiru\\SQLEXPRESS;Database=StudentDB;Trusted_Connection=True;TrustServerCertificate=True;";

    static void Main()
    {
        while (true)
        {
            Console.WriteLine("1.Insert 2.View 3.Update 4.Delete 5.Exit");
            int ch = ReadInt();

            if (ch == 1) Insert();
            else if (ch == 2) View();
            else if (ch == 3) Update();
            else if (ch == 4) Delete();
            else break;
        }
    }

    static int ReadInt()
    {
        int value;
        while (!int.TryParse(Console.ReadLine(), out value))
            Console.Write("Enter valid number: ");
        return value;
    }

    static string ReadString()
    {
        string? input = Console.ReadLine();
        return input ?? "";
    }

    static void Insert()
    {
        using (SqlConnection con = new SqlConnection(cs))
        {
            con.Open();

            Console.Write("Name: ");
            string name = ReadString();

            Console.Write("Age: ");
            int age = ReadInt();

            Console.Write("Grade: ");
            string grade = ReadString();

            string q = "INSERT INTO Students (Name, Age, Grade) VALUES (@n,@a,@g)";
            SqlCommand cmd = new SqlCommand(q, con);

            cmd.Parameters.AddWithValue("@n", name);
            cmd.Parameters.AddWithValue("@a", age);
            cmd.Parameters.AddWithValue("@g", grade);

            cmd.ExecuteNonQuery();
            Console.WriteLine("Inserted");
        }
    }

    static void View()
    {
        using (SqlConnection con = new SqlConnection(cs))
        {
            con.Open();

            string q = "SELECT * FROM Students";
            SqlCommand cmd = new SqlCommand(q, con);
            SqlDataReader r = cmd.ExecuteReader();

            while (r.Read())
                Console.WriteLine($"{r["Id"]} {r["Name"]} {r["Age"]} {r["Grade"]}");
        }
    }

    static void Update()
    {
        using (SqlConnection con = new SqlConnection(cs))
        {
            con.Open();

            Console.Write("Id: ");
            int id = ReadInt();

            Console.Write("New Grade: ");
            string grade = ReadString();

            string q = "UPDATE Students SET Grade=@g WHERE Id=@id";
            SqlCommand cmd = new SqlCommand(q, con);

            cmd.Parameters.AddWithValue("@g", grade);
            cmd.Parameters.AddWithValue("@id", id);

            cmd.ExecuteNonQuery();
            Console.WriteLine("Updated");
        }
    }

    static void Delete()
    {
        using (SqlConnection con = new SqlConnection(cs))
        {
            con.Open();

            Console.Write("Id: ");
            int id = ReadInt();

            string q = "DELETE FROM Students WHERE Id=@id";
            SqlCommand cmd = new SqlCommand(q, con);

            cmd.Parameters.AddWithValue("@id", id);

            cmd.ExecuteNonQuery();
            Console.WriteLine("Deleted");
        }
    }
}