using System;
using System.Collections.Generic;
using System.Text;

abstract class Sales
{
    public abstract int MonthlySales();
    public int DailySales()
    {
        return 400;
    }
}

interface ISales
{
    int YearlySales();
}

class Report : Sales, ISales
{
    public override int MonthlySales()
    {
        return DailySales() * 30;
    }

    public int YearlySales()
    {
        return MonthlySales() * 12;
    }
}

class Program
{
    static void Main()
    {
        Report r = new Report();
        Console.WriteLine("Daily sales: Rs." + r.DailySales());
        Console.WriteLine("Monthly sales: Rs." + r.MonthlySales());
        Console.WriteLine("Annual sales: Rs." + r.YearlySales());
    }
}