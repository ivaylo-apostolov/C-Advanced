using System;
using System.Collections.Generic;

namespace test
{
    class Program
    {
        static void Main(string[] args)
        {
            var dict = new Dictionary<string, int>();

            dict["Ivo"] = 1;

            int number = dict["Ivo"];
            string nema = dict.Keys

            Console.WriteLine(nema + " " + number);
        }
    }
}
