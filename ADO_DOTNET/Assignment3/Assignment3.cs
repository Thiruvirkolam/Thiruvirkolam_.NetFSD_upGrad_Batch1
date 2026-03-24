using System;
using System.Data;
using Microsoft.Data.SqlClient;

class Program
{
    static string cs = "Server=Thiru\\SQLEXPRESS;Database=InventoryDB;Trusted_Connection=True;TrustServerCertificate=True;";

    static void Main()
    {
        SqlConnection con = new SqlConnection(cs);
        SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM Products", con);

        DataSet ds = new DataSet();
        da.Fill(ds, "Products");

        if (!ds.Tables.Contains("Products"))
        {
            Console.WriteLine("Table not found");
            return;
        }

        DataTable dt = ds.Tables["Products"]!;

        while (true)
        {
            Console.WriteLine("1.View 2.Add 3.Update 4.Delete 5.Save 6.Exit");
            int ch = ReadInt();

            if (ch == 1) View(dt);
            else if (ch == 2) Add(dt);
            else if (ch == 3) Update(dt);
            else if (ch == 4) Delete(dt);
            else if (ch == 5) Save(da, ds);
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

    static decimal ReadDecimal()
    {
        decimal v;
        while (!decimal.TryParse(Console.ReadLine(), out v))
            Console.Write("Enter valid amount: ");
        return v;
    }

    static string ReadString()
    {
        string? s = Console.ReadLine();
        return s ?? "";
    }

    static void View(DataTable dt)
    {
        foreach (DataRow r in dt.Rows)
        {
            if (r.RowState != DataRowState.Deleted)
                Console.WriteLine($"{r["ProductId"]} {r["ProductName"]} {r["Price"]} {r["Stock"]}");
        }
    }

    static void Add(DataTable dt)
    {
        DataRow row = dt.NewRow();

        Console.Write("Name: ");
        row["ProductName"] = ReadString();

        Console.Write("Price: ");
        row["Price"] = ReadDecimal();

        Console.Write("Stock: ");
        row["Stock"] = ReadInt();

        dt.Rows.Add(row);
        Console.WriteLine("Added (offline)");
    }

    static void Update(DataTable dt)
    {
        Console.Write("Enter ProductId: ");
        int id = ReadInt();

        foreach (DataRow r in dt.Rows)
        {
            if (r.RowState != DataRowState.Deleted && Convert.ToInt32(r["ProductId"]) == id)
            {
                Console.Write("New Price: ");
                r["Price"] = ReadDecimal();
                Console.WriteLine("Updated (offline)");
                return;
            }
        }

        Console.WriteLine("Not found");
    }

    static void Delete(DataTable dt)
    {
        Console.Write("Enter ProductId: ");
        int id = ReadInt();

        foreach (DataRow r in dt.Rows)
        {
            if (r.RowState != DataRowState.Deleted && Convert.ToInt32(r["ProductId"]) == id)
            {
                r.Delete();
                Console.WriteLine("Deleted (offline)");
                return;
            }
        }

        Console.WriteLine("Not found");
    }

    static void Save(SqlDataAdapter da, DataSet ds)
    {
        SqlCommandBuilder cb = new SqlCommandBuilder(da);
        da.Update(ds, "Products");
        Console.WriteLine("Changes saved to DB");
    }
}