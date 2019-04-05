using System;
using System.Collections.Generic;
using System.Linq;

namespace _10._SoftUni_Exam_Results
{
    class Program
    {
        static void Main(string[] args)
        {
            var dict = new Dictionary<string, int>();
            var subDict = new Dictionary<string, int>();

            string command = string.Empty;

            while ((command = Console.ReadLine()) != "exam finished")
            {
                var arr = command.Split("-").ToArray();

                string name = arr[0];
                string subject = arr[1];
                int grade = 0;
                if (arr.Length == 3)
                {
                    grade = int.Parse(arr[2]);
                }

                if (!dict.ContainsKey(name) && subject != "banned")
                {
                    dict[name] = grade;
                }
                else if (dict.ContainsKey(name) && subject != "banned")
                {
                    if (grade > dict[name])
                    {
                        dict[name] = grade;
                    }
                }

                if (subject == "banned")
                {
                    dict.Remove(name);
                }

                if (subject != "banned")
                {
                    if (!subDict.ContainsKey(subject))
                    {
                        subDict[subject] = 0;
                    }
                    subDict[subject]++;
                }
            }

            Console.WriteLine("Results:");
            foreach (var kpv in dict.OrderByDescending(x => x.Value).ThenBy(x => x.Key))
            {
                Console.WriteLine($"{kpv.Key} | {kpv.Value}");
            }

            Console.WriteLine("Submissions:");
            foreach (var kpv in subDict.OrderByDescending(x => x.Value).ThenBy(x => x.Key))
            {
                Console.WriteLine($"{kpv.Key} - {kpv.Value}");
            }
        }
    }
}
