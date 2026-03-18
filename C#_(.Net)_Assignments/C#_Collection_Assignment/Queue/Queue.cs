using System;
using System.Collections.Generic;
using System.Text;

class Patient
{
    public int Id { get; set; }
    public string? Name { get; set; }
    public string? Disease { get; set; }

    public Patient(int id, string? name, string? disease)
    {
        Id = id;
        Name = name;
        Disease = disease;
    }
}

class Program
{
    static void Main()
    {
        Queue<Patient> queue = new Queue<Patient>();

        queue.Enqueue(new Patient(1, "Thiru", "Fever"));
        queue.Enqueue(new Patient(2, "Kowshik", "Cold"));
        queue.Enqueue(new Patient(3, "Rithick", "Headache"));
        queue.Enqueue(new Patient(4, "Ashwin", "Cough"));
        queue.Enqueue(new Patient(5, "Kishore", "Flu"));

        Console.WriteLine("Serving Patients:");
        Console.WriteLine(queue.Dequeue().Name);
        Console.WriteLine(queue.Dequeue().Name);

        Console.WriteLine("\nNext Patient:");
        Console.WriteLine(queue.Peek().Name);

        Console.WriteLine("\nRemaining Patients:");
        foreach (var p in queue)
        {
            Console.WriteLine(p.Id + " " + p.Name + " " + p.Disease);
        }

        Queue<Patient> vipQueue = new Queue<Patient>();

        vipQueue.Enqueue(new Patient(101, "VIP1", "Emergency"));
        vipQueue.Enqueue(new Patient(102, "VIP2", "Critical"));

        Console.WriteLine("\nServing with Priority:");
        while (vipQueue.Count > 0 || queue.Count > 0)
        {
            if (vipQueue.Count > 0)
                Console.WriteLine("VIP: " + vipQueue.Dequeue().Name);
            else
                Console.WriteLine("Regular: " + queue.Dequeue().Name);
        }
    }
}