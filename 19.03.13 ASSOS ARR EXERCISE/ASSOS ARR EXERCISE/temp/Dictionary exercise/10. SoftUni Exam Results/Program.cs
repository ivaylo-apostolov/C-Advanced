using System;
using System.Collections.Generic;
using System.Linq;

namespace _10._SoftUni_Exam_Results
{
    class Program
    {
        static void Main(string[] args)
        {
            var participantsDict = new Dictionary<string, int>();
            var examNameAndSubmisionsDict = new Dictionary<string, int>();

            string input = string.Empty;

            while ((input = Console.ReadLine()) != "exam finished")
            {
                var tokens = input.Split("-").ToArray();

                if (tokens[1] != "banned")
                {
                    string studetName = tokens[0];
                    string exam = tokens[1];
                    int points = int.Parse(tokens[2]);

                    if (!participantsDict.ContainsKey(studetName))
                    {
                        participantsDict.Add(studetName, points);
                    }
                    if (participantsDict[studetName] < points)
                    {
                        participantsDict[studetName] = points;
                    }

                    if (!examNameAndSubmisionsDict.ContainsKey(exam))
                    {
                        examNameAndSubmisionsDict[exam] = 1;
                    }
                    else
                    {
                        examNameAndSubmisionsDict[exam]++;
                    }
                }
                else if (tokens[1] == "banned")
                {
                    string studetName = tokens[0];

                    participantsDict.Remove(studetName);
                }
            }

            Console.WriteLine("Results:");
            foreach (var kvp in participantsDict.OrderByDescending(x => x.Value).ThenBy(x => x.Key))
            {
                Console.WriteLine($"{kvp.Key} | {kvp.Value}");
            }

            Console.WriteLine("Submissions:");

            foreach (var kvp in examNameAndSubmisionsDict.OrderByDescending(x => x.Value).ThenBy(x => x.Key))
            {
                Console.WriteLine($"{kvp.Key} - {kvp.Value}");
            }
        }
    }
}
