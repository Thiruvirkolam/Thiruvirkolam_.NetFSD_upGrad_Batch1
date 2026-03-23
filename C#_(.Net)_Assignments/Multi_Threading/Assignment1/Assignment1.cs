using System;
using System.Threading;

class Program
{
    static int[] numbers = new int[50];
    static int[] partialSums = new int[5];

    static void Process(object? obj)
    {
        if (obj == null) return;

        int index = (int)obj;
        int start = index * 10;
        int end = start + 10;

        int sum = 0;

        for (int i = start; i < end; i++)
        {
            Console.Write(numbers[i] + " ");
            sum += numbers[i];
        }

        Console.WriteLine();
        partialSums[index] = sum;
        Console.WriteLine("Thread " + (index + 1) + " Sum: " + sum);
    }

    static void Main()
    {
        for (int i = 0; i < 50; i++)
            numbers[i] = i + 1;

        Thread[] threads = new Thread[5];

        for (int i = 0; i < 5; i++)
        {
            threads[i] = new Thread(Process);
            threads[i].Start(i);
        }

        for (int i = 0; i < 5; i++)
            threads[i].Join();

        int finalSum = 0;

        for (int i = 0; i < 5; i++)
            finalSum += partialSums[i];

        Console.WriteLine("Final Sum: " + finalSum);
    }
}