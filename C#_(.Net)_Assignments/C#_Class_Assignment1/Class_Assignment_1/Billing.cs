using System;
using System.Collections.Generic;
using System.Text;

namespace Class_Assignment_1
{
    internal class Billing
    {
        public string? Patient_Name;
        public int Consultation_Fee;
        public int Test_Charges;

        public void CalculateTotalBill()
        {
            int total = Consultation_Fee + Test_Charges;
            Console.WriteLine("Patient Name: " + Patient_Name);
            Console.WriteLine("Total Bill: " + total);
        }
    }
    internal class Billing1
    {
        static void Main()
        {
            Billing b = new Billing();
            b.Patient_Name = "Venkat";
            b.Consultation_Fee = 1000;
            b.Test_Charges = 500;
            b.CalculateTotalBill();
        }
    }
}
