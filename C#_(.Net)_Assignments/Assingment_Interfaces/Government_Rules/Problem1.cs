using System;
using System.Collections.Generic;
using System.Text;

interface GovtRules
{
    double EmployeePF(double basicSalary);
    string? LeaveDetails();
    double GratuityAmount(float serviceCompleted, double basicSalary);
}

class TCS : GovtRules
{
    int empid;
    string? name, dept, desg;
    double basicSalary;

    public TCS(int empid, string? name, string? dept, string? desg, double basicSalary)
    {
        this.empid = empid;
        this.name = name;
        this.dept = dept;
        this.desg = desg;
        this.basicSalary = basicSalary;
    }

    public int Empid { get { return empid; } }
    public string? Name { get { return name; } }
    public string? Dept { get { return dept; } }
    public string? Desg { get { return desg; } }
    public double Salary { get { return basicSalary; } }

    public double EmployeePF(double basicSalary)
    {
        double emp = 0.12 * basicSalary;
        double employer = 0.0833 * basicSalary;
        double pension = 0.0367 * basicSalary;
        return emp + employer + pension;
    }

    public string LeaveDetails()
    {
        return "1 Casual/month, 12 Sick/year, 10 Privilege/year";
    }

    public double GratuityAmount(float serviceCompleted, double basicSalary)
    {
        if (serviceCompleted > 20) return 3 * basicSalary;
        if (serviceCompleted > 10) return 2 * basicSalary;
        if (serviceCompleted > 5) return basicSalary;
        return 0;
    }
}

class Accenture : GovtRules
{
    int empid;
    string? name, dept, desg;
    double basicSalary;

    public Accenture(int empid, string? name, string? dept, string? desg, double basicSalary)
    {
        this.empid = empid;
        this.name = name;
        this.dept = dept;
        this.desg = desg;
        this.basicSalary = basicSalary;
    }

    public int Empid { get { return empid; } }
    public string? Name { get { return name; } }
    public string? Dept { get { return dept; } }
    public string? Desg { get { return desg; } }
    public double Salary { get { return basicSalary; } }

    public double EmployeePF(double basicSalary)
    {
        double emp = 0.12 * basicSalary;
        double employer = 0.12 * basicSalary;
        return emp + employer;
    }

    public string? LeaveDetails()
    {
        return "2 Casual/month, 5 Sick/year, 5 Privilege/year";
    }

    public double GratuityAmount(float serviceCompleted, double basicSalary)
    {
        return 0;
    }
}

class Program
{
    static void Main()
    {
        TCS t = new TCS(1, "Thiru", "IT", "Developer", 50000);
        Console.WriteLine(t.Empid + " " + t.Name);
        Console.WriteLine("PF: " + t.EmployeePF(t.Salary));
        Console.WriteLine("Leave: " + t.LeaveDetails());
        Console.WriteLine("Gratuity: " + t.GratuityAmount(6, t.Salary));

        Accenture a = new Accenture(2, "Ashwin", "HR", "Manager", 60000);
        Console.WriteLine(a.Empid + " " + a.Name);
        Console.WriteLine("PF: " + a.EmployeePF(a.Salary));
        Console.WriteLine("Leave: " + a.LeaveDetails());
        Console.WriteLine("Gratuity: " + a.GratuityAmount(6, a.Salary));
    }
}