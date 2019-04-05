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
                string studentName = Console.ReadLine();
                double grade = double.Parse(Console.ReadLine());

                if (!dict.ContainsKey(studentName))
                {
                    dict.Add(studentName, new List<double>());
                }

                dict[studentName].Add(grade);
            }

            var namesToRemove = new List<string>();

            foreach (var kvp in dict)
            {
                if (kvp.Value.Average() < 4.5)
                {
                    namesToRemove.Add(kvp.Key);
                }
            }

            foreach (var name in namesToRemove)
            {
                dict.Remove(name);
            }

            foreach (var kvp in dict.OrderByDescending(x => x.Value.Average()))
            {
                double averageGrade = kvp.Value.Average();
                Console.WriteLine($"{kvp.Key} -> {averageGrade:f2}");
            }
        }
    }
}
