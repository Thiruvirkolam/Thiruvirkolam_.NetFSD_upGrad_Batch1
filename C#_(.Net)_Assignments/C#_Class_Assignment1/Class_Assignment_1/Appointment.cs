using System;
using System.Collections.Generic;
using System.Text;

namespace Class_Assignment_1
{
    class Appointment
    {
        public int AppointmentId;
        public string? PatientName;
        public string? DoctorName;
        public DateTime AppointmentDate;

        public Appointment() 
        {
            DoctorName = "General Physician";
            AppointmentDate = DateTime.Today;
        }
    }

    class Program
    {
        static void Main()
        {
            Appointment a = new Appointment();

            a.AppointmentId = 1;
            a.PatientName = "Thiru";

            Console.WriteLine(a.AppointmentId);
            Console.WriteLine(a.PatientName);
            Console.WriteLine(a.DoctorName);
            Console.WriteLine(a.AppointmentDate);
        }
    }
}
