using System;

namespace CoreApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Console.WriteLine("Repository Change");

            SportCar car = new SportCar(4, "BeytX Car Cooperation");
            Console.WriteLine(car.Name);

            Console.ReadLine();
        }
    }
}
