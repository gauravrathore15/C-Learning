// single inheritance 

/*using System;
using System.Collections.Generic;
using System.Text;

namespace C__Fundamentals
{
    public class Program{
        public static void Main(String[] args) {
            ElectricCar obj = new ElectricCar(2025, "Tata Nexon EV", "DL-01-EV-1234", 450.0, 40, 150);
            obj.displayDetails();
            obj.electricCarDisplay();
        }
    }
}
*/

// Multilevel Inheritance

/*
using System;
using System.Collections.Generic;
using System.Text;

namespace C__Fundamentals
{
    public class Program
    {
        public static void Main(String[] args)
        {
            AutonomousElectricCar obj = new AutonomousElectricCar();
            obj.start();
            obj.chargeBattery();
            obj.AutoPilot();
        }
    }
}

 internal class car
    {
    public void start() => Console.WriteLine("car started");
    }

internal class ElectricCar:car {
    public void chargeBattery() => Console.WriteLine("Battery Charging");
    }

internal class AutonomousElectricCar : ElectricCar
{
    public void AutoPilot() => Console.WriteLine("Self driving mode on");
}
*/

// Hierarchial inheritance

/*
using System;
using System.Collections.Generic;
using System.Text;

namespace C_Fundamental
{
    internal class Program
    {
        public static void Main(String[] args)
        {
            ElectricCar E = new ElectricCar("skoda rabit",450);
            E.displayBrand();
            E.displayElectricCarDetails();

            AutonomousElectricCar AE = new AutonomousElectricCar("Nisaan", true);
            AE.displayBrand();
            AE.AutonomousElectricCarDetails();
        }
    }


    internal class Car
    {
        private String brand { get; set; }

        public Car(String brand)
        {
            this.brand = brand;
        }

        public void displayBrand()
        {
            Console.WriteLine("Car Brand = " + this.brand);
        }
    }



    internal class ElectricCar : Car
    {
        private int batteryCapcity { get; set; }

        public ElectricCar(String brand, int batteryCapcity) : base(brand)
        {
            this.batteryCapcity = batteryCapcity;
        }

        public void displayElectricCarDetails()
        {
            Console.WriteLine("Battery Capacity = " + this.batteryCapcity);
        }
    }

    internal class AutonomousElectricCar : Car
    {
        private Boolean isAutoPilot { get; set; }

        public AutonomousElectricCar(String brand, Boolean isAutoPilot) : base(brand)
        {
            this.isAutoPilot = isAutoPilot;
        }

        public void AutonomousElectricCarDetails()
        {
            Console.WriteLine("Autopilot = " + this.isAutoPilot);
        }
    }
}*/