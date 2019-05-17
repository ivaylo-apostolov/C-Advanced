using System;
using System.Collections.Generic;
using System.Linq;

namespace _06._Auto_Repair_and_Service
{
    class Program
    {
        static void Main(string[] args)
        {
            var inputVehicals = Console.ReadLine()
                .Split();

            var service = new Queue<string>(inputVehicals);
            var servedCars = new Stack<string>();

            string input = string.Empty;

            while ((input = Console.ReadLine()) != "End")
            {
                var tokens = input.Split("-").ToArray();
                string command = tokens[0];

                if (command == "Service" && service.Count > 0)
                {
                    servedCars.Push(service.Dequeue());
                    Console.WriteLine($"Vehicle {servedCars.Peek()} got served.");
                }
                else if (command == "CarInfo")
                {
                    string carToCheck = tokens[1];

                    if (service.Contains(carToCheck))
                    {
                        Console.WriteLine("Still waiting for service.");
                    }
                    else
                    {
                        Console.WriteLine("Served.");
                    }
                }
                else if (command == "History")
                {
                    Console.WriteLine(string.Join(", ", servedCars));
                }
            }

            if (service.Count > 0)
            {
                Console.WriteLine($"Vehicles for service: {string.Join(", ", service)}");
            }

            if (servedCars.Count > 0)
            {
                Console.WriteLine($"Served vehicles: {string.Join(", ", servedCars)}");
            }
        }
    }
}
