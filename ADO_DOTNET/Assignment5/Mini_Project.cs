using System;
using Microsoft.Data.SqlClient;

class Program
{
    static string cs = "Server=Thiru\\SQLEXPRESS;Database=LibraryDB;Trusted_Connection=True;TrustServerCertificate=True;";

    static void Main()
    {
        while (true)
        {
            Console.WriteLine("1.Add 2.View 3.Update 4.Delete 5.Search 6.Exit");
            int ch = ReadInt();

            if (ch == 1) Add();
            else if (ch == 2) View();
            else if (ch == 3) Update();
            else if (ch == 4) Delete();
            else if (ch == 5) Search();
            else break;
        }
    }

    static int ReadInt()
    {
        int v;
        while (!int.TryParse(Console.ReadLine(), out v))
            Console.Write("Enter valid number: ");
        return v;
    }

    static string ReadString()
    {
        string? s = Console.ReadLine();
        return s ?? "";
    }

    static void Add()
    {
        using (SqlConnection con = new SqlConnection(cs))
        {
            con.Open();

            Console.Write("Title: ");
            string title = ReadString();

            string q = "INSERT INTO Books (Title) VALUES (@t)";
            SqlCommand cmd = new SqlCommand(q, con);
            cmd.Parameters.AddWithValue("@t", title);

            cmd.ExecuteNonQuery();
            Console.WriteLine("Book Added");
        }
    }

    static void View()
    {
        using (SqlConnection con = new SqlConnection(cs))
        {
            con.Open();

            string q = "SELECT * FROM Books";
            SqlCommand cmd = new SqlCommand(q, con);
            SqlDataReader r = cmd.ExecuteReader();

            while (r.Read())
                Console.WriteLine($"{r["BookId"]} {r["Title"]}");
        }
    }

    static void Update()
    {
        using (SqlConnection con = new SqlConnection(cs))
        {
            con.Open();

            Console.Write("BookId: ");
            int id = ReadInt();

            Console.Write("New Title: ");
            string title = ReadString();

            string q = "UPDATE Books SET Title=@t WHERE BookId=@id";
            SqlCommand cmd = new SqlCommand(q, con);

            cmd.Parameters.AddWithValue("@t", title);
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

            Console.Write("BookId: ");
            int id = ReadInt();

            string q = "DELETE FROM Books WHERE BookId=@id";
            SqlCommand cmd = new SqlCommand(q, con);
            cmd.Parameters.AddWithValue("@id", id);

            cmd.ExecuteNonQuery();
            Console.WriteLine("Deleted");
        }
    }

    static void Search()
    {
        using (SqlConnection con = new SqlConnection(cs))
        {
            con.Open();

            Console.Write("Search Title: ");
            string title = ReadString();

            string q = "SELECT * FROM Books WHERE Title LIKE @t";
            SqlCommand cmd = new SqlCommand(q, con);
            cmd.Parameters.AddWithValue("@t", "%" + title + "%");

            SqlDataReader r = cmd.ExecuteReader();

            while (r.Read())
                Console.WriteLine($"{r["BookId"]} {r["Title"]}");
        }
    }
}