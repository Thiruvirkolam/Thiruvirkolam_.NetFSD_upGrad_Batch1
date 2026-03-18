using System;
using System.Collections.Generic;
using System.Text;

class Product
{
    public int Id { get; set; }
    public string? Name { get; set; }
    public double Price { get; set; }
    public string? Category { get; set; }

    public Product(int id, string? name, double price, string? category)
    {
        Id = id;
        Name = name;
        Price = price;
        Category = category;
    }
}

class Program
{
    static void Main()
    {
        List<Product> products = new List<Product>
        {
            new Product(1,"Laptop",50000,"Electronics"),
            new Product(2,"Phone",20000,"Electronics"),
            new Product(3,"Shirt",800,"Clothing"),
            new Product(4,"Shoes",1500,"Footwear"),
            new Product(5,"Watch",2500,"Accessories"),
            new Product(6,"TV",60000,"Electronics"),
            new Product(7,"Bag",1200,"Accessories"),
            new Product(8,"Headphones",1800,"Electronics"),
            new Product(9,"Jeans",2000,"Clothing"),
            new Product(10,"Keyboard",900,"Electronics")
        };

        Console.WriteLine("All Products:");
        products.ForEach(p => Console.WriteLine($"{p.Id} {p.Name} {p.Price} {p.Category}"));

        Console.WriteLine("\nPrice > 1000:");
        var costly = products.Where(p => p.Price > 1000);
        foreach (var p in costly)
            Console.WriteLine($"{p.Name} {p.Price}");

        Console.WriteLine("\nSorted Asc:");
        var asc = products.OrderBy(p => p.Price);
        foreach (var p in asc)
            Console.WriteLine($"{p.Name} {p.Price}");

        Console.WriteLine("\nSorted Desc:");
        var desc = products.OrderByDescending(p => p.Price);
        foreach (var p in desc)
            Console.WriteLine($"{p.Name} {p.Price}");

        int removeId = 3;
        var prod = products.FirstOrDefault(p => p.Id == removeId);
        if (prod != null) products.Remove(prod);

        Console.WriteLine("\nAfter Removal:");
        products.ForEach(p => Console.WriteLine($"{p.Id} {p.Name}"));

        Console.WriteLine("\nElectronics Category:");
        var electronics = products.Where(p => p.Category == "Electronics");
        foreach (var p in electronics)
            Console.WriteLine(p.Name);
    }
}