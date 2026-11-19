using System;
using System.Collections.Generic;
using System.Text;

namespace C__Fundamentals
{
    internal class ElectricCar : Car
    {
        public ElectricCar(string brand) : base(brand) { }

        public override void startEngine()
        {
            Console.WriteLine("It strated with battery");
        }
    }
}
