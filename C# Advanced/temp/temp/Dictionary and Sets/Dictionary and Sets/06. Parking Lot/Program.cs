using System;
using System.Collections.Generic;
using System.Linq;

namespace _06._Parking_Lot
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine()
                .Split(", ")
                .ToArray();

            var carList = new HashSet<string>();

            while (input[0] != "END")
            {
                string command = input[0];
                string plate = input[1];

                if (command == "IN")
                {
                    carList.Add(plate);
                }
                else if (command == "OUT")
                {
                    carList.Remove(plate);
                }

                input = Console.ReadLine()
                .Split(", ")
                .ToArray();
            }

            if (carList.Count > 0)
            {
                foreach (var car in carList)
                {
                    Console.WriteLine(car);
                }
            }
            else
            {
                Console.WriteLine("Parking Lot is Empty");
            }
        }
    }
}
