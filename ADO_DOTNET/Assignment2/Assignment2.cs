using System;
using System.Data;
using Microsoft.Data.SqlClient;

class Program
{
    static string cs = "Server=Thiru\\SQLEXPRESS;Database=EmployeeDB;Trusted_Connection=True;TrustServerCertificate=True;";

    static void Main()
    {
        while (true)
        {
            Console.WriteLine("1.Insert 2.ViewByDept 3.UpdateSalary 4.Delete 5.Exit");
            int ch = ReadInt();

            if (ch == 1) Insert();
            else if (ch == 2) ViewByDept();
            else if (ch == 3) UpdateSalary();
            else if (ch == 4) Delete();
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

    static decimal ReadDecimal()
    {
        decimal v;
        while (!decimal.TryParse(Console.ReadLine(), out v))
            Console.Write("Enter valid amount: ");
        return v;
    }

    static void Insert()
    {
        using (SqlConnection con = new SqlConnection(cs))
        {
            con.Open();

            Console.Write("Name: ");
            string name = ReadString();

            Console.Write("Salary: ");
            decimal salary = ReadDecimal();

            Console.Write("Department: ");
            string dept = ReadString();

            SqlCommand cmd = new SqlCommand("InsertEmployee", con);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@Name", name);
            cmd.Parameters.AddWithValue("@Salary", salary);
            cmd.Parameters.AddWithValue("@Department", dept);

            cmd.ExecuteNonQuery();
            Console.WriteLine("Inserted");
        }
    }

    static void ViewByDept()
    {
        using (SqlConnection con = new SqlConnection(cs))
        {
            con.Open();

            Console.Write("Department: ");
            string dept = ReadString();

            string q = "SELECT * FROM Employees WHERE Department=@d";
            SqlCommand cmd = new SqlCommand(q, con);
            cmd.Parameters.AddWithValue("@d", dept);

            SqlDataReader r = cmd.ExecuteReader();

            while (r.Read())
                Console.WriteLine($"{r["EmpId"]} {r["Name"]} {r["Salary"]} {r["Department"]}");
        }
    }

    static void UpdateSalary()
    {
        using (SqlConnection con = new SqlConnection(cs))
        {
            con.Open();

            Console.Write("EmpId: ");
            int id = ReadInt();

            Console.Write("New Salary: ");
            decimal salary = ReadDecimal();

            SqlCommand cmd = new SqlCommand("UpdateSalary", con);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@EmpId", id);
            cmd.Parameters.AddWithValue("@Salary", salary);

            cmd.ExecuteNonQuery();
            Console.WriteLine("Updated");
        }
    }

    static void Delete()
    {
        using (SqlConnection con = new SqlConnection(cs))
        {
            con.Open();

            Console.Write("EmpId: ");
            int id = ReadInt();

            string q = "DELETE FROM Employees WHERE EmpId=@id";
            SqlCommand cmd = new SqlCommand(q, con);
            cmd.Parameters.AddWithValue("@id", id);

            cmd.ExecuteNonQuery();
            Console.WriteLine("Deleted");
        }
    }
}