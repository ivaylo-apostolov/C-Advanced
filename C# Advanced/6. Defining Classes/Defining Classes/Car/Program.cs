using System;

namespace Car
{
    class Program
    {
        static void Main(string[] args)
        {
            Car car = new Car("subaru", "outback", 2006, 60, 16);           

            //car.Drive(100);

            Console.WriteLine(car.ToString());
        }
    }
}
