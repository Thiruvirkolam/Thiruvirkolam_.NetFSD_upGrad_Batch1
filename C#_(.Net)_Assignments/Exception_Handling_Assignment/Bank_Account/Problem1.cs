using System;
using System.Collections.Generic;   
using System.Text;

class CheckBalanceException : Exception
{
    public CheckBalanceException(string message) : base(message) { }
}

class BankAccount
{
    public int AccountNumber;
    public string? Name;
    public static double balance = 1000;
    public char transactionType;
    public double transactionAmount;

    public void ProcessTransaction()
    {
        if (transactionType == 'd')
        {
            balance += transactionAmount;
            Console.WriteLine("Deposited Successfully. Balance: " + balance);
        }
        else if (transactionType == 'c')
        {
            if (balance - transactionAmount < 500)
            {
                throw new CheckBalanceException("Balance cannot go below 500");
            }
            balance -= transactionAmount;
            Console.WriteLine("Withdrawn Successfully. Balance: " + balance);
        }
    }
}

class Program
{
    static void Main()
    {
        try
        {
            BankAccount acc = new BankAccount();
            acc.AccountNumber = 101;
            acc.Name = "Thiru";
            acc.transactionType = 'c';
            acc.transactionAmount = 600;
            acc.ProcessTransaction();
        }
        catch (CheckBalanceException ex)
        {
            Console.WriteLine(ex.Message);
        }
    }
}