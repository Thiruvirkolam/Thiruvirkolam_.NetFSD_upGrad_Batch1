using System;
using System.Collections.Generic;
using System.Text;

namespace Class_Assignment_1
{
    class Nurse
    {
        public int Nurse_Id { get; set; }
        public string? Nurse_Name { get; set; }
        public string? Department { get; set; }
    }
    class NurseTest 
    {
        static void Main()
        {
            Nurse n = new Nurse
            {
                Nurse_Id = 1,
                Nurse_Name = "Raghul",
                Department = "Emergency"
            };

            Console.WriteLine(n.Nurse_Id);
            Console.WriteLine(n.Nurse_Name);
            Console.WriteLine(n.Department);
        }
    }
}
