using System;
using System.Collections.Generic;
using System.Linq;

namespace SpeedRacing
{
    public class StartUp
    {
        public static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            var listCars = new List<Car>();

            for (int i = 0; i < n; i++)
            {
                var tokens = Console.ReadLine()
                    .Split();

                string model = tokens[0];
                double fuelAmount = double.Parse(tokens[1]);
                double fuelConsumption = double.Parse(tokens[2]);

                Car car = new Car(model, fuelAmount, fuelConsumption);
                listCars.Add(car);
            }

            string inputCommand = string.Empty;

            while ((inputCommand = Console.ReadLine()) != "End")
            {
                var token = inputCommand
                    .Split();

                string model = token[1];
                double distance = double.Parse(token[2]);

                Car car = listCars.Where(c => c.Model == model).FirstOrDefault();
                car.Drive(distance);
            }

            foreach (var car in listCars.OrderBy(c => c.Model))
            {
                Console.WriteLine(car.ToString());
            }
        }
    }
}
