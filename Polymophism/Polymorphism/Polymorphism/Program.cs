using System;
using System.Linq;

namespace Polymorphism
{
    class Program
    {
        static void Main(string[] args)
        {
            Car car = (Car)Factory();
            Truck truck = (Truck)Factory();

            int timesRepeatInput = int.Parse(Console.ReadLine());

            for (int i = 0; i < timesRepeatInput; i++)
            {
                var inputCommand = Console.ReadLine()
                    .Split()
                    .ToArray();

                string commandType = inputCommand[0] + inputCommand[1];
                double distanceOrRefueling = double.Parse(inputCommand[2]);

                if (commandType == "DriveCar")
                {
                    Console.WriteLine(car.Drive(distanceOrRefueling));
                }
                else if (commandType == "DriveTruck")
                {
                    Console.WriteLine(truck.Drive(distanceOrRefueling));
                }
                else if (commandType == "RefuelCar")
                {
                    car.Refueling(distanceOrRefueling);
                }
                else if (commandType == "RefuelTruck")
                {
                    truck.Refueling(distanceOrRefueling);
                }
            }

            Console.WriteLine(car.ToString());
            Console.WriteLine(truck.ToString());
        }

        public static Vehicle Factory()
        {
            var input = Console.ReadLine()
                .Split()
                .ToArray();

            string vehicleType = input[0];
            double fuelQuantity = double.Parse(input[1]);
            double fuelConsuption = double.Parse(input[2]);

            if (vehicleType == "Car")
            {
                return new Car(fuelQuantity, fuelConsuption);
            }
            else if (vehicleType == "Truck")
            {
                return new Truck(fuelQuantity, fuelConsuption);
            }
            else
            {
                throw new ArgumentException("Not a proper vehicle input");
            }
        }
    }
}
