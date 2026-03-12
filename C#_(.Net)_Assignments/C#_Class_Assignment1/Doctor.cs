using System;
using System.Collections.Generic;
using System.Text;

namespace Class_Assignment_1
{
    internal class Doctor
    {
        public int Doctor_ID;  
        public string? Doctor_Name;
        public string? Doctor_Specialization;
        public int Consultation_Fee;
    }
    internal class Doctor1
    {
        static void Main()
        {
            Doctor D1 = new Doctor();
            Doctor D2 = new Doctor();
            D1.Doctor_ID = 10;
            D1.Doctor_Name = "Ashwin Thiru";
            D1.Doctor_Specialization = "Cardiologist";
            D1.Consultation_Fee = 500;

            D2.Doctor_ID = 11;
            D2.Doctor_Name = "Kowshik";
            D2.Doctor_Specialization = "Neurologist";
            D2.Consultation_Fee = 600;

            Console.WriteLine("Doctor ID: " + D1.Doctor_ID);
            Console.WriteLine("Doctor Name: " + D1.Doctor_Name);
            Console.WriteLine("Doctor Specialization: " + D1.Doctor_Specialization);
            Console.WriteLine("Doctor Consultation Fee: " + D1.Consultation_Fee);
            Console.WriteLine("Doctor ID: " + D2.Doctor_ID);
            Console.WriteLine("Doctor Name: " + D2.Doctor_Name);
            Console.WriteLine("Doctor Specialization: " + D2.Doctor_Specialization);
            Console.WriteLine("Doctor Consultation Fee: " + D2.Consultation_Fee);
        }
            
    }
}
