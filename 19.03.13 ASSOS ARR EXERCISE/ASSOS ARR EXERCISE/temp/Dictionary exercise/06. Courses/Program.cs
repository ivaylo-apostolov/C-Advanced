using System;
using System.Collections.Generic;
using System.Linq;

namespace _06._Courses
{
    class Program
    {
        static void Main(string[] args)
        {
            var dict = new Dictionary<string, List<string>>();

            string input = string.Empty;

            while ((input = Console.ReadLine()) != "end")
            {
                var courseAndName = input
                    .Split(" : ")
                    .ToArray();

                string courseName = courseAndName[0];
                string studentName = courseAndName[1];

                if (!dict.ContainsKey(courseName))
                {
                    dict[courseName] = new List<string>();
                }

                dict[courseName].Add(studentName);
            }

            foreach (var kvp in dict.OrderByDescending(x => x.Value.Count))
            {
                Console.WriteLine($"{kvp.Key}: {kvp.Value.Count}");

                foreach (var value in kvp.Value.OrderBy(x => x))
                {
                    Console.WriteLine($"-- {value}");
                }
            }
        }
    }
}
