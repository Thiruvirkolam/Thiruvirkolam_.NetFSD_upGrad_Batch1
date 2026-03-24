using System;
using Microsoft.Data.SqlClient;

class Program
{
    static string cs = "Server=Thiru\\SQLEXPRESS;Database=OrderDB;Trusted_Connection=True;TrustServerCertificate=True;";

    static void Main()
    {
        using (SqlConnection con = new SqlConnection(cs))
        {
            con.Open();
            SqlTransaction tx = con.BeginTransaction();

            try
            {
                Console.Write("Customer Name: ");
                string customer = ReadString();

                Console.Write("Total Amount: ");
                decimal total = ReadDecimal();

                string orderQuery = "INSERT INTO Orders (CustomerName, TotalAmount) VALUES (@c,@t); SELECT SCOPE_IDENTITY();";
                SqlCommand cmd1 = new SqlCommand(orderQuery, con, tx);

                cmd1.Parameters.AddWithValue("@c", customer);
                cmd1.Parameters.AddWithValue("@t", total);

                int orderId = Convert.ToInt32(cmd1.ExecuteScalar());

                Console.Write("Number of Items: ");
                int n = ReadInt();

                for (int i = 0; i < n; i++)
                {
                    Console.Write("Product Name: ");
                    string pname = ReadString();

                    Console.Write("Quantity: ");
                    int qty = ReadInt();

                    string itemQuery = "INSERT INTO OrderItems (OrderId, ProductName, Quantity) VALUES (@id,@p,@q)";
                    SqlCommand cmd2 = new SqlCommand(itemQuery, con, tx);

                    cmd2.Parameters.AddWithValue("@id", orderId);
                    cmd2.Parameters.AddWithValue("@p", pname);
                    cmd2.Parameters.AddWithValue("@q", qty);

                    cmd2.ExecuteNonQuery();
                }

                tx.Commit();
                Console.WriteLine("Order Placed Successfully");
            }
            catch
            {
                tx.Rollback();
                Console.WriteLine("Transaction Failed");
            }
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
}