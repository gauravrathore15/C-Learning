using System;
using System.Collections.Generic;
using System.Text;

namespace C__Fundamentals
{
    public class Program{
        public static void Main(String[] args) {
          ElectricCar obj = new ElectricCar("skoda rapid");
            obj.showBrand();
            obj.startEngine();
        }
    }
}
