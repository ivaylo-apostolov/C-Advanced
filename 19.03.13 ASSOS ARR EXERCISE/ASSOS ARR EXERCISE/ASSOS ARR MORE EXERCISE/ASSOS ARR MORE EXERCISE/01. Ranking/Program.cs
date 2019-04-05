using System;
using System.Collections.Generic;
using System.Linq;

namespace _01._Ranking
{
    class Program
    {
        static void Main(string[] args)
        {

            //!!!!!!! Have to change - first is the name, than coure + grade !!!!!!!!

            var dictContestsAndPass = new Dictionary<string, string>();
            var dictContestsWithUserAndPoints = new Dictionary<string, Dictionary<string, int>>();

            string inputContestsAndPass = string.Empty;

            while ((inputContestsAndPass = Console.ReadLine()) != "end of contests")
            {
                var tokens = inputContestsAndPass
                    .Split(":")
                    .ToArray();

                string contest = tokens[0];
                string pass = tokens[1];

                dictContestsAndPass[contest] = pass;
            }

            string input = string.Empty;

            while ((input = Console.ReadLine()) != "end of submissions")
            {
                var tokens = input.Split("=>").ToArray();

                string contest = tokens[0];
                string pass = tokens[1];
                string studentName = tokens[2];
                int points = int.Parse(tokens[3]);

                if (dictContestsAndPass.ContainsKey(contest) && dictContestsAndPass[contest] == pass)
                {
                    if (!dictContestsWithUserAndPoints.ContainsKey(contest))
                    {
                        dictContestsWithUserAndPoints[contest] = new Dictionary<string, int>();
                        dictContestsWithUserAndPoints[contest].Add(studentName, points);
                    }
                    else if (dictContestsWithUserAndPoints.ContainsKey(contest))
                    {
                        if (!dictContestsWithUserAndPoints[contest].ContainsKey(studentName))
                        {
                            dictContestsWithUserAndPoints[contest].Add(studentName, points);
                        }
                        else
                        {
                            if (dictContestsWithUserAndPoints[contest][studentName] < points)
                            {
                                dictContestsWithUserAndPoints[contest][studentName] = points;
                            }
                        }
                    }
                }
            }

            var allStudentAndPoints = new Dictionary<string, int>();

            foreach (var kvp in dictContestsWithUserAndPoints)
            {
                foreach (var students in kvp.Value)
                {
                    if (!allStudentAndPoints.ContainsKey(students.Key))
                    {
                        allStudentAndPoints[students.Key] = 0;
                    }

                    allStudentAndPoints[students.Key] += students.Value;
                }
            }

            foreach (var kvp in allStudentAndPoints.OrderByDescending(x => x.Value))
            {
                Console.WriteLine($"Best candidate is {kvp.Key} with total {kvp.Value} points.");
                break;
            }

            Console.WriteLine("Ranking:");

            foreach (var kvp in dictContestsWithUserAndPoints.OrderBy(x => x.Value.Keys))
            {
                Console.WriteLine($"{kvp.Value.Keys}");
            }
        }
    }
}
