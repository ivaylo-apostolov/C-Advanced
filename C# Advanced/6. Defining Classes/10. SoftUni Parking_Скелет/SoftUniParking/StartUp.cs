﻿namespace SoftUniParking
{
    using System;
    using System.Collections.Generic;

    public class StartUp
    {
        public static void Main(string[] args)
        {
            var car = new Car("Skoda", "Fabia", 65, "CC1856BG");
            var car2 = new Car("Audi", "A3", 110, "EB8787MN");
            var car3 = new Car("Audi", "A3", 110, "EB8787MN");
            var car4 = new Car("Audi", "A3", 110, "EB8787MS");

            var list = new List<string>();
            list.Add(car.RegistrationNumber);
            list.Add(car2.RegistrationNumber);


            var parking = new Parking(2);

            Console.WriteLine(parking.AddCar(car));
            Console.WriteLine(parking.AddCar(car2));

            Console.WriteLine(parking.GetCar("EB8787MN"));

            Console.WriteLine(parking.RemoveCar("EB8787M"));

            parking.RemoveSetOfRegistrationNumber(list);

            Console.WriteLine(parking.Count);
        }
    }
}
