using System;
using System.Collections.Generic;
using System.Text;

public class Furniture
{
    public int OrderId { get; set; }
    public string? OrderDate { get; set; }
    public string? FurnitureType { get; set; }
    public int Qty { get; set; }
    public double TotalAmt { get; set; }
    public string? PaymentMode { get; set; }

    public virtual void GetData()
    {
        Console.Write("Enter Order Id: ");
        OrderId = Convert.ToInt32(Console.ReadLine()!);

        Console.Write("Enter Order Date: ");
        OrderDate = Console.ReadLine()!;

        Console.Write("Enter Quantity: ");
        Qty = Convert.ToInt32(Console.ReadLine()!);

        Console.Write("Enter Payment Mode (Credit/Debit): ");
        PaymentMode = Console.ReadLine()!;
    }

    public virtual void ShowData()
    {
        Console.WriteLine("Order Id: " + OrderId);
        Console.WriteLine("Order Date: " + OrderDate);
        Console.WriteLine("Quantity: " + Qty);
        Console.WriteLine("Payment Mode: " + PaymentMode);
        Console.WriteLine("Total Amount: " + TotalAmt);
    }
}

public class Chair : Furniture
{
    public string? ChairType { get; set; }
    public string? Purpose { get; set; }
    public string? MaterialType { get; set; }
    public double Rate { get; set; }

    public override void GetData()
    {
        base.GetData();
        FurnitureType = "Chair";
        Console.Write("Enter Chair Type (Wood/Steel/Plastic): ");
        ChairType = Console.ReadLine()!;
        Console.Write("Enter Purpose (Home/Office): ");
        Purpose = Console.ReadLine()!;

        if (ChairType.ToLower() == "wood")
        {
            Console.Write("Enter Wood Type (Teak Wood/Rose Wood): ");
            MaterialType = Console.ReadLine()!;
        }
        else if (ChairType.ToLower() == "steel")
        {
            Console.Write("Enter Steel Type (Gray/Green/Brown): ");
            MaterialType = Console.ReadLine()!;
        }
        else
        {
            Console.Write("Enter Plastic Color (Green/Red/Blue/White): ");
            MaterialType = Console.ReadLine()!;
        }

        Console.Write("Enter Rate: ");
        Rate = Convert.ToDouble(Console.ReadLine()!);

        TotalAmt = Qty * Rate;
    }

    public override void ShowData()
    {
        base.ShowData();
        Console.WriteLine("Furniture Type: " + FurnitureType);
        Console.WriteLine("Chair Type: " + ChairType);
        Console.WriteLine("Purpose: " + Purpose);
        Console.WriteLine("Material Type: " + MaterialType);
        Console.WriteLine("Rate: " + Rate);
    }
}

public class Cot : Furniture
{
    public string? CotType { get; set; }
    public string? MaterialType { get; set; }
    public string? Capacity { get; set; }
    public double Rate { get; set; }

    public override void GetData()
    {
        base.GetData();
        FurnitureType = "Cot";
        Console.Write("Enter Cot Type (Wood/Steel): ");
        CotType = Console.ReadLine()!;

        if (CotType.ToLower() == "wood")
        {
            Console.Write("Enter Wood Type (Teak Wood/Rose Wood): ");
            MaterialType = Console.ReadLine()!;
        }
        else
        {
            Console.Write("Enter Steel Type (Gray/Green/Brown): ");
            MaterialType = Console.ReadLine()!;
        }

        Console.Write("Enter Capacity (Single/Double): ");
        Capacity = Console.ReadLine()!;

        Console.Write("Enter Rate: ");
        Rate = Convert.ToDouble(Console.ReadLine()!);

        TotalAmt = Qty * Rate;
    }

    public override void ShowData()
    {
        base.ShowData();
        Console.WriteLine("Furniture Type: " + FurnitureType);
        Console.WriteLine("Cot Type: " + CotType);
        Console.WriteLine("Material Type: " + MaterialType);
        Console.WriteLine("Capacity: " + Capacity);
        Console.WriteLine("Rate: " + Rate);
    }
}

class Assignment6
{
    static void Main()
    {
        Console.WriteLine("1. Chair");
        Console.WriteLine("2. Cot");
        Console.Write("Enter your choice: ");
        int choice = Convert.ToInt32(Console.ReadLine());
        Furniture f;

        if (choice == 1)
        {
            f = new Chair();
        }
        else
        {
            f = new Cot();
        }

        f.GetData();
        Console.WriteLine("\n----- Order Details -----");
        f.ShowData();
    }
}