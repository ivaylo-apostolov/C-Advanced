using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace SoftUniParking
{
    public class Parking
    {
        private int capacity;
        private List<Car> cars;

        public Parking(int capacity)
        {
            this.cars = new List<Car>();
            this.capacity = capacity;
        }

        public int Count
        {
            get
            {
                return cars.Capacity;
            }
        }

        public string AddCar(Car car)
        {
            Car checkCar = cars.Where(c => c.RegistrationNumber == car.RegistrationNumber).FirstOrDefault();

            if (checkCar != null)
            {
                return "Car with that registration number, already exists!";
            }

            if (cars.Count == capacity)
            {
                return "Parking is full!";
            }

            cars.Add(car);

            return $"Successfully added new car {car.Make} {car.RegistrationNumber}";
        }

        public string RemoveCar(string registrationNumber)
        {
            Car checkCar = cars.Where(c => c.RegistrationNumber == registrationNumber).FirstOrDefault();

            if (checkCar != null)
            {
                cars.Remove(checkCar);
                return $"Successfully removed {registrationNumber}";
            }

            return "Car with that registration number, doesn't exist!";
        }

        public Car GetCar(string registrationNumber)
        {
            Car checkCar = cars.Where(c => c.RegistrationNumber == registrationNumber).FirstOrDefault();
            
            return checkCar;
        }

        public void RemoveSetOfRegistrationNumber(List<string> registrationNumbers)
        {
            foreach (var registrationNumber in registrationNumbers)
            {
                Car checkCar = cars.Where(c => c.RegistrationNumber == registrationNumber).FirstOrDefault();

                if (checkCar != null)
                {
                    cars.Remove(checkCar);
                }
            }
        }
    }
}
