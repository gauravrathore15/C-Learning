// single inheritance 
/*
using System;
using System.Collections.Generic;
using System.Text;

namespace C__Fundamentals
{
    internal class ElectricCar:Car
    {
        public int batteryCapacity { get; set; }
        public int topSpeed { get; set; }

        public ElectricCar(int model, string brand, string carNumber, double mileage, int batteryCapacity, int topSpeed):base(model, brand, carNumber, mileage)
        {
            this.batteryCapacity = batteryCapacity;
            this.topSpeed = topSpeed;
        }

        public void electricCarDisplay()
        {
            Console.WriteLine("Battery Capacity = " + this.batteryCapacity);
            Console.WriteLine("Top Speed = " + this.topSpeed);
        }
    }
}
*/