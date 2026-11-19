using System;
using System.Collections.Generic;
using System.Text;

namespace C__Fundamentals
{
    internal abstract class Car
    {
        private String brand { get; set; }

        public Car(String brand)
        {
            this.brand = brand;
        }

        public void showBrand()
        {
            Console.WriteLine("Car Brand = " + this.brand);
        }

        public abstract void startEngine();
    }
}
