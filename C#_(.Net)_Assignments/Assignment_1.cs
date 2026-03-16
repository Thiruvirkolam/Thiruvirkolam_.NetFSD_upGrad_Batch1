using System;

namespace Assignment1
{
    internal class Assignment
    {
        static void Main(string[] args)
        {
            Problem1();
            Problem2();
            Problem3();
            Problem4();
            Problem5();
            Problem6();
            Problem7();
            Problem8();
        }

        static void Problem1()
        {
            Console.WriteLine("Problem 1 - Divide two numbers");

            Console.WriteLine("Enter first number:");
            int a = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter second number:");
            int b = Convert.ToInt32(Console.ReadLine());

            int c = a / b;

            Console.WriteLine("Quotient: " + c);
        }

        static void Problem2()
        {
            Console.WriteLine("Problem 2 - Kilometer to Meter");

            Console.WriteLine("Enter distance in kilometers:");
            int km = Convert.ToInt32(Console.ReadLine());

            int m = km * 1000;

            Console.WriteLine("Meters: " + m);
        }

        static void Problem3()
        {
            Console.WriteLine("Problem 3 - Sum and Average of Five Numbers");

            Console.WriteLine("Enter five numbers:");

            int a = Convert.ToInt32(Console.ReadLine());
            int b = Convert.ToInt32(Console.ReadLine());
            int c = Convert.ToInt32(Console.ReadLine());
            int d = Convert.ToInt32(Console.ReadLine());
            int e = Convert.ToInt32(Console.ReadLine());

            int sum = a + b + c + d + e;
            int avg = sum / 5;

            Console.WriteLine("Sum: " + sum);
            Console.WriteLine("Average: " + avg);
        }

        static void Problem4()
        {
            Console.WriteLine("Problem 4 - Odd or Even");

            Console.WriteLine("Enter a number:");
            int a = Convert.ToInt32(Console.ReadLine());

            if (a % 2 == 0)
                Console.WriteLine("Even");
            else
                Console.WriteLine("Odd");
        }

        static void Problem5()
        {
            Console.WriteLine("Problem 5 - Highest of Two Numbers");

            Console.WriteLine("Enter first number:");
            int a = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter second number:");
            int b = Convert.ToInt32(Console.ReadLine());

            if (a > b)
                Console.WriteLine("Highest: " + a);
            else
                Console.WriteLine("Highest: " + b);
        }

        static void Problem6()
        {
            Console.WriteLine("Problem 6 - Area of Rectangle and Square");

            Console.WriteLine("Enter length of rectangle:");
            int l = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter breadth of rectangle:");
            int b = Convert.ToInt32(Console.ReadLine());

            int rect = l * b;

            Console.WriteLine("Area of Rectangle: " + rect);

            Console.WriteLine("Enter side of square:");
            int s = Convert.ToInt32(Console.ReadLine());

            int sq = s * s;

            Console.WriteLine("Area of Square: " + sq);
        }

        static void Problem7()
        {
            Console.WriteLine("Problem 7 - Time for Journey");

            Console.WriteLine("Enter distance:");
            int d = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter speed:");
            int s = Convert.ToInt32(Console.ReadLine());

            int t = d / s;

            Console.WriteLine("Time taken: " + t);
        }

        static void Problem8()
        {
            Console.WriteLine("Problem 8 - Third Character Vowel or Consonant");

            Console.WriteLine("Enter a string:");
            string str = Console.ReadLine();

            char c = str[2];

            if (c == 'a' || c == 'e' || c == 'i' || c == 'o' || c == 'u' ||
                c == 'A' || c == 'E' || c == 'I' || c == 'O' || c == 'U')
                Console.WriteLine("Vowel");
            else
                Console.WriteLine("Consonant");
        }
    }
}