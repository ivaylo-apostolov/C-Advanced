using System;
using System.Collections.Generic;
using System.Linq;

namespace RawData
{
    public class StartUp
    {
        public static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());            
            var cars = new List<Car>();

            for (int i = 0; i < n; i++)
            {
                var tires = new List<Tire>();
                var tokens = Console.ReadLine()
                    .Split()
                    .ToArray();

                string model = tokens[0];
                int engineSpeed = int.Parse(tokens[1]);
                int enginePower = int.Parse(tokens[2]);

                Engine engine = new Engine(engineSpeed, enginePower);

                int cargoWeight = int.Parse(tokens[3]);
                string cargoType = tokens[4];

                Cargo cargo = new Cargo(cargoWeight, cargoType);

                for (int j = 5; j <= 12; j+=2)
                {
                    double tirePresure = double.Parse(tokens[j]);
                    int tireAge = int.Parse(tokens[j + 1]);

                    Tire tire = new Tire(tirePresure, tireAge);
                    tires.Add(tire);
                }

                Car car = new Car(model, engine, cargo, tires);                
                cars.Add(car);
            }

            string command = Console.ReadLine();

            if (command == "fragile")
            {
                foreach (var car in cars)
                {
                    if (car.Fragile(car))
                    {
                        Console.WriteLine(car.Model);
                    }
                }
            }
            else if (command == "flamable")
            {
                foreach (var car in cars)
                {
                    if (car.Flamable(car))
                    {
                        Console.WriteLine(car.Model);
                    }
                }
            }
        }
    }
}
