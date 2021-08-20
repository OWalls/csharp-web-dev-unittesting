using System;

namespace CarNS
{
    class Program
    {
        static void Main(string[] args)
        {
            Car car = new Car("Toyota", "Prius", 10, 50);
            Console.WriteLine(car.Make + " - " + car.Model);
            car.AddGas(15.0);
            Console.WriteLine(car.GasTankLevel);
        }
    }
}
