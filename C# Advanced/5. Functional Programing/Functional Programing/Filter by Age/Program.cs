using System;
using System.Collections.Generic;
using System.Linq;

namespace Filter_by_Age
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            var people = new Dictionary<string, int>();

            for (int i = 0; i < n; i++)
            {
                var tokens = Console.ReadLine()
                    .Split(", ")
                    .ToArray();

                var name = tokens[0];
                var age = int.Parse(tokens[1]);

                people[name] = age;
            }

            string olderOrYounger = Console.ReadLine();
            int ages = int.Parse(Console.ReadLine());

            foreach (var kvp in people.Where(kvp => olderOrYounger == "older" ? kvp.Value > ages : kvp.Value < ages))
            {
                Console.WriteLine($"{kvp.Key}");
            }
        }
    }
}
