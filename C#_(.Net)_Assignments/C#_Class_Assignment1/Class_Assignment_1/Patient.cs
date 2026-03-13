using System;
using System.Collections.Generic;
using System.Text;

namespace Class_Assignment_1
{
    internal class Patient
    {
        public int Patient_ID;
        public string? Patient_Name;
        public int Patient_Age;
        public string? Disease;
    }
    internal class Patient1 
    {
        static void Main(string[] args)
        {
            Patient patient1 = new Patient();
            patient1.Patient_ID = 1;
            patient1.Patient_Name = "THIRU";
            patient1.Patient_Age = 22;
            patient1.Disease = "FLU";

            Console.WriteLine("Patient ID: " + patient1.Patient_ID);
            Console.WriteLine("Patient Name: " + patient1.Patient_Name);
            Console.WriteLine("Patient Age: " + patient1.Patient_Age);
            Console.WriteLine("Disease: " + patient1.Disease);
        }
    }
}
