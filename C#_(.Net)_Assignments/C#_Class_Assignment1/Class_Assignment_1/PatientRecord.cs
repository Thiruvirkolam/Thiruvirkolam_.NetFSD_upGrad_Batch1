using System;
using System.Collections.Generic;
using System.Text;

namespace Class_Assignment_1
{
    class PatientRecord
    {
        public int Patient_Id;
        public string? Patient_Name;
        public int Age;
        public string? Disease;

        public static string? Hospital_Name;

        public PatientRecord(int id, string name, int age, string disease)
        {
            Patient_Id = id;
            Patient_Name = name;
            Age = age;
            Disease = disease;
        }

        public void DisplayPatientRecord()
        {
            Console.WriteLine("Hospital: " + Hospital_Name);
            Console.WriteLine("Patient Id: " + Patient_Id);
            Console.WriteLine("Name: " + Patient_Name);
            Console.WriteLine("Age: " + Age);
            Console.WriteLine("Disease: " + Disease);
            Console.WriteLine();
        }
    }
    class PatientRecordTest 
    {
        static void Main()
        {
            PatientRecord.Hospital_Name = "Apollo Hospital";
            PatientRecord p1 = new PatientRecord(101, "Thiru", 40, "Fever");
            PatientRecord p2 = new PatientRecord(102, "Abdul", 35, "Diabetes");
            PatientRecord p3 = new PatientRecord(103, "Kumar", 28, "Cold");

            p1.DisplayPatientRecord();
            p2.DisplayPatientRecord();
            p3.DisplayPatientRecord();
        }
    }
}
