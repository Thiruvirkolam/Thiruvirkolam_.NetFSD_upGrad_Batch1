using System;
using System.Collections.Generic;
using System.Text;

class Order
{
    public int OrderId { get; set; }
    public double OrderAmount { get; set; }

    public virtual double CalculateShippingCost()
    {
        return 50;
    }
}

class StandardOrder : Order
{
    public override double CalculateShippingCost()
    {
        return 50;
    }
}

class ExpressOrder : Order
{
    public override double CalculateShippingCost()
    {
        return 100;
    }
}

class InternationalOrder : Order
{
    public override double CalculateShippingCost()
    {
        return 500;
    }
}

class Assignment3
{
    static void Main()
    {
        List<Order> orders = new List<Order>();

        orders.Add(new StandardOrder { OrderId = 1, OrderAmount = 1000 });
        orders.Add(new ExpressOrder { OrderId = 2, OrderAmount = 2000 });
        orders.Add(new InternationalOrder { OrderId = 3, OrderAmount = 5000 });
        foreach (Order order in orders)
        {
            Console.WriteLine("Order ID: " + order.OrderId + " Shipping Cost: " + order.CalculateShippingCost());
        }
    }
}