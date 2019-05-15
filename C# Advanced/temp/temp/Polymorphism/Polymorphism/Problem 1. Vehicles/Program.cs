using System;
using System.Linq;

namespace Problem_1._Vehicles
{
    class Program
    {
        static void Main(string[] args)
        {
            var carInput = Console.ReadLine()
                .Split()
                .ToArray();

            var carFuelQuantity = double.Parse(carInput[1]);
            var carFuelConsuption = double.Parse(carInput[2]);
            var carTankCapacity = double.Parse(carInput[3]);

            var truckInput = Console.ReadLine()
                .Split()
                .ToArray();

            var truckFuelQuantity = double.Parse(truckInput[1]);
            var truckFuelConsuption = double.Parse(truckInput[2]);
            var truckTankCapacity = double.Parse(truckInput[3]);

            var busInput = Console.ReadLine()
                .Split()
                .ToArray();

            var busFuelQuantity = double.Parse(busInput[1]);
            var busFuelConsuption = double.Parse(busInput[2]);
            var busTankCapacity = double.Parse(busInput[3]);

            var car = new Car(carFuelQuantity, carFuelConsuption, carTankCapacity);
            var truck = new Truck(truckFuelQuantity, truckFuelConsuption, truckTankCapacity);
            var bus = new Bus(busFuelQuantity, busFuelConsuption, busTankCapacity);

            int linesInput = int.Parse(Console.ReadLine());

            for (int i = 0; i < linesInput; i++)
            {
                var tokens = Console.ReadLine()
                    .Split()
                    .ToArray();

                string command = tokens[0] + tokens[1];
                double distanceOrRefuil = double.Parse(tokens[2]);


                if (command == "DriveCar")
                {
                    Console.WriteLine(car.Drive(command, distanceOrRefuil));
                }
                else if (command == "DriveTruck")
                {
                    Console.WriteLine(truck.Drive(command, distanceOrRefuil));
                }
                else if (command == "DriveBus" || command == "DriveEmptyBus")
                {
                    Console.WriteLine(bus.Drive(command, distanceOrRefuil));
                }                
                else if (command == "RefuelCar")
                {
                    car.Refuel(distanceOrRefuil);
                }
                else if (command == "RefuelTruck")
                {
                    truck.Refuel(distanceOrRefuil);
                }
                else if (command == "RefuelBus")
                {
                    bus.Refuel(distanceOrRefuil);
                }
            }

            Console.WriteLine(car.ToString());
            Console.WriteLine(truck.ToString());
            Console.WriteLine(bus.ToString());
        }
    }
}
