using System;
using System.Collections.Generic;   
using System.Text;

class TicketException : Exception
{
    public TicketException(string message) : base(message) { }
}

class TicketBooking
{
    int availableTickets = 15;
    public void BookTickets(int tickets)
    {
        if (tickets > availableTickets)
        {
            throw new TicketException("Tickets not available");
        }
        availableTickets -= tickets;
        Console.WriteLine("Tickets booked successfully");
        Console.WriteLine("Remaining tickets: " + availableTickets);
    }
}

class Program
{
    static void Main()
    {
        try
        {
            TicketBooking tb = new TicketBooking();

            Console.WriteLine("Do you want to book tickets (yes/no)?");
            string? choice = Console.ReadLine();

            if (choice?.ToLower() == "yes")
            {
                Console.WriteLine("Enter number of tickets:");
                int n = Convert.ToInt32(Console.ReadLine());
                tb.BookTickets(n);
            }
        }
        catch (TicketException ex)
        {
            Console.WriteLine(ex.Message);
        }
    }
}