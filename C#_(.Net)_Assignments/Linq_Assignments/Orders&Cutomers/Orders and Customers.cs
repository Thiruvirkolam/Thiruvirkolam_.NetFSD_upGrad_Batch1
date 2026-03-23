using System;
using System.Collections.Generic;
using System.Linq;

class Customer
{
    public int Id { get; set; }
    public string? Name { get; set; }
}

class Order
{
    public int Id { get; set; }
    public int CustomerId { get; set; }
    public double Amount { get; set; }
}

class Program
{
    static void Main()
    {
        var customers = new List<Customer>
        {
            new Customer{Id=1,Name="Thiru"},
            new Customer{Id=2,Name="Ashwin"},
            new Customer{Id=3,Name="Kishore"}
        };

        var orders = new List<Order>
        {
            new Order{Id=1,CustomerId=1,Amount=3000},
            new Order{Id=2,CustomerId=1,Amount=2500},
            new Order{Id=3,CustomerId=2,Amount=1000}
        };

        var joinData = customers.Join(orders,
                                     c => c.Id,
                                     o => o.CustomerId,
                                     (c, o) => new { c.Name, o.Amount });

        Console.WriteLine("Customer Orders:");
        foreach (var x in joinData)
            Console.WriteLine(x.Name + " " + x.Amount);

        var totalPerCustomer = customers.GroupJoin(orders,
                                                   c => c.Id,
                                                   o => o.CustomerId,
                                                   (c, os) => new { c.Name, Total = os.Sum(x => x.Amount) });

        Console.WriteLine("\nTotal Order Amount per Customer:");
        foreach (var x in totalPerCustomer)
            Console.WriteLine(x.Name + " " + x.Total);

        var totalGreater5000 = totalPerCustomer.Where(x => x.Total > 5000);

        Console.WriteLine("\nCustomers with Total > 5000:");
        foreach (var x in totalGreater5000)
            Console.WriteLine(x.Name + " " + x.Total);

        var noOrders = customers.GroupJoin(orders,
                                           c => c.Id,
                                           o => o.CustomerId,
                                           (c, os) => new { c.Name, Count = os.Count() })
                                .Where(x => x.Count == 0);

        Console.WriteLine("\nCustomers with No Orders:");
        foreach (var x in noOrders)
            Console.WriteLine(x.Name);
    }
}