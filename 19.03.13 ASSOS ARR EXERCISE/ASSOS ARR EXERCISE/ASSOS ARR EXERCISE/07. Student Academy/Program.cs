using System;
using System.Collections.Generic;
using System.Linq;

namespace _07._Student_Academy
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            var dict = new Dictionary<string, List<double>>();

            for (int i = 0; i < n; i++)
            {
                string name = Console.ReadLine();
                double grade = double.Parse(Console.ReadLine());

                if (!dict.ContainsKey(name))
                {
                    dict[name] = new List<double>();
                }
                dict[name].Add(grade);
            }

            var list = new List<string>();

            foreach (var kvp in dict)
            {
                if (kvp.Value.Average() < 4.5)
                {
                    list.Add(kvp.Key);
                }
            }

            foreach (var name in list)
            {
                dict.Remove(name);
            }

            foreach (var kvp in dict.OrderByDescending(x => x.Value.Average()))
            {
                Console.WriteLine($"{kvp.Key} -> {kvp.Value.Average():f2}");
            }
        }
    }
}
