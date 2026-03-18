using System;
using System.Collections.Generic;
using System.Text;

class Program
{
    static void Main()
    {
        HashSet<string> event1 = new HashSet<string>();

        event1.Add("a@gmail.com");
        event1.Add("b@gmail.com");
        event1.Add("c@gmail.com");
        event1.Add("d@gmail.com");
        event1.Add("e@gmail.com");
        event1.Add("a@gmail.com");
        event1.Add("b@gmail.com");
        event1.Add("f@gmail.com");
        event1.Add("g@gmail.com");
        event1.Add("h@gmail.com");

        Console.WriteLine("Unique Emails:");
        foreach (var email in event1)
        {
            Console.WriteLine(email);
        }

        string checkEmail = "c@gmail.com";
        if (event1.Contains(checkEmail))
        {
            Console.WriteLine("\nEmail exists: " + checkEmail);
        }
        else
        {
            Console.WriteLine("\nEmail not found");
        }

        event1.Remove("d@gmail.com");
        Console.WriteLine("\nAfter removing d@gmail.com:");
        foreach (var email in event1)
        {
            Console.WriteLine(email);
        }

        HashSet<string> event2 = new HashSet<string>()
        {
            "x@gmail.com",
            "y@gmail.com",
            "c@gmail.com",
            "f@gmail.com",
            "z@gmail.com"
        };

        event1.IntersectWith(event2);
        Console.WriteLine("\nCommon Participants:");
        foreach (var email in event1)
        {
            Console.WriteLine(email);
        }
    }
}