using System;
using System.Linq;

namespace Add_VAT
{
    class Program
    {
        static void Main(string[] args)
        {
            Func<double, double> vat = d => d * 1.2;

            var arr = Console.ReadLine()
                .Split(", ")
                .Select(double.Parse)
                .Select(vat)
                .ToArray();

            foreach (var number in arr)
            {
                Console.WriteLine(number);
            }
        }
    }
}
