using System;

namespace Assignment2
{
    class Assignment
    {
        static void Main(string[] args)
        {
            Q1.Run();
            Q2.Run(args);
            Q3.Run(args);
            Q4.Run();
            Q5.Run();
            Q6.Run();
            Q7.Run();
            Q8.Run();
            Q9.Run();
            Q10.Run();
            Q11.Run();
            Q12.Run();
            Q13.Run();
            Q14.Run();
            Q15.Run();
            Q16.Run();
            Q17.Run();
            Q18.Run();
            Q19.Run();
        }
    }

    class Q1
    {
        public static void Run()
        {
            Console.WriteLine("Welcome to the world of C#");
        }
    }

    class Q2
    {
        public static void Run(string[] args)
        {
            if (args.Length > 0)
            {
                Console.WriteLine("Hi! " + args[0]);
                Console.WriteLine("Welcome to the world of C#");
            }
        }
    }

    class Q3
    {
        public static void Run(string[] args)
        {
            if (args.Length >= 2)
            {
                int a = Convert.ToInt32(args[0]);
                int b = Convert.ToInt32(args[1]);
                for (int i = a; i <= b; i++)
                    Console.WriteLine(i);
            }
        }
    }

    class Q4
    {
        public static void Run()
        {
            Console.WriteLine("Enter number:");
            int n = Convert.ToInt32(Console.ReadLine());
            if (n % 2 == 0)
                Console.WriteLine("Even");
            else
                Console.WriteLine("Odd");
        }
    }

    class Q5
    {
        public static void Run()
        {
            int odd = 0, even = 0;
            Console.WriteLine("Enter numbers (0 to stop):");
            int n;
            do
            {
                n = Convert.ToInt32(Console.ReadLine());
                if (n != 0)
                {
                    if (n % 2 == 0) even++;
                    else odd++;
                }
            } while (n != 0);
            Console.WriteLine("Even: " + even);
            Console.WriteLine("Odd: " + odd);
        }
    }

    class Q6
    {
        public static void Run()
        {
            Console.WriteLine("Enter Fahrenheit:");
            double f = Convert.ToDouble(Console.ReadLine());
            double c = (f - 32) * 5 / 9;
            Console.WriteLine("Celsius: " + c);
        }
    }

    class Q7
    {
        public static void Run()
        {
            double total = 0;
            double[] price = { 0, 22.5, 44.5, 9.98 };

            Console.WriteLine("Enter product number and quantity (0 to stop):");
            int p;
            do
            {
                p = Convert.ToInt32(Console.ReadLine());
                if (p != 0)
                {
                    int q = Convert.ToInt32(Console.ReadLine());
                    total += price[p] * q;
                }
            } while (p != 0);

            Console.WriteLine("Total price: " + total);
        }
    }

    class Q8
    {
        public static void Run()
        {
            for (int i = 0; i * i <= 625; i++)
                Console.WriteLine(i * i);
        }
    }

    class Q9
    {
        public static void Run()
        {
            Console.WriteLine("Enter number:");
            int n = Convert.ToInt32(Console.ReadLine());
            int fact = 1;
            for (int i = 1; i <= n; i++)
                fact *= i;
            Console.WriteLine("Factorial: " + fact);
        }
    }

    class Q10
    {
        public static void Run()
        {
            int a = 0, b = 1;
            while (a <= 40)
            {
                Console.WriteLine(a);
                int c = a + b;
                a = b;
                b = c;
            }
        }
    }

    class Q11
    {
        public static void Run()
        {
            Console.WriteLine("Enter number:");
            int n = Convert.ToInt32(Console.ReadLine());
            for (int i = 1; i <= 20; i++)
                Console.WriteLine(n + " x " + i + " = " + (n * i));
        }
    }

    class Q12
    {
        public static void Run()
        {
            for (int i = 200; i <= 300; i++)
                if (i % 7 == 0)
                    Console.WriteLine(i);
        }
    }

    class Q13
    {
        public static void Run()
        {
            Console.WriteLine("Enter three numbers:");
            int a = Convert.ToInt32(Console.ReadLine());
            int b = Convert.ToInt32(Console.ReadLine());
            int c = Convert.ToInt32(Console.ReadLine());

            int max = a;
            if (b > max) max = b;
            if (c > max) max = c;

            Console.WriteLine("Largest: " + max);
        }
    }

    class Q14
    {
        public static void Run()
        {
            int min = int.MaxValue;
            Console.WriteLine("Enter five numbers:");
            for (int i = 0; i < 5; i++)
            {
                int n = Convert.ToInt32(Console.ReadLine());
                if (n < min) min = n;
            }
            Console.WriteLine("Smallest: " + min);
        }
    }

    class Q15
    {
        public static void Run()
        {
            int[] m = new int[10];
            int sum = 0, min = 100, max = 0;

            Console.WriteLine("Enter 10 marks:");
            for (int i = 0; i < 10; i++)
            {
                m[i] = Convert.ToInt32(Console.ReadLine());
                sum += m[i];
                if (m[i] < min) min = m[i];
                if (m[i] > max) max = m[i];
            }

            Console.WriteLine("Total: " + sum);
            Console.WriteLine("Average: " + sum / 10);
            Console.WriteLine("Min: " + min);
            Console.WriteLine("Max: " + max);

            Array.Sort(m);

            Console.WriteLine("Ascending:");
            foreach (int x in m) Console.WriteLine(x);

            Console.WriteLine("Descending:");
            for (int i = m.Length - 1; i >= 0; i--) Console.WriteLine(m[i]);
        }
    }

    class Q16
    {
        public static void Run()
        {
            Console.WriteLine("Enter word:");
            string s = Console.ReadLine();
            Console.WriteLine("Length: " + s.Length);
        }
    }

    class Q17
    {
        public static void Run()
        {
            Console.WriteLine("Enter word:");
            string s = Console.ReadLine();
            char[] arr = s.ToCharArray();
            Array.Reverse(arr);
            Console.WriteLine(new string(arr));
        }
    }

    class Q18
    {
        public static void Run()
        {
            Console.WriteLine("Enter first word:");
            string a = Console.ReadLine();
            Console.WriteLine("Enter second word:");
            string b = Console.ReadLine();

            if (a == b)
                Console.WriteLine("Same");
            else
                Console.WriteLine("Not Same");
        }
    }

    class Q19
    {
        public static void Run()
        {
            Console.WriteLine("Enter word:");
            string s = Console.ReadLine();
            char[] arr = s.ToCharArray();
            Array.Reverse(arr);
            string rev = new string(arr);

            if (s == rev)
                Console.WriteLine("Palindrome");
            else
                Console.WriteLine("Not Palindrome");
        }
    }
}