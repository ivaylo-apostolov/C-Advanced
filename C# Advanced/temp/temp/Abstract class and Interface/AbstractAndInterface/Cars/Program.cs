using System;

namespace Cars
{
    class Program
    {
        static void Main(string[] args)
        {
            ICar seat = new Seat("Ibisa", "red");
            ICar tesla = new Tesla("Model S", "white", 2);

            Console.WriteLine(seat.ToString());
            Console.WriteLine(tesla.ToString());

            Console.WriteLine(tesla.);
        }
    }
}
