using System;
using System.Collections.Generic;
using System.Text;

public class Vehicle
{
    public string VehicleNumber { get; set; }
    public string Brand { get; set; }

    public Vehicle(string vehicleNumber, string brand)
    {
        VehicleNumber = vehicleNumber;
        Brand = brand;
    }

    public void StartVehicle()
    {
        Console.WriteLine("Vehicle started");
    }
}

public class Car : Vehicle
{
    public string FuelType { get; set; }
    public Car(string vehicleNumber, string brand, string fuelType) 
        : base(vehicleNumber, brand)
    {
        FuelType = fuelType;
    }
}

public class Bike : Vehicle
{
    public Bike(string vehicleNumber, string brand) 
        : base(vehicleNumber, brand)
    {
    }
}

public sealed class ElectricCar : Car
{
    public ElectricCar(string vehicleNumber, string brand, string fuelType) 
        : base(vehicleNumber, brand, fuelType)
    {
    }
}

class Assignment4
{
    static void Main()
    {
        ElectricCar ec = new ElectricCar("TN20CJ1269", "Tesla", "Electric");
        ec.StartVehicle();
        Console.WriteLine("Vehicle Number: " + ec.VehicleNumber);
        Console.WriteLine("Brand: " + ec.Brand);
        Console.WriteLine("Fuel Type: " + ec.FuelType);
    }
}