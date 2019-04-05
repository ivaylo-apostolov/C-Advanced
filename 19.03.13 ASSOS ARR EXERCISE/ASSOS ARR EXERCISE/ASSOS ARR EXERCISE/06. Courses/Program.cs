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

            string courseAndName = string.Empty;

            while ((courseAndName = Console.ReadLine()) != "end")
            {
                var arr = courseAndName
                    .Split(" : ")
                    .ToArray();

                string course = arr[0];
                string name = arr[1];

                if (!dict.ContainsKey(course))
                {
                    dict[course] = new List<string>();
                    dict[course].Add(name);
                }
                else
                {
                    dict[course].Add(name);
                }
            }

            foreach (var kpv in dict.OrderByDescending(x => x.Value.Count))
            {
                Console.WriteLine($"{kpv.Key}: {kpv.Value.Count}");

                foreach (var names in kpv.Value.OrderBy(x => x))
                {
                    Console.WriteLine($"-- {names}");
                }
                //var list = new List<string>();

                //for (int i = 0; i < kpv.Value.Count; i++)
                //{
                //    list.Add(kpv.Value[i]);
                //}
                //list.Sort();
                //foreach (var name in list)
                //{
                //    Console.WriteLine($"-- {name}");
                //}
            }
        }
    }
}
