using System;
using System.Collections.Generic;
using System.Text;

class Staff
{
    public int StaffId { get; set; }
    public string? Name { get; set; }
    public double BaseSalary { get; set; }

    public virtual double CalculateSalary()
    {
        return BaseSalary;
    }
}

class Doctor : Staff
{
    public double ConsultationFee { get; set; }
    public override double CalculateSalary()
    {
        return BaseSalary + ConsultationFee;
    }
}

class Nurse : Staff
{
    public double NightShiftAllowance { get; set; }
    public override double CalculateSalary()
    {
        return BaseSalary + NightShiftAllowance;
    }
}

class LabTechnician : Staff
{
    public double EquipmentAllowance { get; set; }
    public override double CalculateSalary()
    {
        return BaseSalary + EquipmentAllowance;
    }
}

class Assignment1
{
    static void Main()
    {
        Staff s1 = new Doctor { StaffId = 1, Name = "Thiru", BaseSalary = 50000, ConsultationFee = 20000 };
        Staff s2 = new Nurse { StaffId = 2, Name = "Rithick", BaseSalary = 30000, NightShiftAllowance = 5000 };
        Staff s3 = new LabTechnician { StaffId = 3, Name = "Kowshik", BaseSalary = 25000, EquipmentAllowance = 4000 };
        Staff[] staffList = { s1, s2, s3 };
        foreach (Staff s in staffList)
        {
            Console.WriteLine(s.Name + " Salary: " + s.CalculateSalary());
        }
    }
}