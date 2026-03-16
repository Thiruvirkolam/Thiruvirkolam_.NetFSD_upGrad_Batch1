using System;
using System.Collections.Generic;
using System.Text;

namespace Class_Assignment_1
{
    internal class MedicalTest
    {
        public int TestId;
        public string? TestName;
        public int TestCost;

        public MedicalTest(int id, string? name, int cost)
        {
            TestId = id;
            TestName = name;
            TestCost = cost;
        }
    }
    internal class MedicalTest1 
    {
        static void Main()
        {
            MedicalTest t1 = new MedicalTest(1, "Blood Test", 500);
            MedicalTest t2 = new MedicalTest(2, "X-Ray", 800);

            Console.WriteLine(t1.TestId + " " + t1.TestName + " " + t1.TestCost);
            Console.WriteLine(t2.TestId + " " + t2.TestName + " " + t2.TestCost);
        }
    }
}
